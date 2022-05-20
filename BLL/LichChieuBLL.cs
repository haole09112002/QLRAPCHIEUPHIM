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
        public void XoaLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu)
        {
            LichChieuDAL.instance.XoaLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu);
        }
    }
}
