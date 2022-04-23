using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.AD_Form;
namespace GUI.AD_Form
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
      //  UC_NCCPhim_AD ucNCC = new UC_NCCPhim_AD();


       // UC_MenuPhim_AD ucMenuPhim = new UC_MenuPhim_AD();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucThongKe);
        
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AddControlsToPnCenter(ucLichChieu);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
       //     AddControlsToPnMenu(ucMenuPhim);
            AddControlsToPnCenter(ucNCC);
         //   ucMenuPhim.d = new UC_MenuPhim_AD.Mydel(AddControlsToPnCenter);
            
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
        }
    }
}
