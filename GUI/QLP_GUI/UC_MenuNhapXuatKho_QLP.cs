using DTO;
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
    public partial class UC_MenuNhapXuatKho_QLP : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        NhanVienDTO nhanvien = new NhanVienDTO();
        UC_TaoPhieu_QLP ucTP;
        UC_PhieuNhapXuat_QLP ucLS = new UC_PhieuNhapXuat_QLP();
        public UC_MenuNhapXuatKho_QLP(NhanVienDTO nhanvien)
        {
            this.nhanvien = nhanvien; 
            InitializeComponent();
            changeColorButton(btnTaoPhieu);
            ucTP = new UC_TaoPhieu_QLP(nhanvien);
        }
        public void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> { btnTaoPhieu,btnDanhSachPhieuNX };
            foreach (Button i in buttons)
            {
                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) // xanh
                {
                    i.BackColor = Color.FromArgb(226, 251, 242); // den
                }
            }
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            d(ucTP);
            changeColorButton(btnTaoPhieu);
        }

        private void btnLSNX_Click(object sender, EventArgs e)
        {
            d(ucLS);
            changeColorButton(btnDanhSachPhieuNX);
            ucLS.Reload();
        }
    }
}
