using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class frmThemHopDongThucAn : Form
    {
        public delegate void Mydel(string maLoaiHD, string txt);
        public Mydel d { get; set; }
        private string maHopDong;
        private string maDeXuat;
        List<HopDongThucAnView> dsThucAnDaChon = new List<HopDongThucAnView>();
        List<ChiTietDeXuatThucAnViewDTO> dsThucAnCanTaoHopDong = new List<ChiTietDeXuatThucAnViewDTO>();

        public frmThemHopDongThucAn(string maHopDong = "")
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
            setGUI(maHopDong);
        }
        public void setGUI(string maHopDong)
        {
            dsThucAnDaChon = HopDongThucAnBLL.Instance.GetListHopThucAnViewByMaHopDong(maHopDong);
            dsThucAnCanTaoHopDong = HopDongThucAnBLL.Instance.DSThucAnCanThemHopDong();
            foreach (CBBItem i in NhaCungCapBLL.Instance.GetCBBNhaCungCap("LNCC03"))
            {
                cbTenCungCap.Items.Add(i);
            }
            txtMaNCC.Enabled = false;
            txtMaThucAn.Enabled = false;
            txtTenThucAn.Enabled = false;
            cbDonViTinh.Items.AddRange(HopDongThucAnBLL.Instance.GetAllDonViTinh().ToArray());
            ReLoadDGVThucAnLuaChon();
            if (maHopDong != "")        //  xem chi tiet
            {
                txtTenHopDong.Text = HopDongBLL.Instance.GetHopDongByMaHopDong(maHopDong).TenHopDong;
                ReLoadDGVThucAnDaChon();
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

   

        private void dgvThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThucAn.SelectedRows.Count == 1)
            {
                maDeXuat = dgvThucAn.SelectedRows[0].Cells["MaDeXuat"].Value.ToString();
                txtMaThucAn.Text = dgvThucAn.SelectedRows[0].Cells["MaThucAn"].Value.ToString();
                txtTenThucAn.Text = dgvThucAn.SelectedRows[0].Cells["TenThucAn"].Value.ToString();
                cbDonViTinh.SelectedItem = dgvThucAn.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                txtGiaTien.Text = "";
                numUpDowSoLuong.Value = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            string maThucAn = txtMaThucAn.Text;
            string DonViTinh = cbDonViTinh.SelectedItem.ToString();
            string GiaTien = txtGiaTien.Text;
            int SoLuong = Convert.ToInt32(numUpDowSoLuong.Value);
            HopDongThucAnDTO hopDongTA = new HopDongThucAnDTO();
            string result = HopDongThucAnBLL.Instance.KiemTraDuLieuHopDongThucAn(maThucAn, SoLuong, DonViTinh, GiaTien);
            if (result == null)
            {
                try
                {
                    hopDongTA = new HopDongThucAnDTO
                    {
                        MaThucAn = maThucAn,
                        DonViTinh = DonViTinh,
                        GiaTien = Convert.ToDouble(GiaTien),
                        SoLuong = SoLuong,
                        MaHopDong = maHopDong
                    };
                }
                catch (Exception) { }
                HopDongThucAnView item1 = null;
                ChiTietDeXuatThucAnViewDTO item = null;
                foreach (HopDongThucAnView i in dsThucAnDaChon)
                {
                    if (i.MaThucAn == maThucAn)
                        item1 = i;
                }
                if (item1 != null)
                    dsThucAnDaChon.Remove(item1);
                foreach (ChiTietDeXuatThucAnViewDTO j in dsThucAnCanTaoHopDong)
                {
                    if (j.MaThucAn == maThucAn)
                        item = j;
                }
                if (item != null)
                    dsThucAnCanTaoHopDong.Remove(item);
                dsThucAnDaChon.Add(HopDongThucAnBLL.Instance.GetHopDongTAViewByHopDongTADTO(hopDongTA));
                RefreshTextBox();
                cbDonViTinh.SelectedItem = cbDonViTinh.Items[0];
                ReLoadDGVThucAnDaChon();
                ReLoadDGVThucAnLuaChon();
            }
            else
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThucAnDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThucAnDaThem.SelectedRows.Count == 1)
            {
                foreach (HopDongThucAnView i in dsThucAnDaChon)
                {
                    if (i.MaThucAn == dgvThucAnDaThem.SelectedRows[0].Cells["MaThucAn"].Value.ToString())
                    {
                        txtGiaTien.Text = i.GiaTien.ToString();
                        numUpDowSoLuong.Value = i.SoLuong;
                        txtTenThucAn.Text = i.TenThucAn.ToString();
                        txtMaThucAn.Text = i.MaThucAn.ToString();
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
                    MaLoaiHopDong = "LHD003",
                    NgayKiKetHD = dtpThoiGianKiKet.Value
                };
                if (HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong, dsThucAnDaChon.Count) == null)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        HopDongBLL.Instance.ThemHopDong(hopDong);
                        foreach (ChiTietDeXuatThucAnViewDTO i in HopDongThucAnBLL.Instance.DSThucAnCanThemHopDong())
                        {
                            foreach (HopDongThucAnView j in dsThucAnDaChon)
                            {
                                if (i.MaThucAn == j.MaThucAn)
                                        ChiTietDeXuatPhimBLL.Instance.CapNhatTinhTrangDeXuat(i.MaThucAn, i.MaDeXuat, "3");//
                            }
                        }
                        HopDongThucAnBLL.Instance.AddHopDongThucAn(dsThucAnDaChon, maHopDong);
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        d("0", "");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show(HopDongBLL.Instance.KiemTraDuLieuHopDong(hopDong, dsThucAnDaChon.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Dữ liệu Nhà cung cấp còn trống! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void dgvThucAnDaThem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maHopDong == "")
            {
                if (dgvThucAnDaThem.SelectedRows.Count == 1)
                {

                    var item = dsThucAnDaChon.Single(x => x.MaThucAn == txtMaThucAn.Text);
                    dsThucAnDaChon.Remove(item);
                    dsThucAnCanTaoHopDong.Add(new ChiTietDeXuatThucAnViewDTO
                    {
                        MaDeXuat = maDeXuat,
                        MaThucAn = txtMaThucAn.Text,
                        TenThucAn = txtTenThucAn.Text,
                        SoLuong = Convert.ToInt32(numUpDowSoLuong.Value),
                        DonViTinh = cbDonViTinh.SelectedItem.ToString()
                    });
                    ReLoadDGVThucAnDaChon();
                    ReLoadDGVThucAnLuaChon();
                    RefreshTextBox();
                }
            }
        }
        private void ReLoadDGVThucAnDaChon()
        {
            dgvThucAnDaThem.DataSource = null;
            dgvThucAnDaThem.DataSource = dsThucAnDaChon;
            dgvThucAnDaThem.FirstDisplayedCell = null;
            dgvThucAnDaThem.ClearSelection();
            dgvThucAnDaThem.Columns["MaThucAn"].HeaderText = "Mã thức ăn";
            dgvThucAnDaThem.Columns["TenThucAn"].HeaderText = "Tên thức ăn";
            dgvThucAnDaThem.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvThucAnDaThem.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvThucAnDaThem.Columns["GiaTien"].HeaderText = "Giá tiền";

        }
        private void ReLoadDGVThucAnLuaChon()
        {
            dgvThucAn.DataSource = null;
            dgvThucAn.DataSource = dsThucAnCanTaoHopDong;
            dgvThucAn.FirstDisplayedCell = null;
            dgvThucAn.ClearSelection();
            dgvThucAn.Columns["MaDeXuat"].Visible = false;
            dgvThucAn.Columns["MaThucAn"].HeaderText = "Mã thức ăn";
            dgvThucAn.Columns["TenThucAn"].HeaderText = "Tên thức ăn";
            dgvThucAn.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvThucAn.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void RefreshTextBox()
        {
            txtGiaTien.Text = "";
            numUpDowSoLuong.Value = 0;
            txtTenThucAn.Text = "";
            txtMaThucAn.Text = "";
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
