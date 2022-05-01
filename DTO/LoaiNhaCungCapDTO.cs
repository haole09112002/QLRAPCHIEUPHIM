using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNhaCungCapDTO
    {
        private string maLoaiNhaCungCap;
        private string tenLoaiNhaCungCap;
        public string MaLoaiNhaCungCap { get => maLoaiNhaCungCap; set => maLoaiNhaCungCap = value; }
        public string TenLoaiNhaCungCap { get => tenLoaiNhaCungCap; set => tenLoaiNhaCungCap = value; }
    }
}
