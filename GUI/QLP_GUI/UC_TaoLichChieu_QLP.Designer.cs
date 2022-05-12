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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rBDSPChieu = new System.Windows.Forms.RadioButton();
            this.rBDSPhim = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayGioChieu = new System.Windows.Forms.TextBox();
            this.txtPhongChieu = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.dGVDanhSachPC = new System.Windows.Forms.DataGridView();
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.gBDanhSachPhim = new System.Windows.Forms.GroupBox();
            this.gBDanhSachPhongChieu = new System.Windows.Forms.GroupBox();
            this.gBKhungGioChieu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGVKhungGioChieu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.gBDanhSachPhongChieu.SuspendLayout();
            this.gBKhungGioChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhungGioChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.rBDSPChieu);
            this.panel1.Controls.Add(this.rBDSPhim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dGVDanhSachPhim);
            this.panel1.Controls.Add(this.gBDanhSachPhim);
            this.panel1.Controls.Add(this.gBDanhSachPhongChieu);
            this.panel1.Controls.Add(this.gBKhungGioChieu);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 733);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Image = global::GUI.Properties.Resources.ScheduleTitle;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(14, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 41);
            this.label5.TabIndex = 56;
            this.label5.Text = "LỊCH CHIẾU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::GUI.Properties.Resources.Renew;
            this.button2.Location = new System.Drawing.Point(721, 652);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 55;
            this.button2.Text = "Làm mới";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cyan;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::GUI.Properties.Resources.SearchIcon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1135, 498);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 45);
            this.button7.TabIndex = 53;
            this.button7.Text = "TÌM KIẾM";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GUI.Properties.Resources.save_26px;
            this.button3.Location = new System.Drawing.Point(1135, 652);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 45);
            this.button3.TabIndex = 54;
            this.button3.Text = "   Lưu";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(738, 504);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 33);
            this.textBox2.TabIndex = 52;
            // 
            // rBDSPChieu
            // 
            this.rBDSPChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBDSPChieu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDSPChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.rBDSPChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBDSPChieu.Location = new System.Drawing.Point(987, 554);
            this.rBDSPChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBDSPChieu.Name = "rBDSPChieu";
            this.rBDSPChieu.Size = new System.Drawing.Size(284, 48);
            this.rBDSPChieu.TabIndex = 48;
            this.rBDSPChieu.TabStop = true;
            this.rBDSPChieu.Text = "Danh Sách Phòng Chiếu";
            this.rBDSPChieu.UseVisualStyleBackColor = true;
            // 
            // rBDSPhim
            // 
            this.rBDSPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBDSPhim.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDSPhim.Image = global::GUI.Properties.Resources.Calam;
            this.rBDSPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBDSPhim.Location = new System.Drawing.Point(721, 556);
            this.rBDSPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBDSPhim.Name = "rBDSPhim";
            this.rBDSPhim.Size = new System.Drawing.Size(220, 41);
            this.rBDSPhim.TabIndex = 47;
            this.rBDSPhim.TabStop = true;
            this.rBDSPhim.Text = "Danh Sách Phim";
            this.rBDSPhim.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNgayGioChieu);
            this.panel2.Controls.Add(this.txtPhongChieu);
            this.panel2.Controls.Add(this.txtTenPhim);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(16, 541);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 177);
            this.panel2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.MovieRoom;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 34);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phòng chiếu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::GUI.Properties.Resources.Time;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 34);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày giờ chiếu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên phim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgayGioChieu
            // 
            this.txtNgayGioChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNgayGioChieu.Location = new System.Drawing.Point(218, 132);
            this.txtNgayGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayGioChieu.Name = "txtNgayGioChieu";
            this.txtNgayGioChieu.Size = new System.Drawing.Size(440, 27);
            this.txtNgayGioChieu.TabIndex = 5;
            // 
            // txtPhongChieu
            // 
            this.txtPhongChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhongChieu.Location = new System.Drawing.Point(218, 78);
            this.txtPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhongChieu.Name = "txtPhongChieu";
            this.txtPhongChieu.Size = new System.Drawing.Size(440, 27);
            this.txtPhongChieu.TabIndex = 4;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenPhim.Location = new System.Drawing.Point(218, 21);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(440, 27);
            this.txtTenPhim.TabIndex = 3;
            // 
            // dGVDanhSachPC
            // 
            this.dGVDanhSachPC.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPC.Location = new System.Drawing.Point(24, 42);
            this.dGVDanhSachPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPC.Name = "dGVDanhSachPC";
            this.dGVDanhSachPC.RowHeadersWidth = 62;
            this.dGVDanhSachPC.RowTemplate.Height = 28;
            this.dGVDanhSachPC.Size = new System.Drawing.Size(353, 412);
            this.dGVDanhSachPC.TabIndex = 42;
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(29, 59);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(348, 412);
            this.dGVDanhSachPhim.TabIndex = 41;
            // 
            // gBDanhSachPhim
            // 
            this.gBDanhSachPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhim.Location = new System.Drawing.Point(9, 15);
            this.gBDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Name = "gBDanhSachPhim";
            this.gBDanhSachPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Size = new System.Drawing.Size(382, 472);
            this.gBDanhSachPhim.TabIndex = 49;
            this.gBDanhSachPhim.TabStop = false;
            this.gBDanhSachPhim.Text = "DANH SÁCH PHIM";
            // 
            // gBDanhSachPhongChieu
            // 
            this.gBDanhSachPhongChieu.Controls.Add(this.dGVDanhSachPC);
            this.gBDanhSachPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhongChieu.Location = new System.Drawing.Point(419, 19);
            this.gBDanhSachPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhongChieu.Name = "gBDanhSachPhongChieu";
            this.gBDanhSachPhongChieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhongChieu.Size = new System.Drawing.Size(398, 472);
            this.gBDanhSachPhongChieu.TabIndex = 50;
            this.gBDanhSachPhongChieu.TabStop = false;
            this.gBDanhSachPhongChieu.Text = "DANH SÁCH PHÒNG CHIẾU";
            // 
            // gBKhungGioChieu
            // 
            this.gBKhungGioChieu.Controls.Add(this.label2);
            this.gBKhungGioChieu.Controls.Add(this.textBox1);
            this.gBKhungGioChieu.Controls.Add(this.dGVKhungGioChieu);
            this.gBKhungGioChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBKhungGioChieu.Location = new System.Drawing.Point(842, 19);
            this.gBKhungGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBKhungGioChieu.Name = "gBKhungGioChieu";
            this.gBKhungGioChieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBKhungGioChieu.Size = new System.Drawing.Size(429, 472);
            this.gBKhungGioChieu.TabIndex = 51;
            this.gBKhungGioChieu.TabStop = false;
            this.gBKhungGioChieu.Text = "KHUNG GIỜ CHIẾU";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.Time;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ngày giờ chiếu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(201, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 33);
            this.textBox1.TabIndex = 6;
            // 
            // dGVKhungGioChieu
            // 
            this.dGVKhungGioChieu.BackgroundColor = System.Drawing.Color.White;
            this.dGVKhungGioChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKhungGioChieu.Location = new System.Drawing.Point(16, 91);
            this.dGVKhungGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVKhungGioChieu.Name = "dGVKhungGioChieu";
            this.dGVKhungGioChieu.RowHeadersWidth = 62;
            this.dGVKhungGioChieu.RowTemplate.Height = 28;
            this.dGVKhungGioChieu.Size = new System.Drawing.Size(393, 365);
            this.dGVKhungGioChieu.TabIndex = 44;
            // 
            // UC_TaoLichChieu_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TaoLichChieu_QLP";
            this.Size = new System.Drawing.Size(1333, 766);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.gBDanhSachPhongChieu.ResumeLayout(false);
            this.gBKhungGioChieu.ResumeLayout(false);
            this.gBKhungGioChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhungGioChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rBDSPChieu;
        private System.Windows.Forms.RadioButton rBDSPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNgayGioChieu;
        private System.Windows.Forms.TextBox txtPhongChieu;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.DataGridView dGVKhungGioChieu;
        private System.Windows.Forms.DataGridView dGVDanhSachPC;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.GroupBox gBDanhSachPhim;
        private System.Windows.Forms.GroupBox gBDanhSachPhongChieu;
        private System.Windows.Forms.GroupBox gBKhungGioChieu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}
