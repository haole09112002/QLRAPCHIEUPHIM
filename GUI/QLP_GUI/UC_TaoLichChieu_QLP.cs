using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_TaoLichChieu_QLP : UserControl
    {
        DataTable dtDanhSachPhim = new DataTable();
        DataTable dtDanhSachPhongChieu = new DataTable();
        DataTable dtKhungGioChieu = new DataTable();
        public UC_TaoLichChieu_QLP()
        {
            InitializeComponent();
            SetDataTable();
            ReLoad();
            rBDSPhim.Checked = true;
            txtMaKhungGioChieu.Visible = false;
            txtMaPhim.Visible = false;
            txtMaPhongChieu.Visible = false;
        }
        public void SetDataTable()
        {
            dtDanhSachPhim.Columns.Add("Mã Phim");
            dtDanhSachPhim.Columns.Add("Tên Phim");
            dtDanhSachPhongChieu.Columns.Add("Mã Phòng Chiếu");
            dtDanhSachPhongChieu.Columns.Add("Tên Phòng Chiếu");
            dtKhungGioChieu.Columns.Add("Mã Khung Giờ Chiếu");
            dtKhungGioChieu.Columns.Add("Giờ Bắt Đầu");
            dtKhungGioChieu.Columns.Add("Giờ Kết Thúc");
        }
        public void ReLoad()
        {
            foreach (PhimDTO i in PhimBLL.Instance.GetAllPhimCoHopDong())
            {
                foreach(string j in ChiTietKhoPhimBLL.Instance.GetDanhSachMaPhimCoTrongKho())
                {
                    if(i.MaPhim == j)
                    {
                        dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim);
                    }
                }
            }
            foreach (PhongChieuDTO i in PhongChieuBLL.Instance.GetAllPhongChieuByTinhTrang(1))
            {
                dtDanhSachPhongChieu.Rows.Add(i.MaPhongChieu, i.TenPhong);
            }
            foreach (KhungGioChieuDTO i in KhungGioChieuBLL.Instance.GetAllKhungGioChieu())
            {
                dtKhungGioChieu.Rows.Add(i.MaKhungGioChieu, i.TGBatDau.ToLongTimeString(), i.TGKetThuc.ToLongTimeString());
            }
            dGVDanhSachPhim.DataSource = dtDanhSachPhim;
            dGVDanhSachPhim.Columns["Mã Phim"].Visible = false;
            dGVDanhSachPC.DataSource = dtDanhSachPhongChieu;
            dGVDanhSachPC.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVKhungGioChieu.DataSource = dtKhungGioChieu;
            dGVKhungGioChieu.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }

        public bool KiemTraTinhDungDang()
        {
            bool kt = true;
            if (txtTenPhim.Text == "")
            {
                lbTenPhim.Text = "*Vui lòng chọn phim";
                kt = false;
            }
            else
            {
                lbTenPhim.Text = "";
            }
            if (txtPhongChieu.Text == "")
            {
                lbPhongChieu.Text = "*Vui lòng chọn phòng chiếu";
                kt = false;
            }
            else
            {
                lbPhongChieu.Text = "";
            }
            if (txtGioChieu.Text == "")
            {
                lbKhungGioChieu.Text = "*Vui lòng chọn khung giờ chiếu";
                kt = false;
            }
            else
            {
                lbKhungGioChieu.Text = "";
            }
            if(dTPNgayChieu.Value.Date > HopDongPhimBLL.Instance.GetHopDongPhimByMaPhim(txtMaPhim.Text).NgayKetThucBanQuyen)
            {
                lbTenPhim.Text = "*Phim đã hết hạn hợp đồng vào thời điểm chiếu";
                kt = false;
            }
            else
            {
                lbTenPhim.Text = "";
            }
            return kt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraTinhDungDang())
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    string KiemTra = LichChieuBLL.Instance.KiemTraLichChieu(txtMaPhim.Text, txtMaKhungGioChieu.Text, txtMaPhongChieu.Text, dTPNgayChieu.Value);
                    if (KiemTra == "")
                    {
                        LichChieuBLL.Instance.LuuLichChieu(txtMaPhim.Text, txtMaKhungGioChieu.Text, txtMaPhongChieu.Text, "1", dTPNgayChieu.Value);
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(KiemTra, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtGioChieu.Text = txtMaKhungGioChieu.Text = txtMaPhim.Text = txtMaPhongChieu.Text = txtPhongChieu.Text = txtTenPhim.Text = "";
                }
            }
        }

        private void dGVDanhSachPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDanhSachPhim.SelectedRows.Count == 1)
            {
                txtMaPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
                txtTenPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Tên Phim"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dGVDanhSachPC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDanhSachPC.SelectedRows.Count == 1)
            {
                txtMaPhongChieu.Text = dGVDanhSachPC.SelectedRows[0].Cells["Mã Phòng Chiếu"].Value.ToString();
                txtPhongChieu.Text = dGVDanhSachPC.SelectedRows[0].Cells["Tên Phòng Chiếu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dGVKhungGioChieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVKhungGioChieu.SelectedRows.Count == 1)
            {
                txtMaKhungGioChieu.Text = dGVKhungGioChieu.SelectedRows[0].Cells["Mã Khung Giờ Chiếu"].Value.ToString();
                txtGioChieu.Text = dGVKhungGioChieu.SelectedRows[0].Cells["Giờ Bắt Đầu"].Value.ToString()
                    + "-" + dGVKhungGioChieu.SelectedRows[0].Cells["Giờ Kết Thúc"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtGioChieu.Text = "";
            txtPhongChieu.Text = "";
            txtTenPhim.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rBDSPhim.Checked == true)
            {
                dtDanhSachPhim.Rows.Clear();
                foreach (PhimDTO i in PhimBLL.Instance.GetAllPhimCoHopDong(txtTimKiem.Text))
                {
                    dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim);
                }
                dGVDanhSachPhim.DataSource = dtDanhSachPhim;
            }
            if (rBDSPChieu.Checked == true)
            {
                dtDanhSachPhongChieu.Rows.Clear();
                foreach (PhongChieuDTO i in PhongChieuBLL.Instance.GetAllPhongChieuByTinhTrang(1, txtTimKiem.Text))
                {
                    dtDanhSachPhongChieu.Rows.Add(i.MaPhongChieu, i.TenPhong);
                }
                dGVDanhSachPC.DataSource = dtDanhSachPhongChieu;
            }
        }

        private void UC_TaoLichChieu_QLP_Leave(object sender, EventArgs e)
        {
            txtMaPhim.Text = "";
            txtMaPhongChieu.Text = "";
            txtGioChieu.Text = "";
            txtTenPhim.Text = "";
            txtTimKiem.Text = "";
            txtMaKhungGioChieu.Text = "";
            txtPhongChieu.Text = "";
        }
    }
}
