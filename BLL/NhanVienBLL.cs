using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBLL();
                }
                return instance;
            }
            private set { }
        }

        public int KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            return NhanVienDAL.Instance.KiemTraDangNhap(tenTaiKhoan, MD5(matKhau));
        }
        public string MD5(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
        public NhanVienDTO GetNhanVienByMaNhanVien(string MaNhanVien)
        {
            foreach(NhanVienDTO i in NhanVienDAL.Instance.GetAllNhanVien())
            {
                if(i.MaNhanVien == MaNhanVien)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
