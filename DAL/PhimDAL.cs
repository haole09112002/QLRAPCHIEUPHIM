using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhimDAL
    {
        private static PhimDAL instance;
        public static PhimDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhimDAL();
                return instance;
            }
            set { }
        }
        public List<PhimDTO> GetALLPhim()
        {
            List<PhimDTO> listPhim = new List<PhimDTO>();
            string query = "Select * from PHIM,THE_LOAI_PHIM where PHIM.MaTheLoai = THE_LOAI_PHIM.MaTheLoaiPhim";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listPhim.Add(GetPhimByDataRow(i));
            }
            return listPhim;
        }
       public PhimDTO GetPhimByDataRow(DataRow i)
        {
            return new PhimDTO
            {
                MaPhim = i["MaPhim"].ToString(),
                TenPhim = i["TenPhim"].ToString(),
                AnhPhim = i["AnhPhim"].ToString(),
                ThoiLuong = Convert.ToInt32(i["ThoiLuong"].ToString()),
                QuocGia = i["QuocGia"].ToString(),
                NamSanXuat = Convert.ToDateTime(i["NamSanXuat"].ToString()),
                TenHangPhim = i["TenHangPhim"].ToString(),
                DoTuoiXem = Convert.ToInt32(i["DoTuoiXem"].ToString()),
                TheLoai = i["TenTheLoaiPhim"].ToString(),
                NoiDung = i["NoiDung"].ToString(),
                DienVienChinh = i["DienVienCHinh"].ToString(),
                DienVienPhu = i["DienVienPhu"].ToString(),
                DaoDien = i["DaoDien"].ToString()
            };
        }
    }
}
