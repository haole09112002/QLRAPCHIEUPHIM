using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongChieuBLL
    {
        private static PhongChieuBLL instance;
        public static PhongChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongChieuBLL();
                }
                return instance;
            }
            private set { }
        }
        private PhongChieuBLL()
        {

        }
        public List<PhongChieuDTO> GetAllPhongChieu()
        {
            return PhongChieuDAL.Instance.GetAllPhongChieu();
        }

        public PhongChieuView ConvertPhongChieuDTOToView(PhongChieuDTO pc)
        {
            string tenTinhTrang = "";
            string tenLoaiPhongChieu = "";
            foreach(TinhTrangPhongChieuDTO i  in TinhTrangPhongChieuDAL.Instance.GetAllTinhTrangPhongChieu())
            {
                if (i.MaTinhTrang == pc.MaTinhTrang.ToString())
                    tenTinhTrang = i.TenTinhTrang;
            }
            foreach (LoaiPhongChieuDTO i in LoaiPhongChieuDAL.Instance.GetAllLoaiPhongChieu())
            {
                if (i.MaLoaiPhongChieu == pc.MaLoaiPhongChieu)
                    tenLoaiPhongChieu = i.TenLoaiPhongChieu;
            }
            return new PhongChieuView
            {
                MaPhongChieu = pc.MaPhongChieu,
                TenPhong = pc.TenPhong,
                TenLoaiPhongChieu = tenLoaiPhongChieu,
                TenTinhTrang = tenTinhTrang
            };
        }
        public List<PhongChieuView> GetAllPhongChieuView()
        {
            List<PhongChieuView> data = new List<PhongChieuView>();
            foreach (PhongChieuDTO i in GetAllPhongChieu())
            {
                data.Add(ConvertPhongChieuDTOToView(i));
            }
            return data;
        }
        public PhongChieuView GetPhongChieuViewByMaPhongChieu(string maPhongChieu)
        {
            foreach(PhongChieuView i in GetAllPhongChieuView())
            {
                if(i.MaPhongChieu == maPhongChieu)
                    return i;
            }
            return null;
        }
        
        public PhongChieuDTO GetPhongChieuByMaPC(string MaPhongChieu)
        {
            foreach (PhongChieuDTO i in PhongChieuDAL.Instance.GetAllPhongChieu())
            {
                if (i.MaPhongChieu == MaPhongChieu)
                {
                    return i;
                }
            }
            return null;
        }
        public List<PhongChieuDTO> GetAllPhongChieuByTinhTrang(int TinhTrang, string txt = "")
        {
            List<PhongChieuDTO> data = new List<PhongChieuDTO>();
            foreach(PhongChieuDTO i in PhongChieuDAL.Instance.GetAllPhongChieu())
            {
                if(i.MaTinhTrang == TinhTrang && i.TenPhong.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
    }
}
