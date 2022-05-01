using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhimDAL
    {
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
            private set { }
        }

      
    }
}
