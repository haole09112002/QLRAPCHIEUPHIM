using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private static NhaCungCapBLL instance;
        public static NhaCungCapBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBLL();
                }
                return instance;
            }
            private set { }
        }
        private NhaCungCapBLL()
        {

        }
        public List<NhaCungCapDTO> GetNCCByMaLoaiNCC(string maLoaiNCC, string txt)
        {
            List<NhaCungCapDTO> data = new List<NhaCungCapDTO>();
            if (maLoaiNCC == "0")
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (i.TenNhaCungCap.Contains(txt) || i.SoDienThoai.Contains(txt) || i.MaSoThue.Contains(txt))
                        data.Add(i);
                }
            }
            else
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (i.MaLoaiNhaCungCap == maLoaiNCC && (i.TenNhaCungCap.Contains(txt) || i.SoDienThoai.Contains(txt) || i.MaSoThue.Contains(txt)))
                        data.Add(i);
                }
            }

            return data;
        }
        public NhaCungCapDTO GetNCCByMaNCC(string MaNCC)
        {
            NhaCungCapDTO nhaCungCap = null;
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if (i.MaNhaCungCap == MaNCC)
                {
                    nhaCungCap = i;
                    break;
                }
            }
            return nhaCungCap;
        }
        public List<NhaCungCapViewDTO> GetNCCViewMaLoaiNCC(string maLoaiNCC, string txt)
        {
            List<NhaCungCapViewDTO> data = new List<NhaCungCapViewDTO>();
            foreach (NhaCungCapDTO i in GetNCCByMaLoaiNCC(maLoaiNCC, txt))
            {
                data.Add(GetNhaCungCapViewByNhaCungCapDTO(i));
            }
            return data;
        }


        public NhaCungCapViewDTO GetNhaCungCapViewByNhaCungCapDTO(NhaCungCapDTO ncc)
        {
            string tenLoaiNCC = "";
            foreach (LoaiNhaCungCapDTO i in LoaiNhaCungCapDAL.Instance.GetAllLoaiNhaCungCap())
            {
                if (i.MaLoaiNhaCungCap == ncc.MaLoaiNhaCungCap)
                    tenLoaiNCC = i.TenLoaiNhaCungCap;
            }
            return new NhaCungCapViewDTO
            {
                MaNhaCungCap = ncc.MaNhaCungCap,
                TenNhaCungCap = ncc.TenNhaCungCap,
                MaSoThue = ncc.MaSoThue,
                SoDienThoai = ncc.SoDienThoai,
                TenLoaiNhaCungCap = tenLoaiNCC
            };
        }
        public List<NhaCungCapDTO> GetNhaCungCapDGV (List<string> maNhaCungCap)
        {
            List<NhaCungCapDTO> data = new List<NhaCungCapDTO>();
            foreach (string i in maNhaCungCap)
            {
                data.Add(GetNCCByMaNCC(i));
            }
            return data;
        }
        public List<NhaCungCapViewDTO> GetNhaCungCapViewDGV(List<string> maNhaCungCap)
        {
            List<NhaCungCapViewDTO> data = new List<NhaCungCapViewDTO>();
            foreach(NhaCungCapDTO i in GetNhaCungCapDGV(maNhaCungCap))
            {
                data.Add(GetNhaCungCapViewByNhaCungCapDTO(i));
            }
            return data;
        }
        public bool CheckAddUpdateNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            bool add = true;
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if (i.MaNhaCungCap == nhaCungCap.MaNhaCungCap)
                {
                    add = false;
                    break;
                }
            }
            return add;

        }
        public void AddUpdateNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            if (CheckAddUpdateNhaCungCap(nhaCungCap))
            {
                NhaCungCapDAL.Instance.ThemNhaCungCap(nhaCungCap);
            }
            else
            {
                NhaCungCapDAL.Instance.CapNhatNhaCungCap(nhaCungCap);
            }
        }

        public string KiemTraDuLieu(NhaCungCapDTO nhaCungCap)
        {

            if (nhaCungCap.TenNhaCungCap == "" ||
                nhaCungCap.MaLoaiNhaCungCap == "" ||
                nhaCungCap.MaSoThue == "" ||
                nhaCungCap.Email == "" ||
                nhaCungCap.SoDienThoai == "" ||
                nhaCungCap.DiaChi == "")
            {
                return "Dữ liệu còn trống !";
            }
            if (!CheckAddUpdateNhaCungCap(nhaCungCap))
            {
                if (nhaCungCap.MaSoThue != GetNCCByMaNCC(nhaCungCap.MaNhaCungCap).MaSoThue && (int)NhaCungCapDAL.Instance.KiemTraMaSoThue(nhaCungCap) > 0)
                {
                    return "Mã số thuế đã tồn tại!";
                }
                if (nhaCungCap.SoDienThoai != GetNCCByMaNCC(nhaCungCap.MaNhaCungCap).SoDienThoai && (int)NhaCungCapDAL.Instance.KiemTraSoDienThoai(nhaCungCap) > 0)
                {
                    return "Số điện thoại đã tồn tại!";
                }
                if (nhaCungCap.Email != GetNCCByMaNCC(nhaCungCap.MaNhaCungCap).Email && (int)NhaCungCapDAL.Instance.KiemTraEmail(nhaCungCap) > 0)
                {
                    return "Email đã tồn tại!";
                }
            }
            else
            {
                if ((int)NhaCungCapDAL.Instance.KiemTraMaSoThue(nhaCungCap) >= 1)
                {
                    return "Mã số thuế đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraSoDienThoai(nhaCungCap) >= 1)
                {
                    return "Số điện thoại đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraEmail(nhaCungCap) >= 1)
                {
                    return "Email đã tồn tại!";
                }
            }
            return null;
        }

        public delegate bool CompareObj(object o1, object o2);
        public List<NhaCungCapViewDTO> SortNhaCungCap(List<NhaCungCapViewDTO> now, string dkSort)
        {
            if (dkSort == "Tên A->Z")
                return Sort(now, CompareTenNhaCungCapTang);
            if (dkSort == "Tên Z->A")
                return Sort(now, CompareTenNhaCungCapGiam);
            return null;
        }
        public static bool CompareTenNhaCungCapTang(object o1, object o2)
        {
            return String.Compare(((NhaCungCapViewDTO)o1).TenNhaCungCap, ((NhaCungCapViewDTO)o2).TenNhaCungCap) > 0;
        }
        public static bool CompareTenNhaCungCapGiam(object o1, object o2)
        {
            return String.Compare(((NhaCungCapViewDTO)o2).TenNhaCungCap, ((NhaCungCapViewDTO)o1).TenNhaCungCap) > 0;
        }


        public List<NhaCungCapViewDTO> Sort(List<NhaCungCapViewDTO> now, CompareObj cmp)
        {
            List<NhaCungCapViewDTO> data = now;
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        NhaCungCapViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }

        public System.Data.DataTable GetSPByMaNhaCungCap(string maNhaCungCap)
        {
            return NhaCungCapDAL.Instance.GetSPByMaNhaCungCap(maNhaCungCap, GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap);
        }
    }
}

