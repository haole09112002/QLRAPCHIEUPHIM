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
    public partial class UC_NCC_QLP : UserControl
    {
        public UC_NCC_QLP()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            frm_ThongTinNCC_QLP f = new frm_ThongTinNCC_QLP();
            f.ShowDialog();
        }
    }
}
