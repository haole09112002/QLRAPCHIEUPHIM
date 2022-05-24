using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietPhieuVatTuDAL
    {
        private static ChiTietPhieuVatTuDAL instance;

        public static ChiTietPhieuVatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuVatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietPhieuVatTuDAL()
        {

        }
        public List<ChiTietPhieuVatTuDTO> GetAllChiTietPhieuVatTu()
        {
            List<ChiTietPhieuVatTuDTO> data = new List<ChiTietPhieuVatTuDTO>();
            string query = "select * from CHI_TIET_PHIEU_VT";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietPhieuVatTuByDataRow(i));
            }
            return data;
        }
        public ChiTietPhieuVatTuDTO GetChiTietPhieuVatTuByDataRow(DataRow i)
        {
            return new ChiTietPhieuVatTuDTO()
            {
                MaPhieu = i["MaPhieu"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
            };
        }
    }
}
