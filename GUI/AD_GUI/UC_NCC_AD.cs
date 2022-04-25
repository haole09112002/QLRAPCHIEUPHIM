using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_NCC_AD : UserControl
    {
        public UC_NCC_AD()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmThemNhaCungCap = new frmThemNhaCungCap();
        }
    }
}
