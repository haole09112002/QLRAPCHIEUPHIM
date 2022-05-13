using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDTO
    {
        private string maPhieu;
        private string maLoaiPhieu;
        private string maKho;
        private string maNhanVien;
        private DateTime ngayLapPhieu;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaLoaiPhieu { get => maLoaiPhieu; set => maLoaiPhieu = value; }
        public string MaKho { get => maKho; set => maKho = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public DateTime NgayLapPhieu { get => ngayLapPhieu; set => ngayLapPhieu = value; }
    }
}
