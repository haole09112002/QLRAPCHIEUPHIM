using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class LichLamViecDAL
    {
        private static LichLamViecDAL instance;

        public static LichLamViecDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichLamViecDAL();
                }
                return instance;
            }
            private set { }
        }
        private LichLamViecDAL()
        {

        }
        public List<LichLamViecDTO> GetAllLichLamViec()
        {
            List<LichLamViecDTO> data = new List<LichLamViecDTO>();
            string query = "select * from lICH_LAM_VIEC";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetLichLamViecByDataRow(i));
            }
            return data;
        }
        public LichLamViecDTO GetLichLamViecByDataRow(DataRow i)
        {
            return new LichLamViecDTO()
            {
                MaNhanVien = i["MaNhanVien"].ToString(),
                MaCa = i["MaCa"].ToString(),
                NgayLamViec = Convert.ToDateTime(i["NgayLamViec"].ToString()),
            };
        }
        public void XoaLichLamViec(string maNhanVien, string maCa,DateTime ngayLamViec)
        {
            string query = "EXEC XoaLichLamViec @MaNhanVien , @MaCa , @NgayLamViec";
            object[] parameter = { maNhanVien, maCa, ngayLamViec };
            DBHelper.Instance.ExcuteNonQuery(query,parameter);
        }
        public void ThemLichLamViec(string maNhanVien, string maCa, DateTime ngayLamViec)
        {
            string query = "EXEC ThemLichLamViec @MaNhanVien , @MaCa , @NgayLamViec";
            object[] parameter = { maNhanVien, maCa, ngayLamViec };
            DBHelper.Instance.ExcuteNonQuery(query, parameter);
        }
    }
}
