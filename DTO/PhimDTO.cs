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
        private string anhPhim;
        private int thoiLuong;
        private string quocGia;
        private DateTime namSanXuat;
        private string tenHangSanXuat;
        private int doTuoiXem;
        private string maTheLoai;
        private string noiDung;
        private string dienVienChinh;
        private string dienVienPhu;
        private string daoDien;

        public PhimDTO(string maPhim, string tenPhim, string anhPhim, int thoiLuong, string quocGia, DateTime namSanXuat, string tenHangSanXuat, int doTuoiXem, string maTheLoai, string noiDung, string dienVienPhu, string dienVienChinh, string daoDien)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.anhPhim = anhPhim;
            this.thoiLuong = thoiLuong;
            this.quocGia = quocGia;
            this.namSanXuat = namSanXuat;
            this.tenHangSanXuat = tenHangSanXuat;
            this.doTuoiXem = doTuoiXem;
            this.maTheLoai = maTheLoai;
            this.noiDung = noiDung;
            this.dienVienChinh = dienVienChinh;
            this.dienVienPhu = dienVienPhu;
            this.daoDien = daoDien;
        }

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string AnhPhim { get => anhPhim; set => anhPhim = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public DateTime NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public string TenHangSanXuat { get => tenHangSanXuat; set => tenHangSanXuat = value; }
        public int DoTuoiXem { get => doTuoiXem; set => doTuoiXem = value; }
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string DienVienChinh { get => dienVienChinh; set => dienVienChinh = value; }
        public string DienVienPhu { get => dienVienPhu; set => dienVienPhu = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
    }
}

