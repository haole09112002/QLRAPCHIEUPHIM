using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TongSoLuongThucAnDTO
    {
        private string maThucAn;
        private int tongSoLuongThucAn;

        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public int TongSoLuongThucAn { get => tongSoLuongThucAn; set => tongSoLuongThucAn = value; }
    }
}
