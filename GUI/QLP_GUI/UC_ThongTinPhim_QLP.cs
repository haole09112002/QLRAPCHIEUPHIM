using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_ThongTinPhim_QLP : UserControl
    {
        DataTable dtDanhSachPhim = new DataTable();
        public UC_ThongTinPhim_QLP()
        {
            InitializeComponent();
            SetDataTable();
            Reload();
            btnXemChiTiet.Enabled = false;
        }
        public void SetDataTable()
        {
            dtDanhSachPhim.Columns.Add("Mã Phim");
            dtDanhSachPhim.Columns.Add("Tên Phim");
            dtDanhSachPhim.Columns.Add("Thời Lượng");
            dtDanhSachPhim.Columns.Add("Quốc Gia");
            dtDanhSachPhim.Columns.Add("Năm Sản Xuất");
            dtDanhSachPhim.Columns.Add("Tên Hãng Sản Xuất Phim");
            dtDanhSachPhim.Columns.Add("Độ Tuổi Xem");
            dtDanhSachPhim.Columns.Add("Thể Loại");
        }
        public void Reload(string txt = "", string TimKiem = "")
        {
            dtDanhSachPhim.Rows.Clear();
            foreach (PhimViewDTO i in PhimBLL.Instance.GetPhimViews(txt, TimKiem))
            {
                dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
            }
            dGVDanhSachPhim.DataSource = dtDanhSachPhim;
            dGVDanhSachPhim.Columns["Mã Phim"].Visible = false;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cBTimKiem.SelectedIndex < 0)
            {
                    MessageBox.Show("Chưa chọn loại tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Reload(txtTimKiem.Text, cBTimKiem.SelectedItem.ToString());
            }
        }
        public void SearchShow(string cbSapXep, string txtTimKiem, string cbTimKiem)
        {
            dtDanhSachPhim.Rows.Clear();
            switch (cbSapXep)
            {
                case "Tên Phim":
                    {
                        foreach (PhimViewDTO i in PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareTenPhim, txtTimKiem, cbTimKiem))
                        {
                            dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
                        }
                        break;
                    }
                case "Thời Lượng":
                    {
                        foreach (PhimViewDTO i in PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareThoiLuong, txtTimKiem, cbTimKiem))
                        {
                            dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
                        }
                        break;
                    }
                case "Quốc Gia":
                    {
                        foreach (PhimViewDTO i in PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareQuocGia, txtTimKiem, cbTimKiem))
                        {
                            dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
                        }
                        break;
                    }
                case "Năm Sản Xuất":
                    {
                        foreach (PhimViewDTO i in PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareNamSanXuat, txtTimKiem, cbTimKiem))
                        {
                            dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
                        }
                        break;
                    }
                case "Thể Loại":
                    {
                        foreach (PhimViewDTO i in PhimBLL.Instance.SortPhimView(PhimBLL.Instance.CompareTheLoai, txtTimKiem, cbTimKiem))
                        {
                            dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
                        }
                        break;
                    }
            }
            dGVDanhSachPhim.DataSource = dtDanhSachPhim;
            dGVDanhSachPhim.Columns["Mã Phim"].Visible = false;
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string search = "";
            string Sort = "Tên Phim";
            if (cBSapXep.SelectedIndex >= 0)
            {
                Sort = cBSapXep.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn loại sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cBTimKiem.SelectedIndex >= 0)
            {
                search = cBTimKiem.SelectedItem.ToString();
            }
            SearchShow(Sort, txtTimKiem.Text, search);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachPhim.SelectedRows.Count == 1)
            {
                var frmTTP = new frmThongTinPhim(dGVDanhSachPhim.SelectedRows[0].Cells["Mã Phim"].Value.ToString());
                frmTTP.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_DeXuatPhim frmDXP = new frm_DeXuatPhim();
            frmDXP.ShowDialog();
            Reload();
        }

        private void dGVDanhSachPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDanhSachPhim.SelectedRows.Count == 1)
            {
                btnXemChiTiet.Enabled = true;
            }
            else
            {
                btnXemChiTiet.Enabled = false;
            }
        }
    }
}
