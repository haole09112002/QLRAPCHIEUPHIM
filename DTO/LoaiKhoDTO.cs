using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhoDTO
    {
        private string maLoaiKho;
        private string tenLoaiKho;

        public string MaLoaiKho { get => maLoaiKho; set => maLoaiKho = value; }
        public string TenLoaiKho { get => tenLoaiKho; set => tenLoaiKho = value; }
    }
}
