using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhieuBLL
    {
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
        public List<PhieuDTO> GEtListPhieuNow(List<string> MaPhieu)
        {
            List<PhieuDTO> data = new List<PhieuDTO>();
            return data;
        }
    }
}
