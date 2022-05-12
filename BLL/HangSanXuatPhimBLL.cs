using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangSanXuatPhimBLL
    {
        public static HangSanXuatPhimBLL instance;
        public static HangSanXuatPhimBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangSanXuatPhimBLL();
                return instance;
            }
            private set { }
        }
        public string GetTenHSXPbyMaHSXP(string MaHangSanXuatPhim)
        {
            foreach (HangSanXuatPhimDTO i in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
            {
                if(i.MaHangSanXuatPhim == MaHangSanXuatPhim)
                {
                    return i.TenHangSanXuatPhim;
                }
            }
            return null;
        }
    }
}
