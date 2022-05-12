using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class LoaiHopDongDAL
    {
        private static LoaiHopDongDAL instance;
        public static LoaiHopDongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiHopDongDAL();
                }
                return instance;
            }
            private set { }
        }
        private LoaiHopDongDAL()
        {

        }
        public List<LoaiHopDongDTO> GetAllLoaiHopDong()
        {
            List<LoaiHopDongDTO> ds = new List<LoaiHopDongDTO>();
            string query = "select * from LOAI_HOP_DONG";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                ds.Add(GetLoaiHopDongByDataRow(i));
            }
            return ds;
        }
        public LoaiHopDongDTO GetLoaiHopDongByDataRow(DataRow i)
        {
            return new LoaiHopDongDTO
            {
                MaLoaiHopDong = i["MaLoaiHopDong"].ToString(),
                TenLoaiHopDong = i["TenLoaiHopDong"].ToString()
            };

        }
    }
}
