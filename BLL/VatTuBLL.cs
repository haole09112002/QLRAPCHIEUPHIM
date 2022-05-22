using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class VatTuBLL
    {
        private static VatTuBLL instance;
        public static VatTuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VatTuBLL();
                }
                return instance;
            }
            set { }
        }
        public List<VatTuDTO> GetAllVatTu()
        {

            return VatTuDAL.Instance.GetALLVatTu();
           
        }
        public List<VatTuViewDTO> GetVatTuViews(string txt)
        {
            List<VatTuViewDTO> data = new List<VatTuViewDTO>();
            foreach (VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.TenVatTu.Contains(txt))
                {
                    data.Add(new VatTuViewDTO
                    {
                        MaVatTu = i.MaVatTu,
                        TenVatTu = i.TenVatTu,
                        DonViTinh = i.DonViTinh,
                        SoLuong = i.SoLuong,
                    }); 
                }
            }
            return data;
        }
        public VatTuDTO GetVatTuByMaVatTu(string MaVatTu)
        {
            VatTuDTO data = new VatTuDTO();
            foreach (VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.MaVatTu == MaVatTu)
                {
                    data.MaVatTu = i.MaVatTu;
                    data.TenVatTu = i.TenVatTu;
                    data.DonViTinh = i.DonViTinh;
                    data.SoLuong = i.SoLuong;
                }
            }
            return data;
        }
    }
}
