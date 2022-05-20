using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhoThucAnDTO
    {
        private string maKho;
        private string maThucAn;
        private string donViTinh;
        private int soLuongSP;

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuongSP { get => soLuongSP; set => soLuongSP = value; }
    }
}
