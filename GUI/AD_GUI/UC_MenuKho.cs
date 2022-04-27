using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_MenuKho : UserControl
    {
        public UC_MenuKho()
        {
            InitializeComponent();
        }
        public delegate void Mydel(UserControl c);
        public Mydel d { get; set; }
        public UC_Kho_AD ucThongTinKho = new UC_Kho_AD();
        public UC_PhieuNhapXuat ucPhieuNhapXuat = new UC_PhieuNhapXuat();
        private void btnMenuKho_Click(object sender, EventArgs e)
        {
            d(ucThongTinKho);
            changeColorButton(btnMenuKho);
        }

        private void btnMenuPhieuNhapXuat_Click(object sender, EventArgs e)
        {
            d(ucPhieuNhapXuat);
            changeColorButton(btnMenuPhieuNhapXuat);
        }


        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153); // xanh
            List<Button> buttons = new List<Button> { btnMenuKho, btnMenuPhieuNhapXuat};
            foreach (Button i in buttons)
            {

                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) // xanh 
                {
                    i.BackColor = Color.FromArgb(226, 251, 242); // xanh non
                }
            }
        }
        public void setColor()
        {
            btnMenuKho.BackColor = Color.FromArgb(0, 144, 153);
            btnMenuPhieuNhapXuat.BackColor = Color.FromArgb(226, 251, 242);
        }
    }
}
