using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class ChinhSachDAL
    {
        private static ChinhSachDAL instance;

        public static ChinhSachDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChinhSachDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChinhSachDAL()
        {

        }
        public List<ChinhSachDTO> GetAllChinhSach()
        {
            List<ChinhSachDTO> data = new List<ChinhSachDTO>();
            string query = "select * from CHINH_SACH";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChinhSachByDataRow(i));
            }
            return data;
        }
        public ChinhSachDTO GetChinhSachByDataRow(DataRow i)
        {
            return new ChinhSachDTO()
            {
                MaChinhSach = i["MaChinhSach"].ToString(),
                TenChinhSach =i["TenChinhSach"].ToString(),
                BaoHiemXaHoi = i["BHXH"].ToString(),
                HeSoLuong = Convert.ToInt32(i["HeSoLuong"]),
                TienThuong = Convert.ToDouble(i["TienThuong"]),
            };
        }
    }
}
