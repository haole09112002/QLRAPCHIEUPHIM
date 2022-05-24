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

namespace GUI.QLVT_GUI
{
    public partial class UCThongTinSanPhamQLVT : UserControl
    {
        public UCThongTinSanPhamQLVT()
        {
            InitializeComponent();
            ReloadListThucAn();
            ReloadListVatTu();
            SetGUI();
        }
        public void SetGUI()
        {
            dgvListVatTu.Columns["MaVatTu"].HeaderText = "Mã Vật Tư";
            dgvListVatTu.Columns["TenKho"].HeaderText = "Tên Kho";
            dgvListVatTu.Columns["TenVatTu"].HeaderText = "Tên Vật Tư";
            dgvListVatTu.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvListVatTu.Columns["SoLuongSP"].HeaderText = "Số Lượng";
            dgvListVatTu.Columns["GiaTien"].HeaderText = "Giá Tiền";
            dgvListThucAn.Columns["MaThucAn"].HeaderText = "Mã Thức Ăn";
            dgvListThucAn.Columns["TenKho"].HeaderText = "Tên Kho";
            dgvListThucAn.Columns["TenThucAn"].HeaderText = "Tên Thức Ăn";
            dgvListThucAn.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvListThucAn.Columns["SoLuongSP"].HeaderText = "Số Lượng";
            dgvListThucAn.Columns["GiaTien"].HeaderText = "Giá Tiền";
        }
        public void ReloadListThucAn(string txt = "")
        {
            dgvListThucAn.DataSource = ChiTietKhoThucAnBLL.Instance.GetAllChiTietKhoThucAnView(txt);
            dgvListThucAn.Columns["MaKho"].Visible = false;
        }
        public void ReloadListVatTu(string txt = "")
        {
            dgvListVatTu.DataSource = ChiTietKhoVatTuBLL.Instance.GetAllChiTietKhoVatTuView(txt);
            dgvListVatTu.Columns["MaKho"].Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string txtSearch = txtTimKiem.Text;
            ReloadListThucAn(txtSearch);
        }
        private void btnTimKiemVatTu_Click(object sender, EventArgs e)
        {
            string txtSearch = txtTimKiemVatTu.Text;
            ReloadListVatTu(txtSearch);
        }

        private void btnSapXepThucAn_Click(object sender, EventArgs e)
        {
            string selectSort = cboSapXep.SelectedItem.ToString();
            switch (selectSort)
            {
                case "Tên Thức Ăn":
                    {
                        dgvListThucAn.DataSource = ChiTietKhoThucAnBLL.Instance.SortChiTietKhoThucAnView(ChiTietKhoThucAnBLL.Instance.CompareTenThucAn);
                        break;
                    }
                case "Tên Kho":
                    {
                        dgvListThucAn.DataSource = ChiTietKhoThucAnBLL.Instance.SortChiTietKhoThucAnView(ChiTietKhoThucAnBLL.Instance.CompareTenKho);
                        break;
                    }
                case "Đơn Vị Tính":
                    {
                        dgvListThucAn.DataSource = ChiTietKhoThucAnBLL.Instance.SortChiTietKhoThucAnView(ChiTietKhoThucAnBLL.Instance.CompareDonViTinh);
                        break;
                    }
                case "Số Lượng":
                    {
                        dgvListThucAn.DataSource = ChiTietKhoThucAnBLL.Instance.SortChiTietKhoThucAnView(ChiTietKhoThucAnBLL.Instance.CompareSoLuong);
                        break;
                    }
                case "Giá Tiền":
                    {
                        dgvListThucAn.DataSource = ChiTietKhoThucAnBLL.Instance.SortChiTietKhoThucAnView(ChiTietKhoThucAnBLL.Instance.CompareGiaTien);
                        break;
                    }
            }
        }
        private void btnSapXepVatTu_Click(object sender, EventArgs e)
        {
            string selectSort = cboSapXepVatTu.SelectedItem.ToString();
            switch (selectSort)
            {
                case "Tên Vật Tư":
                    {
                        dgvListVatTu.DataSource = ChiTietKhoVatTuBLL.Instance.SortChiTietKhoVatTuView(ChiTietKhoVatTuBLL.Instance.CompareTenVatTu);
                        break;
                    }
                case "Tên Kho":
                    {
                        dgvListVatTu.DataSource = ChiTietKhoVatTuBLL.Instance.SortChiTietKhoVatTuView(ChiTietKhoVatTuBLL.Instance.CompareTenKho);
                        break;
                    }
                case "Đơn Vị Tính":
                    {
                        dgvListVatTu.DataSource = ChiTietKhoVatTuBLL.Instance.SortChiTietKhoVatTuView(ChiTietKhoVatTuBLL.Instance.CompareDonViTinh);
                        break;
                    }
                case "Số Lượng":
                    {
                        dgvListVatTu.DataSource = ChiTietKhoVatTuBLL.Instance.SortChiTietKhoVatTuView(ChiTietKhoVatTuBLL.Instance.CompareSoLuong);
                        break;
                    }
                case "Giá Tiền":
                    {
                        dgvListVatTu.DataSource = ChiTietKhoVatTuBLL.Instance.SortChiTietKhoVatTuView(ChiTietKhoVatTuBLL.Instance.CompareGiaTien);
                        break;
                    }
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiemVatTu_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiemVatTu.Text = null;
            txtTimKiemVatTu.ForeColor = Color.Black;
        }
    }
}
