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
using DTO;

namespace GUI.QLVT_GUI
{
    public partial class UCNhaCungUngThucAnQLVT : UserControl
    {
        public UCNhaCungUngThucAnQLVT()
        {
            InitializeComponent();
            ReLoadListNCCThucAn();
            SetGUI();
        }
        public void SetGUI()
        {
            cboSapXep.Items.AddRange(new string[] { "Tên A->Z", "Tên Z->A" });
            ReLoadListNCCThucAn();
            dgvListNCCThucAn.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgvListNCCThucAn.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvListNCCThucAn.Columns["MaSoThue"].HeaderText = "Mã số thuế";
            dgvListNCCThucAn.Columns["SoDienThoai"].HeaderText = "Điện thoại";
            dgvListNCCThucAn.Columns["TenLoaiNhaCungCap"].HeaderText = "Loại SP cung cấp";
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvListNCCThucAn.SelectedRows.Count == 1)
            {
                string maNhaCungCap = dgvListNCCThucAn.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
                FrmChiTietNhaCungCap frmChiTietNhaCungCap = new FrmChiTietNhaCungCap(maNhaCungCap);
                frmChiTietNhaCungCap.d = new FrmChiTietNhaCungCap.Mydel(ReLoadListNCCThucAn);
                frmChiTietNhaCungCap.ShowDialog();
            }
        }
        public void ReLoadListNCCThucAn(string maLoaiNCC = "LNCC03", string txt = "")
        {
            dgvListNCCThucAn.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC(maLoaiNCC, txt);
            dgvListNCCThucAn.Columns["TenLoaiNhaCungCap"].Visible = false;
        }
        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cboSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvListNCCThucAn.Rows)
                {
                    now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
                }
                dgvListNCCThucAn.DataSource = NhaCungCapBLL.Instance.SortNhaCungCap(NhaCungCapBLL.Instance.GetNhaCungCapViewDGV(now), dkSapXep);
          
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvListNCCThucAn.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC("LNCC03",txtTimKiem.Text);
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
        }
    }
}
