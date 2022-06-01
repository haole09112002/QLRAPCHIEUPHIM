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
        private string gioiTinh;
        private string soDienThoai;
        private string maChinhSach;
        private string tenChinhSach;
        private string maChucVu;
        private string tenChucVu;
        private string trangThai;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string TenChinhSach { get => tenChinhSach; set => tenChinhSach = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string MaChinhSach { get => maChinhSach; set => maChinhSach = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}