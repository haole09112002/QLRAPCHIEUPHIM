using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChinhSachBLL
    {
        private static ChinhSachBLL instance;
        public static ChinhSachBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChinhSachBLL();
                }
                return instance;
            }
            private set { }
        }

        private ChinhSachBLL()
        {

        }
        public List<CBBItem> GetCBBChinhSach()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (ChinhSachDTO i in ChinhSachDAL.Instance.GetAllChinhSach())
            {
                data.Add(new CBBItem
                { Value = i.MaChinhSach, Text = i.TenChinhSach });
            }
            return data;
        }
    }
}
