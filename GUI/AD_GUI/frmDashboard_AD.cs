using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.AD_GUI;
namespace GUI.AD_GUI
{
    public partial class frmDashboard_AD : Form
    {
        public frmDashboard_AD()
        {
            InitializeComponent();
        }
        UC_ThongKe ucThongKe = new UC_ThongKe();
        UC_LichChieu_AD ucLichChieu = new UC_LichChieu_AD();
     
        UC_NCC_AD ucNCC = new UC_NCC_AD();
        UC_MenuNhanVien ucMenuNhanVien = new UC_MenuNhanVien();
        UC_MenuKho ucMenuKho = new UC_MenuKho();
        UC_HopDong ucHopDong = new UC_HopDong();
        UC_DeXuat ucDeXuat = new UC_DeXuat();
        UC_CaNhan ucCaNhan = new UC_CaNhan();   
        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> {btnCaNhan, btnDangXuat, btnHopDong, btnDeXuat, btnKho, btnLichChieu,
            btnNCC, btnThongKe, btnNV  };
            foreach (Button i in buttons)
            {
               
                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn) // xanh
                {
                    i.BackColor = Color.FromArgb(40, 51, 66); // den
                }
            }
   
            


        }
     
        private void btnThongKe_Click(object sender, EventArgs e)
        {

            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucThongKe);
            changeColorButton(btnThongKe );
        
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucLichChieu);
            changeColorButton(btnLichChieu);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucNCC);
            changeColorButton(btnNCC);
        }
        private void AddControlsToPnCenter(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);
        }
        private void AddControlsToPnMenu(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnMenu.Controls.Clear();
            pnMenu.Controls.Add(c);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnMenu(ucMenuKho);
            AddControlsToPnCenter(ucMenuKho.ucThongTinKho);
            ucMenuKho.d = new UC_MenuKho.Mydel(AddControlsToPnCenter);
            changeColorButton(btnKho);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnMenu(ucMenuNhanVien);
           
            AddControlsToPnCenter(ucMenuNhanVien.ucThongTinNV);
            ucMenuNhanVien.d = new UC_MenuNhanVien.Mydel(AddControlsToPnCenter);
            changeColorButton(btnNV);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucHopDong);
            changeColorButton(btnHopDong);
        }

        private void btnDeXuat_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucDeXuat);
            changeColorButton(btnDeXuat);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucCaNhan);
            changeColorButton(btnCaNhan);
        }
    }
}
