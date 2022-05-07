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
    public partial class frm_DeXuatPhim : Form
    {
        public frm_DeXuatPhim()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBAnhPhim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pBAnhPhim.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhimDTO phim = new PhimDTO();
            phim.TenPhim = txtTenPhim.Text.ToString();
            phim.AnhPhim = PhimBLL.Instance.ChuyenAnhThanhMangByte(pBAnhPhim);
            phim.ThoiLuong = Convert.ToInt32(txtThoiLuong.Text.ToString());
            phim.QuocGia = cBQuocGia.SelectedItem.ToString();
            phim.NamSanXuat = dTPNamSanXuat.Value;
            phim.TenHangPhim = txtHangSanXuat.Text.ToString();
            phim.DoTuoiXem = Convert.ToInt32(cBDoTuoiXem.SelectedItem.ToString());
            phim.MaTheLoai = txtTheLoai.Text.ToString();
            phim.NoiDung = rtxtNoiDung.Text.ToString();
            phim.DienVienChinh = txtDienVienChinh.Text.ToString();
            phim.DienVienPhu = txtDienVienPhu.Text.ToString();
            phim.DaoDien = txtDaoDien.Text.ToString();
            PhimBLL.Instance.LuuPhim(phim);
            this.Close();
        }
    }
}
