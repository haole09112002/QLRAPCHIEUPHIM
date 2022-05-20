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
        private List<ChiTietPhongChieuDTO> dsVatTuDaChon;
        private string maPhongChieu;
        public FrmCapNhatPhongChieuQLVT(string maPhongChieu)
        {
            this.maPhongChieu = maPhongChieu;
            dsVatTuTrongKho = ChiTietKhoVatTuBLL.Instance.GetAllChiTietKhoVatTuView();
            dsVatTuDaChon = ChiTietPhongChieuBLL.Instance.GetAllVatTuByMaPhongChieu(maPhongChieu);
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
        private void LoadDGVVatTuDaThem()
        {
            dgvVatTuDaThem.DataSource = null;
            dgvVatTuDaThem.DataSource = dsVatTuDaChon;
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
                ChiTietPhongChieuBLL.Instance.ThemChiTietPhongChieuToDSVatTuDaChon(pc,ref dsVatTuDaChon);
                //bool daTonTai = false;
                //foreach (ChiTietPhongChieuDTO i in dsVatTuDaChon)
                //{
                //    if (i.MaVatTu == pc.MaVatTu)
                //    {
                //        daTonTai = true;
                //        i.SoLuongSP += pc.SoLuongSP;
                //    }
                //}
                //if (!daTonTai)
                //{
                //    dsVatTuDaChon.Add(pc);
                //}
                LoadDGVListVatTuKho();
                LoadDGVVatTuDaThem();
            }    
        }
    }
}
