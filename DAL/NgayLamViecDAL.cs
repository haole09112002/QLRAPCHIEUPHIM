using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NgayLamViecDAL
    {
        private static NgayLamViecDAL instance;

        public static NgayLamViecDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NgayLamViecDAL();
                }
                return instance;
            }
            private set { }
        }
        private NgayLamViecDAL()
        {

        }
        public List<NgayLamViecDTO> GetAllNgayLamViec()
        {
            List<NgayLamViecDTO> data = new List<NgayLamViecDTO>();
            string query = "select * from NGAY_LAM_VIEC";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetNgayLamViecByDataRow(i));
            }
            return data;
        }
        public NgayLamViecDTO GetNgayLamViecByDataRow(DataRow i)
        {
            return new NgayLamViecDTO()
            {
                NgayLamViec = Convert.ToDateTime(i["NgayLamViec"].ToString()),
            };
        }
    }
}
