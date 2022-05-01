namespace GUI.QLVT_GUI
{
    partial class FrmCapNhatPhongChieuQLVT
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
            this.pnThemPhongChieu = new System.Windows.Forms.Panel();
            this.pnTitleThemPhongChieu = new System.Windows.Forms.Panel();
            this.lblTitleThemPhongChieu = new System.Windows.Forms.Label();
            this.pnContentThemPhongChieu = new System.Windows.Forms.Panel();
            this.btnXacNhanThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboPhongChieu = new System.Windows.Forms.ComboBox();
            this.lblPhongChieu = new System.Windows.Forms.Label();
            this.grpListVatTuPhongChieu = new System.Windows.Forms.GroupBox();
            this.btnTimKiemVatTuPC = new System.Windows.Forms.Button();
            this.txtTimKiemVatTuPC = new System.Windows.Forms.TextBox();
            this.dgvListVatTuPhongChieu = new System.Windows.Forms.DataGridView();
            this.grpListVatTuKho = new System.Windows.Forms.GroupBox();
            this.btnTimKiemVatTuKho = new System.Windows.Forms.Button();
            this.txtTimKiemVatTuKho = new System.Windows.Forms.TextBox();
            this.dgvListVatTuKho = new System.Windows.Forms.DataGridView();
            this.grpListVatTuDaThem = new System.Windows.Forms.GroupBox();
            this.btnLuuVatTuDaThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvVatTuDaThem = new System.Windows.Forms.DataGridView();
            this.pnThemPhongChieu.SuspendLayout();
            this.pnTitleThemPhongChieu.SuspendLayout();
            this.pnContentThemPhongChieu.SuspendLayout();
            this.grpListVatTuPhongChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTuPhongChieu)).BeginInit();
            this.grpListVatTuKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTuKho)).BeginInit();
            this.grpListVatTuDaThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTuDaThem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnThemPhongChieu
            // 
            this.pnThemPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThemPhongChieu.Controls.Add(this.pnTitleThemPhongChieu);
            this.pnThemPhongChieu.Controls.Add(this.pnContentThemPhongChieu);
            this.pnThemPhongChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThemPhongChieu.Location = new System.Drawing.Point(0, 0);
            this.pnThemPhongChieu.Name = "pnThemPhongChieu";
            this.pnThemPhongChieu.Size = new System.Drawing.Size(1000, 620);
            this.pnThemPhongChieu.TabIndex = 0;
            // 
            // pnTitleThemPhongChieu
            // 
            this.pnTitleThemPhongChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnTitleThemPhongChieu.Controls.Add(this.lblTitleThemPhongChieu);
            this.pnTitleThemPhongChieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleThemPhongChieu.Location = new System.Drawing.Point(0, 0);
            this.pnTitleThemPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitleThemPhongChieu.Name = "pnTitleThemPhongChieu";
            this.pnTitleThemPhongChieu.Size = new System.Drawing.Size(998, 45);
            this.pnTitleThemPhongChieu.TabIndex = 35;
            // 
            // lblTitleThemPhongChieu
            // 
            this.lblTitleThemPhongChieu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleThemPhongChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.lblTitleThemPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleThemPhongChieu.Location = new System.Drawing.Point(358, 9);
            this.lblTitleThemPhongChieu.Name = "lblTitleThemPhongChieu";
            this.lblTitleThemPhongChieu.Size = new System.Drawing.Size(268, 27);
            this.lblTitleThemPhongChieu.TabIndex = 0;
            this.lblTitleThemPhongChieu.Text = "  THÊM PHÒNG CHIẾU";
            this.lblTitleThemPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnContentThemPhongChieu
            // 
            this.pnContentThemPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContentThemPhongChieu.Controls.Add(this.btnXacNhanThem);
            this.pnContentThemPhongChieu.Controls.Add(this.btnThoat);
            this.pnContentThemPhongChieu.Controls.Add(this.cboPhongChieu);
            this.pnContentThemPhongChieu.Controls.Add(this.lblPhongChieu);
            this.pnContentThemPhongChieu.Controls.Add(this.grpListVatTuPhongChieu);
            this.pnContentThemPhongChieu.Controls.Add(this.grpListVatTuKho);
            this.pnContentThemPhongChieu.Controls.Add(this.grpListVatTuDaThem);
            this.pnContentThemPhongChieu.Location = new System.Drawing.Point(16, 59);
            this.pnContentThemPhongChieu.Name = "pnContentThemPhongChieu";
            this.pnContentThemPhongChieu.Size = new System.Drawing.Size(972, 549);
            this.pnContentThemPhongChieu.TabIndex = 34;
            // 
            // btnXacNhanThem
            // 
            this.btnXacNhanThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnXacNhanThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThem.Image = global::GUI.Properties.Resources.save_26px;
            this.btnXacNhanThem.Location = new System.Drawing.Point(527, 479);
            this.btnXacNhanThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanThem.Name = "btnXacNhanThem";
            this.btnXacNhanThem.Size = new System.Drawing.Size(192, 36);
            this.btnXacNhanThem.TabIndex = 56;
            this.btnXacNhanThem.Text = "XÁC NHẬN THÊM";
            this.btnXacNhanThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhanThem.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(266, 479);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 36);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboPhongChieu
            // 
            this.cboPhongChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPhongChieu.FormattingEnabled = true;
            this.cboPhongChieu.Location = new System.Drawing.Point(463, 25);
            this.cboPhongChieu.Name = "cboPhongChieu";
            this.cboPhongChieu.Size = new System.Drawing.Size(195, 24);
            this.cboPhongChieu.TabIndex = 53;
            // 
            // lblPhongChieu
            // 
            this.lblPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.lblPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhongChieu.Location = new System.Drawing.Point(308, 22);
            this.lblPhongChieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongChieu.Name = "lblPhongChieu";
            this.lblPhongChieu.Size = new System.Drawing.Size(148, 27);
            this.lblPhongChieu.TabIndex = 52;
            this.lblPhongChieu.Text = "Phòng chiếu";
            this.lblPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpListVatTuPhongChieu
            // 
            this.grpListVatTuPhongChieu.Controls.Add(this.btnTimKiemVatTuPC);
            this.grpListVatTuPhongChieu.Controls.Add(this.txtTimKiemVatTuPC);
            this.grpListVatTuPhongChieu.Controls.Add(this.dgvListVatTuPhongChieu);
            this.grpListVatTuPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpListVatTuPhongChieu.Location = new System.Drawing.Point(9, 82);
            this.grpListVatTuPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListVatTuPhongChieu.Name = "grpListVatTuPhongChieu";
            this.grpListVatTuPhongChieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListVatTuPhongChieu.Size = new System.Drawing.Size(308, 378);
            this.grpListVatTuPhongChieu.TabIndex = 49;
            this.grpListVatTuPhongChieu.TabStop = false;
            this.grpListVatTuPhongChieu.Text = "VẬT TƯ PHÒNG CHIẾU HIỆN CÓ";
            // 
            // btnTimKiemVatTuPC
            // 
            this.btnTimKiemVatTuPC.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemVatTuPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVatTuPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemVatTuPC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemVatTuPC.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemVatTuPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemVatTuPC.Location = new System.Drawing.Point(168, 330);
            this.btnTimKiemVatTuPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemVatTuPC.Name = "btnTimKiemVatTuPC";
            this.btnTimKiemVatTuPC.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemVatTuPC.TabIndex = 55;
            this.btnTimKiemVatTuPC.Text = "TÌM KIẾM";
            this.btnTimKiemVatTuPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemVatTuPC.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemVatTuPC
            // 
            this.txtTimKiemVatTuPC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemVatTuPC.Location = new System.Drawing.Point(18, 334);
            this.txtTimKiemVatTuPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemVatTuPC.Name = "txtTimKiemVatTuPC";
            this.txtTimKiemVatTuPC.Size = new System.Drawing.Size(146, 28);
            this.txtTimKiemVatTuPC.TabIndex = 54;
            // 
            // dgvListVatTuPhongChieu
            // 
            this.dgvListVatTuPhongChieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListVatTuPhongChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVatTuPhongChieu.Location = new System.Drawing.Point(18, 27);
            this.dgvListVatTuPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListVatTuPhongChieu.Name = "dgvListVatTuPhongChieu";
            this.dgvListVatTuPhongChieu.RowHeadersWidth = 62;
            this.dgvListVatTuPhongChieu.RowTemplate.Height = 28;
            this.dgvListVatTuPhongChieu.Size = new System.Drawing.Size(273, 288);
            this.dgvListVatTuPhongChieu.TabIndex = 41;
            // 
            // grpListVatTuKho
            // 
            this.grpListVatTuKho.Controls.Add(this.btnTimKiemVatTuKho);
            this.grpListVatTuKho.Controls.Add(this.txtTimKiemVatTuKho);
            this.grpListVatTuKho.Controls.Add(this.dgvListVatTuKho);
            this.grpListVatTuKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpListVatTuKho.Location = new System.Drawing.Point(329, 82);
            this.grpListVatTuKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListVatTuKho.Name = "grpListVatTuKho";
            this.grpListVatTuKho.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListVatTuKho.Size = new System.Drawing.Size(298, 378);
            this.grpListVatTuKho.TabIndex = 50;
            this.grpListVatTuKho.TabStop = false;
            this.grpListVatTuKho.Text = "VẬT TƯ TRONG KHO HIỆN CÓ";
            // 
            // btnTimKiemVatTuKho
            // 
            this.btnTimKiemVatTuKho.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemVatTuKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVatTuKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemVatTuKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemVatTuKho.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemVatTuKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemVatTuKho.Location = new System.Drawing.Point(161, 330);
            this.btnTimKiemVatTuKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemVatTuKho.Name = "btnTimKiemVatTuKho";
            this.btnTimKiemVatTuKho.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemVatTuKho.TabIndex = 54;
            this.btnTimKiemVatTuKho.Text = "TÌM KIẾM";
            this.btnTimKiemVatTuKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemVatTuKho.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemVatTuKho
            // 
            this.txtTimKiemVatTuKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemVatTuKho.Location = new System.Drawing.Point(11, 334);
            this.txtTimKiemVatTuKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemVatTuKho.Name = "txtTimKiemVatTuKho";
            this.txtTimKiemVatTuKho.Size = new System.Drawing.Size(143, 28);
            this.txtTimKiemVatTuKho.TabIndex = 53;
            // 
            // dgvListVatTuKho
            // 
            this.dgvListVatTuKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvListVatTuKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVatTuKho.Location = new System.Drawing.Point(11, 28);
            this.dgvListVatTuKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListVatTuKho.Name = "dgvListVatTuKho";
            this.dgvListVatTuKho.RowHeadersWidth = 62;
            this.dgvListVatTuKho.RowTemplate.Height = 28;
            this.dgvListVatTuKho.Size = new System.Drawing.Size(273, 287);
            this.dgvListVatTuKho.TabIndex = 42;
            // 
            // grpListVatTuDaThem
            // 
            this.grpListVatTuDaThem.Controls.Add(this.btnLuuVatTuDaThem);
            this.grpListVatTuDaThem.Controls.Add(this.btnLamMoi);
            this.grpListVatTuDaThem.Controls.Add(this.lblSoLuong);
            this.grpListVatTuDaThem.Controls.Add(this.txtSoLuong);
            this.grpListVatTuDaThem.Controls.Add(this.dgvVatTuDaThem);
            this.grpListVatTuDaThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpListVatTuDaThem.Location = new System.Drawing.Point(643, 82);
            this.grpListVatTuDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListVatTuDaThem.Name = "grpListVatTuDaThem";
            this.grpListVatTuDaThem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListVatTuDaThem.Size = new System.Drawing.Size(317, 378);
            this.grpListVatTuDaThem.TabIndex = 51;
            this.grpListVatTuDaThem.TabStop = false;
            this.grpListVatTuDaThem.Text = "VẬT TƯ ĐÃ THÊM";
            // 
            // btnLuuVatTuDaThem
            // 
            this.btnLuuVatTuDaThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuuVatTuDaThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuVatTuDaThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuVatTuDaThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuVatTuDaThem.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuuVatTuDaThem.Location = new System.Drawing.Point(178, 329);
            this.btnLuuVatTuDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuVatTuDaThem.Name = "btnLuuVatTuDaThem";
            this.btnLuuVatTuDaThem.Size = new System.Drawing.Size(121, 36);
            this.btnLuuVatTuDaThem.TabIndex = 54;
            this.btnLuuVatTuDaThem.Text = "   Lưu";
            this.btnLuuVatTuDaThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuVatTuDaThem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::GUI.Properties.Resources.Renew;
            this.btnLamMoi.Location = new System.Drawing.Point(14, 330);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 36);
            this.btnLamMoi.TabIndex = 55;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Image = global::GUI.Properties.Resources.Soluong;
            this.lblSoLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSoLuong.Location = new System.Drawing.Point(26, 34);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(108, 27);
            this.lblSoLuong.TabIndex = 45;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSoLuong.Location = new System.Drawing.Point(151, 34);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 28);
            this.txtSoLuong.TabIndex = 6;
            // 
            // dgvVatTuDaThem
            // 
            this.dgvVatTuDaThem.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatTuDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTuDaThem.Location = new System.Drawing.Point(14, 73);
            this.dgvVatTuDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVatTuDaThem.Name = "dgvVatTuDaThem";
            this.dgvVatTuDaThem.RowHeadersWidth = 62;
            this.dgvVatTuDaThem.RowTemplate.Height = 28;
            this.dgvVatTuDaThem.Size = new System.Drawing.Size(285, 242);
            this.dgvVatTuDaThem.TabIndex = 44;
            // 
            // FrmCapNhatPhongChieuQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnThemPhongChieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCapNhatPhongChieuQLVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnThemPhongChieu.ResumeLayout(false);
            this.pnTitleThemPhongChieu.ResumeLayout(false);
            this.pnContentThemPhongChieu.ResumeLayout(false);
            this.grpListVatTuPhongChieu.ResumeLayout(false);
            this.grpListVatTuPhongChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTuPhongChieu)).EndInit();
            this.grpListVatTuKho.ResumeLayout(false);
            this.grpListVatTuKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTuKho)).EndInit();
            this.grpListVatTuDaThem.ResumeLayout(false);
            this.grpListVatTuDaThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTuDaThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThemPhongChieu;
        private System.Windows.Forms.Panel pnTitleThemPhongChieu;
        private System.Windows.Forms.Label lblTitleThemPhongChieu;
        private System.Windows.Forms.Panel pnContentThemPhongChieu;
        private System.Windows.Forms.Button btnXacNhanThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboPhongChieu;
        private System.Windows.Forms.Label lblPhongChieu;
        private System.Windows.Forms.GroupBox grpListVatTuPhongChieu;
        private System.Windows.Forms.Button btnTimKiemVatTuPC;
        private System.Windows.Forms.TextBox txtTimKiemVatTuPC;
        private System.Windows.Forms.DataGridView dgvListVatTuPhongChieu;
        private System.Windows.Forms.GroupBox grpListVatTuKho;
        private System.Windows.Forms.Button btnTimKiemVatTuKho;
        private System.Windows.Forms.TextBox txtTimKiemVatTuKho;
        private System.Windows.Forms.DataGridView dgvListVatTuKho;
        private System.Windows.Forms.GroupBox grpListVatTuDaThem;
        private System.Windows.Forms.Button btnLuuVatTuDaThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvVatTuDaThem;
    }
}