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
        public UC_DanhSachPhimDeXuat_QLP()
        {
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void SetDataTable()
        {
            dtDSPhieuDeXuat.Columns.Add("Mã Đề Xuất");
            dtDSPhieuDeXuat.Columns.Add("Mã Nhân Viên");
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
                dtDSPhieuDeXuat.Rows.Add(i.MaDeXuat,i.MaNhanVien,i.NgayDeXuat);
            }
            dGVDanhSachPhieuDeXuat.DataSource = dtDSPhieuDeXuat;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_TaoDeXuat_QLP frmTDX = new frm_TaoDeXuat_QLP();
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
    }
}
