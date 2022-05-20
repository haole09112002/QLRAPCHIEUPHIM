using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongChieuDTO
    {
        private string maLoaiPhongChieu;
        private string tenLoaiPhongChieu;

        public string MaLoaiPhongChieu { get => maLoaiPhongChieu; set => maLoaiPhongChieu = value; }
        public string TenLoaiPhongChieu { get => tenLoaiPhongChieu; set => tenLoaiPhongChieu = value; }
    }
}
