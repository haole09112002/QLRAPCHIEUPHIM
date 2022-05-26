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
            string query = "select * from HOP_DONG_PHIM where PhienBan = '0'";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetHopDongPhimByDataRow(i));
            }
            return data;
        }
        //dẽuat
      
        public HopDongPhimDTO GetHopDongPhimByDataRow(DataRow i)
        {
            return new HopDongPhimDTO()
            {
                MaHopDong = i["MaHopDong"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                PhienBan = i["PhienBan"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                GiaTien = Convert.ToDouble(i["GiaTien"]),
                NgayBatDauBanQuyen = Convert.ToDateTime(i["NgayBatDauBanQuyen"]),
                NgayKetThucBanQuyen = Convert.ToDateTime(i["NgayKetThucBanQuyen"]),
            };
        }
        public void ThemHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            hopDongPhim.PhienBan = "0";
            string query = "EXEC ThemHopDongPhim @MaHopDong , @MaPhim , @PhienBan , @NgayBatDauBanQuyen , @NgayKetThucBanQuyen , @Donvitinh , @SoLuong , @GiaTien";
            object[] parameter = new object[] {hopDongPhim.MaHopDong, hopDongPhim.MaPhim, hopDongPhim.PhienBan,
                hopDongPhim.NgayBatDauBanQuyen, hopDongPhim.NgayKetThucBanQuyen,
                hopDongPhim.DonViTinh, hopDongPhim.SoLuong, hopDongPhim.GiaTien};
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public void CapNhatHopDongPhim(HopDongPhimDTO hopDongPhim)
        {
            hopDongPhim.PhienBan = GetMaPhienBanLonNhat(hopDongPhim.MaHopDong, hopDongPhim.MaPhim);
            string query = "EXEC CapNhatHopDongPhim  @MaHopDong , @MaPhim , @PhienBan , @NgayBatDauBanQuyen , @NgayKetThucBanQuyen , @Donvitinh , @SoLuong , @GiaTien";
            object[] parameter = new object[] {hopDongPhim.MaHopDong, hopDongPhim.MaPhim, hopDongPhim.PhienBan,
                hopDongPhim.NgayBatDauBanQuyen, hopDongPhim.NgayKetThucBanQuyen,
                hopDongPhim.DonViTinh, hopDongPhim.SoLuong, hopDongPhim.GiaTien};
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public string GetMaPhienBanLonNhat(string maHopDong, string maPhim)
        {
            string query = "EXEC LayMaPhienBanHopDongPhimLonNhat @MaHopDong , @MaPhim";
            object[] parameter = new object[] { maHopDong, maPhim };
            return  DBHelper.Instance.ExcuteScalar(query, parameter).ToString();
        }
        public DataTable GetLichSuGiaHan(string maHopDong, string maPhim)
        {
            string query = string.Format("select hd.NgayBatDauBanQuyen, hd.NgayKetThucBanQuyen, hd.SoLuong, hd.GiaTien from HOP_DONG_PHIM hd where hd.MaPhim = '{0}' and hd.MaHopDong = '{1}' and hd.PhienBan!= '0' order by hd.PhienBan asc", maPhim, maHopDong);
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public List<TongSoLuongPhimDTO> GetTongSoLuongCuaTungPhim()
        {
            List<TongSoLuongPhimDTO> data = new List<TongSoLuongPhimDTO>();
            string query = "select MaPhim,SUM(Soluong) as 'TongSoLuong' from HOP_DONG_PHIM Group By MaPhim ";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(new TongSoLuongPhimDTO
                {
                    MaPhim = i["MaPhim"].ToString(),
                    TongSoLuongPhim = Convert.ToInt32(i["TongSoLuong"].ToString())
                });
            }
            return data;
        }
    }
}
