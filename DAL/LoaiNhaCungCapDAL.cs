using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class LoaiNhaCungCapDAL
    {

        private static LoaiNhaCungCapDAL instance;

        public static LoaiNhaCungCapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiNhaCungCapDAL();
                }
                return instance;
            }
            private set { }
        }

        public List<LoaiNhaCungCapDTO> GetAllLoaiNhaCungCap()
        {
            List<LoaiNhaCungCapDTO> dsLoaiNhaCungCap = new List<LoaiNhaCungCapDTO>();
            string query = "select * from LOAI_NHA_CUNG_CAP";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                dsLoaiNhaCungCap.Add(GetLoaiNhaCungCapByDataRow(i));
            }
            return dsLoaiNhaCungCap;
        }
        public LoaiNhaCungCapDTO GetLoaiNhaCungCapByDataRow(DataRow i)
        {
            return new LoaiNhaCungCapDTO
            { 
                MaLoaiNhaCungCap = i["MaLoaiNCC"].ToString(),
                TenLoaiNhaCungCap = i["TenLoaiNCC"].ToString()
            };

        }

    }
}
