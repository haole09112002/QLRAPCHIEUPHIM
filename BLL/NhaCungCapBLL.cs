using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private static NhaCungCapBLL instance;
        public static NhaCungCapBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBLL();
                }
                return instance;
            }
            private set { }
        }
        private NhaCungCapBLL()
        {

        }
        public List<NhaCungCapDTO> GetNCCByMaLoaiNCC(string maLoaiNCC)
        {
            List<NhaCungCapDTO> data = new List<NhaCungCapDTO>();
            if (maLoaiNCC == "0")
            {
                data = NhaCungCapDAL.Instance.GetAllNhaCungCap();
            }
            else
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (i.MaLoaiNhaCungCap == maLoaiNCC)
                        data.Add(i);
                }
            }

            return data;
        }
        public List<NhaCungCapViewDTO> GetNCCViewMaLoaiNCC(string maLoaiNCC)
        {
            List<NhaCungCapViewDTO> data = new List<NhaCungCapViewDTO>();
            string tenLoaiNCC = "";
            foreach (NhaCungCapDTO j in GetNCCByMaLoaiNCC(maLoaiNCC))
            {
                foreach (LoaiNhaCungCapDTO i in LoaiNhaCungCapDAL.Instance.GetAllLoaiNhaCungCap())
                {
                    if (i.MaLoaiNhaCungCap == j.MaLoaiNhaCungCap)
                        tenLoaiNCC = i.TenLoaiNhaCungCap;
                }
                data.Add(new NhaCungCapViewDTO
                {
                    MaNhaCungCap = j.MaNhaCungCap,
                    TenNhaCungCap = j.TenNhaCungCap,
                    MaSoThue = j.MaSoThue,
                    SoDienThoai = j.SoDienThoai,
                    TenLoaiNhaCungCap = tenLoaiNCC
                });
            }
            return data;
        }

        public NhaCungCapDTO GetNCCByMaNCC(string MaNCC)
        {
            NhaCungCapDTO nhaCungCap = null;
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if (i.MaNhaCungCap == MaNCC)
                {
                    nhaCungCap = i;
                    break;
                }
            }
            return nhaCungCap;
        }


        public bool CheckAddUpdateNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            bool add = true;
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if (i.MaNhaCungCap == nhaCungCap.MaNhaCungCap)
                {
                    add = false;
                    break;
                }
            }
            return add;

        }
        public void AddUpdateNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            if (CheckAddUpdateNhaCungCap(nhaCungCap))
            {
                NhaCungCapDAL.Instance.ThemNhaCungCap(nhaCungCap);
            }
            else
            {
                NhaCungCapDAL.Instance.CapNhatNhaCungCap(nhaCungCap);
            }
        }

        public string KiemTraDuLieu(NhaCungCapDTO nhaCungCap)
        {
           
            if (nhaCungCap.MaNhaCungCap == "" &&
                nhaCungCap.TenNhaCungCap == "" &&
                nhaCungCap.MaLoaiNhaCungCap == "" &&
                nhaCungCap.MaSoThue == "" &&
                nhaCungCap.Email == "" &&
                nhaCungCap.SoDienThoai == "" &&
                nhaCungCap.DiaChi == "")
            {
                return "Dữ liệu còn trống !";
            }
            if (!CheckAddUpdateNhaCungCap(nhaCungCap))
            {
                if ((int)NhaCungCapDAL.Instance.KiemTraMaSoThue(nhaCungCap) >= 2)
                {
                    return "Mã số thuế đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraSoDienThoai(nhaCungCap) >= 2)
                {
                    return "Số điện thoại đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraEmail(nhaCungCap) >= 2)
                {
                    return "Email đã tồn tại!";
                }
            }
            else
            {
                if ((int)NhaCungCapDAL.Instance.KiemTraMaSoThue(nhaCungCap) >= 1)
                {
                    return "Mã số thuế đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraSoDienThoai(nhaCungCap) >= 1)
                {
                    return "Số điện thoại đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraEmail(nhaCungCap) >= 1)
                {
                    return "Email đã tồn tại!";
                }
            }
            return null;
        }
    }
}
