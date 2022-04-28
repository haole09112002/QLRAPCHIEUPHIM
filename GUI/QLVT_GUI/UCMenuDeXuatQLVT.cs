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
    public partial class UCMenuDeXuatQLVT : UserControl
    {
        public UCMenuDeXuatQLVT()
        {
            InitializeComponent();
        }
        public delegate void Mydel(UserControl c);
        public Mydel d { get; set; }
        public UCDaDeXuatThucAnQLVT ucDaDeXuatThucAnQLVT = new UCDaDeXuatThucAnQLVT();
        public UCDaDeXuatVatTuQLVT ucDaDeXuatVatTuQLVT = new UCDaDeXuatVatTuQLVT();
        private void btnTaoDeXuat_Click(object sender, EventArgs e)
        {
            d(ucDaDeXuatThucAnQLVT);
        }

        private void btnDSDXP_Click(object sender, EventArgs e)
        {
            d(ucDaDeXuatVatTuQLVT);
        }

    }
}
