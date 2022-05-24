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
    public partial class UCPhongChieuQLVT : UserControl
    {
        public UCPhongChieuQLVT()
        {
            InitializeComponent();
            setGUI();
        }
        private void setGUI()
        {
            cbLoaiPhong.Items.AddRange(LoaiPhongChieuBLL.Instance.GetCBBLoaiPhongChieu().ToArray());
            cbLocTinhTrangPC.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbLocTinhTrangPC.Items.AddRange(TinhTrangPhongChieuBLL.Instance.GetCBBTinhTrangPhongChieu().ToArray());
            cbTinhTrangPhong.Items.AddRange(TinhTrangPhongChieuBLL.Instance.GetCBBTinhTrangPhongChieu().ToArray());
            LoadDGVPhongChieu();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnChinhSua.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaPhongChieu.Text != "")
            {
                FrmCapNhatPhongChieuQLVT frmCapNhatPhongChieuQLVT = new FrmCapNhatPhongChieuQLVT(txtMaPhongChieu.Text);
                frmCapNhatPhongChieuQLVT.d = new FrmCapNhatPhongChieuQLVT.Mydel(LoadDGVListVatTu);
                frmCapNhatPhongChieuQLVT.ShowDialog();
            }    
        }

        private void dgvListPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvListPhongChieu.SelectedRows.Count == 1)
            {
                txtMaPhongChieu.ReadOnly = true;
                txtMaPhongChieu.ReadOnly = true;
                cbLoaiPhong.Enabled = false;
                cbTinhTrangPhong.Enabled = false;
                txtTenPhongChieu.ReadOnly=true;
                string maPhongChieu = dgvListPhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                LoadDGVListVatTu(maPhongChieu);
                txtMaPhongChieu.Text = maPhongChieu;
                txtTenPhongChieu.Text = dgvListPhongChieu.SelectedRows[0].Cells["TenPhong"].Value.ToString();
                foreach(CBBItem i in cbLoaiPhong.Items)
                {
                    if(i.Text == dgvListPhongChieu.SelectedRows[0].Cells["TenLoaiPhongChieu"].Value.ToString())
                        cbLoaiPhong.SelectedItem = i;
                }
                foreach (CBBItem i in cbTinhTrangPhong.Items)
                {
                    if (i.Text == dgvListPhongChieu.SelectedRows[0].Cells["TenTinhTrang"].Value.ToString())
                        cbTinhTrangPhong.SelectedItem = i;
                }
                btnLuu.Enabled=false;
                btnHuy.Enabled=false;
                btnChinhSua.Enabled=true;
            }    
        }
        private void LoadDGVPhongChieu()
        {
            dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.GetAllPhongChieuView();
            dgvListPhongChieu.Columns["MaPhongChieu"].HeaderText = "Mã phòng";
            dgvListPhongChieu.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvListPhongChieu.Columns["TenTinhTrang"].HeaderText = "Tình trạng";
            dgvListPhongChieu.Columns["TenLoaiPhongChieu"].HeaderText = "Loại phòng";
        }
        private void LoadDGVListVatTu (string maPhongChieu)
        {
            dgvListVatTu.DataSource = null;
            dgvListVatTu.DataSource = ChiTietPhongChieuBLL.Instance.GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu);
            dgvListVatTu.Columns["MaPhongChieu"].Visible = false;
            dgvListVatTu.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvListVatTu.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvListVatTu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvListVatTu.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void btnThemPhongChieu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaPhongChieu.Enabled = false;
            cbLoaiPhong.Enabled = true;
            cbTinhTrangPhong.Enabled = true;
            txtTenPhongChieu.ReadOnly = false;
            txtMaPhongChieu.Text = null;
            cbLoaiPhong.SelectedIndex = -1;
            cbTinhTrangPhong.SelectedIndex = -1;
            txtTenPhongChieu.Text = null;
            lbThongBao.Text = "Mời nhập thông tin phòng chiếu!";
            btnHuy.Enabled = true;
            btnChinhSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                if (txtTenPhongChieu.Text == "")
                {
                    lbTenPhong.Text = "Tên phòng trống!";
                }
                if (cbLoaiPhong.SelectedIndex == -1)
                {
                    lbLoaiPhong.Text = "Chưa chọn loại phòng!";
                }
                if (cbTinhTrangPhong.SelectedIndex == -1)
                {
                    lbTinhTrang.Text = "Chưa chọn tình trạng phòng!";
                }
                if (txtTenPhongChieu.Text != "" &&
                    cbLoaiPhong.SelectedIndex != -1 &&
                    cbTinhTrangPhong.SelectedIndex != -1)
                {

                    PhongChieuDTO pc = new PhongChieuDTO
                    {
                        MaPhongChieu = txtMaPhongChieu.Text,
                        TenPhong = txtTenPhongChieu.Text,
                        MaTinhTrang = Convert.ToInt32(((CBBItem)cbTinhTrangPhong.SelectedItem).Value),
                        MaLoaiPhongChieu = ((CBBItem)cbLoaiPhong.SelectedItem).Value
                    };
                    PhongChieuBLL.Instance.ThemCapNhatPhongChieu(pc);
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    btnChinhSua.Enabled = true;
                    LoadDGVPhongChieu();
                }
                
            
         
        }

        private void txtTenPhongChieu_TextChanged(object sender, EventArgs e)
        {
            lbTenPhong.Text = "";
            lbThongBao.Text = "";
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLoaiPhong.Text = "";
        }

        private void cbTinhTrangPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTinhTrang.Text = "";
        }

        private void cbLocTinhTrangPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocTinhTrangPC.SelectedIndex != -1)
                dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.GetDsPhongChieuViewByMaTinhTrang(((CBBItem)cbLocTinhTrangPC.SelectedItem).Value);
            txtTimKiem.Text = "";
        }

        private void btnTimKiemPhongChieu_Click(object sender, EventArgs e)
        {
            string maTinhTrang = "0";
            if (cbLocTinhTrangPC.SelectedIndex != -1)
                maTinhTrang = ((CBBItem)cbLocTinhTrangPC.SelectedItem).Value;
            dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.TimKiemPhongChieu(txtTimKiem.Text, maTinhTrang);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhongChieu.Text = "";
            btnLuu.Enabled = true;
            txtTenPhongChieu.Text = "";
            cbLoaiPhong.SelectedIndex = -1;
            cbTinhTrangPhong.SelectedIndex = -1;
            cbLoaiPhong.Enabled = true;
            lbLoaiPhong.Text = "";
            lbTinhTrang.Text = "";
            lblVatTu.Text = "";
            lbThongBao.Text = "Mời nhập thông tin phòng chiếu!";
            lbTenPhong.Text = "";
           btnChinhSua.Enabled = true;
        }

        private void btnTimKiemVatTu_Click(object sender, EventArgs e)
        {
            if(dgvListPhongChieu.SelectedRows.Count == 1)
            {
                string maPhongChieu = dgvListPhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                dgvListVatTu.DataSource = ChiTietPhongChieuBLL.Instance.TimKiemVatTuTrongPhongChieu(txtTimKiemVatTu.Text, maPhongChieu);
            }    
           
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenPhongChieu.ReadOnly = false;
            cbTinhTrangPhong.Enabled = true ;
            btnChinhSua.Enabled = false ;
        }
    }
}
