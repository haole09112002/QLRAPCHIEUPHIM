using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDeXuatPhimDTO
    {
        private string maDeXuat;
        private string maPhim;
        private bool tinhTrang;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
