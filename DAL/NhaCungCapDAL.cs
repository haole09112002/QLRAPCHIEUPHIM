using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class NhaCungCapDAL
    {
        private static NhaCungCapDAL instance;

        public static NhaCungCapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAL();
                }
                return instance;
            }
            private set { }
        }
        
        public List<NhaCungCapDTO> GetAllNhaCungCap()
        {
            List<NhaCungCapDTO> dsNhaCungCap = new List<NhaCungCapDTO>();   
            string query = "select * from NHA_CUNG_CAP";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                dsNhaCungCap.Add(GetNhaCungCapByDataRow(i));
            }
            return dsNhaCungCap;
        }
        public NhaCungCapDTO GetNhaCungCapByDataRow(DataRow i)
        {
            return new NhaCungCapDTO
            {
                MaNhaCungCap = i["MaNhaCungCap"].ToString(),
                TenNhaCungCap = i["TenNhaCungCap"].ToString(),
                MaSoThue = i["MaSoThue"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                Email = i["Email"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                TenGiamDoc = i["TenGiamDoc"].ToString(),
                MaLoaiNhaCungCap = i["MaLoaiNCC"].ToString()
            };
        }
        //public DataTable GetSanPhamByMaNhaCungCap(string maNCC )
        //{
        //    string str = "", query = "";
        //    string sql = "select NHA_CUNG_CAP.MaLoaiNCC from NHA_CUNG_CAP where NHA_CUNG_CAP.MaNhaCungCap = '"+maNCC+"'";
        //    foreach(DataRow row in DBHelper.Instance.ExcuteQuery(sql).Rows)
        //    {
        //         str = row["MaLoaiNCC"].ToString();
        //        break;
        //    }
        //    if(str == "LNCC01")
        //    {
        //        query = "select PHIM.MaPhim ,PHIM.TenPhim from PHIM, HOP_DONG_PHIM where HOP_DONG_PHIM.MaNhaCungCap = '" + maNCC + "' and HOP_DONG_PHIM.MaPhim = PHIM.MaPhim";
        //    }
        //    if(str == "LNCC02")
        //        query = "select ct.MaVatTu ,VAT_TU.TenVatTu from VAT_TU, CHI_TIET_CUNG_CAP_VAT_TU ct where ct.MaNhaCungCap = '" + maNCC + "' and ct.MaVatTu =VAT_TU.MaVatTu";
        //    if (str == "LNCC03")
        //        query = "select ct.MaThucAn ,THUC_AN.TenThucAn from THUC_AN,  CHI_TIET_CUNG_CAP_THUC_AN ct where ct.MaNhaCungCap = '" + maNCC + "' and ct.MaThucAn =THUC_AN.MaThucAn";
        //    return DBHelper.Instance.ExcuteQuery(query);
        //}

        public void ThemNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            string query = "EXEC ThemNhaCungCap @TenNhaCungCap , @MaSoThue , @DiaChi , @Email , @SoDienThoai , @TenGiamDoc , @MaLoaiNCC";
            object[] parameter = new object[]
            {
                nhaCungCap.TenNhaCungCap, nhaCungCap.MaSoThue, nhaCungCap.DiaChi, nhaCungCap.Email, nhaCungCap.SoDienThoai, nhaCungCap.TenGiamDoc,
                nhaCungCap.MaLoaiNhaCungCap
            };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
            
        }
        public void CapNhatNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            string query = "EXEC CapNhatNhaCungCap @MaNhaCungCap , @TenNhaCungCap , @MaSoThue , @DiaChi , @Email , @SoDienThoai , @TenGiamDoc , @MaLoaiNCC";
            object[] parameter = new object[]
            {
                nhaCungCap.MaNhaCungCap,nhaCungCap.TenNhaCungCap, nhaCungCap.MaSoThue, nhaCungCap.DiaChi, nhaCungCap.Email, nhaCungCap.SoDienThoai, nhaCungCap.TenGiamDoc,
                nhaCungCap.MaLoaiNhaCungCap
            };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public object KiemTraMaSoThue(NhaCungCapDTO nhaCungCap)
        {
            string query = "select  count(NHA_CUNG_CAP.MaSoThue) from NHA_CUNG_CAP where MaSoThue = @MaSoThue";
            object[] parameter = new object[] {nhaCungCap.MaSoThue};
            return  DBHelper.Instance.ExcuteScalar(query, parameter);
        }
        public object KiemTraSoDienThoai(NhaCungCapDTO nhaCungCap)
        {
            string query = "select  count(NHA_CUNG_CAP.SoDienThoai) from NHA_CUNG_CAP where MaSoThue = @MaSoThue";
            object[] parameter = new object[] { nhaCungCap.MaSoThue };
            return DBHelper.Instance.ExcuteScalar(query, parameter);
        }
        public object KiemTraEmail(NhaCungCapDTO nhaCungCap)
        {
            string query = "select  count(NHA_CUNG_CAP.Email) from NHA_CUNG_CAP where MaSoThue = @MaSoThue";
            object[] parameter = new object[] { nhaCungCap.MaSoThue };
            return DBHelper.Instance.ExcuteScalar(query, parameter);
        }
    }
}
