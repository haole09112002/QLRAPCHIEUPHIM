using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_MenuDeXuat_QLP : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        public UC_MenuDeXuat_QLP()
        {
            InitializeComponent();
        }
        UC_TaoDX_QLP ucTDX = new UC_TaoDX_QLP();
        UC_DSPDX_QLP ucDSPDX = new UC_DSPDX_QLP();
        private void btnTaoDeXuat_Click(object sender, EventArgs e)
        {
            d(ucTDX);
        }

        private void btnDSDXP_Click(object sender, EventArgs e)
        {
            d(ucDSPDX);
        }
    }
}
