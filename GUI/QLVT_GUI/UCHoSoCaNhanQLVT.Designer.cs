namespace GUI.QLVT_GUI
{
    partial class UCHoSoCaNhanQLVT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnThongTinCaNhan = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListCaLamViec = new System.Windows.Forms.DataGridView();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.grpThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnThongTinCaNhan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCaLamViec)).BeginInit();
            this.grpThongTinCaNhan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnThongTinCaNhan
            // 
            this.pnThongTinCaNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTinCaNhan.Controls.Add(this.groupBox1);
            this.pnThongTinCaNhan.Controls.Add(this.lblChucVu);
            this.pnThongTinCaNhan.Controls.Add(this.grpThongTinCaNhan);
            this.pnThongTinCaNhan.Controls.Add(this.picAvatar);
            this.pnThongTinCaNhan.Location = new System.Drawing.Point(22, 19);
            this.pnThongTinCaNhan.Name = "pnThongTinCaNhan";
            this.pnThongTinCaNhan.Size = new System.Drawing.Size(1310, 731);
            this.pnThongTinCaNhan.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListCaLamViec);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(65, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 272);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CA LÀM VIỆC";
            // 
            // dgvListCaLamViec
            // 
            this.dgvListCaLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCaLamViec.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCaLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCaLamViec.Location = new System.Drawing.Point(19, 26);
            this.dgvListCaLamViec.Name = "dgvListCaLamViec";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCaLamViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCaLamViec.RowHeadersWidth = 51;
            this.dgvListCaLamViec.RowTemplate.Height = 24;
            this.dgvListCaLamViec.Size = new System.Drawing.Size(348, 231);
            this.dgvListCaLamViec.TabIndex = 39;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChucVu.Image = global::GUI.Properties.Resources.avatar;
            this.lblChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChucVu.Location = new System.Drawing.Point(142, 205);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(186, 30);
            this.lblChucVu.TabIndex = 38;
            this.lblChucVu.Text = "Quản lý vật tư";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinCaNhan
            // 
            this.grpThongTinCaNhan.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinCaNhan.Controls.Add(this.txtCCCD);
            this.grpThongTinCaNhan.Controls.Add(this.lblCCCD);
            this.grpThongTinCaNhan.Controls.Add(this.groupBox2);
            this.grpThongTinCaNhan.Controls.Add(this.btnLuu);
            this.grpThongTinCaNhan.Controls.Add(this.btnChinhSua);
            this.grpThongTinCaNhan.Controls.Add(this.lblTen);
            this.grpThongTinCaNhan.Controls.Add(this.txtTen);
            this.grpThongTinCaNhan.Controls.Add(this.lblNgaySinh);
            this.grpThongTinCaNhan.Controls.Add(this.txtDiaChi);
            this.grpThongTinCaNhan.Controls.Add(this.txtDienThoai);
            this.grpThongTinCaNhan.Controls.Add(this.txtTenTaiKhoan);
            this.grpThongTinCaNhan.Controls.Add(this.lblDiaChi);
            this.grpThongTinCaNhan.Controls.Add(this.lblDienThoai);
            this.grpThongTinCaNhan.Controls.Add(this.btnDoiMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.lblTenTaiKhoan);
            this.grpThongTinCaNhan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinCaNhan.Location = new System.Drawing.Point(511, 31);
            this.grpThongTinCaNhan.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinCaNhan.Name = "grpThongTinCaNhan";
            this.grpThongTinCaNhan.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinCaNhan.Size = new System.Drawing.Size(650, 622);
            this.grpThongTinCaNhan.TabIndex = 36;
            this.grpThongTinCaNhan.TabStop = false;
            this.grpThongTinCaNhan.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(205, 200);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(392, 28);
            this.dtpNgaySinh.TabIndex = 23;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.checkSave);
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCD.Location = new System.Drawing.Point(205, 405);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(389, 27);
            this.txtCCCD.TabIndex = 22;
            this.txtCCCD.TextChanged += new System.EventHandler(this.checkSave);
            // 
            // lblCCCD
            // 
            this.lblCCCD.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Image = global::GUI.Properties.Resources.CCCD;
            this.lblCCCD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCCCD.Location = new System.Drawing.Point(30, 402);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(109, 28);
            this.lblCCCD.TabIndex = 21;
            this.lblCCCD.Text = "CCCD";
            this.lblCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNu);
            this.groupBox2.Controls.Add(this.rbNam);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(572, 64);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rbNu
            // 
            this.rbNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNu.Enabled = false;
            this.rbNu.Image = global::GUI.Properties.Resources.Female;
            this.rbNu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbNu.Location = new System.Drawing.Point(410, 18);
            this.rbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(77, 34);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.checkSave);
            // 
            // rbNam
            // 
            this.rbNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNam.Enabled = false;
            this.rbNam.Image = global::GUI.Properties.Resources.Male;
            this.rbNam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbNam.Location = new System.Drawing.Point(244, 18);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(100, 31);
            this.rbNam.TabIndex = 0;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.checkSave);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(467, 536);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 36);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.Edit;
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(266, 537);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(127, 36);
            this.btnChinhSua.TabIndex = 18;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Image = global::GUI.Properties.Resources.UserProfileQLVT;
            this.lblTen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTen.Location = new System.Drawing.Point(27, 53);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(64, 19);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "TÊN";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTen.Location = new System.Drawing.Point(205, 50);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(389, 27);
            this.txtTen.TabIndex = 8;
            this.txtTen.TextChanged += new System.EventHandler(this.checkSave);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Image = global::GUI.Properties.Resources.Birthday;
            this.lblNgaySinh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNgaySinh.Location = new System.Drawing.Point(27, 200);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(133, 19);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "NGÀY SINH";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDiaChi.Location = new System.Drawing.Point(205, 268);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(389, 27);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.checkSave);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDienThoai.Location = new System.Drawing.Point(205, 338);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(389, 27);
            this.txtDienThoai.TabIndex = 10;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.checkSave);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(205, 467);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(389, 27);
            this.txtTenTaiKhoan.TabIndex = 12;
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.checkSave);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Image = global::GUI.Properties.Resources.Location;
            this.lblDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiaChi.Location = new System.Drawing.Point(27, 266);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(112, 27);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "ĐỊA CHỈ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Image = global::GUI.Properties.Resources.Phone;
            this.lblDienThoai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDienThoai.Location = new System.Drawing.Point(27, 336);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(141, 26);
            this.lblDienThoai.TabIndex = 5;
            this.lblDienThoai.Text = "ĐIỆN THOẠI";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Peru;
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Image = global::GUI.Properties.Resources.Password;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(22, 537);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(159, 37);
            this.btnDoiMatKhau.TabIndex = 14;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Image = global::GUI.Properties.Resources.UserProfileQLVT;
            this.lblTenTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(27, 470);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(163, 19);
            this.lblTenTaiKhoan.TabIndex = 7;
            this.lblTenTaiKhoan.Text = "TÊN TÀI KHOẢN";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Silver;
            this.picAvatar.ErrorImage = null;
            this.picAvatar.InitialImage = null;
            this.picAvatar.Location = new System.Drawing.Point(118, 14);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(226, 173);
            this.picAvatar.TabIndex = 35;
            this.picAvatar.TabStop = false;
            // 
            // UCHoSoCaNhanQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnThongTinCaNhan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCHoSoCaNhanQLVT";
            this.Size = new System.Drawing.Size(1352, 766);
            this.pnThongTinCaNhan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCaLamViec)).EndInit();
            this.grpThongTinCaNhan.ResumeLayout(false);
            this.grpThongTinCaNhan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThongTinCaNhan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.GroupBox grpThongTinCaNhan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListCaLamViec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}
