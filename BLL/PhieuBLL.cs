using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Collections;
using System.Windows.Forms;

namespace BLL
{
    public class PhieuBLL
    {
        public delegate bool Compare(object a, object b);
        private static PhieuBLL instance;
        public static PhieuBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuBLL();
                return instance;
            }
            private set { }
        }
        public List<PhieuDTO> GetAllPhieu()
        {
            List<PhieuDTO> data = new List<PhieuDTO>();
            foreach(PhieuDTO i in PhieuDAL.Instance.GetAllPhieu())
            {
                data.Add(i);
            }
            return data;
        }
        public List<PhieuDTO> GetListPhieuByLoaiPhieu(string MaLoaiPhieu)
        {
            List<PhieuDTO> data = new List<PhieuDTO>();
            if (MaLoaiPhieu == "") 
            {
                data = PhieuDAL.Instance.GetAllPhieu();
            }
            else
            foreach(PhieuDTO i in PhieuDAL.Instance.GetAllPhieu())
            {
                if(i.MaLoaiPhieu == MaLoaiPhieu)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public PhieuDTO GetPhieuByMaPhieu(string MaPhieu)
        {
            foreach (PhieuDTO i in PhieuDAL.Instance.GetAllPhieu())
            {
                if (i.MaPhieu == MaPhieu)
                {
                    return i;

                }
            }
            return null;
        }
        public List<PhieuDTO> GetListPhieuNow(List<string> MaPhieu, string TimKiem = "", string LoaiTimKiem = "")
        {
            List<PhieuDTO> data = new List<PhieuDTO>();
            if(LoaiTimKiem == "Tên Nhân Viên" || LoaiTimKiem == "")
            {
                foreach (string i in MaPhieu)
                {
                    if(NhanVienBLL.Instance.GetNhanVienByMaNhanVien(GetPhieuByMaPhieu(i).MaNhanVien).TenNhanVien.Contains(TimKiem))
                        data.Add(GetPhieuByMaPhieu(i));
                }
            }
            if (LoaiTimKiem == "Ngày Lập Phiếu")
            {
                foreach (string i in MaPhieu)
                {
                    if (GetPhieuByMaPhieu(i).NgayLapPhieu.ToShortDateString().Contains(TimKiem))
                        data.Add(GetPhieuByMaPhieu(i));
                }
            }
            return data;
        }
        public List<PhieuDTO> SortPhieu(Compare compare, List<string> MaPhieu, string TimKiem = "", string LoaiTimKiem = "")
        {
            List<PhieuDTO> data = new List<PhieuDTO>();
            data = GetListPhieuNow(MaPhieu,TimKiem,LoaiTimKiem);
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        PhieuDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public bool CompareTenNhanVien(object o1, object o2)
        {
            return String.Compare(NhanVienBLL.Instance.GetNhanVienByMaNhanVien(((PhieuDTO)o1).MaNhanVien).TenNhanVien, NhanVienBLL.Instance.GetNhanVienByMaNhanVien(((PhieuDTO)o2).MaNhanVien).TenNhanVien) > 0;
        }
        public bool CompareNgayLapPhieu(object o1, object o2)
        {
            return DateTime.Compare(((PhieuDTO)o1).NgayLapPhieu, ((PhieuDTO)o2).NgayLapPhieu) > 0;
        }
        public void LuuPhieu(string MaLoaiPhieu,string MaKho,string MaNhanVien,DateTime NgayLapPhieu)
        {
            PhieuDAL.Instance.LuuPhieu(MaLoaiPhieu,MaKho,MaNhanVien,NgayLapPhieu);
        }
        public string GetMaPhieuAddNew()
        {
            return PhieuDAL.Instance.GetMaPhieuAddNew();
        }
    }
}
