using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongBLL
    {

        private static HopDongBLL instance;
        public static HopDongBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongBLL();
                }
                return instance;
            }
            private set { }
        }

        private HopDongBLL()
        {

        }
        public List<HopDongDTO> GetHopDongByMaLoaiHopDong(string maLoaiHopDong = "0", string txt = "")
        {
            List<HopDongDTO> data = new List<HopDongDTO>();
            if(maLoaiHopDong == "0")
            foreach (HopDongDTO i in HopDongDAL.Instance.GetAllHopDong())
            {
                if (i.TenHopDong.Contains(txt))
                {
                    data.Add(i);
                }
            }
            else
            foreach (HopDongDTO i in HopDongDAL.Instance.GetAllHopDong())
            {
                if(i.MaLoaiHopDong == maLoaiHopDong && i.TenHopDong.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
            
        }
        public HopDongViewDTO GetHopDongViewByHopDongDTO(HopDongDTO hd)
        {
            string tenNCC = "";
            string tenLoaiHopDong = "";
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if(i.MaNhaCungCap == hd.MaNhaCungCap)
                {
                    tenNCC = i.TenNhaCungCap;
                }
            }
            foreach (LoaiHopDongDTO i in LoaiHopDongDAL.Instance.GetAllLoaiHopDong())
            {
                if (i.MaLoaiHopDong == hd.MaLoaiHopDong)
                {
                    tenLoaiHopDong = i.TenLoaiHopDong;
                }
            }
            return new HopDongViewDTO
            {
                MaHopDong = hd.MaHopDong,
                TenHopDong = hd.TenHopDong,
                NgayKiKetHD = hd.NgayKiKetHD,
                TenLoaiHopDong = tenLoaiHopDong,
                TenNhaCungCap = tenNCC
            };
        }
        public List<HopDongViewDTO> GetListHopDongView(List<HopDongDTO> list)
        {
            List<HopDongViewDTO> data = new List<HopDongViewDTO>();
            foreach (HopDongDTO i in list)
            {
                data.Add(GetHopDongViewByHopDongDTO(i));
            }
            return data;
        }
   
        public HopDongDTO GetHopDongByMaHopDong(string maHopDong)
        {
            foreach (HopDongDTO i in HopDongDAL.Instance.GetAllHopDong())
            {
                if (i.MaHopDong == maHopDong)
                {
                    return i;
                }
            }
            return null;
        }
        
        public HopDongPhimDTO GetHopDongPhimByMaHopDong(string maHopDong)
        {
            foreach(HopDongPhimDTO i in HopDongPhimDAL.Instance.GetAllHopDongPhim())
            {
                if (i.MaHopDong == maHopDong)
                    return i;
            }
            return null;
        }
        public HopDongVatTuDTO GetHopDongVatTuByMaHopDong(string maHopDong)
        {
            foreach (HopDongVatTuDTO i in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
            {
                if (i.MaHopDong == maHopDong)
                    return i;
            }
            return null;
        }
        public HopDongThucAnDTO GetHopDongThucAnByMaHopDong(string maHopDong)
        {
            foreach (HopDongThucAnDTO i in HopDongThucAnDAL.Instance.GetAllHopDongThucAn())
            {
                if (i.MaHopDong == maHopDong)
                    return i;
            }
            return null;
        }
        //-------------------------------Hop_Dong
        public void ThemHopDong(HopDongDTO hopDong)
        {
            HopDongDAL.Instance.ThemHopDong(hopDong);
        }
        
        //-------------------------------PHIM
        public HopDongPhimViewDTO GetHopDongPhimViewByHopDongPhimDTO(HopDongPhimDTO phimDTO)
        {
            HopDongPhimViewDTO phimView = new HopDongPhimViewDTO();
            string tenPhim = "";
            foreach(PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                if (i.MaPhim == phimDTO.MaPhim)
                    tenPhim = i.TenPhim;
            }
            phimView.MaPhim = phimDTO.MaPhim;
            phimView.TenPhim = tenPhim;
            phimView.DonViTinh = phimDTO.DonViTinh;
            phimView.SoLuong = phimDTO.SoLuong;
            phimView.NgayKetThucBanQuyen = phimDTO.NgayKetThucBanQuyen;
            phimView.NgayBatDauBanQuyen = phimDTO.NgayBatDauBanQuyen;
            phimView.GiaTien = phimDTO.GiaTien;
            return phimView;
        }

        public List<HopDongPhimDTO> GetListHopDongPhimByMaHopDong(string maHopDong)
        {
            List<HopDongPhimDTO> data = new List<HopDongPhimDTO>();
            foreach(HopDongPhimDTO i in HopDongPhimDAL.Instance.GetAllHopDongPhim())
            {
                if(i.MaHopDong == maHopDong)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public HopDongPhimDTO GetHopDongPhimByMaHopDongMaPhim(string maHopDong, string maPhim)
        {
            foreach(HopDongPhimDTO i in GetListHopDongPhimByMaHopDong(maHopDong))
            {
                if (i.MaPhim == maPhim)
                    return i;
            }
            return null;
        }
        public List<HopDongPhimViewDTO> GetListHopDongPhimViewByMaHopDong(string maHopDong)
        {
            List<HopDongPhimViewDTO> data = new List<HopDongPhimViewDTO>();
            foreach(HopDongPhimDTO i in GetListHopDongPhimByMaHopDong(maHopDong))
            {
                data.Add(GetHopDongPhimViewByHopDongPhimDTO(i));
            }
            return data;
        }
        public string KiemTraDuLieuHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            if(hopDongPhim.MaPhim == "" ||
                hopDongPhim.DonViTinh == "" ||
                hopDongPhim.SoLuong == 0 ||
                hopDongPhim.GiaTien == 0||
                hopDongPhim.NgayKetThucBanQuyen.ToString() == ""||
                hopDongPhim.NgayBatDauBanQuyen.ToString() == "")
            {
                return "Dữ liệu nhập vào còn trống!Vui lòng nhập lại!";
            }
            //
            return "";

        }
        public void AddUpdateHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            bool add = true;
            foreach (HopDongPhimDTO i in HopDongPhimDAL.Instance.GetAllHopDongPhim())
            {
                if (i.MaHopDong == hopDongPhim.MaHopDong)
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                HopDongPhimDAL.Instance.ThemHopDongPhim(hopDongPhim);
            }
            else
            {
                HopDongPhimDAL.Instance.CapNhatHopDongPhim(hopDongPhim);
            }
        }


    }
}
