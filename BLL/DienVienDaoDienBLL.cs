using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DienVienDaoDienBLL
    {
        public static DienVienDaoDienBLL instance;
        public static DienVienDaoDienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DienVienDaoDienBLL();
                return instance;
            }
            private set { }
        }
        public List<DienVienDaoDienDTO> GetAllDienVienDaoDien()
        {
            List<DienVienDaoDienDTO> data = new List<DienVienDaoDienDTO>();
            foreach (DienVienDaoDienDTO i in DienVienDaoDienDAL.Instance.GetAllDienVienDaoDien())
            {
                data.Add(i);
            }
            return data;
        }
        public DienVienDaoDienDTO GetDVDDByMaDVDD(string MaDienVienDaoDien)
        {
            DienVienDaoDienDTO data = new DienVienDaoDienDTO();
            foreach(DienVienDaoDienDTO i in DienVienDaoDienDAL.Instance.GetAllDienVienDaoDien())
            {
                if(i.MaDienVienDaoDien == MaDienVienDaoDien)
                {
                    data = i;
                }
            }
            return data;
        }
        public string GetTenDVDDByMaDVDD(string MaDienVienDaoDien)
        {
            return GetDVDDByMaDVDD(MaDienVienDaoDien).TenDienVienDaoDien;
        }
        public void LuuDienVienDaoDien(string TenDienVienDaoDien, string Link)
        {
            DienVienDaoDienDAL.Instance.LuuDienVienDaoDien(TenDienVienDaoDien,Link);
        }
    }
}
