namespace GUI.QLVT_GUI
{
    partial class UCPhongChieuQLVT
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
            this.pnListPhongChieu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenPhongChieu = new System.Windows.Forms.TextBox();
            this.txtMaPhongChieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListPhongChieu = new System.Windows.Forms.DataGridView();
            this.btnTimKiemPhongChieu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtVatTu = new System.Windows.Forms.TextBox();
            this.lblPhongChieu = new System.Windows.Forms.Label();
            this.lblVatTu = new System.Windows.Forms.Label();
            this.btnTimKiemVatTu = new System.Windows.Forms.Button();
            this.lblListPhongChieu = new System.Windows.Forms.Label();
            this.dgvListVatTu = new System.Windows.Forms.DataGridView();
            this.pnListPhongChieu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhongChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListPhongChieu
            // 
            this.pnListPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListPhongChieu.Controls.Add(this.groupBox1);
            this.pnListPhongChieu.Controls.Add(this.groupBox2);
            this.pnListPhongChieu.Controls.Add(this.txtVatTu);
            this.pnListPhongChieu.Controls.Add(this.lblPhongChieu);
            this.pnListPhongChieu.Controls.Add(this.lblVatTu);
            this.pnListPhongChieu.Controls.Add(this.btnTimKiemVatTu);
            this.pnListPhongChieu.Controls.Add(this.lblListPhongChieu);
            this.pnListPhongChieu.Controls.Add(this.dgvListVatTu);
            this.pnListPhongChieu.Location = new System.Drawing.Point(3, 12);
            this.pnListPhongChieu.Name = "pnListPhongChieu";
            this.pnListPhongChieu.Size = new System.Drawing.Size(1335, 757);
            this.pnListPhongChieu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenPhongChieu);
            this.groupBox1.Controls.Add(this.txtMaPhongChieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbLoaiPhong);
            this.groupBox1.Controls.Add(this.cbTinhTrangPhong);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 450);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng chiếu";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(245, 393);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Thêm vật tư vào phòng";
            // 
            // txtTenPhongChieu
            // 
            this.txtTenPhongChieu.Location = new System.Drawing.Point(164, 86);
            this.txtTenPhongChieu.Name = "txtTenPhongChieu";
            this.txtTenPhongChieu.Size = new System.Drawing.Size(202, 28);
            this.txtTenPhongChieu.TabIndex = 7;
            // 
            // txtMaPhongChieu
            // 
            this.txtMaPhongChieu.Location = new System.Drawing.Point(164, 27);
            this.txtMaPhongChieu.Name = "txtMaPhongChieu";
            this.txtMaPhongChieu.Size = new System.Drawing.Size(202, 28);
            this.txtMaPhongChieu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phòng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(326, 278);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 36);
            this.btnThem.TabIndex = 30;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(164, 155);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(202, 29);
            this.cbLoaiPhong.TabIndex = 1;
            // 
            // cbTinhTrangPhong
            // 
            this.cbTinhTrangPhong.FormattingEnabled = true;
            this.cbTinhTrangPhong.Location = new System.Drawing.Point(164, 217);
            this.cbTinhTrangPhong.Name = "cbTinhTrangPhong";
            this.cbTinhTrangPhong.Size = new System.Drawing.Size(202, 29);
            this.cbTinhTrangPhong.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListPhongChieu);
            this.groupBox2.Controls.Add(this.btnTimKiemPhongChieu);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(402, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 633);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các phòng chiếu";
            // 
            // dgvListPhongChieu
            // 
            this.dgvListPhongChieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPhongChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPhongChieu.Location = new System.Drawing.Point(6, 73);
            this.dgvListPhongChieu.Name = "dgvListPhongChieu";
            this.dgvListPhongChieu.RowHeadersWidth = 51;
            this.dgvListPhongChieu.RowTemplate.Height = 24;
            this.dgvListPhongChieu.Size = new System.Drawing.Size(459, 554);
            this.dgvListPhongChieu.TabIndex = 12;
            this.dgvListPhongChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPhongChieu_CellClick);
            // 
            // btnTimKiemPhongChieu
            // 
            this.btnTimKiemPhongChieu.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemPhongChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemPhongChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhongChieu.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhongChieu.Location = new System.Drawing.Point(285, 28);
            this.btnTimKiemPhongChieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemPhongChieu.Name = "btnTimKiemPhongChieu";
            this.btnTimKiemPhongChieu.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemPhongChieu.TabIndex = 44;
            this.btnTimKiemPhongChieu.Text = "TÌM KIẾM";
            this.btnTimKiemPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhongChieu.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 28);
            this.txtTimKiem.TabIndex = 20;
            // 
            // txtVatTu
            // 
            this.txtVatTu.Location = new System.Drawing.Point(1036, 130);
            this.txtVatTu.Name = "txtVatTu";
            this.txtVatTu.Size = new System.Drawing.Size(130, 22);
            this.txtVatTu.TabIndex = 48;
            // 
            // lblPhongChieu
            // 
            this.lblPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhongChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.lblPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhongChieu.Location = new System.Drawing.Point(449, 57);
            this.lblPhongChieu.Name = "lblPhongChieu";
            this.lblPhongChieu.Size = new System.Drawing.Size(158, 33);
            this.lblPhongChieu.TabIndex = 15;
            this.lblPhongChieu.Text = "PHÒNG CHIẾU";
            this.lblPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVatTu
            // 
            this.lblVatTu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblVatTu.Image = global::GUI.Properties.Resources.ToolDeXuat;
            this.lblVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVatTu.Location = new System.Drawing.Point(891, 123);
            this.lblVatTu.Name = "lblVatTu";
            this.lblVatTu.Size = new System.Drawing.Size(93, 33);
            this.lblVatTu.TabIndex = 46;
            this.lblVatTu.Text = "VẬT TƯ";
            this.lblVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiemVatTu
            // 
            this.btnTimKiemVatTu.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemVatTu.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemVatTu.Location = new System.Drawing.Point(1197, 120);
            this.btnTimKiemVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemVatTu.Name = "btnTimKiemVatTu";
            this.btnTimKiemVatTu.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemVatTu.TabIndex = 45;
            this.btnTimKiemVatTu.Text = "TÌM KIẾM";
            this.btnTimKiemVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemVatTu.UseVisualStyleBackColor = false;
            // 
            // lblListPhongChieu
            // 
            this.lblListPhongChieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblListPhongChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.lblListPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListPhongChieu.Location = new System.Drawing.Point(568, 12);
            this.lblListPhongChieu.Name = "lblListPhongChieu";
            this.lblListPhongChieu.Size = new System.Drawing.Size(305, 37);
            this.lblListPhongChieu.TabIndex = 14;
            this.lblListPhongChieu.Text = "QUẢN LÝ PHÒNG CHIẾU";
            this.lblListPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListVatTu
            // 
            this.dgvListVatTu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVatTu.Location = new System.Drawing.Point(886, 166);
            this.dgvListVatTu.Name = "dgvListVatTu";
            this.dgvListVatTu.RowHeadersWidth = 51;
            this.dgvListVatTu.RowTemplate.Height = 24;
            this.dgvListVatTu.Size = new System.Drawing.Size(434, 323);
            this.dgvListVatTu.TabIndex = 13;
            // 
            // UCPhongChieuQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListPhongChieu);
            this.Name = "UCPhongChieuQLVT";
            this.Size = new System.Drawing.Size(1352, 782);
            this.pnListPhongChieu.ResumeLayout(false);
            this.pnListPhongChieu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhongChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListPhongChieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListPhongChieu;
        private System.Windows.Forms.TextBox txtVatTu;
        private System.Windows.Forms.Label lblVatTu;
        private System.Windows.Forms.Button btnTimKiemVatTu;
        private System.Windows.Forms.Button btnTimKiemPhongChieu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblListPhongChieu;
        private System.Windows.Forms.DataGridView dgvListVatTu;
        private System.Windows.Forms.Label lblPhongChieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenPhongChieu;
        private System.Windows.Forms.TextBox txtMaPhongChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbTinhTrangPhong;
    }
}
