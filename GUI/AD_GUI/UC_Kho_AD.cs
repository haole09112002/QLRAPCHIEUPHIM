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
        DataTable dtChiTietKho = new DataTable();
        DataTable dtDanhSachKho = new DataTable();
        public UC_Kho_AD()
        {
            InitializeComponent();
            SetGUI();
            SetDataTable();
            Reload();
            loadDGVDSKho();
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
            dgvKho.Columns["MaKho"].Visible = false;
        }
        public void loadDGVDanhSachKho(string maLoaiKho = "0", string txt = "")
        {
            dgvKho.DataSource = KhoBLL.Instance.GetKhoViewMaLoaiKho(maLoaiKho, txt);
            dgvKho.Columns["MaKho"].HeaderText = "Mã Kho";
            dgvKho.Columns["TenLoaiKho"].HeaderText = "Tên Loại Kho";
            dgvKho.Columns["TenKho"].HeaderText = "Tên Kho";
        }
        public void SetDataTable()
        {
            dtDanhSachKho.Columns.Add("Mã Kho");
            dtDanhSachKho.Columns.Add("Tên Kho");
            dtDanhSachKho.Columns.Add("Tên Loại Kho");
            dtChiTietKho.Columns.Add("Tên Phim");
            dtChiTietKho.Columns.Add("Số Lượng");
            dtChiTietKho.Columns.Add("Đơn Vị Tính");
        }
        public void Reload(string MaLoaiKho = "")
        {
            dtDanhSachKho.Rows.Clear();
            foreach (KhoDTO i in KhoBLL.Instance.GetListKhoByLoaiKho(MaLoaiKho))
            {
                dtDanhSachKho.Rows.Add(i.MaKho, KhoBLL.Instance.GetKhoByMaKho(i.MaKho).TenKho, LoaiKhoBLL.Instance.GetLoaiKhoByMaLoaiKho(i.MaLoaiKho).TenLoaiKho);
            }
            dgvKho.DataSource = dtDanhSachKho;
            dgvKho.Columns["Mã Kho"].Visible = false;
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
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
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

        private void dgvKho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKho.SelectedRows.Count == 1)
            {
                dtChiTietKho.Rows.Clear();
                string maKho = dgvKho.SelectedRows[0].Cells["MaKho"].Value.ToString();
                if (ChiTietKhoPhimBLL.Instance.GetListChiTietKhoPhimByMaKho(maKho) != null)
                    foreach (ChiTietKhoPhimDTO i in ChiTietKhoPhimBLL.Instance.GetListChiTietKhoPhimByMaKho(dgvKho.SelectedRows[0].Cells["MaKho"].Value.ToString()))
                    {
                        dtChiTietKho.Rows.Add(PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim, i.SoLuongSP, i.DonViTinh);
                    }
                if (ChiTietKhoVatTuBLL.Instance.GetListChiTietKhoVatTuByMaKho(maKho) != null)
                    foreach (ChiTietKhoVatTuDTO i in ChiTietKhoVatTuBLL.Instance.GetListChiTietKhoVatTuByMaKho(dgvKho.SelectedRows[0].Cells["MaKho"].Value.ToString()))
                    {
                        dtChiTietKho.Rows.Add(VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu, i.SoLuongSP, i.DonViTinh);
                    }
                if (ChiTietKhoThucAnBLL.Instance.GetListChiTietKhoThucAnByMaKho(maKho) != null)
                    foreach (ChiTietKhoThucAnDTO i in ChiTietKhoThucAnBLL.Instance.GetListChiTietKhoThucAnByMaKho(dgvKho.SelectedRows[0].Cells["MaKho"].Value.ToString()))
                    {
                        dtChiTietKho.Rows.Add(ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn, i.SoLuongSP, i.DonViTinh);
                    }
                dgvChiTiet.DataSource = dtChiTietKho;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 hàng");
            }
        }
    }
}
