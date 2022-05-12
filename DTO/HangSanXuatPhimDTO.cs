using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangSanXuatPhimDTO
    {
        private string maHangSanXuatPhim;
        private string tenHangSanXuatPhim;
        private string link;

        public string MaHangSanXuatPhim { get => maHangSanXuatPhim; set => maHangSanXuatPhim = value; }
        public string TenHangSanXuatPhim { get => tenHangSanXuatPhim; set => tenHangSanXuatPhim = value; }
        public string Link { get => link; set => link = value; }
    }
}
