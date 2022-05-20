using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class frm_QLP : Form
    {
        public frm_QLP()
        {
            InitializeComponent();
        }
        UC_ThongTinPhim_QLP ucTTP = new UC_ThongTinPhim_QLP();
        UC_CaNhan_QLP ucCN = new UC_CaNhan_QLP();
        UC_TaoPhieu_QLP ucTP = new UC_TaoPhieu_QLP();
        UC_PhieuNhapXuat_QLP ucLS = new UC_PhieuNhapXuat_QLP();
        UC_MenuNhapXuatKho_QLP ucMNXK = new UC_MenuNhapXuatKho_QLP();
        UC_TaoLichChieu_QLP ucTLC = new UC_TaoLichChieu_QLP();
        UC_DanhSachLichChieuChinhThuc_QLP ucDSCT = new UC_DanhSachLichChieuChinhThuc_QLP();
        UC_DanhSachLichChieuDuKien_QLP ucDSDK = new UC_DanhSachLichChieuDuKien_QLP();
        UC_MenuTaoLichChieu_QLP ucMTLC = new UC_MenuTaoLichChieu_QLP();
        UC_DanhSachPhimDeXuat_QLP ucDSPDX = new UC_DanhSachPhimDeXuat_QLP();
        UC_NhaCungCap_QLP ucNCC = new UC_NhaCungCap_QLP();
        void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);
        }
        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> {btnCaNhan, btnDangXuat,btnDeXuatPhim,btnNCC,btnNhapXuat,btnTaoLichChieu,btnThongTinPhim};
            foreach (Button i in buttons)
            {
                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) // xanh
                {
                    i.BackColor = Color.FromArgb(40, 51, 66); // den
                }
            }
        }
        private void AddControlsToPnMenu(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnMenu.Controls.Clear();
            pnMenu.Controls.Add(c);
        }
        private void btnThongTinPhim_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucTTP);
            changeColorButton(btnThongTinPhim);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoLichChieu_Click(object sender, EventArgs e)
        {
            pnCenter.Controls.Clear();
            AddControlsToPnMenu(ucMTLC);
            AddControlsToPnCenter(ucTLC);
            ucMTLC.d = new UC_MenuTaoLichChieu_QLP.MyDel(AddControlsToPnCenter);
            changeColorButton(btnTaoLichChieu);
            ucMTLC.changeColorButton(ucMTLC.btnTaoLichChieu);
        }

        private void btnDeXuatPhim_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucDSPDX);
            changeColorButton(btnDeXuatPhim);
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            pnCenter.Controls.Clear();
            AddControlsToPnMenu(ucMNXK);
            AddControlsToPnCenter(ucTP);
            ucMNXK.d = new UC_MenuNhapXuatKho_QLP.MyDel(AddControlsToPnCenter);
            changeColorButton(btnNhapXuat);
            ucMNXK.changeColorButton(ucMNXK.btnTaoPhieu);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucCN);
            changeColorButton(btnCaNhan);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucNCC);
            changeColorButton(btnNCC);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
    }
}
