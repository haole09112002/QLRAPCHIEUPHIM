using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChucVuDAL
    {
        private static ChucVuDAL instance;

        public static ChucVuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChucVuDAL()
        {

        }
        public List<ChucVuDTO> GetAllChucVu()
        {
            List<ChucVuDTO> data = new List<ChucVuDTO>();
            string query = "select * from CHUC_VU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChucVuByDataRow(i));
            }
            return data;
        }
        public ChucVuDTO GetChucVuByDataRow(DataRow i)
        {
            return new ChucVuDTO()
            {
                MaChucVu = i["MaChucVu"].ToString(),
                TenChucVu = i["TenChucVu"].ToString(),
            };
        }
    }
}
