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
    public partial class UCHoSoCaNhanQLVT : UserControl
    {
        public UCHoSoCaNhanQLVT()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauQLVT frmDoiMatKhauQLVT = new FrmDoiMatKhauQLVT();
            frmDoiMatKhauQLVT.Show();
        }
    }
}
