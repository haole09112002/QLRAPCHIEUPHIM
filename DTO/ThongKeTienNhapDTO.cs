using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeTienNhapDTO
    {
        private string maHopDong;
        private string tenHopDong;
        private string maLoaiHopDong;
        private string tenLoaiHopDong;
        private double tongTien;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string LoaiHopDong { get => maLoaiHopDong; set => maLoaiHopDong = value; }
        public string TenLoaiHopDong { get => tenLoaiHopDong; set => tenLoaiHopDong = value; }
    }
}
