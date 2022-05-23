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
    public partial class frm_TaoDeXuat_QLP : Form
    {
        DataTable dtDeXuatPhim = new DataTable();
        public frm_TaoDeXuat_QLP()
        {
            InitializeComponent();
            ReLoad();
            SetDataTable();
        }
        public void ReLoad()
        {
            dGVDanhSachPhim.DataSource = PhimBLL.Instance.GetPhimViews();
        }

        public void SetDataTable()
        {
            dtDeXuatPhim.Columns.Add("Mã Phim");
            dtDeXuatPhim.Columns.Add("Tên Phim");
            dtDeXuatPhim.Columns.Add("Số Lượng");
            dtDeXuatPhim.Columns.Add("Đơn Vị Tính");
            dtDeXuatPhim.Columns.Add("Nội Dung");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachPhim.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn phim");
            }
            else
            {
                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Mời nhập số lượng");
                }
                else
                {
                    if (txtNoiDung.Text == "")
                    {
                        MessageBox.Show("Mời nhập nội dung đề xuất");
                    }
                    else
                    {
                        if (cBDonViTinh.SelectedIndex < 0)
                        {
                            MessageBox.Show("Mời chọn đơn vị tính");
                        }
                        else
                        {
                            foreach (DataGridViewRow i in dGVDanhSachPhim.SelectedRows)
                            {
                                dtDeXuatPhim.Rows.Add(i.Cells["MaPhim"].Value.ToString(), PhimBLL.Instance.GetPhimByMaPhim(i.Cells["MaPhim"].Value.ToString()).TenPhim, txtSoLuong.Text, cBDonViTinh.SelectedItem.ToString(), txtNoiDung.Text);
                            }
                            dGVDeXuatPhim.DataSource = dtDeXuatPhim;
                        }
                    }
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Mời nhập số lượng");
            }
            else
            {
                if (txtNoiDung.Text == "")
                {
                    MessageBox.Show("Mời nhập nội dung đề xuất");
                }
                else
                {
                    if (cBDonViTinh.SelectedIndex < 0)
                    {
                        MessageBox.Show("Mời chọn đơn vị tính");
                    }
                    else
                    {
                        dGVDeXuatPhim.CurrentRow.Cells["Số Lượng"].Value = txtSoLuong.Text;
                        dGVDeXuatPhim.CurrentRow.Cells["Nội Dung"].Value = txtNoiDung.Text;
                        dGVDeXuatPhim.CurrentRow.Cells["Đơn Vị Tính"].Value = cBDonViTinh.SelectedItem.ToString();
                    }
                }
            }
        }

        private void dGVDeXuatPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDeXuatPhim.SelectedRows.Count > 1)
            {
                MessageBox.Show("Số dòng chỉnh sửa không vượt quá 1");
            }
            else
            {
                txtSoLuong.Text = dGVDeXuatPhim.CurrentRow.Cells["Số Lượng"].Value.ToString();
                txtNoiDung.Text = dGVDeXuatPhim.CurrentRow.Cells["Nội Dung"].Value.ToString();
                cBDonViTinh.Text = dGVDeXuatPhim.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
            }
        }
            
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dGVDeXuatPhim.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn dòng để xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dGVDeXuatPhim.SelectedRows)
            {
                        dGVDeXuatPhim.Rows.RemoveAt(i.Index);
                    }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.OK)
            {
                DeXuatBLL.Instance.LuuDeXuat("NV0003", DateTime.Now, "LDX01");
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                string MaPhim = "";
                string NoiDung = "";
                string DonViTinh = "";
                int SoLuong;
                for(int i = 0; i <dGVDeXuatPhim.Rows.Count - 1; i++)
        {
                    MaPhim = dGVDeXuatPhim.Rows[i].Cells["Mã Phim"].Value.ToString();
                    NoiDung = dGVDeXuatPhim.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dGVDeXuatPhim.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dGVDeXuatPhim.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatPhimBLL.Instance.LuuChiTietDeXuatPhim(MaDeXuat, MaPhim, NoiDung, DonViTinh, SoLuong, "1");
                }
                this.Close();
            }
        }
    }
}
