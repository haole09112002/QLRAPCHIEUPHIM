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

namespace GUI.QLP_GUI
{
    public partial class frm_ThemDienVienDaoDien_QLP : Form
    {
        DataTable dt = new DataTable();
        public frm_ThemDienVienDaoDien_QLP()
        {
            InitializeComponent();
            ReLoad();
            dt.Columns.Add("MaDienVienDaoDien");
            dt.Columns.Add("TenDienVienDaoDien");
        }
        public void ReLoad()
        {
            dGVDanhSachDienVienDaoDien.DataSource = DienVienDaoDienBLL.Instance.GetAllDienVienDaoDien();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frm_ThemMoiDienVienDaoDien_QLP frmThemMoi = new frm_ThemMoiDienVienDaoDien_QLP();
            frmThemMoi.ShowDialog();
            ReLoad();
        }
        public bool KiemTraTonTai(string MaDienVienDaoDien)
        {
            for(int i = 0; i < dGVDienVienDaoDienCuaPhim.Rows.Count - 1; i++)
            {
                if (dGVDienVienDaoDienCuaPhim.Rows[i].Cells["MaDienVienDaoDien"].Value.ToString() == MaDienVienDaoDien)
                {
                    MessageBox.Show("Diễn viên(Đạo Diễn) "+DienVienDaoDienBLL.Instance.GetTenDVDDByMaDVDD(MaDienVienDaoDien)+" đã có","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return true;
                } 
            }
            return false;
        }
        private void dGVDanhSachDienVienDaoDien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGVDanhSachDienVienDaoDien.SelectedRows.Count > 0)
            {
                List<string> sel = new List<string>();
                foreach(DataGridViewRow i in dGVDanhSachDienVienDaoDien.SelectedRows)
                {
                    sel.Add(i.Cells["MaDienVienDaoDien"].Value.ToString());
                }
                DialogResult dlr = MessageBox.Show("Xác nhận thêm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dlr == DialogResult.OK)
                {
                    foreach(string i in sel)
                    {
                        if(KiemTraTonTai(i) == false)
                            dt.Rows.Add(i.ToString(),DienVienDaoDienBLL.Instance.GetTenDVDDByMaDVDD(i));
                    }
                    dGVDienVienDaoDienCuaPhim.DataSource = dt;
                }
            }
        }
    }
}
