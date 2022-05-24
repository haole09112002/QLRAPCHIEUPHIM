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
            txtTen.Text = nhanVien.TenNhanVien;
            dtpNgaySinh.Value = nhanVien.NgaySinh;
            if (nhanVien.GioiTinh == false)
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
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
            foreach (CaLamViecDTO i in LichLamViecBLL.Instance.GetListCaLamViecByMaNhanVien(nhanVien.MaNhanVien))
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
            if(checkEdit == true)
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
                if (txtTen.Text == "" || txtCCCD.Text == ""|| txtDiaChi.Text == "" || txtDienThoai.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống Thông Tin, Vui Lòng Nhập Lại!!");
                }
                else
                {
                    nhanVien.TenNhanVien = txtTen.Text;
                    nhanVien.CCCD1 = txtCCCD.Text;
                    nhanVien.DiaChi = txtDiaChi.Text;
                    nhanVien.SoDienThoai = txtDienThoai.Text;
                    if(rbNam.Checked == true)
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
        }

        private void checkSave(object sender, EventArgs e)
        {
            if (nhanVien.TenNhanVien == txtTen.Text && nhanVien.GioiTinh != rbNam.Checked
                && nhanVien.NgaySinh.ToShortDateString() == dtpNgaySinh.Value.ToShortDateString()
                && nhanVien.DiaChi == txtDiaChi.Text && nhanVien.SoDienThoai == txtDienThoai.Text
                && nhanVien.CCCD1 == txtCCCD.Text)
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }
    }
}
