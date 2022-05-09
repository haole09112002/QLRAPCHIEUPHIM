using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeXuatPhimDTO
    {
        private string maDeXuat;
        private string maPhim;
        private string noidung;
        private bool tinhTrang;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
