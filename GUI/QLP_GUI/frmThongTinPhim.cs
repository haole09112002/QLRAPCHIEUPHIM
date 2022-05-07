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
        public string TheLoaiPhim { get; set; }
        public frmThongTinPhim(string MaPhim, string TheLoaiPhim)
        {
            this.MaPhim = MaPhim;
            this.TheLoaiPhim = TheLoaiPhim;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if(MaPhim != "")
            {
                PhimDTO phim = PhimBLL.Instance.GetPhimByMaPhim(MaPhim);
                txtTenPhim.Enabled = false;
                txtTenPhim.Text = phim.TenPhim;
                txtThoiLuong.Enabled = false;
                txtThoiLuong.Text = phim.ThoiLuong.ToString();
                cBQuocGia.Enabled = false;
                cBQuocGia.Text = phim.QuocGia;
                cBNamSanXuat.Enabled = false;
                cBNamSanXuat.Text = phim.NamSanXuat.Date.ToString();
                txtHangSanXuat.Enabled = false;
                txtHangSanXuat.Text = phim.TenHangPhim;
                cBDoTuoiXem.Enabled = false;
                cBDoTuoiXem.Text = phim.DoTuoiXem.ToString();
                txtTheLoai.Enabled = false;
                txtTheLoai.Text = TheLoaiPhim;
                rtxtNoiDung.Enabled = false;
                rtxtNoiDung.Text = phim.NoiDung;
                txtDienVienChinh.Enabled = false;
                txtDienVienChinh.Text = phim.DienVienChinh;
                txtDienVienPhu.Enabled = false;
                txtDienVienPhu.Text = phim.DienVienPhu;
                txtDaoDien.Enabled = false;
                txtDaoDien.Text = phim.DaoDien;
                if(phim.AnhPhim !=null)
                {
                    MemoryStream memoryStream = new MemoryStream(phim.AnhPhim);
                    if (memoryStream == null) MessageBox.Show("rong1");
                    if(pBAnhPhim.Image != null) pBAnhPhim.Image.Dispose();
                    pBAnhPhim.Image = Image.FromStream(memoryStream);

                }
                else if(phim.AnhPhim == null)
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
