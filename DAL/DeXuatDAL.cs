using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DeXuatDAL
    {
        private static DeXuatDAL instance;
        public static DeXuatDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatDAL();
                }
                return instance;
            }
            private set { }
        }
        private DeXuatDAL()
        {
            
        }
        public List<DeXuatDTO> GetAllDeXuat()
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            string query = "select * from DE_XUAT";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetDeXuatByDataRow(i));
            }
            return data;
        }

        public DeXuatDTO GetDeXuatByDataRow(DataRow i)
        {
            return new DeXuatDTO
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaNhanVien = i["MaNhanVien"].ToString(),
                NgayDeXuat = Convert.ToDateTime(i["NgayDeXuat"]),
                MaLoaiDeXuat = i["MaLoaiDeXuat"].ToString(),
                MaKho = i["MaKho"].ToString()
            };

        }
    }
}
