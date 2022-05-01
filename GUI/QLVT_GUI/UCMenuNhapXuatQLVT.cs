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
        private void btnMenuListNXThucAn_Click(object sender, EventArgs e)
        {
            d(ucNhapXuatThucAnQLVT);
            changeColorButton(btnMenuListNXThucAn);
        }

        private void btnMenuListNXVatTu_Click(object sender, EventArgs e)
        {
            d(ucNhapXuatVatTuQLVT);
            changeColorButton(btnMenuListNXVatTu);
        }
        private void changeColorButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 144, 153);
            List<Button> buttons = new List<Button> { btnMenuListNXThucAn, btnMenuListNXVatTu };
            foreach (Button i in buttons)
            {

                if (i.BackColor == Color.FromArgb(0, 144, 153) && i != btn)
                {
                    i.BackColor = Color.FromArgb(226, 251, 242);
                }
            }
        }
        public void setColor()
        {
            btnMenuListNXThucAn.BackColor = Color.FromArgb(0, 144, 153);
            btnMenuListNXVatTu.BackColor = Color.FromArgb(226, 251, 242);
        }
    }
}
