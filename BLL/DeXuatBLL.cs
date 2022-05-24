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
        public List<DeXuatDTO> GetAllDeXuat(string txt = "")
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            foreach (DeXuatDTO i in DeXuatDAL.Instance.GetAllDeXuat())
            {
                if (i.MaDeXuat.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public DeXuatViewDTO GetDeXuatViewByDeXuatDTO(DeXuatDTO deXuat)
        {

            string tenLoaiDeXuat = "";
            foreach (LoaiDeXuatDTO i in LoaiDeXuatDAL.Instance.GetAllLoaiDeXuat())
            {
                if (i.MaLoaiDeXuat == deXuat.MaLoaiDeXuat)
                {
                    tenLoaiDeXuat = i.TenLoaiDeXuat;
                }
            }
            return new DeXuatViewDTO
            {
                MaDeXuat = deXuat.MaDeXuat,
                NgayDeXuat = deXuat.NgayDeXuat.ToString(),
                TenLoaiDeXuat = tenLoaiDeXuat

            };
        }
        public List<DeXuatViewDTO> GetDeXuatViewByMaDeXuat(string maLoaiDeXuat, string txt)
        {
            List<DeXuatViewDTO> data = new List<DeXuatViewDTO>();
            foreach (DeXuatDTO i in GetDeXuatByMaLoaiDeXuat(maLoaiDeXuat, txt))
            {
                data.Add(GetDeXuatViewByDeXuatDTO(i));
            }
            return data;
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
        public DeXuatDTO GetDXuatByMaDeXuat(string maDeXuat)
        {
            DeXuatDTO deXuat = null;
            foreach (DeXuatDTO i in DeXuatDAL.Instance.GetAllDeXuat())
            {
                if (i.MaDeXuat == maDeXuat)
                {
                    deXuat = i;
                    break;
                }
            }
            return deXuat;
        }
        public List<DeXuatDTO> GetDeXuatDGV(List<string> maDeXuat)
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            foreach (string i in maDeXuat)
            {
                data.Add(GetDXuatByMaDeXuat(i));
            }
            return data;
        }
        public List<DeXuatViewDTO> GetDeXuatViewDGV(List<string> maDeXuat)
        {
            List<DeXuatViewDTO> data = new List<DeXuatViewDTO>();
            foreach (DeXuatDTO i in GetDeXuatDGV(maDeXuat))
            {
                data.Add(GetDeXuatViewByDeXuatDTO(i));
            }
            return data;
        }
        public delegate bool CompareObj(object o1, object o2);
        public List<DeXuatViewDTO> SortDeXuat(List<DeXuatViewDTO> now, string dkSort)
        {
            if (dkSort == "Tên A->Z")
                return Sort(now, CompareKhoTang);
            if (dkSort == "Tên Z->A")
                return Sort(now, CompareKhoGiam);
            return null;
        }
        public static bool CompareKhoTang(object o1, object o2)
        {
            return String.Compare(((DeXuatViewDTO)o1).TenLoaiDeXuat, ((DeXuatViewDTO)o2).TenLoaiDeXuat) > 0;
        }
        public static bool CompareKhoGiam(object o1, object o2)
        {
            return String.Compare(((DeXuatViewDTO)o2).TenLoaiDeXuat, ((DeXuatViewDTO)o1).TenLoaiDeXuat) > 0;
        }

        public List<DeXuatViewDTO> Sort(List<DeXuatViewDTO> now, CompareObj cmp)
        {
            List<DeXuatViewDTO> data = now;
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        DeXuatViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }

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
        public List<DeXuatViewDTO> TimTheoMaDeXuat(string maDeXuat)
        {
            List<DeXuatViewDTO> data = new List<DeXuatViewDTO>();
            foreach (DeXuatDTO i in DeXuatDAL.Instance.TimTheoMa(maDeXuat))
            {
                data.Add(GetDeXuatViewByDeXuatDTO(i));
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
    }
}
