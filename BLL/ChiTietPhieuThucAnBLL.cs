using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ChiTietPhieuThucAnBLL
    {
        private static ChiTietPhieuThucAnBLL instance;
        public static ChiTietPhieuThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuThucAnBLL();
                return instance;
            }
            private set { }
        }
        public List<ChiTietPhieuThucAnDTO> GetAllChiTietPhieuThucAn()
        {
            return ChiTietPhieuThucAnDAL.Instance.GetAllChiTietPhieuThucAn();
        }
        public List<ChiTietPhieuThucAnDTO> GetListChiTietPhieuThucAnByMaPhieu(string MaPhieu)
        {
            List<ChiTietPhieuThucAnDTO> data = new List<ChiTietPhieuThucAnDTO>();
            foreach (ChiTietPhieuThucAnDTO i in GetAllChiTietPhieuThucAn())
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
            foreach (ChiTietPhieuThucAnDTO i in GetAllChiTietPhieuThucAn())
            {
                if (PhieuBLL.Instance.GetPhieuByMaPhieu(i.MaPhieu).MaLoaiPhieu.Contains(MaLoaiPhieu))
                {
                    data.Add(i.MaPhieu);
                }
            }
            return data.Distinct().ToList();
        }
        public void LuuChiTietPhieuThucAn(string MaPhieu, string MaThucAn, string DonViTinh, int SoLuong)
        {
            ChiTietPhieuThucAnDAL.Instance.LuuChiTietPhieuThucAn(MaPhieu, MaThucAn, DonViTinh, SoLuong);
        }
        public List<TongSoLuongThucAnDTO> GetListTongSoLuongThucAnTrongPhieuNhap()
        {
            return ChiTietPhieuThucAnDAL.Instance.GetListTongSoLuongThucAnTrongPhieuNhap();
        }
        public int GetTongSoLuongThucAnTrongPhieuNhap(string MaThucAn)
        {
            foreach (TongSoLuongThucAnDTO i in GetListTongSoLuongThucAnTrongPhieuNhap())
            {
                if (i.MaThucAn == MaThucAn)
                {
                    return i.TongSoLuongThucAn;
                }
            }
            return 0;
        }
    }
}
