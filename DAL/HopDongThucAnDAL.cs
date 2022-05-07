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
        public List<HopDongThucAnDTO> GetAllHopDongPhim()
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
                //MaNhaCungCap = i["MaNhaCungCap"].ToString(),
                //MaThucAn = i["MaThucAn"].ToString(),
                //NgayKiKetHD = Convert.ToDateTime(i["NgayKiKetHD"]),
                //SoLuong = Convert.ToInt32(i["SoLuong"]),
                //DonViTinh = i["DonViTinh"].ToString(),
                //GiaTien = Convert.ToDouble(i["GiaTien"]),
            };
        }
    }
}
