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
           
            SetGUI();
        }

        public void SetGUI()
        {
            cbLoaiNhaCungCap.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbLoaiNhaCungCap.Items.AddRange(LoaiNhaCungCapBLL.Instance.GetCBBLoaiNhaCungCap().ToArray());
            cbSapXep.Items.AddRange(new string[] { "Tên A->Z", "Tên Z->A" });
            cbLoaiNhaCungCap.SelectedItem = cbLoaiNhaCungCap.Items[0];
            loadDGVDanhSachNCC();
            dgvDSNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgvDSNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvDSNhaCungCap.Columns["MaSoThue"].HeaderText = "Mã số thuế";
            dgvDSNhaCungCap.Columns["SoDienThoai"].HeaderText = "Điện thoại";
            dgvDSNhaCungCap.Columns["TenLoaiNhaCungCap"].HeaderText = "Loại SP cung cấp";
        }
        public void loadDGVDanhSachNCC(string maLoaiNCC = "0", string txt = "" )
        {
            dgvDSNhaCungCap.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC(maLoaiNCC, txt );
        }

        private void cbLoaiNhaCungCap_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiNhaCungCap.SelectedItem != null)
            {
                loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value);
                dgvDSSanPham.DataSource = NhaCungCapBLL.Instance.GetSPByMaNhaCungCap(dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString());
            }
            
           
        }
        private void dgvDSNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSNhaCungCap.SelectedRows.Count == 1)
            {
                string maNhaCungCap = dgvDSNhaCungCap.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
               
                dgvDSSanPham.DataSource =    NhaCungCapBLL.Instance.GetSPByMaNhaCungCap(maNhaCungCap);
            }
                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmThemNhaCungCap = new frmThemNhaCungCap();
            frmThemNhaCungCap.d = new frmThemNhaCungCap.Mydel(loadDGVDanhSachNCC);
            frmThemNhaCungCap.ShowDialog();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value, txtTimKiem.Text );
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvDSNhaCungCap.Rows)
                {
                    now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
                }
                dgvDSNhaCungCap.DataSource =   NhaCungCapBLL.Instance.SortNhaCungCap(NhaCungCapBLL.Instance.GetNhaCungCapViewDGV(now), dkSapXep);
                dgvDSSanPham.DataSource = NhaCungCapBLL.Instance.GetSPByMaNhaCungCap(dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString());
            }
            
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value, txtTimKiem.Text);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            List<string> now = new List<string>();
            foreach (DataGridViewRow row in dgvDSNhaCungCap.Rows)
            {
                now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
            }
           Helper.Instance.ExportDataToExcel<NhaCungCapDTO>(NhaCungCapBLL.Instance.GetNhaCungCapDGV(now));
        }
    }
}
