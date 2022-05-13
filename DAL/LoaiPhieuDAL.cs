using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class LoaiPhieuDAL
    {
        private static LoaiPhieuDAL instance;

        public static LoaiPhieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiPhieuDAL();
                }
                return instance;
            }
            private set { }
        }
        private LoaiPhieuDAL()
        {

        }
        public List<LoaiPhieuDTO> GetAllLoaiPhieu()
        {
            List<LoaiPhieuDTO> data = new List<LoaiPhieuDTO>();
            string query = "select * from lOAI_PHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLoaiPhieuByDataRow(i));
            }
            return data;
        }
        public LoaiPhieuDTO GetLoaiPhieuByDataRow(DataRow i)
        {
            return new LoaiPhieuDTO()
            {
                MaLoaiPhieu = i["MaLoaiPhieu"].ToString(),
                TenLoaiPhieu = i["TenLoaiPhieu"].ToString(),
            };
        }
    }
}
