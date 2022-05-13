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

namespace GUI.QLP_GUI
{
    public partial class frm_ThongTinNCC_QLP : Form
    {
        public string MaNhaCungCap;
        public frm_ThongTinNCC_QLP(string MaNCC)
        {
            MaNhaCungCap = MaNCC;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if(MaNhaCungCap != "")
            {
                NhaCungCapDTO NhaCC = NhaCungCapBLL.Instance.GetNCCByMaNCC(MaNhaCungCap);
                txtMaNCC.Enabled = false;
                txtMaNCC.Text = MaNhaCungCap;
                txtNCC.Enabled = false;
                txtNCC.Text = NhaCC.TenNhaCungCap;
                txtMaSoThue.Enabled = false;
                txtMaSoThue.Text = NhaCC.MaSoThue;
                txtDiaChi.Enabled = false;
                txtDiaChi.Text = NhaCC.DiaChi;
                txtEmail.Enabled = false;
                txtEmail.Text = NhaCC.Email;
                txtSDT.Enabled = false;
                txtSDT.Text = NhaCC.SoDienThoai;
                txtTenGiamDoc.Enabled = false;
                txtTenGiamDoc.Text = NhaCC.TenGiamDoc;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
