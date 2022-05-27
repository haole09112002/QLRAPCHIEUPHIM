using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using GUI.QLP_GUI;
using GUI.AD_GUI;
using GUI.QLVT_GUI;

using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            int result = NhanVienBLL.Instance.KiemTraDangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text);
            if (result == 0)
                MessageBox.Show("Sai tài khoản hoặc mật khẩu! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == -1)
                MessageBox.Show("Tài khoản chưa tồn tại! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == 3)
            {
                frmDashboard_AD frmDashboard_AD = new frmDashboard_AD();
                frmDashboard_AD.Show();
            }
            if (result == 2)
            {
                FrmDashboardQLVT frmDashboardQLVT = new FrmDashboardQLVT(NhanVienBLL.Instance.GetNhanVienByTenTaiKhoan(txtTenTaiKhoan.Text));
                frmDashboardQLVT.Show();
            }
            if (result == 1)
            {
                frm_QLP frm_QLP = new frm_QLP(NhanVienBLL.Instance.GetNhanVienByTenTaiKhoan(txtTenTaiKhoan.Text));
                frm_QLP.Show();
            }
            if(result >0)
            {
                this.Hide();
            }

        }

        
        private void pbxExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtTenTaiKhoan.Text = "";
        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar == '*')
            {
                pictureBoxShowPass.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }    
        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pictureBoxHidePass.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
