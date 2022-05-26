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
            set { }
        }
        public List<LoaiPhieuDTO> GetAllLoaiPhieu()
        {
            return LoaiPhieuDAL.Instance.GetAllLoaiPhieu();
        }
    }
}
