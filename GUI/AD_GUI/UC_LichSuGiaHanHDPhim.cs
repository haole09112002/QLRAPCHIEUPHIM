using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_LichSuGiaHanHDPhim : UserControl
    {
        public UC_LichSuGiaHanHDPhim()
        {
            InitializeComponent();
        }
        public void LoadData(DataTable dt )
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["NgayBatDauBanQuyen"].HeaderText = "Ngày bắt đầu bản quyền";
            dataGridView1.Columns["NgayKetThucBanQuyen"].HeaderText = "Ngày kết thúc bản quyền";
           // dataGridView1.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["GiaTien"].HeaderText = "Giá tiền";
        }
    }
}
