using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
        public List<NhaCungCapDTO> GetNCCByMaLoaiNCC(string maLoaiNCC = "0", string txt = "", string cbbText = "")
        {
            List<NhaCungCapDTO> data = new List<NhaCungCapDTO>();
            if (maLoaiNCC == "0")
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if(cbbText == "Tên nhà cung cấp")
                    {
                        if (i.TenNhaCungCap.ToLower().Contains(txt.ToLower()))
                            data.Add(i);
                    }    
                    if(cbbText == "Mã số thuế")
                    {
                        if (i.MaSoThue.Contains(txt))
                            data.Add(i);
                    }
                    if (cbbText == "Số điện thoại")
                    {
                        if (i.SoDienThoai.Contains(txt))
                            data.Add(i);
                    }
                    if(cbbText == "")
                    {
                        data = NhaCungCapDAL.Instance.GetAllNhaCungCap();
                    }    
                }
            }
            else
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (cbbText == "Tên nhà cung cấp"  && maLoaiNCC == i.MaLoaiNhaCungCap)
                    {
                        if (i.TenNhaCungCap.ToLower().Contains(txt.ToLower()))
                            data.Add(i);
                    }
                    if (cbbText == "Mã số thuế" && maLoaiNCC == i.MaLoaiNhaCungCap)
                    {
                        if (i.MaSoThue.Contains(txt))
                            data.Add(i);
                    }
                    if (cbbText == "Số điện thoại" && maLoaiNCC == i.MaLoaiNhaCungCap)
                    {
                        if (i.SoDienThoai.Contains(txt))
                            data.Add(i);
                    };
                    if (cbbText == "" && maLoaiNCC == i.MaLoaiNhaCungCap)
                    {
                        data.Add(i);    
                    }    
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
        public List<NhaCungCapViewDTO> GetNCCViewMaLoaiNCC(string maLoaiNCC, string txt, string tieuChiTiemKiem= "")
        {
            List<NhaCungCapViewDTO> data = new List<NhaCungCapViewDTO>();
            foreach (NhaCungCapDTO i in GetNCCByMaLoaiNCC(maLoaiNCC, txt, tieuChiTiemKiem))
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
        public DataTable GetSPByMaNhaCungCap(string maNhaCungCap)
        {
            
            return NhaCungCapDAL.Instance.GetSPByMaNhaCungCap(maNhaCungCap, GetNCCByMaNCC(maNhaCungCap).MaLoaiNhaCungCap);
        }
        public List<CBBItem> GetCBBNhaCungCap(string maLoaiNhaCungCap = "")
        {
            List<CBBItem> data = new List<CBBItem>();
            if (maLoaiNhaCungCap == "")
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                        data.Add(new CBBItem
                        { Value = i.MaNhaCungCap, Text = i.TenNhaCungCap });
                }
            }
            else
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (i.MaLoaiNhaCungCap == maLoaiNhaCungCap)
                        data.Add(new CBBItem
                        { Value = i.MaNhaCungCap, Text = i.TenNhaCungCap });
                }
            }    
            return data;
        }
        public List<NhaCungCapDTO> GetAllNhaCungCap(string TimKiem = "", string LoaiTimKiem = "")
        {
            List<NhaCungCapDTO> data = new List<NhaCungCapDTO>();
            foreach(NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if(LoaiTimKiem == "Tên Nhà Cung Cấp" || LoaiTimKiem == "")
                {
                    if(i.TenNhaCungCap.Contains(TimKiem))
                    {
                        data.Add(i);
                    }
                }
                if(LoaiTimKiem == "Mã Số Thuế")
                {
                    if(i.MaSoThue.Contains(TimKiem))
                    {
                        data.Add(i);
                    }
                }
                if(LoaiTimKiem == "Email")
                {
                    if(i.Email.Contains(TimKiem))
                    {
                        data.Add(i);
                    }
                }
                if(LoaiTimKiem == "Số Điện Thoại")
                {
                    if(i.SoDienThoai.Contains(TimKiem))
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
        public DataTable TimKiemVatTuTheoTen(string maNhaCungCap, string txt = "")
        {
            DataTable data = GetSPByMaNhaCungCap(maNhaCungCap);
            var results = data.AsEnumerable().Where(myRow => myRow[1].ToString().ToLower().Contains(txt.ToLower())).Select(myRow => myRow);
            if (results != null && results.GetEnumerator().MoveNext())
            {
                return results.CopyToDataTable();
            }
            else
            {
                data.Rows.Clear();
                data.AcceptChanges();
            }
            return data;
        }
        public bool KiemTraMaSoThue(string maNhaCungCap, string maSoThue)
        {
            bool check = true;
            if (GetNCCByMaNCC(maNhaCungCap) != null)    // cap nhat
            {

                if (maSoThue != GetNCCByMaNCC(maNhaCungCap).MaSoThue && GetAllNhaCungCap().FindIndex(x => x.MaSoThue == maSoThue) != -1)
                {
                    maSoThue = "Mã số thuế đã tồn tại!";
                    check = false;
                }
             
            }
            else  // them
            {
                if (GetAllNhaCungCap().FindIndex(x => x.MaSoThue == maSoThue) != -1)
                {
                    maSoThue = "Mã số thuế đã tồn tại!";
                    check = false;
                }
            }
            return check;
        }
        public bool KiemTraSDT(string maNhaCungCap, string sdt)
        {
            bool check = true;
            if (GetNCCByMaNCC(maNhaCungCap) != null)    // cap nhat
            {
                if (sdt != GetNCCByMaNCC(maNhaCungCap).SoDienThoai && GetAllNhaCungCap().FindIndex(x => x.SoDienThoai == sdt) != -1)
                {
                    check = false;
                }
            }
            else  // them
            {
                if (GetAllNhaCungCap().FindIndex(x => x.SoDienThoai == sdt) != -1)
                {
                    check = false;
                }
            }
            return check;
        }
        public bool KiemTraEmail(string maNhaCungCap, string email)
        {
            bool check = true;
            if (GetNCCByMaNCC(maNhaCungCap) != null)    // cap nhat
            {
                if (email != GetNCCByMaNCC(maNhaCungCap).Email && GetAllNhaCungCap().FindIndex(x => x.Email == email) != -1)
                {
                    check = false;
                }
            }
            else  // them
            {
                if (GetAllNhaCungCap().FindIndex(x => x.Email == email) != -1)
                {
                    check = false;
                }
            }
            return check;
        }

    }
   
}

