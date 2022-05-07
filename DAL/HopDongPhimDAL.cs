using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HopDongPhimDAL
    {
        private static HopDongPhimDAL instance;

        public static HopDongPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private HopDongPhimDAL()
        {

        }
        public List<HopDongPhimDTO> GetAllHopDongPhim()
        {
            List<HopDongPhimDTO> data = new List<HopDongPhimDTO>();
            string query = "select * from HOP_DONG_PHIM";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetHopDongPhimByDataRow(i));
            }
            return data;
        }
        public HopDongPhimDTO GetHopDongPhimByDataRow(DataRow i)
        {
            return new HopDongPhimDTO()
            {
                //MaNhaCungCap = i["MaNhaCungCap"].ToString(),
                //MaPhim = i["MaPhim"].ToString(),
                //NgayKiKetHD =   Convert.ToDateTime( i["NgayKiKetHD"]),
                //SoLuong = Convert.ToInt32(i["SoLuong"]),
                //DonViTinh = i["DonViTinh"].ToString(),
                //GiaTien = Convert.ToDouble(i["GiaTien"]),
                //NgayBatDauBanQuyen = Convert.ToDateTime(i["NgayBatDauBanQuyen"]),
                //NgayKetThucBanQuyen = Convert.ToDateTime(i["NgayKetThucBanQuyen"]),
            };
        }
    }
}
