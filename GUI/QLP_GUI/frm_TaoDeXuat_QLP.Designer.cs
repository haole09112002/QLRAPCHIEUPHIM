namespace GUI.QLP_GUI
{
    partial class frm_TaoDeXuat_QLP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.nUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cBDonViTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gBDanhSachPhim = new System.Windows.Forms.GroupBox();
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gBDeXuatPhim = new System.Windows.Forms.GroupBox();
            this.dGVDeXuatPhim = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).BeginInit();
            this.gBDanhSachPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.gBDeXuatPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDeXuatPhim)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThemPhim);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lbNoiDung);
            this.panel1.Controls.Add(this.lbDonViTinh);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.txtMaPhim);
            this.panel1.Controls.Add(this.nUDSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnChinhSua);
            this.panel1.Controls.Add(this.txtNoiDung);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cBDonViTinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gBDanhSachPhim);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.gBDeXuatPhim);
            this.panel1.Location = new System.Drawing.Point(22, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 818);
            this.panel1.TabIndex = 13;
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.BackColor = System.Drawing.Color.Silver;
            this.btnThemPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhim.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThemPhim.Location = new System.Drawing.Point(1098, 385);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(178, 36);
            this.btnThemPhim.TabIndex = 82;
            this.btnThemPhim.Text = " Thêm Phim";
            this.btnThemPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemPhim.UseVisualStyleBackColor = false;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(865, 37);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 33);
            this.btnTimKiem.TabIndex = 81;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTimKiem.Location = new System.Drawing.Point(995, 43);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(281, 28);
            this.txtTimKiem.TabIndex = 80;
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.ForeColor = System.Drawing.Color.Red;
            this.lbNoiDung.Location = new System.Drawing.Point(643, 500);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(0, 17);
            this.lbNoiDung.TabIndex = 79;
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonViTinh.ForeColor = System.Drawing.Color.Red;
            this.lbDonViTinh.Location = new System.Drawing.Point(241, 498);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(0, 17);
            this.lbDonViTinh.TabIndex = 78;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lbSoLuong.Location = new System.Drawing.Point(241, 446);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(0, 17);
            this.lbSoLuong.TabIndex = 77;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Enabled = false;
            this.txtMaPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaPhim.Location = new System.Drawing.Point(646, 415);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.ReadOnly = true;
            this.txtMaPhim.Size = new System.Drawing.Size(296, 28);
            this.txtMaPhim.TabIndex = 76;
            // 
            // nUDSoLuong
            // 
            this.nUDSoLuong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.nUDSoLuong.Location = new System.Drawing.Point(241, 416);
            this.nUDSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSoLuong.Name = "nUDSoLuong";
            this.nUDSoLuong.Size = new System.Drawing.Size(296, 28);
            this.nUDSoLuong.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(560, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Mã Phim";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.trash_can_26px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(639, 761);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 36);
            this.btnXoa.TabIndex = 73;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.Edit;
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(1138, 470);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(138, 36);
            this.btnChinhSua.TabIndex = 72;
            this.btnChinhSua.Text = "CHỈNH SỬA";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNoiDung.Location = new System.Drawing.Point(646, 470);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(296, 28);
            this.txtNoiDung.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(556, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nội Dung";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(1160, 470);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 36);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "    Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cBDonViTinh
            // 
            this.cBDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDonViTinh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.cBDonViTinh.FormattingEnabled = true;
            this.cBDonViTinh.Items.AddRange(new object[] {
            "Đĩa",
            "Cuộn"});
            this.cBDonViTinh.Location = new System.Drawing.Point(241, 469);
            this.cBDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBDonViTinh.Name = "cBDonViTinh";
            this.cBDonViTinh.Size = new System.Drawing.Size(296, 27);
            this.cBDonViTinh.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Đơn Vị Tính";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Số Lượng";
            // 
            // gBDanhSachPhim
            // 
            this.gBDanhSachPhim.Controls.Add(this.dGVDanhSachPhim);
            this.gBDanhSachPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhim.Location = new System.Drawing.Point(28, 78);
            this.gBDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Name = "gBDanhSachPhim";
            this.gBDanhSachPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Size = new System.Drawing.Size(1248, 293);
            this.gBDanhSachPhim.TabIndex = 16;
            this.gBDanhSachPhim.TabStop = false;
            this.gBDanhSachPhim.Text = "DANH SÁCH PHIM";
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.AllowUserToAddRows = false;
            this.dGVDanhSachPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(15, 24);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.ReadOnly = true;
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(1227, 247);
            this.dGVDanhSachPhim.TabIndex = 0;
            this.dGVDanhSachPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhim_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(77, 761);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 36);
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(1124, 765);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gBDeXuatPhim
            // 
            this.gBDeXuatPhim.Controls.Add(this.dGVDeXuatPhim);
            this.gBDeXuatPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDeXuatPhim.Location = new System.Drawing.Point(40, 512);
            this.gBDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Name = "gBDeXuatPhim";
            this.gBDeXuatPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Size = new System.Drawing.Size(1257, 244);
            this.gBDeXuatPhim.TabIndex = 15;
            this.gBDeXuatPhim.TabStop = false;
            this.gBDeXuatPhim.Text = "ĐỀ XUẤT PHIM";
            // 
            // dGVDeXuatPhim
            // 
            this.dGVDeXuatPhim.AllowUserToAddRows = false;
            this.dGVDeXuatPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDeXuatPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDeXuatPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDeXuatPhim.Location = new System.Drawing.Point(15, 28);
            this.dGVDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDeXuatPhim.Name = "dGVDeXuatPhim";
            this.dGVDeXuatPhim.ReadOnly = true;
            this.dGVDeXuatPhim.RowHeadersWidth = 62;
            this.dGVDeXuatPhim.RowTemplate.Height = 28;
            this.dGVDeXuatPhim.Size = new System.Drawing.Size(1221, 201);
            this.dGVDeXuatPhim.TabIndex = 0;
            this.dGVDeXuatPhim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDeXuatPhim_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(22, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 32);
            this.panel2.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(627, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 35);
            this.label6.TabIndex = 27;
            this.label6.Text = "TẠO ĐỀ XUẤT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_TaoDeXuat_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 844);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_TaoDeXuat_QLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TaoDeXuat_QLP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).EndInit();
            this.gBDanhSachPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.gBDeXuatPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDeXuatPhim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBDonViTinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.NumericUpDown nUDSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gBDeXuatPhim;
        private System.Windows.Forms.DataGridView dGVDeXuatPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gBDanhSachPhim;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.Button btnThemPhim;
    }
}