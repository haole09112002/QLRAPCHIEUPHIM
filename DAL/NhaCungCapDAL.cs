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
        public DataTable GetSPByMaNhaCungCap(string maNhaCungCap, string maLoaiNhaCungCap)
        {
            string query = "EXEC LaySanPhamByMaNhaCungCap @MaNhaCungCap , @MaLoaiNhaCungCap";
            object[] parameter = new object[]
            {
                maNhaCungCap, maLoaiNhaCungCap
            };
            return DBHelper.Instance.ExcuteQuery(query, parameter);
        }
        

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
