using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLamViecDTO
    {
        private string maCa;
        private string tenCa;
        private DateTime gioBatDau;
        private DateTime gioKetThuc;

        public string MaCa { get => maCa; set => maCa = value; }
        public string TenCa { get => tenCa; set => tenCa = value; }
        public DateTime GioBatDau { get => gioBatDau; set => gioBatDau = value; }
        public DateTime GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }
    }
}
