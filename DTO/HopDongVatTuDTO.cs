using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongVatTuDTO
    {
		private string maVatTu;
        private string maHopDong;
        private double giaTien;
		private string donViTinh;
		private int soLuong;

        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
    }
}
