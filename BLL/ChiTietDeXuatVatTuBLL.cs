using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ChiTietDeXuatVatTuBLL
    {
        private static ChiTietDeXuatVatTuBLL instance;

        public static ChiTietDeXuatVatTuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatVatTuBLL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatVatTuBLL()
        {

        }

        public void CapNhatTinhTrangDeXuat(string maVatTu, string maDeXuat, string tinhTrang)
        {

            ChiTietDeXuatVatTuDAL.Instance.CapNhatTinhTrangDeXuat(maVatTu, maDeXuat, tinhTrang);


        }
        //0: ko chap nhan. //1: đg chờ duyetj, //2 Đã duyệt chờ tạo hóa đơn, //3 đã tạo hóa đơn
        public ChiTietDeXuatVatTuDTO GetChiTietDeXuatVatTu(string maDeXuat, string maVatTu)
        {
            foreach (ChiTietDeXuatVatTuDTO j in ChiTietDeXuatVatTuDAL.Instance.GetAllChiTietDeXuatVatTu())
            {
                if (j.MaVatTu == maVatTu && j.MaDeXuat == maDeXuat)
                {
                    return j;
                }
            }
            return null;
        }

        public void LuuChiTietDeXuatVatTu(string MaDeXuat, string MaVatTu, string NoiDung, string DonViTinh, int SoLuong, string TinhTrang)
        {
            ChiTietDeXuatVatTuDAL.Instance.LuuChiTietDeXuatVatTu(MaDeXuat, MaVatTu, NoiDung, DonViTinh, SoLuong, TinhTrang);
        }
        public List<ChiTietDeXuatVatTuDTO> GetChiTietDXVTByMaDeXuat(string MaDeXuat)
        {
            List<ChiTietDeXuatVatTuDTO> data = new List<ChiTietDeXuatVatTuDTO>();
            foreach (ChiTietDeXuatVatTuDTO j in ChiTietDeXuatVatTuDAL.Instance.GetAllChiTietDeXuatVatTu())
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
