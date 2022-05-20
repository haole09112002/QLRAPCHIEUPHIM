using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class TinhTrangPhongChieuBLL
    {
        private static TinhTrangPhongChieuBLL instance;
        public static TinhTrangPhongChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinhTrangPhongChieuBLL();
                }
                return instance;
            }
            private set { }
        }

        private TinhTrangPhongChieuBLL()
        {

        }
        public List<CBBItem> GetCBBTinhTrangPhongChieu()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (TinhTrangPhongChieuDTO i in TinhTrangPhongChieuDAL.Instance.GetAllTinhTrangPhongChieu())
            {
                data.Add(new CBBItem
                { Value = i.MaTinhTrang, Text = i.TenTinhTrang });
            }
            return data;
        }
    }
}
