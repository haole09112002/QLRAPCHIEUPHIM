using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienViewDTO
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string ngaySinh;
        private bool gioiTinh;
        private string soDienThoai;
        private string maChinhSach;
        private string tenChucVu;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string MaChinhSach { get => maChinhSach; set => maChinhSach = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
    }
}