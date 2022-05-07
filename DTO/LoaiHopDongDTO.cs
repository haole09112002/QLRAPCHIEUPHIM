using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHopDongDTO
    {
        private string maLoaiHopDong;
        private string tenLoaiHopDong;

        public string MaLoaiHopDong { get => maLoaiHopDong; set => maLoaiHopDong = value; }
        public string TenLoaiHopDong { get => tenLoaiHopDong; set => tenLoaiHopDong = value; }
    }
}
