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
        public delegate bool Compare(object a, object b);
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
                    if (i.TrangThai == TrangThai && PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim).TenPhim.ToLower().Contains(TimKiem.ToLower()))
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
                    if (i.TrangThai == TrangThai && PhongChieuBLL.Instance.GetPhongChieuByMaPC(i.MaPhongChieu).TenPhong.ToLower().Contains(TimKiem.ToLower()))
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
        public List<LichChieuViewDTO> SortLichChieu(Compare compare,string TrangThai, string TimKiem = "", string LoaiTimKiem = "")
        {
            List<LichChieuViewDTO> data = new List<LichChieuViewDTO>();
            data = GetLichChieuViewByTrangThai(TrangThai, TimKiem, LoaiTimKiem);
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        LichChieuViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public bool CompareTenPhim(object o1, object o2)
        {
            return String.Compare(((LichChieuViewDTO)o1).TenPhim, ((LichChieuViewDTO)o2).TenPhim) > 0;
        }
        public bool CompareTenPhongChieu(object o1, object o2)
        {
            return String.Compare(((LichChieuViewDTO)o1).TenPhongChieu, ((LichChieuViewDTO)o2).TenPhongChieu) > 0;
        }
        public bool CompareNgayChieu(object o1, object o2)
        {
            return DateTime.Compare(((LichChieuViewDTO)o1).NgayChieu, ((LichChieuViewDTO)o2).NgayChieu) > 0;
        }
    }
}
