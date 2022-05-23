using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.AD_GUI
{
    public partial class UC_ThongTinNV : UserControl
    {
        public UC_ThongTinNV()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            loadDGVDSNhanVien();
        }
        //public void loadDGVDanhSachNhanVien(string maChucVu = "0", string txt = "")
        //{
        //    dgvDSNhanVien.DataSource = NhanVienBLL.Instance.GetNhanVienViewByMaChucVu(maChucVu, txt);
        //}
        public void loadDGVDSNhanVien()
        {
            dgvDSNhanVien.DataSource = NhanVienBLL.Instance.GetAllNhanVienView();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.d = new frmThemNhanVien.MyDel(loadDGVDSNhanVien);
            frmThemNhanVien.ShowDialog();

        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count==0) { MessageBox.Show("Vui long chon doi  tuong"); }
            else if(dgvDSNhanVien.SelectedRows.Count==1)
            {
                frmThemNhanVien f = new frmThemNhanVien(dgvDSNhanVien.SelectedRows[0].Cells["maNhanVien"].Value.ToString());
                f.d = new frmThemNhanVien.MyDel(loadDGVDSNhanVien);
                f.ShowDialog();
            }
            else if (dgvDSNhanVien.SelectedRows.Count > 1) { MessageBox.Show("Ban chi co the chon 1  doi tuong"); }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            
        }
        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }
        private void Sort()
        {
            //if (cbbSapXep.SelectedIndex >= 0)
            //{
            //    List<string> now = new List<string>();
            //    string dkSapXep = cbbSapXep.SelectedItem.ToString();
            //    foreach (DataGridViewRow row in dgvDSNhanVien.Rows)
            //    {
            //        now.Add(row.Cells["MaNhanVien"].Value.ToString());
            //    }
            //    dgvDSNhanVien.DataSource = NhanVienBLL.Instance.SortNhanVien(NhanVienBLL.Instance.GetNhanVienViewDGV(now), dkSapXep);
            //    loadDGVDSNhanVien(dgvDSNhanVien.Rows[0].Cells["MaNhanVien"].Value.ToString());
            //}
        }
    }
}
