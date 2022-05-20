using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietKhoVatTuBLL
    {
        private static ChiTietKhoVatTuBLL instance;

        public static ChiTietKhoVatTuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoVatTuBLL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoVatTuBLL()
        {

        }
        public List<ChiTietKhoVatTuDTO> GetAllChiTietKhoVatTu()
        {
           return ChiTietKhoVatTuDAL.Instance.GetAllChiTietKhoVatTu();
        }

        public ChiTietKhoVatTuView ConvertChiTietKhoVatTuDTOToView(ChiTietKhoVatTuDTO vt)
        {
            string tenVatTu = "";
            foreach(VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.MaVatTu == vt.MaVatTu)
                    tenVatTu = i.TenVatTu;
            }
            return new ChiTietKhoVatTuView
            {
                MaKho = vt.MaKho,
                MaVatTu = vt.MaVatTu,
                TenVatTu = tenVatTu,
                DonViTinh = vt.DonViTinh,
                SoLuongSP = vt.SoLuongSP
            };
        }
        public List<ChiTietKhoVatTuView> GetAllChiTietKhoVatTuView()
        {
            List<ChiTietKhoVatTuView> data = new List<ChiTietKhoVatTuView>();
            foreach(ChiTietKhoVatTuDTO i in GetAllChiTietKhoVatTu())
                data.Add(ConvertChiTietKhoVatTuDTOToView(i));
            return data;
        }
        public List<string> GetAllDonViTinh()
        {
            List<string> data = new List<string>();
            foreach (ChiTietKhoVatTuDTO i in GetAllChiTietKhoVatTu())
                data.Add(i.DonViTinh);
            return data.Distinct().ToList();
        }

        public void KiemTraThongTinChiTietVatTuTrongKho(string maVatTu, int soLuong, string DonViTinh)
        {

        }
    }
}
