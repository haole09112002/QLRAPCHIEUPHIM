using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietKhoThucAnDAL
    {
        private static ChiTietKhoThucAnDAL instance;

        public static ChiTietKhoThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoThucAnDAL()
        {

        }
        public List<ChiTietKhoThucAnDTO> GetAllChiTietKhoThucAn()
        {
            List<ChiTietKhoThucAnDTO> data = new List<ChiTietKhoThucAnDTO>();
            string query = "select * from CHI_TIET_KHO_THUC_AN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietKhoThucAnByDataRow(i));
            }
            return data;
        }
        public ChiTietKhoThucAnDTO GetChiTietKhoThucAnByDataRow(DataRow i)
        {
            return new ChiTietKhoThucAnDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaThucAn = i["MaThucAn"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
    }
}
