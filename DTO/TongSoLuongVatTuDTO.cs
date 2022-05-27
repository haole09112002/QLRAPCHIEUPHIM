using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TongSoLuongVatTuDTO
    {
        private string maVatTu;
        private int tongSoLuongVatTu;

        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public int TongSoLuongVatTu { get => tongSoLuongVatTu; set => tongSoLuongVatTu = value; }
    }
}
