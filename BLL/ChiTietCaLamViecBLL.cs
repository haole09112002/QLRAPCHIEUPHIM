using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ChiTietCaLamViecBLL
    {
        private static ChiTietCaLamViecBLL instance;
        public static ChiTietCaLamViecBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietCaLamViecBLL();
                }
                return instance;
            }
            set { }
        }
        public List<ChiTietCaLamViecDTO> GetAllChiTietCaLamViec()
        {

            return ChiTietCaLamViecDAL.Instance.GetAllChiTietCaLamViec();

        }

        public ChiTietCaLamViecDTO GetChiTietCaLamViecByMaChiTietCaLamViec(string MaChiTietCaLamViec)
        {
            ChiTietCaLamViecDTO data = new ChiTietCaLamViecDTO();
            foreach (ChiTietCaLamViecDTO i in ChiTietCaLamViecDAL.Instance.GetAllChiTietCaLamViec())
            {
                if (i.MaCa == MaChiTietCaLamViec)
                {
                    data.MaCa = i.MaCa;
                    data.MaNhanVien = i.MaNhanVien;
                }
            }
            return data;
        }
        public List<CaLamViecDTO> GetListCaLamViecByMaNhanVien(string maNhanVien)
        {
            List<CaLamViecDTO> data = new List<CaLamViecDTO>();
            foreach(ChiTietCaLamViecDTO i in ChiTietCaLamViecDAL.Instance.GetAllChiTietCaLamViec())
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
