using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietKhoVatTuDAL
    {
        private static ChiTietKhoVatTuDAL instance;

        public static ChiTietKhoVatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoVatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoVatTuDAL()
        {

        }
        public List<ChiTietKhoVatTuDTO> GetAllChiTietKhoVatTu()
        {
            List<ChiTietKhoVatTuDTO> data = new List<ChiTietKhoVatTuDTO>();
            string query = "select * from CHI_TIET_KHO_VT";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietKhoVatTuByDataRow(i));
            }
            return data;
        }
        public ChiTietKhoVatTuDTO GetChiTietKhoVatTuByDataRow(DataRow i)
        {
            return new ChiTietKhoVatTuDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
        public void ThemChiTietKhoVatTu(ChiTietKhoVatTuDTO kho)
        {
            string query = "EXEC ThemChiTietKhoVatTu @MaKho , @MaVatTu , @DonViTinh , @SoLuongSP";
            object[] parameter = new object[] { kho.MaKho, kho.MaVatTu, kho.DonViTinh, kho.SoLuongSP };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public void CapNhatChiTietKhoVatTu(ChiTietKhoVatTuDTO kho)
        {
            string query = "EXEC CapNhatChiTietKhoVatTu @MaKho , @MaVatTu , @DonViTinh , @SoLuongSP";
            object[] parameter = new object[] { kho.MaKho, kho.MaVatTu, kho.DonViTinh, kho.SoLuongSP };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public void XoaChiTietKhoVatTu(ChiTietKhoVatTuDTO kho)
        {
            string query = $"Delete from CHI_TIET_KHO_VT where MaKho= '{kho.MaKho}' and MaVatTu = '{kho.MaVatTu}'";
            DBHelper.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatChiTietKhoVatTu(string MaKho, string MaVatTu, int SoLuongSP, string DonViTinh)
        {
            string query = "update CHI_TIET_KHO_VT set " +
                $"SoLuongSP = {SoLuongSP}, DonViTinh = '{DonViTinh}'" +
                $"where MaKho = '{MaKho}' and MaVatTu = '{MaVatTu}'";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public void LuuChiTietKhoVatTu(string MaKho, string MaVatTu, string DonViTinh, int SoLuongSP)
        {
            string query = "insert into CHI_TIET_KHO_VT values" +
                $"('{MaKho}','{MaVatTu}','{DonViTinh}',{SoLuongSP})";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}

