using DAL;
using DTO;
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
        public List<LichChieuDTO> GetListLichChieuByTrangThai(bool TrangThai)
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
        public List<LichChieuViewDTO> GetAllLichChieuViews(bool TrangThai)
        {
            List<LichChieuViewDTO> data = new List<LichChieuViewDTO>();
            LichChieuViewDTO LichChieuView = new LichChieuViewDTO();
            foreach(LichChieuDTO i in GetListLichChieuByTrangThai(TrangThai))
            {
                foreach(PhimViewDTO j in PhimBLL.Instance.GetPhimViews())
                {
                    if (i.MaPhim == j.MaPhim)
                    {
                        LichChieuView.MaPhim = j.MaPhim;
                        LichChieuView.TenPhim = j.TenPhim;
                    }
                }
                foreach(KhungGioChieuDTO j in KhungGioChieuDAL.Instance.GetAllKhungGioChieu())
                {
                    if(i.MaKhungGioChieu == j.MaKhungGioChieu)
                    {
                        LichChieuView.MaKhungGioChieu = j.MaKhungGioChieu;
                        LichChieuView.TenKhungGio = j.TenKhungGio;
                    }
                }
                foreach (PhongChieuDTO j in PhongChieuDAL.Instance.GetAllPhongChieu())
                {
                    if (i.MaPhongChieu == j.MaPhongChieu)
                    {
                        LichChieuView.MaPhongChieu = j.MaPhongChieu;
                        LichChieuView.TenPhongChieu = j.TenPhong;
                    }
                }
                data.Add(LichChieuView);
            }
            return data;
        }
        public void XoaLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu)
        {
            LichChieuDAL.instance.XoaLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu);
        }
    }
}
