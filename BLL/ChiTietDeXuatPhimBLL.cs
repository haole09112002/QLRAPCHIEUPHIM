using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ChiTietDeXuatPhimBLL
    {
        private static ChiTietDeXuatPhimBLL instance;

        public static ChiTietDeXuatPhimBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatPhimBLL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatPhimBLL()
        {

        }

        public void CapNhatTinhTrangDeXuat(string maPhim, string maDeXuat, string tinhTrang)
        {

            ChiTietDeXuatPhimDAL.Instance.CapNhatTinhTrangDeXuat(maPhim, maDeXuat, tinhTrang);


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

        public void LuuChiTietDeXuatPhim(string MaDeXuat, string MaPhim, string NoiDung, string DonViTinh, int SoLuong, string TinhTrang)
        {
            ChiTietDeXuatPhimDAL.Instance.LuuChiTietDeXuatPhim(MaDeXuat, MaPhim, NoiDung, DonViTinh, SoLuong, TinhTrang);
        }
        public List<ChiTietDeXuatPhimDTO> GetChiTietDXPByMaDeXuat(string MaDeXuat)
        {
            List<ChiTietDeXuatPhimDTO> data = new List<ChiTietDeXuatPhimDTO>();
            foreach (ChiTietDeXuatPhimDTO j in ChiTietDeXuatPhimDAL.Instance.GetllDeXuatPhim())
            {
                if (j.MaDeXuat == MaDeXuat)
                {
                    data.Add(j);
                }
            }
            return data;
        }
    }
}
