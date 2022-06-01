using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class ThongKeBLL
    {

        private static ThongKeBLL instance;
        public static ThongKeBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeBLL();
                }
                return instance;
            }
            private set { }
        }

        private ThongKeBLL()
        { }
        // 1 tot, 2 hong, 3 bao tri
        public int SoLuongPhongChieu(int maTinhTrang = 0)
        {
            if(maTinhTrang != 0)
                return PhongChieuBLL.Instance.GetAllPhongChieu().FindAll( i => i.MaTinhTrang == maTinhTrang).Count();
            else
            {
                return PhongChieuBLL.Instance.GetAllPhongChieu().Count();
            }    
        }
        public int SoLuongPhimTrongKho()
        {
           
         
            return ChiTietKhoPhimBLL.Instance.GetAllChiTietKhoPhim().Count();
        }
        public int SoLuongNhaCungCap(string maLoaiNCC = "0")
        { 
            int count = 0;
            var dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong();
            var dsNCC = NhaCungCapBLL.Instance.GetNCCByMaLoaiNCC(maLoaiNCC);
            foreach(var i in dsHD)
            {
                int index = dsNCC.FindIndex(x => x.MaNhaCungCap == i.MaNhaCungCap);
                if(index != -1)
                {
                    count++;
                    dsNCC.RemoveAt(index);
                }
            }
            return count;
        }
        public int SoLuongNhanVien(string maChucVu = "")
        {
            if (maChucVu != "")
                return NhanVienBLL.Instance.GetAllNhanVien().FindAll(i => i.MaChucVu == maChucVu).Count();
            else
            {
                return NhanVienBLL.Instance.GetAllNhanVien().Count();
            }
        }
        public List<ThongKeTienNhapDTO> ThongKeTienNhapPhim(string maloaiHopDong, DateTime ngayBD, DateTime ngayKT, Label lbSoLuongHD, Label lbTongTienThanhToanHD, Label lbDocTienThanhChu)
        {
            var result = new List<ThongKeTienNhapDTO>();

            if (maloaiHopDong != "0")
            {

                if (maloaiHopDong == "LHD001")
                {
                    var dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong(maloaiHopDong).Where(hd => hd.NgayKiKetHD >= ngayBD && hd.NgayKiKetHD <= ngayKT).Select(hd => hd);
                    result = TinhTienPhim(dsHD.ToList());

                }
                if (maloaiHopDong == "LHD002")
                {
                    var dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong(maloaiHopDong).Where(hd => hd.NgayKiKetHD >= ngayBD && hd.NgayKiKetHD <= ngayKT).Select(hd => hd);
                    result = TinhTienVatTu(dsHD.ToList());
                }
                if (maloaiHopDong == "LHD003")
                {
                    var dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong(maloaiHopDong).Where(hd => hd.NgayKiKetHD >= ngayBD && hd.NgayKiKetHD <= ngayKT).Select(hd => hd);
                    result = TinhTienThucAn(dsHD.ToList());
                }

            }
            else
            {
                var dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong("LHD001").Where(hd => hd.NgayKiKetHD >= ngayBD && hd.NgayKiKetHD <= ngayKT).Select(hd => hd);
                result = TinhTienPhim(dsHD.ToList());
                dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong("LHD002").Where(hd => hd.NgayKiKetHD >= ngayBD && hd.NgayKiKetHD <= ngayKT).Select(hd => hd);
                result.AddRange(TinhTienVatTu(dsHD.ToList()));
                dsHD = HopDongBLL.Instance.GetHopDongByMaLoaiHopDong("LHD003").Where(hd => hd.NgayKiKetHD >= ngayBD && hd.NgayKiKetHD <= ngayKT).Select(hd => hd);
                result.AddRange(TinhTienThucAn(dsHD.ToList()));
            }
            double tongTien = 0;
            lbSoLuongHD.Text = result.Count().ToString();
            result.ForEach(i => tongTien += i.TongTien);
            lbTongTienThanhToanHD.Text = tongTien.ToString();
            lbDocTienThanhChu.Text = Helper.Instance.NumberToTextVN((decimal)tongTien);
            return result;
        }
        public List<ThongKeTienNhapDTO> TinhTienPhim(List<HopDongDTO> dsHD)
        {
            var result = new List<ThongKeTienNhapDTO>();
            foreach (var i in dsHD)
            {
                var hd = HopDongPhimBLL.Instance.GetListHopDongPhimByMaHopDongHao(i.MaHopDong);
                double tongTien = 0;
                foreach (var h in hd)
                {
                    tongTien += h.SoLuong * h.GiaTien;
                }
                result.Add(new ThongKeTienNhapDTO 
                { 
                    MaHopDong = i.MaHopDong, 
                    TenHopDong = i.TenHopDong, 
                    TongTien = tongTien, 
                    LoaiHopDong = i.MaLoaiHopDong, 
                    TenLoaiHopDong = LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().Find(p => p.Value == i.MaLoaiHopDong).Text 
                });
            }
            return result;
        }
        public List<ThongKeTienNhapDTO> TinhTienVatTu(List<HopDongDTO> dsHD)
        {
            var result = new List<ThongKeTienNhapDTO>();
            foreach (var i in dsHD)
            {
                var hd = HopDongVatTuBLL.Instance.GetListHopDongVatTuByMaHopDong(i.MaHopDong);
                double tongTien = 0;
                foreach (var h in hd)
                {
                    tongTien += h.SoLuong * h.GiaTien;
                }
                result.Add(new ThongKeTienNhapDTO
                {
                    MaHopDong = i.MaHopDong,
                    TenHopDong = i.TenHopDong,
                    TongTien = tongTien,
                    LoaiHopDong = i.MaLoaiHopDong,
                    TenLoaiHopDong = LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().Find(p => p.Value == i.MaLoaiHopDong).Text
                });
            }
            return result;
        }
        public List<ThongKeTienNhapDTO> TinhTienThucAn(List<HopDongDTO> dsHD)
        {
            var result = new List<ThongKeTienNhapDTO>();
            foreach (var i in dsHD)
            {
                var hd = HopDongThucAnBLL.Instance.GetListHopDongThucAnByMaHopDong(i.MaHopDong);
                double tongTien = 0;
                foreach (var h in hd)
                {
                    tongTien += h.SoLuong * h.GiaTien;
                }
                result.Add(new ThongKeTienNhapDTO
                {
                    MaHopDong = i.MaHopDong,
                    TenHopDong = i.TenHopDong,
                    TongTien = tongTien,
                    LoaiHopDong = i.MaLoaiHopDong,
                    TenLoaiHopDong = LoaiHopDongBLL.Instance.GetCBBLoaiHopDong().Find(p => p.Value == i.MaLoaiHopDong).Text
                });
            }
            return result;
        }
        public int SoLuongPhieu(DateTime ngayBD, DateTime ngayKT, string maLoaiPhieu, string maLoaiKho)
        {

            var ds = PhieuBLL.Instance.GetAllPhieu().Where(p => p.NgayLapPhieu >= ngayBD
                                                    && p.NgayLapPhieu <= ngayKT
                                                    && p.MaLoaiPhieu == maLoaiPhieu
                                                    && KhoBLL.Instance.GetKhoByMaKho(p.MaKho).MaLoaiKho == maLoaiKho).Select(p => p).ToList();      
            return ds.Count();
        }


    }
}
