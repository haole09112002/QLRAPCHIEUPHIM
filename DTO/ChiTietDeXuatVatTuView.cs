using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDeXuatVatTuView
    {
        private string maDeXuat;
        private string maVatTu;
        private string tenVatTu;
        private int soLuong;
        private string donViTinh;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaVatTu{ get => maVatTu; set => maVatTu = value; }
        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
