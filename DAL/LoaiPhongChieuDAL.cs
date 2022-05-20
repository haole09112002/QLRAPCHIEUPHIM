using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class LoaiPhongChieuDAL
    {
        private static LoaiPhongChieuDAL instance;
        public static LoaiPhongChieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiPhongChieuDAL();
                }
                return instance;
            }
            private set { }
        }
        private LoaiPhongChieuDAL()
        {

        }

        public List<LoaiPhongChieuDTO> GetAllLoaiPhongChieu()
        {
            List<LoaiPhongChieuDTO> data = new List<LoaiPhongChieuDTO>();
            string query = "Select * from LOAI_PHONG_CHIEU";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLoaiPhongChieuByDataRow(i));
            }
            return data;
        }

        public LoaiPhongChieuDTO GetLoaiPhongChieuByDataRow(DataRow i)
        {
            return new LoaiPhongChieuDTO
            {
                MaLoaiPhongChieu = i["MaLoaiPhongChieu"].ToString(),
                TenLoaiPhongChieu = i["TenLoaiPhongChieu"].ToString()
            };
        }
    }
}
