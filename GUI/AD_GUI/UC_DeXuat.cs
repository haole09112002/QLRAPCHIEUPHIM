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

namespace GUI.AD_GUI
{
    public partial class UC_DeXuat : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        DataTable dtDeXuat = new DataTable();
        DataTable dtDaDeXuat = new DataTable();
        NhanVienDTO nhanvien = new NhanVienDTO();

        public UC_DeXuat()
        {
            InitializeComponent();
            SetGUI();

        }
        public void SetGUI()
        {
            //cbbDeXuat.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbbDeXuat.Items.AddRange(LoaiDeXuatBLL.Instance.GetCBBLoaiDeXuat().ToArray());
            cbbDeXuat.SelectedIndex = 0;
            string maLoaiDeXuat = ((CBBItem)cbbDeXuat.SelectedItem).Value.ToString();
            loadDGVDeXuat(maLoaiDeXuat);
            loadDGVDaDeXuat(maLoaiDeXuat);

        }

        public void loadDGVDeXuat(string maLoaiDeXuat)
        {
            dgvChiTietdeXuat.DataSource = null;
            if (maLoaiDeXuat == "LDX01")
            {
                dgvChiTietdeXuat.DataSource = ChiTietDeXuatPhimBLL.Instance.GetChiTietDeXuatPhimViewByTinhTrang("1");
            }
            if (maLoaiDeXuat == "LDX02")
            {
                dgvChiTietdeXuat.DataSource = ChiTietDeXuatVatTuBLL.Instance.GetChiTietDeXuatVatTuViewByTinhTrang("1");
            }
            if (maLoaiDeXuat == "LDX03")
            {
                dgvChiTietdeXuat.DataSource = ChiTietDeXuatThucAnBLL.Instance.GetChiTietDeXuatThucAnViewByTinhTrang("1");
            }

            dgvChiTietdeXuat.Columns["MaDeXuat"].HeaderText = "Mã Đề Xuất";
            dgvChiTietdeXuat.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvChiTietdeXuat.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (maLoaiDeXuat == "LDX01")
            {
                dgvChiTietdeXuat.Columns["TenPhim"].HeaderText = "Tên Phim";
            }
            if (maLoaiDeXuat == "LDX02")
            {
                dgvChiTietdeXuat.Columns["TenVatTu"].HeaderText = "Tên Vật Tư";
            }
            if (maLoaiDeXuat == "LDX03")
            {
                dgvChiTietdeXuat.Columns["TenThucAn"].HeaderText = "Tên Thức Ăn";
            }
            dgvChiTietdeXuat.Columns[1].Visible = false;
        }
        public void loadDGVDaDeXuat(string maLoaiDeXuat)
        {
            dgvDaDeXuat.DataSource = null;
            if (maLoaiDeXuat == "LDX01")
            {
                dgvDaDeXuat.DataSource = ChiTietDeXuatPhimBLL.Instance.GetChiTietDeXuatPhimViewByTinhTrang("2");
            }
            if (maLoaiDeXuat == "LDX02")
            {
                dgvDaDeXuat.DataSource = ChiTietDeXuatVatTuBLL.Instance.GetChiTietDeXuatVatTuViewByTinhTrang("2");
            }
            if (maLoaiDeXuat == "LDX03")
            {
                dgvDaDeXuat.DataSource = ChiTietDeXuatThucAnBLL.Instance.GetChiTietDeXuatThucAnViewByTinhTrang("2");
            }
            dgvDaDeXuat.Columns["MaDeXuat"].HeaderText = "Mã Đề Xuất";
            dgvDaDeXuat.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvDaDeXuat.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (maLoaiDeXuat == "LDX01")
            {
                dgvDaDeXuat.Columns["TenPhim"].HeaderText = "Tên Phim";
            }
            if (maLoaiDeXuat == "LDX02")
            {
                dgvDaDeXuat.Columns["TenVatTu"].HeaderText = "Tên Vật Tư";
            }
            if (maLoaiDeXuat == "LDX03")
            {
                dgvDaDeXuat.Columns["TenThucAn"].HeaderText = "Tên Thức Ăn";
            }
            dgvDaDeXuat.Columns[1].Visible = false;

        }
        private void cbbDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDeXuat.SelectedItem != null)
            {
                string maLoaiDeXuat = ((CBBItem)cbbDeXuat.SelectedItem).Value.ToString();
                loadDGVDeXuat(maLoaiDeXuat);
                loadDGVDaDeXuat(maLoaiDeXuat);
            }
        }
        private void Sort()
        {
            if (cbbDeXuat.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbbDeXuat.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvChiTietdeXuat.Rows)
                {
                    now.Add(row.Cells["MaDeXuat"].Value.ToString());
                }
                dgvChiTietdeXuat.DataSource = DeXuatBLL.Instance.SortDeXuat(DeXuatBLL.Instance.GetDeXuatViewDGV(now), dkSapXep);
            }
        }

        private void btnTKdeXuat_Click(object sender, EventArgs e)
        {
            if (cbbTimKiemDeXuat.SelectedItem == "Mã Đề Xuất")
            {
                string maLoaiDeXuat = ((CBBItem)cbbDeXuat.SelectedItem).Value.ToString();
                if(maLoaiDeXuat=="LDX01")
                {
                    dgvChiTietdeXuat.DataSource= ChiTietDeXuatPhimBLL.Instance.TimKiemChiTietDXPByMaDeXuat(txtTKdeXuat.Text,"1");
                }
                if (maLoaiDeXuat == "LDX02")
                {
                    dgvChiTietdeXuat.DataSource = ChiTietDeXuatVatTuBLL.Instance.TimKiemChiTietDXVTByMaDeXuat(txtTKdeXuat.Text,"1");
                }
                if (maLoaiDeXuat == "LDX03")
                {
                    dgvChiTietdeXuat.DataSource = ChiTietDeXuatThucAnBLL.Instance.TimKiemChiTietDXTAByMaDeXuat(txtTKdeXuat.Text,"1");
                }
            }
            if (cbbTimKiemDeXuat.SelectedItem == "Tên Sản Phẩm")
            {
                string maLoaiDeXuat = ((CBBItem)cbbDeXuat.SelectedItem).Value.ToString();
                if (maLoaiDeXuat == "LDX01")
                {
                    dgvChiTietdeXuat.DataSource = ChiTietDeXuatPhimBLL.Instance.TimKiemChiTietDXPByTenPhim(txtTKdeXuat.Text, "1");
                }
                if (maLoaiDeXuat == "LDX02")
                {
                    dgvChiTietdeXuat.DataSource = ChiTietDeXuatVatTuBLL.Instance.TimKiemChiTietDXPByTenVatTu(txtTKdeXuat.Text, "1");
                }
                if (maLoaiDeXuat == "LDX03")
                {
                    dgvChiTietdeXuat.DataSource = ChiTietDeXuatThucAnBLL.Instance.TimKiemChiTietDXPByTenThucAn(txtTKdeXuat.Text, "1");
                }
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (dgvChiTietdeXuat.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn 1 đối tượng");
            }
            else
            {
                string maDeXuat = dgvChiTietdeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString();
                string maSP = dgvChiTietdeXuat.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn muốn thêm đề xuất?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DeXuatBLL.Instance.GetDeXuatByMaDeXuat(maDeXuat).MaLoaiDeXuat == "LDX01")
                {
                    ChiTietDeXuatPhimBLL.Instance.CapNhatTinhTrangDeXuat(maSP, maDeXuat, "2");
                    loadDGVDeXuat("LDX01");
                    loadDGVDaDeXuat("LDX01");
                }
                if (DeXuatBLL.Instance.GetDeXuatByMaDeXuat(maDeXuat).MaLoaiDeXuat == "LDX02")
                {
                    ChiTietDeXuatVatTuBLL.Instance.CapNhatTinhTrangDeXuat(maSP, maDeXuat, "2");
                    loadDGVDeXuat("LDX02");
                    loadDGVDaDeXuat("LDX02");
                }
                if (DeXuatBLL.Instance.GetDeXuatByMaDeXuat(maDeXuat).MaLoaiDeXuat == "LDX03")
                {
                    ChiTietDeXuatThucAnBLL.Instance.CapNhatTinhTrangDeXuat(maSP, maDeXuat, "2");
                    loadDGVDeXuat("LDX03");
                    loadDGVDaDeXuat("LDX03");
                }



            }
        }

        private void btnKhongDongY_Click(object sender, EventArgs e)
        {
            if (dgvChiTietdeXuat.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn 1 đối tượng");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn hủy đề xuất?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                string maDeXuat = dgvChiTietdeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString();
                string maSP = dgvChiTietdeXuat.SelectedRows[0].Cells[1].Value.ToString();
                if (DeXuatBLL.Instance.GetDeXuatByMaDeXuat(maDeXuat).MaLoaiDeXuat == "LDX01")
                {
                    ChiTietDeXuatPhimBLL.Instance.CapNhatTinhTrangDeXuat(maSP, maDeXuat, "0");
                    loadDGVDeXuat("LDX01");
                    loadDGVDaDeXuat("LDX01");
                }
                if (DeXuatBLL.Instance.GetDeXuatByMaDeXuat(maDeXuat).MaLoaiDeXuat == "LDX02")
                {
                    ChiTietDeXuatVatTuBLL.Instance.CapNhatTinhTrangDeXuat(maSP, maDeXuat, "0");
                    loadDGVDeXuat("LDX02");
                    loadDGVDaDeXuat("LDX02");
                }
                if (DeXuatBLL.Instance.GetDeXuatByMaDeXuat(maDeXuat).MaLoaiDeXuat == "LDX03")
                {
                    ChiTietDeXuatThucAnBLL.Instance.CapNhatTinhTrangDeXuat(maSP, maDeXuat, "0");
                    loadDGVDeXuat("LDX03");
                    loadDGVDaDeXuat("LDX03");
                }
            }
        }

        private void btnTimKiemDaDeXuat_Click(object sender, EventArgs e)
        {
            if (cbbTimKiemDadeXuat.SelectedItem == "Mã Đề Xuất")
            {
                string maLoaiDeXuat = ((CBBItem)cbbDeXuat.SelectedItem).Value.ToString();
                if (maLoaiDeXuat == "LDX01")
                {
                    dgvDaDeXuat.DataSource = ChiTietDeXuatPhimBLL.Instance.TimKiemChiTietDXPByMaDeXuat(txtTimKiemDaDeXuat.Text, "2");
                }
                if (maLoaiDeXuat == "LDX02")
                {
                    dgvDaDeXuat.DataSource = ChiTietDeXuatVatTuBLL.Instance.TimKiemChiTietDXVTByMaDeXuat(txtTimKiemDaDeXuat.Text, "2");
                }
                if (maLoaiDeXuat == "LDX03")
                {
                    dgvDaDeXuat.DataSource = ChiTietDeXuatThucAnBLL.Instance.TimKiemChiTietDXTAByMaDeXuat(txtTimKiemDaDeXuat.Text, "2");
                }
            }
            if (cbbTimKiemDadeXuat.SelectedItem == "Tên Sản Phẩm")
            {
                string maLoaiDeXuat = ((CBBItem)cbbDeXuat.SelectedItem).Value.ToString();
                if (maLoaiDeXuat == "LDX01")
                {
                    dgvDaDeXuat.DataSource = ChiTietDeXuatPhimBLL.Instance.TimKiemChiTietDXPByTenPhim(txtTimKiemDaDeXuat.Text, "2");
                }
                if (maLoaiDeXuat == "LDX02")
                {
                    dgvDaDeXuat.DataSource = ChiTietDeXuatVatTuBLL.Instance.TimKiemChiTietDXPByTenVatTu(txtTimKiemDaDeXuat.Text, "2");
                }
                if (maLoaiDeXuat == "LDX03")
                {
                    dgvDaDeXuat.DataSource = ChiTietDeXuatThucAnBLL.Instance.TimKiemChiTietDXPByTenThucAn(txtTimKiemDaDeXuat.Text, "2");
                }
            }
        }
    }
}
    

