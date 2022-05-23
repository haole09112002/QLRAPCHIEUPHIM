using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class frm_DeXuatPhim : Form
    {
        DataTable dtDienVienChinh = new DataTable();
        DataTable dtDienVienPhu = new DataTable();
        DataTable dtDaoDien = new DataTable();
        public frm_DeXuatPhim()
        {
            InitializeComponent();
            SetDataTable();
            SetCBBHangSanXuatPhim();
            SetCBBTheLoaiPhim();
            SetCBBDienVienDaoDien(cBDienVienChinh);
            SetCBBDienVienDaoDien(cBDienVienPhu);
            SetCBBDienVienDaoDien(cBDaoDien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetDataTable()
        {
            dtDienVienChinh.Columns.Add("Mã Diễn Viên Chính");
            dtDienVienChinh.Columns.Add("Tên Diễn Viên Chính");
            dtDienVienPhu.Columns.Add("Mã Diễn Viên Phụ");
            dtDienVienPhu.Columns.Add("Tên Diễn Viên Phụ");
            dtDaoDien.Columns.Add("Mã Đạo Diễn");
            dtDaoDien.Columns.Add("Tên Đạo Diễn");
        }
        private void pBAnhPhim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pBAnhPhim.ImageLocation = openFileDialog.FileName;
            }
        }
        public void SetCBBTheLoaiPhim()
        {
            foreach (TheLoaiPhimDTO i in TheLoaiPhimBLL.Instance.GetAllTheLoaiPhim())
            {
                cBTheLoai.Items.Add(new CBBItem
                {
                    Value = i.MaTheLoaiPhim,
                    Text = i.TenTheLoaiPhim
                });
            }
        }
        public void SetCBBHangSanXuatPhim()
        {
            cBHangSanXuatPhim.Items.Clear();
            foreach (HangSanXuatPhimDTO i in HangSanXuatPhimBLL.Instance.GetAllHSXP())
            {
                cBHangSanXuatPhim.Items.Add(new CBBItem
                {
                    Value = i.MaHangSanXuatPhim,
                    Text = i.TenHangSanXuatPhim
                });
            }
        }
        public void SetCBBDienVienDaoDien(ComboBox cb, string txt = "")
        {
            cb.Items.Clear();
            foreach (DienVienDaoDienDTO i in DienVienDaoDienBLL.Instance.GetAllDienVienDaoDien(txt))
            {
                cb.Items.Add(new CBBItem
                {
                    Value = i.MaDienVienDaoDien,
                    Text = i.TenDienVienDaoDien
                });
            }
            cb.Sorted = true;
        }
        public bool KiemTraTonTaiDienVienDaoDien(string MaDienVienDaoDien, string VaiTro)
        {
            if (VaiTro == "C")
            {
                for (int i = 0; i < dGVDienVienChinh.Rows.Count - 1; i++)
                {
                    if (dGVDienVienChinh.Rows[i].Cells["Mã Diễn Viên Chính"].Value.ToString() == MaDienVienDaoDien)
                    {
                        return true;
                    }
                }
            }
            if (VaiTro == "P")
            {
                for (int i = 0; i < dGVDienVienPhu.Rows.Count - 1; i++)
                {
                    if (dGVDienVienPhu.Rows[i].Cells["Mã Diễn Viên Phụ"].Value.ToString() == MaDienVienDaoDien)
                    {
                        return true;
                    }
                }
            }
            if (VaiTro == "D")
            {
                for (int i = 0; i < dGVDaoDien.Rows.Count - 1; i++)
                {
                    if (dGVDaoDien.Rows[i].Cells["Mã Đạo Diễn"].Value.ToString() == MaDienVienDaoDien)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool KiemTraTinhDungDang()
        {
            if (txtTenPhim.Text == "")
            {
                MessageBox.Show("Tên phim rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (KiemTraTenPhim() == true) return false;
            if (txtThoiLuong.Text == "")
            {
                MessageBox.Show("Thời lượng rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (cBTheLoai.SelectedIndex < 0)
            {
                MessageBox.Show("Thể loại phim rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (cBQuocGia.SelectedIndex < 0)
            {
                MessageBox.Show("Quốc gia rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (cBHangSanXuatPhim.SelectedIndex < 0)
            {
                MessageBox.Show("Hãng sản xuất phim rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (txtDoTuoiXem.Text == "")
            {
                MessageBox.Show("Độ tuổi xem rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (pBAnhPhim.Image == null)
            {
                MessageBox.Show("Ảnh phim rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (dGVDienVienChinh.RowCount == 0)
            {
                MessageBox.Show("Diẽn viên chính rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (dGVDienVienPhu.RowCount == 0)
            {
                MessageBox.Show("Diẽn viên phụ rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (dGVDaoDien.RowCount == 0)
            {
                MessageBox.Show("Đạo diễn rỗng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool KiemTraTenPhim()
        {
            foreach (PhimDTO i in PhimBLL.Instance.GetAllPhim())
            {
                if (i.TenPhim == txtTenPhim.Text)
                {
                    MessageBox.Show("Phim đã tồn tại");
                    return true;
                }
            }
            return false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhimDTO Phim = new PhimDTO();
            ChiTietDienVienDaoDienPhimDTO ChiTietDVDD = new ChiTietDienVienDaoDienPhimDTO();
            List<String> MaDienVienChinh = new List<String>();
            List<String> MaDienVienPhu = new List<String>();
            List<String> MaDaoDien = new List<string>();
            Phim.NoiDung = rtxtNoiDung.Text;
            Phim.NamSanXuat = dTPNamSanXuat.Value;

            for (int i = 0; i < dGVDienVienChinh.Rows.Count - 1; i++)
            {
                MaDienVienChinh.Add(dGVDienVienChinh.Rows[i].Cells["Mã Diễn Viên Chính"].Value.ToString());
            }
            for (int i = 0; i < dGVDienVienPhu.Rows.Count - 1; i++)
            {
                MaDienVienPhu.Add(dGVDienVienPhu.Rows[i].Cells["Mã Diễn Viên Phụ"].Value.ToString());
            }
            for (int i = 0; i < dGVDaoDien.Rows.Count - 1; i++)
            {
                MaDaoDien.Add(dGVDaoDien.Rows[i].Cells["Mã Đạo Diễn"].Value.ToString());
            }
            if (KiemTraTinhDungDang() == true)
            {
                Phim.TenPhim = txtTenPhim.Text;
                Phim.ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
                Phim.MaTheLoai = ((CBBItem)cBTheLoai.SelectedItem).Value;
                Phim.QuocGia = cBQuocGia.SelectedItem.ToString();
                Phim.MaHangSanXuatPhim = ((CBBItem)cBHangSanXuatPhim.SelectedItem).Value;
                Phim.DoTuoiXem = Convert.ToInt32(txtDoTuoiXem.Text);
                Phim.AnhPhim = PhimBLL.Instance.ChuyenAnhThanhMangByte(pBAnhPhim);
                PhimBLL.Instance.LuuPhim(Phim);
                string MaPhim = PhimBLL.Instance.GetMaPhimAddNew();
                foreach (string i in MaDienVienChinh)
                {
                    ChiTietDienVienDaoDienPhimBLL.Instance.LuuCTDVDDP(MaPhim, i, "C");
                }
                foreach (string i in MaDienVienPhu)
                {
                    ChiTietDienVienDaoDienPhimBLL.Instance.LuuCTDVDDP(MaPhim, i, "P");
                }
                foreach (string i in MaDaoDien)
                {
                    ChiTietDienVienDaoDienPhimBLL.Instance.LuuCTDVDDP(MaPhim, i, "D");
                }
                this.Close();
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frm_ThemMoiDienVienDaoDien_QLP frmThemMoi = new frm_ThemMoiDienVienDaoDien_QLP();
            frmThemMoi.ShowDialog();
            SetCBBDienVienDaoDien(cBDienVienChinh, cBDienVienChinh.Text);
            SetCBBDienVienDaoDien(cBDienVienPhu, cBDienVienPhu.Text);
            SetCBBDienVienDaoDien(cBDaoDien, cBDaoDien.Text);
        }

        private void cBDienVienChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KiemTraTonTaiDienVienDaoDien(((CBBItem)cBDienVienChinh.SelectedItem).Value, "C"))
            {
                MessageBox.Show("Diễn viên(Đạo Diễn) " + cBDienVienChinh.SelectedItem.ToString() + " đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtDienVienChinh.Rows.Add(((CBBItem)cBDienVienChinh.SelectedItem).Value, cBDienVienChinh.SelectedItem.ToString());
                dGVDienVienChinh.DataSource = dtDienVienChinh;
            }
        }

        private void cBDienVienPhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KiemTraTonTaiDienVienDaoDien(((CBBItem)cBDienVienPhu.SelectedItem).Value, "P"))
            {
                MessageBox.Show("Diễn viên(Đạo Diễn) " + cBDienVienPhu.SelectedItem.ToString() + " đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtDienVienPhu.Rows.Add(((CBBItem)cBDienVienPhu.SelectedItem).Value, cBDienVienPhu.SelectedItem.ToString());
                dGVDienVienPhu.DataSource = dtDienVienPhu;
            }
        }

        private void cBDaoDien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KiemTraTonTaiDienVienDaoDien(((CBBItem)cBDaoDien.SelectedItem).Value, "D"))
            {
                MessageBox.Show("Diễn viên(Đạo Diễn) " + cBDaoDien.SelectedItem.ToString() + " đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtDaoDien.Rows.Add(((CBBItem)cBDaoDien.SelectedItem).Value, cBDaoDien.SelectedItem.ToString());
                dGVDaoDien.DataSource = dtDaoDien;
            }
        }

        private void dGVDienVienChinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDienVienChinh.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dGVDienVienChinh.SelectedRows)
                {
                    dGVDienVienChinh.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dGVDienVienPhu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDienVienPhu.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dGVDienVienPhu.SelectedRows)
                {
                    dGVDienVienPhu.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dGVDaoDien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dGVDaoDien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dGVDaoDien.SelectedRows)
                {
                    dGVDaoDien.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void pBThemHSX_Click(object sender, EventArgs e)
        {
            frm_ThemHangSanXuatMoi_QLP frmThemHSXM = new frm_ThemHangSanXuatMoi_QLP();
            frmThemHSXM.ShowDialog();
            SetCBBHangSanXuatPhim();
        }
    }
}
