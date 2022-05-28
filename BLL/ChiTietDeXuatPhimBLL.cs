using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

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
            foreach (ChiTietDeXuatPhimDTO j in ChiTietDeXuatPhimDAL.Instance.GetAllDeXuatPhim())
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
            foreach (ChiTietDeXuatPhimDTO j in ChiTietDeXuatPhimDAL.Instance.GetAllDeXuatPhim())
            {
                if (j.MaDeXuat == MaDeXuat)
                {
                    data.Add(j);
                }
            }
            return data;
        }
        public List<string> GetListMaDeXuat()
        {
            List<string> data = new List<string>();
            foreach(ChiTietDeXuatPhimDTO i in ChiTietDeXuatPhimDAL.Instance.GetAllDeXuatPhim())
            {
                data.Add(i.MaDeXuat);
            }
            return data.Distinct().ToList();
        }
        public ChiTietDeXuatPhimViewDTO ConvertDTOToView(ChiTietDeXuatPhimDTO deXuat)
        {

            return new ChiTietDeXuatPhimViewDTO
            {
                MaDeXuat = deXuat.MaDeXuat,
                MaPhim = deXuat.MaPhim,
                DonViTinh = deXuat.DonViTinh,
                SoLuong = deXuat.SoLuong,
                TenPhim = PhimBLL.Instance.GetPhimByMaPhim(deXuat.MaPhim).TenPhim
     
            };
        }
        public List<ChiTietDeXuatPhimViewDTO> GetChiTietDeXuatPhimViewByTinhTrang(string tinhTrang)
        {

            var data = new List<ChiTietDeXuatPhimViewDTO>();
           foreach (var i in ChiTietDeXuatPhimDAL.Instance.GetAllDeXuatPhim().FindAll(i => i.TinhTrang == tinhTrang))
            {
                data.Add(ConvertDTOToView(i));
            }
            return data;
        }
        public List<ChiTietDeXuatPhimViewDTO> TimKiemChiTietDXPByMaDeXuat(string MaDeXuat,string tinhTrang)
        {
            List<ChiTietDeXuatPhimViewDTO> data = new List<ChiTietDeXuatPhimViewDTO>();
            foreach (ChiTietDeXuatPhimDTO j in ChiTietDeXuatPhimDAL.Instance.GetAllDeXuatPhim().FindAll(i => i.TinhTrang == tinhTrang))
            {
                if (j.MaDeXuat.ToLower().Contains(MaDeXuat.ToLower()))
                {
                    data.Add(ConvertDTOToView(j));
                }
            }
            return data;
        }
        public List<ChiTietDeXuatPhimViewDTO> TimKiemChiTietDXPByTenPhim(string tenPhim, string tinhTrang)
        {
            List<ChiTietDeXuatPhimViewDTO> data = new List<ChiTietDeXuatPhimViewDTO>();
            foreach (ChiTietDeXuatPhimDTO j in ChiTietDeXuatPhimDAL.Instance.GetAllDeXuatPhim().FindAll(i => i.TinhTrang == tinhTrang))
            {
                if (ConvertDTOToView(j).TenPhim.ToLower().Contains(tenPhim.ToLower()))
                {
                    data.Add(ConvertDTOToView(j));
                }
            }
            return data;
        }
    }
}
