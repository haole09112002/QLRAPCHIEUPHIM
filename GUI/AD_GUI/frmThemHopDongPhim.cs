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
        public delegate void Mydel(string maLoaiHD, string txt, string tc = "");
        public Mydel d { get; set; }
        private string maHopDong;
        private string maDeXuat;
        Panel pnLichSuGiaHan;
        UC_LichSuGiaHanHDPhim uc_LichSuGiaHan = new UC_LichSuGiaHanHDPhim();
        List<HopDongPhimViewDTO> dsPhimDaChon = new List<HopDongPhimViewDTO>();
        List<ChiTietDeXuatPhimViewDTO> dsPhimCanTaoHopDong = new List<ChiTietDeXuatPhimViewDTO>();

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
            ReLoadDGVPhimLuaChon();
            if (maHopDong != "")        //  xem chi tiet
            {
                txtTenHopDong.Text = HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).TenHopDong;
                ReLoadDGVPhimDaChon();
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
                btnLuu.Visible = false;
                btnGiaHan.Enabled = false;

                pnLichSuGiaHan = new Panel();
                pnLichSuGiaHan.Size = new Size(535, 316);
                pnLichSuGiaHan.Location = new Point(667, 107);
                pnLichSuGiaHan.Controls.Clear();
                pnLichSuGiaHan.Controls.Add(uc_LichSuGiaHan);
                uc_LichSuGiaHan.Dock = DockStyle.Fill;
                pnCenter.Controls.Add(pnLichSuGiaHan);
            }
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
                btnLuu.Visible = true;
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
            cbDonViTinh.SelectedItem = cbDonViTinh.Items[0].ToString();

            string MaPhim = txtMaPhim.Text;
            string DonViTinh = cbDonViTinh.SelectedItem.ToString();
            string GiaTien = txtGiaTien.Text;
            int SoLuong = Convert.ToInt32(numUpDowSoLuong.Value);
            DateTime NgayBatDauBanQuyen = dtpBanQuyenBatDau.Value;
            DateTime NgayKetThucBanQuyen = dtpBanQuyenKetThuc.Value;
            HopDongPhimDTO hopDongPhim = new HopDongPhimDTO();
           

            string result = HopDongPhimBLL.Instance.KiemTraDuLieuHopDongPhim(MaPhim, SoLuong, DonViTinh, GiaTien, NgayBatDauBanQuyen, NgayKetThucBanQuyen);
            if(result == null)
            {
                try
                {
                    hopDongPhim = new HopDongPhimDTO
                    {
                        MaPhim = MaPhim,
                        DonViTinh = DonViTinh,
                        GiaTien = Convert.ToDouble(GiaTien),
                        SoLuong = SoLuong,
                        NgayBatDauBanQuyen = NgayBatDauBanQuyen,
                        NgayKetThucBanQuyen = NgayKetThucBanQuyen,
                        MaHopDong = maHopDong,
                        PhienBan = "0"
                    };
                }
                catch (Exception){ }
                if (maHopDong == "")    //Them
                {
                    HopDongPhimViewDTO item1 = null;
                    ChiTietDeXuatPhimViewDTO item = null;
                    foreach (HopDongPhimViewDTO i in dsPhimDaChon)
                    {
                        if (i.MaPhim == MaPhim)
                            item1 = i;
                    }    
                    if(item1!= null)
                        dsPhimDaChon.Remove(item1);
                    foreach (ChiTietDeXuatPhimViewDTO j in dsPhimCanTaoHopDong)
                    {
                        if (j.MaPhim == MaPhim)
                            item = j;
                    }
                    if (item != null)
                        dsPhimCanTaoHopDong.Remove(item);
                    dsPhimDaChon.Add(HopDongPhimBLL.Instance.GetHopDongPhimViewByHopDongPhimDTO(hopDongPhim));
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
            else
            {
                MessageBox.Show(result,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnGiaHan.Enabled = true;
                }    
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
             
            if(cbTenCungCap.SelectedIndex >= 0)
            {
                HopDongDTO  hopDong = new HopDongDTO
                {
                    MaHopDong = maHopDong,
                    TenHopDong = txtTenHopDong.Text,
                    MaNhaCungCap = ((CBBItem)cbTenCungCap.SelectedItem).Value,
                    MaLoaiHopDong = "LHD001",
                    NgayKiKetHD = dtpThoiGianKiKet.Value
                };
                if (HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong, dsPhimDaChon.Count) == null)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (maHopDong == "")
                        {
                            HopDongBLL.Instance.ThemHopDong(hopDong);
                            foreach (ChiTietDeXuatPhimViewDTO i in HopDongPhimBLL.Instance.DSPhimCanThemHopDong())
                            {
                                foreach (HopDongPhimViewDTO j in dsPhimDaChon)
                                {
                                    if (i.MaPhim == j.MaPhim)
                                        ChiTietDeXuatPhimBLL.Instance.CapNhatTinhTrangDeXuat(i.MaPhim, i.MaDeXuat, "3");//
                                }
                            }
                        }
                        HopDongPhimBLL.Instance.AddUpdateHopDongPhim(dsPhimDaChon, maHopDong);
                        uc_LichSuGiaHan.LoadData(HopDongPhimBLL.Instance.GetLichSuGiaHan(maHopDong, dgvPhimDaThem.SelectedRows[0].Cells["MaPhim"].Value.ToString()));
                        ReLoadDGVPhimDaChon();
                        ReLoadDGVPhimLuaChon();
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        btnThem.Enabled = false;    
                        d("0", "");
                        //this.Close();
                    }
                }
                else
                    MessageBox.Show(HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong, dsPhimDaChon.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Dữ liệu Nhà cung cấp còn trống! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        private void dgvPhimDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maHopDong == "")
            {
                if (dgvPhimDaThem.SelectedRows.Count == 1)
                {
                    var item = dsPhimDaChon.Single(x => x.MaPhim == txtMaPhim.Text);
                    dsPhimDaChon.Remove(item);
                    dsPhimCanTaoHopDong.Add(new ChiTietDeXuatPhimViewDTO
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
            //dgvPhimDaThem.FirstDisplayedCell = null;
            //dgvPhimDaThem.ClearSelection();
            dgvPhimDaThem.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvPhimDaThem.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvPhimDaThem.Columns["NgayBatDauBanQuyen"].HeaderText = "Ngày bắt đầu bản quyền";
            dgvPhimDaThem.Columns["NgayKetThucBanQuyen"].HeaderText = "Ngày kết thúc bản quyền";
            dgvPhimDaThem.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvPhimDaThem.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvPhimDaThem.Columns["GiaTien"].HeaderText = "Giá tiền";

        }
        private void ReLoadDGVPhimLuaChon()
        {
            dgvPhim.DataSource = null;
            dgvPhim.DataSource = dsPhimCanTaoHopDong;
            dgvPhim.FirstDisplayedCell = null;
            dgvPhim.ClearSelection();
            dgvPhim.Columns["MaDeXuat"].Visible = false;
            dgvPhim.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvPhim.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvPhim.Columns["SoLuong"].HeaderText = "Số lượng";
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
