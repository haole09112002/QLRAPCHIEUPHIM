using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NgayLamViecDTO
    {
        private string maNgayLamViec;
        private DateTime ngayLamViec;
        private string maCa;

        public string MaNgayLamViec { get => maNgayLamViec; set => maNgayLamViec = value; }
        public DateTime NgayLamViec { get => ngayLamViec; set => ngayLamViec = value; }
        public string MaCa { get => maCa; set => maCa = value; }
    }
}
