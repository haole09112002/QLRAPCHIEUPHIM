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
    public partial class UC_MenuThongKe : UserControl
    {
        public UC_MenuThongKe()
        {
            InitializeComponent();
        }
        public void setColor()
        {
            btnMenuThongTinChung.BackColor = Color.FromArgb(0, 144, 153);
            btnMenuNhapXuat.BackColor = Color.FromArgb(226, 251, 242);
     
        }
        public delegate void Mydel (Control control);
        public Mydel d { get; set; }
        public UC_ThongKeChung ucThongKeChung = new UC_ThongKeChung();
        public UC_ThongKeNhapXuat ucThongKeNhapXuat = new UC_ThongKeNhapXuat();
        private void btnMenuThongTinChung_Click(object sender, EventArgs e)
        {
            d(ucThongKeChung);
            changeColorButton(btnMenuThongTinChung);
        }

        private void btnMenuNhapXuat_Click(object sender, EventArgs e)
        {
            d(ucThongKeNhapXuat);
            changeColorButton(btnMenuNhapXuat);
        }
        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153); // xanh
            List<Button> buttons = new List<Button> {btnMenuNhapXuat,  btnMenuThongTinChung};
            foreach (Button i in buttons)
            {

                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) // xanh 
                {
                    i.BackColor = Color.FromArgb(226, 251, 242); // xanh non
                }
            }
        }
    }
}
