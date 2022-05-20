using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class TinhTrangPhongChieuDAL
    {
        private static TinhTrangPhongChieuDAL instance;
        public static TinhTrangPhongChieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinhTrangPhongChieuDAL();
                }
                return instance;
            }
            private set { }
        }
        private TinhTrangPhongChieuDAL()
        {

        }

        public List<TinhTrangPhongChieuDTO> GetAllTinhTrangPhongChieu()
        {
            List<TinhTrangPhongChieuDTO> data = new List<TinhTrangPhongChieuDTO>();
            string query = "Select * from TINH_TRANG_PHONG_CHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetTinhTrangByDataRow(i));
            }
            return data;
        }

        public TinhTrangPhongChieuDTO GetTinhTrangByDataRow(DataRow i)
        {
            return new TinhTrangPhongChieuDTO
            {
                MaTinhTrang = i["MaTinhTrang"].ToString(),
                TenTinhTrang = i["TenTinhTrang"].ToString()
            };
        }
    }
}
