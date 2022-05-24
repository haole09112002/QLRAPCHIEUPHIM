using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<KhoDTO> GetAllKho()
        {
            List<KhoDTO> data = new List<KhoDTO>();
            foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
            {
                data.Add(i);
            }
            return data;
        }
        public KhoDTO GetKhoByMaKho(string MaKho)
        {
            foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
            {
                if (i.MaKho == MaKho)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
