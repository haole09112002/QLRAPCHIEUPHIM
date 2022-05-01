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
    public partial class UCMenuNhaCungUngQLVT : UserControl
    {
        public UCMenuNhaCungUngQLVT()
        {
            InitializeComponent();
        }
        public delegate void Mydel(UserControl c);
        public Mydel d { get; set; }
        public UCNhaCungUngThucAnQLVT ucNhaCungUngThucAnQLVT = new UCNhaCungUngThucAnQLVT();
        public UCNhaCungUngVatTuQLVT ucNhaCungUngVatTuQLVT = new UCNhaCungUngVatTuQLVT();
        private void btnMenuListNCCThucAn_Click(object sender, EventArgs e)
        {
            d(ucNhaCungUngThucAnQLVT);
            changeColorButton(btnMenuListNCCThucAn);
        }

        private void btnMenuListNCCVatTu_Click(object sender, EventArgs e)
        {
            d(ucNhaCungUngVatTuQLVT);
            changeColorButton(btnMenuListNCCVatTu);
        }
        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> { btnMenuListNCCThucAn, btnMenuListNCCVatTu};
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
            btnMenuListNCCThucAn.BackColor = Color.FromArgb(0, 144, 153);
            btnMenuListNCCVatTu.BackColor = Color.FromArgb(226, 251, 242);
        }
    }
}
