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
        public ChiTietKhoVatTuDTO ConvertChiTietKhoVatTuViewToDTO(ChiTietKhoVatTuView vtView)
        {
            return new ChiTietKhoVatTuDTO
            {
                MaKho = vtView.MaKho,
                MaVatTu = vtView.MaVatTu,
                DonViTinh = vtView.DonViTinh,
                SoLuongSP = vtView.SoLuongSP
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
        public void AddUpDateChiTietKhoVatTu(List<ChiTietKhoVatTuView> dsCTKhoVT)
        {
           
            foreach(ChiTietKhoVatTuView k in dsCTKhoVT)
            {
                bool add = true;
                foreach (ChiTietKhoVatTuView i in GetAllChiTietKhoVatTuView())
                {
                    if (i.MaVatTu == k.MaVatTu && i.MaKho == k.MaKho)
                        add = false;
                }
                
                if (add)
                    ChiTietKhoVatTuDAL.Instance.ThemChiTietKhoVatTu(ConvertChiTietKhoVatTuViewToDTO(k));
                else
                    ChiTietKhoVatTuDAL.Instance.CapNhatChiTietKhoVatTu(ConvertChiTietKhoVatTuViewToDTO(k));
            }
            
        }
        public void XoaChiTietKhoVatTu(List<ChiTietKhoVatTuView> dsCTKhoVT)
        {
            var ds = GetAllChiTietKhoVatTuView();
            foreach(var i in dsCTKhoVT)
            {
                int index = ds.FindIndex(x => x.MaVatTu == i.MaVatTu && x.MaKho == i.MaKho);
                if ( index >= 0)
                    ds.RemoveAt(index);
            }
            if(ds.Count > 0)
            foreach(var i in ds)
            {
                ChiTietKhoVatTuDAL.Instance.XoaChiTietKhoVatTu(ConvertChiTietKhoVatTuViewToDTO(i));
            }
           
        }
    }
}
