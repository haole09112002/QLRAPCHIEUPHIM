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
        public List<LichChieuDTO> GetLichChieuDGV(List<string> maPhim)
        {
            List<LichChieuDTO> data = new List<LichChieuDTO>();
            foreach (string i in maPhim)
            {
                data.Add(GetLichChieuByMaPhim(i));
            }
            return data;
        }
        public LichChieuDTO GetLichChieuByMaPhim(string maPhim)
        {
            LichChieuDTO lichchieu = null;
            foreach (LichChieuDTO i in LichChieuDAL.Instance.GetAllLichChieu())
            {
                if (i.MaPhim == maPhim)
                {
                    lichchieu = i;
                    break;
                }
            }
            return lichchieu;
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
        public string KTLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu, DateTime NgayChieu)
        {
            foreach (LichChieuDTO i in GetAllLichChieu())
            {
                if (i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && i.MaKhungGioChieu == MaKhungGioChieu && i.MaPhongChieu == MaPhongChieu && i.TrangThai == "2")
                    return "Tồn tại một lịch chiếu dùng phòng chiếu cùng thời điểm";
            }
            return "";
        }

        public void CapNhatLichChieu(LichChieuDTO lichChieu, string trangThai)
        {
            lichChieu.TrangThai = trangThai;
            LichChieuDAL.instance.CapNhatLichChieu(lichChieu);
        }
        public void LuuLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu, string TrangThai, DateTime NgayChieu)
        {
            LichChieuDAL.Instance.LuuLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, TrangThai, NgayChieu);
        }
        public void DuyetLichChieu(LichChieuDTO lichChieu)
        {
            LichChieuDAL.instance.CapNhatLichChieu(lichChieu);
        }
    }
}
