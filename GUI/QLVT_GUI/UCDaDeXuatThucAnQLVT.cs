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
    public partial class UCDaDeXuatThucAnQLVT : UserControl
    {
        public UCDaDeXuatThucAnQLVT()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatThucAnQLVT frmTaoPhieuDeXuatThucAnQLVT = new FrmTaoPhieuDeXuatThucAnQLVT();
            frmTaoPhieuDeXuatThucAnQLVT.Show();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatThucAnQLVT frmTaoPhieuDeXuatThucAnQLVT = new FrmTaoPhieuDeXuatThucAnQLVT();
            frmTaoPhieuDeXuatThucAnQLVT.Show();
        }
    }
}
