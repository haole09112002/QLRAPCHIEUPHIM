using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using System.Windows.Forms;

namespace GUI.AD_GUI
{
    public partial class UC_ThongKeChung : UserControl
    {
        public UC_ThongKeChung()
        {
            InitializeComponent();
            setGUI();
        }
        private void setGUI()
        {
            
            cbLoaiHopDong.Items.Add(new CBBItem { Text = "Tất cả", Value = "0" });
            cbLoaiHopDong.Items.AddRange(LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().ToArray());

            lbTongNhaCungCap.Text = ThongKeBLL.Instance.SoLuongNhaCungCap().ToString();
            lbSoLuongNhaCungCapPhim.Text = ThongKeBLL.Instance.SoLuongNhaCungCap("LNCC01").ToString();
            lbSoLuongNhaCungCapVT.Text = ThongKeBLL.Instance.SoLuongNhaCungCap("LNCC02").ToString();
            lbSoLuongNhaCungCapTA.Text = ThongKeBLL.Instance.SoLuongNhaCungCap("LNCC03").ToString();
            lbSoLuongPhimTrongKho.Text = ThongKeBLL.Instance.SoLuongPhimTrongKho().ToString();
            lbTongSoPhongChieu.Text = ThongKeBLL.Instance.SoLuongPhongChieu().ToString();
            lbSoLuongPhongChieuHong.Text = ThongKeBLL.Instance.SoLuongPhongChieu(2).ToString();
            lbSoLuongPhongChieuBaotri.Text = ThongKeBLL.Instance.SoLuongPhongChieu(3).ToString();
            lbSoLuongPhongChieuTinhTrangTot.Text = ThongKeBLL.Instance.SoLuongPhongChieu(1).ToString();
            lbSoLuongNhanVien.Text = ThongKeBLL.Instance.SoLuongNhanVien().ToString();
            lbSLNVPhim.Text = ThongKeBLL.Instance.SoLuongNhanVien("CV0001").ToString();
            lbSLNVVatTu.Text = ThongKeBLL.Instance.SoLuongNhanVien("CV0002").ToString();
            lbSoLuongNVQL.Text = ThongKeBLL.Instance.SoLuongNhanVien("CV0003").ToString();
            lbSoLuongPhimTrongKho.Text = ThongKeBLL.Instance.SoLuongPhimTrongKho().ToString();
        }
        private void LoadGDVThongKeHopDong(object item)
        {
            dgvThongKeHopDong.DataSource = item;
            dgvThongKeHopDong.Columns["MaHopDong"].HeaderText = "Mã hợp đồng";
            dgvThongKeHopDong.Columns["TenHopDong"].HeaderText = "Tên hợp đồng";
            dgvThongKeHopDong.Columns["TongTien"].HeaderText = "Tiền thanh toán(VND)";
            dgvThongKeHopDong.Columns["LoaiHopDong"].HeaderText = "Loại hợp đồng";
        }
        private void cbLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(cbLoaiHopDong.SelectedIndex != -1)
            {
                if (dtpNgayBD.Value <= dtpNgayKT.Value)
                {
                    var result = ThongKeBLL.Instance.ThongKeTienNhapPhim(((CBBItem)cbLoaiHopDong.SelectedItem).Value, dtpNgayBD.Value, dtpNgayKT.Value);
                    double tongTien = 0;
                    LoadGDVThongKeHopDong(result);
                    lbSoLuongHD.Text = result.Count().ToString();
                    result.ForEach(i => tongTien += i.TongTien);
                    lbTongTienThanhToanHD.Text = tongTien.ToString();
                    lbDocTienThanhChu.Text = Helper.Instance.NumberToTextVN((decimal)tongTien);
                }
                else
                {
                    MessageBox.Show("Ngày chưa hợp lệ! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại hợp đồng cần thống kê!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
