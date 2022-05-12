using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class frmThemHopDongPhim : Form
    {
    
        private string maHopDong;
        private string maDeXuat;
        Panel pnLichSuGiaHan;
        UC_LichSuGiaHanHDPhim uc_LichSuGiaHan = new UC_LichSuGiaHanHDPhim();
        List<HopDongPhimViewDTO> dsPhimDaChon = new List<HopDongPhimViewDTO>();
        List<PhimCanTaoHopDongDTO> dsPhimCanTaoHopDong = new List<PhimCanTaoHopDongDTO>();

        public frmThemHopDongPhim(string maHopDong = "")
        {
            InitializeComponent();
           
            this.maHopDong = maHopDong;
            setGUI(maHopDong);
           
            
            
           
        }
        public void setGUI(string maHopDong)
        {
            
            
            dsPhimDaChon = HopDongPhimBLL.Instance.GetListHopDongPhimViewByMaHopDong(maHopDong);
            dsPhimCanTaoHopDong = HopDongPhimBLL.Instance.DSPhimCanThemHopDong();
            foreach (CBBItem i in NhaCungCapBLL.Instance.GetCBBNhaCungCap("LNCC01"))
            {
                cbTenCungCap.Items.Add(i);
            }
            txtMaNCC.Enabled = false;
            txtMaPhim.Enabled = false;
            txtTenPhim.Enabled = false;
            btnGiaHan.Visible = false;
            cbDonViTinh.Items.AddRange(HopDongPhimBLL.Instance.GetAllDonViTinh().ToArray());
            dgvPhim.DataSource = dsPhimCanTaoHopDong;
            if (maHopDong != "")        //  xem chi tiet
            {
                txtTenHopDong.Text = HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).TenHopDong;
                dgvPhimDaThem.DataSource = dsPhimDaChon;
                foreach (CBBItem i in cbTenCungCap.Items)
                {
                    if (i.Value == HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).MaNhaCungCap)
                        cbTenCungCap.SelectedItem = i;
                }
                txtTenHopDong.Enabled = false;
                label14.Text = "*Kích chọn để xem";
                label14.ForeColor = Color.Red;
                setEnable(false);
                gbxNoiDung.Location = new Point(3, 107);
                gbLuaChonPhim.Visible = false;
                btnGiaHan.Visible = true;
                btnThem.Visible = false;
                btnLuu.Enabled = false;
                btnGiaHan.Enabled = true;

                pnLichSuGiaHan = new Panel();
                pnLichSuGiaHan.Size = new Size(535, 316);
                pnLichSuGiaHan.Location = new Point(667, 107);
                pnLichSuGiaHan.Controls.Clear();
                pnLichSuGiaHan.Controls.Add(uc_LichSuGiaHan);
                uc_LichSuGiaHan.Dock = DockStyle.Fill;
                pnCenter.Controls.Add(pnLichSuGiaHan);
                dgvPhimDaThem.Columns["MaPhim"].HeaderText = "Mã phim";
                dgvPhimDaThem.Columns["TenPhim"].HeaderText = "Tên phim";
                dgvPhimDaThem.Columns["NgayBatDauBanQuyen"].HeaderText = "Ngày bắt đầu bản quyền";
                dgvPhimDaThem.Columns["NgayKetThucBanQuyen"].HeaderText = "Ngày kết thúc bản quyền";
                dgvPhimDaThem.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dgvPhimDaThem.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvPhimDaThem.Columns["GiaTien"].HeaderText = "Giá tiền";
            }

            dgvPhim.Columns["MaDeXuat"].Visible = false;
            dgvPhim.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvPhim.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvPhim.Columns["SoLuong"].HeaderText = "Số lượng";

          
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát!, Dữ liệu chưa được lưu lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }
     
        private void cbTenCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = ((CBBItem)cbTenCungCap.SelectedItem).Value;
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if(dgvPhimDaThem.SelectedRows.Count == 1)
            {
                dtpBanQuyenBatDau.Enabled = false;
                dtpBanQuyenKetThuc.Enabled = true;
                dtpBanQuyenBatDau.Value = dtpBanQuyenKetThuc.Value.AddDays(1);
                txtGiaTien.Enabled = true;
                btnThem.Visible = true;
                btnThem.Enabled = true;
                btnThem.Text = "Cập nhật";
                btnLuu.Enabled = true;
            }    
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPhim.SelectedRows.Count == 1)
            {
                maDeXuat = dgvPhim.SelectedRows[0].Cells["MaDeXuat"].Value.ToString();
                txtMaPhim.Text = dgvPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString();
                txtTenPhim.Text = dgvPhim.SelectedRows[0].Cells["TenPhim"].Value.ToString();
                cbDonViTinh.SelectedItem = dgvPhim.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                txtGiaTien.Text = "";
                numUpDowSoLuong.Value = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HopDongPhimDTO hopDongPhim = new HopDongPhimDTO();
            cbDonViTinh.SelectedItem = cbDonViTinh.Items[0].ToString();
            try
            {
                hopDongPhim = new HopDongPhimDTO
                {
                    MaPhim = txtMaPhim.Text,
                    DonViTinh = cbDonViTinh.SelectedItem.ToString(),
                    GiaTien = Convert.ToDouble(txtGiaTien.Text),
                    SoLuong = Convert.ToInt32(numUpDowSoLuong.Value),
                    NgayBatDauBanQuyen = dtpBanQuyenBatDau.Value,
                    NgayKetThucBanQuyen = dtpBanQuyenKetThuc.Value,
                    MaHopDong = maHopDong,
                    PhienBan = "0"
                };
            }
            catch (Exception){}
            if (HopDongPhimBLL.Instance.KiemTraDuLieuHopDongPhim(hopDongPhim) != null)
            {
                MessageBox.Show(HopDongPhimBLL.Instance.KiemTraDuLieuHopDongPhim(hopDongPhim),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(maHopDong == "")    //Them
                {
                    dsPhimDaChon.Add(HopDongPhimBLL.Instance.GetHopDongPhimViewByHopDongPhimDTO(hopDongPhim));
                    var item = dsPhimCanTaoHopDong.Single(x => x.MaPhim == txtMaPhim.Text);
                    dsPhimCanTaoHopDong.Remove(item);
                    RefreshTextBox();
                    cbDonViTinh.SelectedItem = cbDonViTinh.Items[0];
                }
                else // gia han
                {
                    var item = dsPhimDaChon.Single(x => x.MaPhim == txtMaPhim.Text);
                    dsPhimDaChon.Remove(item);
                    dsPhimDaChon.Add(HopDongPhimBLL.Instance.GetHopDongPhimViewByHopDongPhimDTO(hopDongPhim));
                }
                ReLoadDGVPhimDaChon();
                ReLoadDGVPhimLuaChon();
            }
        }
      
        private void dgvPhimDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhimDaThem.SelectedRows.Count == 1)
            {
                foreach (HopDongPhimViewDTO i in dsPhimDaChon)
                {
                    if (i.MaPhim == dgvPhimDaThem.SelectedRows[0].Cells["MaPhim"].Value.ToString())
                    {
                        txtGiaTien.Text = i.GiaTien.ToString();
                        numUpDowSoLuong.Value = i.SoLuong;
                        txtTenPhim.Text = i.TenPhim.ToString();
                        txtMaPhim.Text = i.MaPhim.ToString();
                        dtpBanQuyenBatDau.Value = i.NgayBatDauBanQuyen;
                        dtpBanQuyenKetThuc.Value = i.NgayKetThucBanQuyen;
                        cbDonViTinh.SelectedItem = i.DonViTinh;
                    }
                }
                if(maHopDong != "")
                {
                    uc_LichSuGiaHan.LoadData(HopDongPhimBLL.Instance.GetLichSuGiaHan(maHopDong, dgvPhimDaThem.SelectedRows[0].Cells["MaPhim"].Value.ToString()));
                }    
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            HopDongDTO hopDong = new HopDongDTO();
            if(cbTenCungCap.SelectedIndex >= 0)
            {
                hopDong = new HopDongDTO
                {
                    MaHopDong = maHopDong,
                    TenHopDong = txtTenHopDong.Text,
                    MaNhaCungCap = ((CBBItem)cbTenCungCap.SelectedItem).Value,
                    MaLoaiHopDong = "LHD001",
                    NgayKiKetHD = dtpThoiGianKiKet.Value
                };
            }
            else
                MessageBox.Show("Dữ liệu Nhà cung cấp còn trống! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            if(dsPhimDaChon.Count <= 0)
            {
                MessageBox.Show("Danh sách phim trong hợp đồng trống! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            if(HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong) != null)
                MessageBox.Show(HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dsPhimDaChon.Count > 0 && HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong) == null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (maHopDong == "")
                    {
                        HopDongBLL.Instance.ThemHopDong(hopDong);
                        foreach(PhimCanTaoHopDongDTO i in HopDongPhimBLL.Instance.DSPhimCanThemHopDong())
                        {
                            foreach(HopDongPhimViewDTO j in dsPhimDaChon)
                            {
                                if(i.MaPhim == j.MaPhim)
                                    DeXuatPhimBLL.Instance.CapNhatTinhTrangDeXuat(i.MaPhim, i.MaDeXuat, "3");//
                            }    
                        }    
                    }    
                    HopDongPhimBLL.Instance.AddUpdateHopDongPhim(dsPhimDaChon, maHopDong);
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuu.Enabled = false;
                }
            }
        }
        private void dgvPhimDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maHopDong == "")
            {
                if (dgvPhimDaThem.SelectedRows.Count == 1)
                {
                    var item = dsPhimDaChon.Single(x => x.MaPhim == txtMaPhim.Text);
                    dsPhimDaChon.Remove(item);
                    dsPhimCanTaoHopDong.Add(new PhimCanTaoHopDongDTO
                    {
                        MaDeXuat = maDeXuat,
                        MaPhim = txtMaPhim.Text,
                        TenPhim = txtTenPhim.Text,
                        SoLuong = Convert.ToInt32(numUpDowSoLuong.Value),
                        DonViTinh = cbDonViTinh.SelectedItem.ToString()
                    });
                    ReLoadDGVPhimDaChon();
                    ReLoadDGVPhimLuaChon();
                    RefreshTextBox();
                }
            }
        }
        private void ReLoadDGVPhimDaChon()
        {
            dgvPhimDaThem.DataSource = null;
            dgvPhimDaThem.DataSource = dsPhimDaChon;
        }
        private void ReLoadDGVPhimLuaChon()
        {
            dgvPhim.DataSource = null;
            dgvPhim.DataSource = dsPhimCanTaoHopDong;
        }

        private void RefreshTextBox()
        {
            txtGiaTien.Text = "";
            numUpDowSoLuong.Value = 0;
            txtTenPhim.Text = "";
            txtMaPhim.Text = "";
        }
        private void setEnable(bool var)
        {
            cbTenCungCap.Enabled = var;
            dtpThoiGianKiKet.Enabled = var;

            numUpDowSoLuong.Enabled = var;
            cbDonViTinh.Enabled = var;
            txtGiaTien.Enabled = var;

            dtpBanQuyenBatDau.Enabled = var;
            dtpBanQuyenKetThuc.Enabled = var;
            btnThem.Enabled = var;
        }

    }
}
