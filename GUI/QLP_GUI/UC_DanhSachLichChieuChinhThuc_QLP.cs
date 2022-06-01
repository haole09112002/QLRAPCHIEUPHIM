using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_DanhSachLichChieuChinhThuc_QLP : UserControl
    {
        DataTable dtDanhSachLichChieuChinhThuc = new DataTable();
        public UC_DanhSachLichChieuChinhThuc_QLP()
        {
            InitializeComponent();
            SetDaTaTable();
            Reload();
        }
        public void SetDaTaTable()
        {
            dtDanhSachLichChieuChinhThuc.Columns.Add("Mã Phim");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Tên Phim");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Mã Phòng Chiếu");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Tên Phòng Chiếu");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Mã Khung Giờ Chiếu");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Giờ Bắt Đầu");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Giờ Kết Thúc");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Ngày Chiếu");
        }
        public void Reload(string TimKiem = "", string LoaiTimKiem = "")
        {
            dtDanhSachLichChieuChinhThuc.Rows.Clear();
            foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.GetLichChieuViewByTrangThai("2",TimKiem,LoaiTimKiem))
            {
                dtDanhSachLichChieuChinhThuc.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
            }
            dGVDanhSachLichChieuChinhThuc.DataSource = dtDanhSachLichChieuChinhThuc;
            dGVDanhSachLichChieuChinhThuc.Columns["Mã Phim"].Visible = false;
            dGVDanhSachLichChieuChinhThuc.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVDanhSachLichChieuChinhThuc.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string LoaiTimKiem = "";
            if (cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn loại tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reload(txtTimKiem.Text, LoaiTimKiem);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            dtDanhSachLichChieuChinhThuc.Rows.Clear();
            string SapXep = "Tên Phim";
            string TimKiem = txtTimKiem.Text;
            string LoaiTimKiem = "Tên Phim";
            if (cBSapXep.SelectedIndex >= 0)
            {
                SapXep = cBSapXep.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn loại sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            if (SapXep == "Tên Phim")
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.SortLichChieu(LichChieuViewBLL.Instance.CompareTenPhim, "2", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuChinhThuc.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
                }
            }
            if (SapXep == "Tên Phòng Chiếu")
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.SortLichChieu(LichChieuViewBLL.Instance.CompareTenPhongChieu, "2", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuChinhThuc.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
                }
            }
            if (SapXep == "Ngày Chiếu")
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.SortLichChieu(LichChieuViewBLL.Instance.CompareNgayChieu, "2", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuChinhThuc.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
                }
            }
            dGVDanhSachLichChieuChinhThuc.DataSource = dtDanhSachLichChieuChinhThuc;
            dGVDanhSachLichChieuChinhThuc.Columns["Mã Phim"].Visible = false;
            dGVDanhSachLichChieuChinhThuc.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVDanhSachLichChieuChinhThuc.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }
    }
}
