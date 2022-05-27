namespace GUI.QLP_GUI
{
    partial class frm_QLP
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnNCC = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThongTinPhim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.btnCaNhan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDeXuatPhim = new System.Windows.Forms.Button();
            this.btnTaoLichChieu = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.pnLeft.Controls.Add(this.btnNCC);
            this.pnLeft.Controls.Add(this.pictureBox2);
            this.pnLeft.Controls.Add(this.btnThongTinPhim);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Controls.Add(this.btnNhapXuat);
            this.pnLeft.Controls.Add(this.btnCaNhan);
            this.pnLeft.Controls.Add(this.btnDangXuat);
            this.pnLeft.Controls.Add(this.btnDeXuatPhim);
            this.pnLeft.Controls.Add(this.btnTaoLichChieu);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(213, 875);
            this.pnLeft.TabIndex = 2;
            // 
            // btnNCC
            // 
            this.btnNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCC.Image = global::GUI.Properties.Resources.ncc;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(-3, 529);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(221, 53);
            this.btnNCC.TabIndex = 15;
            this.btnNCC.Text = "   Nhà Cung Cấp";
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(57, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnThongTinPhim
            // 
            this.btnThongTinPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongTinPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTinPhim.FlatAppearance.BorderSize = 0;
            this.btnThongTinPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinPhim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinPhim.ForeColor = System.Drawing.Color.White;
            this.btnThongTinPhim.Image = global::GUI.Properties.Resources.phim;
            this.btnThongTinPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinPhim.Location = new System.Drawing.Point(-3, 153);
            this.btnThongTinPhim.Name = "btnThongTinPhim";
            this.btnThongTinPhim.Size = new System.Drawing.Size(221, 53);
            this.btnThongTinPhim.TabIndex = 11;
            this.btnThongTinPhim.Text = "   Thông Tin Phim";
            this.btnThongTinPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTinPhim.UseVisualStyleBackColor = true;
            this.btnThongTinPhim.Click += new System.EventHandler(this.btnThongTinPhim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "CINEMA";
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhapXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapXuat.FlatAppearance.BorderSize = 0;
            this.btnNhapXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuat.ForeColor = System.Drawing.Color.Snow;
            this.btnNhapXuat.Image = global::GUI.Properties.Resources.kho;
            this.btnNhapXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapXuat.Location = new System.Drawing.Point(-3, 431);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(221, 62);
            this.btnNhapXuat.TabIndex = 5;
            this.btnNhapXuat.Text = "   Nhập/Xuất Kho Phim";
            this.btnNhapXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapXuat.UseVisualStyleBackColor = true;
            this.btnNhapXuat.Click += new System.EventHandler(this.btnNhapXuat_Click);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaNhan.FlatAppearance.BorderSize = 0;
            this.btnCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaNhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaNhan.Image = global::GUI.Properties.Resources.canhan;
            this.btnCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaNhan.Location = new System.Drawing.Point(-2, 621);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(216, 53);
            this.btnCaNhan.TabIndex = 7;
            this.btnCaNhan.Text = "   Cá Nhân";
            this.btnCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaNhan.UseVisualStyleBackColor = true;
            this.btnCaNhan.Click += new System.EventHandler(this.btnCaNhan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Image = global::GUI.Properties.Resources.logout;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 715);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(213, 53);
            this.btnDangXuat.TabIndex = 12;
            this.btnDangXuat.Text = "   Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDeXuatPhim
            // 
            this.btnDeXuatPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeXuatPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeXuatPhim.FlatAppearance.BorderSize = 0;
            this.btnDeXuatPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeXuatPhim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeXuatPhim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeXuatPhim.Image = global::GUI.Properties.Resources.dexuat;
            this.btnDeXuatPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeXuatPhim.Location = new System.Drawing.Point(-3, 334);
            this.btnDeXuatPhim.Name = "btnDeXuatPhim";
            this.btnDeXuatPhim.Size = new System.Drawing.Size(221, 53);
            this.btnDeXuatPhim.TabIndex = 6;
            this.btnDeXuatPhim.Text = "   Đề Xuất Phim";
            this.btnDeXuatPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeXuatPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeXuatPhim.UseVisualStyleBackColor = true;
            this.btnDeXuatPhim.Click += new System.EventHandler(this.btnDeXuatPhim_Click);
            // 
            // btnTaoLichChieu
            // 
            this.btnTaoLichChieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaoLichChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoLichChieu.FlatAppearance.BorderSize = 0;
            this.btnTaoLichChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoLichChieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLichChieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaoLichChieu.Image = global::GUI.Properties.Resources.lichchieu;
            this.btnTaoLichChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLichChieu.Location = new System.Drawing.Point(-4, 240);
            this.btnTaoLichChieu.Name = "btnTaoLichChieu";
            this.btnTaoLichChieu.Size = new System.Drawing.Size(221, 53);
            this.btnTaoLichChieu.TabIndex = 4;
            this.btnTaoLichChieu.Text = "   Tạo Lịch Chiếu";
            this.btnTaoLichChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoLichChieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoLichChieu.UseVisualStyleBackColor = true;
            this.btnTaoLichChieu.Click += new System.EventHandler(this.btnTaoLichChieu_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.pnTop.Controls.Add(this.pbClose);
            this.pnTop.Controls.Add(this.pbMinimize);
            this.pnTop.Controls.Add(this.label5);
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Controls.Add(this.lbTenNhanVien);
            this.pnTop.Controls.Add(this.label6);
            this.pnTop.Controls.Add(this.label7);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(213, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1360, 63);
            this.pnTop.TabIndex = 3;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::GUI.Properties.Resources.Close_24px;
            this.pbClose.Location = new System.Drawing.Point(1309, 14);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(29, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 20;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::GUI.Properties.Resources.subtract_24px;
            this.pbMinimize.Location = new System.Drawing.Point(1251, 14);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(29, 30);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 18;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(829, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xin Chào: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(815, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chức vụ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbTenNhanVien.Location = new System.Drawing.Point(1018, 2);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(49, 20);
            this.lbTenNhanVien.TabIndex = 18;
            this.lbTenNhanVien.Text = "label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(250, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinema Manegemenr System";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = global::GUI.Properties.Resources.EmployeeQLVT;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(956, 18);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(164, 41);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quản lý phim";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(213, 63);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1360, 30);
            this.pnMenu.TabIndex = 4;
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.White;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(213, 93);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1360, 782);
            this.pnCenter.TabIndex = 5;
            // 
            // frm_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 875);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_QLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThongTinPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhapXuat;
        private System.Windows.Forms.Button btnCaNhan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDeXuatPhim;
        private System.Windows.Forms.Button btnTaoLichChieu;
        private System.Windows.Forms.Panel pnTop;
        public System.Windows.Forms.Panel pnMenu;
        public System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
    }
}