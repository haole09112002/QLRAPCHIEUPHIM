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
    public partial class UCNhapXuatVatTuQLVT : UserControl
    {
        DataTable dtDanhSachPhieuNhapXuat = new DataTable();
        DataTable dtChiTietPhieuNhapXuat = new DataTable();
        NhanVienDTO nhanVien = new NhanVienDTO();
        public UCNhapXuatVatTuQLVT(NhanVienDTO nhanvien)
        {
            this.nhanVien = nhanvien;
            InitializeComponent();
            SetDataTable();
            Reload();
            rbTatCa.Checked = true;
            btnTimKiem.Enabled = false;
            btnSapXep.Enabled = false;
        }
        public void SetDataTable()
        {
            dtDanhSachPhieuNhapXuat.Columns.Add("Mã Phiếu");
            dtDanhSachPhieuNhapXuat.Columns.Add("Tên Kho");
            dtDanhSachPhieuNhapXuat.Columns.Add("Tên Nhân Viên");
            dtDanhSachPhieuNhapXuat.Columns.Add("Ngày Lập Phiếu");
            dtChiTietPhieuNhapXuat.Columns.Add("Tên Vật Tư");
            dtChiTietPhieuNhapXuat.Columns.Add("Số Lượng");
            dtChiTietPhieuNhapXuat.Columns.Add("Đơn Vị Tính");
        }
        public void Reload(string MaLoaiPhieu = "")
        {
            PhieuDTO phieu = new PhieuDTO();
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            dtChiTietPhieuNhapXuat.Rows.Clear();
            foreach (string i in ChiTietPhieuVatTuBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                phieu = PhieuBLL.Instance.GetPhieuByMaPhieu(i);
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
            }
            dgvListNhapXuatVatTu.DataSource = dtDanhSachPhieuNhapXuat;
            dgvListNhapXuatVatTu.Columns["Mã Phiếu"].Visible = false;
        }


        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuNhapXuatKhoQLVT frmTaoPhieuNhapXuatKhoQLVT = new FrmTaoPhieuNhapXuatKhoQLVT(nhanVien,"Vật tư");
            frmTaoPhieuNhapXuatKhoQLVT.Show();
        }

        private void dgvListNhapXuatVatTu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListNhapXuatVatTu.SelectedRows.Count == 1)
            {
                dtChiTietPhieuNhapXuat.Rows.Clear();
                foreach (ChiTietPhieuVatTuDTO i in ChiTietPhieuVatTuBLL.Instance.GetListChiTietPhieuVatTuByMaPhieu(dgvListNhapXuatVatTu.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString()))
                {
                    dtChiTietPhieuNhapXuat.Rows.Add(VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu, i.SoLuong, i.DonViTinh);
                }
                dgvListPhieuNhapXuatVatTu.DataSource = dtChiTietPhieuNhapXuat;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTatCa.Checked == true)
            {
                Reload("");
            }
        }

        private void rbNhapVatTu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNhapVatTu.Checked == true)
            {
                Reload("LP001");
            }
        }

        private void rbXuatVatTu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXuatVatTu.Checked == true)
            {
                Reload("LP002");
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            dtChiTietPhieuNhapXuat.Rows.Clear();
            List<string> MaPhieu = new List<string>();
            string TimKiem = txtTimKiem.Text;
            string LoaiTimKiem = "Tên Nhân Viên";
            string MaLoaiPhieu = "";
            if (rbNhapVatTu.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if (rbXuatVatTu.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if (cboTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cboTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuVatTuBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            if (cboSapXep.SelectedItem.ToString() == "Tên Nhân Viên")
            {
                foreach (PhieuDTO phieu in PhieuBLL.Instance.SortPhieu(PhieuBLL.Instance.CompareTenNhanVien, MaPhieu, TimKiem, LoaiTimKiem))
                {
                    dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
                }
            }
            if (cboSapXep.SelectedItem.ToString() == "Ngày Lập Phiếu")
            {
                foreach (PhieuDTO phieu in PhieuBLL.Instance.SortPhieu(PhieuBLL.Instance.CompareNgayLapPhieu, MaPhieu, TimKiem, LoaiTimKiem))
                {
                    dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
                }
            }
            dgvListNhapXuatVatTu.DataSource = dtDanhSachPhieuNhapXuat;
            dgvListNhapXuatVatTu.Columns["Mã Phiếu"].Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtChiTietPhieuNhapXuat.Rows.Clear();
            string TimKiem = txtTimKiem.Text, LoaiTimKiem = "";
            if (cboTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cboTimKiem.SelectedItem.ToString();
            }
            List<string> MaPhieu = new List<string>();
            string MaLoaiPhieu = "";
            if (rbNhapVatTu.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if (rbXuatVatTu.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if (cboTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cboTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuVatTuBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            foreach (PhieuDTO phieu in PhieuBLL.Instance.GetListPhieuNow(MaPhieu, TimKiem, LoaiTimKiem))
            {
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
            }
            dgvListNhapXuatVatTu.DataSource = dtDanhSachPhieuNhapXuat;
            dgvListNhapXuatVatTu.Columns["Mã Phiếu"].Visible = false;
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSapXep.Enabled = true;
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }
    }
}
