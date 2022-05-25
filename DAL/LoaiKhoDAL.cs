using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class LoaiKhoDAL
    {
        private static LoaiKhoDAL instance;

        public static LoaiKhoDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiKhoDAL();
                }
                return instance;
            }
            private set { }
        }
        private LoaiKhoDAL()
        {

        }
        public List<LoaiKhoDTO> GetAllLoaiKho()
        {
            List<LoaiKhoDTO> data = new List<LoaiKhoDTO>();
            string query = "select * from LOAI_KHO";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLoaiKhoByDataRow(i));
            }
            return data;
        }
        public LoaiKhoDTO GetLoaiKhoByDataRow(DataRow i)
        {
            return new LoaiKhoDTO()
            {
                MaLoaiKho = i["MaLoaiKho"].ToString(),
                TenLoaiKho = i["TenLoaiKho"].ToString(),
            };
        }
        public List<LoaiKhoDTO> TimTheoTenLoai(string tenLoaiKho)
        {
            List<LoaiKhoDTO> data = new List<LoaiKhoDTO>();
            string query = $"SELECT * FROM LOAI_KHO WHERE TenLoaiKho LIKE '%{tenLoaiKho}%'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLoaiKhoByDataRow(i));
            }
            return data;
        }
    }
}
