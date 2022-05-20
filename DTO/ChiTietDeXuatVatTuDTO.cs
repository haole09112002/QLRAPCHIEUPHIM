using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDeXuatVatTuDTO
    {
        private string maDeXuat;
        private string maVatTu;
        private string noiDung;
        private int soLuong;
        private string donViTinh;
        private bool tinhTrang;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
