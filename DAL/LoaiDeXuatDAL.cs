using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class LoaiDeXuatDAL
    {
        private static LoaiDeXuatDAL instance;

        public static LoaiDeXuatDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiDeXuatDAL();
                }
                return instance;
            }
            private set { }
        }
        private LoaiDeXuatDAL()
        {

        }
        public List<LoaiDeXuatDTO> GetAllLoaiDeXuat()
        {
            List<LoaiDeXuatDTO> data = new List<LoaiDeXuatDTO>();
            string query = "select * from LOAI_DE_XUAT";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLoaiDeXuatByDataRow(i));
            }
            return data;
        }
        public LoaiDeXuatDTO GetLoaiDeXuatByDataRow(DataRow i)
        {
            return new LoaiDeXuatDTO()
            {
                MaLoaiDeXuat = i["MaLoaiDeXuat"].ToString(),
                TenLoaiDeXuat = i["TenLoaiDeXuat"].ToString(),
            };
        }
    }
}
