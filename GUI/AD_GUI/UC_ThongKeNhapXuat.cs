using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_ThongKeNhapXuat : UserControl
    {
        public UC_ThongKeNhapXuat()
        {
            InitializeComponent();
            setGUI();
        }
        private void setGUI()
        {
            chartPhieu.Series["SeriesPhieuPhim"].Points.AddXY("Phiếu Nhập", 0);
            chartPhieu.Series["SeriesVatTu"].Points.AddXY("Phiếu Nhập", 0);
            chartPhieu.Series["SeriesThucAn"].Points.AddXY("Phiếu Nhập", 0);
            chartPhieu.Series["SeriesPhieuPhim"].Points.AddXY("Phiếu Xuất", 0);
            chartPhieu.Series["SeriesVatTu"].Points.AddXY("Phiếu Xuất", 0);
            chartPhieu.Series["SeriesThucAn"].Points.AddXY("Phiếu Xuất", 0);
            lbSLPNhap.Text = "0";
            lbSLPXuat.Text = "0";
            lbSLThucAnNhap.Text = "0";
            lbSLTAXuat.Text = "0";
            lbSLVatTuNhap.Text = "0";
            lbSLVTXuat.Text = "0";
            lbSLPhieuNhap.Text = "0";
            lbSLPhieuXuat.Text = "0";
            dtpNgayKT.Value = DateTime.Today;
            dtpNgayBD.Value = DateTime.Today.AddDays(-7);
            ThongKe(dtpNgayBD.Value, dtpNgayKT.Value);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe(dtpNgayBD.Value, dtpNgayKT.Value);
        }
        private void ThongKe(DateTime ngayBD, DateTime ngayKT)
        {
            if (dtpNgayBD.Value > dtpNgayKT.Value)
                lbErrNgay.Text = "*Ngày lựa chọn không hợp lệ. Vui lòng kiểm tra lại!";
            else
            {
                lbSLPNhap.Text = ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK001").ToString();
                lbSLPXuat.Text = ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP002", "LK001").ToString();
                lbSLThucAnNhap.Text = ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK003").ToString();
                lbSLTAXuat.Text = ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK003").ToString();
                lbSLVatTuNhap.Text = ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK002").ToString();
                lbSLVTXuat.Text = ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP002", "LK002").ToString();
                lbSLPhieuNhap.Text = (Convert.ToInt32(lbSLThucAnNhap.Text) + Convert.ToInt32(lbSLVatTuNhap.Text) + Convert.ToInt32(lbSLPNhap.Text)).ToString();
                lbSLPhieuXuat.Text = (Convert.ToInt32(lbSLPXuat.Text) + Convert.ToInt32(lbSLTAXuat.Text) + Convert.ToInt32(lbSLVTXuat.Text)).ToString();
                chartPhieu.Series["SeriesPhieuPhim"].Points.Clear();
                chartPhieu.Series["SeriesVatTu"].Points.Clear();
                chartPhieu.Series["SeriesThucAn"].Points.Clear();
                chartPhieu.Series["SeriesPhieuPhim"].Points.AddXY("Phiếu Nhập", ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK001"));
                chartPhieu.Series["SeriesVatTu"].Points.AddXY("Phiếu Nhập", ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK002"));
                chartPhieu.Series["SeriesThucAn"].Points.AddXY("Phiếu Nhập", ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP001", "LK003"));
                chartPhieu.Series["SeriesPhieuPhim"].Points.AddXY("Phiếu Xuất", ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP002", "LK001"));
                chartPhieu.Series["SeriesVatTu"].Points.AddXY("Phiếu Xuất", ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP002", "LK002"));
                chartPhieu.Series["SeriesThucAn"].Points.AddXY("Phiếu Xuất", ThongKeBLL.Instance.SoLuongPhieu(ngayBD, ngayKT, "LP002", "LK003"));
            }    

        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpNgayBD.Value > dtpNgayKT.Value)
                lbErrNgay.Text = "";
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            
                lbErrNgay.Text = "";
        }
    }
}
