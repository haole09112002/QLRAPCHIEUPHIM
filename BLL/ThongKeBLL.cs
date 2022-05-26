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
            //foreach(ChiTietKhoPhimDTO i in chiti)
            return 0;
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
        public List<ThongKeTienNhapPhimDTO> ThongKeTienNhapPhim(string maloaiHopDong, DateTime ngayBD, DateTime ngayKT)
        {
            var result = new List<ThongKeTienNhapPhimDTO>();

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

            return result;
        }
        public List<ThongKeTienNhapPhimDTO> TinhTienPhim(List<HopDongDTO> dsHD)
        {
            var result = new List<ThongKeTienNhapPhimDTO>();
            foreach (var i in dsHD)
            {
                var hd = HopDongPhimBLL.Instance.GetListHopDongPhimByMaHopDongHao(i.MaHopDong);
                double tongTien = 0;
                foreach (var h in hd)
                {
                    tongTien += h.SoLuong * h.GiaTien;
                }
                result.Add(new ThongKeTienNhapPhimDTO { MaHopDong = i.MaHopDong, TenHopDong = i.TenHopDong, TongTien = tongTien, LoaiHopDong = i.MaLoaiHopDong });
            }
            return result;
        }
        public List<ThongKeTienNhapPhimDTO> TinhTienVatTu(List<HopDongDTO> dsHD)
        {
            var result = new List<ThongKeTienNhapPhimDTO>();
            foreach (var i in dsHD)
            {
                var hd = HopDongVatTuBLL.Instance.GetListHopDongVatTuByMaHopDong(i.MaHopDong);
                double tongTien = 0;
                foreach (var h in hd)
                {
                    tongTien += h.SoLuong * h.GiaTien;
                }
                result.Add(new ThongKeTienNhapPhimDTO { MaHopDong = i.MaHopDong, TenHopDong = i.TenHopDong, TongTien = tongTien, LoaiHopDong = i.MaLoaiHopDong });
            }
            return result;
        }
        public List<ThongKeTienNhapPhimDTO> TinhTienThucAn(List<HopDongDTO> dsHD)
        {
            var result = new List<ThongKeTienNhapPhimDTO>();
            foreach (var i in dsHD)
            {
                var hd = HopDongThucAnBLL.Instance.GetListHopDongThucAnByMaHopDong(i.MaHopDong);
                double tongTien = 0;
                foreach (var h in hd)
                {
                    tongTien += h.SoLuong * h.GiaTien;
                }
                result.Add(new ThongKeTienNhapPhimDTO { MaHopDong = i.MaHopDong, TenHopDong = i.TenHopDong, TongTien = tongTien, LoaiHopDong = i.MaLoaiHopDong });
            }
            return result;
        }
        public int SoLuongPhieu(DateTime ngayBD, DateTime ngayKT, string maLoaiPhieu, string maLoaiNCC)
        {
            var dsPhieu =PhieuBLL.Instance.GetListPhieuByLoaiPhieu(maLoaiPhieu).Where(p => p.NgayLapPhieu >= ngayBD && p.NgayLapPhieu <= ngayKT).Select(p => p);
            int count = 0;
            if(maLoaiNCC == "LNCC01")
            {
                var dsCTPhieu = ChiTietPhieuPhimBLL.Instance.GetAllChiTietPhieuPhim();
                foreach (var h in dsPhieu)
                {
                    foreach (var p in dsCTPhieu)
                        if (h.MaPhieu == p.MaPhieu)
                            count++;

                }
                return count;
            }
            if (maLoaiNCC == "LNCC02")
            {
                var dsCTPhieu = chitiet.Instance.GetAllChiTietPhieuPhim();
                foreach (var h in dsPhieu)
                {
                    foreach (var p in dsCTPhieu)
                        if (h.MaPhieu == p.MaPhieu)
                            count++;

                }
                return count;
            }
            if (maLoaiNCC == "LNCC03")
            {
                var dsCTPhieu = ChiTietPhieuPhimBLL.Instance.GetAllChiTietPhieuPhim();
                foreach (var h in dsPhieu)
                {
                    foreach (var p in dsCTPhieu)
                        if (h.MaPhieu == p.MaPhieu)
                            count++;

                }
                return count;
            }
        }


    }
}
