using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ThucAnBLL
    {
        private static ThucAnBLL instance;
        public static ThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThucAnBLL();
                }
                return instance;
            }
            set { }
        }
        public List<ThucAnViewDTO> GetThucAnViews(string txt)
        {
            List<ThucAnViewDTO> data = new List<ThucAnViewDTO>();
            foreach (ThucAnDTO i in ThucAnDAL.Instance.GetALLThucAn())
            {
                if (i.TenThucAn.Contains(txt))
                {
                    data.Add(new ThucAnViewDTO
                    {
                        MaThucAn = i.MaThucAn,
                        TenThucAn = i.TenThucAn,
                        DonViTinh = i.DonViTinh,
                        SoLuong = i.SoLuong,
                    });
                }
            }
            return data;
        }
        public List<ThucAnDTO> GetAllThucAn()
        {

            return ThucAnDAL.Instance.GetALLThucAn();

        }
        public ThucAnDTO GetThucAnByMaThucAn(string MaThucAn)
        {
            ThucAnDTO data = new ThucAnDTO();
            foreach (ThucAnDTO i in ThucAnDAL.Instance.GetALLThucAn())
            {
                if (i.MaThucAn == MaThucAn)
                {
                    data.MaThucAn = i.MaThucAn;
                    data.TenThucAn = i.TenThucAn;
                    data.DonViTinh = i.DonViTinh;
                    data.SoLuong = i.SoLuong;
                }
            }
            return data;
        }
    }
}
