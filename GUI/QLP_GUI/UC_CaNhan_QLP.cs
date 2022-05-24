using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI.QLP_GUI
{
    public partial class UC_CaNhan_QLP : UserControl
    {
        NhanVienDTO nhanvien = new NhanVienDTO();
        public UC_CaNhan_QLP(NhanVienDTO nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau_QLP f = new frmDoiMatKhau_QLP();
            f.ShowDialog();
        }
    }
}
