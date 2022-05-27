using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HopDongVatTuDAL
    {
        private static HopDongVatTuDAL instance;

        public static HopDongVatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongVatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        private HopDongVatTuDAL()
        {

        }
        public List<HopDongVatTuDTO> GetAllHopDongVatTu()
        {
            List<HopDongVatTuDTO> data = new List<HopDongVatTuDTO>();
            string query = "select * from HOP_DONG_VAT_TU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetHopDongVatTuByDataRow(i));
            }
            return data;
        }
        public HopDongVatTuDTO GetHopDongVatTuByDataRow(DataRow i)
        {
            return new HopDongVatTuDTO()
            {
                MaHopDong = i["MaHopDong"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                GiaTien = Convert.ToDouble(i["GiaTien"]),
            };
        }
        public void ThemHopDongVatTu(HopDongVatTuDTO hdVT)
        {

            string query = "EXEC ThemHopDongVatTu @MaHopDong , @MaVatTu , @Donvitinh , @SoLuong , @GiaTien";
            object[] parameter = new object[] {hdVT.MaHopDong, hdVT.MaVatTu,
                hdVT.DonViTinh, hdVT.SoLuong, hdVT.GiaTien};
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public List<TongSoLuongVatTuDTO> GetTongSoLuongCuaTungVatTu()
        {
            List<TongSoLuongVatTuDTO> data = new List<TongSoLuongVatTuDTO>();
            string query = "select MaVatTu,SUM(Soluong) as 'TongSoLuong' from HOP_DONG_VAT_TU Group By MaVatTu ";
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
