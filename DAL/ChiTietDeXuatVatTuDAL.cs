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
            string query = "select * from CHI_TIET_DE_XUAT_VT";
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
                TinhTrang = i["TinhTrang"].ToString(),
            };
        }
        public List<ChiTietDeXuatVatTuView> DanhSachVatTuCanThemHopDong()
        {
            List<ChiTietDeXuatVatTuView> data = new List<ChiTietDeXuatVatTuView>();
            string query = "select ct.MaDeXuat, VAT_TU.MaVatTu, VAT_TU.TenVatTu, ct.SoLuong, ct.DonViTinh from CHI_TIET_DE_XUAT_VT ct inner join VAT_TU on VAT_TU.MaVatTu = ct.MaVatTu where ct.TinhTrang = '2'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetVatTuCanTaoHopDongByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatVatTuView GetVatTuCanTaoHopDongByDataRow(DataRow i)
        {
            return new ChiTietDeXuatVatTuView
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaVatTu = i["MaVatTu"].ToString(),
                TenVatTu = i["TenVatTu"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
            };
        }
        public void CapNhatTinhTrangDeXuat(string maVatTu, string maDeXuat, string tinhTrang)
        {
            string query = string.Format("Update CHI_TIET_DE_XUAT_VT set TinhTrang = '{0}' where MaDeXuat ='{1}' and MaVatTu= '{2}' ", tinhTrang, maDeXuat, maVatTu);
            DBHelper.Instance.ExcuteNonQuery(query);
        }
        public void LuuChiTietDeXuatVatTu(string MaDeXuat, string MaVatTu, string NoiDung, string DonViTinh, int SoLuong, string TinhTrang)
        {
            string query = "Insert into CHI_TIET_DE_XUAT_VT values" +
                $"('{MaDeXuat}','{MaVatTu}',N'{NoiDung}',{SoLuong},'{DonViTinh}','{TinhTrang}')";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}
