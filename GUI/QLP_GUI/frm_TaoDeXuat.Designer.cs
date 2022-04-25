namespace GUI.QLP_GUI
{
    partial class frm_TaoDeXuat
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDeXuat = new System.Windows.Forms.Button();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gBThongTinPhim = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBQuocGia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBNamSanXuat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBMoTaPhim = new System.Windows.Forms.GroupBox();
            this.rtxtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDienVienChinh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtxtDienVienPhu = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rtxtTheLoai = new System.Windows.Forms.RichTextBox();
            this.gBSoLuongPhim = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.gBThongTinPhim.SuspendLayout();
            this.gBMoTaPhim.SuspendLayout();
            this.gBSoLuongPhim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Location = new System.Drawing.Point(751, 649);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 39);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDeXuat
            // 
            this.btnDeXuat.BackColor = System.Drawing.Color.White;
            this.btnDeXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnDeXuat.Location = new System.Drawing.Point(353, 649);
            this.btnDeXuat.Name = "btnDeXuat";
            this.btnDeXuat.Size = new System.Drawing.Size(116, 39);
            this.btnDeXuat.TabIndex = 18;
            this.btnDeXuat.Text = "Đề Xuất";
            this.btnDeXuat.UseVisualStyleBackColor = false;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNhaCungCap.Location = new System.Drawing.Point(178, 248);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(431, 33);
            this.txtNhaCungCap.TabIndex = 17;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDonViTinh.Location = new System.Drawing.Point(176, 78);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(433, 33);
            this.txtDonViTinh.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSoLuong.Location = new System.Drawing.Point(176, 28);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(433, 33);
            this.txtSoLuong.TabIndex = 15;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenPhim.Location = new System.Drawing.Point(176, 32);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(433, 33);
            this.txtTenPhim.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Phim";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gBSoLuongPhim);
            this.panel1.Controls.Add(this.rtxtDienVienPhu);
            this.panel1.Controls.Add(this.gBMoTaPhim);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.gBThongTinPhim);
            this.panel1.Controls.Add(this.btnDeXuat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 729);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(493, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tạo Đề Xuất Phim";
            // 
            // gBThongTinPhim
            // 
            this.gBThongTinPhim.Controls.Add(this.txtDaoDien);
            this.gBThongTinPhim.Controls.Add(this.label10);
            this.gBThongTinPhim.Controls.Add(this.txtNhaCungCap);
            this.gBThongTinPhim.Controls.Add(this.comboBox1);
            this.gBThongTinPhim.Controls.Add(this.label9);
            this.gBThongTinPhim.Controls.Add(this.cBNamSanXuat);
            this.gBThongTinPhim.Controls.Add(this.label8);
            this.gBThongTinPhim.Controls.Add(this.label4);
            this.gBThongTinPhim.Controls.Add(this.cBQuocGia);
            this.gBThongTinPhim.Controls.Add(this.label7);
            this.gBThongTinPhim.Controls.Add(this.txtThoiLuong);
            this.gBThongTinPhim.Controls.Add(this.label6);
            this.gBThongTinPhim.Controls.Add(this.label1);
            this.gBThongTinPhim.Controls.Add(this.txtTenPhim);
            this.gBThongTinPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBThongTinPhim.Location = new System.Drawing.Point(19, 71);
            this.gBThongTinPhim.Name = "gBThongTinPhim";
            this.gBThongTinPhim.Size = new System.Drawing.Size(615, 436);
            this.gBThongTinPhim.TabIndex = 18;
            this.gBThongTinPhim.TabStop = false;
            this.gBThongTinPhim.Text = "Thông Tin Phim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thời Lượng";
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtThoiLuong.Location = new System.Drawing.Point(176, 95);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(433, 33);
            this.txtThoiLuong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quốc Gia";
            // 
            // cBQuocGia
            // 
            this.cBQuocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBQuocGia.FormattingEnabled = true;
            this.cBQuocGia.Location = new System.Drawing.Point(176, 180);
            this.cBQuocGia.Name = "cBQuocGia";
            this.cBQuocGia.Size = new System.Drawing.Size(136, 31);
            this.cBQuocGia.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(329, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Năm Sản Xuất";
            // 
            // cBNamSanXuat
            // 
            this.cBNamSanXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBNamSanXuat.FormattingEnabled = true;
            this.cBNamSanXuat.Location = new System.Drawing.Point(492, 183);
            this.cBNamSanXuat.Name = "cBNamSanXuat";
            this.cBNamSanXuat.Size = new System.Drawing.Size(117, 31);
            this.cBNamSanXuat.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Độ Tuổi Xem";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(433, 31);
            this.comboBox1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Đạo Diễn";
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDaoDien.Location = new System.Drawing.Point(176, 383);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(433, 33);
            this.txtDaoDien.TabIndex = 24;
            // 
            // gBMoTaPhim
            // 
            this.gBMoTaPhim.Controls.Add(this.rtxtTheLoai);
            this.gBMoTaPhim.Controls.Add(this.label14);
            this.gBMoTaPhim.Controls.Add(this.label13);
            this.gBMoTaPhim.Controls.Add(this.txtDienVienChinh);
            this.gBMoTaPhim.Controls.Add(this.label12);
            this.gBMoTaPhim.Controls.Add(this.label11);
            this.gBMoTaPhim.Controls.Add(this.rtxtNoiDung);
            this.gBMoTaPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBMoTaPhim.Location = new System.Drawing.Point(659, 71);
            this.gBMoTaPhim.Name = "gBMoTaPhim";
            this.gBMoTaPhim.Size = new System.Drawing.Size(528, 572);
            this.gBMoTaPhim.TabIndex = 20;
            this.gBMoTaPhim.TabStop = false;
            this.gBMoTaPhim.Text = "Mô Tả Phim";
            // 
            // rtxtNoiDung
            // 
            this.rtxtNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtxtNoiDung.Location = new System.Drawing.Point(11, 81);
            this.rtxtNoiDung.Name = "rtxtNoiDung";
            this.rtxtNoiDung.Size = new System.Drawing.Size(511, 155);
            this.rtxtNoiDung.TabIndex = 0;
            this.rtxtNoiDung.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nội Dung";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Diễn Viên Chính";
            // 
            // txtDienVienChinh
            // 
            this.txtDienVienChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDienVienChinh.Location = new System.Drawing.Point(11, 276);
            this.txtDienVienChinh.Name = "txtDienVienChinh";
            this.txtDienVienChinh.Size = new System.Drawing.Size(511, 33);
            this.txtDienVienChinh.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Diễn Viên Phụ";
            // 
            // rtxtDienVienPhu
            // 
            this.rtxtDienVienPhu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtxtDienVienPhu.Location = new System.Drawing.Point(670, 413);
            this.rtxtDienVienPhu.Name = "rtxtDienVienPhu";
            this.rtxtDienVienPhu.Size = new System.Drawing.Size(511, 94);
            this.rtxtDienVienPhu.TabIndex = 28;
            this.rtxtDienVienPhu.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(6, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Thể Loại";
            // 
            // rtxtTheLoai
            // 
            this.rtxtTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtxtTheLoai.Location = new System.Drawing.Point(11, 472);
            this.rtxtTheLoai.Name = "rtxtTheLoai";
            this.rtxtTheLoai.Size = new System.Drawing.Size(511, 83);
            this.rtxtTheLoai.TabIndex = 29;
            this.rtxtTheLoai.Text = "";
            // 
            // gBSoLuongPhim
            // 
            this.gBSoLuongPhim.Controls.Add(this.label2);
            this.gBSoLuongPhim.Controls.Add(this.label3);
            this.gBSoLuongPhim.Controls.Add(this.txtDonViTinh);
            this.gBSoLuongPhim.Controls.Add(this.txtSoLuong);
            this.gBSoLuongPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBSoLuongPhim.Location = new System.Drawing.Point(19, 515);
            this.gBSoLuongPhim.Name = "gBSoLuongPhim";
            this.gBSoLuongPhim.Size = new System.Drawing.Size(615, 128);
            this.gBSoLuongPhim.TabIndex = 29;
            this.gBSoLuongPhim.TabStop = false;
            this.gBSoLuongPhim.Text = "Số Lượng Phim";
            // 
            // frm_TaoDeXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 754);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TaoDeXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TaoDeXuat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBThongTinPhim.ResumeLayout(false);
            this.gBThongTinPhim.PerformLayout();
            this.gBMoTaPhim.ResumeLayout(false);
            this.gBMoTaPhim.PerformLayout();
            this.gBSoLuongPhim.ResumeLayout(false);
            this.gBSoLuongPhim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDeXuat;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBThongTinPhim;
        private System.Windows.Forms.ComboBox cBNamSanXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBQuocGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gBMoTaPhim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxtNoiDung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtDienVienChinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtxtDienVienPhu;
        private System.Windows.Forms.RichTextBox rtxtTheLoai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gBSoLuongPhim;
    }
}