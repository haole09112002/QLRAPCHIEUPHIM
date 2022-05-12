using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietDienVienDaoDienPhimDAL
    {
        public static ChiTietDienVienDaoDienPhimDAL instance;
        public static ChiTietDienVienDaoDienPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDienVienDaoDienPhimDAL();
                }
                return instance;
            }
            set { }
        }
        public List<ChiTietDienVienDaoDienPhimDTO> GetAllChiTietDienVienDaoDien()
        {
            List<ChiTietDienVienDaoDienPhimDTO> listChiTietDienVienDaoDien = new List<ChiTietDienVienDaoDienPhimDTO>();
            string query = "Select * from CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listChiTietDienVienDaoDien.Add(new ChiTietDienVienDaoDienPhimDTO
                {
                    MaPhim = i["MaPhim"].ToString(),
                    MaDienVienDaoDien = i["MaDienVienDaoDien"].ToString(),
                    VaiTro = i["VaiTro"].ToString()
                });
            }
            return listChiTietDienVienDaoDien;
        }
    }
}
