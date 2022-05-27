using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeXuatViewDTO
    {
        private string maDeXuat;
        private string tenNhanVien;

        private DateTime ngayDeXuat;
        private string tenLoaiDeXuat;
        private string maNhanVien;
        private string maLoaiDeXuat;
     
        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public DateTime NgayDeXuat { get => ngayDeXuat; set => ngayDeXuat = value; }
        public string TenLoaiDeXuat { get => tenLoaiDeXuat; set => tenLoaiDeXuat = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaLoaiDeXuat { get => maLoaiDeXuat; set => maLoaiDeXuat = value; }
    }
}
