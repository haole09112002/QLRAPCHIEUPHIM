using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HangSanXuatPhimDAL
    {
        public static HangSanXuatPhimDAL instance;
        public static HangSanXuatPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HangSanXuatPhimDAL();
                }
                return instance;
            }
            set { }
        }
        public List<HangSanXuatPhimDTO> GetAllHangSanXuatPhim()
        {
            List<HangSanXuatPhimDTO> listHangSanXuatPhim = new List<HangSanXuatPhimDTO>();
            string query = "Select * from HANG_SAN_XUAT_PHIM";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listHangSanXuatPhim.Add(new HangSanXuatPhimDTO
                {
                    MaHangSanXuatPhim = i["MaHangSanXuatPhim"].ToString(),
                    TenHangSanXuatPhim = i["TenHangSanXuatPhim"].ToString(),
                    Link = i["Link"].ToString()
                });
            }
            return listHangSanXuatPhim;
        }
    }
}
