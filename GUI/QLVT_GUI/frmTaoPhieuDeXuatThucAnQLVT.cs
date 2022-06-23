using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class FrmTaoPhieuDeXuatThucAnQLVT : Form
    {
        DataTable dtDeXuatThucAn = new DataTable();
        DataTable dsDexuatThucAn = new DataTable();
        NhanVienDTO nhanVien = new NhanVienDTO();
        public FrmTaoPhieuDeXuatThucAnQLVT(NhanVienDTO nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
            SetDataTable();
            ReLoad();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            lblValidNoiDung.Visible = false;
            lblValidSoLuong.Visible = false;
        }
        public void ReLoad(string timKiem = "")
        {
            dsDexuatThucAn.Rows.Clear();
            txtTimKiem.ForeColor = Color.Silver;
            txtMaThucAn.Text = "";
            txtDonViTinh.Text = "";
            nUDSoLuong.Value = 0;
            txtNoiDung.Text = "";
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnChinhSua.Visible = false;
            nUDSoLuong.Enabled = false;
            txtNoiDung.Enabled = false;
            txtTimKiem.Text = "Nhập tên thức ăn";
            txtDonViTinh.Text = "Thùng";
            foreach (ThucAnViewDTO i in ThucAnBLL.Instance.GetThucAnViews(timKiem))
            {
                dsDexuatThucAn.Rows.Add(i.MaThucAn, i.TenThucAn);
            }
            dgvListThucAn.DataSource = dsDexuatThucAn;
        }
        public void SetDataTable()
        {

            dtDeXuatThucAn.Columns.Add("Mã Thức Ăn");
            dtDeXuatThucAn.Columns.Add("Tên Thức Ăn");
            dtDeXuatThucAn.Columns.Add("Số Lượng");
            dtDeXuatThucAn.Columns.Add("Đơn Vị Tính");
            dtDeXuatThucAn.Columns.Add("Nội Dung");
            dsDexuatThucAn.Columns.Add("Mã Thức Ăn");
            dsDexuatThucAn.Columns.Add("Tên Thức Ăn");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa lưu có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
            this.Close();
            }
        }
        public bool KiemTraTonTai(string maSanPham)
        {

            for (int i = 0; i < dgvListDeXuatThucAn.Rows.Count; i++)
            {
                if (dgvListDeXuatThucAn.Rows[i].Cells["Mã Thức Ăn"].Value.ToString() == maSanPham)
                {
                    MessageBox.Show("Sản Phẩm đã được đề xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        public bool CheckValidated()
        {
            string check = "";
            if (nUDSoLuong.Value == 0)
            {
                lblValidSoLuong.Visible = true;
                check = "loi!";
            }
            else
            {
                lblValidSoLuong.Visible = false;
            }
            if (txtNoiDung.Text == "")
            {
                lblValidNoiDung.Visible = true;
                check = "loi!";
            }
            else
            {
                lblValidNoiDung.Visible = false;
            }
            if (check == "loi!")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai(txtMaThucAn.Text) == false)
            {
                if (CheckValidated() == true)
                {
                    foreach (DataGridViewRow i in dgvListThucAn.SelectedRows)
                    {
                        dtDeXuatThucAn.Rows.Add(i.Cells["Mã Thức Ăn"].Value.ToString(), ThucAnBLL.Instance.GetThucAnByMaThucAn(i.Cells["Mã Thức Ăn"].Value.ToString()).TenThucAn, nUDSoLuong.Value, txtDonViTinh.Text, txtNoiDung.Text);
                    }
                    dgvListDeXuatThucAn.DataSource = dtDeXuatThucAn;
                    txtMaThucAn.Text = "";
                    nUDSoLuong.Value = 0;
                    btnLuu.Enabled = true;
                    txtNoiDung.Text = "";
                    lblValidNoiDung.Visible = false;
                    lblValidSoLuong.Visible = false;
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (CheckValidated() == true)
            {
                btnChinhSua.Visible = false;
                btnThem.Visible = true;
                btnThem.Enabled = false;
                dgvListDeXuatThucAn.CurrentRow.Cells["Mã Thức Ăn"].Value = txtMaThucAn.Text;
                dgvListDeXuatThucAn.CurrentRow.Cells["Tên Thức Ăn"].Value = dgvListThucAn.CurrentRow.Cells["Tên Thức Ăn"].Value;
                dgvListDeXuatThucAn.CurrentRow.Cells["Số Lượng"].Value = nUDSoLuong.Value;
                dgvListDeXuatThucAn.CurrentRow.Cells["Nội Dung"].Value = txtNoiDung.Text;
                dgvListDeXuatThucAn.CurrentRow.Cells["Đơn Vị Tính"].Value = txtDonViTinh.Text;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListDeXuatThucAn.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dgvListDeXuatThucAn.SelectedRows)
                    {
                        dgvListDeXuatThucAn.Rows.RemoveAt(i.Index);
                    }
                btnXoa.Enabled = false;
                btnChinhSua.Visible = false;
                btnThem.Visible = true;
            }
            if (dgvListDeXuatThucAn.Rows.Count == 0)
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                DeXuatBLL.Instance.LuuDeXuat(nhanVien.MaNhanVien, DateTime.Now, "LDX03");
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                string MaThucAn = "";
                string NoiDung = "";
                string DonViTinh = "";
                int SoLuong;
                for (int i = 0; i < dgvListDeXuatThucAn.Rows.Count; i++)
                {
                    MaThucAn = dgvListDeXuatThucAn.Rows[i].Cells["Mã Thức Ăn"].Value.ToString();
                    NoiDung = dgvListDeXuatThucAn.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dgvListDeXuatThucAn.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dgvListDeXuatThucAn.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatThucAnBLL.Instance.LuuChiTietDeXuatThucAn(MaDeXuat, MaThucAn, NoiDung, DonViTinh, SoLuong, "1");
                }
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ReLoad(txtTimKiem.Text);
        }

        private void dgvListThucAn_MouseClick(object sender, MouseEventArgs e)
        {
            if (KiemTraTonTai(dgvListThucAn.CurrentRow.Cells["Mã Thức Ăn"].Value.ToString()) == false)
            {
                if (dgvListThucAn.SelectedRows.Count == 1)
                {
                    txtMaThucAn.Text = dgvListThucAn.CurrentRow.Cells["Mã Thức Ăn"].Value.ToString();
                    if (btnThem.Visible == true)
                    {
                        btnChinhSua.Visible = false;
                        btnThem.Enabled = true;
                    }
                    else
                    {
                        btnChinhSua.Visible = true;
                        btnChinhSua.Enabled = true;
                    }
                    nUDSoLuong.Enabled = true;
                    txtNoiDung.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn 1 dòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListDeXuatThucAn_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvListDeXuatThucAn.SelectedRows.Count == 1)
            {
                txtMaThucAn.Text = dgvListDeXuatThucAn.CurrentRow.Cells["Mã Thức Ăn"].Value.ToString();
                txtDonViTinh.Text = dgvListDeXuatThucAn.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
                nUDSoLuong.Enabled = true;
                txtNoiDung.Text = dgvListDeXuatThucAn.CurrentRow.Cells["Nội Dung"].Value.ToString();
                btnXoa.Enabled = true;
                btnChinhSua.Enabled = true;
                btnChinhSua.Visible = true;
                btnThem.Enabled = false;
                btnThem.Visible = false;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnXoa.Enabled = false;
                btnChinhSua.Enabled = false;
                btnThem.Enabled = false;
            }
        }
    }
}
