using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class KhoBLL
    {
        private static KhoBLL instance;
        public static KhoBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoBLL();
                }
                return instance;
            }
            private set { }
        }
        private KhoBLL()
        {

        }
        public List<KhoDTO> GetAllKho(string txt = "")
        {
            List<KhoDTO> data = new List<KhoDTO>();
            foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
            {
                if (i.TenKho.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<KhoView> GetAllKhoView()
        {
            List<KhoView> data = new List<KhoView>();
            foreach (KhoDTO i in GetAllKho())
            {
                data.Add(GetKhoViewByKhoDTO(i));
            }
            return data;
        }
        public KhoView GetKhoViewByKhoDTO(KhoDTO kho)
        {
            
            string tenLoaiKho = "";
            foreach (LoaiKhoDTO i in LoaiKhoDAL.Instance.GetAllLoaiKho())
            {
                if (i.MaLoaiKho == kho.MaLoaiKho)
                {
                    tenLoaiKho = i.TenLoaiKho;
                }
            }
            return new KhoView
            {
                MaKho = kho.MaKho,
                TenKho = kho.TenKho,
                TenLoaiKho = tenLoaiKho

            };
        }
        public List<KhoDTO> GetKhoDGV(List<string> maKho)
        {
            List<KhoDTO> data = new List<KhoDTO>();
            foreach (string i in maKho)
        {
                data.Add(GetKhoByMaKho(i));
            }
            return data;
        }
        public KhoDTO GetKhoByMaKho(string MaKho)
        {
            KhoDTO kho = null;
            foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
            {
                if (i.MaKho == MaKho)
                {
                    kho = i;
                    break;
                }
            }
            return kho;
        }
        public List<KhoDTO> GetKhoByMaLoaiKho(string maLoaiKho, string txt)
        {
            List<KhoDTO> data = new List<KhoDTO>();
            if (maLoaiKho == "0")
            {
                foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
                {
                    if (i.TenKho.Contains(txt) || i.MaKho.Contains(txt))
                        data.Add(i);
                }
            }
            else
            {
                foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
                {
                    if (i.MaLoaiKho == maLoaiKho && (i.TenKho.Contains(txt) || i.MaKho.Contains(txt)))
                        data.Add(i);
                }
            }

            return data;
        }
        public List<KhoView> GetKhoViewMaLoaiKho(string maLoaiKho, string txt)
        {
            List<KhoView> data = new List<KhoView>();
            foreach (KhoDTO i in GetKhoByMaLoaiKho(maLoaiKho, txt))
            {
                data.Add(GetKhoViewByKhoDTO(i));
            }
            return data;
        }
        public List<KhoView> GetKhoViewDGV(List<string> maKho)
        {
            List<KhoView> data = new List<KhoView>();
            foreach (KhoDTO i in GetKhoDGV(maKho))
            {
                data.Add(GetKhoViewByKhoDTO(i));
                }
            return data;
            }
        public delegate bool CompareObj(object o1, object o2);
        public List<KhoView> SortKho(List<KhoView> now, string dkSort)
        {
            if (dkSort == "Tên A->Z")
                return Sort(now, CompareKhoTang);
            if (dkSort == "Tên Z->A")
                return Sort(now, CompareKhoGiam);
            return null;
        }
        public static bool CompareKhoTang(object o1, object o2)
        {
            return String.Compare(((KhoView)o1).TenKho, ((KhoView)o2).TenKho) > 0;
    }
        public static bool CompareKhoGiam(object o1, object o2)
        {
            return String.Compare(((KhoView)o2).TenKho, ((KhoView)o1).TenKho) > 0;
        }

        public List<KhoView> Sort(List<KhoView> now, CompareObj cmp)
        {
            List<KhoView> data = now;
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        KhoView temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public List<KhoView> TimTheoTenKho(string tenKho)
        {
            List<KhoView> data = new List<KhoView>();
            foreach (KhoDTO i in KhoDAL.Instance.TimTheoTenKho(tenKho))
            {
                data.Add(GetKhoViewByKhoDTO(i));
            }
            return data;
        }
    }
}

