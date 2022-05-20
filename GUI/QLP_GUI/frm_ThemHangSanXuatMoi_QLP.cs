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

namespace GUI.QLP_GUI
{
    public partial class frm_ThemHangSanXuatMoi_QLP : Form
    {
        public frm_ThemHangSanXuatMoi_QLP()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string txtTenHSX = txtTen.Text;
            string txtLinkHSX = txtLink.Text;
            HangSanXuatPhimBLL.Instance.LuuHangSanXuatPhim(txtTenHSX, txtLinkHSX);
            this.Close();
        }
    }
}
