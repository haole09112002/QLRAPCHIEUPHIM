using BLL;
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
        public UC_DanhSachLichChieuDuKien_QLP()
        {
            InitializeComponent();
            Reload();
        }
        UC_TaoLichChieu_QLP ucTLC = new UC_TaoLichChieu_QLP();
        public void Reload()
        {
            dGVDanhSachLichChieuDuKien.DataSource = LichChieuBLL.Instance.GetAllLichChieuViews(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaPhim = dGVDanhSachLichChieuDuKien.SelectedRows[0].Cells["MaPhim"].Value.ToString();
            string MaPhongChieu = dGVDanhSachLichChieuDuKien.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
            string MaKhungGioChieu = dGVDanhSachLichChieuDuKien.SelectedRows[0].Cells["MaKhungGioChieu"].Value.ToString();
            LichChieuBLL.Instance.XoaLichChieu(MaPhim,MaKhungGioChieu,MaPhongChieu);
            Reload();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
        }
    }
}
