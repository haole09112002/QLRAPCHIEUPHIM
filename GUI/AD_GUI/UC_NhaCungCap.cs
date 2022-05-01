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

namespace GUI.AD_GUI
{
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
            cbLoaiNhaCungCap.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbLoaiNhaCungCap.Items.AddRange(LoaiNhaCungCapBLL.Instance.GetCBBLoaiNhaCungCap().ToArray());
            loadDGVDanhSachNCC();
        }

        public void SetGUI()
        {
           
        }
        public void loadDGVDanhSachNCC(string maLoaiNCC = "0")
        {
            dgvDSNhaCungCap.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC(maLoaiNCC );
        }
        public void setDGVDanhSachSanPham(DataGridView dgvDSSanPham, string maNhaCungCap)
        {
           
        }
        private void cbLoaiNhaCungCap_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiNhaCungCap.SelectedItem != null)
            {
                loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value);
            }
        }

   
        private void dgvDSNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmThemNhaCungCap = new frmThemNhaCungCap();
            frmThemNhaCungCap.d = new frmThemNhaCungCap.Mydel(loadDGVDanhSachNCC);
            frmThemNhaCungCap.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

           
        }

   
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(dgvDSNhaCungCap.SelectedRows.Count == 1 )
            {
                string maNhaCungCap = dgvDSNhaCungCap.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
                frmThemNhaCungCap frmThemNhaCungCap = new frmThemNhaCungCap(maNhaCungCap);
                frmThemNhaCungCap.d = new frmThemNhaCungCap.Mydel(loadDGVDanhSachNCC);
                frmThemNhaCungCap.ShowDialog();
            }
           
        }

        private void dgvDSNhaCungCap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSNhaCungCap.SelectedRows.Count == 1)
            {
                string maNhaCungCap = dgvDSNhaCungCap.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
                frmThemNhaCungCap frmThemNhaCungCap = new frmThemNhaCungCap(maNhaCungCap);
                frmThemNhaCungCap.d = new frmThemNhaCungCap.Mydel(loadDGVDanhSachNCC);
                frmThemNhaCungCap.ShowDialog();
            }
        }
    }
}
