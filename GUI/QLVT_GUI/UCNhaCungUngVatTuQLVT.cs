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

    public partial class UCNhaCungUngVatTuQLVT : UserControl
    {
        public UCNhaCungUngVatTuQLVT()
        {
            InitializeComponent();
            ReLoadListNCCVatTu();
            SetGUI();
        }
        public void SetGUI()
        {
            cboSapXep.Items.Clear();
            cboSapXep.Items.AddRange(new string[] { "Tên A->Z", "Tên Z->A" });
            txtTimKiem.Text = "Nhập từ khóa bất kì";
            txtTimKiem.ForeColor = Color.DimGray;
            ReLoadListNCCVatTu();
            dgvListNCCVatTu.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgvListNCCVatTu.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvListNCCVatTu.Columns["MaSoThue"].HeaderText = "Mã số thuế";
            dgvListNCCVatTu.Columns["SoDienThoai"].HeaderText = "Điện thoại";
            dgvListNCCVatTu.Columns["TenLoaiNhaCungCap"].HeaderText = "Loại SP cung cấp";
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvListNCCVatTu.SelectedRows.Count == 1)
            {
                string maNhaCungCap = dgvListNCCVatTu.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
                FrmChiTietNhaCungCap frmChiTietNhaCungCap = new FrmChiTietNhaCungCap(maNhaCungCap);
                frmChiTietNhaCungCap.d = new FrmChiTietNhaCungCap.Mydel(ReLoadListNCCVatTu);
                frmChiTietNhaCungCap.ShowDialog();
            }
        }
        public void ReLoadListNCCVatTu(string maLoaiNCC = "LNCC02", string txt = "")
        {
            dgvListNCCVatTu.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC(maLoaiNCC, txt);
            dgvListNCCVatTu.Columns["TenLoaiNhaCungCap"].Visible = false;
        }
        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cboSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvListNCCVatTu.Rows)
                {
                    now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
                }
                dgvListNCCVatTu.DataSource = NhaCungCapBLL.Instance.SortNhaCungCap(NhaCungCapBLL.Instance.GetNhaCungCapViewDGV(now), dkSapXep);

            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvListNCCVatTu.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC("LNCC02", txtTimKiem.Text);
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
        }
    }
}
