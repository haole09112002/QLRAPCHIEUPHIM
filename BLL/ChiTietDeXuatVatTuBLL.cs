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
        public ChiTietDeXuatVatTuView ConvertDTOToView(ChiTietDeXuatVatTuDTO deXuat)
        {

            return new ChiTietDeXuatVatTuView
            {
                MaDeXuat = deXuat.MaDeXuat,
                MaVatTu = deXuat.MaVatTu,
                DonViTinh = deXuat.DonViTinh,
                SoLuong = deXuat.SoLuong,
                TenVatTu = VatTuBLL.Instance.GetVatTuByMaVatTu(deXuat.MaVatTu).TenVatTu

            };
        }
        public List<ChiTietDeXuatVatTuView> GetChiTietDeXuatVatTuViewByTinhTrang(string tinhTrang)
        {

            var data = new List<ChiTietDeXuatVatTuView>();
            foreach (var i in ChiTietDeXuatVatTuDAL.Instance.GetAllChiTietDeXuatVatTu().FindAll(i => i.TinhTrang == tinhTrang))
            {
                data.Add(ConvertDTOToView(i));
            }
            return data;
        }
        public List<ChiTietDeXuatVatTuView> TimKiemChiTietDXVTByMaDeXuat(string MaDeXuat,string tinhTrang)
        {
            List<ChiTietDeXuatVatTuView> data = new List<ChiTietDeXuatVatTuView>();
            foreach (ChiTietDeXuatVatTuDTO j in ChiTietDeXuatVatTuDAL.Instance.GetAllChiTietDeXuatVatTu().FindAll(i => i.TinhTrang == tinhTrang))
            {
                if (j.MaDeXuat.ToLower().Contains(MaDeXuat.ToLower()))
                {
                    data.Add(ConvertDTOToView(j));
                }
            }
            return data;
        }
        public List<ChiTietDeXuatVatTuView> TimKiemChiTietDXPByTenVatTu(string tenVatTu, string tinhTrang)
        {
            List<ChiTietDeXuatVatTuView> data = new List<ChiTietDeXuatVatTuView>();
            foreach (ChiTietDeXuatVatTuDTO j in ChiTietDeXuatVatTuDAL.Instance.GetAllChiTietDeXuatVatTu().FindAll(i => i.TinhTrang == tinhTrang))
            {
                if (ConvertDTOToView(j).TenVatTu.ToLower().Contains(tenVatTu.ToLower()))
                {
                    data.Add(ConvertDTOToView(j));
                }
            }
            return data;
        }
    }
}
