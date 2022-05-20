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
        public delegate bool Compare(object a, object b);
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
        public List<VatTuViewDTO> GetVatTuViews(string txt)
        {
            List<VatTuViewDTO> data = new List<VatTuViewDTO>();
            foreach (VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                double GiaTienVatTu = 0;
                if (i.TenVatTu.Contains(txt))
                {
                    foreach (HopDongVatTuDTO k in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
                    {
                        if (k.MaVatTu == i.MaVatTu)
                        {
                            GiaTienVatTu = k.GiaTien;
                        }
                    }
                    data.Add(new VatTuViewDTO
                    {
                        MaVatTu = i.MaVatTu,
                        TenVatTu = i.TenVatTu,
                        DonViTinh = i.DonViTinh,
                        SoLuong = i.SoLuong,
                        GiaTien = GiaTienVatTu
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
        public List<VatTuViewDTO> SortVatTuView(Compare compare)
        {
            List<VatTuViewDTO> data = new List<VatTuViewDTO>();
            data = GetVatTuViews("");
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        VatTuViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public bool CompareMaVatTu(object o1, object o2)
        {
            return String.Compare(((VatTuViewDTO)o1).MaVatTu, ((VatTuViewDTO)o2).MaVatTu) > 0;
        }
        public bool CompareTenVatTu(object o1, object o2)
        {
            return String.Compare(((VatTuViewDTO)o1).TenVatTu, ((VatTuViewDTO)o2).TenVatTu) > 0;
        }
        public bool CompareDonViTinh(object o1, object o2)
        {
            return String.Compare(((VatTuViewDTO)o1).DonViTinh, ((VatTuViewDTO)o2).DonViTinh) > 0;
        }
        public bool CompareSoLuong(object o1, object o2)
        {
            return ((VatTuViewDTO)o1).SoLuong > ((VatTuViewDTO)o2).SoLuong;
        }
        public bool CompareGiaTien(object o1, object o2)
        {
            return ((VatTuViewDTO)o1).GiaTien > ((VatTuViewDTO)o2).GiaTien;
        }
    }
}
