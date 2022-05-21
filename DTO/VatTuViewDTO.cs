using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VatTuViewDTO
    {
        private string maVatTu;
        private string tenVatTu;
        private string donViTinh;
        private int soLuong;
        private double giaTien;
        private string tenKho;
        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
    }
}
