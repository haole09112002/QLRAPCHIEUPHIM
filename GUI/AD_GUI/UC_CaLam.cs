using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_CaLam : UserControl
    {
        DataTable dtListLamViec = new DataTable();
        DataTable dtListNhanVien = new DataTable();

        public UC_CaLam()
        {
            InitializeComponent();
            setGUI();
            ReLoad();
        }
        public void ReLoad()
        {
            SetDataTable();
            LoadListNhanVien();

        }
        public void setGUI()
        {
            cboTimKiemCaLamViec.Items.Add(new CBBItem { Text = "Tất Cả", Value = "" });
            cboTimKiemCaLamViec.Items.AddRange(CaLamViecBLL.Instance.GetCBBCaLamViec().ToArray());
            cboThemCaLamViec.Items.AddRange(CaLamViecBLL.Instance.GetCBBCaLamViec().ToArray());
            dtListLamViec.Columns.Add("Mã Nhân Viên");
            dtListLamViec.Columns.Add("Tên Nhân Viên");
            dtListLamViec.Columns.Add("Tên Ca Làm Việc");
            dtListLamViec.Columns.Add("Giờ Bắt Đầu");
            dtListLamViec.Columns.Add("Giờ Kết Thúc");
            dtListLamViec.Columns.Add("Ngày Làm Việc");
            dtListNhanVien.Columns.Add("Mã Nhân Viên");
            dtListNhanVien.Columns.Add("Tên Nhân Viên");
            cboTimKiemCaLamViec.SelectedIndex = 0;
            LoadListLamViec();
        }
        public void SetDataTable()
        {
            //dtListLamViec.Columns.Clear();
            //dtListNhanVien.Columns.Clear();
            lblNhapTen.Visible = true;
            lblErrorXoa.Visible = true;
            lblErrorChonXoa.Visible = false;
            btnXoa.Enabled = false;
            lblValidatedNgayLamViec.Visible = false;
            lblValidatedCaLamViec.Visible = false;
            btnThem.Enabled = false;
            lblThongBao.Visible = true;
            lblValidatedNhanVien.Visible = false;
            dtpThemNgayLamViec.Value = DateTime.Now;
            txtTenNhanVien.Text = "";
            txtMaNhanVien.Text = "";

        }
        public void LoadListLamViec(string txt = "")
        {
            dtListLamViec.Rows.Clear();
            foreach (LichLamViecDTO i in LichLamViecBLL.Instance.GetAllLichLamViecByNgayLamViec(dtpTimKiemLich.Value, ((CBBItem)cboTimKiemCaLamViec.SelectedItem).Value, txt))
            {
                dtListLamViec.Rows.Add(i.MaNhanVien, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,
                    CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).TenCa,
                    CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).GioBatDau.ToShortTimeString(),
                    CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).GioKetThuc.ToShortTimeString(), i.NgayLamViec.ToShortDateString());
            }
            dgvLichLamViec.DataSource = dtListLamViec;
        }
        public void LoadListNhanVien()
        {
            dtListNhanVien.Rows.Clear();
            foreach (NhanVienDTO i in NhanVienBLL.Instance.GetAllNhanVien())
            {
                dtListNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien);
            }
            dgvNhanVien.DataSource = dtListNhanVien;
        }
        private void dtpTimKiemLich_ValueChanged(object sender, EventArgs e)
        {
            dtListLamViec.Rows.Clear();
            foreach (LichLamViecDTO i in LichLamViecBLL.Instance.GetAllLichLamViecByNgayLamViec(dtpTimKiemLich.Value, ((CBBItem)cboTimKiemCaLamViec.SelectedItem).Value, txtTimKiemNhanVien.Text))
            {
                dtListLamViec.Rows.Add(i.MaNhanVien, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,
                    CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).TenCa,
                    CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).GioBatDau.ToShortTimeString(),
                    CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).GioKetThuc.ToShortTimeString(), i.NgayLamViec.ToShortDateString());
            }
            dgvLichLamViec.DataSource = dtListLamViec;
        }

        private void cboTimKiemCaLamViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtListLamViec.Rows.Clear();
            foreach (LichLamViecDTO i in LichLamViecBLL.Instance.GetAllLichLamViecByNgayLamViec(dtpTimKiemLich.Value, ((CBBItem)cboTimKiemCaLamViec.SelectedItem).Value, txtTimKiemNhanVien.Text))
            {
                dtListLamViec.Rows.Add(i.MaNhanVien, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,
                CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).TenCa,
                CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).GioBatDau.ToShortTimeString(),
                CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa).GioKetThuc.ToShortTimeString(), i.NgayLamViec.ToShortDateString());
            }
            dgvLichLamViec.DataSource = dtListLamViec;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadListLamViec(txtTimKiemNhanVien.Text);
        }

        private void txtTimKiemNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiemNhanVien.Text = "";
            lblNhapTen.Visible = false;
        }
        public bool checkChonRowDGV()
        {
            if (dgvLichLamViec.SelectedRows.Count <= 0)
            {
                btnXoa.Enabled = false;
                lblErrorChonXoa.Visible = false;
                return false;
            }
            else
            {
                if (dgvLichLamViec.SelectedRows.Count > 1)
                {
                    btnXoa.Enabled = false;
                    lblErrorXoa.Visible = false;
                    lblErrorChonXoa.Visible = true;
                    return false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    lblErrorXoa.Visible = true;
                    lblErrorChonXoa.Visible = false;
                    return true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkChonRowDGV() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    string maNhanVien;
                    string maCa;
                    DateTime ngayLamViec;
                    foreach (DataGridViewRow i in dgvLichLamViec.SelectedRows)
                    {
                        maNhanVien = dgvLichLamViec.Rows[i.Index].Cells["Mã Nhân Viên"].Value.ToString();
                        maCa = dgvLichLamViec.Rows[i.Index].Cells["Tên Ca Làm Việc"].Value.ToString();
                        ngayLamViec = Convert.ToDateTime(dgvLichLamViec.Rows[i.Index].Cells["Ngày Làm Việc"].Value);
                        LichLamViecBLL.Instance.XoaLichLamViec(maNhanVien, maCa, ngayLamViec);
                        MessageBox.Show("Xóa lịch làm việc thành công!");
                    }
                    LoadListLamViec();
                }
            }
        }

        private void dgvLichLamViec_MouseClick(object sender, MouseEventArgs e)
        {
            checkChonRowDGV();
        }
        private void dtpThemNgayLamViec_ValueChanged(object sender, EventArgs e)
        {
            if (dtpThemNgayLamViec.Value <= DateTime.Today)
            {
                lblValidatedNgayLamViec.Visible = true;
                cboThemCaLamViec.Enabled = false;
                btnThem.Enabled = false;
            }
            else
            {
                cboThemCaLamViec.Enabled = true;
                lblValidatedNgayLamViec.Visible = false;
                btnThem.Enabled = true;
            }
        }
        public bool checkChonRowDGVNhanVien()
        {
            if (dgvNhanVien.SelectedRows.Count <= 0)
            {

                lblThongBao.Visible = false;
                lblValidatedNhanVien.Visible = true;
                return false;
            }
            else
            {
                if (dgvNhanVien.SelectedRows.Count > 1)
                {
                    lblThongBao.Visible = false;
                    lblValidatedNhanVien.Visible = true;
                    return false;
                }
                else
                {
                    lblThongBao.Visible = true;
                    lblValidatedNhanVien.Visible = false;
                    return true;
                }
            }
        }

        private void dgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkChonRowDGVNhanVien() == true)
            {
                foreach (DataGridViewRow i in dgvNhanVien.SelectedRows)
                {
                    txtTenNhanVien.Text = dgvNhanVien.Rows[i.Index].Cells["Tên Nhân Viên"].Value.ToString();
                    txtMaNhanVien.Text = dgvNhanVien.Rows[i.Index].Cells["Mã Nhân Viên"].Value.ToString();
                }
            }
        }

        private void cboThemCaLamViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void UC_CaLam_Leave(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Thông tin chưa lưu, có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    ReLoad();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkChonRowDGVNhanVien() == true)
            {
                if (cboThemCaLamViec.SelectedIndex >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận thêm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        string KiemTra = LichLamViecBLL.Instance.KiemTraLichLamViec(txtMaNhanVien.Text, ((CBBItem)cboThemCaLamViec.SelectedItem).Value, dtpThemNgayLamViec.Value);
                        if (KiemTra == "")
                        {
                            string maNhanVien;
                            string maCa;
                            DateTime ngayLamViec;
                            maNhanVien = txtMaNhanVien.Text;
                            maCa = cboThemCaLamViec.Text;
                            ngayLamViec = dtpThemNgayLamViec.Value;
                            LichLamViecBLL.Instance.ThemLichLamViec(maNhanVien, maCa, ngayLamViec);
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListLamViec();
                        }
                        else
                        {
                            MessageBox.Show(KiemTra, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        lblValidatedCaLamViec.Visible = false;
                    }
                }
                else
                {
                    lblValidatedCaLamViec.Visible = true;
                }
            }
        }
    }
}
