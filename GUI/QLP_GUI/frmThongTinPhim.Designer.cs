﻿namespace GUI.QLP_GUI
{
    partial class frmThongTinPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.gBMoTaPhim = new System.Windows.Forms.GroupBox();
            this.dGVDaoDien = new System.Windows.Forms.DataGridView();
            this.dGVDienVienPhu = new System.Windows.Forms.DataGridView();
            this.dGVDienVienChinh = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxtNoiDung = new System.Windows.Forms.RichTextBox();
            this.gBThongTinPhim = new System.Windows.Forms.GroupBox();
            this.txtDoTuoiXem = new System.Windows.Forms.TextBox();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.txtNamSanXuat = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pBAnhPhim = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gBMoTaPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaoDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienVienPhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienVienChinh)).BeginInit();
            this.gBThongTinPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAnhPhim)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.BackColor = System.Drawing.Color.White;
            this.txtHangSanXuat.Location = new System.Drawing.Point(225, 258);
            this.txtHangSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(380, 33);
            this.txtHangSanXuat.TabIndex = 17;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.White;
            this.txtTenPhim.Location = new System.Drawing.Point(227, 32);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(381, 33);
            this.txtTenPhim.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.gBMoTaPhim);
            this.panel1.Controls.Add(this.gBThongTinPhim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 836);
            this.panel1.TabIndex = 20;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnHuy.Location = new System.Drawing.Point(537, 768);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 45);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // gBMoTaPhim
            // 
            this.gBMoTaPhim.Controls.Add(this.dGVDaoDien);
            this.gBMoTaPhim.Controls.Add(this.dGVDienVienPhu);
            this.gBMoTaPhim.Controls.Add(this.dGVDienVienChinh);
            this.gBMoTaPhim.Controls.Add(this.label13);
            this.gBMoTaPhim.Controls.Add(this.label10);
            this.gBMoTaPhim.Controls.Add(this.label12);
            this.gBMoTaPhim.Controls.Add(this.label11);
            this.gBMoTaPhim.Controls.Add(this.rtxtNoiDung);
            this.gBMoTaPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBMoTaPhim.Location = new System.Drawing.Point(659, 71);
            this.gBMoTaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBMoTaPhim.Name = "gBMoTaPhim";
            this.gBMoTaPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBMoTaPhim.Size = new System.Drawing.Size(528, 666);
            this.gBMoTaPhim.TabIndex = 20;
            this.gBMoTaPhim.TabStop = false;
            this.gBMoTaPhim.Text = "MÔ TẢ PHIM";
            // 
            // dGVDaoDien
            // 
            this.dGVDaoDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDaoDien.BackgroundColor = System.Drawing.Color.White;
            this.dGVDaoDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDaoDien.Location = new System.Drawing.Point(13, 508);
            this.dGVDaoDien.Name = "dGVDaoDien";
            this.dGVDaoDien.RowHeadersWidth = 62;
            this.dGVDaoDien.RowTemplate.Height = 28;
            this.dGVDaoDien.Size = new System.Drawing.Size(509, 106);
            this.dGVDaoDien.TabIndex = 42;
            // 
            // dGVDienVienPhu
            // 
            this.dGVDienVienPhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDienVienPhu.BackgroundColor = System.Drawing.Color.White;
            this.dGVDienVienPhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDienVienPhu.Location = new System.Drawing.Point(13, 362);
            this.dGVDienVienPhu.Name = "dGVDienVienPhu";
            this.dGVDienVienPhu.RowHeadersWidth = 62;
            this.dGVDienVienPhu.RowTemplate.Height = 28;
            this.dGVDienVienPhu.Size = new System.Drawing.Size(509, 106);
            this.dGVDienVienPhu.TabIndex = 41;
            // 
            // dGVDienVienChinh
            // 
            this.dGVDienVienChinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDienVienChinh.BackgroundColor = System.Drawing.Color.White;
            this.dGVDienVienChinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDienVienChinh.Location = new System.Drawing.Point(13, 225);
            this.dGVDienVienChinh.Name = "dGVDienVienChinh";
            this.dGVDienVienChinh.RowHeadersWidth = 62;
            this.dGVDienVienChinh.RowTemplate.Height = 28;
            this.dGVDienVienChinh.Size = new System.Drawing.Size(509, 106);
            this.dGVDienVienChinh.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::GUI.Properties.Resources.DienVien;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(8, 334);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Diễn viên phụ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::GUI.Properties.Resources.DienVien;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(8, 471);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 34);
            this.label10.TabIndex = 30;
            this.label10.Text = "Đạo diễn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = global::GUI.Properties.Resources.DienVien1;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(8, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 34);
            this.label12.TabIndex = 31;
            this.label12.Text = "Diễn viên chính";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::GUI.Properties.Resources.Noidung;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(8, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 34);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nội dung";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtNoiDung
            // 
            this.rtxtNoiDung.BackColor = System.Drawing.Color.White;
            this.rtxtNoiDung.Location = new System.Drawing.Point(11, 81);
            this.rtxtNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtNoiDung.Name = "rtxtNoiDung";
            this.rtxtNoiDung.Size = new System.Drawing.Size(511, 113);
            this.rtxtNoiDung.TabIndex = 0;
            this.rtxtNoiDung.Text = "";
            // 
            // gBThongTinPhim
            // 
            this.gBThongTinPhim.Controls.Add(this.txtDoTuoiXem);
            this.gBThongTinPhim.Controls.Add(this.txtQuocGia);
            this.gBThongTinPhim.Controls.Add(this.txtNamSanXuat);
            this.gBThongTinPhim.Controls.Add(this.txtTheLoai);
            this.gBThongTinPhim.Controls.Add(this.label14);
            this.gBThongTinPhim.Controls.Add(this.pBAnhPhim);
            this.gBThongTinPhim.Controls.Add(this.label2);
            this.gBThongTinPhim.Controls.Add(this.label9);
            this.gBThongTinPhim.Controls.Add(this.label4);
            this.gBThongTinPhim.Controls.Add(this.label8);
            this.gBThongTinPhim.Controls.Add(this.label7);
            this.gBThongTinPhim.Controls.Add(this.label6);
            this.gBThongTinPhim.Controls.Add(this.txtHangSanXuat);
            this.gBThongTinPhim.Controls.Add(this.txtThoiLuong);
            this.gBThongTinPhim.Controls.Add(this.label1);
            this.gBThongTinPhim.Controls.Add(this.txtTenPhim);
            this.gBThongTinPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBThongTinPhim.Location = new System.Drawing.Point(19, 71);
            this.gBThongTinPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBThongTinPhim.Name = "gBThongTinPhim";
            this.gBThongTinPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBThongTinPhim.Size = new System.Drawing.Size(619, 666);
            this.gBThongTinPhim.TabIndex = 18;
            this.gBThongTinPhim.TabStop = false;
            this.gBThongTinPhim.Text = "THÔNG TIN PHIM";
            // 
            // txtDoTuoiXem
            // 
            this.txtDoTuoiXem.BackColor = System.Drawing.Color.White;
            this.txtDoTuoiXem.Location = new System.Drawing.Point(224, 332);
            this.txtDoTuoiXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoTuoiXem.Name = "txtDoTuoiXem";
            this.txtDoTuoiXem.Size = new System.Drawing.Size(381, 33);
            this.txtDoTuoiXem.TabIndex = 40;
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.BackColor = System.Drawing.Color.White;
            this.txtQuocGia.Location = new System.Drawing.Point(227, 199);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(381, 33);
            this.txtQuocGia.TabIndex = 39;
            // 
            // txtNamSanXuat
            // 
            this.txtNamSanXuat.BackColor = System.Drawing.Color.White;
            this.txtNamSanXuat.Location = new System.Drawing.Point(227, 145);
            this.txtNamSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamSanXuat.Name = "txtNamSanXuat";
            this.txtNamSanXuat.Size = new System.Drawing.Size(381, 33);
            this.txtNamSanXuat.TabIndex = 38;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BackColor = System.Drawing.Color.White;
            this.txtTheLoai.Location = new System.Drawing.Point(227, 395);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(380, 33);
            this.txtTheLoai.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(24, 394);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 31);
            this.label14.TabIndex = 33;
            this.label14.Text = "Thể loại";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBAnhPhim
            // 
            this.pBAnhPhim.BackColor = System.Drawing.Color.White;
            this.pBAnhPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBAnhPhim.Location = new System.Drawing.Point(280, 451);
            this.pBAnhPhim.Name = "pBAnhPhim";
            this.pBAnhPhim.Size = new System.Drawing.Size(187, 198);
            this.pBAnhPhim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAnhPhim.TabIndex = 37;
            this.pBAnhPhim.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(24, 451);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ảnh Phim";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::GUI.Properties.Resources.Dotuoi;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(24, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 34);
            this.label9.TabIndex = 29;
            this.label9.Text = "Độ tuổi xem";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.MovieRoom;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(24, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hãng sản xuất";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::GUI.Properties.Resources.ScheduleTitle;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(24, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 34);
            this.label8.TabIndex = 27;
            this.label8.Text = "Năm sản xuất";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::GUI.Properties.Resources.Location;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(24, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "Quốc gia";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::GUI.Properties.Resources.Time;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(24, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 41);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thời lượng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BackColor = System.Drawing.Color.White;
            this.txtThoiLuong.Location = new System.Drawing.Point(227, 95);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(381, 33);
            this.txtThoiLuong.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên phim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 40);
            this.panel2.TabIndex = 30;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbName.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.Location = new System.Drawing.Point(490, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(247, 37);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Thông Tin Phim";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmThongTinPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 875);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongTinPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TaoDeXuat";
            this.panel1.ResumeLayout(false);
            this.gBMoTaPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaoDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienVienPhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienVienChinh)).EndInit();
            this.gBThongTinPhim.ResumeLayout(false);
            this.gBThongTinPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAnhPhim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gBThongTinPhim;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.GroupBox gBMoTaPhim;
        private System.Windows.Forms.RichTextBox rtxtNoiDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBAnhPhim;
        private System.Windows.Forms.DataGridView dGVDaoDien;
        private System.Windows.Forms.DataGridView dGVDienVienPhu;
        private System.Windows.Forms.DataGridView dGVDienVienChinh;
        private System.Windows.Forms.TextBox txtDoTuoiXem;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.TextBox txtNamSanXuat;
    }
}