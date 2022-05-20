using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieuView
    {
        private string maPhongChieu;
        private string tenPhong;
        private string tenTinhTrang;
        private string tenLoaiPhongChieu;

        public string MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string TenTinhTrang { get => tenTinhTrang; set => tenTinhTrang = value; }
        public string TenLoaiPhongChieu { get => tenLoaiPhongChieu; set => tenLoaiPhongChieu = value; }
    }
}
