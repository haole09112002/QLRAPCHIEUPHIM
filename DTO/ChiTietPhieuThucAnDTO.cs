using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuThucAnDTO
    {
        private string maPhieu;
        private string maThucAn;
        private string donViTinh;
        private int soLuong;
        private DateTime ngayHetHan;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaThucAn { get => maThucAn; set => maThucAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
    }
}
