using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_DanhSachLichChieuDuKien_QLP : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        DataTable dtDanhSachLichChieuDuKien = new DataTable();
        public UC_DanhSachLichChieuDuKien_QLP()
        {
            InitializeComponent();
            SetDaTaTable();
            Reload();
        }
        UC_TaoLichChieu_QLP ucTLC = new UC_TaoLichChieu_QLP();
        public void SetDaTaTable()
        {
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Khung Giờ Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Bắt Đầu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Kết Thúc");
            dtDanhSachLichChieuDuKien.Columns.Add("Ngày Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Trạng thái");
        }
        public void Reload(string TimKiem = "", string LoaiTimKiem = "")
        {
            dtDanhSachLichChieuDuKien.Rows.Clear();
            if (cbLichChieuBiTuChoi.Checked == true)
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.GetLichChieuViewByTrangThai("2", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString(), "Bị từ chối");
                }
            }
            foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.GetLichChieuViewByTrangThai("1", TimKiem, LoaiTimKiem))
            {
                dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString(), "Chờ duyệt");
            }
            dGVDanhSachLichChieuDuKien.DataSource = dtDanhSachLichChieuDuKien;
            dGVDanhSachLichChieuDuKien.Columns["Mã Phim"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Mã Khung Giờ Chiếu"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Trạng thái"].Visible = false;
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

        private void UC_DanhSachLichChieuDuKien_QLP_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cBTimKiem.SelectedIndex = -1;
            cBSapXep.SelectedIndex = -1;
            Reload();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string SapXep = "";
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
            dtDanhSachLichChieuDuKien.Rows.Clear();
            if (cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            if (SapXep == "Tên Phim")
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.SortLichChieu(LichChieuViewBLL.Instance.CompareTenPhim, "1", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
                }
            }
            if (SapXep == "Tên Phòng Chiếu")
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.SortLichChieu(LichChieuViewBLL.Instance.CompareTenPhongChieu, "1", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
                }
            }
            if (SapXep == "Ngày Chiếu")
            {
                foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.SortLichChieu(LichChieuViewBLL.Instance.CompareNgayChieu, "1", TimKiem, LoaiTimKiem))
                {
                    dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim, i.TenPhim, i.MaPhongChieu, i.TenPhongChieu, i.MaKhungGioChieu, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString(), i.NgayChieu.ToShortDateString());
                }
            }
            dGVDanhSachLichChieuDuKien.DataSource = dtDanhSachLichChieuDuKien;
            dGVDanhSachLichChieuDuKien.Columns["Mã Phim"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }

        private void cbLichChieuBiTuChoi_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
            if(cbLichChieuBiTuChoi.Checked == true)
            {
                dGVDanhSachLichChieuDuKien.Columns["Trạng thái"].Visible = true;
            }
            else
            {
                dGVDanhSachLichChieuDuKien.Columns["Trạng thái"].Visible = false;
            }
            cBTimKiem.SelectedIndex = -1;
            cBSapXep.SelectedIndex = -1;
            txtTimKiem.Text = "";
        }
    }
}
