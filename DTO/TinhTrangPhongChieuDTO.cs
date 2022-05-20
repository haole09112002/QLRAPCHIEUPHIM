using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangPhongChieuDTO
    {
        private string maTinhTrang;
        private string tenTinhTrang;

        public string MaTinhTrang { get => maTinhTrang; set => maTinhTrang = value; }
        public string TenTinhTrang { get => tenTinhTrang; set => tenTinhTrang = value; }
    }
}
