using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LichLamViecBLL
    {
        private static LichLamViecBLL instance;
        public static LichLamViecBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichLamViecBLL();
                }
                return instance;
            }
            set { }
        }
        public List<LichLamViecDTO> GetAllLichLamViec()
        {

            return LichLamViecDAL.Instance.GetAllLichLamViec();

        }
        public List<CaLamViecDTO> GetListCaLamViecByMaNhanVien(string maNhanVien, DateTime ngayLamViec)
        {
            List<CaLamViecDTO> data = new List<CaLamViecDTO>();
            foreach(LichLamViecDTO i in LichLamViecDAL.Instance.GetAllLichLamViec())
            {
                if(maNhanVien == i.MaNhanVien && ngayLamViec.ToShortDateString() == i.NgayLamViec.ToShortDateString())
                {
                    data.Add(CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa));
                }
            }
            return data;
        }
        public List<LichLamViecDTO> GetAllLichLamViecByNgayLamViec(DateTime ngayLamViec,string maCaLamViec = "", string txt = "")
        {
            List<LichLamViecDTO> data = new List<LichLamViecDTO>();
            foreach(LichLamViecDTO i in LichLamViecDAL.Instance.GetAllLichLamViec())
            {
                if(ngayLamViec.ToShortDateString() == i.NgayLamViec.ToShortDateString() && i.MaCa.Contains(maCaLamViec) && NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public void XoaLichLamViec(string maNhanVien, string maCa, DateTime ngayLamViec)
        {
            if(maCa == "Ca 1")
            {
                maCa = "CLV001";
            }
            if (maCa == "Ca 2")
            {
                maCa = "CLV002";
            }
            if (maCa == "Ca 3")
            {
                maCa = "CLV003";
            }
            if (maCa == "Ca 4")
            {
                maCa = "CLV004";
            }
            LichLamViecDAL.Instance.XoaLichLamViec(maNhanVien,maCa,ngayLamViec);
        }
        public void ThemLichLamViec(string maNhanVien, string maCa, DateTime ngayLamViec)
        {
            if (maCa == "Ca 1")
            {
                maCa = "CLV001";
            }
            if (maCa == "Ca 2")
            {
                maCa = "CLV002";
            }
            if (maCa == "Ca 3")
            {
                maCa = "CLV003";
            }
            if (maCa == "Ca 4")
            {
                maCa = "CLV004";
            }
            LichLamViecDAL.Instance.ThemLichLamViec(maNhanVien, maCa, ngayLamViec);
        }

    }
}
