using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietDeXuatVatTuDAL
    {
        private static ChiTietDeXuatVatTuDAL instance;

        public static ChiTietDeXuatVatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatVatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatVatTuDAL()
        {

        }
        public List<ChiTietDeXuatVatTuDTO> GetAllChiTietDeXuatVatTu()
        {
            List<ChiTietDeXuatVatTuDTO> data = new List<ChiTietDeXuatVatTuDTO>();
            string query = "select * from CHI_TIET_DE_XUAT_VAT_TU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietDeXuatVatTuByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatVatTuDTO GetChiTietDeXuatVatTuByDataRow(DataRow i)
        {
            return new ChiTietDeXuatVatTuDTO()
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                NoiDung = i["NoiDung"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                TinhTrang = Convert.ToBoolean(i["TinhTrang"].ToString()),
            };
        }
    }
}
