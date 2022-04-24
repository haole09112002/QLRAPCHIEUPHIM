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
    public partial class frm_QLP : Form
    {
        public frm_QLP()
        {
            InitializeComponent();
        }
        UC_TTPhim_QLP ucTTP = new UC_TTPhim_QLP();
        UC_CN_QLP ucCN = new UC_CN_QLP();
        void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);
        }
        private void AddControlsToPnMenu(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnMenu.Controls.Clear();
            pnMenu.Controls.Add(c);
        }
        private void btnThongTinPhim_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucTTP);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoLichChieu_Click(object sender, EventArgs e)
        {
            pnCenter.Controls.Clear();
            UC_MenuTaoLC_QLP ucMTLC = new UC_MenuTaoLC_QLP(pnCenter);
            AddControlsToPnMenu(ucMTLC);
        }

        private void btnDeXuatPhim_Click(object sender, EventArgs e)
        {
            pnCenter.Controls.Clear();
            UC_MenuDeXuat_QLP ucMDX = new UC_MenuDeXuat_QLP(pnCenter);
            AddControlsToPnMenu(ucMDX);
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            pnCenter.Controls.Clear();
            UC_MenuNXK_QLP ucMNXK = new UC_MenuNXK_QLP(pnCenter);
            AddControlsToPnMenu(ucMNXK);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucCN);
        }
    }
}
