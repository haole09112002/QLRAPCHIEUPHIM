using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichLamViecDTO
    {
        private string maNhanVien;
        private string maCa;
        private DateTime ngayLamViec;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaCa { get => maCa; set => maCa = value; }
        public DateTime NgayLamViec { get => ngayLamViec; set => ngayLamViec = value; }
    }
}
