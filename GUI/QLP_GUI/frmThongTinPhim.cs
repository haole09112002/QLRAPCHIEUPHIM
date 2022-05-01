﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

namespace GUI.QLP_GUI
{
    public partial class frmThongTinPhim : Form
    {
        public string MaPhim { get; set; }
        public frmThongTinPhim(string MaPhim)
        {
            this.MaPhim = MaPhim;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if(MaPhim != "")
            {
                PhimDTO phim = PhimBLL.Instance.GetPhimByMaPhim(MaPhim);
                txtTenPhim.Enabled = false;
                txtTenPhim.Text = phim.TenPhim;
                txtThoiLuong.Enabled = false;
                txtThoiLuong.Text = phim.ThoiLuong.ToString();
                cBQuocGia.Enabled = false;
                cBQuocGia.Text = phim.QuocGia;
                cBNamSanXuat.Enabled = false;
                cBNamSanXuat.Text = phim.NamSanXuat.Date.ToString();
                txtHangSanXuat.Enabled = false;
                txtHangSanXuat.Text = phim.TenHangPhim;
                cBDoTuoiXem.Enabled = false;
                cBDoTuoiXem.Text = phim.DoTuoiXem.ToString();
                txtTheLoai.Enabled = false;
                txtTheLoai.Text = phim.TheLoai;
                rtxtNoiDung.Enabled = false;
                rtxtNoiDung.Text = phim.NoiDung;
                txtDienVienChinh.Enabled = false;
                txtDienVienChinh.Text = phim.DienVienChinh;
                txtDienVienPhu.Enabled = false;
                txtDienVienPhu.Text = phim.DienVienPhu;
                txtDaoDien.Enabled = false;
                txtDaoDien.Text = phim.DaoDien;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
