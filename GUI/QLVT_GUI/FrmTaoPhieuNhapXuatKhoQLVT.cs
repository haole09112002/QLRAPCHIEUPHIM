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
            btnChinhSua.Visible = false;
            btnThem.Enabled = false;
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
            dtDanhSachSanPham.Columns.Add("Số Lượng");
            dtDanhSachSanPham.Columns.Add("Đơn Vị Tính");
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
            txtMaSanPham.Text = "";
            txtDonViTinh.Text = "";
            nUDSoLuong.Value = 0;
            btnThem.Enabled = false;
            lblValidatedSoLuong.Visible = false;
            lblValidSoLuong.Visible = false;
            btnXoa.Enabled = false;
            if (((CBBItem)cboLoaiPhieu.SelectedItem).Value == "LP001")
            {
                if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                {
                    foreach (HopDongThucAnDTO i in HopDongThucAnBLL.Instance.GetAllHopDongThucAn())
                    {
                        dtDanhSachSanPham.Rows.Add(i.MaThucAn, ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn
                            , i.SoLuong
                            , i.DonViTinh);
                    }
                }
                if (txtLoaiSanPham.Text == "Vật tư")
                {
                    foreach (HopDongVatTuDTO i in HopDongVatTuBLL.Instance.GetAllHopDongVatTu())
                    {
                        dtDanhSachSanPham.Rows.Add(i.MaVatTu, VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu
                            , i.SoLuong
                            , i.DonViTinh);
                    }
                }
                dgvListSanPham.DataSource = dtDanhSachSanPham;
                dgvListSanPham.Columns["Mã Sản Phẩm"].Visible = false;
                dgvListSanPham.Columns["Số Lượng"].Visible = false;
            }
            else
            {
                if (txtLoaiSanPham.Text == "Thức ăn nhanh")
                {
                    foreach (ChiTietKhoThucAnDTO i in ChiTietKhoThucAnBLL.Instance.GetListChiTietKhoThucAnByMaKho(((CBBItem)cboMaKho.SelectedItem).Value))
                    {
                        dtDanhSachSanPham.Rows.Add(i.MaThucAn, ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn, i.SoLuongSP, i.DonViTinh);
                    }
                }
                if (txtLoaiSanPham.Text == "Vật tư")
                {
                    foreach (ChiTietKhoVatTuDTO i in ChiTietKhoVatTuBLL.Instance.GetListChiTietKhoVatTuByMaKho(((CBBItem)cboMaKho.SelectedItem).Value))
                    {
                        dtDanhSachSanPham.Rows.Add(i.MaVatTu, VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu, i.SoLuongSP, i.DonViTinh);
                    }
                }
                dgvListSanPham.DataSource = dtDanhSachSanPham;
                dgvListSanPham.Columns["Mã Sản Phẩm"].Visible = false;
                dgvListSanPham.Columns["Số Lượng"].Visible = true;

            }
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
        }
        private void cboMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiPhieu.SelectedIndex < 0)
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

        private void dgvListSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListSanPham.SelectedRows.Count == 1)
            {
                txtMaSanPham.Text = dgvListSanPham.CurrentRow.Cells["Tên Sản Phẩm"].Value.ToString();
                txtDonViTinh.Text = dgvListSanPham.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
                nUDSoLuong.Enabled = true;
                if (((CBBItem)cboLoaiPhieu.SelectedItem).Value == "LP002")
                {
                    nUDSoLuong.Maximum = (decimal)dgvListSanPham.CurrentRow.Cells["Số Lượng"].Value; // đang sai cần sửa
                }
                else
                {
                    nUDSoLuong.Maximum = 300; //sai cần sửa phải theo hợp đồng
                }
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nUDSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (((CBBItem)cboLoaiPhieu.SelectedItem).Value == "LP002")
            {
                if (nUDSoLuong.Value > nUDSoLuong.Maximum) {
                    lblValidatedSoLuong.Visible = true;
                    btnThem.Enabled = false;
                }
                if (nUDSoLuong.Value == 0)
                {
                    btnThem.Enabled = false;
                }
            }
            else{
                if(nUDSoLuong.Value > nUDSoLuong.Maximum)
                {
                    lblValidSoLuong.Visible = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtSanPhamDaThem.Rows.Add(dgvListSanPham.SelectedRows[0].Cells["Mã Sản Phẩm"].Value.ToString(),cboLoaiPhieu.Text,cboMaKho.Text,txtMaSanPham.Text,nUDSoLuong.Value.ToString(),txtDonViTinh.Text);
            btnLuu.Enabled = true;
        }

        private void dgvSanPhamDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPhamDaThem.SelectedRows.Count == 1)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnXoa.Enabled = false;
            }
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
            }
        }
    }
}
