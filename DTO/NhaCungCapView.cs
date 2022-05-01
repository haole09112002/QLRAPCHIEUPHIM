using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapView
    {
		private string maNhaCungCap;
		private string tenNhaCungCap;
		private string maSoThue;
		private string soDienThoai;
		private string tenLoaiNhaCungCap;

        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string TenLoaiNhaCungCap { get => tenLoaiNhaCungCap; set => tenLoaiNhaCungCap = value; }
    }
}
