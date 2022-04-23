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
    public partial class UC_MenuNXK_QLP : UserControl
    {
        Panel pnCenter;
        public UC_MenuNXK_QLP()
        {
            InitializeComponent();
        }
        UC_TaoPhieu_QLP ucTP = new UC_TaoPhieu_QLP();
        UC_LSNX ucLS = new UC_LSNX();
        public UC_MenuNXK_QLP(Panel _pnCenter) :this()
        {
            pnCenter = _pnCenter;
        }
        void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucTP);
        }

        private void btnLSNX_Click(object sender, EventArgs e)
        {
            AddControlsToPnCenter(ucLS);
        }
    }
}
