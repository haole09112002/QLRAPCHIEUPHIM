using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietKhoPhimDAL
    {
        private static ChiTietKhoPhimDAL instance;

        public static ChiTietKhoPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoPhimDAL()
        {

        }
        public List<ChiTietKhoPhimDTO> GetAllChiTietKhoPhim()
        {
            List<ChiTietKhoPhimDTO> data = new List<ChiTietKhoPhimDTO>();
            string query = "select * from CHI_TIET_KHO_PHIM";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietKhoPhimByDataRow(i));
            }
            return data;
        }
        public ChiTietKhoPhimDTO GetChiTietKhoPhimByDataRow(DataRow i)
        {
            return new ChiTietKhoPhimDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
    }
}
