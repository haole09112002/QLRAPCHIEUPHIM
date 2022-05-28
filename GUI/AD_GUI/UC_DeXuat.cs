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

namespace GUI.AD_GUI
{
    public partial class UC_DeXuat : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        DataTable dtDeXuat = new DataTable();
        DataTable dtDaDeXuat = new DataTable();
        public UC_DeXuat()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            cbbDeXuat.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbbDeXuat.Items.AddRange(LoaiDeXuatBLL.Instance.GetCBBLoaiDeXuat().ToArray());
            loadDGVDeXuat();
        }

        public void loadDGVDeXuat()
        {
            dgvDeXuat.DataSource = DeXuatBLL.Instance.GetAllDeXuat();
        }
        public void loadDGVDanhSachDeXuat(string maLoaiDeXuat = "0", string txt = "")
        {
            dgvDeXuat.DataSource = DeXuatBLL.Instance.GetDeXuatViewByMaDeXuat(maLoaiDeXuat, txt);
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dgvDeXuat.DataSource = DeXuatBLL.Instance.TimTheoMaDeXuat(txtTimKiem.Text);
        }
        private void cbbDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDeXuat.SelectedItem != null)
            {
               loadDGVDanhSachDeXuat(((CBBItem)cbbDeXuat.SelectedItem).Value);
               Sort();
               loadDGVDanhSachDeXuat(((CBBItem)cbbDeXuat.SelectedItem).Value, txtTimKiem.Text);
            }
        }
        private void Sort()
        {
            if (cbbDeXuat.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbbDeXuat.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvDeXuat.Rows)
                {
                    now.Add(row.Cells["MaDeXuat"].Value.ToString());
                }
                dgvDeXuat.DataSource = DeXuatBLL.Instance.SortDeXuat(DeXuatBLL.Instance.GetDeXuatViewDGV(now), dkSapXep);
            }
        }
    }
}
