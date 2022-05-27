using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietKhoThucAnDAL
    {
        private static ChiTietKhoThucAnDAL instance;

        public static ChiTietKhoThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoThucAnDAL()
        {

        }
        public List<ChiTietKhoThucAnDTO> GetAllChiTietKhoThucAn()
        {
            List<ChiTietKhoThucAnDTO> data = new List<ChiTietKhoThucAnDTO>();
            string query = "select * from CHI_TIET_KHO_THUC_AN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietKhoThucAnByDataRow(i));
            }
            return data;
        }
        public ChiTietKhoThucAnDTO GetChiTietKhoThucAnByDataRow(DataRow i)
        {
            return new ChiTietKhoThucAnDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaThucAn = i["MaThucAn"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
        public void CapNhatChiTietKhoThucAn(string MaKho, string MaThucAn, int SoLuongSP, string DonViTinh)
        {
            string query = "update CHI_TIET_KHO_THUC_AN set " +
                $"SoLuongSP = {SoLuongSP}, DonViTinh = '{DonViTinh}'" +
                $"where MaKho = '{MaKho}' and MaThucAn = '{MaThucAn}'";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public void LuuChiTietKhoThucAn(string MaKho, string MaThucAn, string DonViTinh, int SoLuongSP)
        {
            string query = "insert into CHI_TIET_KHO_THUC_AN values" +
                $"('{MaKho}','{MaThucAn}','{DonViTinh}',{SoLuongSP})";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}
