using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoaiPhieuBLL
    {
        private static LoaiPhieuBLL instance;
        public static LoaiPhieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiPhieuBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<LoaiPhieuDTO> GetAllLoaiPhieu()
        {
            List<LoaiPhieuDTO> data = new List<LoaiPhieuDTO>();
            foreach (LoaiPhieuDTO i in LoaiPhieuDAL.Instance.GetAllLoaiPhieu())
            {
                data.Add(i);
            }
            return data;
        }
        public LoaiPhieuDTO GetLoaiPhieuByMaLoaiPhieu(string MaLoaiPhieu)
        {
  
            foreach (LoaiPhieuDTO i in GetAllLoaiPhieu())
            {
                if (i.MaLoaiPhieu == MaLoaiPhieu)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
