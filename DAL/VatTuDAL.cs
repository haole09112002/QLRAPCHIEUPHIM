using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class VatTuDAL
    {
        private static VatTuDAL instance;
        public static VatTuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VatTuDAL();
                }
                return instance;
            }
            private set { }
        }
        public List<VatTuDTO> GetALLVatTu()
        {
            List<VatTuDTO> listVatTu = new List<VatTuDTO>();
            string query = "Select * from VAT_TU";
            foreach (DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                listVatTu.Add(GetVatTuByDataRow(i));
            }
            return listVatTu;
        }
        public VatTuDTO GetVatTuByDataRow(DataRow i)
        {
            return new VatTuDTO
            {
                MaVatTu = i["MaVatTu"].ToString(),
                TenVatTu = i["TenVatTu"].ToString(),
            };
        }
    }
}
