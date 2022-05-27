using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietKhoThucAnBLL
    {
        private static ChiTietKhoThucAnBLL instance;
        public delegate bool Compare(object a, object b);

        public static ChiTietKhoThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietKhoThucAnBLL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietKhoThucAnBLL()
        {

        }
        public List<ChiTietKhoThucAnDTO> GetAllChiTietKhoThucAn()
        {
            return ChiTietKhoThucAnDAL.Instance.GetAllChiTietKhoThucAn();
        }

        public ChiTietKhoThucAnViewDTO ConvertChiTietKhoThucAnDTOToView(ChiTietKhoThucAnDTO vt)
        {
            string tenThucAn = "";
            double GiaTien = 0;
            string TenKho = "";
            foreach (HopDongThucAnDTO j in HopDongThucAnDAL.Instance.GetAllHopDongThucAn())
            {
                if (j.MaThucAn == vt.MaThucAn)
                    GiaTien = j.GiaTien;
            }
            foreach (KhoDTO k in KhoDAL.Instance.GetAllKho())
            {
                if (k.MaKho == vt.MaKho)
                    TenKho = k.TenKho;
            }
            foreach (ThucAnDTO i in ThucAnDAL.Instance.GetALLThucAn())
            {
                if (i.MaThucAn == vt.MaThucAn)
                    tenThucAn = i.TenThucAn;
            }
            return new ChiTietKhoThucAnViewDTO
            {
                MaKho = vt.MaKho,
                MaThucAn = vt.MaThucAn,
                TenThucAn = tenThucAn,
                DonViTinh = vt.DonViTinh,
                SoLuongSP = vt.SoLuongSP,
                GiaTien = GiaTien,
                TenKho = TenKho,

            };
        }
        public List<ChiTietKhoThucAnDTO> GetListChiTietKhoThucAnByMaKho(string MaKho)
        {
            List<ChiTietKhoThucAnDTO> data = new List<ChiTietKhoThucAnDTO>();
            foreach (ChiTietKhoThucAnDTO i in GetAllChiTietKhoThucAn())
            {
                if (i.MaKho == MaKho)
                    data.Add(i);
            }
            return data;
        }
        public List<ChiTietKhoThucAnViewDTO> GetAllChiTietKhoThucAnView(string txt)
        {
            List<ChiTietKhoThucAnViewDTO> data = new List<ChiTietKhoThucAnViewDTO>();
            foreach (ChiTietKhoThucAnDTO i in GetAllChiTietKhoThucAn())
            {
                if (ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn).TenThucAn.Contains(txt))
                {
                data.Add(ConvertChiTietKhoThucAnDTOToView(i));
                }
            }
            return data;
        }
        public List<string> GetAllDonViTinh()
        {
            List<string> data = new List<string>();
            foreach (ChiTietKhoThucAnDTO i in GetAllChiTietKhoThucAn())
                data.Add(i.DonViTinh);
            return data.Distinct().ToList();
        }

        public List<ChiTietKhoThucAnViewDTO> SortChiTietKhoThucAnView(Compare compare)
        {
            List<ChiTietKhoThucAnViewDTO> data = new List<ChiTietKhoThucAnViewDTO>();
            data = GetAllChiTietKhoThucAnView("");
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        ChiTietKhoThucAnViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public bool CompareTenThucAn(object o1, object o2)
        {
            return String.Compare(((ChiTietKhoThucAnViewDTO)o1).TenThucAn, ((ChiTietKhoThucAnViewDTO)o2).TenThucAn) > 0;
        }
        public bool CompareTenKho(object o1, object o2)
        {
            return String.Compare(((ChiTietKhoThucAnViewDTO)o1).TenKho, ((ChiTietKhoThucAnViewDTO)o2).TenKho) > 0;
        }
        public bool CompareDonViTinh(object o1, object o2)
        {
            return String.Compare(((ChiTietKhoThucAnViewDTO)o1).DonViTinh, ((ChiTietKhoThucAnViewDTO)o2).DonViTinh) > 0;
        }
        public bool CompareSoLuong(object o1, object o2)
        {
            return ((ChiTietKhoThucAnViewDTO)o1).SoLuongSP > ((ChiTietKhoThucAnViewDTO)o2).SoLuongSP;
        }
        public bool CompareGiaTien(object o1, object o2)
        {
            return ((ChiTietKhoThucAnViewDTO)o1).GiaTien > ((ChiTietKhoThucAnViewDTO)o2).GiaTien;
        }



        public void KiemTraThongTinChiTietThucAnTrongKho(string maThucAn, int soLuong, string DonViTinh)
        {

        }
        public List<ThucAnDTO> GetListThucAnByMaKho(string MaKho)
        {
            List<ThucAnDTO> data = new List<ThucAnDTO>();
            foreach (ChiTietKhoThucAnDTO i in GetListChiTietKhoThucAnByMaKho(MaKho))
            {
                data.Add(ThucAnBLL.Instance.GetThucAnByMaThucAn(i.MaThucAn));
            }
            return data;
        }
        public ChiTietKhoThucAnDTO GetChiTietKhoThucAnByKhoa(string MaKho, string MaThucAn)
        {
            foreach (ChiTietKhoThucAnDTO i in GetListChiTietKhoThucAnByMaKho(MaKho))
            {
                if (MaThucAn == i.MaThucAn)
                {
                    return i;
                }
            }
            return null;
        }
        public ChiTietKhoThucAnDTO GetChiTietKhoThucAnByMaThucAn(string MaThucAn)
        {
            foreach (ChiTietKhoThucAnDTO i in GetAllChiTietKhoThucAn())
            {
                if (MaThucAn == i.MaThucAn)
                {
                    return i;
                }
            }
            return null;
        }
        public void ThemCapNhatChiTietKhoThucAn(List<ChiTietKhoThucAnDTO> list, string LoaiPhieu)
        {
            bool KiemTraTonTaiThucAn = true;
            foreach (ChiTietKhoThucAnDTO i in list)
            {
                KiemTraTonTaiThucAn = false;
                foreach (ChiTietKhoThucAnDTO j in GetListChiTietKhoThucAnByMaKho(i.MaKho))
                {
                    if (i.MaThucAn == j.MaThucAn)
                    {
                        KiemTraTonTaiThucAn = true;
                        j.DonViTinh = i.DonViTinh;
                        if (LoaiPhieu == "LP001")
                        {
                            j.SoLuongSP = j.SoLuongSP + i.SoLuongSP;
                        }
                        else
                        {
                            j.SoLuongSP = j.SoLuongSP - i.SoLuongSP;
                        }
                        CapNhatChiTietKhoThucAn(j.MaKho, j.MaThucAn, j.SoLuongSP, j.DonViTinh);
                    }
                }
                if (KiemTraTonTaiThucAn == false)
                {
                    LuuChiTietKhoThucAn(i.MaKho, i.MaThucAn, i.DonViTinh, i.SoLuongSP);
                }
            }
        }
        public void CapNhatChiTietKhoThucAn(string MaKho, string MaThucAn, int SoLuongSP, string DonViTinh)
        {
            ChiTietKhoThucAnDAL.Instance.CapNhatChiTietKhoThucAn(MaKho, MaThucAn, SoLuongSP, DonViTinh);
        }
        public void LuuChiTietKhoThucAn(string MaKho, string MaThucAn, string DonViTinh, int SoLuongSP)
        {
            ChiTietKhoThucAnDAL.Instance.LuuChiTietKhoThucAn(MaKho, MaThucAn, DonViTinh, SoLuongSP);
        }
    }
}
