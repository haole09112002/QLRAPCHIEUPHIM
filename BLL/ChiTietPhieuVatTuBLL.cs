using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ChiTietPhieuVatTuBLL
    {
        private static ChiTietPhieuVatTuBLL instance;
        public static ChiTietPhieuVatTuBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuVatTuBLL();
                return instance;
            }
            private set { }
        }
        public List<ChiTietPhieuVatTuDTO> GetAllChiTietPhieuVatTu()
        {
            return ChiTietPhieuVatTuDAL.Instance.GetAllChiTietPhieuVatTu();
        }
        public List<ChiTietPhieuVatTuDTO> GetListChiTietPhieuVatTuByMaPhieu(string MaPhieu)
        {
            List<ChiTietPhieuVatTuDTO> data = new List<ChiTietPhieuVatTuDTO>();
            foreach (ChiTietPhieuVatTuDTO i in GetAllChiTietPhieuVatTu())
            {
                if (i.MaPhieu == MaPhieu)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<string> GetListMaPhieu(string MaLoaiPhieu = "")
        {
            List<string> data = new List<string>();
            foreach (ChiTietPhieuVatTuDTO i in GetAllChiTietPhieuVatTu())
            {
                if (PhieuBLL.Instance.GetPhieuByMaPhieu(i.MaPhieu).MaLoaiPhieu.Contains(MaLoaiPhieu))
                {
                    data.Add(i.MaPhieu);
                }
            }
            return data.Distinct().ToList();
        }
        public void LuuChiTietPhieuVatTu(string MaPhieu, string MaVatTu, string DonViTinh, int SoLuong)
        {
            ChiTietPhieuVatTuDAL.Instance.LuuChiTietPhieuVatTu(MaPhieu, MaVatTu, DonViTinh, SoLuong);
        }
        public List<TongSoLuongVatTuDTO> GetListTongSoLuongVatTuTrongPhieuNhap()
        {
            return ChiTietPhieuVatTuDAL.Instance.GetListTongSoLuongVatTuTrongPhieuNhap();
        }
        public int GetTongSoLuongVatTuTrongPhieuNhap(string MaVatTu)
        {
            foreach (TongSoLuongVatTuDTO i in GetListTongSoLuongVatTuTrongPhieuNhap())
            {
                if (i.MaVatTu == MaVatTu)
                {
                    return i.TongSoLuongVatTu;
                }
            }
            return 0;
        }
    }
}
