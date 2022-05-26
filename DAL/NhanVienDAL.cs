using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;

        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAL();
                }
                return instance;
            }
            private set { }
        }
        private NhanVienDAL()
        {

        }
        public List<NhanVienDTO> GetAllNhanVien()
        {
            List<NhanVienDTO> data = new List<NhanVienDTO>();
            string query = "select * from NHAN_VIEN";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetNhanVienByDataRow(i));
            }
            return data;
        }
        public NhanVienDTO GetNhanVienByDataRow(DataRow i)
        {
            return new NhanVienDTO()
            {
                MaNhanVien = i["MaNhanVien"].ToString(),
                TenNhanVien = i["TenNhanVien"].ToString(),
                NgaySinh = Convert.ToDateTime(i["NgaySinh"].ToString()),
                GioiTinh = Convert.ToBoolean(i["GioiTinh"].ToString()),
                DiaChi = i["DiaChi"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                CCCD1 = i["CCCD"].ToString(),
                TenTaiKhoan = i["TenTaiKhoan"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                Anh1 = null,
                MaChinhSach = i["MaChinhSach"].ToString(),
                MaChucVu = i["MaChucVu"].ToString(),
            };
        }
        public DataTable GetNVByMaChucVu(string maNhanVien, string maChucVu)
        {
            string query = "EXEC LayNhanVienByMaChucVu @maNhanVien , @maChucVu";
            object[] parameter = new object[]
            {
                maNhanVien, maChucVu
            };
            return DBHelper.Instance.ExcuteQuery(query, parameter);
        }
        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
           // nhanVien.Anh1 = null;
            string query = "EXEC themnhanvien @TenNhanVien , @NgaySinh , @GioiTinh , @DiaChi , @SoDienThoai , @CCCD , @TenTaiKhoan , @MatKhau , @MaChinhSach , @MaChucVu";
            object[] parameter = new object[]
            {
                nhanVien.TenNhanVien, nhanVien.NgaySinh, nhanVien.GioiTinh , nhanVien.DiaChi , nhanVien.SoDienThoai, nhanVien.CCCD1, nhanVien.TenTaiKhoan,nhanVien.MatKhau ,nhanVien.MaChinhSach,
                nhanVien.MaChucVu
            };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);

        }
        public void CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            string query = "EXEC CapNhatNhanVien @MaNhanVien , @TenNhanVien , @NgaySinh , @GioiTinh , @DiaChi , @SoDienThoai , @CCCD , @TenTaiKhoan , @MatKhau , @MaChinhSach , @MaChucVu";
            object[] parameter = new object[]
            {
                nhanVien.MaNhanVien,nhanVien.TenNhanVien, nhanVien.NgaySinh, nhanVien.GioiTinh , nhanVien.DiaChi , nhanVien.SoDienThoai, nhanVien.CCCD1, nhanVien.TenTaiKhoan,nhanVien.MatKhau ,nhanVien.MaChinhSach,
                nhanVien.MaChucVu
            };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
        public object KiemTraTenTK(NhanVienDTO nhanVien)
        {
            string query =String.Format("select  count(NHAN_VIEN.TenTaiKhoan) from NHAN_VIEN where TenTaiKhoan = '{0}'",nhanVien.TenTaiKhoan);
           
            return DBHelper.Instance.ExcuteScalar(query);
        }
        public object KiemTraSoDienThoai(NhanVienDTO nhanVien )
        {
            string query = String.Format("select  count(NHAN_VIEN.SoDienThoai) from NHAN_VIEN where SoDienThoai = '{0}'", nhanVien.SoDienThoai);
            return DBHelper.Instance.ExcuteScalar(query);
        }
        public object KiemTraCCCD(NhanVienDTO nhanVien)
        {
            string query = String.Format("select  count(NHAN_VIEN.CCCD) from NHAN_VIEN where CCCD = '{0}'", nhanVien.CCCD1);
            return DBHelper.Instance.ExcuteScalar(query);
        }
        public int KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {  
            string query = "EXEC KiemTraDangNhap @TenTaiKhoan , @MatKhau";
            object[] parameter = new object[] { tenTaiKhoan, matKhau };
            return Convert.ToInt32(DBHelper.Instance.ExcuteScalar(query,parameter));
        }
        public List<NhanVienDTO> TimTheoMa(string maNhanVien)
        {
            List<NhanVienDTO> data = new List<NhanVienDTO>();
            string query = $"SELECT * FROM NHAN_VIEN WHERE MaNhanVien LIKE '%{maNhanVien}%'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetNhanVienByDataRow(i));
            }
            return data;
        }
        public List<NhanVienDTO> TimTheoTen(string tenNhanVien)
        {
            List<NhanVienDTO> data = new List<NhanVienDTO>();
            string query = $"SELECT * FROM NHAN_VIEN WHERE TenNhanVien LIKE '%{tenNhanVien}%'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetNhanVienByDataRow(i));
            }
            return data;
        }
        public List<NhanVienDTO> TimTheoSDT(string soDienThoai)
        {
            List<NhanVienDTO> data = new List<NhanVienDTO>();
            string query = $"SELECT * FROM NHAN_VIEN WHERE SoDienThoai LIKE '%{soDienThoai}%'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetNhanVienByDataRow(i));
            }
            return data;
        }

    }
}
