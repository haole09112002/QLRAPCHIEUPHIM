using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ChiTietKhoPhimBLL
    {
        private static ChiTietKhoPhimBLL instance;
        public static ChiTietKhoPhimBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoPhimBLL();
                }
                return instance;
            }
            set { }
        }
        public List<ChiTietKhoPhimDTO> GetAllChiTietKhoPhim()
        {
            return ChiTietKhoPhimDAL.Instance.GetAllChiTietKhoPhim();
        }
        public List<ChiTietKhoPhimDTO> GetListChiTietKhoPhimByMaKho(string MaKho)
        {
            List<ChiTietKhoPhimDTO> data = new List<ChiTietKhoPhimDTO>();
            foreach (ChiTietKhoPhimDTO i in GetAllChiTietKhoPhim())
            {
                if (i.MaKho == MaKho)
                    data.Add(i);
            }
            return data;
        }
        public ChiTietKhoPhimDTO GetChiTietKhoPhimByKho(string MaKho, string MaPhim)
        {
            foreach (ChiTietKhoPhimDTO i in GetListChiTietKhoPhimByMaKho(MaKho))
            {
                if (MaPhim == i.MaPhim)
                {
                    return i;
                }
            }
            return null;
        }
        public void CapNhatChiTietKhoPhim(string MaKho, string MaPhim, int SoLuongSP, string DonViTinh)
        {
            ChiTietKhoPhimDAL.Instance.CapNhatChiTietKhoPhim(MaKho, MaPhim, SoLuongSP, DonViTinh);
        }
        public void LuuChiTietKhoPhim(string MaKho, string MaPhim, string DonViTinh, int SoLuongSP)
        {
            ChiTietKhoPhimDAL.Instance.LuuChiTietKhoPhim(MaKho, MaPhim, DonViTinh, SoLuongSP);
        }
        public void ThemCapNhatChiTietKhoPhim(List<ChiTietKhoPhimDTO> list, string LoaiPhieu)
        {
            bool KiemTraTonTaiPhim = true;
            foreach (ChiTietKhoPhimDTO i in list)
            {
                KiemTraTonTaiPhim = false;
                foreach (ChiTietKhoPhimDTO j in GetListChiTietKhoPhimByMaKho(i.MaKho))
                {
                    if (i.MaPhim == j.MaPhim)
                    {
                        KiemTraTonTaiPhim = true;
                        j.DonViTinh = i.DonViTinh;
                        if (LoaiPhieu == "LP001")
                        {
                            j.SoLuongSP = j.SoLuongSP + i.SoLuongSP;
                        }
                        else
                        {
                            j.SoLuongSP = j.SoLuongSP - i.SoLuongSP;
                        }
                        CapNhatChiTietKhoPhim(j.MaKho, j.MaPhim, j.SoLuongSP, j.DonViTinh);
                    }
                }
                if (KiemTraTonTaiPhim == false)
                {
                    LuuChiTietKhoPhim(i.MaKho, i.MaPhim, i.DonViTinh, i.SoLuongSP);
                }
            }
        }
        public List<PhimDTO> GetListPhimByMaKho(string MaKho)
        {
            List<PhimDTO> data = new List<PhimDTO>();
            foreach (ChiTietKhoPhimDTO i in GetListChiTietKhoPhimByMaKho(MaKho))
            {
                data.Add(PhimBLL.Instance.GetPhimByMaPhim(i.MaPhim));
            }
            return data;
        }
        public List<TongSoLuongPhimDTO> GetTongSoLuongCuaTungPhim()
        {
            return ChiTietKhoPhimDAL.Instance.GetTongSoLuongCuaTungPhim();
        }
        public TongSoLuongPhimDTO GetChiTietSoLuongPhim(string MaPhim)
        {
            foreach (TongSoLuongPhimDTO i in GetTongSoLuongCuaTungPhim())
            {
                if (i.MaPhim == MaPhim)
                    return i;
            }
            return null;
        }
        public TongSoLuongPhimDTO GetSoLuongPhim(string MaPhim)
        {
            foreach (TongSoLuongPhimDTO i in ChiTietKhoPhimDAL.Instance.GetTongSoLuongCuaTungPhim())
            {
                if (i.MaPhim == MaPhim)
                {
                    return i;
                }
            }
            return null;
        }
        public List<string> GetDanhSachMaPhimCoTrongKho()
        {
            List<string> data = new List<string>();
            foreach (ChiTietKhoPhimDTO i in GetAllChiTietKhoPhim())
            {
                data.Add(i.MaPhim);
            }
            return data.Distinct().ToList();
        }
        public void XoaPhimTrongKho(string MaPhim, string MaKho)
        {
            ChiTietKhoPhimDAL.Instance.XoaPhimTrongKho(MaPhim, MaKho);
        }
        public ChiTietKhoPhimDTO GetChiTietKhoPhimByKhoa(string MaPhim, string MaKho)
        {
            foreach(ChiTietKhoPhimDTO i in GetAllChiTietKhoPhim())
            {
                if(i.MaKho == MaKho && i.MaPhim == MaPhim)
                {
                    return i;
                }
            }
            return null;
        }
    }
}

