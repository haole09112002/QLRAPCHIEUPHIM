using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiPhongChieuBLL
    {
        private static LoaiPhongChieuBLL instance;
        public static LoaiPhongChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiPhongChieuBLL();
                }
                return instance;
            }
            private set { }
        }

        private LoaiPhongChieuBLL()
        {

        }
        public List<CBBItem> GetCBBLoaiPhongChieu()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LoaiPhongChieuDTO i in LoaiPhongChieuDAL.Instance.GetAllLoaiPhongChieu())
            {
                data.Add(new CBBItem
                { Value = i.MaLoaiPhongChieu, Text = i.TenLoaiPhongChieu });
            }
            return data;
        }
    
    }
}
