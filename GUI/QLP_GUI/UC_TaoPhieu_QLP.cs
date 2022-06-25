using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_TaoPhieu_QLP : UserControl
    {
        DataTable dtDanhSachPhim = new DataTable();
        DataTable dtPhimDaThem = new DataTable();
        NhanVienDTO nhanvien = new NhanVienDTO();
        public UC_TaoPhieu_QLP(NhanVienDTO nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
            SetCBB();
            SetDataTable();
            txtMaPhim.Visible = false;
            txtTenPhim.Enabled = false;
            btnLuu.Enabled = false;
            btnChinhSua.Visible = false;
            btnThem.Enabled = false;
        }
        public void SetCBB()
        {
            foreach (LoaiPhieuDTO i in LoaiPhieuBLL.Instance.GetAllLoaiPhieu())
            {
                cBMaLoaiPhieu.Items.Add(new CBBItem
                {
                    Value = i.MaLoaiPhieu,
                    Text = i.TenLoaiPhieu
                });
            }
            foreach (KhoDTO i in KhoBLL.Instance.GetAllKho())
            {
                if (i.MaLoaiKho == "LK001")
                {
                    cBMaKho.Items.Add(new CBBItem
                    {
                        Value = i.MaKho,
                        Text = i.TenKho
                    });
                }
            }
        }
        public void SetDataTable()
        {
            dtDanhSachPhim.Columns.Add("Mã Phim");
            dtDanhSachPhim.Columns.Add("Tên Phim");
            dtPhimDaThem.Columns.Add("Mã Phim");
            dtPhimDaThem.Columns.Add("Tên Phim");
            dtPhimDaThem.Columns.Add("Số Lượng");
            dtPhimDaThem.Columns.Add("Đơn Vị Tính");
        }
        public void ReLoad()
        {
            if (cBMaLoaiPhieu.SelectedIndex >= 0)
            {
                dtDanhSachPhim.Rows.Clear();
                if (((CBBItem)cBMaLoaiPhieu.SelectedItem).Value == "LP001")
                {
                    foreach (string i in HopDongPhimBLL.Instance.GetDanhSachMaPhimConHopDong())
                    {
                        if (HopDongPhimBLL.Instance.GetChiTietTSLPhimByMaPhim(i).TongSoLuongPhim - ChiTietPhieuPhimBLL.Instance.GetTongSoLuongPhimTrongPhieuNhap(i) > 0)
                        {
                            dtDanhSachPhim.Rows.Add(i, PhimBLL.Instance.GetPhimByMaPhim(i).TenPhim);
                        }
                    }
                }
                else
                {
                    foreach (PhimDTO i in ChiTietKhoPhimBLL.Instance.GetListPhimByMaKho(((CBBItem)cBMaKho.SelectedItem).Value))
                    {
                        if (ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKho(((CBBItem)cBMaKho.SelectedItem).Value, i.MaPhim).SoLuongSP > 0)
                            dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim);
                    }
                }
                dGVDanhSachPhim.DataSource = dtDanhSachPhim;
                dGVDanhSachPhim.Columns["Mã Phim"].Visible = false;
            }
        }
        public bool KiemTraTinhDungDangP1()
        {
            bool kiemtra = true;
            if (cBMaLoaiPhieu.SelectedIndex < 0)
            {
                lbLoaiPhieu.Text = "*Vui lòng chọn loại phiếu";
                kiemtra = false;
            }
            else
            {
                lbLoaiPhieu.Text = "";
            }
            if (cBMaKho.SelectedIndex < 0)
            {
                lbMaKho.Text = "*Vui lòng chọn kho";
                kiemtra = false;
            }
            else
            {
                lbMaKho.Text = "";
            }
            return kiemtra;
        }

        private void dGVDanhSachPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KiemTraTinhDungDangP1() == true)
            {
                txtMaPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
                txtTenPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Tên Phim"].Value.ToString();
                txtDonViTinh.Text = HopDongPhimBLL.Instance.GetHopDongPhimByMaPhim(txtMaPhim.Text).DonViTinh;
                if (((CBBItem)cBMaLoaiPhieu.SelectedItem).Value == "LP002")
                {
                    nUDSoLuong.Maximum = ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKho(((CBBItem)cBMaKho.SelectedItem).Value, txtMaPhim.Text).SoLuongSP;
                }
                else
                {
                    nUDSoLuong.Maximum = HopDongPhimBLL.Instance.GetChiTietTSLPhimByMaPhim(txtMaPhim.Text).TongSoLuongPhim - ChiTietPhieuPhimBLL.Instance.GetTongSoLuongPhimTrongPhieuNhap(txtMaPhim.Text);
                }
            }
            btnThem.Enabled = true;
        }

        public bool KiemTraTinhDungDangP2()
        {
            bool kiemtra = true;
            if (nUDSoLuong.Value == 0)
            {
                lbSoLuong.Text = "*Vui lòng nhập số lượng";
                kiemtra = false;
            }
            else
            {
                lbSoLuong.Text = "";
            }
            return kiemtra;
        }
        public bool KiemTraTonTaiMaPhim(string MaPhim)
        {
            for (int i = 0; i < dGVPhimDaThem.Rows.Count; i++)
            {
                if (dGVPhimDaThem.Rows[i].Cells["Mã Phim"].Value.ToString() == MaPhim)
                {
                    MessageBox.Show("Phim đã được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTinhDungDangP2() == true)
            {
                if (KiemTraTonTaiMaPhim(txtMaPhim.Text) == false)
                {
                    dtPhimDaThem.Rows.Add(txtMaPhim.Text, txtTenPhim.Text, nUDSoLuong.Value, txtDonViTinh.Text);
                    dGVPhimDaThem.DataSource = dtPhimDaThem;
                    dGVPhimDaThem.Columns["Mã Phim"].Visible = false;
                }
                txtMaPhim.Text = "";
                txtTenPhim.Text = "";
                nUDSoLuong.Value = 0;
                txtDonViTinh.Text = "";
                btnLuu.Enabled = true;
                cBMaKho.Enabled = false;
                cBMaLoaiPhieu.Enabled = false;
                btnThem.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dGVPhimDaThem.Rows.Count == 0)
            {
                lbPhimDaThem.Text = "*Danh sách phiếu nhập xuất không hợp lệ";
            }
            else
            {
                lbPhimDaThem.Text = "";
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                {
                    PhieuBLL.Instance.LuuPhieu(((CBBItem)cBMaLoaiPhieu.SelectedItem).Value, ((CBBItem)cBMaKho.SelectedItem).Value, nhanvien.MaNhanVien, DateTime.Today);
                    string MaPhieu = PhieuBLL.Instance.GetMaPhieuAddNew();
                    List<ChiTietKhoPhimDTO> data = new List<ChiTietKhoPhimDTO>();
                    for (int i = 0; i < dGVPhimDaThem.Rows.Count; i++)
                    {
                        ChiTietPhieuPhimBLL.Instance.LuuChiTietPhieuPhim(MaPhieu, dGVPhimDaThem.Rows[i].Cells["Mã Phim"].Value.ToString(), dGVPhimDaThem.Rows[i].Cells["Đơn Vị Tính"].Value.ToString(), Convert.ToInt32(dGVPhimDaThem.Rows[i].Cells["Số Lượng"].Value.ToString()));
                        data.Add(new ChiTietKhoPhimDTO
                        {
                            MaKho = ((CBBItem)cBMaKho.SelectedItem).Value,
                            MaPhim = dGVPhimDaThem.Rows[i].Cells["Mã Phim"].Value.ToString(),
                            DonViTinh = dGVPhimDaThem.Rows[i].Cells["Đơn Vị Tính"].Value.ToString(),
                            SoLuongSP = Convert.ToInt32(dGVPhimDaThem.Rows[i].Cells["Số Lượng"].Value.ToString())
                        });
                    }
                    ChiTietKhoPhimBLL.Instance.ThemCapNhatChiTietKhoPhim(data, ((CBBItem)cBMaLoaiPhieu.SelectedItem).Value);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDonViTinh.Text = "";
                    cBMaKho.SelectedIndex = -1;
                    cBMaLoaiPhieu.SelectedIndex = -1;
                    nUDSoLuong.Value = 0;
                    txtTenPhim.Text = "";
                    txtMaPhim.Text = "";
                    dGVDanhSachPhim.DataSource = null;
                    dGVPhimDaThem.DataSource = null;
                }
            }
            dtPhimDaThem.Rows.Clear();
            dGVPhimDaThem.DataSource = dtPhimDaThem;
            btnLuu.Enabled = false;
        }

        private void cBMaLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMaKho.SelectedIndex < 0 && cBMaLoaiPhieu.SelectedIndex == 1)
            {
                lbMaKho.Text = "Vui lòng chọn kho";
            }
            else
            {
                lbMaKho.Text = "";
                ReLoad();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dGVPhimDaThem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dGVPhimDaThem.SelectedRows)
                    {
                        dGVPhimDaThem.Rows.RemoveAt(i.Index);
                    }
            }
            if (dGVPhimDaThem.Rows.Count == 0)
            {
                btnLuu.Enabled = false;
                cBMaKho.Enabled = true;
                cBMaLoaiPhieu.Enabled = true;
            }
        }

        private void UC_TaoPhieu_QLP_Leave(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa lưu có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                {
                    txtDonViTinh.Text = "";
                    cBMaKho.SelectedIndex = -1;
                    cBMaLoaiPhieu.SelectedIndex = -1;
                    nUDSoLuong.Value = 0;
                    txtTenPhim.Text = "";
                    txtMaPhim.Text = "";
                    dGVDanhSachPhim.DataSource = null;
                    dGVPhimDaThem.DataSource = null;
                    lbMaKho.Text = "";
                    cBMaKho.Enabled = true;
                    cBMaLoaiPhieu.Enabled = true;
                }
            }
            else
            {
                txtDonViTinh.Text = "";
                cBMaKho.SelectedIndex = -1;
                cBMaLoaiPhieu.SelectedIndex = -1;
                nUDSoLuong.Value = 0;
                txtTenPhim.Text = "";
                txtMaPhim.Text = "";
                dGVDanhSachPhim.DataSource = null;
                dGVPhimDaThem.DataSource = null;
                lbMaKho.Text = "";
                cBMaKho.Enabled = true;
                cBMaLoaiPhieu.Enabled = true;
            }
        }

        private void dGVPhimDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVPhimDaThem.SelectedRows.Count > 1)
            {
                MessageBox.Show("Số dòng chỉnh sửa không vượt quá 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtTenPhim.Text = dGVPhimDaThem.CurrentRow.Cells["Tên Phim"].Value.ToString();
                txtMaPhim.Text = dGVPhimDaThem.CurrentRow.Cells["Mã Phim"].Value.ToString();
                txtMaPhim.Enabled = false;
                nUDSoLuong.Text = dGVPhimDaThem.CurrentRow.Cells["Số Lượng"].Value.ToString();
                txtDonViTinh.Text = dGVPhimDaThem.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
            }
            btnThem.Visible = false;
            btnChinhSua.Visible = true;
            dGVPhimDaThem.Enabled = false;
            dGVDanhSachPhim.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTinhDungDangP2() == true)
            {
                dGVPhimDaThem.CurrentRow.Cells["Số Lượng"].Value = nUDSoLuong.Text;
                dGVPhimDaThem.CurrentRow.Cells["Đơn Vị Tính"].Value = txtDonViTinh.Text;
                txtTenPhim.Text = "";
                nUDSoLuong.Text = "0";
                txtDonViTinh.Text = "";
                btnThem.Visible = true;
                btnChinhSua.Visible = false;
                dGVPhimDaThem.Enabled = true;
                dGVDanhSachPhim.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void cBMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMaKho.SelectedIndex >= 0)
            {
                lbMaKho.Text = "";
                if (cBMaLoaiPhieu.SelectedIndex >= 0)
                {
                    ReLoad();
                }
            }
        }
    }
}