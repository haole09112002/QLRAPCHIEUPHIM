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

namespace GUI.QLP_GUI
{
    public partial class UC_NhaCungCap_QLP : UserControl
    {
        public UC_NhaCungCap_QLP()
        {
            InitializeComponent();
            ReLoad();
        }
        public void ReLoad(string s = "")
        {
            dGVNhaCungCapPhim.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC("LNCC01",s);
        }
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if(dGVNhaCungCapPhim.SelectedRows.Count == 1)
            {
                frm_ThongTinNCC_QLP frmThongTinNhaCungCap = new frm_ThongTinNCC_QLP(dGVNhaCungCapPhim.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString());
                frmThongTinNhaCungCap.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ReLoad(txtTimKiem.Text);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(cBSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cBSapXep.SelectedItem.ToString(); 
                foreach (DataGridViewRow row in dGVNhaCungCapPhim.Rows)
                {
                    now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
                }
                dGVNhaCungCapPhim.DataSource = NhaCungCapBLL.Instance.SortNhaCungCap(NhaCungCapBLL.Instance.GetNhaCungCapViewDGV(now), dkSapXep);
            }
        }
    }
}
