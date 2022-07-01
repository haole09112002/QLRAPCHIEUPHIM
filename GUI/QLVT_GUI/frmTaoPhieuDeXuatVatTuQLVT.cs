using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class FrmTaoPhieuDeXuatVatTuQLVT : Form
    {
        DataTable dtDeXuatVatTu = new DataTable();
        DataTable dsDexuatVatTu = new DataTable();
        NhanVienDTO nhanVien = new NhanVienDTO();
        public FrmTaoPhieuDeXuatVatTuQLVT(NhanVienDTO nhanVien)
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
            dsDexuatVatTu.Rows.Clear();
            txtTimKiem.ForeColor = Color.Silver;
            txtMaVatTu.Text = "";
            txtDonViTinh.Text = "";
            nUDSoLuong.Value = 0;
            txtNoiDung.Text = "";
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnChinhSua.Visible = false;
            nUDSoLuong.Enabled = false;
            txtNoiDung.Enabled = false;
            txtTimKiem.Text = "Nhập tên vật tư";
            txtDonViTinh.Text = "Cái";
            foreach (VatTuViewDTO i in VatTuBLL.Instance.GetVatTuViews(timKiem))
            {
                dsDexuatVatTu.Rows.Add(i.MaVatTu, i.TenVatTu);
            }
            dgvListVatTu.DataSource = dsDexuatVatTu;
        }
        public void SetDataTable()
        {

            dtDeXuatVatTu.Columns.Add("Mã Vật Tư");
            dtDeXuatVatTu.Columns.Add("Tên Vật Tư");
            dtDeXuatVatTu.Columns.Add("Số Lượng");
            dtDeXuatVatTu.Columns.Add("Đơn Vị Tính");
            dtDeXuatVatTu.Columns.Add("Nội Dung");
            dsDexuatVatTu.Columns.Add("Mã Vật Tư");
            dsDexuatVatTu.Columns.Add("Tên Vật Tư");
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
            this.Close();
        }
        public bool KiemTraTonTai(string maSanPham)
        {

            for (int i = 0; i < dgvListDeXuatVatTu.Rows.Count; i++)
            {
                if (dgvListDeXuatVatTu.Rows[i].Cells["Mã Vật Tư"].Value.ToString() == maSanPham)
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
            if(nUDSoLuong.Value == 0)
            {
                lblValidSoLuong.Visible = true;
                check = "loi!";
            }
            else
            {
                lblValidSoLuong.Visible = false;
            }
            if(txtNoiDung.Text == "")
            {
                lblValidNoiDung.Visible = true;
                check = "loi!";
            }
            else
            {
                lblValidNoiDung.Visible = false;
            }
            if(check == "loi!")
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
            if (KiemTraTonTai(txtMaVatTu.Text) == false)
            {
                if (CheckValidated() == true)
                {
                    foreach (DataGridViewRow i in dgvListVatTu.SelectedRows)
                    {
                        dtDeXuatVatTu.Rows.Add(i.Cells["Mã Vật Tư"].Value.ToString(), VatTuBLL.Instance.GetVatTuByMaVatTu(i.Cells["Mã Vật Tư"].Value.ToString()).TenVatTu, nUDSoLuong.Value, txtDonViTinh.Text, txtNoiDung.Text);
                    }
                    dgvListDeXuatVatTu.DataSource = dtDeXuatVatTu;
                    txtMaVatTu.Text = "";
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
                dgvListDeXuatVatTu.CurrentRow.Cells["Mã Vật Tư"].Value = txtMaVatTu.Text;
                dgvListDeXuatVatTu.CurrentRow.Cells["Tên Vật Tư"].Value = dgvListVatTu.CurrentRow.Cells["Tên Vật Tư"].Value;
                dgvListDeXuatVatTu.CurrentRow.Cells["Số Lượng"].Value = nUDSoLuong.Value;
                dgvListDeXuatVatTu.CurrentRow.Cells["Nội Dung"].Value = txtNoiDung.Text;
                dgvListDeXuatVatTu.CurrentRow.Cells["Đơn Vị Tính"].Value = txtDonViTinh.Text;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        { 
            if(dgvListDeXuatVatTu.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dgvListDeXuatVatTu.SelectedRows)
                    {
                        dgvListDeXuatVatTu.Rows.RemoveAt(i.Index);
                    }
                     btnXoa.Enabled = false;
                     btnChinhSua.Visible = false;
                     btnThem.Visible = true;
            }
            if (dgvListDeXuatVatTu.Rows.Count == 0)
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
                DeXuatBLL.Instance.LuuDeXuat(nhanVien.MaNhanVien, DateTime.Now, "LDX02");
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                string MaVatTu = "";
                string NoiDung = "";
                string DonViTinh = "";
                int SoLuong;
                for (int i = 0; i < dgvListDeXuatVatTu.Rows.Count; i++)
                {
                    MaVatTu = dgvListDeXuatVatTu.Rows[i].Cells["Mã Vật Tư"].Value.ToString();
                    NoiDung = dgvListDeXuatVatTu.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dgvListDeXuatVatTu.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dgvListDeXuatVatTu.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatVatTuBLL.Instance.LuuChiTietDeXuatVatTu(MaDeXuat, MaVatTu, NoiDung, DonViTinh, SoLuong, "1");
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

        private void dgvListVatTu_MouseClick(object sender, MouseEventArgs e)
        {
            if (KiemTraTonTai(dgvListVatTu.CurrentRow.Cells["Mã Vật Tư"].Value.ToString()) == false)
            {
                if (dgvListVatTu.SelectedRows.Count == 1)
                {
                    txtMaVatTu.Text = dgvListVatTu.CurrentRow.Cells["Mã Vật Tư"].Value.ToString();
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

        private void dgvListDeXuatVatTu_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvListDeXuatVatTu.SelectedRows.Count == 1)
            {
                txtMaVatTu.Text = dgvListDeXuatVatTu.CurrentRow.Cells["Mã Vật Tư"].Value.ToString();
                txtDonViTinh.Text = dgvListDeXuatVatTu.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
                nUDSoLuong.Enabled = true;
                txtNoiDung.Text = dgvListDeXuatVatTu.CurrentRow.Cells["Nội Dung"].Value.ToString();
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
