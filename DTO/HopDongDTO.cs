using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongDTO
    {
        private string maHopDong;
        private string tenHopDong;
        private string maNhaCungCap;
        private DateTime ngayKiKetHD;
        private string maLoaiHopDong;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public DateTime NgayKiKetHD { get => ngayKiKetHD; set => ngayKiKetHD = value; }
        public string MaLoaiHopDong { get => maLoaiHopDong; set => maLoaiHopDong = value; }
    }
}
