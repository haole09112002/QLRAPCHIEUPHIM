using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class DeXuatBLL
    {
        public delegate bool Compare(object a, object b);
        private static DeXuatBLL instance;
        public static DeXuatBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatBLL();
                }
                return instance;
            }
            private set { }
        }
        private DeXuatBLL()
        {

        }
        public List<DeXuatDTO> GetDeXuatByMaLoaiDeXuat(string maLoaiDeXuat, string txt = "")
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            if(maLoaiDeXuat == "0")
            {

            }
            else
            {
                foreach(DeXuatDTO i in DeXuatDAL.Instance.GetAllDeXuat())
                {
                    if(i.MaLoaiDeXuat == maLoaiDeXuat )
                    {
                        data.Add(i);    
                    }
                }
            }
            return data;
        }
        //public CBBItem GetCBBItemDeXuatPhim()
        //{
        //    foreach(DeXuatPhimDTO i in DeXuatPhimDAL.Instance.GetllDeXuatPhim())
        //    {
                
        //    }
        //}
       
        public List<CBBItem> GetCBBPhimDeXuat()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (ChiTietDeXuatPhimDTO i in ChiTietDeXuatPhimDAL.Instance.GetllDeXuatPhim())
            {
                foreach (CBBItem j in PhimBLL.Instance.GetCBBPhim())
                {
                    if (j.Value == i.MaPhim)
                    {
                        data.Add(j);
                    }
                }
            }
            return data;
        }
        public void LuuDeXuat(string MaNhanVien, DateTime NgayDeXuat, string MaLoaiDeXuat)
        {
            DeXuatDAL.Instance.LuuDeXuat(MaNhanVien,NgayDeXuat, MaLoaiDeXuat);
        }
        public string GetMaDeXuatAddNew()
        {
            return DeXuatDAL.Instance.GetMaDeXuatAddNew();
        }
        public DeXuatDTO GetDeXuatByMaDeXuat(string MaDeXuat)
        {
            foreach(DeXuatDTO i in DeXuatDAL.Instance.GetAllDeXuat())
            {
                if(i.MaDeXuat == MaDeXuat)
                {
                    return i;
                }
            }
            return null;
        }
        public List<DeXuatDTO> GetListDeXuatNow(List<string> MaDeXuat, string TimKiem = "", string LoaiTimKiem = "")
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            if (LoaiTimKiem == "Tên Nhân Viên" || LoaiTimKiem == "")
            {
                foreach (string i in MaDeXuat)
                {
                    if (NhanVienBLL.Instance.GetNhanVienByMaNhanVien(GetDeXuatByMaDeXuat(i).MaNhanVien).TenNhanVien.Contains(TimKiem))
                        data.Add(GetDeXuatByMaDeXuat(i));
                }
            }
            if (LoaiTimKiem == "Ngày Lập Phiếu")
            {
                foreach (string i in MaDeXuat)
                {
                    if (GetDeXuatByMaDeXuat(i).NgayDeXuat.ToShortDateString().Contains(TimKiem))
                        data.Add(GetDeXuatByMaDeXuat(i));
                }
            }
            return data;
        }
        public List<DeXuatDTO> SortDeXuat(Compare compare, List<string> MaDeXuat, string TimKiem = "", string LoaiTimKiem = "")
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            data = GetListDeXuatNow(MaDeXuat, TimKiem, LoaiTimKiem);
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        DeXuatDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
    }
}
