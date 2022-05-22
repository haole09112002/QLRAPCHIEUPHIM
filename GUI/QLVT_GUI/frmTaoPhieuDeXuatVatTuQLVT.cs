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
    public partial class FrmTaoPhieuDeXuatVatTuQLVT : Form
    {
        DataTable dtDeXuatVatTu = new DataTable();
        DataTable dsDexuatVatTu = new DataTable();
        public FrmTaoPhieuDeXuatVatTuQLVT()
        {
            InitializeComponent();
            SetDataTable();
            ReLoad();
        }
        public void ReLoad()
        {
            dsDexuatVatTu.Rows.Clear();
            foreach (VatTuDTO i in VatTuBLL.Instance.GetAllVatTu())
            {
                dsDexuatVatTu.Rows.Add(i.MaVatTu, i.TenVatTu);        
            }
            dgvListVatTu.DataSource = dsDexuatVatTu;
        }
        public void SetDataTable()
        {

            dtDeXuatVatTu.Columns.Add("Mã Vật Tư");
            dtDeXuatVatTu.Columns.Add("Tên Vật Tư");
            dtDeXuatVatTu.Columns.Add("Số Lượng");
            dtDeXuatVatTu.Columns.Add("Đơn Vị Tính");
            dtDeXuatVatTu.Columns.Add("Nội Dung");
            dsDexuatVatTu.Columns.Add("Mã Vật Tư");
            dsDexuatVatTu.Columns.Add("Tên Vật Tư");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvListVatTu.SelectedRows.Count <= 0)
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
                            foreach (DataGridViewRow i in dgvListVatTu.SelectedRows)
                            {
                                dtDeXuatVatTu.Rows.Add(i.Cells["Mã Vật Tư"].Value.ToString(), VatTuBLL.Instance.GetVatTuByMaVatTu(i.Cells["Mã Vật Tư"].Value.ToString()).TenVatTu, txtSoLuong.Text, cBDonViTinh.SelectedItem.ToString(), txtNoiDung.Text);
                            }
                        }
                    }
                }
            }
            dgvListDeXuatVatTu.DataSource = dtDeXuatVatTu;
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
                        dgvListDeXuatVatTu.CurrentRow.Cells["Số Lượng"].Value = txtSoLuong.Text;
                        dgvListDeXuatVatTu.CurrentRow.Cells["Nội Dung"].Value = txtNoiDung.Text;
                        dgvListDeXuatVatTu.CurrentRow.Cells["Đơn Vị Tính"].Value = cBDonViTinh.SelectedItem.ToString();
                    }
                }
            }
        }

        private void dgvListDeXuatVatTu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListDeXuatVatTu.SelectedRows.Count > 1)
            {
                MessageBox.Show("Số dòng chỉnh sửa không vượt quá 1");
            }
            else
            {
                txtSoLuong.Text = dgvListDeXuatVatTu.CurrentRow.Cells["Số Lượng"].Value.ToString();
                txtNoiDung.Text = dgvListDeXuatVatTu.CurrentRow.Cells["Nội Dung"].Value.ToString();
                cBDonViTinh.Text = dgvListDeXuatVatTu.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListDeXuatVatTu.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn dòng để xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dgvListDeXuatVatTu.SelectedRows)
                    {
                        dgvListDeXuatVatTu.Rows.RemoveAt(i.Index);
                    }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                DeXuatBLL.Instance.LuuDeXuat("NV0001", DateTime.Now, "LDX02"); // sai
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                string MaVatTu = "";
                string NoiDung = "";
                string DonViTinh = "";
                int SoLuong;
                for (int i = 0; i < dgvListDeXuatVatTu.Rows.Count - 1; i++)
                {
                    MaVatTu = dgvListDeXuatVatTu.Rows[i].Cells["Mã Vật Tư"].Value.ToString();
                    NoiDung = dgvListDeXuatVatTu.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dgvListDeXuatVatTu.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dgvListDeXuatVatTu.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatVatTuBLL.Instance.LuuChiTietDeXuatVatTu(MaDeXuat, MaVatTu, NoiDung, DonViTinh, SoLuong, "1");
                }
                this.Close();
            }
        }
    }
}
