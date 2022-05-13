using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;
using System.Data;

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
            if(hopDong.MaHopDong == "")
            HopDongDAL.Instance.ThemHopDong(hopDong);
        }
        
        //-------------------------------PHIM
      
        public string KiemTraDuLieuHopDong(HopDongDTO hd, int soLuongPhimTrongHopDong)
        {
            if (hd.TenHopDong == "")
                return "Dữ liệu tên hợp đồng còn trống! Vui lòng kiểm tra lại!";
            if (hd.MaNhaCungCap == "")
                return "Dữ liệu nhà cung cấp còn trống! Vui lòng kiểm tra lại!";
            if (hd.NgayKiKetHD == null)
                return "Dữ liệu ngày kí kết còn trống! Vui lòng kiểm tra lại!";
            if (soLuongPhimTrongHopDong == 0)
                return "Chưa có phim trong hợp đồng! Vui lòng kiểm tra lại!";
            return null;
        }
        public string GetMaHopDongMoiNhat()
        {
            return HopDongDAL.Instance.GetMaHopDongMoiNhat();
        }
    }
}
