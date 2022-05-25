using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LichChieuViewBLL
    {
        private static LichChieuViewBLL instance;
        public static LichChieuViewBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichChieuViewBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<LichChieuViewDTO> GetLichChieuViewByTrangThai(string TrangThai, string TimKiem = "", string LoaiTimKiem = "")
        {
            List<LichChieuViewDTO> data = new List<LichChieuViewDTO>();
            foreach(LichChieuDTO i in LichChieuBLL.Instance.GetAllLichChieu())
            {
                if (LoaiTimKiem == "")
                {
                    if (i.TrangThai == TrangThai)
                    {
                        data.Add(new LichChieuViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim,
                            MaPhongChieu = i.MaPhongChieu,
                            TenPhongChieu = PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong,
                            MaKhungGioChieu = i.MaKhungGioChieu,
                            GioBatDau = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau,
                            GioKetThuc = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc,
                            NgayChieu = i.NgayChieu
                        });
                    }
                }
                else if(LoaiTimKiem == "Tên Phim")
                {
                    if (i.TrangThai == TrangThai && PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim.Contains(TimKiem))
                    {
                        data.Add(new LichChieuViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim,
                            MaPhongChieu = i.MaPhongChieu,
                            TenPhongChieu = PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong,
                            MaKhungGioChieu = i.MaKhungGioChieu,
                            GioBatDau = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau,
                            GioKetThuc = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc,
                            NgayChieu = i.NgayChieu
                        });
                    }
                }
                else if(LoaiTimKiem == "Tên Phòng Chiếu")
                {
                    if (i.TrangThai == TrangThai && PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong.Contains(TimKiem))
                    {
                        data.Add(new LichChieuViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim,
                            MaPhongChieu = i.MaPhongChieu,
                            TenPhongChieu = PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong,
                            MaKhungGioChieu = i.MaKhungGioChieu,
                            GioBatDau = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau,
                            GioKetThuc = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc,
                            NgayChieu = i.NgayChieu
                        });
                    }
                }
                else if(LoaiTimKiem == "Ngày Chiếu")
                {
                    if (i.TrangThai == TrangThai && i.NgayChieu.ToShortDateString().Contains(TimKiem))
                    {
                        data.Add(new LichChieuViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim,
                            MaPhongChieu = i.MaPhongChieu,
                            TenPhongChieu = PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong,
                            MaKhungGioChieu = i.MaKhungGioChieu,
                            GioBatDau = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau,
                            GioKetThuc = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc,
                            NgayChieu = i.NgayChieu
                        });
                    }
                }
            }
            return data;
        }
    }
}
