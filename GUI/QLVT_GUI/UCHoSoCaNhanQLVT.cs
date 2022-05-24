using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
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
            if (nhanVien.GioiTinh == false)
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
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

            txtTen.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtCCCD.ReadOnly = true;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            btnLuu.Enabled = false;
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

        private void btnLuu_Click(object sender, EventArgs e)
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
                NhanVienBLL.Instance.AddUpdateNhaCungCap(nhanVien);
                MessageBox.Show("Cập nhật thành công!");
                Reload();
            }
        }

        private void checkSave(object sender, EventArgs e)
        {
            lblErrorCCCD.Visible = false;
            lblErrorTen.Visible = false;
            lblErrorDiaChi.Visible = false;
            lblErrorDienThoai.Visible = false;
            btnChinhSua.Enabled = true;
            if (nhanVien.TenNhanVien == txtTen.Text && nhanVien.GioiTinh != rbNam.Checked
                && nhanVien.NgaySinh.ToShortDateString() == dtpNgaySinh.Value.ToShortDateString()
                && nhanVien.DiaChi == txtDiaChi.Text && nhanVien.SoDienThoai == txtDienThoai.Text
                && nhanVien.CCCD1 == txtCCCD.Text)
            {
                btnLuu.Enabled = false;
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
            if (nhanVien.TenNhanVien == txtTen.Text && nhanVien.GioiTinh != rbNam.Checked
                && nhanVien.NgaySinh.ToShortDateString() == dtpNgaySinh.Value.ToShortDateString()
                && nhanVien.DiaChi == txtDiaChi.Text && nhanVien.SoDienThoai == txtDienThoai.Text
                && nhanVien.CCCD1 == txtCCCD.Text)
            {

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Thông tin chưa lưu, có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    Reload();
                }

            }
        }

        private void dtpNhanVien_ValueChanged(object sender, EventArgs e)
        {
            dtListCaLam.Rows.Clear();
            LoadListCaLamViec();
        }
    }
}
