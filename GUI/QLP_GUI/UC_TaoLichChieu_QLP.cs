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

namespace GUI.QLP_GUI
{
    public partial class UC_TaoLichChieu_QLP : UserControl
    {
        DataTable dtDanhSachPhim = new DataTable();
        DataTable dtDanhSachPhongChieu = new DataTable();
        DataTable dtKhungGioChieu = new DataTable();
        public UC_TaoLichChieu_QLP()
        {
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void SetDataTable()
        {
            dtDanhSachPhim.Columns.Add("Mã Phim");
            dtDanhSachPhim.Columns.Add("Tên Phim");
            dtDanhSachPhongChieu.Columns.Add("Mã Phòng Chiếu");
            dtDanhSachPhongChieu.Columns.Add("Tên Phòng Chiếu");
            dtKhungGioChieu.Columns.Add("Mã Khung Giờ Chiếu");
            dtKhungGioChieu.Columns.Add("Giờ Bắt Đầu");
            dtKhungGioChieu.Columns.Add("Giờ Kết Thúc");
        }
        public void ReLoad()
        {
            foreach (PhimDTO i in PhimBLL.Instance.GetAllPhim())
            {
                dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim);
            }
            foreach(PhongChieuDTO i in PhongChieuBLL.Instance.GetAllPhongChieu())
            {
                dtDanhSachPhongChieu.Rows.Add(i.MaPhongChieu, i.TenPhong);
            }
            foreach(KhungGioChieuDTO i in KhungGioChieuBLL.Instance.GetAllKhungGioChieu())
            {
                dtKhungGioChieu.Rows.Add(i.MaKhungGioChieu, i.TGBatDau.ToShortTimeString(), i.TGKetThuc.ToShortTimeString());
            }
            dGVDanhSachPhim.DataSource = dtDanhSachPhim;
            dGVDanhSachPhim.Columns["Mã Phim"].Visible = false;
            dGVDanhSachPC.DataSource = dtDanhSachPhongChieu;
            dGVDanhSachPC.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVKhungGioChieu.DataSource = dtKhungGioChieu;
            dGVKhungGioChieu.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
