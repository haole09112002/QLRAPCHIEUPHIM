using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DeXuatViewBLL
    {
        private static DeXuatViewBLL instance;
        public static DeXuatViewBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatViewBLL();
                }
                return instance;
            }
            private set { }
        }

      

        //public List<DeXuatViewDTO> GetDeXuatViewByTrangThai(string TrangThai, string TimKiem = "", string LoaiTimKiem = "")
        //{
        //    List<DeXuatViewDTO> data = new List<DeXuatViewDTO>();
        //    foreach (DeXuatDTO i in DeXuatBLL.Instance.GetAllDeXuat())
        //    {
        //        if (LoaiTimKiem == "")
        //        {
        //            if (i.TrangThai == TrangThai)
        //            {
        //                data.Add(new DeXuatViewDTO
        //                {
        //                    MaDeXuat = i.MaDeXuat,
        //                    TenNhanVien =NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,
        //                    NgayDeXuat = i.NgayDeXuat,
        //                    TenLoaiDeXuat = LoaiDeXuatBLL.Instance.GetLoaiDeXuatByMaLoaiDeXuat(i.MaLoaiDeXuat).TenLoaiDeXuat,
        //                    MaNhanVien = i.MaNhanVien,
        //                    MaLoaiDeXuat = i.MaLoaiDeXuat,
        //                    TrangThai = i.TrangThai
        //                });
        //            }
        //        }
        //        if (LoaiTimKiem == "Tên Nhân Viên")
        //        {
        //            if (i.TrangThai == TrangThai && NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien.Contains(TimKiem))
        //            {
        //                data.Add(new DeXuatViewDTO
        //                {
        //                    MaDeXuat = i.MaDeXuat,
        //                    TenNhanVien = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,
        //                    NgayDeXuat = i.NgayDeXuat,
        //                    TenLoaiDeXuat = LoaiDeXuatBLL.Instance.GetLoaiDeXuatByMaLoaiDeXuat(i.MaLoaiDeXuat).TenLoaiDeXuat,
        //                    MaNhanVien = i.MaNhanVien,
        //                    MaLoaiDeXuat = i.MaLoaiDeXuat,
        //                    TrangThai = i.TrangThai
        //                });
        //            }
        //        }
        //        else if (LoaiTimKiem == "Ngày Nhập Xuất")
        //        {
        //            if (i.TrangThai == TrangThai && DeXuatBLL.Instance.GetDeXuatByMaDeXuat(i.MaDeXuat).NgayDeXuat.ToString().Contains(TimKiem))
        //            {
        //                data.Add(new DeXuatViewDTO
        //                {
        //                    MaDeXuat = i.MaDeXuat,
        //                    TenNhanVien = NhanVienBLL.Instance.GetNhanVienByMaNhanVien(i.MaNhanVien).TenNhanVien,
        //                    NgayDeXuat = i.NgayDeXuat,
        //                    TenLoaiDeXuat = LoaiDeXuatBLL.Instance.GetLoaiDeXuatByMaLoaiDeXuat(i.MaLoaiDeXuat).TenLoaiDeXuat,
        //                    MaNhanVien = i.MaNhanVien,
        //                    MaLoaiDeXuat = i.MaLoaiDeXuat,
        //                    TrangThai = i.TrangThai
        //                });
        //            }
        //        }
        //    }
        //    return data;
        //}
    }
}
