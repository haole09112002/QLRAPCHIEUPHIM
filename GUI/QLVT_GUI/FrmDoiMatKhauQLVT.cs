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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                int checkMatKhau = NhanVienBLL.Instance.KiemTraDangNhap(nhanVien.TenTaiKhoan, NhanVienBLL.Instance.MD5(txtMatKhauCu.Text));
                if (checkMatKhau != 0 &&  checkMatKhau != 1)
                {
                    
                }
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                for (int i = 0; i < dgvListDeXuatVatTu.Rows.Count - 1; i++)
                {
                    MaVatTu = dgvListDeXuatVatTu.Rows[i].Cells["Mã Vật Tư"].Value.ToString();
                    NoiDung = dgvListDeXuatVatTu.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dgvListDeXuatVatTu.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dgvListDeXuatVatTu.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatVatTuBLL.Instance.LuuChiTietDeXuatVatTu(MaDeXuat, MaVatTu, NoiDung, DonViTinh, SoLuong, "1");
                }
                this.Close();
            }
        }
    }
}
