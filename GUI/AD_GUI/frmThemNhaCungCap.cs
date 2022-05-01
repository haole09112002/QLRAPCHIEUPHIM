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

namespace GUI.AD_GUI
{
    public partial class frmThemNhaCungCap : Form
    {
        private string maNhaCungCap;
        public delegate void Mydel(string maNhaCungCap, string txt);
        public Mydel d { get; set; }
         
        public frmThemNhaCungCap(string maNhaCungCap = "")
        {
            InitializeComponent();
            this.maNhaCungCap = maNhaCungCap;
            cbLoaiNhaCungCap.Items.AddRange(LoaiNhaCungCapBLL.Instance.GetCBBLoaiNhaCungCap().ToArray());
            setGUI(maNhaCungCap);
        }
        public void setGUI(string maNhaCungCap)
        {
            
            if (maNhaCungCap != "")
            {
                setEnable(false);
                NhaCungCapDTO nhaCungCap = NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap);
                txtTenCongTy.Text = nhaCungCap.TenNhaCungCap;
                txtMaSoThue.Text = nhaCungCap.MaSoThue;
                txtDiaChi.Text = nhaCungCap.DiaChi;
                txtEmail.Text = nhaCungCap.Email;
                txtDienThoai.Text = nhaCungCap.SoDienThoai;
                txtTenGiamDoc.Text = nhaCungCap.TenGiamDoc;
                foreach (CBBItem i in cbLoaiNhaCungCap.Items)
                {
                    if (i.Value == nhaCungCap.MaLoaiNhaCungCap)
                        cbLoaiNhaCungCap.SelectedItem = i;
                }
                btnLuu.Enabled = false;
                
            }
            else
            {
                btnChinhSua.Visible = false;
            }

        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLoaiNhaCungCap = "";
            if (cbLoaiNhaCungCap.SelectedItem != null)
            {
                maLoaiNhaCungCap = ((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value;
            }
            NhaCungCapDTO nhaCungCap = new NhaCungCapDTO
            {
                MaNhaCungCap = maNhaCungCap,
                TenNhaCungCap = txtTenCongTy.Text,
                MaSoThue = txtMaSoThue.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                SoDienThoai = txtDienThoai.Text,
                TenGiamDoc = txtTenGiamDoc.Text,
                MaLoaiNhaCungCap = maLoaiNhaCungCap
            };
            if(NhaCungCapBLL.Instance.KiemTraDuLieu(nhaCungCap) == null)
            {
                DialogResult  result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NhaCungCapBLL.Instance.AddUpdateNhaCungCap(nhaCungCap);
                    DialogResult result2 = MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        d("0", "");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(NhaCungCapBLL.Instance.KiemTraDuLieu(nhaCungCap), "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void setEnable(bool var)
        {
            txtTenCongTy.Enabled = var;
            txtMaSoThue.Enabled = var;
            txtDiaChi.Enabled = var;
            txtEmail.Enabled = var;
            txtDienThoai.Enabled = var;
            txtTenGiamDoc.Enabled = var;
            cbLoaiNhaCungCap.Enabled = var;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            setEnable(true);
            btnLuu.Enabled = true;
        }
    }
}
