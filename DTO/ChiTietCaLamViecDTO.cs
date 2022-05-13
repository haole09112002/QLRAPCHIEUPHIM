using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietCaLamViecDTO
    {
        private string maNhanVien;
        private string maCa;
        private bool trangThai;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaCa { get => maCa; set => maCa = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
