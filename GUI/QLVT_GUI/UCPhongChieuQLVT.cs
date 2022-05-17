using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class UCPhongChieuQLVT : UserControl
    {
        public UCPhongChieuQLVT()
        {
            InitializeComponent();
            setGUI();
        }
        private void setGUI()
        {
            dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.GetAllPhongChieu();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmCapNhatPhongChieuQLVT frmCapNhatPhongChieuQLVT = new FrmCapNhatPhongChieuQLVT();
            frmCapNhatPhongChieuQLVT.Show();
        }

        private void dgvListPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvListPhongChieu.SelectedRows.Count == 1)
            {
                string maPhongChieu = dgvListPhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                MessageBox.Show(maPhongChieu);
                LoadDGVListVatTu(maPhongChieu);
            }    
        }

        private void LoadDGVListVatTu (string maPhongChieu)
        {
            dgvListVatTu.DataSource = null;
            dgvListVatTu.DataSource = ChiTietPhongChieuBLL.Instance.GetAllVatTuByMaPhongChieu(maPhongChieu);
        }
    }
}
