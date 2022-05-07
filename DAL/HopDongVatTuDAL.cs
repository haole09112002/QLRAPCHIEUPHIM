using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    internal class HopDongVatTuDAL
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
        public List<HopDongVatTuDTO> GetAllHopDongPhim()
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
                //MaNhaCungCap = i["MaNhaCungCap"].ToString(),
                //MaVatTu = i["MaVatTu"].ToString(),
                //NgayKiKetHD = Convert.ToDateTime(i["NgayKiKetHD"]),
                //SoLuong = Convert.ToInt32(i["SoLuong"]),
                //DonViTinh = i["DonViTinh"].ToString(),
                //GiaTien = Convert.ToDouble(i["GiaTien"]),
            };
        }
    }
}
