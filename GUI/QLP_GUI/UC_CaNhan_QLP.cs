﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_CaNhan_QLP : UserControl
    {
        public UC_CaNhan_QLP()
        {
            InitializeComponent();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau_QLP f = new frmDoiMatKhau_QLP();
            f.ShowDialog();
        }
    }
}
