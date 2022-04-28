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
        private void btnTaoDeXuat_Click(object sender, EventArgs e)
        {
            d(ucThongTinThucAnQLVT);
        }

        private void btnDSDXP_Click(object sender, EventArgs e)
        {
            d(ucThongTinVatTuQLVT);
        }
    }
}
