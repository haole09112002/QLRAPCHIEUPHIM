using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ThucAnBLL
    {
        public delegate bool Compare(object a, object b);
        private static ThucAnBLL instance;
        public static ThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThucAnBLL();
                }
                return instance;
            }
            set { }
        }
        public List<ThucAnViewDTO> GetThucAnViews(string txt)
        {
            List<ThucAnViewDTO> data = new List<ThucAnViewDTO>();
            foreach (ThucAnDTO i in ThucAnDAL.Instance.GetALLThucAn())
            {
                double GiaTienThucAn = 0;
                if (i.TenThucAn.Contains(txt))
                {
                    foreach (HopDongThucAnDTO k in HopDongThucAnDAL.Instance.GetAllHopDongThucAn())
                    {
                        if (k.MaThucAn == i.MaThucAn)
                        {
                            GiaTienThucAn = k.GiaTien;
                        }
                    }
                    data.Add(new ThucAnViewDTO
                    {
                        MaThucAn = i.MaThucAn,
                        TenThucAn = i.TenThucAn,
                        DonViTinh = i.DonViTinh,
                        SoLuong = i.SoLuong,
                        GiaTien = GiaTienThucAn
                    });
                }
            }
            return data;
        }
        public ThucAnDTO GetThucAnByMaThucAn(string MaThucAn)
        {
            ThucAnDTO data = new ThucAnDTO();
            foreach (ThucAnDTO i in ThucAnDAL.Instance.GetALLThucAn())
            {
                if (i.MaThucAn == MaThucAn)
                {
                    data.MaThucAn = i.MaThucAn;
                    data.TenThucAn = i.TenThucAn;
                    data.DonViTinh = i.DonViTinh;
                    data.SoLuong = i.SoLuong;
                }
            }
            return data;
        }
        public List<ThucAnViewDTO> SortThucAnView(Compare compare)
        {
            List<ThucAnViewDTO> data = new List<ThucAnViewDTO>();
            data = GetThucAnViews("");
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        ThucAnViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public bool CompareMaThucAn(object o1, object o2)
        {
            return String.Compare(((ThucAnViewDTO)o1).MaThucAn, ((ThucAnViewDTO)o2).MaThucAn) > 0;
        }
        public bool CompareTenThucAn(object o1, object o2)
        {
            return String.Compare(((ThucAnViewDTO)o1).TenThucAn, ((ThucAnViewDTO)o2).TenThucAn) > 0;
        }
        public bool CompareDonViTinh(object o1, object o2)
        {
            return String.Compare(((ThucAnViewDTO)o1).DonViTinh, ((ThucAnViewDTO)o2).DonViTinh) > 0;
        }
        public bool CompareSoLuong(object o1, object o2)
        {
            return ((ThucAnViewDTO)o1).SoLuong > ((ThucAnViewDTO)o2).SoLuong;
        }
        public bool CompareGiaTien(object o1, object o2)
        {
            return ((ThucAnViewDTO)o1).GiaTien > ((ThucAnViewDTO)o2).GiaTien;
        }
    }
}
