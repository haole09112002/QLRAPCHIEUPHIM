using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhieuDTO
    {
        private string maLoaiPhieu;
        private string tenLoaiPhieu;

        public string MaLoaiPhieu { get => maLoaiPhieu; set => maLoaiPhieu = value; }
        public string TenLoaiPhieu { get => tenLoaiPhieu; set => tenLoaiPhieu = value; }
    }
}
