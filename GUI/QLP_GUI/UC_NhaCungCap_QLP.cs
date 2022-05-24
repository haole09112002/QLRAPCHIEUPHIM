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
using DTO;

namespace GUI.QLP_GUI
{
    public partial class UC_NhaCungCap_QLP : UserControl
    {
        DataTable dtNhaCungCap = new DataTable();
        public UC_NhaCungCap_QLP()
        {
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void SetDataTable()
        {
            dtNhaCungCap.Columns.Add("Mã Nhà Cung Cấp");
            dtNhaCungCap.Columns.Add("Tên Nhà Cung Cấp");
            dtNhaCungCap.Columns.Add("Mã Số Thuế");
            dtNhaCungCap.Columns.Add("Số Điện Thoại");
            dtNhaCungCap.Columns.Add("Email");
        }
        public void ReLoad(string TimKiem = "",string LoaiTimKiem = "")
        {
            dtNhaCungCap.Rows.Clear();
            foreach (NhaCungCapDTO i in NhaCungCapBLL.Instance.GetAllNhaCungCap(TimKiem,LoaiTimKiem))
            {
                if(i.MaLoaiNhaCungCap == "LNCC01")
                {
                    dtNhaCungCap.Rows.Add(i.MaNhaCungCap,i.TenNhaCungCap, i.MaNhaCungCap, i.SoDienThoai, i.Email);
                }
            }
            dGVNhaCungCapPhim.DataSource = dtNhaCungCap;
            dGVNhaCungCapPhim.Columns[0].Visible = false;
        }
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if(dGVNhaCungCapPhim.SelectedRows.Count == 1)
            {
                frm_ThongTinNCC_QLP frmThongTinNhaCungCap = new frm_ThongTinNCC_QLP(dGVNhaCungCapPhim.SelectedRows[0].Cells["Mã Nhà Cung Cấp"].Value.ToString());
                frmThongTinNhaCungCap.ShowDialog();
            }
            else if(dGVNhaCungCapPhim.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để xem chi tiết");
            }
            else if(dGVNhaCungCapPhim.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được chọn 1 nhà cung cấp để xem chi tiết");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cBTimKiem.SelectedIndex < 0)
                MessageBox.Show("Trường sắp xếp chưa được chọn");
            else
                ReLoad(txtTimKiem.Text,cBTimKiem.SelectedItem.ToString());
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(cBSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cBSapXep.SelectedItem.ToString(); 
                foreach (DataGridViewRow row in dGVNhaCungCapPhim.Rows)
                {
                    now.Add(row.Cells["MaNhaCungCap"].Value.ToString());
                }
                dGVNhaCungCapPhim.DataSource = NhaCungCapBLL.Instance.SortNhaCungCap(NhaCungCapBLL.Instance.GetNhaCungCapViewDGV(now), dkSapXep);
            }
        }
    }
}
