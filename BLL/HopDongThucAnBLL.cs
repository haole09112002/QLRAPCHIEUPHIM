using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class HopDongThucAnBLL
    {
        private static HopDongThucAnBLL instance;
        public static HopDongThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongThucAnBLL();
                }
                return instance;
            }
            private set { }
        }

        private HopDongThucAnBLL() { }
        public List<HopDongThucAnDTO> GetAllHopDongThucAn()
        {
            return HopDongThucAnDAL.Instance.GetAllHopDongThucAn();
        }
        public HopDongThucAnView GetHopDongTAViewByHopDongTADTO(HopDongThucAnDTO thucAnDTO)
        {
            HopDongThucAnView thucAnView = new HopDongThucAnView();
            string tenThucAn = "";
            foreach (ThucAnDTO i in ThucAnDAL.Instance.GetALLThucAn())
            {
                if (i.MaThucAn == thucAnDTO.MaThucAn)
                    tenThucAn = i.TenThucAn;
            }
            thucAnView.MaThucAn = thucAnDTO.MaThucAn;
            thucAnView.TenThucAn = tenThucAn;
            thucAnView.DonViTinh = thucAnDTO.DonViTinh;
            thucAnView.SoLuong = thucAnDTO.SoLuong;
            thucAnView.GiaTien = thucAnDTO.GiaTien;
            return thucAnView;
        }

        public List<HopDongThucAnDTO> GetListHopDongThucAnByMaHopDong(string maHopDong)
        {
            List<HopDongThucAnDTO> data = new List<HopDongThucAnDTO>();
            foreach (HopDongThucAnDTO i in HopDongThucAnDAL.Instance.GetAllHopDongThucAn())
            {
                if (i.MaHopDong == maHopDong)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public HopDongThucAnDTO GetHopDongThucAnByMaHopDongMaThucAn(string maHopDong, string maThucAn)
        {
            foreach (HopDongThucAnDTO i in GetListHopDongThucAnByMaHopDong(maHopDong))
            {
                if (i.MaThucAn == maThucAn)
                    return i;
            }
            return null;
        }
        public List<HopDongThucAnView> GetListHopThucAnViewByMaHopDong(string maHopDong)
        {
            List<HopDongThucAnView> data = new List<HopDongThucAnView>();
            foreach (HopDongThucAnDTO i in GetListHopDongThucAnByMaHopDong(maHopDong))
            {
                data.Add(GetHopDongTAViewByHopDongTADTO(i));
            }
            return data;
        }
        public string KiemTraDuLieuHopDongThucAn(string maThucAn, int soLuong, string donViTinh, string giaTien)
        {
            if (maThucAn == "")
                return "Dữ liệu thức ăn còn trống! Vui lòng kiểm tra lại";
            if (soLuong == 0)
                return "Dữ liệu số lượng còn trống! Vui lòng kiểm tra lại";
            if (donViTinh == "")
                return "Dữ liệu đơn vị tính còn trống! Vui lòng kiểm tra lại";
            if (giaTien == "")
                return "Dữ liệu giá tiền còn trống! Vui lòng kiểm tra lại";
            try
            {
                Convert.ToDouble(giaTien);
            }
            catch (Exception)
            {
                return "Định dạng giá tiền không hợp lệ! Vui lòng kiểm tra lại!";
            }
            return null;
        }
        public void AddHopDongThucAn(List<HopDongThucAnView> dsHopDong, string maHopDong)
        {
           

            List<HopDongThucAnDTO> data = new List<HopDongThucAnDTO>();
            foreach (HopDongThucAnView i in dsHopDong)
            {
                data.Add(ConvertChiTietHopDongThucAnViewToDTO(i, maHopDong));
            }
            maHopDong = HopDongBLL.Instance.GetMaHopDongMoiNhat();

            foreach (HopDongThucAnDTO i in data)
            {
                i.MaHopDong = maHopDong;
                HopDongThucAnDAL.Instance.ThemHopDongThucAn(i);
            }            
        }
        public List<ChiTietDeXuatThucAnViewDTO> DSThucAnCanThemHopDong()
        {
            return ChiTietDeXuatThucAnDAL.Instance.DanhSachThucAnCanThemHopDong();
        }

        public HopDongThucAnDTO ConvertChiTietHopDongThucAnViewToDTO(HopDongThucAnView hdView, string maHopDong)
        {
            return new HopDongThucAnDTO
            {
                MaHopDong = maHopDong,
                MaThucAn = hdView.MaThucAn,
                DonViTinh = hdView.DonViTinh,
                GiaTien = hdView.GiaTien,
                SoLuong = hdView.SoLuong
            };
        }
        public List<string> GetAllDonViTinh()
        {
            List<string> list = new List<string>();
            foreach (HopDongThucAnDTO i in HopDongThucAnDAL.Instance.GetAllHopDongThucAn().Distinct())
            {
                list.Add(i.DonViTinh);
            }
            return list.Distinct().ToList();
        }
        public List<string> GetDanhSachMaThucAnCoHopDong()
        {
            List<string> data = new List<string>();
            foreach (HopDongThucAnDTO i in HopDongThucAnDAL.Instance.GetAllHopDongThucAn())
            {
                data.Add(i.MaThucAn);
            }
            return data.Distinct().ToList();
        }
        public TongSoLuongThucAnDTO GetChiTietTSLThucAnByMaThucAn(string MaThucAn)
        {
            foreach (TongSoLuongThucAnDTO i in GetTongSoLuongCuaTungThucAn())
            {
                if (i.MaThucAn == MaThucAn)
                {
                    return i;
                }
            }
            return null;
        }
        public List<TongSoLuongThucAnDTO> GetTongSoLuongCuaTungThucAn()
        {
            return HopDongThucAnDAL.Instance.GetTongSoLuongCuaTungThucAn();
        }
    }
}
