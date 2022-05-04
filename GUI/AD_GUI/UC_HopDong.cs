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
    public partial class UC_HopDong : UserControl
    {
        public UC_HopDong()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(cbLoaiHopDong.SelectedItem.ToString() == "Hợp Đồng Phim")
            {
                frmThemHopDongPhim frmThemHopDongPhim = new frmThemHopDongPhim();
                frmThemHopDongPhim.Show();
            }
            if (cbLoaiHopDong.SelectedItem.ToString() == "Hợp Đồng Vật Tư")
            {
                frmThemHopDongVatTu frmThemHopDongVatTu = new frmThemHopDongVatTu();
                frmThemHopDongVatTu.Show();
            }
            if (cbLoaiHopDong.SelectedItem.ToString() == "Hợp Đồng Thức Ăn")
            {
                frmThemHopDongThucAn frmThemHopDongThucAn = new frmThemHopDongThucAn();
                frmThemHopDongThucAn.Show();
            }
        }

    }
}
