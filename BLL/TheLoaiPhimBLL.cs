using DAL;
using DTO;
using System.Collections.Generic;

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
        public TheLoaiPhimDTO GetTheLoaiByMaTL(string MaTheLoaiPhim)
        {
            TheLoaiPhimDTO data = new TheLoaiPhimDTO();
            foreach (TheLoaiPhimDTO i in TheLoaiPhimDAL.Instance.GetAllTheLoaiPhim())
            {
                if (i.MaTheLoaiPhim == MaTheLoaiPhim)
                {
                    data.MaTheLoaiPhim = i.MaTheLoaiPhim;
                    data.TenTheLoaiPhim = i.TenTheLoaiPhim;
                }
            }
            return data;
        }
        public List<TheLoaiPhimDTO> GetAllTheLoaiPhim()
        {
            List<TheLoaiPhimDTO> data = new List<TheLoaiPhimDTO>();
            foreach (TheLoaiPhimDTO i in TheLoaiPhimDAL.Instance.GetAllTheLoaiPhim())
            {
                data.Add(i);
            }
            return data;
        }
        public string GetTenTLByMaTL(string MaTheLoai)
        {
            foreach(TheLoaiPhimDTO i in TheLoaiPhimDAL.Instance.GetAllTheLoaiPhim())
            {
                if(i.MaTheLoaiPhim == MaTheLoai)
                {
                    return i.TenTheLoaiPhim;
                }
            }
            return null;
        }
    }
}
