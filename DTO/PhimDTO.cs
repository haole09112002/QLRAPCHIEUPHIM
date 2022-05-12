using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimDTO
    {
        private string maPhim;
        private string tenPhim;
        private byte[] anhPhim;
        private int thoiLuong;
        private string quocGia;
        private DateTime namSanXuat;
        private int doTuoiXem;
        private string maTheLoai;
        private string noiDung;
        private string maHangSanXuatPhim;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public byte[] AnhPhim { get => anhPhim; set => anhPhim = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public DateTime NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public int DoTuoiXem { get => doTuoiXem; set => doTuoiXem = value; }
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string MaHangSanXuatPhim { get => maHangSanXuatPhim; set => maHangSanXuatPhim = value; }
    }
}

