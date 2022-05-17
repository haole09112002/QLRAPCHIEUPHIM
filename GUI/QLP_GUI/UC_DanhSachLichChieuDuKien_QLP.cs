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
            btnChinhSua.Hide();
            btnXoa.Hide();
        }
        UC_TaoLichChieu_QLP ucTLC = new UC_TaoLichChieu_QLP();
        public void SetDaTaTable()
        {
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Bắt Đầu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Kết Thúc"); 
            dtDanhSachLichChieuDuKien.Columns.Add("Ngày Chiếu"); 
        }
        public void Reload()
        {
            foreach (LichChieuDTO i in LichChieuBLL.Instance.GetListLichChieuByTrangThai(false))
            {
                dtDanhSachLichChieuDuKien.Rows.Add(PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim, PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong, KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau,KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc,i.NgayChieu.ToShortDateString());
            }
            dGVDanhSachLichChieuDuKien.DataSource = dtDanhSachLichChieuDuKien;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
        }
    }
}
