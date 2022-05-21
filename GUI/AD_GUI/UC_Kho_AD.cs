using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.AD_GUI
{
    public partial class UC_Kho_AD : UserControl
    {
        public UC_Kho_AD()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            dgvKho.DataSource = KhoBLL.Instance.GetAllKho();
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSapXep.SelectedIndex == 0)
            {
                this.dgvKho.Sort(this.dgvKho.Columns["TenKho"], ListSortDirection.Ascending);
            }
            else
            {
                this.dgvKho.Sort(this.dgvKho.Columns["MaKho"], ListSortDirection.Ascending);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            KhoBLL.Instance.TimKiem(txtTimKiem.Text);
        }
    }
}
