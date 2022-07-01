using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.AD_GUI
{
    public partial class UC_PhieuNhapXuat : UserControl
    {
        DataTable dtDanhSachPhieuNhapXuat = new DataTable();
        DataTable dtChiTietPhieuNhapXuat = new DataTable();
        public UC_PhieuNhapXuat()
        {
            InitializeComponent();
            SetDataTable();
            Reload();
            rBTatCa.Checked = true;
        }
        public void SetDataTable()
        {
            dtDanhSachPhieuNhapXuat.Columns.Add("Mã Phiếu");
            dtDanhSachPhieuNhapXuat.Columns.Add("Tên Kho");
            dtDanhSachPhieuNhapXuat.Columns.Add("Tên Nhân Viên");
            dtDanhSachPhieuNhapXuat.Columns.Add("Loại Phiếu");
            dtDanhSachPhieuNhapXuat.Columns.Add("Ngày Lập Phiếu");
            dtChiTietPhieuNhapXuat.Columns.Add("Tên Sản Phẩm");
            dtChiTietPhieuNhapXuat.Columns.Add("Số Lượng");
            dtChiTietPhieuNhapXuat.Columns.Add("Đơn Vị Tính");
            //dtChiTietPhieuNhapXuatVatTu.Columns.Add("Tên Vật Tư");
            //dtChiTietPhieuNhapXuatVatTu.Columns.Add("Số Lượng");
            //dtChiTietPhieuNhapXuatVatTu.Columns.Add("Đơn Vị Tính");
        }
        public void Reload(string MaLoaiPhieu = "")
        {
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            foreach (PhieuDTO i in PhieuBLL.Instance.GetListPhieuByLoaiPhieu(MaLoaiPhieu))
            { 
                dtDanhSachPhieuNhapXuat.Rows.Add(i.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(i.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,LoaiPhieuBLL.Instance.GetLoaiPhieuByMaLoaiPhieu(i.MaLoaiPhieu).TenLoaiPhieu,i.NgayLapPhieu.ToShortDateString());
            }
            dgvDSPhieu.DataSource = dtDanhSachPhieuNhapXuat;
            dgvDSPhieu.Columns["Mã Phiếu"].Visible = false;
        }

        private void dGVDanhSachPhieuNhapXuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSPhieu.SelectedRows.Count == 1)
            {
                dtChiTietPhieuNhapXuat.Rows.Clear();
                string maPhieu = dgvDSPhieu.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString();
                if(ChiTietPhieuPhimBLL.Instance.GetListChiTietPhieuPhimByMaPhieu(maPhieu) != null)
                    foreach (ChiTietPhieuPhimDTO i in ChiTietPhieuPhimBLL.Instance.GetListChiTietPhieuPhimByMaPhieu(dgvDSPhieu.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString()))
                    {
                        dtChiTietPhieuNhapXuat.Rows.Add(PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim, i.SoLuong, i.DonViTinh);
                    }
               
                if (ChiTietPhieuVatTuBLL.Instance.GetListChiTietPhieuVatTuByMaPhieu(maPhieu) != null)
                    foreach (ChiTietPhieuVatTuDTO i in ChiTietPhieuVatTuBLL.Instance.GetListChiTietPhieuVatTuByMaPhieu(dgvDSPhieu.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString()))
                    {
                        dtChiTietPhieuNhapXuat.Rows.Add(VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu, i.SoLuong, i.DonViTinh);
                    }
                if (ChiTietPhieuThucAnBLL.Instance.GetListChiTietPhieuThucAnByMaPhieu(maPhieu) != null)
                    foreach (ChiTietPhieuThucAnDTO i in ChiTietPhieuThucAnBLL.Instance.GetListChiTietPhieuThucAnByMaPhieu(dgvDSPhieu.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString()))
                    {
                        dtChiTietPhieuNhapXuat.Rows.Add(ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn, i.SoLuong, i.DonViTinh);
                    }
                dgvChiTiet.DataSource = dtChiTietPhieuNhapXuat;
               // dgvChiTiet.DataSource = dtChiTietPhieuNhapXuatVatTu;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 hàng");
            }
        }

        private void rBTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTatCa.Checked == true)
            {
                Reload("");
            }
        }
        private void rBNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rBNhap.Checked == true)
            {
                Reload("LP001");
            }
        }

        private void rBXuat_CheckedChanged(object sender, EventArgs e)
        {
            if (rBXuat.Checked == true)
            {
                Reload("LP002");
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<string> MaPhieu = new List<string>();
            string TimKiem = txtTimKiem.Text;
            string LoaiTimKiem = "Tên Nhân Viên";
            string MaLoaiPhieu = "";
            if (rBNhap.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if (rBXuat.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if (cbbTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cbbTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuPhimBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            foreach (string i in ChiTietPhieuVatTuBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            foreach (string i in ChiTietPhieuThucAnBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            if (cBSapXep.SelectedItem.ToString() == "Tên Nhân Viên")
            {
                foreach (PhieuDTO phieu in PhieuBLL.Instance.SortPhieu(PhieuBLL.Instance.CompareTenNhanVien, MaPhieu, TimKiem, LoaiTimKiem))
                {
                    dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien,LoaiPhieuBLL.Instance.GetLoaiPhieuByMaLoaiPhieu(phieu.MaLoaiPhieu).TenLoaiPhieu ,phieu.NgayLapPhieu.ToShortDateString());
                }
            }
            if (cBSapXep.SelectedItem.ToString() == "Ngày Lập Phiếu")
            {
                foreach (PhieuDTO phieu in PhieuBLL.Instance.SortPhieu(PhieuBLL.Instance.CompareNgayLapPhieu, MaPhieu, TimKiem, LoaiTimKiem))
                {
                    dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien,LoaiPhieuBLL.Instance.GetLoaiPhieuByMaLoaiPhieu(phieu.MaLoaiPhieu).TenLoaiPhieu, phieu.NgayLapPhieu.ToShortDateString());
                }
            }
            dgvDSPhieu.DataSource = dtDanhSachPhieuNhapXuat;
            dgvDSPhieu.Columns["Mã Phiếu"].Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimKiem.Text, LoaiTimKiem = "";
            if (cbbTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cbbTimKiem.SelectedItem.ToString();
            }
            List<string> MaPhieu = new List<string>();
            string MaLoaiPhieu = "";
            if (rBNhap.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if (rBXuat.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if (cbbTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cbbTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuPhimBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            foreach (string i in ChiTietPhieuVatTuBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            foreach (string i in ChiTietPhieuThucAnBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            foreach (PhieuDTO phieu in PhieuBLL.Instance.GetListPhieuNow(MaPhieu, TimKiem, LoaiTimKiem))
            {
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, LoaiPhieuBLL.Instance.GetLoaiPhieuByMaLoaiPhieu(phieu.MaLoaiPhieu).TenLoaiPhieu, phieu.NgayLapPhieu.ToShortDateString()) ;
            }
            dgvDSPhieu.DataSource = dtDanhSachPhieuNhapXuat;
            dgvDSPhieu.Columns["Mã Phiếu"].Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}