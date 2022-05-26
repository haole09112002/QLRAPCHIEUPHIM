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

namespace GUI.QLP_GUI
{
    public partial class UC_DanhSachPhimDeXuat_QLP : UserControl
    {
        DataTable dtDSPhieuDeXuat = new DataTable();
        DataTable dtCTPhieuDeXuat = new DataTable();
        NhanVienDTO nhanvien = new NhanVienDTO();
        public UC_DanhSachPhimDeXuat_QLP(NhanVienDTO nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void SetDataTable()
        {
            dtDSPhieuDeXuat.Columns.Add("Mã Đề Xuất");
            dtDSPhieuDeXuat.Columns.Add("Tên Nhân Viên");
            dtDSPhieuDeXuat.Columns.Add("Ngày Đề Xuất");
            dtCTPhieuDeXuat.Columns.Add("Tên Phim");      
            dtCTPhieuDeXuat.Columns.Add("Nội Dung");      
            dtCTPhieuDeXuat.Columns.Add("Số Lượng");
            dtCTPhieuDeXuat.Columns.Add("Đơn Vị Tính");
            dtCTPhieuDeXuat.Columns.Add("Tình Trạng");
        }
        public void ReLoad()
        {
            dtDSPhieuDeXuat.Rows.Clear();
            foreach(DeXuatDTO i in DeXuatBLL.Instance.GetDeXuatByMaLoaiDeXuat("LDX01"))
            {
                dtDSPhieuDeXuat.Rows.Add(i.MaDeXuat,NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,i.NgayDeXuat.ToShortDateString());
            }
            dGVDanhSachPhieuDeXuat.DataSource = dtDSPhieuDeXuat;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_TaoDeXuat_QLP frmTDX = new frm_TaoDeXuat_QLP(nhanvien);
            frmTDX.ShowDialog();
            ReLoad();
        }

        private void dGVDanhSachPhieuDeXuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGVDanhSachPhieuDeXuat.SelectedRows.Count <= 0 )
            {
                MessageBox.Show("Số dòng chọn ít nhất là 1 dòng");
            }
            else
            {
                if(dGVDanhSachPhieuDeXuat.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Số dòng chọn không vượt quá 1");
                }
                else
                {
                    dtCTPhieuDeXuat.Rows.Clear();
                    string TenPhim = "";
                    string TinhTrang = "";
                    string MaDeXuat = dGVDanhSachPhieuDeXuat.SelectedRows[0].Cells["Mã Đề Xuất"].Value.ToString();
                    foreach (ChiTietDeXuatPhimDTO i in ChiTietDeXuatPhimBLL.Instance.GetChiTietDXPByMaDeXuat(MaDeXuat))
                    {
                        TenPhim = PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim;
                        if (i.TinhTrang == "0") TinhTrang = "Không Chấp Nhận";
                        if (i.TinhTrang == "1") TinhTrang = "Đang Chờ Phê Duyệt";
                        if (i.TinhTrang == "2") TinhTrang = "Đã Phê Duyệt Chờ Tạo Hóa Đơn";
                        if (i.TinhTrang == "3") TinhTrang = "Đã Tạo Hóa Đơn";
                        dtCTPhieuDeXuat.Rows.Add(TenPhim, i.NoiDung, i.SoLuong, i.DonViTinh, TinhTrang);
                    }
                    dGVChiTietPhieuDeXuat.DataSource = dtCTPhieuDeXuat;
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
            foreach (string i in ChiTietDeXuatPhimBLL.Instance.GetListMaDeXuat())
            {
                MaDeXuat.Add(i);
            }
            dtDSPhieuDeXuat.Rows.Clear();
            foreach (DeXuatDTO dexuat in DeXuatBLL.Instance.GetListDeXuatNow(MaDeXuat,TimKiem,LoaiTimKiem))
            {
                dtDSPhieuDeXuat.Rows.Add(dexuat.MaDeXuat,NhanVienBLL.Instance.GetNhanVienByMaNhanVien(dexuat.MaNhanVien).TenNhanVien,dexuat.NgayDeXuat.ToShortDateString());
            }
            dGVDanhSachPhieuDeXuat.DataSource = dtDSPhieuDeXuat;
            //dGVDanhSachPhieuDeXuat.Columns["Mã Đề Xuất"].Visible = false;
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
            foreach (string i in ChiTietDeXuatPhimBLL.Instance.GetListMaDeXuat())
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
            dGVDanhSachPhieuDeXuat.DataSource = dtDSPhieuDeXuat;
            //dGVDanhSachPhieuDeXuat.Columns["Mã Đề Xuất"].Visible = false;
        }
    }
}
