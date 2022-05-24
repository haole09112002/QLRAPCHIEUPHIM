using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichChieuDAL
    {
        public static LichChieuDAL instance;
        public static LichChieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichChieuDAL();
                }
                return instance;
            }
            set { }
        }
        public List<LichChieuDTO> GetAllLichChieu()
        {
            List<LichChieuDTO> listLichChieu = new List<LichChieuDTO>();
            string query = "Select * from LICH_CHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listLichChieu.Add(new LichChieuDTO
                {
                    MaPhim = i["MaPhim"].ToString(),
                    MaKhungGioChieu = i["MaKhungGioChieu"].ToString(),
                    MaPhongChieu = i["MaPhongChieu"].ToString(),
                    TrangThai = Convert.ToBoolean(i["TrangThai"].ToString()),
                    NgayChieu = Convert.ToDateTime(i["NgayChieu"].ToString())
                });
            }
            return listLichChieu;
        }
        public LichChieuDTO GetLichChieuByDataRow(DataRow i)
        {
            return new LichChieuDTO()
            {
                MaPhim = i["MaPhim"].ToString(),
                MaPhongChieu = i["MaPhongChieu"].ToString(),
                MaKhungGioChieu = (i["MakhungGioChieu"].ToString()),
                NgayChieu = Convert.ToDateTime(i["NgayChieu"].ToString()),
                TrangThai = Convert.ToBoolean(i["TrangThai"].ToString()),
            };
        }
        public List<LichChieuDTO> TimTheoMa(string maPhim)
        {
            List<LichChieuDTO> data = new List<LichChieuDTO>();
            string query = $"SELECT * FROM LICH_CHIEU WHERE MaPhim LIKE '%{maPhim}%'";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLichChieuByDataRow(i));
            }
            return data;
        }
        public void XoaLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu)
        {
            string query = "Delete from LICH_CHIEU where MaPhim = '" + MaPhim + "' and MaKhungGioChieu = '" + MaKhungGioChieu +
                "' and MaPhongChieu = '" + MaPhongChieu + "'";
            DBHelper.Instance.ExcuteQuery(query);
        }
    }
}
