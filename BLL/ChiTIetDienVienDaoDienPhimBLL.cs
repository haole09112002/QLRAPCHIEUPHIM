using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTIetDienVienDaoDienPhimBLL
    {
        public static ChiTIetDienVienDaoDienPhimBLL instance;
        public static ChiTIetDienVienDaoDienPhimBLL Instance
        {
            get
            {
                if(instance == null)
                    instance = new ChiTIetDienVienDaoDienPhimBLL();
                return instance;
            }
            private set { }
        }
        public List<ChiTietDienVienDaoDienPhimDTO> GetAllChiTietDienVienDaoDien()
        {
            List<ChiTietDienVienDaoDienPhimDTO> data = new List<ChiTietDienVienDaoDienPhimDTO>();
            foreach (ChiTietDienVienDaoDienPhimDTO i in ChiTietDienVienDaoDienPhimDAL.Instance.GetAllChiTietDienVienDaoDien())
            {
                data.Add(i);
            }
            return data;
        }
        public List<string> GetMaDVDDByMaPhimVaVaiTro(string MaPhim, string VaiTro)
        {
            List<string> data = new List<string>();
            foreach(ChiTietDienVienDaoDienPhimDTO i in ChiTietDienVienDaoDienPhimDAL.Instance.GetAllChiTietDienVienDaoDien())
            {
                if(i.MaPhim == MaPhim && i.VaiTro == VaiTro)
                {
                    data.Add(i.MaDienVienDaoDien);
                }
            }
            return data;
        }
    }
}
