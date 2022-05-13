using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoDTO
    {
        private string maKho;
        private string maLoaiKho;
        private string tenKho;

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaLoaiKho { get => maLoaiKho; set => maLoaiKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
    }
}
