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
        private string ngayDeXuat;
        private string tenLoaiDeXuat;

        public string MaDeXuat { get => maDeXuat; set => maDeXuat = value; }
        public string NgayDeXuat { get => ngayDeXuat; set => ngayDeXuat = value; }
        public string TenLoaiDeXuat { get => tenLoaiDeXuat; set => tenLoaiDeXuat = value; }
    }
}
