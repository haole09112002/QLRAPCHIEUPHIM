using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhimBLL
    {
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
            private set { }
        }
    }
}
