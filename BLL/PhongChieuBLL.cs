using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhongChieuBLL
    {
        private static PhongChieuBLL instance;
        public static PhongChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongChieuBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<PhongChieuDTO> GetAllPhongChieu()
        {
            List<PhongChieuDTO> data = new List<PhongChieuDTO>();
            foreach (PhongChieuDTO i in PhongChieuDAL.Instance.GetAllPhongChieu())
            {
                data.Add(i);
            }
            return data;
        }
        public PhongChieuDTO GetPhongChieuByMaPC(string MaPhongChieu)
        {
            foreach (PhongChieuDTO i in PhongChieuDAL.Instance.GetAllPhongChieu())
            {
                if (i.MaPhongChieu == MaPhongChieu)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
