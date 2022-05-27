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
        public delegate bool Compare(object a, object b);

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

        public ChiTietKhoVatTuViewDTO ConvertChiTietKhoVatTuDTOToView(ChiTietKhoVatTuDTO vt)
        {
            string tenVatTu = "";
            double GiaTien = 0;
            string TenKho = "";
            foreach(VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.MaVatTu == vt.MaVatTu)
                    tenVatTu = i.TenVatTu;
            }
            foreach (HopDongVatTuDTO j in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
            {
                if (j.MaVatTu == vt.MaVatTu)
                    GiaTien = j.GiaTien;
            }
            foreach (KhoDTO k in KhoDAL.Instance.GetAllKho())
            {
                if (k.MaKho == vt.MaKho)
                    TenKho = k.TenKho;
            }
            return new ChiTietKhoVatTuViewDTO
            {
                MaKho = vt.MaKho,
                MaVatTu = vt.MaVatTu,
                TenVatTu = tenVatTu,
                DonViTinh = vt.DonViTinh,
                SoLuongSP = vt.SoLuongSP,
                GiaTien = GiaTien,
                TenKho = TenKho,

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
            foreach (ChiTietKhoVatTuDTO i in GetAllChiTietKhoVatTu())
                data.Add(ConvertChiTietKhoVatTuToView(i));
            return data;
        }
    
        public List<ChiTietKhoVatTuViewDTO> GetAllChiTietKhoVatTuView(string txt = "")
        {
            List<ChiTietKhoVatTuViewDTO> data = new List<ChiTietKhoVatTuViewDTO>();
            foreach(ChiTietKhoVatTuDTO i in GetAllChiTietKhoVatTu())
            {
                if (VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu).TenVatTu.Contains(txt))
                {
                data.Add(ConvertChiTietKhoVatTuDTOToView(i));
                }
            }
            return data;
        }

        public List<string> GetAllDonViTinh()
        {
            List<string> data = new List<string>();
            foreach (ChiTietKhoVatTuDTO i in GetAllChiTietKhoVatTu())
                data.Add(i.DonViTinh);
            return data.Distinct().ToList();
        }

        public List<ChiTietKhoVatTuViewDTO> SortChiTietKhoVatTuView(Compare compare)
        {
            List<ChiTietKhoVatTuViewDTO> data = new List<ChiTietKhoVatTuViewDTO>();
            data = GetAllChiTietKhoVatTuView("");
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        ChiTietKhoVatTuViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public List<ChiTietKhoVatTuView> GetAllChiTietKhoVatTuView1()
        {
            List<ChiTietKhoVatTuView> data = new List<ChiTietKhoVatTuView>();
            foreach (ChiTietKhoVatTuDTO i in GetAllChiTietKhoVatTu())
            {
                    data.Add(ConvertChiTietKhoVatTuToView(i));
            }
            return data;
        }
        public ChiTietKhoVatTuView ConvertChiTietKhoVatTuToView(ChiTietKhoVatTuDTO vt)
        {
            string tenVatTu = "";
            double GiaTien = 0;
            string TenKho = "";
            foreach (VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.MaVatTu == vt.MaVatTu)
                    tenVatTu = i.TenVatTu;
            }
            foreach (HopDongVatTuDTO j in HopDongVatTuDAL.Instance.GetAllHopDongVatTu())
            {
                if (j.MaVatTu == vt.MaVatTu)
                    GiaTien = j.GiaTien;
            }
            foreach (KhoDTO k in KhoDAL.Instance.GetAllKho())
            {
                if (k.MaKho == vt.MaKho)
                    TenKho = k.TenKho;
            }
            return new ChiTietKhoVatTuView
            {
                MaKho = vt.MaKho,
                MaVatTu = vt.MaVatTu,
                TenVatTu = tenVatTu,
                DonViTinh = vt.DonViTinh,
                SoLuongSP = vt.SoLuongSP,
            };
        }
        public bool CompareTenVatTu(object o1, object o2)
        {
            return String.Compare(((ChiTietKhoVatTuViewDTO)o1).TenVatTu, ((ChiTietKhoVatTuViewDTO)o2).TenVatTu) > 0;
        }
        public bool CompareTenKho(object o1, object o2)
        {
            return String.Compare(((ChiTietKhoVatTuViewDTO)o1).TenKho, ((ChiTietKhoVatTuViewDTO)o2).TenKho) > 0;
        }
        public bool CompareDonViTinh(object o1, object o2)
        {
            return String.Compare(((ChiTietKhoVatTuViewDTO)o1).DonViTinh, ((ChiTietKhoVatTuViewDTO)o2).DonViTinh) > 0;
        }
        public bool CompareSoLuong(object o1, object o2)
        {
            return ((ChiTietKhoVatTuViewDTO)o1).SoLuongSP > ((ChiTietKhoVatTuViewDTO)o2).SoLuongSP;
        }
        public bool CompareGiaTien(object o1, object o2)
        {
            return ((ChiTietKhoVatTuViewDTO)o1).GiaTien > ((ChiTietKhoVatTuViewDTO)o2).GiaTien;
        }



        
        public void AddUpDateChiTietKhoVatTu(List<ChiTietKhoVatTuView> dsCTKhoVT)
        {
           
            foreach(ChiTietKhoVatTuView k in dsCTKhoVT)
            {
                bool add = true;
                foreach (ChiTietKhoVatTuView i in GetAllChiTietKhoVatTuView1())
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
            var ds = GetAllChiTietKhoVatTuView1();
            foreach (var i in dsCTKhoVT)
            {
                int index = ds.FindIndex(x => x.MaVatTu == i.MaVatTu && x.MaKho == i.MaKho);
                if (index >= 0)
                    ds.RemoveAt(index);
            }
            if (ds.Count > 0)
                foreach (var i in ds)
                {
                    ChiTietKhoVatTuDAL.Instance.XoaChiTietKhoVatTu(ConvertChiTietKhoVatTuViewToDTO(i));
                }

        }
        public void XoaMotVTTrongKho(ChiTietKhoVatTuDTO vtCanXoa)
        {
            var ds = GetAllChiTietKhoVatTu();
            var itemKho = ds.Find(i=>i.MaVatTu == vtCanXoa.MaVatTu && i.MaKho == vtCanXoa.MaKho);
            if(itemKho != null)
            {
                itemKho.SoLuongSP += vtCanXoa.SoLuongSP;
                ChiTietKhoVatTuDAL.Instance.CapNhatChiTietKhoVatTu(itemKho);
            }   
            else
            {
                ChiTietKhoVatTuDAL.Instance.ThemChiTietKhoVatTu(vtCanXoa);
            }
        }
    }
}
