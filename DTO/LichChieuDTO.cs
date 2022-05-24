using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuDTO
    {
        private string maPhim;
        //private string tenPhim;
        private string maPhongChieu;
        private string maKhungGioChieu;
        private DateTime ngayChieu;
        private bool trangThai;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public string MaKhungGioChieu { get => maKhungGioChieu; set => maKhungGioChieu = value; }
        public DateTime NgayChieu { get => ngayChieu; set => ngayChieu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        //public string TenPhim { get => tenPhim; set => tenPhim = value; }
    }
}
