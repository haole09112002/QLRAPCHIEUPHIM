using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietPhongChieuDAL
    {
        private static ChiTietPhongChieuDAL instance;

        public static ChiTietPhongChieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhongChieuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietPhongChieuDAL()
        {

        }
        public List<ChiTietPhongChieuDTO> GetAllChiTietPhongChieu()
        {
            List<ChiTietPhongChieuDTO> data = new List<ChiTietPhongChieuDTO>();
            string query = "select * from CHI_TIET_PHONG_CHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietPhongChieuByDataRow(i));
            }
            return data;
        }
        public ChiTietPhongChieuDTO GetChiTietPhongChieuByDataRow(DataRow i)
        {
            return new ChiTietPhongChieuDTO()
            {
                MaPhongChieu = i["MaPhongChieu"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
    }
}
