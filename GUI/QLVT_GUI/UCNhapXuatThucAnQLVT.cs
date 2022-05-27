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

namespace GUI.QLVT_GUI
{
    public partial class UCNhapXuatThucAnQLVT : UserControl
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        DataTable dtDanhSachPhieuNhapXuat = new DataTable();
        DataTable dtChiTietPhieuNhapXuat = new DataTable();
        public UCNhapXuatThucAnQLVT(NhanVienDTO nhanvien)
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
            dtChiTietPhieuNhapXuat.Columns.Add("Tên Thức Ăn");
            dtChiTietPhieuNhapXuat.Columns.Add("Số Lượng");
            dtChiTietPhieuNhapXuat.Columns.Add("Đơn Vị Tính");
        }
        public void Reload(string MaLoaiPhieu = "")
        {
            PhieuDTO phieu = new PhieuDTO();
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            dtChiTietPhieuNhapXuat.Rows.Clear();
            foreach (string i in ChiTietPhieuThucAnBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                phieu = PhieuBLL.Instance.GetPhieuByMaPhieu(i);
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
            }
            dgvListNhapXuatThucAn.DataSource = dtDanhSachPhieuNhapXuat;
            dgvListNhapXuatThucAn.Columns["Mã Phiếu"].Visible = false;
        }


        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuNhapXuatKhoQLVT frmTaoPhieuNhapXuatKhoQLVT = new FrmTaoPhieuNhapXuatKhoQLVT(nhanVien,"Thức ăn nhanh");
            frmTaoPhieuNhapXuatKhoQLVT.ShowDialog();
            Reload();
        }

        private void dgvListNhapXuatThucAn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListNhapXuatThucAn.SelectedRows.Count == 1)
            {
                dtChiTietPhieuNhapXuat.Rows.Clear();
                foreach (ChiTietPhieuThucAnDTO i in ChiTietPhieuThucAnBLL.Instance.GetListChiTietPhieuThucAnByMaPhieu(dgvListNhapXuatThucAn.SelectedRows[0].Cells["Mã Phiếu"].Value.ToString()))
                {
                    dtChiTietPhieuNhapXuat.Rows.Add(ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn, i.SoLuong, i.DonViTinh);
                }
                dgvListPhieuNhapXuatThucAn.DataSource = dtChiTietPhieuNhapXuat;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng", "Cảnh báo!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTatCa.Checked == true)
            {
                Reload("");
            }
        }

        private void rbNhapThucAn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNhapThucAn.Checked == true)
            {
                Reload("LP001");
            }
        }

        private void rbXuatThucAn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXuatThucAn.Checked == true)
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
            if (rbNhapThucAn.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if (rbXuatThucAn.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if (cboTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cboTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuThucAnBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
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
            dgvListNhapXuatThucAn.DataSource = dtDanhSachPhieuNhapXuat;
            dgvListNhapXuatThucAn.Columns["Mã Phiếu"].Visible = false;
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
            if (rbNhapThucAn.Checked == true)
            {
                MaLoaiPhieu = "LP001";
            }
            if (rbXuatThucAn.Checked == true)
            {
                MaLoaiPhieu = "LP002";
            }
            if (cboTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cboTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietPhieuThucAnBLL.Instance.GetListMaPhieu(MaLoaiPhieu))
            {
                MaPhieu.Add(i);
            }
            dtDanhSachPhieuNhapXuat.Rows.Clear();
            foreach (PhieuDTO phieu in PhieuBLL.Instance.GetListPhieuNow(MaPhieu, TimKiem, LoaiTimKiem))
            {
                dtDanhSachPhieuNhapXuat.Rows.Add(phieu.MaPhieu, KhoBLL.Instance.GetKhoByMaKho(phieu.MaKho).TenKho, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(phieu.MaNhanVien).TenNhanVien, phieu.NgayLapPhieu.ToShortDateString());
            }
            dgvListNhapXuatThucAn.DataSource = dtDanhSachPhieuNhapXuat;
            dgvListNhapXuatThucAn.Columns["Mã Phiếu"].Visible = false;
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSapXep.Enabled = true;
        }
    }
}
