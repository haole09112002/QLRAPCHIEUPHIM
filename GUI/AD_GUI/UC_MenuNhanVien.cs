using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.AD_GUI;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_MenuNhanVien : UserControl
    {
        public UC_MenuNhanVien()
        {
            InitializeComponent();
        }
        public UC_ThongTinNV ucThongTinNV = new UC_ThongTinNV();
        public UC_CaLam ucCaLam = new UC_CaLam();
        public delegate void Mydel(UserControl c);
        public Mydel d { get;set;}

        private void btnMenuThongTinNV_Click(object sender, EventArgs e)
        {
            d(ucThongTinNV);
        }

        private void btnMenuCaLam_Click(object sender, EventArgs e)
        {
            d(ucCaLam);
        }
    }
}
