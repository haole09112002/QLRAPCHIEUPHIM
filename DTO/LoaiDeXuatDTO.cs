using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDeXuatDTO
    {
        private string maLoaiDeXuat;
        private string tenLoaiDeXuat;

        public string MaLoaiDeXuat { get => maLoaiDeXuat; set => maLoaiDeXuat = value; }
        public string TenLoaiDeXuat { get => tenLoaiDeXuat; set => tenLoaiDeXuat = value; }
    }
}
