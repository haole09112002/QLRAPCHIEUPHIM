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
            this.Close();
        }
        public void SetGUI()
        {
            if(txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtXacNhanMatKhau.Text == "")
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
                if ((checkMatKhau != 0 &&  checkMatKhau != -1) && (txtMatKhauMoi.Text == txtXacNhanMatKhau.Text))
                {
                    nhanVien.MatKhau = NhanVienBLL.Instance.MD5(txtMatKhauMoi.Text);
                    NhanVienBLL.Instance.AddUpdateNhaCungCap(nhanVien);
                    MessageBox.Show("Thay Đổi Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nhập sai thông tin!");
                    SetGUI();
                }
                
                //for (int i = 0; i < dgvListDeXuatVatTu.Rows.Count - 1; i++)
                //{
                //    MaVatTu = dgvListDeXuatVatTu.Rows[i].Cells["Mã Vật Tư"].Value.ToString();
                //    NoiDung = dgvListDeXuatVatTu.Rows[i].Cells["Nội Dung"].Value.ToString();
                //    DonViTinh = dgvListDeXuatVatTu.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                //    SoLuong = Convert.ToInt32(dgvListDeXuatVatTu.Rows[i].Cells["Số Lượng"].Value.ToString());
                //    ChiTietDeXuatVatTuBLL.Instance.LuuChiTietDeXuatVatTu(MaDeXuat, MaVatTu, NoiDung, DonViTinh, SoLuong, "1");
                //}
            }
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text != "" && txtMatKhauMoi.Text != "" && txtXacNhanMatKhau.Text != "")
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }
    }
}
