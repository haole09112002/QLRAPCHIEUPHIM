using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.QLVT_GUI
{
    public partial class FrmTaoPhieuDeXuatThucAnQLVT : Form
    {
        DataTable dtDeXuatThucAn = new DataTable();
        DataTable dsDexuatThucAn = new DataTable();
        public FrmTaoPhieuDeXuatThucAnQLVT()
        {
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void ReLoad()
        {
            dsDexuatThucAn.Rows.Clear();
            foreach (ThucAnDTO i in ThucAnBLL.Instance.GetAllThucAn())
            {
                dsDexuatThucAn.Rows.Add(i.MaThucAn, i.TenThucAn);
            }
            dgvListThucAn.DataSource = dsDexuatThucAn;
        }
        public void SetDataTable()
        {

            dtDeXuatThucAn.Columns.Add("Mã Thức Ăn");
            dtDeXuatThucAn.Columns.Add("Tên Thức Ăn");
            dtDeXuatThucAn.Columns.Add("Số Lượng");
            dtDeXuatThucAn.Columns.Add("Đơn Vị Tính");
            dtDeXuatThucAn.Columns.Add("Nội Dung");
            dsDexuatThucAn.Columns.Add("Mã Thức Ăn");
            dsDexuatThucAn.Columns.Add("Tên Thức Ăn");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        dgvListDeXuatThucAn.CurrentRow.Cells["Số Lượng"].Value = txtSoLuong.Text;
                        dgvListDeXuatThucAn.CurrentRow.Cells["Nội Dung"].Value = txtNoiDung.Text;
                        dgvListDeXuatThucAn.CurrentRow.Cells["Đơn Vị Tính"].Value = cBDonViTinh.SelectedItem.ToString();
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvListThucAn.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn vật tư");
            }
            else
            {
                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Mời nhập vật tư");
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
                            foreach (DataGridViewRow i in dgvListThucAn.SelectedRows)
                            {
                                dtDeXuatThucAn.Rows.Add(i.Cells["Mã Thức Ăn"].Value.ToString(), ThucAnBLL.Instance.GetThucAnByMaThucAn(i.Cells["Mã Thức Ăn"].Value.ToString()).TenThucAn, txtSoLuong.Text, cBDonViTinh.SelectedItem.ToString(), txtNoiDung.Text);
                            }
                        }
                    }
                }
            }
            dgvListDeXuatThucAn.DataSource = dtDeXuatThucAn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListDeXuatThucAn.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn dòng để xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dgvListDeXuatThucAn.SelectedRows)
                    {
                        dgvListDeXuatThucAn.Rows.RemoveAt(i.Index);
                    }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                DeXuatBLL.Instance.LuuDeXuat("NV0001", DateTime.Now, "LDX03"); // sai
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                string MaThucAn = "";
                string NoiDung = "";
                string DonViTinh = "";
                int SoLuong;
                for (int i = 0; i < dgvListDeXuatThucAn.Rows.Count - 1; i++)
                {
                    MaThucAn = dgvListDeXuatThucAn.Rows[i].Cells["Mã Thức Ăn"].Value.ToString();
                    NoiDung = dgvListDeXuatThucAn.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dgvListDeXuatThucAn.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dgvListDeXuatThucAn.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatThucAnBLL.Instance.LuuChiTietDeXuatThucAn(MaDeXuat, MaThucAn, NoiDung, DonViTinh, SoLuong, "1");
                }
                this.Close();
            }
        }

        private void dgvListDeXuatThucAn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListDeXuatThucAn.SelectedRows.Count > 1)
            {
                MessageBox.Show("Số dòng chỉnh sửa không vượt quá 1");
            }
            else
            {
                txtSoLuong.Text = dgvListDeXuatThucAn.CurrentRow.Cells["Số Lượng"].Value.ToString();
                txtNoiDung.Text = dgvListDeXuatThucAn.CurrentRow.Cells["Nội Dung"].Value.ToString();
                cBDonViTinh.Text = dgvListDeXuatThucAn.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
            }
        }
    }
}
