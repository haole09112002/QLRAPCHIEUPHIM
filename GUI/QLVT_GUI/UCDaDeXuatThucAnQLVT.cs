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
    public partial class UCDaDeXuatThucAnQLVT : UserControl
    {
        DataTable dtDSPhieuDeXuat = new DataTable();
        DataTable dtCTPhieuDeXuat = new DataTable();
        NhanVienDTO nhanVien = new NhanVienDTO();
        public UCDaDeXuatThucAnQLVT(NhanVienDTO nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
            SetDataTable();
            ReLoad();
            btnTimKiem.Enabled = false;
            btnSapXep.Enabled = false;
        }
        public void SetDataTable()
        {
            dtDSPhieuDeXuat.Columns.Add("Mã Đề Xuất");
            dtDSPhieuDeXuat.Columns.Add("Tên Nhân Viên");
            dtDSPhieuDeXuat.Columns.Add("Ngày Đề Xuất");
            dtCTPhieuDeXuat.Columns.Add("Tên Thức Ăn");
            dtCTPhieuDeXuat.Columns.Add("Nội Dung");
            dtCTPhieuDeXuat.Columns.Add("Số Lượng");
            dtCTPhieuDeXuat.Columns.Add("Đơn Vị Tính");
            dtCTPhieuDeXuat.Columns.Add("Tình Trạng");
        }
        public void ReLoad(string maLoaiDeXuat = "LDX03")
        {
            dtDSPhieuDeXuat.Rows.Clear();
            foreach (DeXuatDTO i in DeXuatBLL.Instance.GetDeXuatByMaLoaiDeXuat(maLoaiDeXuat))
            {
                dtDSPhieuDeXuat.Rows.Add(i.MaDeXuat, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien, i.NgayDeXuat);
            }
            dgvListDeXuatThucAn.DataSource = dtDSPhieuDeXuat;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatThucAnQLVT frmTaoPhieuDeXuatThucAnQLVT = new FrmTaoPhieuDeXuatThucAnQLVT(nhanVien);
            frmTaoPhieuDeXuatThucAnQLVT.ShowDialog();
            ReLoad();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatThucAnQLVT frmTaoPhieuDeXuatThucAnQLVT = new FrmTaoPhieuDeXuatThucAnQLVT(nhanVien);
            frmTaoPhieuDeXuatThucAnQLVT.Show();
        }

        private void dgvListDeXuatThucAn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListDeXuatThucAn.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Số dòng chọn ít nhất là 1 dòng");
            }
            else
            {
                if (dgvListDeXuatThucAn.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Số dòng chọn không vượt quá 1");
                }
                else
                {
                    dtCTPhieuDeXuat.Rows.Clear();
                    string TenThucAn = "";
                    string TinhTrang = "";
                    string MaDeXuat = dgvListDeXuatThucAn.SelectedRows[0].Cells["Mã Đề Xuất"].Value.ToString();
                    foreach (ChiTietDeXuatThucAnDTO i in ChiTietDeXuatThucAnBLL.Instance.GetChiTietDXTAByMaDeXuat(MaDeXuat)) 
                    {
                        TenThucAn = ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn;
                        if (i.TinhTrang == "0") TinhTrang = "Không Chấp Nhận";
                        if (i.TinhTrang == "1") TinhTrang = "Đang Chờ Phê Duyệt";
                        if (i.TinhTrang == "2") TinhTrang = "Đã Phê Duyệt Chờ Tạo Hóa Đơn";
                        if (i.TinhTrang == "3") TinhTrang = "Đã Tạo Hóa Đơn";
                        dtCTPhieuDeXuat.Rows.Add(TenThucAn, i.NoiDung, i.SoLuong, i.DonViTinh, TinhTrang);
                    }
                    dgvListChiTietDeXuat.DataSource = dtCTPhieuDeXuat;
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimKiem.Text, LoaiTimKiem = "";
            if (cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            List<string> MaDeXuat = new List<string>();

            if (cBTimKiem.SelectedIndex >= 0)
            {
                LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
            }
            foreach (string i in ChiTietDeXuatThucAnBLL.Instance.GetListMaDeXuat())
            {
                MaDeXuat.Add(i);
            }
            dtDSPhieuDeXuat.Rows.Clear();
            foreach (DeXuatDTO dexuat in DeXuatBLL.Instance.GetListDeXuatNow(MaDeXuat, TimKiem, LoaiTimKiem))
            {
                dtDSPhieuDeXuat.Rows.Add(dexuat.MaDeXuat, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(dexuat.MaNhanVien).TenNhanVien, dexuat.NgayDeXuat.ToShortDateString());
            }
            dgvListDeXuatThucAn.DataSource = dtDSPhieuDeXuat;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
                List<string> MaDeXuat = new List<string>();
                string TimKiem = txtTimKiem.Text;
                string LoaiTimKiem = "Tên Nhân Viên";
                if (cBTimKiem.SelectedIndex >= 0)
                {
                    LoaiTimKiem = cBTimKiem.SelectedItem.ToString();
                }
                foreach (string i in ChiTietDeXuatThucAnBLL.Instance.GetListMaDeXuat())
                {
                    MaDeXuat.Add(i);
                }
                dtDSPhieuDeXuat.Rows.Clear();
                if (cBSapXep.SelectedItem.ToString() == "Tên Nhân Viên")
                {
                    foreach (DeXuatDTO dexuat in DeXuatBLL.Instance.SortDeXuat(DeXuatBLL.Instance.CompareTenNhanVien, MaDeXuat, TimKiem, LoaiTimKiem))
                    {
                        dtDSPhieuDeXuat.Rows.Add(dexuat.MaDeXuat, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(dexuat.MaNhanVien).TenNhanVien, dexuat.NgayDeXuat.ToShortDateString());
                    }
                }
                if (cBSapXep.SelectedItem.ToString() == "Ngày Đề Xuất")
                {
                    foreach (DeXuatDTO dexuat in DeXuatBLL.Instance.SortDeXuat(DeXuatBLL.Instance.CompareNgayDeXuat, MaDeXuat, TimKiem, LoaiTimKiem))
                    {
                        dtDSPhieuDeXuat.Rows.Add(dexuat.MaDeXuat, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(dexuat.MaNhanVien).TenNhanVien, dexuat.NgayDeXuat.ToShortDateString());
                    }
                }
                dgvListDeXuatThucAn.DataSource = dtDSPhieuDeXuat;
        }

        private void cBTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void cBSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSapXep.Enabled = true;
        }
    }
}
