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
using DTO;

namespace GUI.QLVT_GUI
{
    public partial class FrmDoiMatKhauQLVT : Form
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        public FrmDoiMatKhauQLVT(NhanVienDTO nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
            SetGUI();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != "" || txtMatKhauMoi.Text != "" || txtXacNhanMatKhau.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Thông tin chưa lưu, có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        public void SetGUI()
        {
            lblValidatedXacNhanMK.Visible = false;
            lblValidatedMatKhauCu.Visible = false;
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtXacNhanMatKhau.Text == "")
            {
                btnLuu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                int checkMatKhau = NhanVienBLL.Instance.KiemTraDangNhap(nhanVien.TenTaiKhoan,txtMatKhauCu.Text);
                if ((checkMatKhau != 0 ) && (txtMatKhauMoi.Text == txtXacNhanMatKhau.Text))
                {
                    nhanVien.MatKhau = NhanVienBLL.Instance.MD5(txtMatKhauMoi.Text);
                    NhanVienBLL.Instance.AddUpdateNhanVien(nhanVien);
                    MessageBox.Show("Thay Đổi Thành Công");
                    this.Close();
                }
                else
                {
                    lblValidatedMatKhauCu.Visible = true;
                }
            }
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            if((txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtXacNhanMatKhau.Text == "") 
                || (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text))
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
            if(txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                lblValidatedXacNhanMK.Visible = true;
            }
            else
            {
                lblValidatedXacNhanMK.Visible = false;
            }
        }
    }
}
