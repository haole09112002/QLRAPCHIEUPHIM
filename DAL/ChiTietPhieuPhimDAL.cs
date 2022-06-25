using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietPhieuPhimDAL
    {
        private static ChiTietPhieuPhimDAL instance;

        public static ChiTietPhieuPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietPhieuPhimDAL()
        {

        }
        public List<ChiTietPhieuPhimDTO> GetAllChiTietPhieuPhim()
        {
            List<ChiTietPhieuPhimDTO> data = new List<ChiTietPhieuPhimDTO>();
            string query = "select * from CHI_TIET_PHIEU_PHIM";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietPhieuPhimByDataRow(i));
            }
            return data;
        }
        public ChiTietPhieuPhimDTO GetChiTietPhieuPhimByDataRow(DataRow i)
        {
            return new ChiTietPhieuPhimDTO()
            {
                MaPhieu = i["MaPhieu"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
            };
        }
        public void LuuChiTietPhieuPhim(string MaPhieu, string MaPhim, string DonViTinh, int SoLuong)
        {
            string query = "insert into CHI_TIET_PHIEU_PHIM values " +
                $"('{MaPhieu}','{MaPhim}','{DonViTinh}',{SoLuong})";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public List<TongSoLuongPhimDTO> GetListTongSoLuongPhimTrongPhieuNhap()
        {
            List<TongSoLuongPhimDTO> data = new List<TongSoLuongPhimDTO>();
            string query = "select MaPhim,SUM(SoLuong) as 'TongSoLuong' from CHI_TIET_PHIEU_PHIM, PHIEU where MaLoaiPhieu = 'LP001' and CHI_TIET_PHIEU_PHIM.MaPhieu = PHIEU.MaPhieu Group By MaPhim";
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
    }
}
