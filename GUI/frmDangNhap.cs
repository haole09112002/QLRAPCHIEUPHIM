using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.QLP_GUI;
using GUI.AD_GUI;
using GUI.QLVT_GUI;

using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Admin")
            {
                frmDashboard_AD frmDashboard_AD = new frmDashboard_AD();
                //frmDashboard_AD.WindowState = FormWindowState.Maximized;
                //frmDashboard_AD.TopMost = true;
               
                frmDashboard_AD.Show();
               
            }
            if (comboBox1.SelectedItem.ToString() == "QLP")
            {
                frm_QLP frm_QLP = new frm_QLP();
                //frm_QLP.WindowState = FormWindowState.Maximized;
                //frm_QLP.TopMost = true;
                frm_QLP.Show();
            
            }
            if (comboBox1.SelectedItem.ToString() == "QLVT")
            {
                FrmDashboardQLVT frmDashboardQLVT = new FrmDashboardQLVT();
                //frmDashboardQLVT.WindowState = FormWindowState.Maximized;
                //frmDashboardQLVT.TopMost = true;
                frmDashboardQLVT.Show();
            }
                
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
