using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNhanVien;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private string soDienThoai;
        private string CCCD;
        private string tenTaiKhoan;
        private string matKhau;
        private byte[] Anh;
        private string maChinhSach;
        private string maChucVu;
        private string trangThai;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public byte[] Anh1 { get => Anh; set => Anh = value; }
        public string MaChinhSach { get => maChinhSach; set => maChinhSach = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
