using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DTO;
using BLL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class frmThemHopDongVatTu : Form
    {
        public delegate void Mydel(string maLoaiHD, string txt, string tc = "");
        public Mydel d { get; set; }
        private string maHopDong;
        private string maDeXuat;
        List<HopDongVatTuView> dsVatTuDaChon = new List<HopDongVatTuView>();
        List<ChiTietDeXuatVatTuView> dsVatTuCanTaoHopDong = new List<ChiTietDeXuatVatTuView>();

        public frmThemHopDongVatTu(string maHopDong = "")
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
            setGUI(maHopDong);
        }
        public void setGUI(string maHopDong)
        {
            dsVatTuDaChon = HopDongVatTuBLL.Instance.GetListHopVatTuViewByMaHopDong(maHopDong);
            dsVatTuCanTaoHopDong = HopDongVatTuBLL.Instance.DSVatTuCanThemHopDong();
            foreach (CBBItem i in NhaCungCapBLL.Instance.GetCBBNhaCungCap("LNCC02"))
            {
                cbTenCungCap.Items.Add(i);
            }
            txtMaNCC.Enabled = false;
            txtMaVatTu.Enabled = false;
            txtTenVatTu.Enabled = false;
            cbDonViTinh.Items.AddRange(HopDongVatTuBLL.Instance.GetAllDonViTinh().ToArray());
            ReLoadDGVVatTuLuaChon();
            if (maHopDong != "")        //  xem chi tiet
            {
                txtTenHopDong.Text = HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).TenHopDong;
                ReLoadDGVVatTuDaChon();
                foreach (CBBItem i in cbTenCungCap.Items)
                {
                    if (i.Value == HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).MaNhaCungCap)
                        cbTenCungCap.SelectedItem = i;
                }
                txtTenHopDong.Enabled = false;
                label14.Text = "*Kích chọn để xem";
                label14.ForeColor = Color.Red;
                setEnable(false);
                gbxNoiDung.Location = new Point(3, 107);
                gbLuaChonPhim.Visible = false;

                btnThem.Visible = false;
                btnLuu.Visible = false;

            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Visible == true)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát!, Dữ liệu chưa được lưu lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void cbTenCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = ((CBBItem)cbTenCungCap.SelectedItem).Value;
        }



        private void dgvVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVatTu.SelectedRows.Count == 1)
            {
                maDeXuat = dgvVatTu.SelectedRows[0].Cells["MaDeXuat"].Value.ToString();
                txtMaVatTu.Text = dgvVatTu.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                txtTenVatTu.Text = dgvVatTu.SelectedRows[0].Cells["TenVatTu"].Value.ToString();
                cbDonViTinh.SelectedItem = dgvVatTu.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                txtGiaTien.Text = "";
                numUpDowSoLuong.Value = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            string MaVatTu = txtMaVatTu.Text;
            string DonViTinh = cbDonViTinh.SelectedItem.ToString();
            string GiaTien = txtGiaTien.Text;
            int SoLuong = Convert.ToInt32(numUpDowSoLuong.Value);
            HopDongVatTuDTO hopDongVT = new HopDongVatTuDTO();
            string result = HopDongVatTuBLL.Instance.KiemTraDuLieuHopDongVatTu(MaVatTu, SoLuong, DonViTinh, GiaTien);
            if (result == null)
            {
                try
                {
                    hopDongVT = new HopDongVatTuDTO
                    {
                        MaVatTu = MaVatTu,
                        DonViTinh = DonViTinh,
                        GiaTien = Convert.ToDouble(GiaTien),
                        SoLuong = SoLuong,
                        MaHopDong = maHopDong
                    };
                }
                catch (Exception) { }
                HopDongVatTuView item1 = null;
                ChiTietDeXuatVatTuView item = null;
                foreach (HopDongVatTuView i in dsVatTuDaChon)
                {
                    if (i.MaVatTu == MaVatTu)
                        item1 = i;
                }
                if (item1 != null)
                    dsVatTuDaChon.Remove(item1);
                foreach (ChiTietDeXuatVatTuView j in dsVatTuCanTaoHopDong)
                {
                    if (j.MaVatTu == MaVatTu)
                        item = j;
                }
                if (item != null)
                    dsVatTuCanTaoHopDong.Remove(item);
                dsVatTuDaChon.Add(HopDongVatTuBLL.Instance.GetHopDongVaTuViewByHopDongVatTuDTO(hopDongVT));
                RefreshTextBox();
                cbDonViTinh.SelectedItem = cbDonViTinh.Items[0];
                ReLoadDGVVatTuDaChon();
                ReLoadDGVVatTuLuaChon();
                
            }
            else
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVatTuDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVatTuDaThem.SelectedRows.Count == 1)
            {
                foreach (HopDongVatTuView i in dsVatTuDaChon)
                {
                    if (i.MaVatTu == dgvVatTuDaThem.SelectedRows[0].Cells["MaVatTu"].Value.ToString())
                    {
                        txtGiaTien.Text = i.GiaTien.ToString();
                        numUpDowSoLuong.Value = i.SoLuong;
                        txtTenVatTu.Text = i.TenVatTu.ToString();
                        txtMaVatTu.Text = i.MaVatTu.ToString();
                        cbDonViTinh.SelectedItem = i.DonViTinh;
                    }
                }

            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            HopDongDTO hopDong = new HopDongDTO();
            if (cbTenCungCap.SelectedIndex >= 0)
            {
                hopDong = new HopDongDTO
                {
                    MaHopDong = maHopDong,
                    TenHopDong = txtTenHopDong.Text,
                    MaNhaCungCap = ((CBBItem)cbTenCungCap.SelectedItem).Value,
                    MaLoaiHopDong = "LHD002",
                    NgayKiKetHD = dtpThoiGianKiKet.Value
                };
                if (HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong, dsVatTuDaChon.Count) == null)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        HopDongBLL.Instance.ThemHopDong(hopDong);
                        foreach (ChiTietDeXuatVatTuView i in HopDongVatTuBLL.Instance.DSVatTuCanThemHopDong())
                        {
                            foreach (HopDongVatTuView j in dsVatTuDaChon)
                            {
                                if (i.MaVatTu == j.MaVatTu)
                                    ChiTietDeXuatPhimBLL.Instance.CapNhatTinhTrangDeXuat(i.MaVatTu, i.MaDeXuat, "3");//
                            }
                        }
                        HopDongVatTuBLL.Instance.AddHopDongVatTu(dsVatTuDaChon, maHopDong);
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        d("0", "");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show(HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong, dsVatTuDaChon.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Dữ liệu Nhà cung cấp còn trống! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void dgvVatTuDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maHopDong == "")
            {
                if (dgvVatTuDaThem.SelectedRows.Count == 1)
                {

                    var item = dsVatTuDaChon.Single(x => x.MaVatTu == txtMaVatTu.Text);
                    dsVatTuDaChon.Remove(item);
                    dsVatTuCanTaoHopDong.Add(new ChiTietDeXuatVatTuView
                    {
                        MaDeXuat = maDeXuat,
                        MaVatTu = txtMaVatTu.Text,
                        TenVatTu = txtTenVatTu.Text,
                        SoLuong = Convert.ToInt32(numUpDowSoLuong.Value),
                        DonViTinh = cbDonViTinh.SelectedItem.ToString()
                    });
                    ReLoadDGVVatTuDaChon();
                    ReLoadDGVVatTuLuaChon();
                    RefreshTextBox();
                }
            }
        }
        private void ReLoadDGVVatTuDaChon()
        {
            dgvVatTuDaThem.DataSource = null;
            dgvVatTuDaThem.DataSource = dsVatTuDaChon;
            dgvVatTuDaThem.FirstDisplayedCell = null;
            dgvVatTuDaThem.ClearSelection();
            dgvVatTuDaThem.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvVatTuDaThem.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvVatTuDaThem.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvVatTuDaThem.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvVatTuDaThem.Columns["GiaTien"].HeaderText = "Giá tiền";

        }
        private void ReLoadDGVVatTuLuaChon()
        {
            dgvVatTu.DataSource = null;
            dgvVatTu.DataSource = dsVatTuCanTaoHopDong;
            dgvVatTu.FirstDisplayedCell = null;
            dgvVatTu.ClearSelection();
            dgvVatTu.Columns["MaDeXuat"].Visible = false;
            dgvVatTu.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvVatTu.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvVatTu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvVatTu.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void RefreshTextBox()
        {
            txtGiaTien.Text = "";
            numUpDowSoLuong.Value = 0;
            txtTenVatTu.Text = "";
            txtMaVatTu.Text = "";
        }
        private void setEnable(bool var)
        {
            cbTenCungCap.Enabled = var;
            dtpThoiGianKiKet.Enabled = var;

            numUpDowSoLuong.Enabled = var;
            cbDonViTinh.Enabled = var;
            txtGiaTien.Enabled = var;

            btnThem.Enabled = var;
        }

     }
}
