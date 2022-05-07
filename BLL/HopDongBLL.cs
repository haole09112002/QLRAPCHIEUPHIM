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
        public List<HopDongDTO> GetAllHopDong(string txt = "")
        {
            List<HopDongDTO> data = new List<HopDongDTO>();
            foreach(HopDongDTO i in HopDongDAL.Instance.GetAllHopDong())
            {
                if(i.TenHopDong.Contains(txt))
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
    }
}
