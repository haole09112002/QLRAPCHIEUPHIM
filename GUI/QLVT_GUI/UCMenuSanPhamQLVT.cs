using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class UCMenuSanPhamQLVT : UserControl
    {
        public UCMenuSanPhamQLVT()
        {
            InitializeComponent();
        }
        public delegate void Mydel(UserControl c);
        public Mydel d { get; set; }
        public UCThongTinThucAnQLVT ucThongTinThucAnQLVT = new UCThongTinThucAnQLVT();
        public UCThongTinVatTuQLVT ucThongTinVatTuQLVT = new UCThongTinVatTuQLVT();
        private void btnMenuListTTThucAn_Click(object sender, EventArgs e)
        {
            d(ucThongTinThucAnQLVT);
            changeColorButton(btnMenuListTTThucAn);
        }

        private void btnMenuListTTVatTu_Click(object sender, EventArgs e)
        {
            d(ucThongTinVatTuQLVT);
            changeColorButton(btnMenuListTTVatTu);
        }
        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> { btnMenuListTTThucAn, btnMenuListTTVatTu };
            foreach (Button i in buttons)
            {

                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn)
                {
                    i.BackColor = Color.FromArgb(226, 251, 242);
                }
            }
        }
        public void setColor()
        {
            btnMenuListTTThucAn.BackColor = Color.FromArgb(0, 144, 153);
            btnMenuListTTVatTu.BackColor = Color.FromArgb(226, 251, 242);
        }
    }
}
