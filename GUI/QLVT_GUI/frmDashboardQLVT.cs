using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLVT_GUI;
using DTO;

namespace GUI.QLVT_GUI
{
    public partial class FrmDashboardQLVT : Form
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        public FrmDashboardQLVT(NhanVienDTO NV)
        {
            InitializeComponent();
            nhanVien = NV;
            lbTenNhanVien.Text = nhanVien.TenNhanVien;
            
            
        }
        UCThongTinSanPhamQLVT ucThongTinSanPhamQLVT = new UCThongTinSanPhamQLVT();
        UCPhongChieuQLVT ucPhongChieuQLVT = new UCPhongChieuQLVT();
        UCMenuDeXuatQLVT ucMenuDeXuatQLVT;
        UCMenuNhaCungUngQLVT ucMenuNhaCungUngQLVT = new UCMenuNhaCungUngQLVT();
        UCMenuNhapXuatQLVT ucMenuNhapXuatQLVT = new UCMenuNhapXuatQLVT();
        UCHoSoCaNhanQLVT ucHoSoCaNhanQLVT = new UCHoSoCaNhanQLVT();

        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> {btnDeXuat,btnNhapXuatKho,btnNhaCungUng,btnSanPham,btnPhongChieu,btnCaNhan,btnDangXuat};
            foreach (Button i in buttons)
            {

                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) 
                {
                    i.BackColor = Color.FromArgb(40, 51, 66); 
                }
            }
        }
        private void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnMenuContent.Controls.Clear();
            pnMenuContent.Controls.Add(c);
        }
        private void AddControlsToPnMenu(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnMenu.Controls.Clear();
            pnMenu.Controls.Add(c);
        }

        private void btnDeXuat_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            ucMenuDeXuatQLVT = new UCMenuDeXuatQLVT(nhanVien);
            AddControlsToPnMenu(ucMenuDeXuatQLVT);
            ucMenuDeXuatQLVT.setColor();
            //AddControlsToPnCenter(ucMenuDeXuatQLVT.ucDaDeXuatThucAnQLVT);
            ucMenuDeXuatQLVT.d = new UCMenuDeXuatQLVT.Mydel(AddControlsToPnCenter);
            changeColorButton(btnDeXuat);
        }

        private void btnNhapXuatKho_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnMenu(ucMenuNhapXuatQLVT);
            ucMenuNhapXuatQLVT.setColor();
            AddControlsToPnCenter(ucMenuNhapXuatQLVT.ucNhapXuatThucAnQLVT);
            ucMenuNhapXuatQLVT.d = new UCMenuNhapXuatQLVT.Mydel(AddControlsToPnCenter);
            changeColorButton(btnNhapXuatKho);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnMenu(ucMenuNhaCungUngQLVT);
            ucMenuNhaCungUngQLVT.setColor();
            AddControlsToPnCenter(ucMenuNhaCungUngQLVT.ucNhaCungUngThucAnQLVT);
            ucMenuNhaCungUngQLVT.d = new UCMenuNhaCungUngQLVT.Mydel(AddControlsToPnCenter);
            changeColorButton(btnNhaCungUng);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucThongTinSanPhamQLVT);
            changeColorButton(btnSanPham);
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucPhongChieuQLVT);
            changeColorButton(btnPhongChieu);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucHoSoCaNhanQLVT);
            changeColorButton(btnCaNhan);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
    }
}
