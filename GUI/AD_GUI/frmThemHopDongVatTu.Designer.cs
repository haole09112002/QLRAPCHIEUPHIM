namespace GUI.AD_GUI
{
    partial class frmThemHopDongVatTu
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
            this.dtpThoiGianKiKet = new System.Windows.Forms.DateTimePicker();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTenCungCap = new System.Windows.Forms.ComboBox();
            this.txtTenHopDong = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxNoiDung = new System.Windows.Forms.GroupBox();
            this.numUpDowSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtTenVatTu = new System.Windows.Forms.TextBox();
            this.txtMaVatTu = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvVatTuDaThem = new System.Windows.Forms.DataGridView();
            this.gbLuaChonPhim = new System.Windows.Forms.GroupBox();
            this.dgvVatTu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCenter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowSoLuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTuDaThem)).BeginInit();
            this.gbLuaChonPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpThoiGianKiKet
            // 
            this.dtpThoiGianKiKet.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianKiKet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpThoiGianKiKet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianKiKet.Location = new System.Drawing.Point(853, 20);
            this.dtpThoiGianKiKet.Name = "dtpThoiGianKiKet";
            this.dtpThoiGianKiKet.Size = new System.Drawing.Size(339, 28);
            this.dtpThoiGianKiKet.TabIndex = 5;
            // 
            // pnCenter
            // 
            this.pnCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCenter.Controls.Add(this.groupBox1);
            this.pnCenter.Controls.Add(this.gbxNoiDung);
            this.pnCenter.Controls.Add(this.btnThoat);
            this.pnCenter.Controls.Add(this.btnLuu);
            this.pnCenter.Controls.Add(this.groupBox3);
            this.pnCenter.Controls.Add(this.gbLuaChonPhim);
            this.pnCenter.Location = new System.Drawing.Point(21, 50);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1206, 753);
            this.pnCenter.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbTenCungCap);
            this.groupBox1.Controls.Add(this.txtTenHopDong);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpThoiGianKiKet);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 102);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(35, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 33);
            this.label12.TabIndex = 38;
            this.label12.Text = "Tên hợp đồng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTenCungCap
            // 
            this.cbTenCungCap.FormattingEnabled = true;
            this.cbTenCungCap.Location = new System.Drawing.Point(853, 66);
            this.cbTenCungCap.Name = "cbTenCungCap";
            this.cbTenCungCap.Size = new System.Drawing.Size(339, 27);
            this.cbTenCungCap.TabIndex = 33;
            this.cbTenCungCap.SelectedIndexChanged += new System.EventHandler(this.cbTenCungCap_SelectedIndexChanged);
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHopDong.Location = new System.Drawing.Point(215, 24);
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(314, 28);
            this.txtTenHopDong.TabIndex = 35;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(215, 69);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(314, 28);
            this.txtMaNCC.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.MaSoThue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã nhà cung cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.UserProfileQLVT;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(619, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tên nhà cung cấp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::GUI.Properties.Resources.Time;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(619, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ngày kí kết";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxNoiDung
            // 
            this.gbxNoiDung.Controls.Add(this.numUpDowSoLuong);
            this.gbxNoiDung.Controls.Add(this.label11);
            this.gbxNoiDung.Controls.Add(this.label10);
            this.gbxNoiDung.Controls.Add(this.label5);
            this.gbxNoiDung.Controls.Add(this.label6);
            this.gbxNoiDung.Controls.Add(this.label13);
            this.gbxNoiDung.Controls.Add(this.txtGiaTien);
            this.gbxNoiDung.Controls.Add(this.btnThem);
            this.gbxNoiDung.Controls.Add(this.cbDonViTinh);
            this.gbxNoiDung.Controls.Add(this.txtTenVatTu);
            this.gbxNoiDung.Controls.Add(this.txtMaVatTu);
            this.gbxNoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxNoiDung.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNoiDung.Location = new System.Drawing.Point(544, 107);
            this.gbxNoiDung.Name = "gbxNoiDung";
            this.gbxNoiDung.Size = new System.Drawing.Size(657, 316);
            this.gbxNoiDung.TabIndex = 13;
            this.gbxNoiDung.TabStop = false;
            this.gbxNoiDung.Text = "Nhập chi tiết ";
            // 
            // numUpDowSoLuong
            // 
            this.numUpDowSoLuong.Location = new System.Drawing.Point(245, 155);
            this.numUpDowSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDowSoLuong.Name = "numUpDowSoLuong";
            this.numUpDowSoLuong.Size = new System.Drawing.Size(153, 28);
            this.numUpDowSoLuong.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::GUI.Properties.Resources.Giatien;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(29, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 27);
            this.label11.TabIndex = 37;
            this.label11.Text = "Giá tiền(VND)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::GUI.Properties.Resources.DonViTinh;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(405, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 27);
            this.label10.TabIndex = 36;
            this.label10.Text = "Đơn vị tính";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(29, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên vật tư";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::GUI.Properties.Resources.Soluong;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Số lượng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::GUI.Properties.Resources.MaSoThue;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(29, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 27);
            this.label13.TabIndex = 33;
            this.label13.Text = "Mã vật tư";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(245, 191);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(403, 28);
            this.txtGiaTien.TabIndex = 27;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(472, 266);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(176, 36);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Location = new System.Drawing.Point(527, 158);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(121, 27);
            this.cbDonViTinh.TabIndex = 24;
            // 
            // txtTenVatTu
            // 
            this.txtTenVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVatTu.Location = new System.Drawing.Point(245, 115);
            this.txtTenVatTu.Name = "txtTenVatTu";
            this.txtTenVatTu.Size = new System.Drawing.Size(403, 28);
            this.txtTenVatTu.TabIndex = 16;
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVatTu.Location = new System.Drawing.Point(245, 77);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(403, 28);
            this.txtMaVatTu.TabIndex = 14;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(656, 700);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 36);
            this.btnThoat.TabIndex = 29;
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
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(441, 700);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 36);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dgvVatTuDaThem);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1198, 265);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thức ăn trong hợp đồng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(30, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "*Kích đúp để xóa";
            // 
            // dgvVatTuDaThem
            // 
            this.dgvVatTuDaThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatTuDaThem.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatTuDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTuDaThem.Location = new System.Drawing.Point(6, 27);
            this.dgvVatTuDaThem.Name = "dgvVatTuDaThem";
            this.dgvVatTuDaThem.RowHeadersWidth = 51;
            this.dgvVatTuDaThem.RowTemplate.Height = 24;
            this.dgvVatTuDaThem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVatTuDaThem.Size = new System.Drawing.Size(1186, 206);
            this.dgvVatTuDaThem.TabIndex = 0;
            this.dgvVatTuDaThem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatTuDaThem_CellClick);
            this.dgvVatTuDaThem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatTuDaThem_CellDoubleClick);
            // 
            // gbLuaChonPhim
            // 
            this.gbLuaChonPhim.Controls.Add(this.dgvVatTu);
            this.gbLuaChonPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChonPhim.Location = new System.Drawing.Point(3, 107);
            this.gbLuaChonPhim.Name = "gbLuaChonPhim";
            this.gbLuaChonPhim.Size = new System.Drawing.Size(535, 316);
            this.gbLuaChonPhim.TabIndex = 12;
            this.gbLuaChonPhim.TabStop = false;
            this.gbLuaChonPhim.Text = "Danh sách thức ăn đề xuất tạo hợp đồng";
            // 
            // dgvVatTu
            // 
            this.dgvVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatTu.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTu.Location = new System.Drawing.Point(6, 27);
            this.dgvVatTu.Name = "dgvVatTu";
            this.dgvVatTu.RowHeadersWidth = 51;
            this.dgvVatTu.RowTemplate.Height = 24;
            this.dgvVatTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVatTu.Size = new System.Drawing.Size(523, 275);
            this.dgvVatTu.TabIndex = 0;
            this.dgvVatTu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatTu_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 45);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỢP ĐỒNG VẬT TƯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmThemHopDongVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemHopDongVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemCaLam";
            this.pnCenter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxNoiDung.ResumeLayout(false);
            this.gbxNoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowSoLuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTuDaThem)).EndInit();
            this.gbLuaChonPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpThoiGianKiKet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.GroupBox gbLuaChonPhim;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVatTuDaThem;
        private System.Windows.Forms.GroupBox gbxNoiDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.TextBox txtTenVatTu;
        private System.Windows.Forms.TextBox txtMaVatTu;
        private System.Windows.Forms.DataGridView dgvVatTu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private System.Windows.Forms.NumericUpDown numUpDowSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTenCungCap;
        private System.Windows.Forms.Label label14;
    }
}
