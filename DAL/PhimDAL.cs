using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class PhimDAL
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private static PhimDAL instance;
        public static PhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhimDAL();
                }
                return instance;
            }
            set { }
        }
        public List<PhimDTO> GetALLPhim()
        {
            List<PhimDTO> listPhim = new List<PhimDTO>();
            string query = "Select * from PHIM";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listPhim.Add(GetPhimByDataRow(i));
            }
            return listPhim;
        }
        public PhimDTO GetPhimByDataRow(DataRow i)
        {
            if(i["AnhPhim"].ToString() == "")
            {
                return new PhimDTO
                {
                    MaPhim = i["MaPhim"].ToString(),
                    TenPhim = i["TenPhim"].ToString(),
                    AnhPhim = null,
                    ThoiLuong = Convert.ToInt32(i["ThoiLuong"].ToString()),
                    QuocGia = i["QuocGia"].ToString(),
                    NamSanXuat = Convert.ToDateTime(i["NamSanXuat"].ToString()),
                    TenHangPhim = i["TenHangPhim"].ToString(),
                    DoTuoiXem = Convert.ToInt32(i["DoTuoiXem"].ToString()),
                    MaTheLoai = i["MaTheLoai"].ToString(),
                    NoiDung = i["NoiDung"].ToString(),
                    DienVienChinh = i["DienVienCHinh"].ToString(),
                    DienVienPhu = i["DienVienPhu"].ToString(),
                    DaoDien = i["DaoDien"].ToString()
                };
            }
            else
            {
                return new PhimDTO
                {
                    MaPhim = i["MaPhim"].ToString(),
                    TenPhim = i["TenPhim"].ToString(),
                    AnhPhim = (byte[])(i["AnhPhim"]),
                    ThoiLuong = Convert.ToInt32(i["ThoiLuong"].ToString()),
                    QuocGia = i["QuocGia"].ToString(),
                    NamSanXuat = Convert.ToDateTime(i["NamSanXuat"].ToString()),
                    TenHangPhim = i["TenHangPhim"].ToString(),
                    DoTuoiXem = Convert.ToInt32(i["DoTuoiXem"].ToString()),
                    MaTheLoai = i["MaTheLoai"].ToString(),
                    NoiDung = i["NoiDung"].ToString(),
                    DienVienChinh = i["DienVienCHinh"].ToString(),
                    DienVienPhu = i["DienVienPhu"].ToString(),
                    DaoDien = i["DaoDien"].ToString()
                };
            }
        }
        public void LuuDuLieuPhim(PhimDTO phim)
        {
            string query = "Insert into PHIM (TenPhim,ThoiLuong,QuocGia,AnhPhim,NamSanXuat,TenHangPhim,DoTuoiXem,MaTheLoai,NoiDung,DienVienChinh,DienVienPhu,DaoDien) " + $"values('{phim.TenPhim}',{phim.ThoiLuong},'{phim.QuocGia}',@AnhPhim,'{phim.NamSanXuat.Year}-{phim.NamSanXuat.Month}-{phim.NamSanXuat.Day}','{phim.TenHangPhim}',{phim.DoTuoiXem},'{phim.MaTheLoai}','{phim.NoiDung}','{phim.DienVienChinh}','{phim.DienVienPhu}','{phim.DaoDien}')";
            try
            {
                DBHelper.Instance.Command(phim, query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }
    }
}
