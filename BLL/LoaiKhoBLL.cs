using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;

namespace BLL
{
    public class LoaiKhoBLL
    {
        private static LoaiKhoBLL instance;
        public static LoaiKhoBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiKhoBLL();
                }
                return instance;
            }
            private set { }
        }

        private LoaiKhoBLL()
        {

        }
        public List<LoaiKhoDTO> GetAllLoaiKho()
        {
            List<LoaiKhoDTO> data = new List<LoaiKhoDTO>();
            foreach (LoaiKhoDTO i in LoaiKhoDAL.Instance.GetAllLoaiKho())
            {
                data.Add(i);
            }
            return data;
        }
        public LoaiKhoDTO GetLoaiKhoByMaLoaiKho(string MaLoaiKho)
        {

            foreach (LoaiKhoDTO i in GetAllLoaiKho())
            {
                if (i.MaLoaiKho == MaLoaiKho)
                {
                    return i;
                }
            }
            return null;
        }
        public List<CBBItem> GetCBBLoaiKho()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LoaiKhoDTO i in LoaiKhoDAL.Instance.GetAllLoaiKho())
            {
                data.Add(new CBBItem
                { Value = i.MaLoaiKho, Text = i.TenLoaiKho });
            }
            return data;
        }

    }
}