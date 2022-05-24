using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDeXuatThucAnDTO
    {
        private string maDeXuat;
        private string maThucAn;
        private string noiDung;
        private int soLuong;
        private string donViTinh;
        private string tinhTrang;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
