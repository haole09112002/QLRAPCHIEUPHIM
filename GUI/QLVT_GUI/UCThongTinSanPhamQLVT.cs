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
            dgvListVatTu.Columns["TenVatTu"].HeaderText = "Tên Vật Tư";
            dgvListVatTu.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvListVatTu.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvListVatTu.Columns["GiaTien"].HeaderText = "Giá Tiền";
            dgvListThucAn.Columns["MaThucAn"].HeaderText = "Mã Thức Ăn";
            dgvListThucAn.Columns["TenThucAn"].HeaderText = "Tên Thức Ăn";
            dgvListThucAn.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvListThucAn.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvListThucAn.Columns["GiaTien"].HeaderText = "Giá Tiền";
        }
        public void ReloadListThucAn(string txt = "")
        {
            dgvListThucAn.DataSource = ThucAnBLL.Instance.GetThucAnViews(txt);
        }
        public void ReloadListVatTu(string txt = "")
        {
            dgvListVatTu.DataSource = VatTuBLL.Instance.GetVatTuViews(txt);
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

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string selectSort = cboSapXep.SelectedItem.ToString();
            switch (selectSort)
            {
                case "Mã Thức Ăn":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareMaThucAn);
                        break;
                    }
                case "Tên Thức Ăn":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareTenThucAn);
                        break;
                    }
                case "Đơn Vị Tính":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareDonViTinh);
                        break;
                    }
                case "Số Lượng":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareSoLuong);
                        break;
                    }
                case "Giá Tiền":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareGiaTien);
                        break;
                    }
            }
        }
        private void btnSapXepVatTu_Click(object sender, EventArgs e)
        {
            string selectSort = cboSapXepVatTu.SelectedItem.ToString();
            switch (selectSort)
            {
                case "Mã Vật Tư":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareMaVatTu);
                        break;
                    }
                case "Tên Vật Tư":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareTenVatTu);
                        break;
                    }
                case "Đơn Vị Tính":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareDonViTinh);
                        break;
                    }
                case "Số Lượng":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareSoLuong);
                        break;
                    }
                case "Giá Tiền":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareGiaTien);
                        break;
                    }
            }
        }
    }
}
