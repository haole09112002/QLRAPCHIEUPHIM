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
        List<HopDongPhimViewDTO> dsPhimDaChonCanThem = new List<HopDongPhimViewDTO>();
        List<CBBItem> dsPhimLuaChon = new List<CBBItem>();

        public frmThemHopDongPhim(string maHopDong = "")
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
            dsPhimDaChonCanThem = HopDongBLL.Instance.GetListHopDongPhimViewByMaHopDong(maHopDong);
            dsPhimLuaChon = DeXuatBLL.Instance.GetCBBPhimDeXuat();
            foreach (CBBItem i in NhaCungCapBLL.Instance.GetCBBNhaCungCap("LNCC01"))
            {
                //if(NhaCungCapBLL.Instance.GetNCCByMaNCC(i.Value).MaLoaiNhaCungCap == NhaCungCapBLL.Instance.GetNCCByMaNCC(HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).MaNhaCungCap).MaLoaiNhaCungCap)
                {
                    cbTenCungCap.Items.Add(i);
                }
            }
            setGUI(maHopDong);
        }
        public void setGUI(string maHopDong)
        {
            txtMaNCC.Enabled = false;
            txtMaPhim.Enabled = false;
            txtTenPhim.Enabled = false;
            btnGiaHan.Visible = false;
            cbDonViTinh.Items.Add("Đĩa"); /////
            dgvPhim.DataSource = dsPhimLuaChon;
            if (maHopDong != "")        //  xem chi tiet
            {
                setEnable(false);
            
                dgvPhimDaThem.DataSource = dsPhimDaChonCanThem ;
                foreach (CBBItem i in cbTenCungCap.Items)
                {
                    if (i.Value == HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).MaNhaCungCap)
                        cbTenCungCap.SelectedItem = i;
                }
                gbxNoiDung.Location = new Point(28, 139);
                gbLuaChonPhim.Visible = false;
                btnGiaHan.Visible = true;
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btnLuu.Enabled = false;
                btnGiaHan.Enabled = true;
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
            btnXoa.Enabled= var;
        }

        private void cbTenCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = ((CBBItem)cbTenCungCap.SelectedItem).Value;
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            dtpBanQuyenBatDau.Enabled=true;
            dtpBanQuyenKetThuc.Enabled=true;
            btnThem.Visible = true;
            btnThem.Enabled = true;
            btnThem.Text = "Cập nhật";
            btnLuu.Enabled = true;
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPhim.SelectedRows.Count == 1)
            {
                txtMaPhim.Text = dgvPhim.SelectedRows[0].Cells["Value"].Value.ToString();
                txtTenPhim.Text = dgvPhim.SelectedRows[0].Cells["Text"].Value.ToString();
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
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (HopDongBLL.Instance.KiemTraDuLieuHopDongPhim(hopDongPhim) != "")
            {
                MessageBox.Show(HopDongBLL.Instance.KiemTraDuLieuHopDongPhim(hopDongPhim),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if(maHopDong == "")    //Them
                {
                    dsPhimDaChonCanThem.Add(HopDongBLL.Instance.GetHopDongPhimViewByHopDongPhimDTO(hopDongPhim));
                    var item = dsPhimLuaChon.Single(x => x.Value == txtMaPhim.Text);
                    dsPhimLuaChon.Remove(item);
                    RefreshTextBox();
                    cbDonViTinh.SelectedItem = cbDonViTinh.Items[0];
                }
                else
                {
                    dsPhimDaChonCanThem.Remove(HopDongBLL.Instance.GetHopDongPhimViewByHopDongPhimDTO(HopDongBLL.Instance.GetHopDongPhimByMaHopDongMaPhim(maHopDong, txtMaPhim.Text)));
                    var item = dsPhimDaChonCanThem.Single(x => x.MaPhim == txtMaPhim.Text);
                    dsPhimDaChonCanThem.Remove(item);
                    dsPhimDaChonCanThem.Add(HopDongBLL.Instance.GetHopDongPhimViewByHopDongPhimDTO(hopDongPhim));
                }
                ReLoadDGVPhimDaChon();
                ReLoadDGVPhimLuaChon();
            }
         
        }
        private void ReLoadDGVPhimDaChon()
        {
            dgvPhimDaThem.DataSource = null;
            dgvPhimDaThem.DataSource = dsPhimDaChonCanThem;
        }
        private void ReLoadDGVPhimLuaChon()
        {
            dgvPhim.DataSource = null;
            dgvPhim.DataSource = dsPhimLuaChon;
        }
        private void dgvPhimDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhimDaThem.SelectedRows.Count == 1)
                {
                    DsPhimDaChon(dsPhimDaChonCanThem);
                }
        }
        private void DsPhimDaChon(List<HopDongPhimViewDTO> list)
        {
            foreach (HopDongPhimViewDTO i in list)
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maHopDong == "")
            {
                if(dgvPhimDaThem.SelectedRows.Count == 1)
                {
                    var item = dsPhimDaChonCanThem.Single(x => x.MaPhim == txtMaPhim.Text);
                    dsPhimDaChonCanThem.Remove(item);
                    dsPhimLuaChon.Add(new CBBItem { Value = txtMaPhim.Text, Text = txtTenPhim.Text });
                    ReLoadDGVPhimDaChon();
                    ReLoadDGVPhimLuaChon();
                    RefreshTextBox();
                }
            }
        }
        private void RefreshTextBox()
        {
            txtGiaTien.Text = "";
            numUpDowSoLuong.Value  = 0;
            txtTenPhim.Text = "";
            txtMaPhim.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           

           
         
            DialogResult result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (maHopDong == "") // neu them moi
                {
                    HopDongDTO hopDong = new HopDongDTO
                    {
                        MaHopDong = "",
                        TenHopDong = "",
                        MaNhaCungCap = ((CBBItem)cbTenCungCap.SelectedItem).Value,
                        MaLoaiHopDong = "LHD001",
                        NgayKiKetHD = dtpThoiGianKiKet.Value
                    };
                    //--
                    HopDongBLL.Instance.ThemHopDong(hopDong);
                }

                //kiemtra
                
                foreach (HopDongPhimViewDTO i in dsPhimDaChonCanThem)
                {

                    HopDongBLL.Instance.AddUpdateHopDongPhim(ConvertHopDongPhimViewToDTO(i, maHopDong));
                }

                DialogResult result2 = MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public HopDongPhimDTO ConvertHopDongPhimViewToDTO(HopDongPhimViewDTO hdView, string maHopDong)
        {
            return   new HopDongPhimDTO
            { 
                MaHopDong = maHopDong,
                MaPhim = hdView.MaPhim,
                DonViTinh = hdView.DonViTinh,
                GiaTien = hdView.GiaTien,
                NgayBatDauBanQuyen = hdView.NgayBatDauBanQuyen,
                NgayKetThucBanQuyen = hdView.NgayBatDauBanQuyen,
                SoLuong = hdView.SoLuong
            };

        }
    }
}
