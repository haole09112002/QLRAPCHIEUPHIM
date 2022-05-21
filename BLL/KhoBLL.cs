using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class KhoBLL
    {
        private BindingSource bindingSource = new BindingSource();
        private static KhoBLL instance;
        public static KhoBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoBLL();
                }
                return instance;
            }
            private set { }
        }

        public DataTable BindingSource { get; private set; }

        private KhoBLL()
        {

        }
        public List<KhoDTO> GetAllKho(string txt = "")
        {
            List<KhoDTO> data = new List<KhoDTO>();
            foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
            {
                if (i.TenKho.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public KhoDTO GetKhoViewByKhoDTO(KhoDTO kho)
        {
            return new KhoDTO
            {
                MaKho = kho.MaKho,
                MaLoaiKho = kho.MaLoaiKho,
                TenKho = kho.TenKho,
                
            };
        }
        public void TimKiem(string maKho)
        {
            BindingSource = KhoDAL.Instance.TimTheoMa(maKho);
        }
    }
}

