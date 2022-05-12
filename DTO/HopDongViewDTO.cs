using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongViewDTO
    {
        private string maHopDong;
        private string tenHopDong;
        private string tenNhaCungCap;
        private DateTime ngayKiKetHD;
        private string tenLoaiHopDong;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public DateTime NgayKiKetHD { get => ngayKiKetHD; set => ngayKiKetHD = value; }
        public string TenLoaiHopDong { get => tenLoaiHopDong; set => tenLoaiHopDong = value; }
    }
}
