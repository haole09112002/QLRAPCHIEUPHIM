using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TongSoLuongPhimDTO
    {
        private string maPhim;
        private int tongSoLuongPhim;
        
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public int TongSoLuongPhim { get => tongSoLuongPhim; set => tongSoLuongPhim = value; }
    }
}
