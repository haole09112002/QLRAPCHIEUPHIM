using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieuDTO
    {
        private string maPhongChieu;
        private string tenPhong;
        private bool tinhTrangPhong;

        public string MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public bool TinhTrangPhong { get => tinhTrangPhong; set => tinhTrangPhong = value; }
    }
}
