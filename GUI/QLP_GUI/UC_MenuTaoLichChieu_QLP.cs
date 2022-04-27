using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLP_GUI;

namespace GUI.QLP_GUI
{
    public partial class UC_MenuTaoLichChieu_QLP : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        public UC_MenuTaoLichChieu_QLP()
        {
            InitializeComponent();
            changeColorButton(btnTaoLichChieu);
        }
        
        UC_TaoLichChieu_QLP ucTLC = new UC_TaoLichChieu_QLP();
        UC_DanhSachLichChieuChinhThuc_QLP ucDSCT = new UC_DanhSachLichChieuChinhThuc_QLP();
        UC_DanhSachLichChieuDuKien_QLP ucDSDK = new UC_DanhSachLichChieuDuKien_QLP();

        public void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> { btnLichChieuChinhThuc, btnTaoLichChieu,btnLichChieuDuKien };
            foreach (Button i in buttons)
            {
                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) // xanh
                {
                    i.BackColor = Color.FromArgb(226, 251, 242); // den
                }
            }
        }
        private void btnTaoLC_Click(object sender, EventArgs e)
        {
            d(ucTLC);
            changeColorButton(btnTaoLichChieu);
        }

        private void btLCDuKien_Click(object sender, EventArgs e)
        {
            d(ucDSDK);
            changeColorButton(btnLichChieuDuKien);
        }

        private void btnLCChinhThuc_Click(object sender, EventArgs e)
        {
            d(ucDSCT);
            changeColorButton(btnLichChieuChinhThuc);
        }
    }
}
