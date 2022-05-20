using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class DeXuatBLL
    {
        private static DeXuatBLL instance;
        public static DeXuatBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatBLL();
                }
                return instance;
            }
            private set { }
        }
        private DeXuatBLL()
        {

        }
        public List<DeXuatDTO> GetDeXuatByMaLoaiDeXuat(string maLoaiDeXuat, string txt = "")
        {
            List<DeXuatDTO> data = new List<DeXuatDTO>();
            if(maLoaiDeXuat == "0")
            {

            }
            else
            {
                foreach(DeXuatDTO i in DeXuatDAL.Instance.GetAllDeXuat())
                {
                    if(i.MaLoaiDeXuat == maLoaiDeXuat )
                    {
                        data.Add(i);    
                    }
                }
            }
            return data;
        }
        //public CBBItem GetCBBItemDeXuatPhim()
        //{
        //    foreach(DeXuatPhimDTO i in DeXuatPhimDAL.Instance.GetllDeXuatPhim())
        //    {
                
        //    }
        //}
       
        public List<CBBItem> GetCBBPhimDeXuat()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (ChiTietDeXuatPhimDTO i in ChiTietDeXuatPhimDAL.Instance.GetllDeXuatPhim())
            {
                foreach (CBBItem j in PhimBLL.Instance.GetCBBPhim())
                {
                    if (j.Value == i.MaPhim)
                    {
                        data.Add(j);
                    }
                }
            }
            return data;
        }
        public void LuuDeXuat(string MaNhanVien, DateTime NgayDeXuat, string MaLoaiDeXuat)
        {
            DeXuatDAL.Instance.LuuDeXuat(MaNhanVien,NgayDeXuat, MaLoaiDeXuat);
        }
        public string GetMaDeXuatAddNew()
        {
            return DeXuatDAL.Instance.GetMaDeXuatAddNew();
        }
    }
}
