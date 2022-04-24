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
        private Panel pnCenter;
        public UC_MenuTaoLC_QLP()
        {
            InitializeComponent();
        }
        public UC_MenuTaoLC_QLP(Panel _pnCenter) :this()
        {
            pnCenter = _pnCenter;
        }
        UC_DSPhim_QLP ucDSP = new UC_DSPhim_QLP();
        UC_DSLCCT_QLP ucDSCT = new UC_DSLCCT_QLP();
        UC_DSLCDK_QLP ucDSDK = new UC_DSLCDK_QLP();
        void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);
        }
        private void btnTaoLC_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucDSP);
        }

        private void btLCDuKien_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucDSDK);
        }

        private void btnLCChinhThuc_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucDSCT);
        }
    }
}
