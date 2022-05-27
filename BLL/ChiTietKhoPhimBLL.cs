using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public ChiTietKhoPhimDTO GetChiTietKhoPhimByKhoa(string MaKho, string MaPhim)
        {
            foreach(ChiTietKhoPhimDTO i in GetListChiTietKhoPhimByMaKho(MaKho))
            {
                if(MaPhim == i.MaPhim)
                {
                    return i;
                }
            }
            return null;
        }
        public void CapNhatChiTietKhoPhim(string MaKho, string MaPhim, int SoLuongSP, string DonViTinh)
        {
            MessageBox.Show("UP");
            ChiTietKhoPhimDAL.Instance.CapNhatChiTietKhoPhim(MaKho, MaPhim, SoLuongSP, DonViTinh);
        }
        public void LuuChiTietKhoPhim(string MaKho, string MaPhim, string DonViTinh, int SoLuongSP)
        {
            ChiTietKhoPhimDAL.Instance.LuuChiTietKhoPhim(MaKho, MaPhim, DonViTinh, SoLuongSP);
        }
        public void ThemCapNhatChiTietKhoPhim(List<ChiTietKhoPhimDTO> list,string LoaiPhieu)
        {
            bool KiemTraTonTaiPhim = true;
            foreach(ChiTietKhoPhimDTO i in list)
            {
                KiemTraTonTaiPhim = false;
                foreach(ChiTietKhoPhimDTO j in GetListChiTietKhoPhimByMaKho(i.MaKho))
                {
                    if(i.MaPhim == j.MaPhim)
                    {
                        MessageBox.Show("Up1");
                        KiemTraTonTaiPhim = true;
                        j.DonViTinh = i.DonViTinh;
                        if(LoaiPhieu == "LP001")
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
            foreach(ChiTietKhoPhimDTO i in GetListChiTietKhoPhimByMaKho(MaKho))
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
            foreach(TongSoLuongPhimDTO i in GetTongSoLuongCuaTungPhim())
            {
                if(i.MaPhim == MaPhim)
                    return i;
            }
            return null;
        }
    }
}

