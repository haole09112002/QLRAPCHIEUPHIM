using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietKhoPhimDAL
    {
        private static ChiTietKhoPhimDAL instance;

        public static ChiTietKhoPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoPhimDAL()
        {

        }
        public List<ChiTietKhoPhimDTO> GetAllChiTietKhoPhim()
        {
            List<ChiTietKhoPhimDTO> data = new List<ChiTietKhoPhimDTO>();
            string query = "select * from CHI_TIET_KHO_PHIM";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietKhoPhimByDataRow(i));
            }
            return data;
        }
        public ChiTietKhoPhimDTO GetChiTietKhoPhimByDataRow(DataRow i)
        {
            return new ChiTietKhoPhimDTO()
            {
                MaKho = i["MaKho"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuongSP = Convert.ToInt32(i["SoLuongSP"]),
            };
        }
        public void LuuChiTietKhoPhim(string MaKho, string MaPhim, string DonViTinh, int SoLuongSP)
        {
            string query = "insert into CHI_TIET_KHO_PHIM values" +
                $"('{MaKho}','{MaPhim}','{DonViTinh}',{SoLuongSP})";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public void CapNhatChiTietKhoPhim(string MaKho, string MaPhim, int SoLuongSP, string DonViTinh)
        {
            string query = "update CHI_TIET_KHO_PHIM set " +
                $"SoLuongSP = {SoLuongSP}, DonViTinh = '{DonViTinh}'" +
                $"where MaKho = '{MaKho}' and MaPhim = '{MaPhim}'";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public List<TongSoLuongPhimDTO> GetTongSoLuongCuaTungPhim()
        {
            List<TongSoLuongPhimDTO> data = new List<TongSoLuongPhimDTO>();
            string query = "select MaPhim,SUM(SoluongSP) as 'TongSoLuong' from CHI_TIET_KHO_PHIM Group By MaPhim ";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(new TongSoLuongPhimDTO
                {
                    MaPhim = i["MaPhim"].ToString(),
                    TongSoLuongPhim = Convert.ToInt32(i["TongSoLuong"].ToString())
                });
            }
            return data;
        }
        public void XoaPhimTrongKho(string MaPhim, string MaKho)
        {
            string query = $"delete from CHI_TIET_KHO_PHIM where MaPhim = '{MaPhim}' and MaKho = '{MaKho}'";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}
