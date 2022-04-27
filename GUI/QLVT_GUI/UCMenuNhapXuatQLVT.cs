﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
    public partial class UCMenuNhapXuatQLVT : UserControl
    {
        public UCMenuNhapXuatQLVT()
        {
            InitializeComponent();
        }
        public delegate void Mydel(UserControl c);
        public Mydel d { get; set; }
        public UCNhapXuatThucAnQLVT ucNhapXuatThucAnQLVT = new UCNhapXuatThucAnQLVT();
        public UCNhapXuatVatTuQLVT ucNhapXuatVatTuQLVT = new UCNhapXuatVatTuQLVT();
        private void btnTaoDeXuat_Click(object sender, EventArgs e)
        {
            d(ucNhapXuatThucAnQLVT);
        }

        private void btnDSDXP_Click(object sender, EventArgs e)
        {
            d(ucNhapXuatVatTuQLVT);
        }
    }
}
