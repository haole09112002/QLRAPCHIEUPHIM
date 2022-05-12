using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DienVienDaoDienDTO
    {
        private string maDienVienDaoDien;
        private string tenDienVienDaoDien;
        private string link;

        public string MaDienVienDaoDien { get => maDienVienDaoDien; set => maDienVienDaoDien = value; }
        public string TenDienVienDaoDien { get => tenDienVienDaoDien; set => tenDienVienDaoDien = value; }
        public string Link { get => link; set => link = value; }
    }
}
