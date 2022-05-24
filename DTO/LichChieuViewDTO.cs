using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuViewDTO
    {
        private string tenPhim;
        private string maPhim;
        private string maPhongChieu;
        private string tenPhongChieu;
        private string maKhungGioChieu;
        private string tenKhungGio;
        private DateTime gioBatDau;
        private DateTime gioKetThuc;
        private DateTime ngayChieu;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public string TenPhongChieu { get => tenPhongChieu; set => tenPhongChieu = value; }
        public string TenKhungGio { get => tenKhungGio; set => tenKhungGio = value; }
        public string MaKhungGioChieu { get => maKhungGioChieu; set => maKhungGioChieu = value; }
        public DateTime GioBatDau { get => gioBatDau; set => gioBatDau = value; }
        public DateTime GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }
        public DateTime NgayChieu { get => ngayChieu; set => ngayChieu = value; }
    }
}
