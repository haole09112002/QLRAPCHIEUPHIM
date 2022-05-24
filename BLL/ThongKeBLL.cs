using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {

        private static ThongKeBLL instance;
        public static ThongKeBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeBLL();
                }
                return instance;
            }
            private set { }
        }

        private ThongKeBLL()
        { }
        // 1 tot, 2 hong, 3 bao tri
        public int SoLuongPhongChieu(int maTinhTrang = 0)
        {
            if(maTinhTrang != 0)
                return PhongChieuBLL.Instance.GetAllPhongChieu().FindAll( i => i.MaTinhTrang == maTinhTrang).Count();
            else
            {
                return PhongChieuBLL.Instance.GetAllPhongChieu().Count();
            }    
        }
        public int SoLuongNhanVien(string maChucVu = "")
        {
            if (maChucVu != "")
                return NhanVienBLL.Instance.GetAllNhanVien().FindAll(i => i.MaChucVu == maChucVu).Count();
            else
            {
                return NhanVienBLL.Instance.GetAllNhanVien().Count();
            }
        }


    }
}
