using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_ThongKeNhapXuat : UserControl
    {
        public UC_ThongKeNhapXuat()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            chartPhieu.Series["SeriesPhieuPhim"].Points.AddXY("Phiếu Nhập", 10);
            chartPhieu.Series["SeriesVatTu"].Points.AddXY("Phiếu Nhập", 10);
            chartPhieu.Series["SeriesThucAn"].Points.AddXY("Phiếu Nhập", 20);
            chartPhieu.Series["SeriesPhieuPhim"].Points.AddXY("Phiếu Xuất", 10);
            chartPhieu.Series["SeriesVatTu"].Points.AddXY("Phiếu Xuất", 10);
            chartPhieu.Series["SeriesThucAn"].Points.AddXY("Phiếu Xuất", 10);

        }
    }
}
