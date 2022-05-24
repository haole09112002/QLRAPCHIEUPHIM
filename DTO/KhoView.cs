using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoView
    {
        private string maKho;
        private string tenLoaiKho;
        private string tenKho;
        

        public string MaKho { get => maKho; set => maKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public string TenLoaiKho { get => tenLoaiKho; set => tenLoaiKho = value; }
    }
}
