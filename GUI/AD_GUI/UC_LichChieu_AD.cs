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
        public UC_LichChieu_AD()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            loadDGVLichChieu();
        }
        public void loadDGVLichChieu()
        {
            dgvLichChieuDK.DataSource = LichChieuBLL.Instance.GetAllLichChieuView();
            dgvLichChieuDK.Columns["TenPhim"].Visible = false;
            dgvLichChieuDK.Columns["MaPhongChieu"].Visible = false;
            dgvLichChieuDK.Columns["MaKhungGioChieu"].Visible = false;
            dgvLichChieuDK.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgvLichChieuDK.Columns["TenPhongChieu"].HeaderText = "Tên Phòng Chiếu";
            dgvLichChieuDK.Columns["TenKhungGio"].HeaderText = "Tên Khung Giờ";
            dgvLichChieuDK.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dgvLichChieuDK.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dgvLichChieuDK.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvLichChieuDK.DataSource = LichChieuBLL.Instance.TimTheoMaPhim(txtTimKiem.Text);
        }

        private void rbDK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDK.Checked == true)
            {
                loadDGVLichChieu();
            }
        }
    }
}
