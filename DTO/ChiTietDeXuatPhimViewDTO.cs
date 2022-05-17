using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDeXuatPhimViewDTO
    {
        private string maDeXuat;
        private string maPhim;
        private string tenPhim;
        private int soLuong;
        private string donViTinh;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        
    }
}
