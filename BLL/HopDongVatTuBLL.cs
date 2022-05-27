using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongVatTuBLL
    {
        private static HopDongVatTuBLL instance;
        public static HopDongVatTuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongVatTuBLL();
                }
                return instance;
            }
            private set { }
        }

        private HopDongVatTuBLL() { }
        public HopDongVatTuView GetHopDongVaTuViewByHopDongVatTuDTO(HopDongVatTuDTO VatTuDTO)
        {
            HopDongVatTuView vatTuView = new HopDongVatTuView();
            string TenVatTu = "";
            foreach (VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.MaVatTu == VatTuDTO.MaVatTu)
                    TenVatTu = i.TenVatTu;
            }
            vatTuView.MaVatTu = VatTuDTO.MaVatTu;
            vatTuView.TenVatTu = TenVatTu;
            vatTuView.DonViTinh = VatTuDTO.DonViTinh;
            vatTuView.SoLuong = VatTuDTO.SoLuong;
            vatTuView.GiaTien = VatTuDTO.GiaTien;
            return vatTuView;
        }

        public List<HopDongVatTuDTO> GetListHopDongVatTuByMaHopDong(string maHopDong)
        {
            List<HopDongVatTuDTO> data = new List<HopDongVatTuDTO>();
            foreach (HopDongVatTuDTO i in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
            {
                if (i.MaHopDong == maHopDong)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public HopDongVatTuDTO GetHopDongVatTuByMaHopDongMaVatTu(string maHopDong, string MaVatTu)
        {
            foreach (HopDongVatTuDTO i in GetListHopDongVatTuByMaHopDong(maHopDong))
            {
                if (i.MaVatTu == MaVatTu)
                    return i;
            }
            return null;
        }
        public List<HopDongVatTuView> GetListHopVatTuViewByMaHopDong(string maHopDong)
        {
            List<HopDongVatTuView> data = new List<HopDongVatTuView>();
            foreach (HopDongVatTuDTO i in GetListHopDongVatTuByMaHopDong(maHopDong))
            {
                data.Add(GetHopDongVaTuViewByHopDongVatTuDTO(i));
            }
            return data;
        }
        public string KiemTraDuLieuHopDongVatTu(string MaVatTu, int soLuong, string donViTinh, string giaTien)
        {
            if (MaVatTu == "")
                return "Dữ liệu vật tư còn trống! Vui lòng kiểm tra lại";
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
        public void AddHopDongVatTu(List<HopDongVatTuView> dsHopDong, string maHopDong)
        {
            List<HopDongVatTuDTO> data = new List<HopDongVatTuDTO>();
            foreach (HopDongVatTuView i in dsHopDong)
            {
                data.Add(ConvertChiTietHopDongVatTuViewToDTO(i, maHopDong));
            }
            maHopDong = HopDongBLL.Instance.GetMaHopDongMoiNhat();

            foreach (HopDongVatTuDTO i in data)
            {
                i.MaHopDong = maHopDong;
                HopDongVatTuDAL.Instance.ThemHopDongVatTu(i);
            }
        }
        public List<ChiTietDeXuatVatTuView> DSVatTuCanThemHopDong()
        {
            return ChiTietDeXuatVatTuDAL.Instance.DanhSachVatTuCanThemHopDong();
        }

        public HopDongVatTuDTO ConvertChiTietHopDongVatTuViewToDTO(HopDongVatTuView hdView, string maHopDong)
        {
            return new HopDongVatTuDTO
            {
                MaHopDong = maHopDong,
                MaVatTu = hdView.MaVatTu,
                DonViTinh = hdView.DonViTinh,
                GiaTien = hdView.GiaTien,
                SoLuong = hdView.SoLuong
            };
        }
        public List<string> GetAllDonViTinh()
        {
            List<string> list = new List<string>();
            foreach (HopDongVatTuDTO i in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
            {
                list.Add(i.DonViTinh);
            }
            return list.Distinct().ToList();
        }
        public List<string> GetDanhSachMaVatTuCoHopDong()
        {
            List<string> data = new List<string>();
            foreach (HopDongVatTuDTO i in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
            {
                data.Add(i.MaVatTu);
            }
            return data.Distinct().ToList();
        }
        public List<HopDongVatTuDTO> GetAllHopDongVatTu()
        {
            return HopDongVatTuDAL.Instance.GetAllHopDongVatTu();
        }
        public TongSoLuongVatTuDTO GetChiTietTSLVatTuByMaVatTu(string MaVatTu)
        {
            foreach (TongSoLuongVatTuDTO i in GetTongSoLuongCuaTungVatTu())
            {
                if (i.MaVatTu == MaVatTu)
                {
                    return i;
                }
            }
            return null;
        }
        public List<TongSoLuongVatTuDTO> GetTongSoLuongCuaTungVatTu()
        {
            return HopDongVatTuDAL.Instance.GetTongSoLuongCuaTungVatTu();
        }
    }
}
