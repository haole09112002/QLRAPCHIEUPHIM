using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhungGioChieuDAL
    {
        private static KhungGioChieuDAL instance;
        public static KhungGioChieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhungGioChieuDAL();
                }
                return instance;
            }
            set { }
        }
        public List<KhungGioChieuDTO> GetAllKhungGioChieu()
        {
            List<KhungGioChieuDTO> listKhungGioChieu = new List<KhungGioChieuDTO>();
            string query = "Select * from KHUNG_GIO_CHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listKhungGioChieu.Add(new KhungGioChieuDTO
                {
                    MaKhungGioChieu = i["MaKhungGioChieu"].ToString(),
                    TenKhungGio = i["TenKhungGio"].ToString(),
                    TGBatDau = Convert.ToDateTime(i["TGBatDau"].ToString()),
                    TGKetThuc = Convert.ToDateTime(i["TGKetThuc"].ToString())
                });
            }
            return listKhungGioChieu;
        }
    }
}
