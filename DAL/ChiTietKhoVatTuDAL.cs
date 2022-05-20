using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietKhoVatTuDAL
    {
        private static ChiTietKhoVatTuDAL instance;

        public static ChiTietKhoVatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoVatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoVatTuDAL()
        {

        }
        public List<ChiTietKhoVatTuDTO> GetAllChiTietKhoVatTu()
        {
            List<ChiTietKhoVatTuDTO> data = new List<ChiTietKhoVatTuDTO>();
            string query = "select * from CHI_TIET_KHO_VAT_TU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietKhoVatTuByDataRow(i));
            }
            return data;
        }
        public ChiTietKhoVatTuDTO GetChiTietKhoVatTuByDataRow(DataRow i)
        {
            return new ChiTietKhoVatTuDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
    }
}
