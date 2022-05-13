using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietDeXuatThucAnDAL
    {
        private static ChiTietDeXuatThucAnDAL instance;

        public static ChiTietDeXuatThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatThucAnDAL()
        {

        }
        public List<ChiTietDeXuatThucAnDTO> GetAllChiTietDeXuatThucAn()
        {
            List<ChiTietDeXuatThucAnDTO> data = new List<ChiTietDeXuatThucAnDTO>();
            string query = "select * from CHI_TIET_DE_XUAT_THUC_AN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietDeXuatThucAnByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatThucAnDTO GetChiTietDeXuatThucAnByDataRow(DataRow i)
        {
            return new ChiTietDeXuatThucAnDTO()
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaThucAn= i["MaThucAn"].ToString(),
                NoiDung = i["NoiDung"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                TinhTrang = Convert.ToBoolean(i["TinhTrang"].ToString()),
            };
        }
    }
}
