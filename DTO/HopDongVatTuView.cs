using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongVatTuView
    {
        private string maVatTu;
        private string tenThucAn;
        private string donViTinh;
        private int soLuong;
        private double giaTien;

        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string TenVatTu { get => tenThucAn; set => tenThucAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
    }
}
