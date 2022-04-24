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
        UC_TaoPhieu_QLP ucTP = new UC_TaoPhieu_QLP();
        UC_LSNX_QLP ucLS = new UC_LSNX_QLP();
        UC_MenuNXK_QLP ucMNXK = new UC_MenuNXK_QLP();
        UC_TaoLC_QLP ucTLC = new UC_TaoLC_QLP();
        UC_DSLCCT_QLP ucDSCT = new UC_DSLCCT_QLP();
        UC_DSLCDK_QLP ucDSDK = new UC_DSLCDK_QLP();
        UC_MenuTaoLC_QLP ucMTLC = new UC_MenuTaoLC_QLP();
        UC_DSPDX_QLP ucDSPDX = new UC_DSPDX_QLP();
        UC_NCC_QLP ucNCC = new UC_NCC_QLP();
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
            AddControlsToPnMenu(ucMTLC);
            AddControlsToPnCenter(ucTLC);
            ucMTLC.d = new UC_MenuTaoLC_QLP.MyDel(AddControlsToPnCenter);
        }

        private void btnDeXuatPhim_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucDSPDX);
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            pnCenter.Controls.Clear();
            AddControlsToPnMenu(ucMNXK);
            AddControlsToPnCenter(ucTP);
            ucMNXK.d = new UC_MenuNXK_QLP.MyDel(AddControlsToPnCenter);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucCN);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucNCC);
        }
    }
}
