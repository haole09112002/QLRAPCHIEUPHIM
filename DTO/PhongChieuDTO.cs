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
        private int maTinhTrang;
        private string maLoaiPhongChieu;

        public string MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int MaTinhTrang { get => maTinhTrang; set => maTinhTrang = value; }
        public string MaLoaiPhongChieu { get => maLoaiPhongChieu; set => maLoaiPhongChieu = value; }
    }
}
