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
    public partial class frm_ThemMoiDienVienDaoDien_QLP : Form
    {
        public frm_ThemMoiDienVienDaoDien_QLP()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string TenDienVienDaoDien = txtTen.Text;
            string Link = txtLink.Text;
            DienVienDaoDienBLL.Instance.LuuDienVienDaoDien(TenDienVienDaoDien, Link);
            this.Close();
        }
    }
}
