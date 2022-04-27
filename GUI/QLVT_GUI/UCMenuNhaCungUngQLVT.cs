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
        private void btnTaoDeXuat_Click(object sender, EventArgs e)
        {
            d(ucNhaCungUngThucAnQLVT);
        }

        private void btnDSDXP_Click(object sender, EventArgs e)
        {
            d(ucNhaCungUngVatTuQLVT);
        }
    }
}
