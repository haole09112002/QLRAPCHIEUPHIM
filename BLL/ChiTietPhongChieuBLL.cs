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
        public void ThemChiTietPhongChieuToDSVatTuDaChon(ChiTietPhongChieuDTO pc,ref List<ChiTietPhongChieuView> dsVatTuDaChon)
        {
            //bool daTonTai = false;
            //foreach(ChiTietPhongChieuView i in dsVatTuDaChon)
            //{
            //    if (i.MaVatTu == pc.MaVatTu)
            //    {
            //        daTonTai = true;
            //        i.SoLuong += pc.SoLuongSP;
            //    }
            //}
            //if(!daTonTai)
            //{
                dsVatTuDaChon.Add(ConvertCTPhongChieuDTOToView(pc));
            //}
        }
        public ChiTietPhongChieuView ConvertCTPhongChieuDTOToView(ChiTietPhongChieuDTO pc)
        {
            string tenVatTu = "";
            foreach(VatTuDTO i in VatTuDAL.Instance.GetALLVatTu())
            {
                if (i.MaVatTu == pc.MaVatTu)
                    tenVatTu = i.TenVatTu;
            }
            return new ChiTietPhongChieuView
            {
                MaPhongChieu = pc.MaPhongChieu,
                MaVatTu = pc.MaVatTu,
                TenVatTu = tenVatTu,
                SoLuong = pc.SoLuongSP,
                DonViTinh = pc.DonViTinh
            };
        }
        public List<ChiTietPhongChieuView> GetAllCTPhongChieuViewByMaPhongChieu(string maPhongChieu)
        {
            List<ChiTietPhongChieuView> data = new List<ChiTietPhongChieuView>();
            foreach(ChiTietPhongChieuDTO i in GetAllVatTuByMaPhongChieu(maPhongChieu))
            {
                data.Add(ConvertCTPhongChieuDTOToView(i));
            }    
            return data;
        }

    }
}
