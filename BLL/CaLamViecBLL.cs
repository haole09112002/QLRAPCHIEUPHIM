using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CaLamViecBLL
    {
        private static CaLamViecBLL instance;
        public static CaLamViecBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CaLamViecBLL();
                }
                return instance;
            }
            set { }
        }
        public List<CaLamViecDTO> GetAllCaLamViec()
        {

            return CaLamViecDAL.Instance.GetAllCaLamViec();

        }

        public CaLamViecDTO GetCaLamViecByMaCaLamViec(string MaCaLamViec)
        {
            CaLamViecDTO data = new CaLamViecDTO();
            foreach (CaLamViecDTO i in CaLamViecDAL.Instance.GetAllCaLamViec())
            {
                if (i.MaCa == MaCaLamViec)
                {
                    data.MaCa = i.MaCa;
                    data.TenCa = i.TenCa;
                    data.GioBatDau = i.GioBatDau;
                    data.GioKetThuc = i.GioKetThuc;
                }
            }
            return data;
        }
    }
}
