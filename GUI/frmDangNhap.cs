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
            setTxtLogin();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text != "Nhập mật khẩu..." && txtTenTaiKhoan.Text != "Nhập tài khoản...")
            {
                int result = NhanVienBLL.Instance.KiemTraDangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text);
                if (result == 0)
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == -1)
                    MessageBox.Show("Tài khoản chưa tồn tại! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == -2)
                    MessageBox.Show("Tài khoản này đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == 3)
                {
                    frmDashboard_AD frmDashboard_AD = new frmDashboard_AD(NhanVienBLL.Instance.GetNhanVienByTenTaiKhoan(txtTenTaiKhoan.Text));
                    frmDashboard_AD.ShowDialog();
                }
                if (result == 2)
                {
                    FrmDashboardQLVT frmDashboardQLVT = new FrmDashboardQLVT(NhanVienBLL.Instance.GetNhanVienByTenTaiKhoan(txtTenTaiKhoan.Text));
                    frmDashboardQLVT.ShowDialog();
                    
                }
                if (result == 1)
                {
                    frm_QLP frm_QLP = new frm_QLP(NhanVienBLL.Instance.GetNhanVienByTenTaiKhoan(txtTenTaiKhoan.Text));
                    frm_QLP.ShowDialog();
                }
                if (result > 0)
                {
                    this.Hide();
                }
            }

         

        }


        private void pbxExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setTxtLogin();
            
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
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTenTaiKhoan.Text.Equals("Nhập tài khoản...") == true)
            {
                txtTenTaiKhoan.Text = "";
                txtTenTaiKhoan.ForeColor = Color.Black;
            }
        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMatKhau.Text.Equals("Nhập mật khẩu...") == true)
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }
        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMatKhau.Text.Equals(null) == true || txtMatKhau.Text.Equals("") == true)
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Nhập mật khẩu...";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTenTaiKhoan.Text.Equals(null) == true || txtTenTaiKhoan.Text.Equals("") == true)
            {
                txtTenTaiKhoan.Text = "Nhập tài khoản...";
                txtTenTaiKhoan.ForeColor = Color.Gray;
            }
        }
      
        private void setTxtLogin()
        {
            txtMatKhau.PasswordChar = '\0';
            txtTenTaiKhoan.Text = "Nhập tài khoản...";
            txtMatKhau.Text = "Nhập mật khẩu...";
            txtTenTaiKhoan.ForeColor = Color.Gray;
            txtMatKhau.ForeColor = Color.Gray;
        }

        private void txtTenTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "Nhập tài khoản...")
            {
                txtTenTaiKhoan.Focus();
                txtTenTaiKhoan.SelectionStart = 0;
            }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "Nhập mật khẩu...")
            {
                txtMatKhau.Focus();
                txtMatKhau.SelectionStart = 0;
            }    
            
        }
    }
}
