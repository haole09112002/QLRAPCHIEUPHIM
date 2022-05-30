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
    public partial class FrmChiTietNhaCungCap : Form
    {
        private string maNhaCungCap;
        public FrmChiTietNhaCungCap(string maNhaCungCap = "")
        {
            InitializeComponent();
            this.maNhaCungCap = maNhaCungCap;
            setGUI(maNhaCungCap);
        }
        public void setGUI(string maNhaCungCap)
        {

            if (maNhaCungCap != "")
            {
                setEnable(false);
                NhaCungCapDTO nhaCungCap = NhaCungCapBLL.Instance.GetNCCByMaNCC(maNhaCungCap);
                txtMaNCC.Text = nhaCungCap.MaNhaCungCap;
                txtTenCongTy.Text = nhaCungCap.TenNhaCungCap;
                txtMaSoThue.Text = nhaCungCap.MaSoThue;
                txtDiaChi.Text = nhaCungCap.DiaChi;
                txtEmail.Text = nhaCungCap.Email;
                txtDienThoai.Text = nhaCungCap.SoDienThoai;
                txtTenGiamDoc.Text = nhaCungCap.TenGiamDoc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setEnable(bool var)
        {
            txtMaNCC.Enabled = var;
            txtTenCongTy.Enabled = var;
            txtMaSoThue.Enabled = var;
            txtDiaChi.Enabled = var;
            txtEmail.Enabled = var;
            txtDienThoai.Enabled = var;
            txtTenGiamDoc.Enabled = var;
        }
    }
}
