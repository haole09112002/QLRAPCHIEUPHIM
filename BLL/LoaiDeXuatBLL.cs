using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoaiDeXuatBLL
    {
        private static LoaiDeXuatBLL instance;
        public static LoaiDeXuatBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiDeXuatBLL();
                }
                return instance;
            }
            private set { }
        }

        private LoaiDeXuatBLL()
        {

        }
        public List<CBBItem> GetCBBLoaiDeXuat()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LoaiDeXuatDTO i in LoaiDeXuatDAL.Instance.GetAllLoaiDeXuat())
            {
                data.Add(new CBBItem
                { Value = i.MaLoaiDeXuat, Text = i.TenLoaiDeXuat });
            }
            return data;
        }
    }
}
