using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChinhSachDTO
    {
        private string maChinhSach;
        private int heSoLuong;
        private string baoHiemXaHoi;
        private double tienThuong;

        public string MaChinhSach { get => maChinhSach; set => maChinhSach = value; }
        public int HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public string BaoHiemXaHoi { get => baoHiemXaHoi; set => baoHiemXaHoi = value; }
        public double TienThuong { get => tienThuong; set => tienThuong = value; }
    }
}
