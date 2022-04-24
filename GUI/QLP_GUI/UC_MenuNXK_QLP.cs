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
        public delegate void MyDel(Control c);
        public MyDel d;
        public UC_MenuNXK_QLP()
        {
            InitializeComponent();
        }
        UC_TaoPhieu_QLP ucTP = new UC_TaoPhieu_QLP();
        UC_LSNX_QLP ucLS = new UC_LSNX_QLP();
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            d(ucTP);
        }

        private void btnLSNX_Click(object sender, EventArgs e)
        {
            d(ucLS);
        }
    }
}
