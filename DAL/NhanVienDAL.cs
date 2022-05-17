using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Security.Cryptography;

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
        public int KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
           
            string query = "EXEC KiemTraDangNhap @TenTaiKhoan , @MatKhau";
            object[] parameter = new object[] { tenTaiKhoan, matKhau };
            return Convert.ToInt32(DBHelper.Instance.ExcuteScalar(query,parameter));
        }
    }
}
