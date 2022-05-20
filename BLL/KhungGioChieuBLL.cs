using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhungGioChieuBLL
    {
        private static KhungGioChieuBLL instance;
        public static KhungGioChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhungGioChieuBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<KhungGioChieuDTO> GetAllKhungGioChieu()
        {
            List<KhungGioChieuDTO> data = new List<KhungGioChieuDTO>();
            foreach(KhungGioChieuDTO i in KhungGioChieuDAL.Instance.GetAllKhungGioChieu())
            {
                data.Add(i);
            }
            return data;
        }
        public KhungGioChieuDTO GetKhungGioChieuByMaKGC(string MaKhungGioChieu)
        {
            foreach(KhungGioChieuDTO i in KhungGioChieuDAL.Instance.GetAllKhungGioChieu())
            {
                if(i.MaKhungGioChieu == MaKhungGioChieu)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
