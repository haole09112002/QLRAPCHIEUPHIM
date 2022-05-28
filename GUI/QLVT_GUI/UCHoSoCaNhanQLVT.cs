
using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class UCHoSoCaNhanQLVT : UserControl
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        DataTable dtListCaLam = new DataTable();
        public UCHoSoCaNhanQLVT(NhanVienDTO nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
            SetDataTable();
            Reload();
        }
        public void Reload()
        {
            if (nhanVien.GioiTinh == true)
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            lblChucVu.Text = ChucVuBLL.Instance.GetChucVuByMaChucVu(nhanVien.MaChucVu).TenChucVu;
            txtTen.Text = nhanVien.TenNhanVien;
            dtpNgaySinh.Value = nhanVien.NgaySinh;
            txtDiaChi.Text = nhanVien.DiaChi;
            txtDienThoai.Text = nhanVien.SoDienThoai;
            txtTenTaiKhoan.Text = nhanVien.TenTaiKhoan;
            txtCCCD.Text = nhanVien.CCCD1;
            dtListCaLam.Rows.Clear();
            txtTen.BackColor = Color.Gainsboro;
            txtDiaChi.BackColor = Color.Gainsboro;
            txtDienThoai.BackColor = Color.Gainsboro;
            txtCCCD.BackColor = Color.Gainsboro;
            lblValidatedCCCD.Visible = false;
            lblValidatedDienThoai.Visible = false;
            lblValidatedDiaChi.Visible = false;
            lblValidatedTen.Visible = false;
            lblValidatedNgaySinh.Visible = false;
            txtTen.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtCCCD.ReadOnly = true;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            btnLuu.Enabled = false;
            checkEdit = true;
            LoadListCaLamViec();
        }
        public void LoadListCaLamViec()
        {
            foreach (CaLamViecDTO i in LichLamViecBLL.Instance.GetListCaLamViecByMaNhanVien(nhanVien.MaNhanVien, dtpNhanVien.Value))
            {
                dtListCaLam.Rows.Add(i.TenCa, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString());
            }
            dgvListCaLamViec.DataSource = dtListCaLam;
        }
        public void SetDataTable()
        {
            dtListCaLam.Columns.Add("Tên Ca");
            dtListCaLam.Columns.Add("Giờ Bắt Đầu");
            dtListCaLam.Columns.Add("Giờ Kết Thúc");

        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauQLVT frmDoiMatKhauQLVT = new FrmDoiMatKhauQLVT(nhanVien);
            frmDoiMatKhauQLVT.ShowDialog();
        }

        bool checkEdit = true;
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (checkEdit == true)
            {
                txtTen.BackColor = Color.White;
                txtDiaChi.BackColor = Color.White;
                txtDienThoai.BackColor = Color.White;
                txtCCCD.BackColor = Color.White;

                txtTen.ReadOnly = false;
                dtpNgaySinh.Enabled = true;
                txtDiaChi.ReadOnly = false;
                txtDienThoai.ReadOnly = false;
                txtCCCD.ReadOnly = false;
                rbNam.Enabled = true;
                rbNu.Enabled = true;
                checkEdit = false;
            }
            else
            {
                txtTen.BackColor = Color.Gainsboro;
                txtDiaChi.BackColor = Color.Gainsboro;
                txtDienThoai.BackColor = Color.Gainsboro;
                txtCCCD.BackColor = Color.Gainsboro;

                txtTen.ReadOnly = true;
                dtpNgaySinh.Enabled = false;
                txtDiaChi.ReadOnly = true;
                txtDienThoai.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                rbNam.Enabled = false;
                rbNu.Enabled = false;
                checkEdit = true;
            }
        }
        public bool checkValidate()
        {
            bool check = true;
            // Tên Tiếng anh hoặc tiếng việt đều được
            if (Regex.IsMatch(txtTen.Text, @"^(\p{L}+\s?)*$") != true)
            {
                lblValidatedTen.Visible = true;
                check = false;
            }
            // Địa chỉ nước ngoài hoặc việt nam đều được
            if (Regex.IsMatch(txtDiaChi.Text, @"^(\p{L}+\s?)*$") != true)
            {
                lblValidatedDiaChi.Visible = true;
                check = false;
            }
            // Độ dài là 10 chữ số, Bắt đầu bằng 84 hoặc 0 kế tiếp phải là các đầu số hiện nay bao gồm 3,5,7,8,9 + với 8 số bất kì
            if (Regex.IsMatch(txtDienThoai.Text, @"(84|0[3|5|7|8|9])+([0-9]{8})\b") != true)
            {
                lblValidatedDienThoai.Visible = true;
                check = false;
            }
            //Độ dài là 12 chữ số, bắt đầu bằng số 0
            if (Regex.IsMatch(txtCCCD.Text, @"(0)+([1-9]{11})\b") != true)
            {
                lblValidatedCCCD.Visible = true;
                check = false;
            }
            if (DateTime.Today <= dtpNgaySinh.Value)
            {
                lblValidatedNgaySinh.Visible = true;
                check = false;
            }
            return check;


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkValidate() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    nhanVien.TenNhanVien = txtTen.Text;
                    nhanVien.CCCD1 = txtCCCD.Text;
                    nhanVien.DiaChi = txtDiaChi.Text;
                    nhanVien.SoDienThoai = txtDienThoai.Text;
                    if (rbNam.Checked == true)
                    {
                        nhanVien.GioiTinh = false;
                    }
                    else
                    {
                        nhanVien.GioiTinh = true;
                    }
                    nhanVien.NgaySinh = dtpNgaySinh.Value;
                    NhanVienBLL.Instance.AddUpdateNhanVien(nhanVien);
                    MessageBox.Show("Cập nhật thành công!");
                    Reload();
                    btnChinhSua.Enabled = true;
                }
            }
        }

        private void checkSave(object sender, EventArgs e)
        {
            lblErrorCCCD.Visible = false;
            lblErrorTen.Visible = false;
            lblErrorDiaChi.Visible = false;
            lblErrorDienThoai.Visible = false;
            btnChinhSua.Enabled = true;
            if (nhanVien.TenNhanVien == txtTen.Text && nhanVien.GioiTinh == rbNam.Checked
                && nhanVien.NgaySinh.ToShortDateString() == dtpNgaySinh.Value.ToShortDateString()
                && nhanVien.DiaChi == txtDiaChi.Text && nhanVien.SoDienThoai == txtDienThoai.Text
                && nhanVien.CCCD1 == txtCCCD.Text)
            {
                btnLuu.Enabled = false;
                lblValidatedCCCD.Visible = false;
                lblValidatedDienThoai.Visible = false;
                lblValidatedDiaChi.Visible = false;
                lblValidatedTen.Visible = false;
                lblValidatedNgaySinh.Visible = false;

            }
            else
            {
                if (txtTen.Text == "" || txtCCCD.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "")
                {
                    if (txtCCCD.Text == "")
                    {
                        lblErrorCCCD.Visible = true;
                    }
                    if (txtTen.Text == "")
                    {
                        lblErrorTen.Visible = true;
                    }
                    if (txtDiaChi.Text == "")
                    {
                        lblErrorDiaChi.Visible = true;
                    }
                    if (txtDienThoai.Text == "")
                    {
                        lblErrorDienThoai.Visible = true;
                    }
                    btnLuu.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    lblErrorTen.Visible = false;
                    lblErrorCCCD.Visible = false;
                    lblErrorDiaChi.Visible = false;
                    lblErrorDienThoai.Visible = false;
                    btnLuu.Enabled = true;
                    btnChinhSua.Enabled = false;
                }
            }
        }
        public void CheckEdit()
        {
            if (nhanVien.TenNhanVien == txtTen.Text && nhanVien.GioiTinh == rbNam.Checked
                && nhanVien.NgaySinh.ToShortDateString() == dtpNgaySinh.Value.ToShortDateString()
                && nhanVien.DiaChi == txtDiaChi.Text && nhanVien.SoDienThoai == txtDienThoai.Text
                && nhanVien.CCCD1 == txtCCCD.Text)
            {

            }
        }

        private void dtpNhanVien_ValueChanged(object sender, EventArgs e)
        {
            dtListCaLam.Rows.Clear();
            LoadListCaLamViec();
        }

        private void UCHoSoCaNhanQLVT_Leave(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true || checkValidate() == false)
            {
                DialogResult dialogResult = MessageBox.Show("Thông tin chưa lưu, có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    Reload();
                }
            }
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pBAnhPhim.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}