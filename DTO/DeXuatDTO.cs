using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeXuatDTO
    {
        private string maDeXuat;
        private string maNhanVien;
        private DateTime ngayDeXuat;
        private string maLoaiDeXuat;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public DateTime NgayDeXuat { get => ngayDeXuat; set => ngayDeXuat = value; }
        public string MaLoaiDeXuat { get => maLoaiDeXuat; set => maLoaiDeXuat = value; }
    }
}
