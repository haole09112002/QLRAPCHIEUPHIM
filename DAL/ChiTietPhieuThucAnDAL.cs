using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietPhieuThucAnDAL
    {
        private static ChiTietPhieuThucAnDAL instance;

        public static ChiTietPhieuThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuThucAnDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietPhieuThucAnDAL()
        {

        }
        public List<ChiTietPhieuThucAnDTO> GetAllChiTietPhieuThucAn()
        {
            List<ChiTietPhieuThucAnDTO> data = new List<ChiTietPhieuThucAnDTO>();
            string query = "select * from CHI_TIET_PHIEU_THUC_AN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietPhieuThucAnByDataRow(i));
            }
            return data;
        }
        public ChiTietPhieuThucAnDTO GetChiTietPhieuThucAnByDataRow(DataRow i)
        {
            return new ChiTietPhieuThucAnDTO()
            {
                MaPhieu = i["MaPhieu"].ToString(),
                MaThucAn = i["MaThucAn"].ToString(),
                DonViTinh = i["DonViTinh"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
            };
        }
        public void LuuChiTietPhieuThucAn(string MaPhieu, string MaThucAn, string DonViTinh, int SoLuong)
        {
            string query = "insert into CHI_TIET_PHIEU_THUC_AN values " +
                $"('{MaPhieu}','{MaThucAn}','{DonViTinh}',{SoLuong})";
            DBHelper.Instance.ExcuteQuery(query);
        }
        public List<TongSoLuongThucAnDTO> GetListTongSoLuongThucAnTrongPhieuNhap()
        {
            List<TongSoLuongThucAnDTO> data = new List<TongSoLuongThucAnDTO>();
            string query = "select MaThucAn,SUM(Soluong) as 'TongSoLuong' from CHI_TIET_PHIEU_THUC_AN, PHIEU where MaLoaiPhieu = 'LP001' and CHI_TIET_PHIEU_THUC_AN.MaPhieu = PHIEU.MaPhieu Group By MaThucAn";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(new TongSoLuongThucAnDTO
                {
                    MaThucAn = i["MaThucAn"].ToString(),
                    TongSoLuongThucAn = Convert.ToInt32(i["TongSoLuong"].ToString())
                });
            }
            return data;
        }
    }
}
