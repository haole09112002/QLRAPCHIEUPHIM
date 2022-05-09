using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongPhimViewDTO
    {
        private string maPhim;
        private string tenPhim;
        private DateTime ngayBatDauBanQuyen;
        private DateTime ngayKetThucBanQuyen;
        private string donViTinh;
        private int soLuong;
        private double giaTien;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public DateTime NgayBatDauBanQuyen { get => ngayBatDauBanQuyen; set => ngayBatDauBanQuyen = value; }
        public DateTime NgayKetThucBanQuyen { get => ngayKetThucBanQuyen; set => ngayKetThucBanQuyen = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
    }
}
