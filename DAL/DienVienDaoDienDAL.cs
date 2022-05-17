using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DienVienDaoDienDAL
    {
        private static DienVienDaoDienDAL instance;
        public static DienVienDaoDienDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DienVienDaoDienDAL();
                }
                return instance;
            }
            set { }
        }
        public List<DienVienDaoDienDTO> GetAllDienVienDaoDien()
        {
            List<DienVienDaoDienDTO> listDienVienDaoDien = new List<DienVienDaoDienDTO>();
            string query = "Select * from DIEN_VIEN_DAO_DIEN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listDienVienDaoDien.Add(new DienVienDaoDienDTO
                {
                    MaDienVienDaoDien = i["MaDienVienDaoDien"].ToString(),
                    TenDienVienDaoDien = i["TenDienVienDaoDien"].ToString(),
                    Link = i["Link"].ToString()
                });
            }
            return listDienVienDaoDien;
        }
        public void LuuDienVienDaoDien(string TenDienVienDAoDien,string Link)
        {
            string query = "Insert into DIEN_VIEN_DAO_DIEN (TenDienVienDaoDIen,Link) values" +
                $"(N'{TenDienVienDAoDien}','{Link}')";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}
