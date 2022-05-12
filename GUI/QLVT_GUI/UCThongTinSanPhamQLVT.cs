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
using DAL;

namespace GUI.QLVT_GUI
{
    public partial class UCThongTinSanPhamQLVT : UserControl
    {
        public UCThongTinSanPhamQLVT()
        {
            InitializeComponent();
            ReloadListThucAn();
            ReloadListVatTu();
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
                case "MaThucAn":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareMaThucAn);
                        break;
                    }
                case "TenThucAn":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareTenThucAn);
                        break;
                    }
                case "DonViTinh":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareDonViTinh);
                        break;
                    }
                case "SoLuong":
                    {
                        dgvListThucAn.DataSource = ThucAnBLL.Instance.SortThucAnView(ThucAnBLL.Instance.CompareSoLuong);
                        break;
                    }
            }
        }
        private void btnSapXepVatTu_Click(object sender, EventArgs e)
        {
            string selectSort = cboSapXepVatTu.SelectedItem.ToString();
            switch (selectSort)
            {
                case "MaVatTu":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareMaVatTu);
                        break;
                    }
                case "TenVatTu":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareTenVatTu);
                        break;
                    }
                case "DonViTinh":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareDonViTinh);
                        break;
                    }
                case "SoLuong":
                    {
                        dgvListVatTu.DataSource = VatTuBLL.Instance.SortVatTuView(VatTuBLL.Instance.CompareSoLuong);
                        break;
                    }
            }
        }
    }
}
