using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class DeXuatPhimBLL
    {
        private static DeXuatPhimBLL instance;

        public static DeXuatPhimBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatPhimBLL();
                }
                return instance;
            }
            private set { }
        }
        private DeXuatPhimBLL()
        {

        }

        public void CapNhatTinhTrangDeXuat(string maPhim, string maDeXuat, string tinhTrang)
        {
             ChiTietDeXuatPhimDAL.Instance.CapNhatTinhTrangDeXuat(maPhim, maDeXuat,tinhTrang);
        }
        //0: ko chap nhan. //1: đg chờ duyetj, //2 Đã duyệt chờ tạo hóa đơn, //3 đã tạo hóa đơn
        public ChiTietDeXuatPhimDTO GetChiTietDeXuatPhim(string maDeXuat, string maPhim)
        {
            foreach (ChiTietDeXuatPhimDTO j in ChiTietDeXuatPhimDAL.Instance.GetllDeXuatPhim())
            {
                if (j.MaPhim == maPhim && j.MaDeXuat == maDeXuat)
                {
                    return j;
                }
            }
            return null;
        }
    }
}
