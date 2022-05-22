using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ChiTietDeXuatThucAnBLL
    {
        private static ChiTietDeXuatThucAnBLL instance;

        public static ChiTietDeXuatThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietDeXuatThucAnBLL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietDeXuatThucAnBLL()
        {

        }

        public void CapNhatTinhTrangDeXuat(string maThucAn, string maDeXuat, string tinhTrang)
        {

            ChiTietDeXuatThucAnDAL.Instance.CapNhatTinhTrangDeXuat(maThucAn, maDeXuat, tinhTrang);


        }
        //0: ko chap nhan. //1: đg chờ duyetj, //2 Đã duyệt chờ tạo hóa đơn, //3 đã tạo hóa đơn
        public ChiTietDeXuatThucAnDTO GetChiTietDeXuatThucAn(string maDeXuat, string maThucAn)
        {
            foreach (ChiTietDeXuatThucAnDTO j in ChiTietDeXuatThucAnDAL.Instance.GetAllChiTietDeXuatThucAn())
            {
                if (j.MaThucAn == maThucAn && j.MaDeXuat == maDeXuat)
                {
                    return j;
                }
            }
            return null;
        }

        public void LuuChiTietDeXuatThucAn(string MaDeXuat, string MaThucAn, string NoiDung, string DonViTinh, int SoLuong, string TinhTrang)
        {
            ChiTietDeXuatThucAnDAL.Instance.LuuChiTietDeXuatThucAn(MaDeXuat, MaThucAn, NoiDung, DonViTinh, SoLuong, TinhTrang);
        }
        public List<ChiTietDeXuatThucAnDTO> GetChiTietDXTAByMaDeXuat(string MaDeXuat) 
        {
            List<ChiTietDeXuatThucAnDTO> data = new List<ChiTietDeXuatThucAnDTO>();
            foreach (ChiTietDeXuatThucAnDTO j in ChiTietDeXuatThucAnDAL.Instance.GetAllChiTietDeXuatThucAn())
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
