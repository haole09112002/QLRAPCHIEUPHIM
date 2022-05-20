using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhoVatTuView
    {
        private string maKho;
        private string maVatTu;
        private string tenVatTu;
        private string donViTinh;
        private int soLuongSP;

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaVatTu { get => maVatTu; set => maVatTu = value; }
        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int SoLuongSP { get => soLuongSP; set => soLuongSP = value; }
    }
}
