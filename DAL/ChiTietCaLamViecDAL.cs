using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ChiTietCaLamViecDAL
    {
        private static ChiTietCaLamViecDAL instance;

        public static ChiTietCaLamViecDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietCaLamViecDAL();
                }
                return instance;
            }
            private set { }
        }
        private ChiTietCaLamViecDAL()
        {

        }
        public List<ChiTietCaLamViecDTO> GetAllChiTietCaLamViec()
        {
            List<ChiTietCaLamViecDTO> data = new List<ChiTietCaLamViecDTO>();
            string query = "select * from CHI_TIET_CA_LAM_VIEC";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetChiTietCaLamViecByDataRow(i));
            }
            return data;
        }
        public ChiTietCaLamViecDTO GetChiTietCaLamViecByDataRow(DataRow i)
        {
            return new ChiTietCaLamViecDTO()
            {
                MaNhanVien = i["MaNhanVien"].ToString(),
                MaCa = i["MaCa"].ToString(),
                TrangThai = Convert.ToBoolean(i["TrangThai"].ToString()),
            };
        }
    }
}
