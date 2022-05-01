using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI.QLP_GUI
{
    public partial class UC_ThongTinPhim_QLP : UserControl
    {
        public UC_ThongTinPhim_QLP()
        {
            InitializeComponent();
            Reload();
        }
        public void Reload(string txt = "")
        {
            dGVDanhSachPhim.DataSource = PhimBLL.Instance.GetPhimViews(txt);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string txtSearch = txtTimKiem.Text;
            Reload(txtSearch);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string selectSort = cBSapXep.SelectedItem.ToString();
            switch (selectSort)
            {
                case "MaPhim":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareMaPhim);
                        break;
                    }
                case "TenPhim":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareTenPhim);
                        break;
                    }
                case "ThoiLuong":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareThoiLuong);
                        break;
                    }
                case "QuocGia":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareQuocGia);
                        break;
                    }
                case "NamSanXuat":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareNamSanXuat);
                        break;
                    }
                case "TenHangPhim":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareTenHangPhim);
                        break;
                    }
                case "TheLoai":
                    {
                        dGVDanhSachPhim.DataSource = PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareTheLoai);
                        break;
                    }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(dGVDanhSachPhim.SelectedRows.Count == 1)
            {
                frmThongTinPhim f = new frmThongTinPhim(dGVDanhSachPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString(),dGVDanhSachPhim.SelectedRows[0].Cells["TheLoai"].Value.ToString());
                f.ShowDialog();
            }
        }
    }
}
