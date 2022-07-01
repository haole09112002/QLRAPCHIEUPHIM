using System;
using BLL;
using DTO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI.AD_GUI
{
    public partial class frmThemNhaCungCap : Form
    {
        private string maNhaCungCap;
        public delegate void Mydel(string maNhaCungCap, string txt, string tieuChi);
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
                setReadOnly(true);
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
                cbLoaiNhaCungCap.Enabled = true;
            }
            //lbLoaiNCC.Visible = false;
            //lbERRTenNCC.Visible = false;
            //lbErrEmail.Visible = false;
            //lbErrSDT.Visible = false;
            //lbMaSoThue.Visible = false;
            //lbErrNguoiDaiDien.Visible = false;
            //lbErrDiaChi.Visible = false;    

        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                if(txtEmail.Text == "" && txtDienThoai.Text == "" && txtTenCongTy.Text ==""
                    && txtTenGiamDoc.Text == "" && txtDiaChi.Text == "" && txtMaSoThue.Text == "" && cbLoaiNhaCungCap.SelectedIndex == -1)
                {
                    this.Close();
                }  
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát!, Dữ liệu chưa được lưu lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        this.Close();
                }    
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLoaiNhaCungCap = "";
            if (cbLoaiNhaCungCap.SelectedItem != null)
            {
                maLoaiNhaCungCap = ((CBBItem)cbLoaiNhaCungCap.SelectedItem).Value;
            }
            
            if(CheckSave() == true)
            {
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
                DialogResult  result = MessageBox.Show("Bạn muốn lưu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NhaCungCapBLL.Instance.AddUpdateNhaCungCap(nhaCungCap);
                    DialogResult result2 = MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        d("0", "", "");
                        this.Close();
                    }
                }
            }
            else
            {
                
            }

        }
        public void setReadOnly(bool var)
        {
            txtTenCongTy.ReadOnly = var;
            txtMaSoThue.ReadOnly = var;
            txtDiaChi.ReadOnly = var;
            txtEmail.ReadOnly = var;
            txtDienThoai.ReadOnly = var;
            txtTenGiamDoc.ReadOnly = var;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            setReadOnly(false);
            btnLuu.Enabled = true;
        }
   
        private bool CheckSave()
        {
            bool check = true;
            if (txtDiaChi.Text == "" )
            {
                lbErrDiaChi.Text = "*Địa chỉ không được trống!";
                check = false;
            }    
            else
            {
                if (Regex.IsMatch(txtDiaChi.Text, @"^(\p{L}+\s?)*$") != true)
                {
                    lbErrDiaChi.Text = "Định dạng địa chỉ chưa hợp lệ! Vui lòng kiểm tra lại!";
                    check = false;
                }
            }

            if(txtDienThoai.Text == "")
            {
                lbErrSDT.Text = "*Số điện thoại không được trống!";
                check = false;
            }
            else
            {
                if (Regex.IsMatch(txtDienThoai.Text, @"(84|0[3|5|7|8|9])+([0-9]{8})\b") != true)
                {
                    lbErrSDT.Text = "Định dạng số điện thoại chưa hợp lệ! Vui lòng kiểm tra lại!";
                    check = false;
                }
                else
                {
                    if(!NhaCungCapBLL.Instance.KiemTraSDT(maNhaCungCap,txtDienThoai.Text))
                    {
                        lbErrSDT.Text = "Số điện thoại đã tồn tại!";
                        check=false;
                    }    
                }    
            }
            if (txtMaSoThue.Text == "")
            {
                lbMaSoThue.Text = "*Mã số thuế không được trống!";
                check = false;
            }
            else
            {
                if (Regex.IsMatch(txtMaSoThue.Text, @"([0-9]{10})\b") != true)
                {
                    lbMaSoThue.Text = "Định dạng mã số thuế chưa hợp lệ! Vui lòng kiểm tra lại!";
                    check = false;
                }
                else
                {
                    if (!NhaCungCapBLL.Instance.KiemTraMaSoThue(maNhaCungCap, txtMaSoThue.Text))
                    {
                        lbMaSoThue.Text = "Mã số thuế đã tồn tại!";
                        check = false;
                    }
                }    
            }

            if (txtEmail.Text == "")
            {
                lbErrEmail.Text = "*Email không được trống";
                check = false;
            }    
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") != true)
                {
                    lbErrEmail.Text = "Định dạng Email chưa hợp lệ! Vui lòng kiểm tra lại!";
                    check = false;
                }
                else
                {
                    if (!NhaCungCapBLL.Instance.KiemTraEmail(maNhaCungCap, txtEmail.Text))
                    {
                        lbErrEmail.Text = "Email đã tồn tại!";
                        check = false;
                    }
                }    
            }   
            if (txtTenGiamDoc.Text == "")
            {
                lbErrNguoiDaiDien.Text = "*Tên người đại diện không được trống!";
                check = false;

            }    
            else
            {
                if (Regex.IsMatch(txtTenGiamDoc.Text, @"^(\p{L}+\s?)*$") != true)
                {
                    lbErrNguoiDaiDien.Text = "Định dạng tên người đại diện chưa hợp lệ! Vui lòng kiểm tra lại!";
                    check = false;
                }
            }
            if (txtTenCongTy.Text == "")
            {
                lbERRTenNCC.Text = "*Tên nhà cung cấp không được trống!";
                check = false;
            } 
            else
            {
                if (Regex.IsMatch(txtTenCongTy.Text, @"^(\p{L}+\s?)*$") != true)
                   
                {
                    lbERRTenNCC.Text = "Định dạng tên chưa hợp lệ! Vui lòng kiểm tra lại!";
                    check = false;
                }
            }
            if(cbLoaiNhaCungCap.SelectedIndex == -1)
            {
                lbLoaiNCC.Text = "*Loại nhà cung cấp không được để trống!";
                check=false;
            }  
            return check;
        }

        private void txtTenCongTy_TextChanged(object sender, EventArgs e)
        {
            lbERRTenNCC.Text = "";
        }

       
        private void txtMaSoThue_TextChanged(object sender, EventArgs e)
        {
            lbMaSoThue.Text = "";
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            lbErrDiaChi.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbErrEmail.Text = "";
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            lbErrSDT.Text = "";
        }

        private void txtTenGiamDoc_TextChanged(object sender, EventArgs e)
        {
            lbErrNguoiDaiDien.Text = "";
        }

        private void cbLoaiNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLoaiNCC.Text = "";
        }
    }
}
