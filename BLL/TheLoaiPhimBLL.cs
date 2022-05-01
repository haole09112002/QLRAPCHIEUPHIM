using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TheLoaiPhimBLL
    {
        public static TheLoaiPhimBLL instance;
        public static TheLoaiPhimBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TheLoaiPhimBLL();
                }
                return instance;
            }
            set { }
        }
        public TheLoaiPhimDTO GetTenTLByMaTL(string MaTheLoaiPhim)
        {
            TheLoaiPhimDTO data = new TheLoaiPhimDTO();
            foreach(TheLoaiPhimDTO i in TheLoaiPhimDAL.Instance.GetAllTheLoaiPhim())
            {
                if(i.MaTheLoaiPhim == MaTheLoaiPhim)
                {
                    data.MaTheLoaiPhim = i.MaTheLoaiPhim;
                    data.TenTheLoaiPhim = i.TenTheLoaiPhim;
                }
            }
            return data;
        }
    }
}
