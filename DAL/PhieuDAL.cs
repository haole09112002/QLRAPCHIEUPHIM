using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class PhieuDAL
    {
        private static PhieuDAL instance;

        public static PhieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuDAL();
                }
                return instance;
            }
            private set { }
        }
        private PhieuDAL()
        {

        }
        public List<PhieuDTO> GetAllPhieu()
        {
            List<PhieuDTO> data = new List<PhieuDTO>();
            string query = "select * from PHIEU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetPhieuByDataRow(i));
            }
            return data;
        }
        public PhieuDTO GetPhieuByDataRow(DataRow i)
        {
            return new PhieuDTO()
            {
                MaPhieu = i["MaPhieu"].ToString(),
                MaLoaiPhieu = i["MaLoaiPhieu"].ToString(),
                MaKho = i["MaKho"].ToString(),
                MaNhanVien = i["MaNhanVien"].ToString(),
                NgayLapPhieu = Convert.ToDateTime(i["NgayLapPhieu"].ToString()),
            };
        }
    }
}
