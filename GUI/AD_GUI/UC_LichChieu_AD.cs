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
        DataTable dtDanhSachLichChieuDuKien = new DataTable();
        DataTable dtDanhSachLichChieuChinhThuc = new DataTable();
        LichChieuDTO lichChieu =new LichChieuDTO();
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
            if (dgvLichChieuDK.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn phim");
            }
            else
            {
                string MaPhim = dgvLichChieuDK.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
                string MaKhungGioChieu = dgvLichChieuDK.SelectedRows[0].Cells["Mã Khung Giờ Chiếu"].Value.ToString();
                string MaPhongChieu = dgvLichChieuDK.SelectedRows[0].Cells["Mã Phòng Chiếu"].Value.ToString();
                DateTime NgayChieu = Convert.ToDateTime(dgvLichChieuDK.SelectedRows[0].Cells["Ngày Chiếu"].Value);
                lichChieu = new LichChieuDTO
                {
                    MaPhim = MaPhim,
                    MaKhungGioChieu = MaKhungGioChieu,
                    MaPhongChieu = MaPhongChieu,
                    NgayChieu = NgayChieu
                };
                {
                    foreach (DataGridViewRow i in dgvLichChieuDK.SelectedRows)
                    {
                        if (LichChieuBLL.Instance.KTLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, NgayChieu) == "")
                        {
                            LichChieuBLL.Instance.CapNhatLichChieu(lichChieu,"2");
                            ReloadDK();
                            ReloadCT();
                        }
                        else
                        {
                            MessageBox.Show(LichChieuBLL.Instance.KTLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, NgayChieu));
                        }
                    }
                }
            }
        }
        private void btnTimKiemDK_Click(object sender, EventArgs e)
        {
            ReloadDK(txtTimKiemDK.Text, cbbTimKiemDK.SelectedItem.ToString());
        }
        private void btnTimKiemCT_Click(object sender, EventArgs e)
        {
            ReloadCT(txtTimKiemCT.Text, cbbTimKiemCT.SelectedItem.ToString());
        }
        private void btnKhongDongY_Click(object sender, EventArgs e)
        {
            if (dgvLichChieuDK.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn phim");
            }
            else
            {
                string MaPhim = dgvLichChieuDK.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
                string MaKhungGioChieu = dgvLichChieuDK.SelectedRows[0].Cells["Mã Khung Giờ Chiếu"].Value.ToString();
                string MaPhongChieu = dgvLichChieuDK.SelectedRows[0].Cells["Mã Phòng Chiếu"].Value.ToString();
                DateTime NgayChieu = Convert.ToDateTime(dgvLichChieuDK.SelectedRows[0].Cells["Ngày Chiếu"].Value);
                lichChieu = new LichChieuDTO
                {
                    MaPhim = MaPhim,
                    MaKhungGioChieu = MaKhungGioChieu,
                    MaPhongChieu = MaPhongChieu,
                    NgayChieu = NgayChieu
                };
                {
                    foreach (DataGridViewRow i in dgvLichChieuDK.SelectedRows)
                    {
                        if (LichChieuBLL.Instance.KTLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, NgayChieu) == "")
                        {
                            LichChieuBLL.Instance.CapNhatLichChieu(lichChieu, "0");
                            ReloadDK();
                            ReloadCT();
                        }
                    }
                }
            }
        }
    }
}