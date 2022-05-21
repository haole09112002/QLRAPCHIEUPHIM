using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
   
    public partial class FrmCapNhatPhongChieuQLVT : Form
    {
        private List<ChiTietKhoVatTuView> dsVatTuTrongKho;
        private List<ChiTietPhongChieuView> dsVatTuCoSan;
        private List<ChiTietPhongChieuView> dsVatTuDaChon;
        private string maPhongChieu;
        public FrmCapNhatPhongChieuQLVT(string maPhongChieu)
        {
            this.maPhongChieu = maPhongChieu;
            dsVatTuTrongKho = ChiTietKhoVatTuBLL.Instance.GetAllChiTietKhoVatTuView();
            dsVatTuCoSan = ChiTietPhongChieuBLL.Instance.GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu);

            InitializeComponent();
            setGUI(this.maPhongChieu);
        }
        private void setGUI(string maPhongChieu)
        {
            cbLoaiPhongChieu.Items.AddRange(LoaiPhongChieuBLL.Instance.GetCBBLoaiPhongChieu().ToArray());
            cbTinhTrang.Items.AddRange(TinhTrangPhongChieuBLL.Instance.GetCBBTinhTrangPhongChieu().ToArray());
            cbDonViTinh.Items.AddRange(ChiTietKhoVatTuBLL.Instance.GetAllDonViTinh().ToArray());
            if(maPhongChieu != "")
            {
                txtMaPhongChieu.Text = maPhongChieu;
                txtTenPhongChieu.Text = PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenPhong;
                foreach (CBBItem i in cbLoaiPhongChieu.Items)
                {
                    if (i.Text == PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenLoaiPhongChieu)
                        cbLoaiPhongChieu.SelectedItem = i;
                }
                foreach (CBBItem i in cbTinhTrang.Items)
                {
                    if (i.Text == PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenTinhTrang)
                        cbTinhTrang.SelectedItem = i;
                }
            }
            LoadDGVListVatTuKho();
            LoadDGVVatTuDaThem();
            
        }
        private void LoadDGVListVatTuKho()
        {
            dgvListVatTuKho.DataSource = null;
            dgvListVatTuKho.DataSource = dsVatTuTrongKho;
        }
        private void LoadDGVVatTuCoSan()
        {
            dgvVatTuCoSan.DataSource = null;
            dgvVatTuCoSan.DataSource = dsVatTuCoSan;
        }
        private void LoadDGVVatTuDaThem()
        {
            dgvVatTuDaChon.DataSource = null;
            dgvVatTuDaChon.DataSource = dsVatTuDaChon;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListVatTuKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvListVatTuKho.SelectedRows.Count == 1)
            {
                txtMaVatTu.Text = dgvListVatTuKho.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                txtTenVatTu.Text = dgvListVatTuKho.SelectedRows[0].Cells["TenVatTu"].Value.ToString();
                cbDonViTinh.SelectedItem = dgvListVatTuKho.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                numUpDowSoLuong.Value = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVatTu.Text == "")
                lbVatTu.Text = "Vật tư còn trống!";
            if (cbDonViTinh.SelectedItem == null)
                lbDonViTinh.Text = "Đơn vị tính còn trống!";
            if (numUpDowSoLuong.Value == 0)
                lbSoLuong.Text = "Số lượng còn trống!";
            if(txtMaVatTu.Text != "" && 
                cbDonViTinh.SelectedItem != null&&
                numUpDowSoLuong.Value != 0)
            {
                ChiTietPhongChieuDTO pc = new ChiTietPhongChieuDTO
                {
                    MaVatTu = txtMaVatTu.Text,
                    DonViTinh = cbDonViTinh.SelectedItem.ToString(),
                    SoLuongSP = Convert.ToInt32(numUpDowSoLuong.Value),
                    MaPhongChieu = maPhongChieu
                };
              //  ChiTietPhongChieuBLL.Instance.ThemChiTietPhongChieuTodsVatTuCoSan(pc,ref dsVatTuDaChon);
                LoadDGVListVatTuKho();
                LoadDGVVatTuDaThem();
            }    
        }

        private void dgvVatTuDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVatTuCoSan.SelectedRows.Count == 1)
            {
                string maVatTu = dgvVatTuCoSan.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                ChiTietPhongChieuView pc = dsVatTuCoSan.Find(x => x.MaVatTu == maVatTu);
                dsVatTuCoSan.Remove(pc);
            }
        }

        private void dgvVatTuDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dgvVatTuDaThem.SelectedRows.Count == 1)
            //{
            //    string maVatTu = dgvVatTuDaThem.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
            //    ChiTietPhongChieuView pc = dsVatTuCoSan.Find(x => x.MaVatTu == maVatTu);
            //    txtMaVatTu.Text = maVatTu;
            //    txtTenVatTu.Text = pc.TenVatTu;
            //    cbDonViTinh.SelectedItem = pc.DonViTinh;
            //    numUpDowSoLuong.Value = pc.SoLuong;
            //}
        }
    }
}
