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
                TenKho = i["TenKho"].ToString()
            };
        }
        public LoaiKhoDTO GetLoaiKhoByDataRow(DataRow i)
        {
            return new LoaiKhoDTO()
            {
                MaLoaiKho = i["MaLoaiKho"].ToString(),
                TenLoaiKho = i["TenLoaiKho"].ToString(),
            };
        }
        public List<KhoDTO> TimTheoTenKho(string tenKho)
        {
            List<KhoDTO> data = new List<KhoDTO>();
            string query = $"SELECT * FROM KHO WHERE TenKho LIKE '%{tenKho}%'";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetKhoByDataRow(i));
            }
            return data;
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
