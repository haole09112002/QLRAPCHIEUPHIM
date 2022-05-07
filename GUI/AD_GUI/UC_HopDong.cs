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
    public partial class UC_HopDong : UserControl
    {
        public UC_HopDong()
        {
            InitializeComponent();
            setGUI();
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
        private void setGUI()
        {
            dgvDSHopDong.DataSource = HopDongBLL.Instance.GetListHopDongView(HopDongBLL.Instance.GetAllHopDong());
        }

        private void dgvDSHopDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSHopDong.SelectedRows.Count == 1)
            {
                string maHopDong = dgvDSHopDong.SelectedRows[0].Cells["MaHopDong"].Value.ToString();
                if(LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD001")
                {
                    frmThemHopDongPhim frmThemHopDongPhim = new frmThemHopDongPhim();
                    frmThemHopDongPhim.Show();
                }
                if (LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD002")
                {
                    frmThemHopDongVatTu frmThemHopDongVatTu = new frmThemHopDongVatTu();
                    frmThemHopDongVatTu.Show();
                }
                if(LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD003")
                {
                    frmThemHopDongThucAn frmThemHopDongThucAn = new frmThemHopDongThucAn();
                    frmThemHopDongThucAn.Show();
                }
            }
        }
    }
}
