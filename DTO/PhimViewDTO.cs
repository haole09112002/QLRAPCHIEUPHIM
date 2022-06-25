using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimViewDTO
    {
        private string maPhim;
        private string tenPhim;
        private int thoiLuong;
        private string quocGia;
        private DateTime namSanXuat;
        private int doTuoiXem;
        private string theLoai;
        private string tenHangSanXuatPhim;
        private string hopDong;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public DateTime NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public string TenHangSanXuatPhim { get => tenHangSanXuatPhim; set => tenHangSanXuatPhim = value; }
        public int DoTuoiXem { get => doTuoiXem; set => doTuoiXem = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string HopDong { get => hopDong; set => hopDong = value; }
    }
}
