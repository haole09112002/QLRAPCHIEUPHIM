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
        private List<ChiTietPhongChieuView> dsVatTuCoSan;// = new List<ChiTietPhongChieuView>();
        private List<ChiTietPhongChieuView> dsVatTuDaChon = new List<ChiTietPhongChieuView>();
        private string maPhongChieu;
        private string maKho;
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
            LoadDGVVatTuCoSan();
            
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
                this.maKho = dgvListVatTuKho.SelectedRows[0].Cells["MaKho"].Value.ToString();
                txtTenVatTu.Text = dgvListVatTuKho.SelectedRows[0].Cells["TenVatTu"].Value.ToString();
                cbDonViTinh.SelectedItem = dgvListVatTuKho.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                numUpDowSoLuong.Value = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var item = dsVatTuTrongKho.Find(x => x.MaVatTu == txtMaVatTu.Text);
            if (txtMaVatTu.Text == "")
                lbVatTu.Text = "Vật tư còn trống!";
            if (cbDonViTinh.SelectedItem == null)
                lbDonViTinh.Text = "Đơn vị tính còn trống!";
            if (numUpDowSoLuong.Value == 0)
                lbSoLuong.Text = "Số lượng còn trống!";
            if(numUpDowSoLuong.Value > item.SoLuongSP)
                lbSoLuong.Text = "Số lượng vượt quá trong kho!";
            if (txtMaVatTu.Text != "" &&
                cbDonViTinh.SelectedItem != null &&
                numUpDowSoLuong.Value != 0 && numUpDowSoLuong.Value <= item.SoLuongSP)
            {
                ChiTietPhongChieuDTO pc = new ChiTietPhongChieuDTO
                {
                    MaVatTu = txtMaVatTu.Text,
                    DonViTinh = cbDonViTinh.SelectedItem.ToString(),
                    SoLuongSP = Convert.ToInt32(numUpDowSoLuong.Value),
                    MaPhongChieu = maPhongChieu
                };
                ChiTietPhongChieuBLL.Instance.ThemChiTietPhongChieuToDSVatTuCoSan(pc,ref dsVatTuDaChon);
                dsVatTuTrongKho.Remove(item);
                item.SoLuongSP -= pc.SoLuongSP;
                if(item.SoLuongSP > 0)
                    dsVatTuTrongKho.Add(item);
                else
                {
                    txtMaVatTu.Text = "";
                    txtTenVatTu.Text = "";
                    cbDonViTinh.SelectedItem = "";
                    numUpDowSoLuong.Value = 0;
                }
                LoadDGVListVatTuKho();
                LoadDGVVatTuDaThem();
            }    
        }

        private void dgvVatTuDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVatTuDaChon.SelectedRows.Count == 1)
            {
                string maVatTu = dgvVatTuDaChon.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                var item = dsVatTuCoSan.Find(x => x.MaVatTu == maVatTu);
                dsVatTuCoSan.Remove(item);
                int index = dsVatTuTrongKho.FindIndex(x => x.MaVatTu == maVatTu);
                ChiTietKhoVatTuView khoVT = new ChiTietKhoVatTuView()
                {
                    TenVatTu = item.TenVatTu,
                    MaVatTu = item.MaVatTu,
                    DonViTinh = item.DonViTinh,
                    SoLuongSP = dsVatTuTrongKho[index].SoLuongSP + item.SoLuong,
                    MaKho = maKho,
                };
                dsVatTuTrongKho.RemoveAt(index);
                dsVatTuTrongKho.Insert(index, khoVT);
                LoadDGVListVatTuKho();
                LoadDGVVatTuDaThem();
            }
        }

       
    }
}
