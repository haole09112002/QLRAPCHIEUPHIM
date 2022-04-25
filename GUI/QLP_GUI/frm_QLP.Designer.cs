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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(249, 882);
            this.pnLeft.TabIndex = 2;
            // 
            // btnNCC
            // 
            this.btnNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCC.Image = global::GUI.Properties.Resources.ncc;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(3, 488);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(249, 66);
            this.btnNCC.TabIndex = 15;
            this.btnNCC.Text = "   Nhà Cung Cấp";
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(64, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnThongTinPhim
            // 
            this.btnThongTinPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongTinPhim.FlatAppearance.BorderSize = 0;
            this.btnThongTinPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinPhim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinPhim.ForeColor = System.Drawing.Color.White;
            this.btnThongTinPhim.Image = global::GUI.Properties.Resources.phim;
            this.btnThongTinPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinPhim.Location = new System.Drawing.Point(-3, 191);
            this.btnThongTinPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongTinPhim.Name = "btnThongTinPhim";
            this.btnThongTinPhim.Size = new System.Drawing.Size(249, 66);
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
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 59);
            this.label1.TabIndex = 13;
            this.label1.Text = "CINEMA";
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhapXuat.FlatAppearance.BorderSize = 0;
            this.btnNhapXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuat.ForeColor = System.Drawing.Color.Snow;
            this.btnNhapXuat.Image = global::GUI.Properties.Resources.kho;
            this.btnNhapXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapXuat.Location = new System.Drawing.Point(0, 412);
            this.btnNhapXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(249, 66);
            this.btnNhapXuat.TabIndex = 5;
            this.btnNhapXuat.Text = "   Nhập/Xuất Kho Phim";
            this.btnNhapXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapXuat.UseVisualStyleBackColor = true;
            this.btnNhapXuat.Click += new System.EventHandler(this.btnNhapXuat_Click);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaNhan.FlatAppearance.BorderSize = 0;
            this.btnCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaNhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaNhan.Image = global::GUI.Properties.Resources.canhan;
            this.btnCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaNhan.Location = new System.Drawing.Point(3, 561);
            this.btnCaNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(249, 66);
            this.btnCaNhan.TabIndex = 7;
            this.btnCaNhan.Text = "   Cá Nhân";
            this.btnCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaNhan.UseVisualStyleBackColor = true;
            this.btnCaNhan.Click += new System.EventHandler(this.btnCaNhan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Image = global::GUI.Properties.Resources.logout;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 635);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(249, 66);
            this.btnDangXuat.TabIndex = 12;
            this.btnDangXuat.Text = "   Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnDeXuatPhim
            // 
            this.btnDeXuatPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeXuatPhim.FlatAppearance.BorderSize = 0;
            this.btnDeXuatPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeXuatPhim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeXuatPhim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeXuatPhim.Image = global::GUI.Properties.Resources.dexuat;
            this.btnDeXuatPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeXuatPhim.Location = new System.Drawing.Point(0, 330);
            this.btnDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeXuatPhim.Name = "btnDeXuatPhim";
            this.btnDeXuatPhim.Size = new System.Drawing.Size(249, 66);
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
            this.btnTaoLichChieu.FlatAppearance.BorderSize = 0;
            this.btnTaoLichChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoLichChieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLichChieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaoLichChieu.Image = global::GUI.Properties.Resources.lichchieu;
            this.btnTaoLichChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLichChieu.Location = new System.Drawing.Point(0, 256);
            this.btnTaoLichChieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoLichChieu.Name = "btnTaoLichChieu";
            this.btnTaoLichChieu.Size = new System.Drawing.Size(249, 66);
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
            this.pnTop.Controls.Add(this.label6);
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Controls.Add(this.label5);
            this.pnTop.Controls.Add(this.label4);
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(249, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1117, 80);
            this.pnTop.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(132, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 44);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinema Manegemenr System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.shutdown_26px1;
            this.pictureBox1.Location = new System.Drawing.Point(1082, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(894, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quản Lí Phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(894, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(752, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(752, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xin Chào: ";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(249, 80);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1117, 36);
            this.pnMenu.TabIndex = 4;
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.White;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(249, 116);
            this.pnCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1117, 766);
            this.pnCenter.TabIndex = 5;
            // 
            // frm_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 882);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnMenu;
        public System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNCC;
    }
}