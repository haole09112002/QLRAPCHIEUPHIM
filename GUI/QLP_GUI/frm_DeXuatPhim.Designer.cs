﻿namespace GUI.QLP_GUI
{
    partial class frm_DeXuatPhim
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.gBMoTaPhim = new System.Windows.Forms.GroupBox();
            this.dGVDaoDien = new System.Windows.Forms.DataGridView();
            this.dGVDienVienPhu = new System.Windows.Forms.DataGridView();
            this.dGVDienVienChinh = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxtNoiDung = new System.Windows.Forms.RichTextBox();
            this.gBThongTinPhim = new System.Windows.Forms.GroupBox();
            this.txtDoTuoiXem = new System.Windows.Forms.TextBox();
            this.pBAnhPhim = new System.Windows.Forms.PictureBox();
            this.cBTheLoai = new System.Windows.Forms.ComboBox();
            this.dTPNamSanXuat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBQuocGia = new System.Windows.Forms.ComboBox();
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
            this.txtHangSanXuat.Location = new System.Drawing.Point(227, 225);
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
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.gBMoTaPhim);
            this.panel1.Controls.Add(this.gBThongTinPhim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 842);
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
            this.btnHuy.Location = new System.Drawing.Point(236, 791);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 45);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(878, 791);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 45);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gBMoTaPhim
            // 
            this.gBMoTaPhim.Controls.Add(this.dGVDaoDien);
            this.gBMoTaPhim.Controls.Add(this.dGVDienVienPhu);
            this.gBMoTaPhim.Controls.Add(this.dGVDienVienChinh);
            this.gBMoTaPhim.Controls.Add(this.label10);
            this.gBMoTaPhim.Controls.Add(this.label13);
            this.gBMoTaPhim.Controls.Add(this.label12);
            this.gBMoTaPhim.Controls.Add(this.label11);
            this.gBMoTaPhim.Controls.Add(this.rtxtNoiDung);
            this.gBMoTaPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBMoTaPhim.Location = new System.Drawing.Point(644, 71);
            this.gBMoTaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBMoTaPhim.Name = "gBMoTaPhim";
            this.gBMoTaPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBMoTaPhim.Size = new System.Drawing.Size(528, 714);
            this.gBMoTaPhim.TabIndex = 20;
            this.gBMoTaPhim.TabStop = false;
            this.gBMoTaPhim.Text = "MÔ TẢ PHIM";
            // 
            // dGVDaoDien
            // 
            this.dGVDaoDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDaoDien.BackgroundColor = System.Drawing.Color.White;
            this.dGVDaoDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDaoDien.Location = new System.Drawing.Point(13, 524);
            this.dGVDaoDien.Name = "dGVDaoDien";
            this.dGVDaoDien.RowHeadersWidth = 62;
            this.dGVDaoDien.RowTemplate.Height = 28;
            this.dGVDaoDien.Size = new System.Drawing.Size(509, 106);
            this.dGVDaoDien.TabIndex = 41;
            // 
            // dGVDienVienPhu
            // 
            this.dGVDienVienPhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDienVienPhu.BackgroundColor = System.Drawing.Color.White;
            this.dGVDienVienPhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDienVienPhu.Location = new System.Drawing.Point(13, 370);
            this.dGVDienVienPhu.Name = "dGVDienVienPhu";
            this.dGVDienVienPhu.RowHeadersWidth = 62;
            this.dGVDienVienPhu.RowTemplate.Height = 28;
            this.dGVDienVienPhu.Size = new System.Drawing.Size(509, 106);
            this.dGVDienVienPhu.TabIndex = 40;
            // 
            // dGVDienVienChinh
            // 
            this.dGVDienVienChinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDienVienChinh.BackgroundColor = System.Drawing.Color.White;
            this.dGVDienVienChinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDienVienChinh.Location = new System.Drawing.Point(13, 233);
            this.dGVDienVienChinh.Name = "dGVDienVienChinh";
            this.dGVDienVienChinh.RowHeadersWidth = 62;
            this.dGVDienVienChinh.RowTemplate.Height = 28;
            this.dGVDienVienChinh.Size = new System.Drawing.Size(509, 106);
            this.dGVDienVienChinh.TabIndex = 39;
            this.dGVDienVienChinh.Click += new System.EventHandler(this.dGVDienVienChinh_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::GUI.Properties.Resources.DienVien;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(15, 487);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 34);
            this.label10.TabIndex = 30;
            this.label10.Text = "Đạo diễn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::GUI.Properties.Resources.DienVien;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(8, 342);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Diễn viên phụ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.gBThongTinPhim.Controls.Add(this.pBAnhPhim);
            this.gBThongTinPhim.Controls.Add(this.cBTheLoai);
            this.gBThongTinPhim.Controls.Add(this.dTPNamSanXuat);
            this.gBThongTinPhim.Controls.Add(this.label5);
            this.gBThongTinPhim.Controls.Add(this.label9);
            this.gBThongTinPhim.Controls.Add(this.label14);
            this.gBThongTinPhim.Controls.Add(this.label4);
            this.gBThongTinPhim.Controls.Add(this.label8);
            this.gBThongTinPhim.Controls.Add(this.label7);
            this.gBThongTinPhim.Controls.Add(this.label6);
            this.gBThongTinPhim.Controls.Add(this.txtHangSanXuat);
            this.gBThongTinPhim.Controls.Add(this.cBQuocGia);
            this.gBThongTinPhim.Controls.Add(this.txtThoiLuong);
            this.gBThongTinPhim.Controls.Add(this.label1);
            this.gBThongTinPhim.Controls.Add(this.txtTenPhim);
            this.gBThongTinPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBThongTinPhim.Location = new System.Drawing.Point(19, 71);
            this.gBThongTinPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBThongTinPhim.Name = "gBThongTinPhim";
            this.gBThongTinPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBThongTinPhim.Size = new System.Drawing.Size(619, 714);
            this.gBThongTinPhim.TabIndex = 18;
            this.gBThongTinPhim.TabStop = false;
            this.gBThongTinPhim.Text = "THÔNG TIN PHIM";
            // 
            // txtDoTuoiXem
            // 
            this.txtDoTuoiXem.BackColor = System.Drawing.Color.White;
            this.txtDoTuoiXem.Location = new System.Drawing.Point(227, 295);
            this.txtDoTuoiXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoTuoiXem.Name = "txtDoTuoiXem";
            this.txtDoTuoiXem.Size = new System.Drawing.Size(380, 33);
            this.txtDoTuoiXem.TabIndex = 32;
            // 
            // pBAnhPhim
            // 
            this.pBAnhPhim.BackColor = System.Drawing.Color.White;
            this.pBAnhPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBAnhPhim.Location = new System.Drawing.Point(286, 487);
            this.pBAnhPhim.Name = "pBAnhPhim";
            this.pBAnhPhim.Size = new System.Drawing.Size(187, 198);
            this.pBAnhPhim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAnhPhim.TabIndex = 37;
            this.pBAnhPhim.TabStop = false;
            this.pBAnhPhim.Click += new System.EventHandler(this.pBAnhPhim_Click);
            // 
            // cBTheLoai
            // 
            this.cBTheLoai.BackColor = System.Drawing.Color.White;
            this.cBTheLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTheLoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTheLoai.FormattingEnabled = true;
            this.cBTheLoai.Location = new System.Drawing.Point(227, 362);
            this.cBTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBTheLoai.Name = "cBTheLoai";
            this.cBTheLoai.Size = new System.Drawing.Size(381, 31);
            this.cBTheLoai.TabIndex = 32;
            // 
            // dTPNamSanXuat
            // 
            this.dTPNamSanXuat.Location = new System.Drawing.Point(227, 423);
            this.dTPNamSanXuat.Name = "dTPNamSanXuat";
            this.dTPNamSanXuat.Size = new System.Drawing.Size(380, 33);
            this.dTPNamSanXuat.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(52, 487);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ảnh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::GUI.Properties.Resources.Dotuoi;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(24, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 34);
            this.label9.TabIndex = 29;
            this.label9.Text = "Độ tuổi xem";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(24, 360);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 31);
            this.label14.TabIndex = 33;
            this.label14.Text = "Thể loại";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.MovieRoom;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(24, 225);
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
            this.label8.Location = new System.Drawing.Point(24, 419);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 34);
            this.label8.TabIndex = 27;
            this.label8.Text = "Năm sản xuất";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::GUI.Properties.Resources.Location;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(24, 160);
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
            // cBQuocGia
            // 
            this.cBQuocGia.BackColor = System.Drawing.Color.White;
            this.cBQuocGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBQuocGia.DropDownHeight = 300;
            this.cBQuocGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQuocGia.FormattingEnabled = true;
            this.cBQuocGia.IntegralHeight = false;
            this.cBQuocGia.Items.AddRange(new object[] {
            "Ả Rập",
            "Ả Rập Xê Út",
            "Afghanistan",
            "Ai Cập",
            "Albania Bosnia",
            "Algeria",
            "Ấn Độ",
            "Andorra",
            "Angola",
            "Anh",
            "Áo",
            "Armenia",
            "Australia, Fiji",
            "Azerbaijan",
            "Ba Lan",
            "Bahrain",
            "Bangladesh",
            "Belarus, Romania",
            "Bhutan",
            "Bỉ",
            "Bồ Đào Nha",
            "Botswana",
            "Brunei",
            "Bulgaria",
            "Cameroon",
            "Campuchia",
            "CH Séc",
            "Chad",
            "Chireland",
            "Cộng hòa Congo",
            "Cộng hòa dân chủ Congo Gabon",
            "Cộng hòa Séc",
            "Cộng hòa Trung Phi",
            "Croatia",
            "Đài Loan",
            "Đan Mạch",
            "Đông Timor",
            "Đức",
            "Estonia",
            "Georgia",
            "Guinea Xích đạo",
            "Hà Lan",
            "Hàn Quốc",
            "Herzegovina",
            "Hungary",
            "Hy Lạp",
            "Iceland",
            "Indonesia",
            "Iran",
            "Iraq",
            "Israel",
            "Jordan",
            "Kazakhstan",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lào",
            "Latvia",
            "Lesotho",
            "Liban",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Malaysia",
            "Maldives",
            "MaltaMontenegro",
            "Ma-rốc",
            "Marshall Islands",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mông Cổ",
            "Myanmar",
            "Na Uy",
            "Nam Phi",
            "Namibia",
            "Nauru",
            "Nepal",
            "New Zealand",
            "Nga",
            "Nhật Bản",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Papua New Guinea",
            "Phần Lan",
            "Pháp",
            "Philippines",
            "Príncipe Chad",
            "Qatar",
            "Samoa",
            "San Marino",
            "São Tomé",
            "Serbia",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Sri, Lanka",
            "Sudan",
            "Swaziland",
            "Syria",
            "Tajikistan",
            "Tây Ban Nha",
            "Tây Sahara",
            "Thái Lan",
            "Thổ Nhĩ Kỳ",
            "Thuỵ Điển",
            "Thuỵ Sĩ",
            "Tonga",
            "Triều Tiên",
            "Trung Quốc",
            "Tunisia",
            "Turkmenistan",
            "Tuvalu",
            "Ukraine",
            "Uzbekistan",
            "Vanuatu",
            "Vatican",
            "Việt Nam",
            "Ý",
            "Yemen"});
            this.cBQuocGia.Location = new System.Drawing.Point(227, 160);
            this.cBQuocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBQuocGia.Name = "cBQuocGia";
            this.cBQuocGia.Size = new System.Drawing.Size(380, 31);
            this.cBQuocGia.TabIndex = 18;
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
            this.lbName.Location = new System.Drawing.Point(512, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(194, 37);
            this.lbName.TabIndex = 0;
            this.lbName.Text = " Thêm Phim";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_DeXuatPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 875);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DeXuatPhim";
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
        private System.Windows.Forms.ComboBox cBQuocGia;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.GroupBox gBMoTaPhim;
        private System.Windows.Forms.RichTextBox rtxtNoiDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
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
        private System.Windows.Forms.PictureBox pBAnhPhim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPNamSanXuat;
        private System.Windows.Forms.ComboBox cBTheLoai;
        private System.Windows.Forms.TextBox txtDoTuoiXem;
        private System.Windows.Forms.DataGridView dGVDaoDien;
        private System.Windows.Forms.DataGridView dGVDienVienPhu;
        private System.Windows.Forms.DataGridView dGVDienVienChinh;
    }
}