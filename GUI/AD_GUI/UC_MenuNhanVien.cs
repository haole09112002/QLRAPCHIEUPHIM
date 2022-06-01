using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.AD_GUI;
using DTO;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_MenuNhanVien : UserControl
    {
        private NhanVienDTO NV;
        public UC_MenuNhanVien(NhanVienDTO nv)
        {
            NV = nv;
            ucThongTinNV = new UC_ThongTinNV(nv);
            InitializeComponent();
            btnMenuThongTinNV.BackColor = Color.FromArgb(40, 51, 66);
        }
        public UC_ThongTinNV ucThongTinNV;
        public UC_CaLam ucCaLam = new UC_CaLam();
        public delegate void Mydel(UserControl c);
        public Mydel d { get;set;}

        private void btnMenuThongTinNV_Click(object sender, EventArgs e)
        {
            d(ucThongTinNV);
            changeColorButton(btnMenuThongTinNV);
        }

        private void btnMenuCaLam_Click(object sender, EventArgs e)
        {
            d(ucCaLam);
            changeColorButton(btnMenuCaLam);
        }


        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153); // xanh
            List<Button> buttons = new List<Button> { btnMenuThongTinNV, btnMenuCaLam};
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
            btnMenuThongTinNV.BackColor = Color.FromArgb(0, 144, 153);
            btnMenuCaLam.BackColor = Color.FromArgb(226, 251, 242);
        }
    }
}
