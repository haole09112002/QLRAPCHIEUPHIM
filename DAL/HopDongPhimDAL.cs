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
                MaHopDong = i["MaHopDong"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                GiaTien = Convert.ToDouble(i["GiaTien"]),
                NgayBatDauBanQuyen = Convert.ToDateTime(i["NgayBatDauBanQuyen"]),
                NgayKetThucBanQuyen = Convert.ToDateTime(i["NgayKetThucBanQuyen"]),
            };
        }
        public void ThemHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            string query = "EXEC ThemHopDong @MaHopDong , @MaPhim , @NgayBatDauBanQuyen , @NgayKetThucBanQuyen , @Donvitinh , @SoLuong , @GiaTien";
            object[] parameter = new object[] {hopDongPhim.MaHopDong, hopDongPhim.MaPhim,
                hopDongPhim.NgayBatDauBanQuyen, hopDongPhim.NgayKetThucBanQuyen,
                hopDongPhim.DonViTinh, hopDongPhim.SoLuong, hopDongPhim.GiaTien};
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public void CapNhatHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            string query = "EXEC CapNhatHopDong @MaHopDong , @MaPhim , @NgayBatDauBanQuyen , @NgayKetThucBanQuyen , @Donvitinh , @SoLuong , @GiaTien";
            object[] parameter = new object[] {hopDongPhim.MaHopDong, hopDongPhim.MaPhim,
                hopDongPhim.NgayBatDauBanQuyen, hopDongPhim.NgayKetThucBanQuyen,
                hopDongPhim.DonViTinh, hopDongPhim.SoLuong, hopDongPhim.GiaTien};
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
    }
}
