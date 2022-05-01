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
    public partial class UCNhapXuatThucAnQLVT : UserControl
    {
        public UCNhapXuatThucAnQLVT()
        {
            InitializeComponent();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuNhapXuatKhoQLVT frmTaoPhieuNhapXuatKhoQLVT = new FrmTaoPhieuNhapXuatKhoQLVT();
            frmTaoPhieuNhapXuatKhoQLVT.Show();
        }
    }
}
