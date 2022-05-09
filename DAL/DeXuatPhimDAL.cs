using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DeXuatPhimDAL
    {
        private static DeXuatPhimDAL instance;
        public static DeXuatPhimDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeXuatPhimDAL();
                }
                return instance;
            }
            private set { }
        }
        private DeXuatPhimDAL()
        {

        }
        public List<DeXuatPhimDTO> GetllDeXuatPhim()
        {
            List <DeXuatPhimDTO > data = new List<DeXuatPhimDTO> ();
           string query = "Select * from CHI_TIET_DE_XUAT_PHIM";
            foreach(DataRow i in DBHelper.Instance.ExcuteQuery(query).Rows)
            {
                data.Add(GetDeXuatPhimByDataRow(i));
            }
            return data;
        }
        public DeXuatPhimDTO GetDeXuatPhimByDataRow(DataRow i)
        {
            return new DeXuatPhimDTO
            {
                MaDeXuat = i["MaDeXuat"].ToString(),
                MaPhim = i["MaPhim"].ToString(),
                TinhTrang = Convert.ToBoolean(i["TinhTrang"]),
                Noidung = i["Noidung"].ToString()
            };
        }
    }
}
