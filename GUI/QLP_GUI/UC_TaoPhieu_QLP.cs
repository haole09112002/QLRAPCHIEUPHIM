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
            cBDonViTinh.Items.AddRange(HopDongPhimBLL.Instance.GetAllDonViTinh().ToArray());
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
            dtDanhSachPhim.Rows.Clear();
            if (((CBBItem)cBMaLoaiPhieu.SelectedItem).Value == "LP001")
            {
                int SoLuong = 0;
                foreach (string i in HopDongPhimBLL.Instance.GetDanhSachMaPhimCoHopDong())
                {
                    if (ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKhoa(((CBBItem)cBMaKho.SelectedItem).Value, i) != null) SoLuong = ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKhoa(((CBBItem)cBMaKho.SelectedItem).Value, i).SoLuongSP;
                    if( HopDongPhimBLL.Instance.GetChiTietTSLPhimByMaPhim(i).TongSoLuongPhim > SoLuong)
                    {
                        dtDanhSachPhim.Rows.Add(i, PhimBLL.Instance.GetPhimByMaPhim(i).TenPhim);
                    }
                }
            }
            else
            {
                foreach (PhimDTO i in ChiTietKhoPhimBLL.Instance.GetListPhimByMaKho(((CBBItem)cBMaKho.SelectedItem).Value))
                {
                    dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim);
                }
            }
            dGVDanhSachPhim.DataSource = dtDanhSachPhim;
            dGVDanhSachPhim.Columns["Mã Phim"].Visible = false;
        }
        public bool KiemTraTinhDungDangP1()
        {
            bool kiemtra = true;
            if (cBMaLoaiPhieu.SelectedIndex < 0)
            {
                lbLoaiPhieu.Text = "*Mời chọn loại phiếu";
                kiemtra = false;
            }
            else
            {
                lbLoaiPhieu.Text = "";
            }
            if (cBMaKho.SelectedIndex < 0)
            {
                lbMaKho.Text = "*Mời chọn kho";
                kiemtra = false;
            }
            else
            {
                lbMaKho.Text = "";
            }
            return kiemtra;
        }
        private void dGVDanhSachPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDanhSachPhim.SelectedRows.Count == 1)
            {
                if (KiemTraTinhDungDangP1() == true)
                {
                    txtMaPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
                    txtTenPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Tên Phim"].Value.ToString();
                    if (((CBBItem)cBMaLoaiPhieu.SelectedItem).Value == "LP002")
                    {
                        nUDSoLuong.Maximum = ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKhoa(((CBBItem)cBMaKho.SelectedItem).Value, txtMaPhim.Text).SoLuongSP;
                    }
                    else
                    {
                        int SoLuong = 0;
                        if (ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKhoa(((CBBItem)cBMaKho.SelectedItem).Value, txtMaPhim.Text) != null) SoLuong = ChiTietKhoPhimBLL.Instance.GetChiTietKhoPhimByKhoa(((CBBItem)cBMaKho.SelectedItem).Value, txtMaPhim.Text).SoLuongSP;
                        nUDSoLuong.Maximum = HopDongPhimBLL.Instance.GetChiTietTSLPhimByMaPhim(txtMaPhim.Text).TongSoLuongPhim - SoLuong;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool KiemTraTinhDungDangP2()
        {
            bool kiemtra = true;
            if (cBDonViTinh.SelectedIndex < 0)
            {
                lbDonViTinh.Text = "*Mời chọn đơn vị tính";
                kiemtra = false;
            }
            else
            {
                lbDonViTinh.Text = "";
            }
            if (nUDSoLuong.Value == 0)
            {
                lbSoLuong.Text = "*Mời nhập số lượng";
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
                if(dGVPhimDaThem.Rows[i].Cells["Mã Phim"].Value.ToString() == MaPhim)
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
                if(KiemTraTonTaiMaPhim(txtMaPhim.Text) == false)
                {
                    dtPhimDaThem.Rows.Add(txtMaPhim.Text, txtTenPhim.Text, nUDSoLuong.Value, cBDonViTinh.SelectedItem.ToString());
                    dGVPhimDaThem.DataSource = dtPhimDaThem;
                    dGVPhimDaThem.Columns["Mã Phim"].Visible = false;
                }
                txtMaPhim.Text = "";
                txtTenPhim.Text = "";
                nUDSoLuong.Value = 0;
                cBDonViTinh.Text = "";
            }
            btnLuu.Enabled = true;
            cBMaKho.Enabled = false;
            cBMaLoaiPhieu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dGVPhimDaThem.Rows.Count.ToString());
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
                    MessageBox.Show("Thêm Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cBDonViTinh.SelectedIndex = -1;
                    cBMaKho.SelectedIndex = -1;
                    cBDonViTinh.SelectedIndex = -1;
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
        }

        private void cBMaLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMaKho.SelectedIndex < 0)
            {
                lbMaKho.Text = "Mời chọn mã kho";
                cBMaLoaiPhieu.SelectedIndex = -1;
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
                MessageBox.Show("Mời chọn dòng để xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            if(dGVPhimDaThem.Rows.Count == 0)
            {
                btnLuu.Enabled = false;
                cBMaKho.Enabled = true;
                cBMaLoaiPhieu.Enabled = true;
            }
        }

        private void UC_TaoPhieu_QLP_Leave(object sender, EventArgs e)
        {
            if(btnLuu.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa lưu có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                {
                    cBDonViTinh.SelectedIndex = -1;
                    cBMaKho.SelectedIndex = -1;
                    cBDonViTinh.SelectedIndex = -1;
                    cBMaLoaiPhieu.SelectedIndex = -1;
                    nUDSoLuong.Value = 0;
                    txtTenPhim.Text = "";
                    txtMaPhim.Text = "";
                    dGVDanhSachPhim.DataSource = null;
                    dGVPhimDaThem.DataSource = null;
                }
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
                cBDonViTinh.Text = dGVPhimDaThem.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
            }
            btnThem.Visible = false;
            btnChinhSua.Visible = true;
            dGVPhimDaThem.Enabled = false;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if(KiemTraTinhDungDangP2() == true)
            {
                dGVPhimDaThem.CurrentRow.Cells["Số Lượng"].Value = nUDSoLuong.Text;
                dGVPhimDaThem.CurrentRow.Cells["Đơn Vị Tính"].Value = cBDonViTinh.SelectedItem.ToString();
            }
            txtTenPhim.Text = "";
            nUDSoLuong.Text = "0";
            cBDonViTinh.Text = "";
            btnThem.Visible = true;
            btnChinhSua.Visible = false;
            dGVPhimDaThem.Enabled = true;
        }

        private void cBMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBMaKho.SelectedIndex >= 0)
            {
                lbMaKho.Text = "";
            }
        }
    }
}
