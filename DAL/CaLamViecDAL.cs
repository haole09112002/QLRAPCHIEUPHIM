using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CaLamViecDAL
    {
        private static CaLamViecDAL instance;

        public static CaLamViecDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CaLamViecDAL();
                }
                return instance;
            }
            private set { }
        }
        private CaLamViecDAL()
        {

        }
        public List<CaLamViecDTO> GetAllCaLamViec()
        {
            List<CaLamViecDTO> data = new List<CaLamViecDTO>();
            string query = "select * from CA_LAM_VIEC";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetCaLamViecByDataRow(i));
            }
            return data;
        }
        public CaLamViecDTO GetCaLamViecByDataRow(DataRow i)
        {
            return new CaLamViecDTO()
            {
                MaCa = i["MaCa"].ToString(),
                TenCa = i["TenCa"].ToString(),
                GioBatDau = Convert.ToDateTime(i["GioBatDau"].ToString()),
                GioKetThuc = Convert.ToDateTime(i["GioKetThuc"].ToString()),
            };
        }
    }
}
