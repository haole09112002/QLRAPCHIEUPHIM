using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhungGioChieuDTO
    {
        private string maKhungGioChieu;
        private string tenKhungGio;
        private DateTime tGBatDau;
        private DateTime tGKetThuc;

        public string MaKhungGioChieu { get => maKhungGioChieu; set => maKhungGioChieu = value; }
        public string TenKhungGio { get => tenKhungGio; set => tenKhungGio = value; }
        public DateTime TGBatDau { get => tGBatDau; set => tGBatDau = value; }
        public DateTime TGKetThuc { get => tGKetThuc; set => tGKetThuc = value; }
    }
}
