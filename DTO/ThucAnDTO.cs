using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucAnDTO
    {
        private string maThucAn;
        private string tenThucAn;
        private string donViTinh;
        private int soLuong;

        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public string TenThucAn { get => tenThucAn; set => tenThucAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
