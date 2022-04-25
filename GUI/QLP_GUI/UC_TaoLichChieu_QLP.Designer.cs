namespace GUI.QLP_GUI
{
    partial class UC_TaoLichChieu_QLP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.dGVDanhSachPC = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGVKhungGioChieu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgayGioChieu = new System.Windows.Forms.TextBox();
            this.txtPhongChieu = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rBDSPhim = new System.Windows.Forms.RadioButton();
            this.rBDSPChieu = new System.Windows.Forms.RadioButton();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gBDanhSachPhim = new System.Windows.Forms.GroupBox();
            this.gBDanhSachPhongChieu = new System.Windows.Forms.GroupBox();
            this.gBKhungGioChieu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhungGioChieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(40, 75);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(307, 412);
            this.dGVDanhSachPhim.TabIndex = 1;
            // 
            // dGVDanhSachPC
            // 
            this.dGVDanhSachPC.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPC.Location = new System.Drawing.Point(408, 75);
            this.dGVDanhSachPC.Name = "dGVDanhSachPC";
            this.dGVDanhSachPC.RowHeadersWidth = 62;
            this.dGVDanhSachPC.RowTemplate.Height = 28;
            this.dGVDanhSachPC.Size = new System.Drawing.Size(307, 412);
            this.dGVDanhSachPC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(756, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Chiếu";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(869, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 6;
            // 
            // dGVKhungGioChieu
            // 
            this.dGVKhungGioChieu.BackgroundColor = System.Drawing.Color.White;
            this.dGVKhungGioChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKhungGioChieu.Location = new System.Drawing.Point(760, 122);
            this.dGVKhungGioChieu.Name = "dGVKhungGioChieu";
            this.dGVKhungGioChieu.RowHeadersWidth = 62;
            this.dGVKhungGioChieu.RowTemplate.Height = 28;
            this.dGVKhungGioChieu.Size = new System.Drawing.Size(307, 365);
            this.dGVKhungGioChieu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "LỊCH CHIẾU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNgayGioChieu);
            this.panel1.Controls.Add(this.txtPhongChieu);
            this.panel1.Controls.Add(this.txtTenPhim);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(40, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 177);
            this.panel1.TabIndex = 10;
            // 
            // txtNgayGioChieu
            // 
            this.txtNgayGioChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNgayGioChieu.Location = new System.Drawing.Point(218, 132);
            this.txtNgayGioChieu.Name = "txtNgayGioChieu";
            this.txtNgayGioChieu.Size = new System.Drawing.Size(440, 27);
            this.txtNgayGioChieu.TabIndex = 5;
            // 
            // txtPhongChieu
            // 
            this.txtPhongChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhongChieu.Location = new System.Drawing.Point(218, 77);
            this.txtPhongChieu.Name = "txtPhongChieu";
            this.txtPhongChieu.Size = new System.Drawing.Size(440, 27);
            this.txtPhongChieu.TabIndex = 4;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenPhim.Location = new System.Drawing.Point(218, 21);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(440, 27);
            this.txtTenPhim.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(36, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày Giờ Chiếu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(36, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phòng Chiếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Phim";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1010, 515);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 33);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimKiem.Location = new System.Drawing.Point(760, 521);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 26);
            this.txtTimKiem.TabIndex = 12;
            // 
            // rBDSPhim
            // 
            this.rBDSPhim.AutoSize = true;
            this.rBDSPhim.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDSPhim.Location = new System.Drawing.Point(760, 569);
            this.rBDSPhim.Name = "rBDSPhim";
            this.rBDSPhim.Size = new System.Drawing.Size(162, 23);
            this.rBDSPhim.TabIndex = 15;
            this.rBDSPhim.TabStop = true;
            this.rBDSPhim.Text = "Danh Sách Phim";
            this.rBDSPhim.UseVisualStyleBackColor = true;
            // 
            // rBDSPChieu
            // 
            this.rBDSPChieu.AutoSize = true;
            this.rBDSPChieu.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDSPChieu.Location = new System.Drawing.Point(760, 617);
            this.rBDSPChieu.Name = "rBDSPChieu";
            this.rBDSPChieu.Size = new System.Drawing.Size(222, 23);
            this.rBDSPChieu.TabIndex = 16;
            this.rBDSPChieu.TabStop = true;
            this.rBDSPChieu.Text = "Danh Sách Phòng Chiếu";
            this.rBDSPChieu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Location = new System.Drawing.Point(1010, 702);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 33);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(776, 702);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 33);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // gBDanhSachPhim
            // 
            this.gBDanhSachPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhim.Location = new System.Drawing.Point(20, 31);
            this.gBDanhSachPhim.Name = "gBDanhSachPhim";
            this.gBDanhSachPhim.Size = new System.Drawing.Size(346, 473);
            this.gBDanhSachPhim.TabIndex = 19;
            this.gBDanhSachPhim.TabStop = false;
            this.gBDanhSachPhim.Text = "Danh Sách Phim";
            // 
            // gBDanhSachPhongChieu
            // 
            this.gBDanhSachPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhongChieu.Location = new System.Drawing.Point(390, 31);
            this.gBDanhSachPhongChieu.Name = "gBDanhSachPhongChieu";
            this.gBDanhSachPhongChieu.Size = new System.Drawing.Size(335, 473);
            this.gBDanhSachPhongChieu.TabIndex = 20;
            this.gBDanhSachPhongChieu.TabStop = false;
            this.gBDanhSachPhongChieu.Text = "Danh Sách Phòng Chiếu";
            // 
            // gBKhungGioChieu
            // 
            this.gBKhungGioChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBKhungGioChieu.Location = new System.Drawing.Point(748, 31);
            this.gBKhungGioChieu.Name = "gBKhungGioChieu";
            this.gBKhungGioChieu.Size = new System.Drawing.Size(356, 473);
            this.gBKhungGioChieu.TabIndex = 21;
            this.gBKhungGioChieu.TabStop = false;
            this.gBKhungGioChieu.Text = "Khung Giờ Chiếu";
            // 
            // UC_TaoLichChieu_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.rBDSPChieu);
            this.Controls.Add(this.rBDSPhim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGVKhungGioChieu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGVDanhSachPC);
            this.Controls.Add(this.dGVDanhSachPhim);
            this.Controls.Add(this.gBDanhSachPhim);
            this.Controls.Add(this.gBDanhSachPhongChieu);
            this.Controls.Add(this.gBKhungGioChieu);
            this.Name = "UC_TaoLichChieu_QLP";
            this.Size = new System.Drawing.Size(1117, 766);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhungGioChieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.DataGridView dGVDanhSachPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGVKhungGioChieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgayGioChieu;
        private System.Windows.Forms.TextBox txtPhongChieu;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rBDSPhim;
        private System.Windows.Forms.RadioButton rBDSPChieu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gBDanhSachPhim;
        private System.Windows.Forms.GroupBox gBDanhSachPhongChieu;
        private System.Windows.Forms.GroupBox gBKhungGioChieu;
    }
}
