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
    public partial class UCDaDeXuatVatTuQLVT : UserControl
    {
        public UCDaDeXuatVatTuQLVT()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatVatTuQLVT frmTaoPhieuDeXuatVatTuQLVT = new FrmTaoPhieuDeXuatVatTuQLVT();
            frmTaoPhieuDeXuatVatTuQLVT.Show();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuDeXuatVatTuQLVT frmTaoPhieuDeXuatVatTuQLVT = new FrmTaoPhieuDeXuatVatTuQLVT();
            frmTaoPhieuDeXuatVatTuQLVT.Show();
        }
    }
}
