using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiPhimDAL
    {
        public static TheLoaiPhimDAL instance;
        public static TheLoaiPhimDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TheLoaiPhimDAL();
                }
                return instance;
            }
            set { }
        }
        public List<TheLoaiPhimDTO> GetAllTheLoaiPhim()
        {
            List<TheLoaiPhimDTO> listTheLoaiPhim = new List<TheLoaiPhimDTO>();
            string query = "Select * from THE_LOAI_PHIM";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listTheLoaiPhim.Add(new TheLoaiPhimDTO
                {
                    MaTheLoaiPhim = i["MaTheLoaiPhim"].ToString(),
                    TenTheLoaiPhim = i["TenTheLoaiPhim"].ToString()
                });
            }
            return listTheLoaiPhim;
        }
    }
}
