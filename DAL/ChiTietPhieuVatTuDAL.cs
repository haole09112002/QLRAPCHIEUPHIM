using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietPhieuVatTuDAL
    {
        private static ChiTietPhieuVatTuDAL instance;

        public static ChiTietPhieuVatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuVatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietPhieuVatTuDAL()
        {

        }
        public List<ChiTietPhieuVatTuDTO> GetAllChiTietPhieuVatTu()
        {
            List<ChiTietPhieuVatTuDTO> data = new List<ChiTietPhieuVatTuDTO>();
            string query = "select * from CHI_TIET_PHIEU_VT";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietPhieuVatTuByDataRow(i));
            }
            return data;
        }
        public ChiTietPhieuVatTuDTO GetChiTietPhieuVatTuByDataRow(DataRow i)
        {
            return new ChiTietPhieuVatTuDTO()
            {
                MaPhieu = i["MaPhieu"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
            };
        }
        public void LuuChiTietPhieuVatTu(string MaPhieu, string MaVatTu, string DonViTinh, int SoLuong)
        {
            string query = "insert into CHI_TIET_PHIEU_VT values " +
                $"('{MaPhieu}','{MaVatTu}','{DonViTinh}',{SoLuong})";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public List<TongSoLuongVatTuDTO> GetListTongSoLuongVatTuTrongPhieuNhap()
        {
            List<TongSoLuongVatTuDTO> data = new List<TongSoLuongVatTuDTO>();
            string query = "select MaVatTu,SUM(Soluong) as 'TongSoLuong' from CHI_TIET_PHIEU_VT, PHIEU where MaLoaiPhieu = 'LP001' and CHI_TIET_PHIEU_VT.MaPhieu = PHIEU.MaPhieu Group By MaVatTu";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(new TongSoLuongVatTuDTO
                {
                    MaVatTu = i["MaVatTu"].ToString(),
                    TongSoLuongVatTu = Convert.ToInt32(i["TongSoLuong"].ToString())
                });
            }
            return data;
        }
    }
}
