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
        //???????
        public void ThemChiTietPhongChieuToDSVatTuCoSan(ChiTietPhongChieuDTO pc,ref List<ChiTietPhongChieuView> dsVatTuDaChon)
        {
            bool daTonTai = false;
            foreach (ChiTietPhongChieuView i in dsVatTuDaChon)
            {
                if (i.MaVatTu == pc.MaVatTu)
                {
                    daTonTai = true;
                    i.SoLuong += pc.SoLuongSP;
                }
            }
            if (!daTonTai)
            {
                dsVatTuDaChon.Add(ConvertCTPhongChieuDTOToView(pc));
            }
        }
        //???????////////////////////////////////////////////
        public void XoaChiTietPhongChieuToDSVatTuCoSan(ChiTietPhongChieuDTO pc, ref List<ChiTietPhongChieuView> ds)
        {
            foreach (ChiTietPhongChieuView i in ds)
            {
                if (i.MaVatTu == pc.MaVatTu)
                {
                    i.SoLuong -= pc.SoLuongSP;
                    if(i.SoLuong > 0)
                    {
                        ds.Add(ConvertCTPhongChieuDTOToView(pc));
                        break;
                    }
                }
            }
            
               
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
        public void  CapNhatChiTietPhongChieu(List<ChiTietPhongChieuView> l1, List<ChiTietPhongChieuView> l2)
        {
            bool daTonTai = false;
            // da ton tai thi cong so luong vao l1
            foreach (ChiTietPhongChieuView i in l1)
            {
               foreach(ChiTietPhongChieuView j in l2)
               {
                    if(i.MaVatTu == j.MaVatTu)
                    {
                        i.SoLuong += j.SoLuong;
                        daTonTai = true;
                    }
               }
               if(daTonTai)
                    l2.Remove(l2.Find(x => x.MaVatTu == i.MaVatTu));
            }
            l1.AddRange(l2);
            foreach (ChiTietPhongChieuView i in l1)
            {
                 ChiTietPhongChieuDTO phongChieuDTO = new ChiTietPhongChieuDTO
                 {
                     MaPhongChieu = i.MaPhongChieu,
                     DonViTinh = i.DonViTinh,
                     MaVatTu = i.MaVatTu,
                     SoLuongSP = i.SoLuong
                 };
                CheckAddUpdateChiTietPhongChieu(phongChieuDTO);
            }
            XoaChiTietPhongChieu(l1);
        }
        public void CheckAddUpdateChiTietPhongChieu(ChiTietPhongChieuDTO pc)
        {
            bool add = true;
            foreach (ChiTietPhongChieuDTO i in GetAllVatTuByMaPhongChieu(pc.MaPhongChieu))
            {
                if (i.MaVatTu == pc.MaVatTu)
                {
                    add = false;
                    break;
                }
            }
            if(add)
            {
                ChiTietPhongChieuDAL.Instance.ThemChiTietPhongChieu(pc);
            }
            else
            {
                ChiTietPhongChieuDAL.Instance.CapNhatChiTietPhongChieu(pc);
            }
        }
        public void XoaChiTietPhongChieu(List<ChiTietPhongChieuView> dsCTPCVT)
        {
            if(dsCTPCVT != null)
            {
                var ds = GetAllVatTuByMaPhongChieu(dsCTPCVT[0].MaPhongChieu);
                foreach (var i in dsCTPCVT)
                {
                    int index = ds.FindIndex(x => x.MaVatTu == i.MaVatTu);
                    if (index >= 0)
                        ds.RemoveAt(index);
                }
                if (ds.Count > 0)
                    foreach (var i in ds)
                    {
                        ChiTietPhongChieuDAL.Instance.XoaChiTietPhongChieu(i);
                    }
            }
           
        }
        public List<ChiTietPhongChieuView> TimKiemVatTuTrongPhongChieu(string txt, string maPhongChieu)
        {
            return GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu).FindAll(x => x.TenVatTu.Contains(txt) || x.MaVatTu.Contains(txt));   
        }
    }
}
