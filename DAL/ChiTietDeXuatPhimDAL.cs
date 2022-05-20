using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class ChiTietDeXuatPhimDAL
    {
        private static ChiTietDeXuatPhimDAL instance;
        public static ChiTietDeXuatPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatPhimDAL()
        {

        }
        public List<ChiTietDeXuatPhimDTO> GetllDeXuatPhim()
        {
            List <ChiTietDeXuatPhimDTO > data = new List<ChiTietDeXuatPhimDTO> ();
           string query = "Select * from CHI_TIET_DE_XUAT_PHIM";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetDeXuatPhimByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatPhimDTO GetDeXuatPhimByDataRow(DataRow i)
        {
            return new ChiTietDeXuatPhimDTO
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                TinhTrang = i["TinhTrang"].ToString(),
                NoiDung = i["Noidung"].ToString(),
                DonViTinh =i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"])
            };
        }
        public List<ChiTietDeXuatPhimViewDTO> DanhSachPhimCanThemHopDong()
        {
            List<ChiTietDeXuatPhimViewDTO> data = new List<ChiTietDeXuatPhimViewDTO>();
            string query = "select ct.MaDeXuat, PHIM.MaPhim, PHIM.TenPhim, ct.SoLuong, ct.DonViTinh from CHI_TIET_DE_XUAT_PHIM ct inner join PHIM on PHIM.MaPhim = ct.MaPhim where ct.TinhTrang = '2'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetPhimCanTaoHopDongByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatPhimViewDTO GetPhimCanTaoHopDongByDataRow(DataRow i)
        {
            return new ChiTietDeXuatPhimViewDTO
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                TenPhim = i["TenPhim"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
            };
        }
        public void CapNhatTinhTrangDeXuat(string maPhim, string maDeXuat,string tinhTrang)
        {
            string query = string.Format("Update CHI_TIET_DE_XUAT_PHIM set TinhTrang = '{0}' where MaDeXuat ='{1}' and MaPhim = '{2}' ", tinhTrang, maDeXuat, maPhim); 
            DBHelper.Instance.ExcuteNonQuery(query);
        }
        public void LuuChiTietDeXuatPhim(string MaDeXuat, string MaPhim, string NoiDung, string DonViTinh, int SoLuong, string TinhTrang)
        {
            string query = "Insert into CHI_TIET_DE_XUAT_PHIM values" +
                $"('{MaDeXuat}','{MaPhim}',N'{NoiDung}',{SoLuong},'{DonViTinh}','{TinhTrang}')";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}
