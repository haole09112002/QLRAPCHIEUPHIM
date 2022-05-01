using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;

namespace BLL
{
    public class LoaiNhaCungCapBLL
    {
        private static LoaiNhaCungCapBLL instance;
        public static LoaiNhaCungCapBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiNhaCungCapBLL();
                }
                return instance;
            }
            private set { }
        }
        
        private LoaiNhaCungCapBLL()
        {

        }
        public List<CBBItem> GetCBBLoaiNhaCungCap()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LoaiNhaCungCapDTO i in LoaiNhaCungCapDAL.Instance.GetAllLoaiNhaCungCap())
            {
                data.Add(new CBBItem
                { Value = i.MaLoaiNhaCungCap, Text = i.TenLoaiNhaCungCap });
            }
            return data;
        }

    }
}
