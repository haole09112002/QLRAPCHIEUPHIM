using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

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
            KhungGioChieuDTO KGC1 = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(MaKhungGioChieu);
            KhungGioChieuDTO KGC2;
            foreach(LichChieuDTO i in GetAllLichChieu())
            {
                KGC2 = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu);
                if (i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && ((KGC1.TGBatDau < KGC2.TGKetThuc && KGC1.TGBatDau > KGC2.TGBatDau) || (KGC1.TGKetThuc > KGC2.TGBatDau && KGC1.TGKetThuc < KGC2.TGKetThuc) || MaKhungGioChieu == i.MaKhungGioChieu) && i.MaPhongChieu == MaPhongChieu && i.TrangThai == "2")
                    return "Tồn tại một lịch chiếu dùng phòng chiếu cùng thời điểm";
                if (i.MaPhim == MaPhim && i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && i.MaKhungGioChieu == MaKhungGioChieu && i.MaPhongChieu == MaPhongChieu)
                    return "Lịch chiếu đã được tạo";
            }
            if(GetSoLuongPhimChieuTaiMotThoiDiem(MaPhim,MaKhungGioChieu,NgayChieu) == ChiTietKhoPhimBLL.Instance.GetChiTietSoLuongPhim(MaPhim).TongSoLuongPhim)
            {
                return "Không đủ phim để chiếu";
            }
            return "";
        }
        public int GetSoLuongPhimChieuTaiMotThoiDiem(string MaPhim,string MaKhungGioChieu,DateTime NgayChieu)
        {
            int SoLuong = 0;
            KhungGioChieuDTO KGC1 = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(MaKhungGioChieu);
            KhungGioChieuDTO KGC2;
            foreach (LichChieuDTO i in GetListLichChieuByTrangThai("2"))
            {
                KGC2 = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu);
                if (MaPhim == i.MaPhim && i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && ((KGC1.TGBatDau < KGC2.TGKetThuc && KGC1.TGBatDau > KGC2.TGBatDau) || (KGC1.TGKetThuc > KGC2.TGBatDau && KGC1.TGKetThuc < KGC2.TGKetThuc) || MaKhungGioChieu == i.MaKhungGioChieu))
                    SoLuong++;
            }
            return SoLuong;
        }
        public void LuuLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu, string TrangThai, DateTime NgayChieu)
        {
            LichChieuDAL.Instance.LuuLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, TrangThai, NgayChieu);
        }
        public void DuyetLichChieu(LichChieuDTO lichChieu)
        {
            
        }
    }
}
