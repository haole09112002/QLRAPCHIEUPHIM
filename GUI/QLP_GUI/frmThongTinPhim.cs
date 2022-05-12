using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.QLP_GUI
{
    public partial class frmThongTinPhim : Form
    {
        public string MaPhim { get; set; }
        public frmThongTinPhim(string MaPhim)
        {
            this.MaPhim = MaPhim;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if(MaPhim != "")
            {
                List<string> DienVienChinh = new List<string>();
                List<string> DienVienPhu = new List<string>();
                List<string> DaoDien = new List<string>();
                List<string> MaDienVienDaoDien = new List<string>();
                PhimDTO phim = PhimBLL.Instance.GetPhimByMaPhim(MaPhim);
                DataTable dtDaoDien = new DataTable();
                DataTable dtDienVienChinh = new DataTable();
                DataTable dtDienVienPhu = new DataTable();
                txtTenPhim.Enabled = false;
                txtTenPhim.Text = phim.TenPhim;
                txtThoiLuong.Enabled = false;
                txtThoiLuong.Text = phim.ThoiLuong.ToString();
                txtQuocGia.Enabled = false;
                txtQuocGia.Text = phim.QuocGia;
                txtNamSanXuat.Enabled = false;
                txtNamSanXuat.Text = phim.NamSanXuat.Date.ToString();
                txtHangSanXuat.Enabled = false;
                txtHangSanXuat.Text = HangSanXuatPhimBLL.Instance.GetTenHSXPbyMaHSXP(phim.MaHangSanXuatPhim);
                txtDoTuoiXem.Enabled = false;
                txtDoTuoiXem.Text = phim.DoTuoiXem.ToString();
                txtTheLoai.Enabled = false;
                txtTheLoai.Text = TheLoaiPhimBLL.Instance.GetTenTLByMaTL(phim.MaTheLoai);
                rtxtNoiDung.Enabled = false;
                rtxtNoiDung.Text = phim.NoiDung;
                MaDienVienDaoDien = ChiTIetDienVienDaoDienPhimBLL.Instance.GetMaDVDDByMaPhimVaVaiTro(phim.MaPhim, "C");
                dtDienVienChinh.Columns.Add("Tên Diễn Viên Chính");
                foreach (string i in MaDienVienDaoDien)
                {
                    dtDienVienChinh.Rows.Add(DienVienDaoDienBLL.Instance.GetDVDDByMaDVDD(i).TenDienVienDaoDien);
                }
                dGVDienVienChinh.DataSource = dtDienVienChinh;
                MaDienVienDaoDien.Clear();
                MaDienVienDaoDien = ChiTIetDienVienDaoDienPhimBLL.Instance.GetMaDVDDByMaPhimVaVaiTro(phim.MaPhim, "P");
                dtDienVienPhu.Columns.Add("Tên Diễn Viên Phụ");
                foreach (string i in MaDienVienDaoDien)
                {
                    dtDienVienPhu.Rows.Add(DienVienDaoDienBLL.Instance.GetDVDDByMaDVDD(i).TenDienVienDaoDien);
                }
                dGVDienVienPhu.DataSource = dtDienVienPhu;
                MaDienVienDaoDien.Clear();
                MaDienVienDaoDien = ChiTIetDienVienDaoDienPhimBLL.Instance.GetMaDVDDByMaPhimVaVaiTro(phim.MaPhim, "D");
                dtDaoDien.Columns.Add("Tên Đạo Diễn");
                foreach (string i in MaDienVienDaoDien)
                {
                    dtDaoDien.Rows.Add(DienVienDaoDienBLL.Instance.GetDVDDByMaDVDD(i).TenDienVienDaoDien);
                }
                dGVDaoDien.DataSource = dtDaoDien;
                if (phim.AnhPhim != null)
                {
                    MemoryStream memoryStream = new MemoryStream(phim.AnhPhim);
                    if (memoryStream == null) MessageBox.Show("rong1");
                    if (pBAnhPhim.Image != null) pBAnhPhim.Image.Dispose();
                    pBAnhPhim.Image = Image.FromStream(memoryStream);

                }
                else if (phim.AnhPhim == null)
                {
                    pBAnhPhim.Image = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
