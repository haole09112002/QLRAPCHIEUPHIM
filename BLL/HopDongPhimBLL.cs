using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongPhimBLL
    {
        private static HopDongPhimBLL instance;
        public static HopDongPhimBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongPhimBLL();
                }
                return instance;
            }
            private set { }
        }

        private HopDongPhimBLL(){}
        public HopDongPhimViewDTO GetHopDongPhimViewByHopDongPhimDTO(HopDongPhimDTO phimDTO)
        {
            HopDongPhimViewDTO phimView = new HopDongPhimViewDTO();
            string tenPhim = "";
            foreach (PhimDTO i in PhimDAL.Instance.GetALLPhim())
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
            foreach (HopDongPhimDTO i in HopDongPhimDAL.Instance.GetAllHopDongPhim())
            {
                if (i.MaHopDong == maHopDong)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public HopDongPhimDTO GetHopDongPhimByMaHopDongMaPhim(string maHopDong, string maPhim)
        {
            foreach (HopDongPhimDTO i in GetListHopDongPhimByMaHopDong(maHopDong))
            {
                if (i.MaPhim == maPhim)
                    return i;
            }
            return null;
        }
        public List<HopDongPhimViewDTO> GetListHopDongPhimViewByMaHopDong(string maHopDong)
        {
            List<HopDongPhimViewDTO> data = new List<HopDongPhimViewDTO>();
            foreach (HopDongPhimDTO i in GetListHopDongPhimByMaHopDong(maHopDong))
            {
                data.Add(GetHopDongPhimViewByHopDongPhimDTO(i));
            }
            return data;
        }
        public string KiemTraDuLieuHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            string txt = "";
            if (hopDongPhim.MaPhim == "")
                txt = "mã phim";
            if (hopDongPhim.SoLuong == 0)
                txt = "số lượng";
            if (hopDongPhim.DonViTinh == "")
                txt = "đơn vị tính";
            if (hopDongPhim.GiaTien == 0)
                txt = "giá tiền";
            if (DateTime.Compare(hopDongPhim.NgayKetThucBanQuyen, hopDongPhim.NgayBatDauBanQuyen) < 0)
                return "Thời gian bản quyền không hợp lệ! Vui lòng kiểm tra lại!";
            if (txt != "")
                return "Dữ liệu " + txt + " còn trống! Vui lòng kiểm tra lại";
            else return null;
        }
        public void AddUpdateHopDongPhim(List<HopDongPhimViewDTO> dsHopDong, string maHopDong)
        {
            bool add = true;
            
            List<HopDongPhimDTO> data = new List<HopDongPhimDTO>();
            foreach (HopDongPhimViewDTO i in dsHopDong)
            {
                data.Add(ConvertHopDongPhimViewToDTO(i, maHopDong));
            }
            if (data[0].MaHopDong != "")
            {
                add = false;
            }
            if (maHopDong == "")        // Thêm
                maHopDong = HopDongBLL.Instance.GetMaHopDongMoiNhat();
            if (add)
            {
                foreach(HopDongPhimDTO i in data)
                {
                    i.MaHopDong = maHopDong;
                    HopDongPhimDAL.Instance.ThemHopDongPhim(i);
                }    
            }
            else
            {
                foreach(HopDongPhimDTO i in data)
                {
                    foreach(HopDongPhimDTO j in GetListHopDongPhimByMaHopDong(maHopDong))
                    {
                        if(i.MaPhim == j.MaPhim && (i.NgayKetThucBanQuyen !=j.NgayKetThucBanQuyen || 
                            i.NgayBatDauBanQuyen != j.NgayBatDauBanQuyen ||
                            i.GiaTien != j.GiaTien))
                        {
                            HopDongPhimDAL.Instance.CapNhatHopDongPhim(i);
                        }    
                    }    
                }
            }
        }
        public List<PhimCanTaoHopDongDTO> DSPhimCanThemHopDong()
        {
            return ChiTietDeXuatPhimDAL.Instance.DanhSachPhimCanThemHopDong();
        }

        public HopDongPhimDTO ConvertHopDongPhimViewToDTO(HopDongPhimViewDTO hdView, string maHopDong)
        {
            return new HopDongPhimDTO
            {
                MaHopDong = maHopDong,
                MaPhim = hdView.MaPhim,
                DonViTinh = hdView.DonViTinh,
                GiaTien = hdView.GiaTien,
                NgayBatDauBanQuyen = hdView.NgayBatDauBanQuyen,
                NgayKetThucBanQuyen = hdView.NgayKetThucBanQuyen,
                SoLuong = hdView.SoLuong
            };
        }
        public List<string> GetAllDonViTinh()
        {
            List<string> list = new List<string>();
            foreach (HopDongPhimDTO i in HopDongPhimDAL.Instance.GetAllHopDongPhim().Distinct())
            {
                list.Add(i.DonViTinh);
            }    
            return list;
        }
        public DataTable GetLichSuGiaHan(string maHopDong, string maPhim)
        {
            return HopDongPhimDAL.Instance.GetLichSuGiaHan(maHopDong, maPhim);
        }
    }
}
