using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ChucVuBLL
    {
        private static ChucVuBLL instance;
        public static ChucVuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuBLL();
                }
                return instance;
            }
            private set { }
        }

        private ChucVuBLL()
        {

        }
        public List<CBBItem> GetCBBChucVU()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (ChucVuDTO i in ChucVuDAL.Instance.GetAllChucVu())
            {
                data.Add(new CBBItem
                { Value = i.MaChucVu, Text = i.TenChucVu });
            }
            return data;
        }
    }
}
