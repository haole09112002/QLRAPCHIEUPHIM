using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.AD_GUI
{
    public partial class UC_LichChieu_AD : UserControl
    {
        //public UC_LichChieu_AD()
        //{
        //    InitializeComponent();
        //    SetGUI();
        //}
        //public void SetGUI()
        //{
        //    loadDGVLichChieu();
        //}
        //public void loadDGVLichChieu()
        //{
        //    dgvLichChieuDK.DataSource = LichChieuBLL.Instance.GetAllLichChieuView();
        //    dgvLichChieuDK.Columns["TenPhim"].Visible = false;
        //    dgvLichChieuDK.Columns["MaPhongChieu"].Visible = false;
        //    dgvLichChieuDK.Columns["MaKhungGioChieu"].Visible = false;
        //    dgvLichChieuDK.Columns["MaPhim"].HeaderText = "Mã Phim";
        //    dgvLichChieuDK.Columns["TenPhongChieu"].HeaderText = "Tên Phòng Chiếu";
        //    dgvLichChieuDK.Columns["TenKhungGio"].HeaderText = "Tên Khung Giờ";
        //    dgvLichChieuDK.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
        //    dgvLichChieuDK.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
        //    dgvLichChieuDK.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
        //}
        public delegate void MyDel(Control c);
        public MyDel d;
        DataTable dtDanhSachLichChieuDuKien = new DataTable();
        DataTable dtDanhSachLichChieuChinhThuc = new DataTable();
        public UC_LichChieu_AD()
        {
            InitializeComponent();
            SetDaTaTableDK();
            SetDaTaTableCT();
            ReloadDK();
            ReloadCT();
        }
        public void SetDaTaTableDK()
        {
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Khung Giờ Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Bắt Đầu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Kết Thúc");
            dtDanhSachLichChieuDuKien.Columns.Add("Ngày Chiếu");
        }
        public void ReloadDK(string TimKiem = "", string LoaiTimKiem = "")
        {
            dtDanhSachLichChieuDuKien.Rows.Clear();
            foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.GetLichChieuViewByTrangThai("1", TimKiem, LoaiTimKiem))
            {
                dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
            }
            dgvLichChieuDK.DataSource = dtDanhSachLichChieuDuKien;
            dgvLichChieuDK.Columns["Mã Phim"].Visible = false;
            dgvLichChieuDK.Columns["Mã Phòng Chiếu"].Visible = false;
            dgvLichChieuDK.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }
        public void SetDaTaTableCT()
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
        public void ReloadCT(string TimKiem = "", string LoaiTimKiem = "")
        {
            dtDanhSachLichChieuChinhThuc.Rows.Clear();
            foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.GetLichChieuViewByTrangThai("2", TimKiem, LoaiTimKiem))
            {
                dtDanhSachLichChieuChinhThuc.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
            }
            dgvLichChieuCT.DataSource = dtDanhSachLichChieuChinhThuc;
            dgvLichChieuCT.Columns["Mã Phim"].Visible = false;
            dgvLichChieuCT.Columns["Mã Phòng Chiếu"].Visible = false;
            dgvLichChieuCT.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ReloadDK(txtTimKiem.Text, cbbTimKiem.SelectedItem.ToString());
            ReloadCT(txtTimKiem.Text, cbbTimKiem.SelectedItem.ToString());
        }
    }
}
