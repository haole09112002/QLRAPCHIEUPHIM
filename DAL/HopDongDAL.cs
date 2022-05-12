using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HopDongDAL
    {
        private static HopDongDAL instance;
        public static HopDongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongDAL();
                }
                return instance;
            }
            private set { }
        }
        private HopDongDAL()
        {

        }
        public List<HopDongDTO> GetAllHopDong()
        {
            List<HopDongDTO> data = new List<HopDongDTO>();
            string query = "select * from HOP_DONG";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetHopDongByDataRow(i));
            }
            return data;
        }
        public HopDongDTO GetHopDongByDataRow(DataRow i)
        {
            return new HopDongDTO()
            { 
                MaHopDong = i["MaHopDong"].ToString(),
                TenHopDong = i["TenHopDong"].ToString(),
                NgayKiKetHD = Convert.ToDateTime(i["NgayKiKetHD"]),
                MaNhaCungCap = i["MaNhaCungCap"].ToString(),
                MaLoaiHopDong = i["MaLoaiHopDong"].ToString()
            };
        }
        public void ThemHopDong(HopDongDTO hopDong)
        {
            string query = "EXEC ThemHopDong @TenHopDong , @MaNhaCungCap , @NgayKiKetHD , @MaLoaiHopDong";
            object[] parameter = {hopDong.TenHopDong, hopDong.MaNhaCungCap, hopDong.NgayKiKetHD, hopDong.MaLoaiHopDong };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public string GetMaHopDongMoiNhat()
        {
            string query = "SELECT MAX(MaHopDong) as MaHopDong FROM HOP_DONG";
            return (string)DBHelper.Instance.ExcuteScalar(query);
        }
    

    }
}
