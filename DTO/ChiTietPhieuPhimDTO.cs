using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuPhimDTO
    {
        private string maPhieu;
        private string maPhim;
        private string donViTinh;
        private int soLuong;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
