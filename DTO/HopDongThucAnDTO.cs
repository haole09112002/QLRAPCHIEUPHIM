using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongThucAnDTO
    {
        private string maHopDong;
        private string maThucAn;
        private double giaTien;
        private string donViTinh;
        private int soLuong;

       
        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
    }
}
