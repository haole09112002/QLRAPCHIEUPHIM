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
    public partial class UC_DanhSachPhimDeXuat_QLP : UserControl
    {
        public UC_DanhSachPhimDeXuat_QLP()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_TaoDeXuat_QLP frmTDX = new frm_TaoDeXuat_QLP();
            frmTDX.ShowDialog();
        }
    }
}
