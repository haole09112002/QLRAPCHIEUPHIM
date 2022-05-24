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
    public partial class UCDaDeXuatVatTuQLVT : UserControl
    {
        DataTable dtDSPhieuDeXuat = new DataTable();
        DataTable dtCTPhieuDeXuat = new DataTable();
        NhanVienDTO nhanVien = new NhanVienDTO();
        public UCDaDeXuatVatTuQLVT(NhanVienDTO nv)
        {
            nhanVien = nv;
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void SetDataTable()
        {
            dtDSPhieuDeXuat.Columns.Add("Mã Đề Xuất");
            dtDSPhieuDeXuat.Columns.Add("Mã Nhân Viên");
            dtDSPhieuDeXuat.Columns.Add("Ngày Đề Xuất");
            dtCTPhieuDeXuat.Columns.Add("Tên Vật Tư");
            dtCTPhieuDeXuat.Columns.Add("Nội Dung");
            dtCTPhieuDeXuat.Columns.Add("Số Lượng");
            dtCTPhieuDeXuat.Columns.Add("Đơn Vị Tính");
            dtCTPhieuDeXuat.Columns.Add("Tình Trạng");
        }
        public void ReLoad(string maLoaiDeXuat = "LDX02")
        {
            dtDSPhieuDeXuat.Rows.Clear();
            foreach (DeXuatDTO i in DeXuatBLL.Instance.GetDeXuatByMaLoaiDeXuat(maLoaiDeXuat))
            {
                dtDSPhieuDeXuat.Rows.Add(i.MaDeXuat, i.MaNhanVien, i.NgayDeXuat);
            }
            dgvListDeXuatVatTu.DataSource = dtDSPhieuDeXuat;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatVatTuQLVT frmTaoPhieuDeXuatVatTuQLVT = new FrmTaoPhieuDeXuatVatTuQLVT(nhanVien);
            frmTaoPhieuDeXuatVatTuQLVT.ShowDialog();
            ReLoad();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatVatTuQLVT frmTaoPhieuDeXuatVatTuQLVT = new FrmTaoPhieuDeXuatVatTuQLVT(nhanVien);
            frmTaoPhieuDeXuatVatTuQLVT.Show();
        }

        private void dgvListDeXuatVatTu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListDeXuatVatTu.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Số dòng chọn ít nhất là 1 dòng");
            }
            else
            {
                if (dgvListDeXuatVatTu.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Số dòng chọn không vượt quá 1");
                }
                else
                {
                    dtCTPhieuDeXuat.Rows.Clear();
                    string TenVatTu = "";
                    string TinhTrang = "";
                    string MaDeXuat = dgvListDeXuatVatTu.SelectedRows[0].Cells["Mã Đề Xuất"].Value.ToString();
                    foreach (ChiTietDeXuatVatTuDTO i in ChiTietDeXuatVatTuBLL.Instance.GetChiTietDXVTByMaDeXuat(MaDeXuat))
                    {
                        TenVatTu = VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu;
                        if (i.TinhTrang == "0") TinhTrang = "Không Chấp Nhận";
                        if (i.TinhTrang == "1") TinhTrang = "Đang Chờ Phê Duyệt";
                        if (i.TinhTrang == "2") TinhTrang = "Đã Phê Duyệt Chờ Tạo Hóa Đơn";
                        if (i.TinhTrang == "3") TinhTrang = "Đã Tạo Hóa Đơn";
                        dtCTPhieuDeXuat.Rows.Add(TenVatTu, i.NoiDung, i.SoLuong, i.DonViTinh, TinhTrang);
                    }
                    dgvListChiTietDeXuat.DataSource = dtCTPhieuDeXuat;
                }
            }
        }
    }
}
