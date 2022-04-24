using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLP_GUI;

namespace GUI.QLP_GUI
{
    public partial class UC_MenuTaoLC_QLP : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        public UC_MenuTaoLC_QLP()
        {
            InitializeComponent();
        }
        
        UC_TaoLC_QLP ucTLC = new UC_TaoLC_QLP();
        UC_DSLCCT_QLP ucDSCT = new UC_DSLCCT_QLP();
        UC_DSLCDK_QLP ucDSDK = new UC_DSLCDK_QLP();
        
        private void btnTaoLC_Click(object sender, EventArgs e)
        {
            d(ucTLC);
        }

        private void btLCDuKien_Click(object sender, EventArgs e)
        {
            d(ucDSDK);
        }

        private void btnLCChinhThuc_Click(object sender, EventArgs e)
        {
            d(ucDSCT);
        }
    }
}
