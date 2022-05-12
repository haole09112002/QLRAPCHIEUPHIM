using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DeXuatPhimDAL
    {
        private static DeXuatPhimDAL instance;
        public static DeXuatPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private DeXuatPhimDAL()
        {

        }
        public List<DeXuatPhimDTO> GetllDeXuatPhim()
        {
            List <DeXuatPhimDTO > data = new List<DeXuatPhimDTO> ();
           string query = "Select * from CHI_TIET_DE_XUAT_PHIM";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetDeXuatPhimByDataRow(i));
            }
            return data;
        }
        public DeXuatPhimDTO GetDeXuatPhimByDataRow(DataRow i)
        {
            return new DeXuatPhimDTO
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                TinhTrang = i["TinhTrang"].ToString(),
                Noidung = i["Noidung"].ToString(),
                DonViTinh =i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"])
            };
        }
        public List<PhimCanTaoHopDongDTO> DanhSachPhimCanThemHopDong()
        {
            List<PhimCanTaoHopDongDTO> data = new List<PhimCanTaoHopDongDTO>();
            string query = "select ct.MaDeXuat, PHIM.MaPhim, PHIM.TenPhim, ct.SoLuong, ct.DonViTinh from CHI_TIET_DE_XUAT_PHIM ct inner join PHIM on PHIM.MaPhim = ct.MaPhim where ct.TinhTrang = '2'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetPhimCanTaoHopDongByDataRow(i));
            }
            return data;
        }
        public PhimCanTaoHopDongDTO GetPhimCanTaoHopDongByDataRow(DataRow i)
        {
            return new PhimCanTaoHopDongDTO
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
    }
}
