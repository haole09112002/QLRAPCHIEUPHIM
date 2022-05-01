using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiPhimDTO
    {
        private string maTheLoaiPhim;
        private string tenTheLoaiPhim;

        public string MaTheLoaiPhim { get => maTheLoaiPhim; set => maTheLoaiPhim = value; }
        public string TenTheLoaiPhim { get => tenTheLoaiPhim; set => tenTheLoaiPhim = value; }
    }
}
