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
            cbbTieuChiTimKiem.Items.AddRange(new string[] { "Tên nhà cung cấp", "Mã số thuế", "Số điện thoại" });
            cbbTieuChiTimKiem.SelectedIndex = 0;
            cbLoaiNhaCungCap.SelectedItem = cbLoaiNhaCungCap.Items[0];
            loadDGVDanhSachNCC();
            loadDGVDanhSachSanPham(dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString());
        }
        public void loadDGVDanhSachNCC(string maLoaiNCC = "0", string txt = "", string tieuChiTiemKiem = "")
        {
            dgvDSNhaCungCap.DataSource = NhaCungCapBLL.Instance.GetNCCViewMaLoaiNCC(maLoaiNCC, txt , tieuChiTiemKiem);
            dgvDSNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgvDSNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvDSNhaCungCap.Columns["MaSoThue"].HeaderText = "Mã số thuế";
            dgvDSNhaCungCap.Columns["SoDienThoai"].HeaderText = "Điện thoại";
            dgvDSNhaCungCap.Columns["TenLoaiNhaCungCap"].HeaderText = "Loại SP cung cấp";
        }
        public void loadDGVDanhSachSanPham(string maNhaCungCap)
        {
            dgvDSSanPham.DataSource = NhaCungCapBLL.Instance.GetSPByMaNhaCungCap(maNhaCungCap);
            if(NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap == "LNCC01")
            {
                dgvDSSanPham.Columns["MaPhim"].HeaderText = "Mã phim";
                dgvDSSanPham.Columns["TenPhim"].HeaderText = "Tên phim";
            }
            if (NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap == "LNCC02")
            {
                dgvDSSanPham.Columns["MaVatTu"].HeaderText = "Mã vật tư";
                dgvDSSanPham.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            }
            if (NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap == "LNCC03")
            {
                dgvDSSanPham.Columns["MaThucAn"].HeaderText = "Mã thức ăn";
                dgvDSSanPham.Columns["TenThucAn"].HeaderText = "Tên thức ăn";
            }
            dgvDSSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDSSanPham.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvDSSanPham.Columns["GiaTien"].HeaderText = "Giá tiền(VND)";
        }

        private void cbLoaiNhaCungCap_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiNhaCungCap.SelectedItem != null)
            {
                loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value);
                Sort();
                loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value, txtTimKiem.Text);
            }
            
           
        }
        private void dgvDSNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSNhaCungCap.SelectedRows.Count == 1)
            {
                string maNhaCungCap = dgvDSNhaCungCap.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
                loadDGVDanhSachSanPham(maNhaCungCap);
            }
                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmThemNhaCungCap = new frmThemNhaCungCap();
            frmThemNhaCungCap.d = new frmThemNhaCungCap.Mydel(loadDGVDanhSachNCC);
            frmThemNhaCungCap.ShowDialog();
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
            loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value, txtTimKiem.Text, cbbTieuChiTimKiem.SelectedItem.ToString() );
            if(dgvDSNhaCungCap.RowCount != 0)
            {
                string maNhaCungCap = dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString();
                loadDGVDanhSachSanPham(maNhaCungCap);
            }    
           
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadDGVDanhSachNCC(((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value, txtTimKiem.Text);
                if (dgvDSNhaCungCap != null)
                {
                    string maNhaCungCap = dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString();
                    loadDGVDanhSachSanPham(maNhaCungCap);
                }

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
        private void Sort()
        {
            if (cbSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvDSNhaCungCap.Rows)
                {
                    now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
                }
                dgvDSNhaCungCap.DataSource = NhaCungCapBLL.Instance.SortNhaCungCap(NhaCungCapBLL.Instance.GetNhaCungCapViewDGV(now), dkSapXep);
                loadDGVDanhSachSanPham(dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString());
            }
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            if(dgvDSNhaCungCap.SelectedRows.Count  == 1)
            {
                string maNhaCungCap = dgvDSNhaCungCap.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
               dgvDSSanPham.DataSource =  NhaCungCapBLL.Instance.TimKiemVatTuTheoTen(maNhaCungCap, txtTimKiemSanPham.Text);
            
                if (NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap == "LNCC01")
                {
                    dgvDSSanPham.Columns["MaPhim"].HeaderText = "Mã phim";
                    dgvDSSanPham.Columns["TenPhim"].HeaderText = "Tên phim";
                }
                if (NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap == "LNCC02")
                {
                    dgvDSSanPham.Columns["MaVatTu"].HeaderText = "Mã vật tư";
                    dgvDSSanPham.Columns["TenVatTu"].HeaderText = "Tên vật tư";
                }
                if (NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap == "LNCC03")
                {
                    dgvDSSanPham.Columns["MaThucAn"].HeaderText = "Mã thức ăn";
                    dgvDSSanPham.Columns["TenThucAn"].HeaderText = "Tên thức ăn";
                }
                dgvDSSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDSSanPham.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dgvDSSanPham.Columns["GiaTien"].HeaderText = "Giá tiền(VND)";
            }    
        }

        private void cbLoaiNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhaCungCap = dgvDSNhaCungCap.Rows[0].Cells["MaNhaCungCap"].Value.ToString();
            loadDGVDanhSachSanPham(maNhaCungCap);
        }

        private void txtTimKiemSanPham_Click(object sender, EventArgs e)
        {
            if(txtTimKiemSanPham.Text == "Nhập tên")
            {
                txtTimKiemSanPham.Text = "";
            }    
        }
    }
}
