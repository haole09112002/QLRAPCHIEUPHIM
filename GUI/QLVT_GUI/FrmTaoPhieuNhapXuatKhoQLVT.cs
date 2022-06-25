using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class FrmTaoPhieuNhapXuatKhoQLVT : Form
    {
        DataTable dtDanhSachSanPham = new DataTable();
        DataTable dtSanPhamDaThem = new DataTable();
        NhanVienDTO nhanvien = new NhanVienDTO();
        public FrmTaoPhieuNhapXuatKhoQLVT(NhanVienDTO nhanvien, string txt)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
            txtLoaiSanPham.Text = txt;
            SetCBB();
            SetDataTable();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            nUDSoLuong.Enabled = false;
            lblChonLoaiPhieu.Visible = false;
            lblChonKho.Visible = false;
        }
        public void SetCBB()
        {
            foreach (LoaiPhieuDTO i in LoaiPhieuBLL.Instance.GetAllLoaiPhieu())
            {
                cboLoaiPhieu.Items.Add(new CBBItem
                {
                    Value = i.MaLoaiPhieu,
                    Text = i.TenLoaiPhieu
                });
            }
            foreach (KhoDTO i in KhoBLL.Instance.GetAllKho())
            {
                if (txtLoaiSanPham.Text == "Vật tư")
                {
                    if (i.MaLoaiKho == "LK002")
                    {
                        cboMaKho.Items.Add(new CBBItem
                        {
                            Value = i.MaKho,
                            Text = i.TenKho
                        });
                    }
                }
                if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                {
                    if (i.MaLoaiKho == "LK003")
                    {
                        cboMaKho.Items.Add(new CBBItem
                        {
                            Value = i.MaKho,
                            Text = i.TenKho
                        });
                    }
                }
            }
        }
        public void SetDataTable()
        {
            dtDanhSachSanPham.Columns.Add("Mã Sản Phẩm");
            dtDanhSachSanPham.Columns.Add("Tên Sản Phẩm");
            dtSanPhamDaThem.Columns.Add("Mã Sản Phẩm");
            dtSanPhamDaThem.Columns.Add("Loại Phiếu");
            dtSanPhamDaThem.Columns.Add("Tên Kho");
            dtSanPhamDaThem.Columns.Add("Tên Sản Phẩm");
            dtSanPhamDaThem.Columns.Add("Số Lượng");
            dtSanPhamDaThem.Columns.Add("Đơn Vị Tính");
        }
        public void ReLoad()
        {
            dtDanhSachSanPham.Rows.Clear();
            nUDSoLuong.Enabled = false;
            txtTenSanPham.Text = "";
            txtMaSanPham.Text = "";
            txtDonViTinh.Text = "";
            nUDSoLuong.Value = 0;
            btnThem.Enabled = false;
            btnThem.Visible = true;
            btnChinhSua.Visible = false;
            btnLuu.Enabled = false;
            lblValidatedSoLuong.Visible = false;
            lblValidSoLuong.Visible = false;
            btnXoa.Enabled = false;
            if (((CBBItem)cboLoaiPhieu.SelectedItem).Value == "LP001")
            {
                if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                {
                    foreach (string i in HopDongThucAnBLL.Instance.GetDanhSachMaThucAnCoHopDong())
                    {
                        if (HopDongThucAnBLL.Instance.GetChiTietTSLThucAnByMaThucAn(i).TongSoLuongThucAn - ChiTietPhieuThucAnBLL.Instance.GetTongSoLuongThucAnTrongPhieuNhap(i) > 0)
                        {
                            dtDanhSachSanPham.Rows.Add(i, ThucAnBLL.Instance.GetThucAnByMaThucAn(i).TenThucAn);
                        }
                    }
                }
                if (txtLoaiSanPham.Text == "Vật tư")
                {
                    foreach (string i in HopDongVatTuBLL.Instance.GetDanhSachMaVatTuCoHopDong())
                    {
                        if (HopDongVatTuBLL.Instance.GetChiTietTSLVatTuByMaVatTu(i).TongSoLuongVatTu - ChiTietPhieuVatTuBLL.Instance.GetTongSoLuongVatTuTrongPhieuNhap(i) > 0)
                        {
                            dtDanhSachSanPham.Rows.Add(i, VatTuBLL.Instance.GetVatTuByMaVatTu(i).TenVatTu);
                        }
                    }
                }
            }
            else
            {
                if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                {
                    foreach (ThucAnDTO i in ChiTietKhoThucAnBLL.Instance.GetListThucAnByMaKho(((CBBItem)cboMaKho.SelectedItem).Value))
                    {
                        if (ChiTietKhoThucAnBLL.Instance.GetChiTietKhoThucAnByKho(((CBBItem)cboMaKho.SelectedItem).Value, i.MaThucAn).SoLuongSP > 0)
                        {
                            dtDanhSachSanPham.Rows.Add(i.MaThucAn, i.TenThucAn);
                        }
                    }
                }
                if (txtLoaiSanPham.Text == "Vật tư")
                {
                    foreach (VatTuDTO i in ChiTietKhoVatTuBLL.Instance.GetListVatTuByMaKho(((CBBItem)cboMaKho.SelectedItem).Value))
                    {
                        if (ChiTietKhoVatTuBLL.Instance.GetChiTietKhoVatTuByKho(((CBBItem)cboMaKho.SelectedItem).Value, i.MaVatTu).SoLuongSP > 0)
                        {
                            dtDanhSachSanPham.Rows.Add(i.MaVatTu, i.TenVatTu);
                        }
                    }
                }
            }
            dgvListSanPham.DataSource = dtDanhSachSanPham;
            dgvListSanPham.Columns["Mã Sản Phẩm"].Visible = false;
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
        private void cboMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiPhieu.SelectedIndex < 0)
            {
                lblChonLoaiPhieu.Visible = true;
                lblChonKho.Visible = false;
            }
            else
            {
                lblChonLoaiPhieu.Visible = false;
                lblChonKho.Visible = false;
                ReLoad();
            }
        }

        private void cboLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKho.SelectedIndex < 0)
            {
                lblChonKho.Visible = true;
                lblChonLoaiPhieu.Visible = false;
            }
            else
            {
                lblChonKho.Visible = false;
                lblChonLoaiPhieu.Visible = false;
                ReLoad();
            }
        }

        private void nUDSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (((CBBItem)cboLoaiPhieu.SelectedItem).Value == "LP002")
            {
                if (nUDSoLuong.Value == nUDSoLuong.Maximum)
                {
                    lblValidatedSoLuong.Visible = true;
                    btnThem.Visible = true;
                    btnThem.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
                else
                {
                    if (nUDSoLuong.Value == 0)
                    {
                        btnThem.Visible = true;
                        btnThem.Enabled = false;
                        btnChinhSua.Enabled = false;
                    }
                    else
                    {
                        lblValidatedSoLuong.Visible = false;
                        btnThem.Enabled = true;
                        btnThem.Visible = true;
                        btnChinhSua.Enabled = true;
                    }
                }
            }
            else
            {
                if (nUDSoLuong.Value == nUDSoLuong.Maximum)
                {
                    lblValidSoLuong.Visible = true;
                    btnThem.Visible = true;
                    btnThem.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
                else
                {
                    if (nUDSoLuong.Value == 0)
                    {
                        btnThem.Visible = true;
                        btnThem.Enabled = false;
                        btnChinhSua.Enabled = false;
                    }
                    else
                    {
                        lblValidSoLuong.Visible = false;
                        btnThem.Visible = true;
                        btnThem.Enabled = true;
                        btnChinhSua.Enabled = true;
                    }
                }
            }
            if (btnChinhSua.Visible == true)
            {
                btnThem.Visible = false;
            }
        }
        public bool KiemTraTonTai(string maSanPham)
        {
            for (int i = 0; i < dgvSanPhamDaThem.Rows.Count; i++)
            {
                if (dgvSanPhamDaThem.Rows[i].Cells["Mã Sản Phẩm"].Value.ToString() == maSanPham)
                {
                    MessageBox.Show("Sản Phẩm đã được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai(txtMaSanPham.Text) == false)
            {
                dtSanPhamDaThem.Rows.Add(txtMaSanPham.Text, cboLoaiPhieu.Text, cboMaKho.Text, txtTenSanPham.Text, nUDSoLuong.Value, txtDonViTinh.Text);
                dgvSanPhamDaThem.DataSource = dtSanPhamDaThem;
                btnLuu.Enabled = true;
                txtMaSanPham.Text = "";
                txtTenSanPham.Text = "";
                nUDSoLuong.Value = 0;
                nUDSoLuong.Enabled = false;
                txtDonViTinh.Text = "";
                btnChinhSua.Visible = false;
            }
            cboLoaiPhieu.Enabled = false;
            cboMaKho.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (dialogResult == DialogResult.OK)
            {
                foreach (DataGridViewRow i in dgvSanPhamDaThem.SelectedRows)
                {
                    dgvSanPhamDaThem.Rows.RemoveAt(i.Index);
                }
                btnXoa.Enabled = false;
                btnChinhSua.Visible = false;
                btnThem.Visible = true;
            }
            if (dgvSanPhamDaThem.Rows.Count == 0)
            {
                btnLuu.Enabled = false;
                cboLoaiPhieu.Enabled = true;
                cboMaKho.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void dgvListSanPham_MouseClick(object sender, MouseEventArgs e)
        {
                if (dgvListSanPham.SelectedRows.Count == 1)
                {
                if (KiemTraTonTai(dgvListSanPham.CurrentRow.Cells["Mã Sản Phẩm"].Value.ToString()) == false)
                {
                    if (btnThem.Visible == true)
                    {
                        btnChinhSua.Visible = false;
                    }
                    else
                    {
                        if (nUDSoLuong.Value == 0)
                        {
                            btnChinhSua.Enabled = false;
                        }
                        else
                        {
                            btnChinhSua.Visible = true;
                            btnChinhSua.Enabled = true;
                        }
                    }

                    txtMaSanPham.Text = dgvListSanPham.CurrentRow.Cells["Mã Sản Phẩm"].Value.ToString();
                    txtTenSanPham.Text = dgvListSanPham.CurrentRow.Cells["Tên Sản Phẩm"].Value.ToString();
                    if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                    {
                        txtDonViTinh.Text = ChiTietKhoThucAnBLL.Instance.GetChiTietKhoThucAnByMaThucAn(txtMaSanPham.Text).DonViTinh;
                    }
                    else
                    {
                        txtDonViTinh.Text = ChiTietKhoVatTuBLL.Instance.GetChiTietKhoVatTuByMaVatTu(txtMaSanPham.Text).DonViTinh;
                    }
                    nUDSoLuong.Enabled = true;
                    if (((CBBItem)cboLoaiPhieu.SelectedItem).Value == "LP002")
                    {
                        if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                        {
                            nUDSoLuong.Maximum = ChiTietKhoThucAnBLL.Instance.GetChiTietKhoThucAnByKhoa(((CBBItem)cboMaKho.SelectedItem).Value, txtMaSanPham.Text).SoLuongSP;
                        }
                        else
                        {
                            nUDSoLuong.Maximum = ChiTietKhoVatTuBLL.Instance.GetChiTietKhoVatTuByKhoa(((CBBItem)cboMaKho.SelectedItem).Value, txtMaSanPham.Text).SoLuongSP;
                        }
                    }
                    else
                    {
                        if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                        {
                            nUDSoLuong.Maximum = HopDongThucAnBLL.Instance.GetChiTietTSLThucAnByMaThucAn(txtMaSanPham.Text).TongSoLuongThucAn - ChiTietPhieuThucAnBLL.Instance.GetTongSoLuongThucAnTrongPhieuNhap(txtMaSanPham.Text);
                        }
                        else
                        {
                            nUDSoLuong.Maximum = HopDongVatTuBLL.Instance.GetChiTietTSLVatTuByMaVatTu(txtMaSanPham.Text).TongSoLuongVatTu - ChiTietPhieuVatTuBLL.Instance.GetTongSoLuongVatTuTrongPhieuNhap(txtMaSanPham.Text);
                        }
                    }
                }
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn 1 dòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận Lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                PhieuBLL.Instance.LuuPhieu(((CBBItem)cboLoaiPhieu.SelectedItem).Value, ((CBBItem)cboMaKho.SelectedItem).Value, nhanvien.MaNhanVien, DateTime.Today);
                string MaPhieu = PhieuBLL.Instance.GetMaPhieuAddNew();
                if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                {
                    List<ChiTietKhoThucAnDTO> data = new List<ChiTietKhoThucAnDTO>();
                    for (int i = 0; i < dgvSanPhamDaThem.Rows.Count; i++)
                    {
                        ChiTietPhieuThucAnBLL.Instance.LuuChiTietPhieuThucAn(MaPhieu, dgvSanPhamDaThem.Rows[i].Cells["Mã Sản Phẩm"].Value.ToString(), dgvSanPhamDaThem.Rows[i].Cells["Đơn Vị Tính"].Value.ToString(), Convert.ToInt32(dgvSanPhamDaThem.Rows[i].Cells["Số Lượng"].Value.ToString()));
                        data.Add(new ChiTietKhoThucAnDTO
                        {
                            MaKho = ((CBBItem)cboMaKho.SelectedItem).Value,
                            MaThucAn = dgvSanPhamDaThem.Rows[i].Cells["Mã Sản Phẩm"].Value.ToString(),
                            DonViTinh = dgvSanPhamDaThem.Rows[i].Cells["Đơn Vị Tính"].Value.ToString(),
                            SoLuongSP = Convert.ToInt32(dgvSanPhamDaThem.Rows[i].Cells["Số Lượng"].Value.ToString())
                        });
                    }
                    ChiTietKhoThucAnBLL.Instance.ThemCapNhatChiTietKhoThucAn(data, ((CBBItem)cboLoaiPhieu.SelectedItem).Value);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    List<ChiTietKhoVatTuDTO> data = new List<ChiTietKhoVatTuDTO>();
                    for (int i = 0; i < dgvSanPhamDaThem.Rows.Count; i++)
                    {
                        ChiTietPhieuVatTuBLL.Instance.LuuChiTietPhieuVatTu(MaPhieu, dgvSanPhamDaThem.Rows[i].Cells["Mã Sản Phẩm"].Value.ToString(), dgvSanPhamDaThem.Rows[i].Cells["Đơn Vị Tính"].Value.ToString(), Convert.ToInt32(dgvSanPhamDaThem.Rows[i].Cells["Số Lượng"].Value.ToString()));
                        data.Add(new ChiTietKhoVatTuDTO
                        {
                            MaKho = ((CBBItem)cboMaKho.SelectedItem).Value,
                            MaVatTu = dgvSanPhamDaThem.Rows[i].Cells["Mã Sản Phẩm"].Value.ToString(),
                            DonViTinh = dgvSanPhamDaThem.Rows[i].Cells["Đơn Vị Tính"].Value.ToString(),
                            SoLuongSP = Convert.ToInt32(dgvSanPhamDaThem.Rows[i].Cells["Số Lượng"].Value.ToString())
                        });
                    }
                    ChiTietKhoVatTuBLL.Instance.ThemCapNhatChiTietKhoVatTu(data, ((CBBItem)cboLoaiPhieu.SelectedItem).Value);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void dgvSanPhamDaThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvSanPhamDaThem.SelectedRows.Count == 1)
            {
                txtMaSanPham.Text = dgvSanPhamDaThem.CurrentRow.Cells["Mã Sản Phẩm"].Value.ToString();
                txtTenSanPham.Text = dgvSanPhamDaThem.CurrentRow.Cells["Tên Sản Phẩm"].Value.ToString();
                txtDonViTinh.Text = dgvSanPhamDaThem.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
                nUDSoLuong.Enabled = true;
                btnXoa.Enabled = true;
                btnChinhSua.Enabled = false;
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

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Visible = false;
            btnThem.Visible = true;
            btnThem.Enabled = false;
            dgvSanPhamDaThem.CurrentRow.Cells["Mã Sản Phẩm"].Value = txtMaSanPham.Text;
            dgvSanPhamDaThem.CurrentRow.Cells["Tên Sản Phẩm"].Value = txtTenSanPham.Text;
            dgvSanPhamDaThem.CurrentRow.Cells["Số Lượng"].Value = nUDSoLuong.Text;
            dgvSanPhamDaThem.CurrentRow.Cells["Đơn Vị Tính"].Value = txtDonViTinh.Text;
        }
    }
}
