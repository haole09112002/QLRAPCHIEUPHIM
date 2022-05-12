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
            if(cbLoaiHopDongMuonTao.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn loại hợp đồng muốn thêm! Vui lòng chọn trước!", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (((CBBItem)cbLoaiHopDongMuonTao.SelectedItem).Value == "LHD001")
                {
                    frmThemHopDongPhim frmThemHopDongPhim = new frmThemHopDongPhim();
                    frmThemHopDongPhim.ShowDialog();
                }
                if (((CBBItem)cbLoaiHopDongMuonTao.SelectedItem).Value == "LHD002")
                {
                    frmThemHopDongVatTu frmThemHopDongVatTu = new frmThemHopDongVatTu();
                    frmThemHopDongVatTu.ShowDialog();
                }
                if (((CBBItem)cbLoaiHopDongMuonTao.SelectedItem).Value == "LHD003")
                {
                    frmThemHopDongThucAn frmThemHopDongThucAn = new frmThemHopDongThucAn();
                    frmThemHopDongThucAn.ShowDialog();
                }
            }
            
        }
        private void setGUI()
        {
            cbLoaiHopDong.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbLoaiHopDongMuonTao.Items.AddRange(LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().ToArray());
            cbLoaiHopDong.Items.AddRange(LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().ToArray());
            cbSapXep.Items.AddRange(new string[] { "Tên A->Z", "Tên Z->A" });
            cbLoaiHopDong.SelectedItem = cbLoaiHopDong.Items[0];
            dgvDSHopDong.DataSource = HopDongBLL.Instance.GetListHopDongView(HopDongBLL.Instance.GetHopDongByMaLoaiHopDong());
            dgvDSHopDong.Columns["MaHopDong"].HeaderText = "Mã hợp đồng";
            dgvDSHopDong.Columns["TenHopDong"].HeaderText = "Tên hợp đồng";
            dgvDSHopDong.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvDSHopDong.Columns["NgayKiKetHD"].HeaderText = "Ngày kí kết";
            dgvDSHopDong.Columns["TenLoaiHopDong"].HeaderText = "Loại hợp đồng";
        }
        public void loadDGV(string maLoaiHopDong = "0", string txt = "")
        {
            dgvDSHopDong.DataSource = HopDongBLL.Instance.GetListHopDongView(HopDongBLL.Instance.GetHopDongByMaLoaiHopDong(maLoaiHopDong, txt));
        }
        private void dgvDSHopDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSHopDong.SelectedRows.Count == 1)
            {
                string maHopDong = dgvDSHopDong.SelectedRows[0].Cells["MaHopDong"].Value.ToString();
                if(LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD001")
                {
                    frmThemHopDongPhim frmThemHopDongPhim = new frmThemHopDongPhim(maHopDong);
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

        private void cbLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHopDong.SelectedItem != null)
            {
                loadDGV(((CBBItem)cbLoaiHopDong.SelectedItem).Value);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadDGV(((CBBItem)cbLoaiHopDong.SelectedItem).Value, txtTimKiem.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
