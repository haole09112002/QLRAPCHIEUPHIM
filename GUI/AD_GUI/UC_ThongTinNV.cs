using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.AD_GUI
{
    public partial class UC_ThongTinNV : UserControl
    {
        public UC_ThongTinNV()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            cbbTimKiem.Items.AddRange(new string[]
            {
                "Mã Nhân Viên","Tên Nhân Viên","SDT"
            });
            cbbSapXep.Items.AddRange(new string[]
            {
                "Tên A->Z","Tên Z->A"
            });
            loadDGVDSNhanVien();
        }
        public void loadDGVDSNhanVien()
        {
            dgvDSNhanVien.DataSource = NhanVienBLL.Instance.GetAllNhanVienView();
            dgvDSNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDSNhanVien.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvDSNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDSNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvDSNhanVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDSNhanVien.Columns["TenChinhSach"].HeaderText = "Tên Chính Sách";
            dgvDSNhanVien.Columns["TenChucVu"].HeaderText = "Tên Chức Vụ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.d = new frmThemNhanVien.MyDel(loadDGVDSNhanVien);
            frmThemNhanVien.ShowDialog();
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 0) { MessageBox.Show("Vui lòng chọn 1 đối tượng"); }
            else if(dgvDSNhanVien.SelectedRows.Count==1)
            {
                frmThemNhanVien f = new frmThemNhanVien(dgvDSNhanVien.SelectedRows[0].Cells["maNhanVien"].Value.ToString());
                f.d = new frmThemNhanVien.MyDel(loadDGVDSNhanVien);
                f.ShowDialog();
            }
            else if (dgvDSNhanVien.SelectedRows.Count > 1) { MessageBox.Show("Bạn chỉ có thể chọn 1 đối tượng"); }
        }
        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }
        private void Sort()
        {
            if (cbbSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbbSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvDSNhanVien.Rows)
                {
                    now.Add(row.Cells["MaNhanVien"].Value.ToString());
                }
                dgvDSNhanVien.DataSource = NhanVienBLL.Instance.SortNhanVien(NhanVienBLL.Instance.GetNhanVienViewDGV(now),dkSapXep);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cbbTimKiem.SelectedItem== "Mã Nhân Viên")
            dgvDSNhanVien.DataSource = NhanVienBLL.Instance.TimTheoMaNV(txtTimKiem.Text);
            if (cbbTimKiem.SelectedItem == "Tên Nhân Viên")
            dgvDSNhanVien.DataSource = NhanVienBLL.Instance.TimTheoTenNV(txtTimKiem.Text);
            if (cbbTimKiem.SelectedItem == "SDT")
            dgvDSNhanVien.DataSource = NhanVienBLL.Instance.TimTheoSDT(txtTimKiem.Text);
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    string maNhanVien = txtTimKiem.Text;
        //    NhanVienDTO nhanVien = new NhanVienDTO();
        //    NhanVienBLL.DeleteNhanVien(maNhanVien);
        //    dgvDSNhanVien.DataSource = NhanVienBLL.Instance.GetAllNhanVienView();
        //}   
    }
}
