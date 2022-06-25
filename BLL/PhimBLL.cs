using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BLL
{
    public class PhimBLL
    {
        public delegate bool Compare(object a, object b);
        private static PhimBLL instance;
        public static PhimBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhimBLL();
                }
                return instance;
            }
            set { }
        }
        public List<PhimViewDTO> GetPhimViews(string txt = "", string TimKiem = "")
        {
            List<PhimViewDTO> data = new List<PhimViewDTO>();
            List<TheLoaiPhimDTO> TLP = new List<TheLoaiPhimDTO>();
            TLP = TheLoaiPhimDAL.Instance.GetAllTheLoaiPhim();
            string HopDong = "";
            foreach (PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                string TheLoaiPhim = "";
                string TenHangSanXuatPhim = "";
                HopDong = "Chưa có HĐ";
                foreach(TongSoLuongPhimDTO j in HopDongPhimBLL.Instance.GetTongSoLuongCuaTungPhim())
                {
                    if(j.MaPhim == i.MaPhim)
                    {
                        HopDong = "Hết hợp đồng";
                        foreach(string z in HopDongPhimBLL.Instance.GetDanhSachMaPhimConHopDong())
                        {
                            if(z == i.MaPhim)
                            {
                                HopDong = "Còn hợp đồng";
                            }
                        }
                    }
                }
                if (TimKiem == "Tên Phim" || TimKiem == "")
                    if (i.TenPhim.ToLower().Contains(txt.ToLower()))
                    {
                        foreach (TheLoaiPhimDTO j in TLP.ToArray())
                        {
                            if (i.MaTheLoai == j.MaTheLoaiPhim)
                            {
                                TheLoaiPhim = j.TenTheLoaiPhim;
                            }
                        }
                        foreach (HangSanXuatPhimDTO k in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
                        {
                            if (k.MaHangSanXuatPhim == i.MaHangSanXuatPhim)
                            {
                                TenHangSanXuatPhim = k.TenHangSanXuatPhim;
                            }
                        }
                        data.Add(new PhimViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = i.TenPhim,
                            ThoiLuong = i.ThoiLuong,
                            QuocGia = i.QuocGia,
                            NamSanXuat = i.NamSanXuat,
                            TenHangSanXuatPhim = TenHangSanXuatPhim,
                            DoTuoiXem = i.DoTuoiXem,
                            TheLoai = TheLoaiPhim,
                            HopDong = HopDong
                        });
                    }
                if (TimKiem == "Quốc Gia")
                    if (i.QuocGia.ToLower().Contains(txt.ToLower()))
                    {
                        foreach (TheLoaiPhimDTO j in TLP.ToArray())
                        {
                            if (i.MaTheLoai == j.MaTheLoaiPhim)
                            {
                                TheLoaiPhim = j.TenTheLoaiPhim;
                            }
                        }
                        foreach (HangSanXuatPhimDTO k in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
                        {
                            if (k.MaHangSanXuatPhim == i.MaHangSanXuatPhim)
                            {
                                TenHangSanXuatPhim = k.TenHangSanXuatPhim;
                            }
                        }
                        data.Add(new PhimViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = i.TenPhim,
                            ThoiLuong = i.ThoiLuong,
                            QuocGia = i.QuocGia,
                            NamSanXuat = i.NamSanXuat,
                            TenHangSanXuatPhim = TenHangSanXuatPhim,
                            DoTuoiXem = i.DoTuoiXem,
                            TheLoai = TheLoaiPhim,
                            HopDong = HopDong
                        });
                    }
                if (TimKiem == "Thời Lượng")
                    if (i.ThoiLuong.ToString().Contains(txt))
                    {
                        foreach (TheLoaiPhimDTO j in TLP.ToArray())
                        {
                            if (i.MaTheLoai == j.MaTheLoaiPhim)
                            {
                                TheLoaiPhim = j.TenTheLoaiPhim;
                            }
                        }
                        foreach (HangSanXuatPhimDTO k in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
                        {
                            if (k.MaHangSanXuatPhim == i.MaHangSanXuatPhim)
                            {
                                TenHangSanXuatPhim = k.TenHangSanXuatPhim;
                            }
                        }
                        data.Add(new PhimViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = i.TenPhim,
                            ThoiLuong = i.ThoiLuong,
                            QuocGia = i.QuocGia,
                            NamSanXuat = i.NamSanXuat,
                            TenHangSanXuatPhim = TenHangSanXuatPhim,
                            DoTuoiXem = i.DoTuoiXem,
                            TheLoai = TheLoaiPhim,
                            HopDong = HopDong
                        });
                    }
                if (TimKiem == "Năm Sản Xuất")
                    if (i.NamSanXuat.ToShortDateString().Contains(txt))
                    {
                        foreach (TheLoaiPhimDTO j in TLP.ToArray())
                        {
                            if (i.MaTheLoai == j.MaTheLoaiPhim)
                            {
                                TheLoaiPhim = j.TenTheLoaiPhim;
                            }
                        }
                        foreach (HangSanXuatPhimDTO k in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
                        {
                            if (k.MaHangSanXuatPhim == i.MaHangSanXuatPhim)
                            {
                                TenHangSanXuatPhim = k.TenHangSanXuatPhim;
                            }
                        }
                        data.Add(new PhimViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = i.TenPhim,
                            ThoiLuong = i.ThoiLuong,
                            QuocGia = i.QuocGia,
                            NamSanXuat = i.NamSanXuat,
                            TenHangSanXuatPhim = TenHangSanXuatPhim,
                            DoTuoiXem = i.DoTuoiXem,
                            TheLoai = TheLoaiPhim,
                            HopDong = HopDong,
                        });
                    }
                if(TimKiem == "Tên Hãng Sản Xuất Phim")
                {
                    foreach(HangSanXuatPhimDTO j in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
                    {
                        if(i.MaHangSanXuatPhim == j.MaHangSanXuatPhim)
                        {
                            TenHangSanXuatPhim = j.TenHangSanXuatPhim;
                            break;
                        }
                    }
                    if(TenHangSanXuatPhim.Contains(txt))
                    {
                        foreach (TheLoaiPhimDTO j in TLP.ToArray())
                        {
                            if (i.MaTheLoai == j.MaTheLoaiPhim)
                            {
                                TheLoaiPhim = j.TenTheLoaiPhim;
                            }
                        }
                        data.Add(new PhimViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = i.TenPhim,
                            ThoiLuong = i.ThoiLuong,
                            QuocGia = i.QuocGia,
                            NamSanXuat = i.NamSanXuat,
                            TenHangSanXuatPhim = TenHangSanXuatPhim,
                            DoTuoiXem = i.DoTuoiXem,
                            TheLoai = TheLoaiPhim,
                            HopDong = HopDong
                        });
                    }
                }
                if(TimKiem == "Thể Loại")
                {
                    foreach (TheLoaiPhimDTO j in TLP.ToArray())
                    {
                        if (i.MaTheLoai == j.MaTheLoaiPhim)
                        {
                            TheLoaiPhim = j.TenTheLoaiPhim;
                        }
                    }
                    if (TheLoaiPhim.ToLower().Contains(txt.ToLower()))
                    {
                        foreach (HangSanXuatPhimDTO j in HangSanXuatPhimDAL.Instance.GetAllHangSanXuatPhim())
                        {
                            if (i.MaHangSanXuatPhim == j.MaHangSanXuatPhim)
                            {
                                TenHangSanXuatPhim = j.TenHangSanXuatPhim;
                                break;
                            }
                        }
                        data.Add(new PhimViewDTO
                        {
                            MaPhim = i.MaPhim,
                            TenPhim = i.TenPhim,
                            ThoiLuong = i.ThoiLuong,
                            QuocGia = i.QuocGia,
                            NamSanXuat = i.NamSanXuat,
                            TenHangSanXuatPhim = TenHangSanXuatPhim,
                            DoTuoiXem = i.DoTuoiXem,
                            TheLoai = TheLoaiPhim,
                            HopDong = HopDong
                        });
                    }
                }
            }
            return data;
        }
        public PhimDTO GetPhimByMaPhim(string MaPhim)
        {
            PhimDTO data = new PhimDTO();
            foreach (PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                if (i.MaPhim == MaPhim)
                {
                    data.MaPhim = i.MaPhim;
                    data.TenPhim = i.TenPhim;
                    data.AnhPhim = i.AnhPhim;
                    data.ThoiLuong = i.ThoiLuong;
                    data.QuocGia = i.QuocGia;
                    data.NamSanXuat = i.NamSanXuat;
                    data.MaHangSanXuatPhim = i.MaHangSanXuatPhim;
                    data.DoTuoiXem = i.DoTuoiXem;
                    data.MaTheLoai = i.MaTheLoai;
                    data.NoiDung = i.NoiDung;
                }
            }
            return data;
        }
        public List<PhimViewDTO> SortPhimView(Compare compare, string txt = "", string TimKiem = "")
        {
            List<PhimViewDTO> data = new List<PhimViewDTO>();
            data = GetPhimViews(txt,TimKiem);
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (compare(data[i], data[j]))
                    {
                        PhimViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }
        public bool CompareMaPhim(object o1, object o2)
        {
            return String.Compare(((PhimViewDTO)o1).MaPhim, ((PhimViewDTO)o2).MaPhim) > 0;
        }
        public bool CompareTenPhim(object o1, object o2)
        {
            return String.Compare(((PhimViewDTO)o1).TenPhim, ((PhimViewDTO)o2).TenPhim) > 0;
        }
        public bool CompareThoiLuong(object o1, object o2)
        {
            return ((PhimViewDTO)o1).ThoiLuong > ((PhimViewDTO)o2).ThoiLuong;
        }
        public bool CompareQuocGia(object o1, object o2)
        {
            return String.Compare(((PhimViewDTO)o1).QuocGia, ((PhimViewDTO)o2).QuocGia) > 0;
        }
        public bool CompareNamSanXuat(object o1, object o2)
        {
            return DateTime.Compare(((PhimViewDTO)o1).NamSanXuat, ((PhimViewDTO)o2).NamSanXuat) > 0;
        }
        public bool CompareTheLoai(object o1, object o2)
        {
            return String.Compare(((PhimViewDTO)o1).TheLoai, ((PhimViewDTO)o2).TheLoai) > 0;
        }
        public byte[] ChuyenAnhThanhMangByte(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
        public Image ChuyeMangByteSangAnh(byte[] byteArray)
        {
            MemoryStream memoryStream = new MemoryStream(byteArray, 0, byteArray.Length);
            memoryStream.Write(byteArray, 0, byteArray.Length);
            return Image.FromStream(memoryStream, true);
        }
        public void LuuPhim(PhimDTO phim)
        {
            PhimDAL.Instance.LuuDuLieuPhim(phim);
        }
        public List<CBBItem> GetCBBPhim()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                data.Add(new CBBItem
                { Value = i.MaPhim, Text = i.TenPhim });
            }
            return data;
        }
        public string GetMaPhimAddNew()
        {
            return PhimDAL.Instance.GetMaPhimAddNew();
        }
        public List<PhimDTO> GetAllPhim()
        {
            List<PhimDTO> data = new List<PhimDTO>();
            foreach(PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                data.Add(i);
            }
            return data;
        }
        public List<PhimDTO> GetAllPhimCoHopDong(string txt = "")
        {
            List<PhimDTO> data = new List<PhimDTO>();
            foreach(string i in HopDongPhimBLL.Instance.GetDanhSachMaPhimConHopDong())
            {
                if(PhimBLL.Instance.GetPhimByMaPhim(i).TenPhim.Contains(txt))
                {
                    data.Add(PhimBLL.Instance.GetPhimByMaPhim(i));
                }
            }
            return data;
        }
    }
}
