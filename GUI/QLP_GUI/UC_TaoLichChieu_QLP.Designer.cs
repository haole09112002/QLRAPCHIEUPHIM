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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rBDSPChieu = new System.Windows.Forms.RadioButton();
            this.rBDSPhim = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaKhungGioChieu = new System.Windows.Forms.TextBox();
            this.txtMaPhongChieu = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGioChieu = new System.Windows.Forms.TextBox();
            this.txtPhongChieu = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.gBDanhSachPhim = new System.Windows.Forms.GroupBox();
            this.gBDanhSachPhongChieu = new System.Windows.Forms.GroupBox();
            this.dGVDanhSachPC = new System.Windows.Forms.DataGridView();
            this.gBKhungGioChieu = new System.Windows.Forms.GroupBox();
            this.dGVKhungGioChieu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.gBDanhSachPhongChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPC)).BeginInit();
            this.gBKhungGioChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhungGioChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.rBDSPChieu);
            this.panel1.Controls.Add(this.rBDSPhim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dGVDanhSachPhim);
            this.panel1.Controls.Add(this.gBDanhSachPhim);
            this.panel1.Controls.Add(this.gBDanhSachPhongChieu);
            this.panel1.Controls.Add(this.gBKhungGioChieu);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 760);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Image = global::GUI.Properties.Resources.ScheduleTitle;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(254, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 56;
            this.label5.Text = "LỊCH CHIẾU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::GUI.Properties.Resources.Renew;
            this.btnLamMoi.Location = new System.Drawing.Point(782, 671);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 36);
            this.btnLamMoi.TabIndex = 55;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1159, 534);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 53;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(1013, 671);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 54;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(782, 540);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(347, 28);
            this.txtTimKiem.TabIndex = 52;
            // 
            // rBDSPChieu
            // 
            this.rBDSPChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBDSPChieu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDSPChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.rBDSPChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBDSPChieu.Location = new System.Drawing.Point(1013, 595);
            this.rBDSPChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBDSPChieu.Name = "rBDSPChieu";
            this.rBDSPChieu.Size = new System.Drawing.Size(252, 38);
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
            this.rBDSPhim.Location = new System.Drawing.Point(782, 598);
            this.rBDSPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBDSPhim.Name = "rBDSPhim";
            this.rBDSPhim.Size = new System.Drawing.Size(196, 33);
            this.rBDSPhim.TabIndex = 47;
            this.rBDSPhim.TabStop = true;
            this.rBDSPhim.Text = "Danh Sách Phim";
            this.rBDSPhim.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMaKhungGioChieu);
            this.panel2.Controls.Add(this.txtMaPhongChieu);
            this.panel2.Controls.Add(this.txtMaPhim);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dTPNgayChieu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtGioChieu);
            this.panel2.Controls.Add(this.txtPhongChieu);
            this.panel2.Controls.Add(this.txtTenPhim);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(14, 540);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 195);
            this.panel2.TabIndex = 46;
            // 
            // txtMaKhungGioChieu
            // 
            this.txtMaKhungGioChieu.BackColor = System.Drawing.Color.White;
            this.txtMaKhungGioChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhungGioChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaKhungGioChieu.Location = new System.Drawing.Point(560, 105);
            this.txtMaKhungGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhungGioChieu.Name = "txtMaKhungGioChieu";
            this.txtMaKhungGioChieu.Size = new System.Drawing.Size(110, 28);
            this.txtMaKhungGioChieu.TabIndex = 49;
            // 
            // txtMaPhongChieu
            // 
            this.txtMaPhongChieu.BackColor = System.Drawing.Color.White;
            this.txtMaPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaPhongChieu.Location = new System.Drawing.Point(560, 62);
            this.txtMaPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhongChieu.Name = "txtMaPhongChieu";
            this.txtMaPhongChieu.Size = new System.Drawing.Size(110, 28);
            this.txtMaPhongChieu.TabIndex = 48;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.White;
            this.txtMaPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaPhim.Location = new System.Drawing.Point(560, 17);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(110, 28);
            this.txtMaPhim.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.ScheduleTitle;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ngày Chiếu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.MovieRoom;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 27);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phòng chiếu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTPNgayChieu
            // 
            this.dTPNgayChieu.Location = new System.Drawing.Point(194, 146);
            this.dTPNgayChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPNgayChieu.Name = "dTPNgayChieu";
            this.dTPNgayChieu.Size = new System.Drawing.Size(476, 28);
            this.dTPNgayChieu.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::GUI.Properties.Resources.Time;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giờ chiếu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.AddHopDongPhim;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên phim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGioChieu
            // 
            this.txtGioChieu.BackColor = System.Drawing.Color.White;
            this.txtGioChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtGioChieu.Location = new System.Drawing.Point(194, 106);
            this.txtGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioChieu.Name = "txtGioChieu";
            this.txtGioChieu.ReadOnly = true;
            this.txtGioChieu.Size = new System.Drawing.Size(476, 28);
            this.txtGioChieu.TabIndex = 5;
            // 
            // txtPhongChieu
            // 
            this.txtPhongChieu.BackColor = System.Drawing.Color.White;
            this.txtPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPhongChieu.Location = new System.Drawing.Point(194, 62);
            this.txtPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhongChieu.Name = "txtPhongChieu";
            this.txtPhongChieu.ReadOnly = true;
            this.txtPhongChieu.Size = new System.Drawing.Size(476, 28);
            this.txtPhongChieu.TabIndex = 4;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.White;
            this.txtTenPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTenPhim.Location = new System.Drawing.Point(194, 17);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.ReadOnly = true;
            this.txtTenPhim.Size = new System.Drawing.Size(476, 28);
            this.txtTenPhim.TabIndex = 39;
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.AllowUserToAddRows = false;
            this.dGVDanhSachPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachPhim.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDanhSachPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDanhSachPhim.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(23, 38);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDanhSachPhim.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(474, 427);
            this.dGVDanhSachPhim.TabIndex = 41;
            this.dGVDanhSachPhim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhim_CellDoubleClick);
            // 
            // gBDanhSachPhim
            // 
            this.gBDanhSachPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhim.Location = new System.Drawing.Point(8, 12);
            this.gBDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Name = "gBDanhSachPhim";
            this.gBDanhSachPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Size = new System.Drawing.Size(507, 481);
            this.gBDanhSachPhim.TabIndex = 49;
            this.gBDanhSachPhim.TabStop = false;
            this.gBDanhSachPhim.Text = "DANH SÁCH PHIM";
            // 
            // gBDanhSachPhongChieu
            // 
            this.gBDanhSachPhongChieu.Controls.Add(this.dGVDanhSachPC);
            this.gBDanhSachPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhongChieu.Location = new System.Drawing.Point(535, 15);
            this.gBDanhSachPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhongChieu.Name = "gBDanhSachPhongChieu";
            this.gBDanhSachPhongChieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhongChieu.Size = new System.Drawing.Size(362, 484);
            this.gBDanhSachPhongChieu.TabIndex = 50;
            this.gBDanhSachPhongChieu.TabStop = false;
            this.gBDanhSachPhongChieu.Text = "DANH SÁCH PHÒNG CHIẾU";
            // 
            // dGVDanhSachPC
            // 
            this.dGVDanhSachPC.AllowUserToAddRows = false;
            this.dGVDanhSachPC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachPC.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPC.Location = new System.Drawing.Point(28, 42);
            this.dGVDanhSachPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPC.Name = "dGVDanhSachPC";
            this.dGVDanhSachPC.RowHeadersWidth = 62;
            this.dGVDanhSachPC.RowTemplate.Height = 28;
            this.dGVDanhSachPC.Size = new System.Drawing.Size(334, 422);
            this.dGVDanhSachPC.TabIndex = 42;
            this.dGVDanhSachPC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPC_CellDoubleClick);
            // 
            // gBKhungGioChieu
            // 
            this.gBKhungGioChieu.Controls.Add(this.dGVKhungGioChieu);
            this.gBKhungGioChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBKhungGioChieu.Location = new System.Drawing.Point(923, 12);
            this.gBKhungGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBKhungGioChieu.Name = "gBKhungGioChieu";
            this.gBKhungGioChieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBKhungGioChieu.Size = new System.Drawing.Size(387, 487);
            this.gBKhungGioChieu.TabIndex = 51;
            this.gBKhungGioChieu.TabStop = false;
            this.gBKhungGioChieu.Text = "KHUNG GIỜ CHIẾU";
            // 
            // dGVKhungGioChieu
            // 
            this.dGVKhungGioChieu.AllowUserToAddRows = false;
            this.dGVKhungGioChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVKhungGioChieu.BackgroundColor = System.Drawing.Color.White;
            this.dGVKhungGioChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKhungGioChieu.Location = new System.Drawing.Point(27, 25);
            this.dGVKhungGioChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVKhungGioChieu.Name = "dGVKhungGioChieu";
            this.dGVKhungGioChieu.RowHeadersWidth = 62;
            this.dGVKhungGioChieu.RowTemplate.Height = 28;
            this.dGVKhungGioChieu.Size = new System.Drawing.Size(340, 442);
            this.dGVKhungGioChieu.TabIndex = 44;
            this.dGVKhungGioChieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKhungGioChieu_CellDoubleClick);
            // 
            // UC_TaoLichChieu_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TaoLichChieu_QLP";
            this.Size = new System.Drawing.Size(1360, 788);
            this.Leave += new System.EventHandler(this.UC_TaoLichChieu_QLP_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.gBDanhSachPhongChieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPC)).EndInit();
            this.gBKhungGioChieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhungGioChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rBDSPChieu;
        private System.Windows.Forms.RadioButton rBDSPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGioChieu;
        private System.Windows.Forms.TextBox txtPhongChieu;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.DataGridView dGVKhungGioChieu;
        private System.Windows.Forms.DataGridView dGVDanhSachPC;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.GroupBox gBDanhSachPhim;
        private System.Windows.Forms.GroupBox gBDanhSachPhongChieu;
        private System.Windows.Forms.GroupBox gBKhungGioChieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPNgayChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhungGioChieu;
        private System.Windows.Forms.TextBox txtMaPhongChieu;
        private System.Windows.Forms.TextBox txtMaPhim;
    }
}
