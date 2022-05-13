using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhoPhimDTO
    {
        private string maKho;
        private string maPhim;
        private string donViTinh;
        private int soLuongSP;

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuongSP { get => soLuongSP; set => soLuongSP = value; }
    }
}
