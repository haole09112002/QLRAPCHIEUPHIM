using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;

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
        private PhongChieuBLL()
        {

        }
        public List<PhongChieuDTO> GetAllPhongChieu()
        {
            return PhongChieuDAL.Instance.GetAllPhongChieu();
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
