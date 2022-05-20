using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class frmThemNhanVien : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        string maNhanVienn { get; set; }
        public frmThemNhanVien(string maNv ="")
        {
            InitializeComponent();
            maNhanVienn = maNv;
            SetGUI(maNv);
           
        }
       
        public void SetGUI(string maNv)
        {   
            btnResetPass.Visible = false;
            txtMatKhau.Enabled = false;
            cbbChucVu.Items.AddRange(ChucVuBLL.Instance.GetCBBChucVU().ToArray());
            cbbChinhSach.Items.AddRange(ChinhSachBLL.Instance.GetCBBChinhSach().ToArray());
            if (maNv == "")
            {
                txtMatKhau.Text = "123456";
                btnChinhSua.Visible= false;
                
            }
            else
            {
                setEnable(false);
           
            NhanVienDTO nv=new NhanVienDTO();
            nv = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv);
            txtHoTen.Text = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).TenNhanVien;
            dtpNgaySinh.Value = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).NgaySinh;
            if (NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).GioiTinh)
            {
                radioButton1.Checked = true;
            }
            else radioButton2.Checked = true;
            txtDiaChi.Text = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).DiaChi;
            txtDienThoai.Text = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).SoDienThoai;
            foreach (CBBItem i in cbbChucVu.Items) {
                    if (i.Value == NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).MaChucVu)
                        cbbChucVu.SelectedItem = i;
                         }
                foreach (CBBItem i in cbbChinhSach.Items)
                {
                    if (i.Value == NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).MaChinhSach)
                        cbbChinhSach.SelectedItem = i;
                }
            txtCCCD.Text = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).CCCD1;
            txtTenTK.Text = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).TenNhanVien;
            txtMatKhau.Text = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(maNv).MatKhau;
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setEnable(bool var)
        {
            txtHoTen.Enabled = var;
            dtpNgaySinh.Enabled = var;
            radioButton1.Enabled = var;
            radioButton2.Enabled = var;
            txtDiaChi.Enabled = var;
            txtDienThoai.Enabled = var;
            cbbChucVu.Enabled = var;
            txtCCCD.Enabled = var;
            txtTenTK.Enabled = var;
            cbbChinhSach.Enabled = var;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            NhanVienDTO nhanVien = new NhanVienDTO
            {
                MaNhanVien = maNhanVienn,
                TenNhanVien = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radioButton1.Checked,
                SoDienThoai=txtDienThoai.Text,
                DiaChi =txtDiaChi.Text,
                CCCD1 =txtCCCD.Text,
                TenTaiKhoan = txtTenTK.Text,
                MatKhau =NhanVienBLL.Instance.MD5(txtMatKhau.Text),
                MaChinhSach =  ((CBBItem)cbbChinhSach.SelectedItem).Value,
                MaChucVu = ((CBBItem)cbbChucVu.SelectedItem).Value
            };
            NhanVienBLL.Instance.AddUpdateNhaCungCap(nhanVien);
            d();
            this.Close();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt lại mật khẩu?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                txtMatKhau.Text = "123456";
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            setEnable(true);
            btnChinhSua.Visible = true;
            btnResetPass.Visible = true;
        }
    }
}
