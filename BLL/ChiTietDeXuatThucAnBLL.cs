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

        public ChiTietDeXuatThucAnViewDTO ConvertDTOToView(ChiTietDeXuatThucAnDTO deXuat)
        {

            return new ChiTietDeXuatThucAnViewDTO
            {
                MaDeXuat = deXuat.MaDeXuat,
                MaThucAn = deXuat.MaThucAn,
                DonViTinh = deXuat.DonViTinh,
                SoLuong = deXuat.SoLuong,
                TenThucAn = ThucAnBLL.Instance.GetThucAnByMaThucAn(deXuat.MaThucAn).TenThucAn

            };
        }
        public List<ChiTietDeXuatThucAnViewDTO> GetChiTietDeXuatThucAnViewByTinhTrang(string tinhTrang)
        {

            var data = new List<ChiTietDeXuatThucAnViewDTO>();
            foreach (var i in ChiTietDeXuatThucAnDAL.Instance.GetAllChiTietDeXuatThucAn().FindAll(i => i.TinhTrang == tinhTrang))
            {
                data.Add(ConvertDTOToView(i));
            }
            return data;
        }
        public List<ChiTietDeXuatThucAnViewDTO> TimKiemChiTietDXTAByMaDeXuat(string MaDeXuat,string tinhTrang)
        {
            List<ChiTietDeXuatThucAnViewDTO> data = new List<ChiTietDeXuatThucAnViewDTO>();
            foreach (ChiTietDeXuatThucAnDTO j in ChiTietDeXuatThucAnDAL.Instance.GetAllChiTietDeXuatThucAn().FindAll(i => i.TinhTrang == tinhTrang))
            {
                if (j.MaDeXuat.ToLower().Contains(MaDeXuat.ToLower()))
                {
                    data.Add(ConvertDTOToView(j));
                }
            }
            return data;
        }
        public List<ChiTietDeXuatThucAnViewDTO> TimKiemChiTietDXPByTenThucAn(string tenThucAn, string tinhTrang)
        {
            List<ChiTietDeXuatThucAnViewDTO> data = new List<ChiTietDeXuatThucAnViewDTO>();
            foreach (ChiTietDeXuatThucAnDTO j in ChiTietDeXuatThucAnDAL.Instance.GetAllChiTietDeXuatThucAn().FindAll(i => i.TinhTrang == tinhTrang))
            {
                if (ConvertDTOToView(j).TenThucAn.ToLower().Contains(tenThucAn.ToLower()))
                {
                    data.Add(ConvertDTOToView(j));
                }
            }
            return data;
        }
    }
}
