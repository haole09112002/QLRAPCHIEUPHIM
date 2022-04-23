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
        public Panel pnCenter;
        public UC_MenuDeXuat_QLP()
        {
            InitializeComponent();
        }
        UC_TaoDX_QLP ucTDX = new UC_TaoDX_QLP();
        UC_DSPDX_QLP ucDSPDX = new UC_DSPDX_QLP();
        public UC_MenuDeXuat_QLP(Panel _pnCenTer) : this()
        {
            pnCenter = _pnCenTer;
        }
        void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);
        }

        private void btnTaoDeXuat_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucTDX);
        }

        private void btnDSDXP_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucDSPDX);
        }
    }
}
