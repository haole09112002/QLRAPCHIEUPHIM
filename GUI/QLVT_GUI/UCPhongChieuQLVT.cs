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
        private List<ChiTietPhongChieuView> dsVT;
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
            btnXoa.Enabled = false;
            txtMaPhongChieu.Enabled = false;
            txtTenPhongChieu.Enabled=false;
            btnThem.Enabled=false;
            cbLocTinhTrangPC.SelectedIndex = 0;
            txtTimKiem.Text = "Nhập tên phòng";
            txtTimKiemVatTu.Text = "Nhập tên vật tư";
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
                string maPhongChieu = dgvListPhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                LoadDGVListVatTu(maPhongChieu);
                txtMaPhongChieu.Text = maPhongChieu;
                txtTenPhongChieu.Text = PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenPhong;
                foreach(CBBItem i in cbLoaiPhong.Items)
                {
                    if(i.Text == PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenLoaiPhongChieu)
                        cbLoaiPhong.SelectedItem = i;
                }
                foreach (CBBItem i in cbTinhTrangPhong.Items)
                {
                    if (i.Text == PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenTinhTrang)
                        cbTinhTrangPhong.SelectedItem = i;
                }

                cbLoaiPhong.Enabled = false;
                cbTinhTrangPhong.Enabled = false;
                txtTenPhongChieu.Enabled = false;
                btnLuu.Enabled=false;
                btnHuy.Enabled=false;
                btnChinhSua.Enabled=true;
                btnThem.Enabled = true;
            
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
            dsVT = ChiTietPhongChieuBLL.Instance.GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu);
            dgvListVatTu.DataSource = null;
            dgvListVatTu.DataSource = dsVT;
            dgvListVatTu.Columns["MaPhongChieu"].Visible = false;
            
            dgvListVatTu.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvListVatTu.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvListVatTu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvListVatTu.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void btnThemPhongChieu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenPhongChieu.Enabled = true;
            cbLoaiPhong.Enabled = true;
            cbTinhTrangPhong.Enabled = true;
            txtMaPhongChieu.Text = "";
            cbLoaiPhong.SelectedIndex = -1;
            cbTinhTrangPhong.SelectedIndex = -1;
            txtTenPhongChieu.Text = "";
            lbThongBao.Text = "Mời nhập thông tin phòng chiếu!";
            btnHuy.Enabled = true;
            btnChinhSua.Enabled = false;
            btnThem.Enabled = false;
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
                    btnThem.Enabled = true;
                    cbTinhTrangPhong.Enabled = false;
                    LoadDGVPhongChieu();
                }
                
            
         
        }

        private void txtTenPhongChieu_TextChanged(object sender, EventArgs e)
        {
            lbTenPhong.Text = "";
            lbThongBao.Text = "";
            if (txtMaPhongChieu.Text != "")
            {
                if (cbTinhTrangPhong.SelectedIndex != -1)
                    if (txtTenPhongChieu.Text == PhongChieuBLL.Instance.GetPhongChieuByMaPC(txtMaPhongChieu.Text).TenPhong
                        && (((CBBItem)cbTinhTrangPhong.SelectedItem).Value == PhongChieuBLL.Instance.GetPhongChieuByMaPC(txtMaPhongChieu.Text).MaTinhTrang.ToString()))
                {
                    btnLuu.Enabled = false;
          
                }
                else
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLoaiPhong.Text = "";
        }

        private void cbTinhTrangPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTinhTrang.Text = "";
            if(txtMaPhongChieu.Text != "")
            {
                if (((CBBItem)cbTinhTrangPhong.SelectedItem).Value == PhongChieuBLL.Instance.GetPhongChieuByMaPC(txtMaPhongChieu.Text).MaTinhTrang.ToString()
                    && txtTenPhongChieu.Text == PhongChieuBLL.Instance.GetPhongChieuByMaPC(txtMaPhongChieu.Text).TenPhong)
                {
                    btnLuu.Enabled = false;
          
                }
                else
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }              
        }

        private void cbLocTinhTrangPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocTinhTrangPC.SelectedIndex != -1)
                dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.GetDsPhongChieuViewByMaTinhTrang(((CBBItem)cbLocTinhTrangPC.SelectedItem).Value);
            
        }

        private void btnTimKiemPhongChieu_Click(object sender, EventArgs e)
        {
            string maTinhTrang = "0";
            if (cbLocTinhTrangPC.SelectedIndex != -1)
                maTinhTrang = ((CBBItem)cbLocTinhTrangPC.SelectedItem).Value;
            dgvListPhongChieu.DataSource = PhongChieuBLL.Instance.TimKiemPhongChieu(txtTimKiem.Text, maTinhTrang);
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập tên phòng";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(txtMaPhongChieu.Text != "")
            {
                
                btnChinhSua.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                txtTenPhongChieu.Enabled = false;
                cbTinhTrangPhong.Enabled = false;
            }    
            else
            {
                lbThongBao.Text = "Mời nhập thông tin phòng chiếu!";
                lbLoaiPhong.Text = "";
                lbTinhTrang.Text = "";
                lbTenPhong.Text = "";
                txtTenPhongChieu.Text = "";
                cbLoaiPhong.SelectedIndex = -1;
                cbTinhTrangPhong.SelectedIndex = -1;
                btnLuu.Enabled = true;
                btnChinhSua.Enabled = false;
            }    
        }

        private void btnTimKiemVatTu_Click(object sender, EventArgs e)
        {
            if(dgvListPhongChieu.SelectedRows.Count == 1)
            {
                
                string maPhongChieu = dgvListPhongChieu.SelectedRows[0].Cells["MaPhongChieu"].Value.ToString();
                dgvListVatTu.DataSource = ChiTietPhongChieuBLL.Instance.TimKiemVatTuTrongPhongChieu(txtTimKiemVatTu.Text, maPhongChieu);
                if (txtTimKiemVatTu.Text == "")
                {
                    txtTimKiemVatTu.Text = "Nhập tên vật tư";
                }    
            }
            else
                MessageBox.Show("Bạn chưa chọn phòng chiếu! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            
            txtTenPhongChieu.ReadOnly = false;
            txtTenPhongChieu.Enabled = true;
            cbTinhTrangPhong.Enabled = true ;
            btnChinhSua.Enabled = false ;
            btnHuy.Enabled = true ;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "Nhập tên phòng")
                txtTimKiem.Text = "";
        }

        private void txtTimKiemVatTu_Click(object sender, EventArgs e)
        {
            if(txtTimKiemVatTu.Text == "Nhập tên vật tư")
                txtTimKiemVatTu.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListVatTu.SelectedRows.Count == 1)
            {
                string maVatTu = dgvListVatTu.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                var vtPC = dsVT.Find(i=>i.MaVatTu == maVatTu);
                if(vtPC != null)
                {
                    if (numericUpDownSoLuongXoa.Value > 0 && numericUpDownSoLuongXoa.Value <= vtPC.SoLuong)
                    {
                        DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            ChiTietKhoVatTuDTO kho = new ChiTietKhoVatTuDTO
                            {
                                MaVatTu = maVatTu,
                                DonViTinh = dgvListVatTu.SelectedRows[0].Cells["DonViTinh"].Value.ToString(),
                                SoLuongSP = Convert.ToInt32(numericUpDownSoLuongXoa.Value),
                                MaKho = "K0002"
                            };
                            ChiTietPhongChieuDTO pc = new ChiTietPhongChieuDTO
                            {
                                MaPhongChieu = vtPC.MaPhongChieu,
                                MaVatTu = maVatTu,
                                DonViTinh = vtPC.DonViTinh,
                                SoLuongSP = Convert.ToInt32(numericUpDownSoLuongXoa.Value)
                            };
                            ChiTietKhoVatTuBLL.Instance.XoaMotVTTrongKho(kho);
                            ChiTietPhongChieuBLL.Instance.XoaMotVatTuTrongPC(pc);
                            LoadDGVListVatTu(vtPC.MaPhongChieu);
                        }                        }
                    else
                        lbSoLuongXoa.Text = "Số lượng không hợp lệ!";
                }
               
                    
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn vật tư cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
       
        }

        private void numericUpDownSoLuongXoa_ValueChanged(object sender, EventArgs e)
        {
            lbSoLuongXoa.Text = "";
        }

        private void dgvListVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }
    }
    
}
