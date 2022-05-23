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
    public partial class UCHoSoCaNhanQLVT : UserControl
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        DataTable dtListCaLam = new DataTable();
        public UCHoSoCaNhanQLVT(NhanVienDTO nhanVien)
        {
            this.nhanVien = nhanVien;
            InitializeComponent();
            SetDataTable();
            Reload();
        }
        public void Reload()
        {
            txtTen.Text = nhanVien.TenNhanVien;
            txtNgaySinh.Text = nhanVien.NgaySinh.ToShortDateString();
            txtDiaChi.Text = nhanVien.DiaChi;
            txtDienThoai.Text = nhanVien.SoDienThoai;
            txtTenTaiKhoan.Text = nhanVien.TenTaiKhoan;
            foreach(CaLamViecDTO i in ChiTietCaLamViecBLL.Instance.GetListCaLamViecByMaNhanVien(nhanVien.MaNhanVien))
            {
                dtListCaLam.Rows.Add(i.TenCa, i.GioBatDau.ToShortTimeString(), i.GioKetThuc.ToShortTimeString());
            }
            dgvListCaLamViec.DataSource = dtListCaLam;
        }
        public void SetDataTable()
        {
            dtListCaLam.Columns.Add("Tên Ca");
            dtListCaLam.Columns.Add("Giờ Bắt Đầu");
            dtListCaLam.Columns.Add("Giờ Kết Thúc");

        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauQLVT frmDoiMatKhauQLVT = new FrmDoiMatKhauQLVT(nhanVien);
            frmDoiMatKhauQLVT.ShowDialog();
        }
    }
}
