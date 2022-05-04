using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietCungCapVatTuDTO
    {
		private string maVatTu;
		private string maNhaCungCap;
		private double giaTien;
		private string donViTinh;
		private int soLuong;

        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
