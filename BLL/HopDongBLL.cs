﻿using System;
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
        
        
        //-------------------------------Hop_Dong
        public void ThemHopDong(HopDongDTO hopDong)
        {
            if(hopDong.MaHopDong == "")
            HopDongDAL.Instance.ThemHopDong(hopDong);
        }
        
        //-------------------------------PHIM
      
        public string KiemTraDuLieuHopDong(HopDongDTO hd)
        {
            string txt = "";
            if (hd.TenHopDong == "")
                txt = "tên hợp đồng";
            if(hd.MaNhaCungCap == "")
                txt = "nhà cung cấp";
            if (hd.NgayKiKetHD == null)
                txt = "ngày kí kết";
            if (txt != "")
                return "Dữ liệu " + txt + " còn trống! Vui lòng kiểm tra lại!";
            else
                return null;
        }
        public string GetMaHopDongMoiNhat()
        {
            return HopDongDAL.Instance.GetMaHopDongMoiNhat();
        }
    }
}
