using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HopDongThucAnDAL
    {
        private static HopDongThucAnDAL instance;

        public static HopDongThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HopDongThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        private HopDongThucAnDAL()
        {

        }
        public List<HopDongThucAnDTO> GetAllHopDongThucAn()
        {
            List<HopDongThucAnDTO> data = new List<HopDongThucAnDTO>();
            string query = "select * from HOP_DONG_THUC_AN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetHopDongThucAnByDataRow(i));
            }
            return data;
        }
        public HopDongThucAnDTO GetHopDongThucAnByDataRow(DataRow i)
        {
            return new HopDongThucAnDTO()
            {
                MaHopDong = i["MaHopDong"].ToString(),
                MaThucAn = i["MaThucAn"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                GiaTien = Convert.ToDouble(i["GiaTien"]),
            };
        }
        public void ThemHopDongThucAn(HopDongThucAnDTO hdTA)
        {

            string query = "EXEC ThemHopDongThucAn @MaHopDong , @MaThucAn , @Donvitinh , @SoLuong , @GiaTien";
            object[] parameter = new object[] {hdTA.MaHopDong, hdTA.MaThucAn,
                hdTA.DonViTinh, hdTA.SoLuong, hdTA.GiaTien};
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public List<TongSoLuongThucAnDTO> GetTongSoLuongCuaTungThucAn()
        {
            List<TongSoLuongThucAnDTO> data = new List<TongSoLuongThucAnDTO>();
            string query = "select MaThucAn,SUM(Soluong) as 'TongSoLuong' from HOP_DONG_THUC_AN Group By MaThucAn ";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(new TongSoLuongThucAnDTO
                {
                    MaThucAn = i["MaThucAn"].ToString(),
                    TongSoLuongThucAn = Convert.ToInt32(i["TongSoLuong"].ToString())
                });
            }
            return data;
        }
    }
}
