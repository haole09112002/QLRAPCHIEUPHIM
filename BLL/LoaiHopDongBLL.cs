using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class LoaiHopDongBLL
    {
        private static LoaiHopDongBLL instance;
        public static LoaiHopDongBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiHopDongBLL();
                }
                return instance;
            }
            private set { }
        }

        private LoaiHopDongBLL()
        {

        }
        public List<CBBItem> GetCBBLoaiHopDong()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LoaiHopDongDTO i in LoaiHopDongDAL.Instance.GetAllLoaiHopDong())
            {
                data.Add(new CBBItem
                { Value = i.MaLoaiHopDong, Text = i.TenLoaiHopDong });
            }
            return data;
        }
        public string KiemTraLoaiHopDong(string maHopDong)
        {
            foreach(HopDongDTO i in HopDongDAL.Instance.GetAllHopDong())
            {
                if (i.MaHopDong == maHopDong)
                    return i.MaLoaiHopDong;
            }
            return null;
        }

    }
}
