using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhongChieuBLL
    {
        private static ChiTietPhongChieuBLL instance;
        public static ChiTietPhongChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhongChieuBLL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietPhongChieuBLL()
        {

        }
        public List<ChiTietPhongChieuDTO> GetAllChiTietPhongChieu()
        {
            return ChiTietPhongChieuDAL.Instance.GetAllChiTietPhongChieu();
        }
        public List<VatTuDTO> GetAllVatTuByMaPhongChieu(string maPhongChieu)
        {
            List<VatTuDTO> data = new List<VatTuDTO>();
            foreach (ChiTietPhongChieuDTO i in GetAllChiTietPhongChieu())
            {
                    if(i.MaPhongChieu == maPhongChieu)
                       data.Add(VatTuBLL.Instance.GetVatTuByMaVatTu(i.MaVatTu));
            }
            return data;
        }
    }
}
