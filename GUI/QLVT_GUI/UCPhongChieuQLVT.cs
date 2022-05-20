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
            cbLoaiPhong.Items.AddRange(LoaiPhongChieuBLL.Instance.GetCBBLoaiPhongChieu().ToArray());
            cbTinhTrangPhong.Items.AddRange(TinhTrangPhongChieuBLL.Instance.GetCBBTinhTrangPhongChieu().ToArray());
            dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.GetAllPhongChieuView();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmCapNhatPhongChieuQLVT frmCapNhatPhongChieuQLVT = new FrmCapNhatPhongChieuQLVT(txtMaPhongChieu.Text);
            frmCapNhatPhongChieuQLVT.Show();
        }

        private void dgvListPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvListPhongChieu.SelectedRows.Count == 1)
            {
                string maPhongChieu = dgvListPhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                LoadDGVListVatTu(maPhongChieu);
                txtMaPhongChieu.Text = maPhongChieu;
                txtTenPhongChieu.Text = dgvListPhongChieu.SelectedRows[0].Cells["TenPhong"].Value.ToString();
                foreach(CBBItem i in cbLoaiPhong.Items)
                {
                    if(i.Text == dgvListPhongChieu.SelectedRows[0].Cells["TenLoaiPhongChieu"].Value.ToString())
                        cbLoaiPhong.SelectedItem = i;
                }
                foreach (CBBItem i in cbTinhTrangPhong.Items)
                {
                    if (i.Text == dgvListPhongChieu.SelectedRows[0].Cells["TenTinhTrang"].Value.ToString())
                        cbTinhTrangPhong.SelectedItem = i;
                }
            }    
        }

        private void LoadDGVListVatTu (string maPhongChieu)
        {
            dgvListVatTu.DataSource = null;
            dgvListVatTu.DataSource = ChiTietPhongChieuBLL.Instance.GetAllVatTuByMaPhongChieu(maPhongChieu);
        }

      
    }
}
