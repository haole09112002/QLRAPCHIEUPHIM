using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThucAnDAL
    {
        private static ThucAnDAL instance;
        public static ThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        public List<ThucAnDTO> GetALLThucAn()
        {
            List<ThucAnDTO> listThucAn = new List<ThucAnDTO>();
            string query = "Select * from THUC_AN,CHI_TIET_KHO_THUC_AN where THUC_AN.MaThucAn = CHI_TIET_KHO_THUC_AN.MaThucAn";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listThucAn.Add(GetThucAnByDataRow(i));
            }
            return listThucAn;
        }
        public ThucAnDTO GetThucAnByDataRow(DataRow i)
        {
            return new ThucAnDTO
            {
                MaThucAn = i["MaThucAn"].ToString(),
                TenThucAn = i["TenThucAn"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuongSP"].ToString()),
            };
        }
    }
}
