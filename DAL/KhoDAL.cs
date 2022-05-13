using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class KhoDAL
    {
        private static KhoDAL instance;

        public static KhoDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoDAL();
                }
                return instance;
            }
            private set { }
        }
        private KhoDAL()
        {

        }
        public List<KhoDTO> GetAllKho()
        {
            List<KhoDTO> data = new List<KhoDTO>();
            string query = "select * from KHO";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetKhoByDataRow(i));
            }
            return data;
        }
        public KhoDTO GetKhoByDataRow(DataRow i)
        {
            return new KhoDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaLoaiKho = i["MaLoaiKho"].ToString(),
                TenKho = i["TenKho"].ToString(),
            };
        }
    }
}
