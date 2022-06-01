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
                    frmThemHopDongPhim.d = new frmThemHopDongPhim.Mydel(loadDGV);
                    frmThemHopDongPhim.ShowDialog();
                }
                if (((CBBItem)cbLoaiHopDongMuonTao.SelectedItem).Value == "LHD002")
                {
                    frmThemHopDongVatTu frmThemHopDongVatTu = new frmThemHopDongVatTu();
                    frmThemHopDongVatTu.d = new frmThemHopDongVatTu.Mydel(loadDGV);
                    frmThemHopDongVatTu.ShowDialog();
                }
                if (((CBBItem)cbLoaiHopDongMuonTao.SelectedItem).Value == "LHD003")
                {
                    frmThemHopDongThucAn frmThemHopDongThucAn = new frmThemHopDongThucAn();
                    frmThemHopDongThucAn.d = new frmThemHopDongThucAn.Mydel(loadDGV);
                    frmThemHopDongThucAn.ShowDialog();
                }
            }
            
        }
        private void setGUI()
        {
            cbLoaiHopDong.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbLoaiHopDongMuonTao.Items.AddRange(LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().ToArray());
            cbLoaiHopDong.Items.AddRange(LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().ToArray());
            cbSapXep.Items.AddRange(new string[] { "Tên A->Z", "Tên Z->A", "Ngày kí kết tăng", "Ngày kí kết giảm" });
            cbLoaiHopDong.SelectedIndex = 0;
            cbbTieuChiTimKiem.Items.AddRange(new string[] { "Tên hợp đồng", "Ngày kí kết", "Tên nhà cung cấp" });
            cbbTieuChiTimKiem.SelectedIndex = 0;
            loadDGV();  
        }
        public void loadDGV(string maLoaiHopDong = "0", string txt = "", string tieuChiTimKiem = "")
        {
            dgvDSHopDong.DataSource = HopDongBLL.Instance.GetHopDongViewByMaLoaiHopDong(maLoaiHopDong, txt, tieuChiTimKiem);
            dgvDSHopDong.Columns["MaHopDong"].HeaderText = "Mã hợp đồng";
            dgvDSHopDong.Columns["TenHopDong"].HeaderText = "Tên hợp đồng";
            dgvDSHopDong.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvDSHopDong.Columns["NgayKiKetHD"].HeaderText = "Ngày kí kết";
            dgvDSHopDong.Columns["TenLoaiHopDong"].HeaderText = "Loại hợp đồng";
        }
        private void dgvDSHopDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSHopDong.SelectedRows.Count == 1)
            {
                string maHopDong = dgvDSHopDong.SelectedRows[0].Cells["MaHopDong"].Value.ToString();
                if(LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD001")
                {
                    frmThemHopDongPhim frmThemHopDongPhim = new frmThemHopDongPhim(maHopDong);
                    frmThemHopDongPhim.d = new frmThemHopDongPhim.Mydel(loadDGV);
                    frmThemHopDongPhim.ShowDialog();
                }
                if (LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD002")
                {
                    frmThemHopDongVatTu frmThemHopDongVatTu = new frmThemHopDongVatTu(maHopDong);
                    frmThemHopDongVatTu.d = new frmThemHopDongVatTu.Mydel(loadDGV);
                    frmThemHopDongVatTu.ShowDialog();
                }
                if(LoaiHopDongBLL.Instance.KiemTraLoaiHopDong(maHopDong) == "LHD003")
                {
                    frmThemHopDongThucAn frmThemHopDongThucAn = new frmThemHopDongThucAn(maHopDong);
                    frmThemHopDongThucAn.d = new frmThemHopDongThucAn.Mydel(loadDGV);
                    frmThemHopDongThucAn.ShowDialog();
                }
            }
        }

        private void cbLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHopDong.SelectedItem != null)
            {
                loadDGV(((CBBItem)cbLoaiHopDong.SelectedItem).Value);
                Sort();
                loadDGV(((CBBItem)cbLoaiHopDong.SelectedItem).Value, txtTimKiem.Text);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadDGV(((CBBItem)cbLoaiHopDong.SelectedItem).Value, txtTimKiem.Text, cbbTieuChiTimKiem.SelectedItem.ToString());
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               loadDGV(((CBBItem)cbLoaiHopDong.SelectedItem).Value, txtTimKiem.Text);
            }
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }
        private void Sort()
        {
            if (cbSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvDSHopDong.Rows)
                {
                    now.Add(row.Cells["MaHopDong"].Value.ToString());
                }
                dgvDSHopDong.DataSource = HopDongBLL.Instance.SortHopDong(HopDongBLL.Instance.GetHopDongDGV(now), dkSapXep);
            }
        }
    }
}
