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
            dtDanhSachLichChieuChinhThuc.Columns.Add("Tên Phim");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Tên Phòng Chiếu");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Giờ Bắt Đầu");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Giờ Kết Thúc");
            dtDanhSachLichChieuChinhThuc.Columns.Add("Ngày Chiếu");
        }
        public void Reload()
        {
            foreach (LichChieuDTO i in LichChieuBLL.Instance.GetListLichChieuByTrangThai(true))
            {
                dtDanhSachLichChieuChinhThuc.Rows.Add(PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim, PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong, KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau, KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc, i.NgayChieu.ToShortDateString());
            }
            dGVDanhSachLichChieuChinhThuc.DataSource = dtDanhSachLichChieuChinhThuc;
        }
    }
}
