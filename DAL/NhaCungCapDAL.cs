using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class NhaCungCapDAL
    {
        private static NhaCungCapDAL instance;

        public static NhaCungCapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAL();
                }
                return instance;
            }
            private set { }
        }
        
        public DataTable GetAllNhaCungCap()
        {
            string query = "";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public void ThemNhaCungCap(NhaCungCapDTO nhaCungCap)
        {

        }
        public void CapNhatNhaCungCap(NhaCungCapDTO nhaCungCap)
        {

        }

    }
}
