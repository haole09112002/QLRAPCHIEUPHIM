using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongChieuDAL
    {
        public static PhongChieuDAL instance;
        public static PhongChieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongChieuDAL();
                }
                return instance;
            }
            set { }
        }
        public List<PhongChieuDTO> GetAllPhongChieu()
        {
            List<PhongChieuDTO> listPhongChieu = new List<PhongChieuDTO>();
            string query = "Select * from PHONG_CHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listPhongChieu.Add(new PhongChieuDTO
                {
                    MaPhongChieu = i["MaPhongChieu"].ToString(),
                    TenPhong = i["TenPhong"].ToString(),
                    TinhTrangPhong = Convert.ToBoolean(i["TinhTrangPhong"].ToString())
                });
            }
            return listPhongChieu;
        }
    }
}
