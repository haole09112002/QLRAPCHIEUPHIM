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
    public partial class UC_Kho_AD : UserControl
    {
        public UC_Kho_AD()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            cbbLoaiKho.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbbLoaiKho.Items.AddRange(LoaiKhoBLL.Instance.GetCBBLoaiKho().ToArray());
            cbbSapXep.Items.AddRange(new string[]
            {
                 "Tên A->Z","Tên Z->A"
            });
            loadDGVDSKho();
        }
        public void loadDGVDSKho()
        {
            dgvKho.DataSource = KhoBLL.Instance.GetAllKhoView();
            dgvKho.Columns["MaKho"].HeaderText = "Mã Kho";
            dgvKho.Columns["TenKho"].HeaderText = "Tên Kho";
            dgvKho.Columns["TenLoaiKho"].HeaderText = "Tên Loại Kho";
        }
        public void loadDGVDanhSachKho(string maLoaiKho = "0", string txt = "")
        {
            dgvKho.DataSource = KhoBLL.Instance.GetKhoViewMaLoaiKho(maLoaiKho, txt);
            dgvKho.Columns["MaKho"].HeaderText = "Mã Kho";
            dgvKho.Columns["TenLoaiKho"].HeaderText = "Tên Loại Kho";
            dgvKho.Columns["TenKho"].HeaderText = "Tên Kho";
        }
        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dgvKho.DataSource = KhoBLL.Instance.TimTheoTenKho(txtTimKiem.Text);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            List<string> now = new List<string>();
            foreach (DataGridViewRow row in dgvKho.Rows)
            {
                now.Add(row.Cells["MaKho"].Value.ToString());
            }
            Helper.Instance.ExportDataToExcel<KhoDTO>(KhoBLL.Instance.GetKhoDGV(now));
        }
        
        private void cbbLoaiKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiKho.SelectedItem != null)
            {
                loadDGVDanhSachKho(((CBBItem)cbbLoaiKho.SelectedItem).Value);
                Sort();
                loadDGVDanhSachKho(((CBBItem)cbbLoaiKho.SelectedItem).Value, txtTimKiem.Text);
            }
        }
        private void Sort()
        {
            if (cbbSapXep.SelectedIndex >= 0)
            {
                List<string> now = new List<string>();
                string dkSapXep = cbbSapXep.SelectedItem.ToString();
                foreach (DataGridViewRow row in dgvKho.Rows)
                {
                    now.Add(row.Cells["MaKho"].Value.ToString());
                }
                dgvKho.DataSource = KhoBLL.Instance.SortKho(KhoBLL.Instance.GetKhoViewDGV(now), dkSapXep);
            }
        }
    }
}
