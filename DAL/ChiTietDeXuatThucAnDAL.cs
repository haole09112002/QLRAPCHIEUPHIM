using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietDeXuatThucAnDAL
    {
        private static ChiTietDeXuatThucAnDAL instance;

        public static ChiTietDeXuatThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatThucAnDAL()
        {

        }
        public List<ChiTietDeXuatThucAnDTO> GetAllChiTietDeXuatThucAn()
        {
            List<ChiTietDeXuatThucAnDTO> data = new List<ChiTietDeXuatThucAnDTO>();
            string query = "select * from CHI_TIET_DE_XUAT_THUC_AN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietDeXuatThucAnByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatThucAnDTO GetChiTietDeXuatThucAnByDataRow(DataRow i)
        {
            return new ChiTietDeXuatThucAnDTO()
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaThucAn= i["MaThucAn"].ToString(),
                NoiDung = i["NoiDung"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
                TinhTrang = Convert.ToBoolean(i["TinhTrang"].ToString()),
            };
        }
        public List<ChiTietDeXuatThucAnViewDTO> DanhSachThucAnCanThemHopDong()
        {
            List<ChiTietDeXuatThucAnViewDTO> data = new List<ChiTietDeXuatThucAnViewDTO>();
            string query = "select ct.MaDeXuat, THUC_AN.MaThucAn, THUC_AN.TenThucAn, ct.SoLuong, ct.DonViTinh from CHI_TIET_DE_XUAT_TA ct inner join THUC_AN on THUC_AN.MaThucAn = ct.MaThucAn where ct.TinhTrang = '2'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetThucAnCanTaoHopDongByDataRow(i));
            }
            return data;
        }
        public ChiTietDeXuatThucAnViewDTO GetThucAnCanTaoHopDongByDataRow(DataRow i)
        {
            return new ChiTietDeXuatThucAnViewDTO
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaThucAn= i["MaThucAn"].ToString(),
                TenThucAn = i["TenThucAn"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                DonViTinh = i["DonViTinh"].ToString(),
            };
        }
        public void CapNhatTinhTrangDeXuat(string maThucAn, string maDeXuat, string tinhTrang)
        {
            string query = string.Format("Update CHI_TIET_DE_XUAT_TA set TinhTrang = '{0}' where MaDeXuat ='{1}' and MaThucAn= '{2}' ", tinhTrang, maDeXuat, maThucAn);
            DBHelper.Instance.ExcuteNonQuery(query);
        }
    }
}
