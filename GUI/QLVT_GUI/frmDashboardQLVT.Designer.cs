namespace GUI.QLVT_GUI
{
    partial class frmDashboardQLVT
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnPhongChieu = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnCaNhan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnNhapXuatKho = new System.Windows.Forms.Button();
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
            this.pnLeft.Controls.Add(this.pictureBox2);
            this.pnLeft.Controls.Add(this.btnDeXuat);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Controls.Add(this.btnSanPham);
            this.pnLeft.Controls.Add(this.btnPhongChieu);
            this.pnLeft.Controls.Add(this.btnNhaCungCap);
            this.pnLeft.Controls.Add(this.btnCaNhan);
            this.pnLeft.Controls.Add(this.btnDangXuat);
            this.pnLeft.Controls.Add(this.btnNhapXuatKho);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(221, 706);
            this.pnLeft.TabIndex = 1;
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
            // btnDeXuat
            // 
            this.btnDeXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeXuat.FlatAppearance.BorderSize = 0;
            this.btnDeXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeXuat.ForeColor = System.Drawing.Color.White;
            this.btnDeXuat.Image = global::GUI.Properties.Resources.MenuDeXuat;
            this.btnDeXuat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDeXuat.Location = new System.Drawing.Point(0, 128);
            this.btnDeXuat.Name = "btnDeXuat";
            this.btnDeXuat.Size = new System.Drawing.Size(221, 48);
            this.btnDeXuat.TabIndex = 11;
            this.btnDeXuat.Text = "    Đề Xuất";
            this.btnDeXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeXuat.UseMnemonic = false;
            this.btnDeXuat.UseVisualStyleBackColor = true;
            this.btnDeXuat.Click += new System.EventHandler(this.btnDeXuat_Click);
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
            // btnSanPham
            // 
            this.btnSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Snow;
            this.btnSanPham.Image = global::GUI.Properties.Resources.MenuProduct;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 300);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(221, 53);
            this.btnSanPham.TabIndex = 5;
            this.btnSanPham.Text = "   Sản Phẩm";
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnPhongChieu
            // 
            this.btnPhongChieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPhongChieu.FlatAppearance.BorderSize = 0;
            this.btnPhongChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongChieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongChieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhongChieu.Image = global::GUI.Properties.Resources.MenuCinemaRoom;
            this.btnPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongChieu.Location = new System.Drawing.Point(0, 359);
            this.btnPhongChieu.Name = "btnPhongChieu";
            this.btnPhongChieu.Size = new System.Drawing.Size(221, 53);
            this.btnPhongChieu.TabIndex = 7;
            this.btnPhongChieu.Text = "   Phòng Chiếu";
            this.btnPhongChieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongChieu.UseVisualStyleBackColor = true;
            this.btnPhongChieu.Click += new System.EventHandler(this.btnPhongChieu_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhaCungCap.Image = global::GUI.Properties.Resources.ncc;
            this.btnNhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCungCap.Location = new System.Drawing.Point(0, 241);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(221, 53);
            this.btnNhaCungCap.TabIndex = 6;
            this.btnNhaCungCap.Text = "   Nhà Cung Ứng";
            this.btnNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhaCungCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
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
            this.btnCaNhan.Location = new System.Drawing.Point(0, 418);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(221, 53);
            this.btnCaNhan.TabIndex = 9;
            this.btnCaNhan.Text = "   Cá nhân";
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
            this.btnDangXuat.Location = new System.Drawing.Point(0, 477);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(221, 53);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "   Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnNhapXuatKho
            // 
            this.btnNhapXuatKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhapXuatKho.FlatAppearance.BorderSize = 0;
            this.btnNhapXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapXuatKho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuatKho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapXuatKho.Image = global::GUI.Properties.Resources.MenuWareHouse1;
            this.btnNhapXuatKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapXuatKho.Location = new System.Drawing.Point(0, 182);
            this.btnNhapXuatKho.Name = "btnNhapXuatKho";
            this.btnNhapXuatKho.Size = new System.Drawing.Size(221, 53);
            this.btnNhapXuatKho.TabIndex = 4;
            this.btnNhapXuatKho.Text = "   Nhập/Xuất Kho";
            this.btnNhapXuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapXuatKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapXuatKho.UseVisualStyleBackColor = true;
            this.btnNhapXuatKho.Click += new System.EventHandler(this.btnNhapXuatKho_Click);
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
            this.pnTop.Location = new System.Drawing.Point(221, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(993, 79);
            this.pnTop.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(122, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinema Manegemenr System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.shutdown_40px;
            this.pictureBox1.Location = new System.Drawing.Point(934, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = global::GUI.Properties.Resources.EmployeeQLVT;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(731, 36);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(178, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quản lý vật tư";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(763, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trần Trung Hiếu";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(626, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chức vụ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(626, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xin Chào: ";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(221, 79);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(993, 43);
            this.pnMenu.TabIndex = 3;
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.White;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(221, 122);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(993, 584);
            this.pnCenter.TabIndex = 4;
            // 
            // frmDashboardQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 706);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDashboardQLVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard_AD";
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
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnDeXuat;
        private System.Windows.Forms.Button btnCaNhan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnPhongChieu;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhapXuatKho;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label label6;
    }
}