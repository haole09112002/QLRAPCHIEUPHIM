using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeTienNhapPhimDTO
    {
        private string maHopDong;
        private string tenHopDong;
        private string loaiHopDong;
        private double tongTien;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string LoaiHopDong { get => loaiHopDong; set => loaiHopDong = value; }
    }
}
