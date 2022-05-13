using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDienVienDaoDienPhimDTO
    {
        private string maPhim;
        private string maDienVienDaoDien;
        private string vaiTro;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string MaDienVienDaoDien { get => maDienVienDaoDien; set => maDienVienDaoDien = value; }
        public string VaiTro {  get => vaiTro; set => vaiTro = value; }
    }
}
