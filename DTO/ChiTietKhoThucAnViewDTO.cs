using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhoThucAnViewDTO
    {
        private string maKho;
        private string maThucAn;
        private string tenKho;
        private string tenThucAn;
        private string donViTinh;
        private int soLuongSP;
        private double giaTien;
        public string MaKho { get => maKho; set => maKho = value; }
        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public string TenThucAn { get => tenThucAn; set => tenThucAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuongSP { get => soLuongSP; set => soLuongSP = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
    }
}
