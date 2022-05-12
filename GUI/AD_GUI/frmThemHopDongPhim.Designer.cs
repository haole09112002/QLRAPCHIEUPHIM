namespace GUI.AD_GUI
{
    partial class frmThemHopDongPhim
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
            this.dtpBanQuyenKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBanQuyenBatDau = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPhimDaThem = new System.Windows.Forms.DataGridView();
            this.gbLuaChonPhim = new System.Windows.Forms.GroupBox();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCenter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowSoLuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhimDaThem)).BeginInit();
            this.gbLuaChonPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
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
            this.pnCenter.Controls.Add(this.btnGiaHan);
            this.pnCenter.Controls.Add(this.btnThoat);
            this.pnCenter.Controls.Add(this.btnLuu);
            this.pnCenter.Controls.Add(this.groupBox3);
            this.pnCenter.Controls.Add(this.gbLuaChonPhim);
            this.pnCenter.Location = new System.Drawing.Point(21, 50);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1206, 741);
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
            this.gbxNoiDung.Controls.Add(this.dtpBanQuyenKetThuc);
            this.gbxNoiDung.Controls.Add(this.dtpBanQuyenBatDau);
            this.gbxNoiDung.Controls.Add(this.label9);
            this.gbxNoiDung.Controls.Add(this.label8);
            this.gbxNoiDung.Controls.Add(this.label7);
            this.gbxNoiDung.Controls.Add(this.txtTenPhim);
            this.gbxNoiDung.Controls.Add(this.txtMaPhim);
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
            this.numUpDowSoLuong.Location = new System.Drawing.Point(245, 108);
            this.numUpDowSoLuong.Name = "numUpDowSoLuong";
            this.numUpDowSoLuong.Size = new System.Drawing.Size(153, 28);
            this.numUpDowSoLuong.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::GUI.Properties.Resources.Giatien;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(29, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 27);
            this.label11.TabIndex = 37;
            this.label11.Text = "Giá tiền(VND)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::GUI.Properties.Resources.DonViTinh;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(405, 113);
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
            this.label5.Location = new System.Drawing.Point(29, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên phim";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::GUI.Properties.Resources.Soluong;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(29, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Số lượng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::GUI.Properties.Resources.MaSoThue;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(29, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 33;
            this.label13.Text = "Mã phim";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(245, 144);
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
            this.cbDonViTinh.Location = new System.Drawing.Point(527, 111);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(121, 27);
            this.cbDonViTinh.TabIndex = 24;
            // 
            // dtpBanQuyenKetThuc
            // 
            this.dtpBanQuyenKetThuc.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBanQuyenKetThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBanQuyenKetThuc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBanQuyenKetThuc.Location = new System.Drawing.Point(245, 232);
            this.dtpBanQuyenKetThuc.Name = "dtpBanQuyenKetThuc";
            this.dtpBanQuyenKetThuc.Size = new System.Drawing.Size(403, 28);
            this.dtpBanQuyenKetThuc.TabIndex = 20;
            // 
            // dtpBanQuyenBatDau
            // 
            this.dtpBanQuyenBatDau.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBanQuyenBatDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBanQuyenBatDau.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBanQuyenBatDau.Location = new System.Drawing.Point(245, 187);
            this.dtpBanQuyenBatDau.Name = "dtpBanQuyenBatDau";
            this.dtpBanQuyenBatDau.Size = new System.Drawing.Size(403, 28);
            this.dtpBanQuyenBatDau.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(182, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Từ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thời hạn bản quyền";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(245, 68);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(403, 28);
            this.txtTenPhim.TabIndex = 16;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(245, 30);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(403, 28);
            this.txtMaPhim.TabIndex = 14;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.Silver;
            this.btnGiaHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.Image = global::GUI.Properties.Resources.Refund;
            this.btnGiaHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaHan.Location = new System.Drawing.Point(424, 697);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(123, 38);
            this.btnGiaHan.TabIndex = 34;
            this.btnGiaHan.Text = "GIA HẠN";
            this.btnGiaHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(715, 700);
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
            this.btnLuu.Location = new System.Drawing.Point(577, 700);
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
            this.groupBox3.Controls.Add(this.dgvPhimDaThem);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1198, 265);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phim trong hợp đồng";
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
            // dgvPhimDaThem
            // 
            this.dgvPhimDaThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhimDaThem.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhimDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhimDaThem.Location = new System.Drawing.Point(6, 27);
            this.dgvPhimDaThem.Name = "dgvPhimDaThem";
            this.dgvPhimDaThem.RowHeadersWidth = 51;
            this.dgvPhimDaThem.RowTemplate.Height = 24;
            this.dgvPhimDaThem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhimDaThem.Size = new System.Drawing.Size(1186, 206);
            this.dgvPhimDaThem.TabIndex = 0;
            this.dgvPhimDaThem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhimDaThem_CellClick);
            this.dgvPhimDaThem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhimDaThem_CellDoubleClick);
            // 
            // gbLuaChonPhim
            // 
            this.gbLuaChonPhim.Controls.Add(this.dgvPhim);
            this.gbLuaChonPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChonPhim.Location = new System.Drawing.Point(3, 107);
            this.gbLuaChonPhim.Name = "gbLuaChonPhim";
            this.gbLuaChonPhim.Size = new System.Drawing.Size(535, 316);
            this.gbLuaChonPhim.TabIndex = 12;
            this.gbLuaChonPhim.TabStop = false;
            this.gbLuaChonPhim.Text = "Danh sách phim đề xuất tạo hợp đồng";
            // 
            // dgvPhim
            // 
            this.dgvPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhim.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Location = new System.Drawing.Point(6, 27);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.RowTemplate.Height = 24;
            this.dgvPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhim.Size = new System.Drawing.Size(523, 275);
            this.dgvPhim.TabIndex = 0;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
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
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỢP ĐỒNG PHIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmThemHopDongPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemHopDongPhim";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhimDaThem)).EndInit();
            this.gbLuaChonPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPhimDaThem;
        private System.Windows.Forms.GroupBox gbxNoiDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.DateTimePicker dtpBanQuyenKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBanQuyenBatDau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.DataGridView dgvPhim;
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
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private System.Windows.Forms.NumericUpDown numUpDowSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTenCungCap;
        private System.Windows.Forms.Label label14;
    }
}