namespace GUI.QLP_GUI
{
    partial class UC_TaoPhieu_QLP
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
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.cBMaKho = new System.Windows.Forms.ComboBox();
            this.cBMaLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbPhimDaThem = new System.Windows.Forms.Label();
            this.lbMaKho = new System.Windows.Forms.Label();
            this.lbLoaiPhieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gBPhimDaThem = new System.Windows.Forms.GroupBox();
            this.dGVPhimDaThem = new System.Windows.Forms.DataGridView();
            this.gBLuaChonPhim = new System.Windows.Forms.GroupBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.nUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.cBDonViTinh = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gBPhimDaThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhimDaThem)).BeginInit();
            this.gBLuaChonPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.White;
            this.txtTenPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhim.Location = new System.Drawing.Point(582, 66);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(488, 28);
            this.txtTenPhim.TabIndex = 5;
            // 
            // cBMaKho
            // 
            this.cBMaKho.BackColor = System.Drawing.Color.White;
            this.cBMaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBMaKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.cBMaKho.FormattingEnabled = true;
            this.cBMaKho.Location = new System.Drawing.Point(802, 49);
            this.cBMaKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBMaKho.Name = "cBMaKho";
            this.cBMaKho.Size = new System.Drawing.Size(304, 27);
            this.cBMaKho.TabIndex = 8;
            // 
            // cBMaLoaiPhieu
            // 
            this.cBMaLoaiPhieu.BackColor = System.Drawing.Color.White;
            this.cBMaLoaiPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBMaLoaiPhieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.cBMaLoaiPhieu.FormattingEnabled = true;
            this.cBMaLoaiPhieu.Location = new System.Drawing.Point(182, 46);
            this.cBMaLoaiPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBMaLoaiPhieu.Name = "cBMaLoaiPhieu";
            this.cBMaLoaiPhieu.Size = new System.Drawing.Size(369, 27);
            this.cBMaLoaiPhieu.TabIndex = 9;
            this.cBMaLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cBMaLoaiPhieu_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.lbPhimDaThem);
            this.panel1.Controls.Add(this.lbMaKho);
            this.panel1.Controls.Add(this.lbLoaiPhieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gBPhimDaThem);
            this.panel1.Controls.Add(this.cBMaKho);
            this.panel1.Controls.Add(this.gBLuaChonPhim);
            this.panel1.Controls.Add(this.cBMaLoaiPhieu);
            this.panel1.Location = new System.Drawing.Point(26, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 583);
            this.panel1.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.trash_can_26px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(495, 542);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 36);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbPhimDaThem
            // 
            this.lbPhimDaThem.AutoSize = true;
            this.lbPhimDaThem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhimDaThem.ForeColor = System.Drawing.Color.Red;
            this.lbPhimDaThem.Location = new System.Drawing.Point(54, 523);
            this.lbPhimDaThem.Name = "lbPhimDaThem";
            this.lbPhimDaThem.Size = new System.Drawing.Size(0, 17);
            this.lbPhimDaThem.TabIndex = 69;
            // 
            // lbMaKho
            // 
            this.lbMaKho.AutoSize = true;
            this.lbMaKho.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKho.ForeColor = System.Drawing.Color.Red;
            this.lbMaKho.Location = new System.Drawing.Point(798, 75);
            this.lbMaKho.Name = "lbMaKho";
            this.lbMaKho.Size = new System.Drawing.Size(0, 17);
            this.lbMaKho.TabIndex = 68;
            // 
            // lbLoaiPhieu
            // 
            this.lbLoaiPhieu.AutoSize = true;
            this.lbLoaiPhieu.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhieu.ForeColor = System.Drawing.Color.Red;
            this.lbLoaiPhieu.Location = new System.Drawing.Point(179, 73);
            this.lbLoaiPhieu.Name = "lbLoaiPhieu";
            this.lbLoaiPhieu.Size = new System.Drawing.Size(0, 17);
            this.lbLoaiPhieu.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 59;
            this.label1.Text = "Loại Phiếu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::GUI.Properties.Resources.NhaKho;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(652, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 58;
            this.label3.Text = "Mã Kho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(988, 542);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(422, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 35);
            this.label6.TabIndex = 27;
            this.label6.Text = "TẠO PHIẾU NHẬP XUẤT KHO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBPhimDaThem
            // 
            this.gBPhimDaThem.Controls.Add(this.dGVPhimDaThem);
            this.gBPhimDaThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBPhimDaThem.Location = new System.Drawing.Point(36, 368);
            this.gBPhimDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBPhimDaThem.Name = "gBPhimDaThem";
            this.gBPhimDaThem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBPhimDaThem.Size = new System.Drawing.Size(1087, 169);
            this.gBPhimDaThem.TabIndex = 15;
            this.gBPhimDaThem.TabStop = false;
            this.gBPhimDaThem.Text = "PHIM ĐÃ THÊM";
            // 
            // dGVPhimDaThem
            // 
            this.dGVPhimDaThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPhimDaThem.BackgroundColor = System.Drawing.Color.White;
            this.dGVPhimDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPhimDaThem.Location = new System.Drawing.Point(16, 25);
            this.dGVPhimDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVPhimDaThem.Name = "dGVPhimDaThem";
            this.dGVPhimDaThem.ReadOnly = true;
            this.dGVPhimDaThem.RowHeadersWidth = 62;
            this.dGVPhimDaThem.RowTemplate.Height = 28;
            this.dGVPhimDaThem.Size = new System.Drawing.Size(1054, 129);
            this.dGVPhimDaThem.TabIndex = 0;
            this.dGVPhimDaThem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPhimDaThem_CellDoubleClick);
            // 
            // gBLuaChonPhim
            // 
            this.gBLuaChonPhim.Controls.Add(this.btnChinhSua);
            this.gBLuaChonPhim.Controls.Add(this.lbDonViTinh);
            this.gBLuaChonPhim.Controls.Add(this.lbSoLuong);
            this.gBLuaChonPhim.Controls.Add(this.btnThem);
            this.gBLuaChonPhim.Controls.Add(this.txtMaPhim);
            this.gBLuaChonPhim.Controls.Add(this.nUDSoLuong);
            this.gBLuaChonPhim.Controls.Add(this.label4);
            this.gBLuaChonPhim.Controls.Add(this.label10);
            this.gBLuaChonPhim.Controls.Add(this.label2);
            this.gBLuaChonPhim.Controls.Add(this.label13);
            this.gBLuaChonPhim.Controls.Add(this.dGVDanhSachPhim);
            this.gBLuaChonPhim.Controls.Add(this.cBDonViTinh);
            this.gBLuaChonPhim.Controls.Add(this.txtTenPhim);
            this.gBLuaChonPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBLuaChonPhim.Location = new System.Drawing.Point(36, 98);
            this.gBLuaChonPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBLuaChonPhim.Name = "gBLuaChonPhim";
            this.gBLuaChonPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBLuaChonPhim.Size = new System.Drawing.Size(1087, 267);
            this.gBLuaChonPhim.TabIndex = 14;
            this.gBLuaChonPhim.TabStop = false;
            this.gBLuaChonPhim.Text = "LỰA CHỌN PHIM";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.Edit;
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(932, 214);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(138, 36);
            this.btnChinhSua.TabIndex = 73;
            this.btnChinhSua.Text = "CHỈNH SỬA";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonViTinh.ForeColor = System.Drawing.Color.Red;
            this.lbDonViTinh.Location = new System.Drawing.Point(582, 193);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(0, 17);
            this.lbDonViTinh.TabIndex = 66;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lbSoLuong.Location = new System.Drawing.Point(582, 145);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(0, 17);
            this.lbSoLuong.TabIndex = 65;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(948, 214);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 36);
            this.btnThem.TabIndex = 64;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.White;
            this.txtMaPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhim.Location = new System.Drawing.Point(953, 66);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(118, 28);
            this.txtMaPhim.TabIndex = 63;
            // 
            // nUDSoLuong
            // 
            this.nUDSoLuong.Location = new System.Drawing.Point(582, 116);
            this.nUDSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSoLuong.Name = "nUDSoLuong";
            this.nUDSoLuong.Size = new System.Drawing.Size(488, 28);
            this.nUDSoLuong.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.film_reel_26px;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(14, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 61;
            this.label4.Text = "Danh Sách Phim";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::GUI.Properties.Resources.DonViTinh;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(434, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 27);
            this.label10.TabIndex = 60;
            this.label10.Text = "Đơn vị tính";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.Soluong;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(434, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 59;
            this.label2.Text = "Số lượng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::GUI.Properties.Resources.MovieRoom;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(435, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 27);
            this.label13.TabIndex = 58;
            this.label13.Text = "Tên Phim";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(17, 68);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(394, 182);
            this.dGVDanhSachPhim.TabIndex = 8;
            this.dGVDanhSachPhim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhim_CellDoubleClick);
            // 
            // cBDonViTinh
            // 
            this.cBDonViTinh.BackColor = System.Drawing.Color.White;
            this.cBDonViTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBDonViTinh.FormattingEnabled = true;
            this.cBDonViTinh.Location = new System.Drawing.Point(582, 166);
            this.cBDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBDonViTinh.Name = "cBDonViTinh";
            this.cBDonViTinh.Size = new System.Drawing.Size(488, 27);
            this.cBDonViTinh.TabIndex = 7;
            // 
            // UC_TaoPhieu_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TaoPhieu_QLP";
            this.Size = new System.Drawing.Size(1185, 613);
            this.Leave += new System.EventHandler(this.UC_TaoPhieu_QLP_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBPhimDaThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhimDaThem)).EndInit();
            this.gBLuaChonPhim.ResumeLayout(false);
            this.gBLuaChonPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.ComboBox cBMaKho;
        private System.Windows.Forms.ComboBox cBMaLoaiPhieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBLuaChonPhim;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.GroupBox gBPhimDaThem;
        private System.Windows.Forms.DataGridView dGVPhimDaThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDSoLuong;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.ComboBox cBDonViTinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbMaKho;
        private System.Windows.Forms.Label lbLoaiPhieu;
        private System.Windows.Forms.Label lbPhimDaThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
    }
}
