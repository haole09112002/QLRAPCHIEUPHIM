using BLL;
using DTO;
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
    public partial class frm_TaoDeXuat_QLP : Form
    {
        public frm_TaoDeXuat_QLP()
        {
            InitializeComponent();
            ReLoad();
        }
        public void ReLoad()
        {
            dGVDanhSachPhim.DataSource = PhimBLL.Instance.GetPhimViews();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm_DeXuatPhim frmDXP = new frm_DeXuatPhim();
            frmDXP.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVDanhSachPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                MessageBox.Show(dGVDeXuatPhim.Rows[0].Cells["Mã Phim"].Value.ToString());
            }
            catch (Exception ex) { };
            dGVDeXuatPhim.Rows.Add(
                dGVDanhSachPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString(),
                dGVDanhSachPhim.SelectedRows[0].Cells["TenPhim"].Value.ToString()
            );
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dGVDeXuatPhim.Rows.Clear();
        }
    }
}
