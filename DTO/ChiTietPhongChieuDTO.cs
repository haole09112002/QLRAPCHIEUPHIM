using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhongChieuDTO
    {
        private string maPhongChieu;
        private string maVatTu;
        private string donViTinh;
        private int soLuongSP;

        public string MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuongSP { get => soLuongSP; set => soLuongSP = value; }
    }
}
