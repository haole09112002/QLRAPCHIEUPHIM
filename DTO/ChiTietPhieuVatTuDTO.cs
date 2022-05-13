using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuVatTuDTO
    {
        private string maPhieu;
        private string maVatTu;
        private string donViTinh;
        private int soLuong;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
