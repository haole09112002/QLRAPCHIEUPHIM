using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

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
        public List<PhimViewDTO> GetPhimViews(string txt = "")
        {
            List<PhimViewDTO> data = new List<PhimViewDTO>();
            List<TheLoaiPhimDTO> TLP = new List<TheLoaiPhimDTO>();
            TLP = TheLoaiPhimDAL.Instance.GetAllTheLoaiPhim();
            foreach (PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                string TheLoaiPhim = "";
                string TenHangSanXuatPhim = "";
                if(i.TenPhim.Contains(txt))
                {
                    foreach(TheLoaiPhimDTO j in TLP.ToArray())
                    {
                        if(i.MaTheLoai == j.MaTheLoaiPhim)
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
                        TheLoai = TheLoaiPhim
                    });
                }
            }
            return data;
        }
        public PhimDTO GetPhimByMaPhim(string MaPhim)
        {
            PhimDTO data = new PhimDTO();
            foreach (PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                if(i.MaPhim == MaPhim)
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
        public List<PhimViewDTO> SortPhimView(Compare compare)
        {
            List<PhimViewDTO> data = new List<PhimViewDTO>();
            data = GetPhimViews("");
            for(int i = 0; i < data.Count - 1; i++)
                for(int j = i + 1; j < data.Count; j++)
                {
                    if(compare(data[i], data[j]))
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
            pictureBox.Image.Save(memoryStream,ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
        public Image ChuyeMangByteSangAnh(byte[] byteArray)
        {
            MemoryStream memoryStream = new MemoryStream(byteArray,0,byteArray.Length);
            memoryStream.Write(byteArray,0,byteArray.Length);
            return Image.FromStream(memoryStream,true);
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
    }
}
