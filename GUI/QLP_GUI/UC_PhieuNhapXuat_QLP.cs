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

namespace GUI.QLP_GUI
{
    public partial class UC_PhieuNhapXuat_QLP : UserControl
    {
        DataTable dtDanhSachPhieuNhapXuat = new DataTable();
        DataTable dtChiTietPhieuNhapXuat = new DataTable();
        public UC_PhieuNhapXuat_QLP()
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
            dtDanhSachPhieuNhapXuat.Columns.Add("Ngày Lập Phiếu");
            dtChiTietPhieuNhapXuat.Columns.Add("Tên Phim");
            dtChiTietPhieuNhapXuat.Columns.Add("Số Lượng");
            dtChiTietPhieuNhapXuat.Columns.Add("Đơn Vị Tính");
        }
        public void Reload(string MaLoaiPhieu = "")
        {
            PhieuDTO phieu = new PhieuDTO();
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            foreach(string i in ChiTietPhieuPhimBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                phieu = PhieuBLL.Instance.GetPhieuByMaPhieu(i);
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
            }
            dGVDanhSachPhieuNhapXuat.DataSource = dtDanhSachPhieuNhapXuat;
            dGVDanhSachPhieuNhapXuat.Columns["Mã Phiếu"].Visible = false;
        }

        private void dGVDanhSachPhieuNhapXuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGVDanhSachPhieuNhapXuat.SelectedRows.Count == 1)
            {
                dtChiTietPhieuNhapXuat.Rows.Clear();
                foreach(ChiTietPhieuPhimDTO i in ChiTietPhieuPhimBLL.Instance.GetListChiTietPhieuPhimByMaPhieu(dGVDanhSachPhieuNhapXuat.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString()))
                {
                    dtChiTietPhieuNhapXuat.Rows.Add(PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim, i.SoLuong, i.DonViTinh);
                }
                dGVChiTietPhieuNhapXuat.DataSource = dtChiTietPhieuNhapXuat;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 hàng");
            }
        }

        private void rBTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(rBTatCa.Checked == true)
            {
                Reload("");
                txtTimKiem.Text = "";
                cBTimKiem.SelectedIndex = -1;
                cBSapXep.SelectedIndex = -1;
            }
        }

        private void rBNhap_CheckedChanged(object sender, EventArgs e)
        {
            if(rBNhap.Checked == true)
            {
                Reload("LP001");
                txtTimKiem.Text = "";
                cBTimKiem.SelectedIndex = -1;
                cBSapXep.SelectedIndex = -1;
            }
        }

        private void rBXuat_CheckedChanged(object sender, EventArgs e)
        {
            if(rBXuat.Checked == true)
            {
                Reload("LP002");
                txtTimKiem.Text = "";
                cBTimKiem.SelectedIndex = -1;
                cBSapXep.SelectedIndex = -1;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<string> MaPhieu = new List<string>();
            string TimKiem = txtTimKiem.Text;
            string LoaiTimKiem = "Tên Nhân Viên";
            string MaLoaiPhieu = "";
            if(rBNhap.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if(rBXuat.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if(cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuPhimBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            if(cBSapXep.SelectedItem.ToString() == "Tên Nhân Viên")
            {
                foreach (PhieuDTO phieu in PhieuBLL.Instance.SortPhieu(PhieuBLL.Instance.CompareTenNhanVien, MaPhieu, TimKiem, LoaiTimKiem))
                {
                    dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
                }
            }
            if(cBSapXep.SelectedItem.ToString() == "Ngày Lập Phiếu")
            {
                foreach (PhieuDTO phieu in PhieuBLL.Instance.SortPhieu(PhieuBLL.Instance.CompareNgayLapPhieu, MaPhieu, TimKiem, LoaiTimKiem))
                {
                    dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
                }
            }
            dGVDanhSachPhieuNhapXuat.DataSource = dtDanhSachPhieuNhapXuat;
            dGVDanhSachPhieuNhapXuat.Columns["Mã Phiếu"].Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimKiem.Text, LoaiTimKiem = "";
            if(cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
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
            if (cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuPhimBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            foreach (PhieuDTO phieu in PhieuBLL.Instance.GetListPhieuNow(MaPhieu,TimKiem,LoaiTimKiem))
            {
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
            }
            dGVDanhSachPhieuNhapXuat.DataSource = dtDanhSachPhieuNhapXuat;
            dGVDanhSachPhieuNhapXuat.Columns["Mã Phiếu"].Visible = false;
        }
    }
}
