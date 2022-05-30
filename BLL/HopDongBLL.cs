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
        public List<HopDongDTO> GetHopDongByMaLoaiHopDong(string maLoaiHopDong = "0")
        {
            List<HopDongDTO> data = new List<HopDongDTO>();
            if (maLoaiHopDong == "0")
                data = HopDongDAL.Instance.GetAllHopDong();
            else
                foreach (HopDongDTO i in HopDongDAL.Instance.GetAllHopDong())
                {
                    if (i.MaLoaiHopDong == maLoaiHopDong)
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
        public List<HopDongViewDTO> GetHopDongViewByMaLoaiHopDong(string maLoaiHopDong = "0", string txt = "")
        {
            List<HopDongViewDTO> data = new List<HopDongViewDTO>();
            foreach(HopDongDTO i in GetHopDongByMaLoaiHopDong(maLoaiHopDong))
            {
                data.Add(GetHopDongViewByHopDongDTO(i));
            }
            List<HopDongViewDTO> result = new List<HopDongViewDTO>();
            foreach (HopDongViewDTO i in data)
            {
                if (i.TenHopDong.Contains(txt) || i.NgayKiKetHD.ToShortDateString().Contains(txt) || i.TenNhaCungCap.Contains(txt))
                    result.Add(i);
            }     
            return result;
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
        
        public void ThemHopDong(HopDongDTO hopDong)
        {
            if(hopDong.MaHopDong == "")
            HopDongDAL.Instance.ThemHopDong(hopDong);
        }
      
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

        public List<HopDongViewDTO> GetHopDongDGV(List<string> listMaHopDong)
        {
            List<HopDongViewDTO> data = new List<HopDongViewDTO>();
            foreach (string i in listMaHopDong)
            {
                data.Add(GetHopDongViewByHopDongDTO(GetHopDongByMaHopDong(i)));
            }
            return data;
        }
        public delegate bool CompareObj(object o1, object o2);
        public List<HopDongViewDTO> SortHopDong(List<HopDongViewDTO> now, string dkSort)
        {
            if (dkSort == "Tên A->Z")
                return Sort(now, CompareTenHopDongTang);
            if (dkSort == "Tên Z->A")
                return Sort(now, CompareTenHopDongGiam);
            if (dkSort == "Ngày kí kết tăng")
                return Sort(now, CompareNgayKiKetTang);
            if (dkSort == "Ngày kí kết giảm")
                return Sort(now, CompareNgayKiKetGiam);
            return null;
        }
        public static bool CompareTenHopDongTang(object o1, object o2)
        {
            return String.Compare(((HopDongViewDTO)o1).TenHopDong, ((HopDongViewDTO)o2).TenHopDong) > 0;
        }
        public static bool CompareNgayKiKetTang(object o1, object o2)
        {
            return DateTime.Compare(((HopDongViewDTO)o1).NgayKiKetHD, ((HopDongViewDTO)o2).NgayKiKetHD) > 0;
        }
        public static bool CompareNgayKiKetGiam(object o1, object o2)
        {
            return DateTime.Compare(((HopDongViewDTO)o1).NgayKiKetHD, ((HopDongViewDTO)o2).NgayKiKetHD) < 0;
        }
        public static bool CompareTenHopDongGiam(object o1, object o2)
        {
            return String.Compare(((HopDongViewDTO)o2).TenHopDong, ((HopDongViewDTO)o1).TenHopDong) > 0;
        }


        public List<HopDongViewDTO> Sort(List<HopDongViewDTO> now, CompareObj cmp)
        {
            List<HopDongViewDTO> data = now;
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        HopDongViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
    }
}
