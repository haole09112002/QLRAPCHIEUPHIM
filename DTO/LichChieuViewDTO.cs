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
        private string tenPhongChieu;
        private string maPhongChieu;
        private string tenKhungGio;
        private string maKhungGioChieu;

        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhongChieu { get => tenPhongChieu; set => tenPhongChieu = value; }
        public string MaPhongChieu { get => maPhongChieu;set => maPhongChieu = value; }
        public string TenKhungGio { get => tenKhungGio; set => tenKhungGio = value;}
        public string MaKhungGioChieu { get => maKhungGioChieu; set=> maKhungGioChieu = value; }

    }
}
