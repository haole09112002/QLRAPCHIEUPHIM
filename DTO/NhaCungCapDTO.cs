using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
		private string maNhaCungCap;
		private string tenNhaCungCap;
		private string maSoThue;
		private string diaChi;
		private string email;
		private string soDienThoai;
		private string tenGiamDoc;
		private string maLoaiNhaCungCap;

        public NhaCungCapDTO(string maNhaCungCap, string tenNhaCungCap, string maSoThue, string diaChi, string email, string soDienThoai, string tenGiamDoc, string maLoaiNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
            this.maSoThue = maSoThue;
            this.diaChi = diaChi;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.tenGiamDoc = tenGiamDoc;
            this.maLoaiNhaCungCap = maLoaiNhaCungCap;
        }
    //    public NhaCungCapDTO() { }
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string TenGiamDoc { get => tenGiamDoc; set => tenGiamDoc = value; }
        public string MaLoaiNhaCungCap { get => maLoaiNhaCungCap; set => maLoaiNhaCungCap = value; }
    }
}

