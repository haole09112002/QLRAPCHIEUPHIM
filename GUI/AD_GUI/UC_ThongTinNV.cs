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
        private NhanVienDTO NV;
        public UC_ThongTinNV(NhanVienDTO nv)
        {
            NV = nv;
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            cbbTrangThai.Items.AddRange(new string[]
            {
             "Nhân Viên Hoạt Động","Nhân Viên Bị Khóa"
            });
            cbbTrangThai.SelectedIndex = 0;
            cbbTimKiem.Items.AddRange(new string[]
            {
                "Mã Nhân Viên","Tên Nhân Viên","SDT"
            });
            cbbSapXep.Items.AddRange(new string[]
            {
                "Tên A->Z","Tên Z->A"
            });

            loadDGVDSNhanVien("1");
        }
        public void loadDGVDSNhanVien(string trangthai="1")
        {
            dgvDSNhanVien.DataSource = NhanVienBLL.Instance.GetAllNhanVienView(trangthai);
            dgvDSNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDSNhanVien.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvDSNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDSNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvDSNhanVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDSNhanVien.Columns["MaChinhSach"].HeaderText = "Mã Chính Sách";
            dgvDSNhanVien.Columns["TenChinhSach"].HeaderText = "Tên Chính Sách";
            dgvDSNhanVien.Columns["MaChucVu"].HeaderText = "Mã Chức Vụ";
            dgvDSNhanVien.Columns["TenChucVu"].HeaderText = "Tên Chức Vụ";
            dgvDSNhanVien.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDSNhanVien.Columns["MaChinhSach"].Visible = false;
            dgvDSNhanVien.Columns["MaChucVu"].Visible = false;
            dgvDSNhanVien.Columns["TrangThai"].Visible = false;
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
            else if (dgvDSNhanVien.SelectedRows.Count == 1)
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
                dgvDSNhanVien.DataSource = NhanVienBLL.Instance.SortNhanVien(NhanVienBLL.Instance.GetNhanVienViewDGV(now), dkSapXep);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedItem == "Mã Nhân Viên")
                dgvDSNhanVien.DataSource = NhanVienBLL.Instance.TimTheoMaNV(txtTimKiem.Text);
            if (cbbTimKiem.SelectedItem == "Tên Nhân Viên")
                dgvDSNhanVien.DataSource = NhanVienBLL.Instance.TimTheoTenNV(txtTimKiem.Text);
            if (cbbTimKiem.SelectedItem == "SDT")
                dgvDSNhanVien.DataSource = NhanVienBLL.Instance.TimTheoSDT(txtTimKiem.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (dgvDSNhanVien.SelectedRows.Count <= 0)
                {
                 MessageBox.Show("Mời Chọn 1 Nhân Viên");
                }
            else
                {
               
                 string maNhanVien = dgvDSNhanVien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                if(maNhanVien == NV.MaNhanVien)
                {
                    MessageBox.Show("Không Thể Xóa Nhân Viên Đang Đăng Nhập");
                }
                else
                {
                    if (cbbTrangThai.SelectedIndex == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        NhanVienBLL.CapNhatTrangThaiNhanVien(maNhanVien, "0");
                        loadDGVDSNhanVien("1");
                    }

                    if (cbbTrangThai.SelectedIndex == 1)
                    {
                        DialogResult result = MessageBox.Show("Bạn muốn khôi phục?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        NhanVienBLL.CapNhatTrangThaiNhanVien(maNhanVien, "1");
                        loadDGVDSNhanVien("0");
                    }
                }
            
 
            }
            
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTrangThai.SelectedIndex == 0)
            {
                loadDGVDSNhanVien("1");
                btnDelete.Text = "XÓA";
            }
            else
            {
                loadDGVDSNhanVien("0");
                btnDelete.Text = "KHÔI PHỤC";
            }
        }
    }
}
