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
        UC_Kho_AD ucKho = new UC_Kho_AD();
        UC_NCC_AD ucNCC = new UC_NCC_AD();
        //UC_PhieuNhapXuatKho ucPhieuNXKHo = new UC_PhieuNhapXuatKho();
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
       //     AddControlsToPnMenu(ucMenuPhim);
            AddControlsToPnCenter(ucNCC);
         //   ucMenuPhim.d = new UC_MenuPhim_AD.Mydel(AddControlsToPnCenter);
            changeColorButton(btnNCC);
        }
        void AddControlsToPnCenter(Control c)
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
            AddControlsToPnCenter(ucKho);
            changeColorButton(btnKho);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucKho);
            changeColorButton(btnNV);
        }
    }
}
