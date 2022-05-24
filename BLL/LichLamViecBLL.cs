using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LichLamViecBLL
    {
        private static LichLamViecBLL instance;
        public static LichLamViecBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichLamViecBLL();
                }
                return instance;
            }
            set { }
        }
        public List<LichLamViecDTO> GetAllLichLamViec()
        {

            return LichLamViecDAL.Instance.GetAllLichLamViec();

        }
        public List<CaLamViecDTO> GetListCaLamViecByMaNhanVien(string maNhanVien)
        {
            List<CaLamViecDTO> data = new List<CaLamViecDTO>();
            foreach(LichLamViecDTO i in LichLamViecDAL.Instance.GetAllLichLamViec())
            {
                if(maNhanVien == i.MaNhanVien)
                {
                    data.Add(CaLamViecBLL.Instance.GetCaLamViecByMaCaLamViec(i.MaCa));
                }
            }
            return data;
        }
    }
}
