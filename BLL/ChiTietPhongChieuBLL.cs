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
        public List<ChiTietPhongChieuDTO> GetAllVatTuByMaPhongChieu(string maPhongChieu)
        {
            List<ChiTietPhongChieuDTO> data = new List<ChiTietPhongChieuDTO>();
            foreach (ChiTietPhongChieuDTO i in GetAllChiTietPhongChieu())
            {
                    if(i.MaPhongChieu == maPhongChieu)
                       data.Add(i);
            }
            return data;
        }
        public void ThemChiTietPhongChieuToDSVatTuDaChon(ChiTietPhongChieuDTO pc,ref List<ChiTietPhongChieuDTO> dsVatTuDaChon)
        {
            bool daTonTai = false;
            foreach(ChiTietPhongChieuDTO i in dsVatTuDaChon)
            {
                if (i.MaVatTu == pc.MaVatTu)
                {
                    daTonTai = true;
                    i.SoLuongSP += pc.SoLuongSP;
                }
            }
            if(!daTonTai)
            {
                dsVatTuDaChon.Add(pc);
            }
        }
        
    }
}
