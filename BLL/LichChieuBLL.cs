using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class LichChieuBLL
    {
        private static LichChieuBLL instance;
        public static LichChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichChieuBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<LichChieuDTO> GetAllLichChieu()
        {
            List<LichChieuDTO> data = new List<LichChieuDTO>();
            foreach(LichChieuDTO i in LichChieuDAL.Instance.GetAllLichChieu())
            {
                data.Add(i);
            }
            return data;
        }
        public List<LichChieuDTO> GetListLichChieuByTrangThai(string TrangThai)
        {
            List<LichChieuDTO> data = new List<LichChieuDTO>();
            foreach(LichChieuDTO i in GetAllLichChieu())
            {
                if(i.TrangThai == TrangThai)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public string KiemTraLichChieu(string MaPhim,string MaKhungGioChieu, string MaPhongChieu, DateTime NgayChieu)
        {
            foreach(LichChieuDTO i in GetAllLichChieu())
            {
                if (i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && i.MaKhungGioChieu == MaKhungGioChieu && i.MaPhongChieu == MaPhongChieu && i.TrangThai == "2")
                    return "Tồn tại một lịch chiếu dùng phòng chiếu cùng thời điểm";
                if (i.MaPhim == MaPhim && i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && i.MaKhungGioChieu == MaKhungGioChieu && i.MaPhongChieu == MaPhongChieu)
                    return "Lịch chiếu đã được tạo";
            }
            return "";
        }
        public void LuuLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu, bool TrangThai, DateTime NgayChieu)
        {
            LichChieuDAL.Instance.LuuLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, TrangThai, NgayChieu);
        }
    }
}
