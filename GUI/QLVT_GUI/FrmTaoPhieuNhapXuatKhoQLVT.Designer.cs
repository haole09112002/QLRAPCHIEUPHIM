namespace GUI.QLVT_GUI
{
    partial class FrmTaoPhieuNhapXuatKhoQLVT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnPhieuNhapXuatKho = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnTitleNhapXuatKho = new System.Windows.Forms.Panel();
            this.lblTitlePhieuNXKho = new System.Windows.Forms.Label();
            this.pnContentNXKho = new System.Windows.Forms.Panel();
            this.lblChonKho = new System.Windows.Forms.Label();
            this.lblChonLoaiPhieu = new System.Windows.Forms.Label();
            this.txtLoaiSanPham = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.lblLoaiPhieu = new System.Windows.Forms.Label();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grpSanPhamDaThem = new System.Windows.Forms.GroupBox();
            this.dgvSanPhamDaThem = new System.Windows.Forms.DataGridView();
            this.cboMaKho = new System.Windows.Forms.ComboBox();
            this.grpLuaChonSanPham = new System.Windows.Forms.GroupBox();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblValidSoLuong = new System.Windows.Forms.Label();
            this.lblValidatedSoLuong = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.nUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblListSanPham = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.dgvListSanPham = new System.Windows.Forms.DataGridView();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.pnPhieuNhapXuatKho.SuspendLayout();
            this.pnTitleNhapXuatKho.SuspendLayout();
            this.pnContentNXKho.SuspendLayout();
            this.grpSanPhamDaThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDaThem)).BeginInit();
            this.grpLuaChonSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPhieuNhapXuatKho
            // 
            this.pnPhieuNhapXuatKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPhieuNhapXuatKho.Controls.Add(this.btnThoat);
            this.pnPhieuNhapXuatKho.Controls.Add(this.pnTitleNhapXuatKho);
            this.pnPhieuNhapXuatKho.Controls.Add(this.pnContentNXKho);
            this.pnPhieuNhapXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPhieuNhapXuatKho.Location = new System.Drawing.Point(0, 0);
            this.pnPhieuNhapXuatKho.Name = "pnPhieuNhapXuatKho";
            this.pnPhieuNhapXuatKho.Size = new System.Drawing.Size(975, 700);
            this.pnPhieuNhapXuatKho.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(427, 641);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 36);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnTitleNhapXuatKho
            // 
            this.pnTitleNhapXuatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnTitleNhapXuatKho.Controls.Add(this.lblTitlePhieuNXKho);
            this.pnTitleNhapXuatKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleNhapXuatKho.Location = new System.Drawing.Point(0, 0);
            this.pnTitleNhapXuatKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitleNhapXuatKho.Name = "pnTitleNhapXuatKho";
            this.pnTitleNhapXuatKho.Size = new System.Drawing.Size(973, 45);
            this.pnTitleNhapXuatKho.TabIndex = 33;
            // 
            // lblTitlePhieuNXKho
            // 
            this.lblTitlePhieuNXKho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitlePhieuNXKho.Image = global::GUI.Properties.Resources.NhapXuat;
            this.lblTitlePhieuNXKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitlePhieuNXKho.Location = new System.Drawing.Point(330, 5);
            this.lblTitlePhieuNXKho.Name = "lblTitlePhieuNXKho";
            this.lblTitlePhieuNXKho.Size = new System.Drawing.Size(311, 35);
            this.lblTitlePhieuNXKho.TabIndex = 27;
            this.lblTitlePhieuNXKho.Text = "TẠO PHIẾU NHẬP XUẤT KHO";
            this.lblTitlePhieuNXKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnContentNXKho
            // 
            this.pnContentNXKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContentNXKho.Controls.Add(this.lblChonKho);
            this.pnContentNXKho.Controls.Add(this.lblChonLoaiPhieu);
            this.pnContentNXKho.Controls.Add(this.txtLoaiSanPham);
            this.pnContentNXKho.Controls.Add(this.btnXoa);
            this.pnContentNXKho.Controls.Add(this.lblLoaiSanPham);
            this.pnContentNXKho.Controls.Add(this.lblLoaiPhieu);
            this.pnContentNXKho.Controls.Add(this.lblMaKho);
            this.pnContentNXKho.Controls.Add(this.btnLuu);
            this.pnContentNXKho.Controls.Add(this.grpSanPhamDaThem);
            this.pnContentNXKho.Controls.Add(this.cboMaKho);
            this.pnContentNXKho.Controls.Add(this.grpLuaChonSanPham);
            this.pnContentNXKho.Controls.Add(this.cboLoaiPhieu);
            this.pnContentNXKho.Location = new System.Drawing.Point(37, 62);
            this.pnContentNXKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentNXKho.Name = "pnContentNXKho";
            this.pnContentNXKho.Size = new System.Drawing.Size(902, 549);
            this.pnContentNXKho.TabIndex = 13;
            // 
            // lblChonKho
            // 
            this.lblChonKho.BackColor = System.Drawing.Color.White;
            this.lblChonKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChonKho.Location = new System.Drawing.Point(458, 5);
            this.lblChonKho.Name = "lblChonKho";
            this.lblChonKho.Size = new System.Drawing.Size(144, 19);
            this.lblChonKho.TabIndex = 85;
            this.lblChonKho.Text = "*Chọn kho";
            this.lblChonKho.Visible = false;
            // 
            // lblChonLoaiPhieu
            // 
            this.lblChonLoaiPhieu.BackColor = System.Drawing.Color.White;
            this.lblChonLoaiPhieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLoaiPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChonLoaiPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChonLoaiPhieu.Location = new System.Drawing.Point(728, 6);
            this.lblChonLoaiPhieu.Name = "lblChonLoaiPhieu";
            this.lblChonLoaiPhieu.Size = new System.Drawing.Size(144, 19);
            this.lblChonLoaiPhieu.TabIndex = 84;
            this.lblChonLoaiPhieu.Text = "*Chọn loại phiếu";
            this.lblChonLoaiPhieu.Visible = false;
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiSanPham.Location = new System.Drawing.Point(191, 26);
            this.txtLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.ReadOnly = true;
            this.txtLoaiSanPham.Size = new System.Drawing.Size(151, 26);
            this.txtLoaiSanPham.TabIndex = 76;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.trash_can_26px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(163, 497);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 36);
            this.btnXoa.TabIndex = 75;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSanPham.Image = global::GUI.Properties.Resources.Nhacungcap;
            this.lblLoaiSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLoaiSanPham.Location = new System.Drawing.Point(37, 22);
            this.lblLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(151, 27);
            this.lblLoaiSanPham.TabIndex = 63;
            this.lblLoaiSanPham.Text = "Loại Sản Phẩm";
            this.lblLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoaiPhieu
            // 
            this.lblLoaiPhieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhieu.Image = global::GUI.Properties.Resources.NhapXuat;
            this.lblLoaiPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLoaiPhieu.Location = new System.Drawing.Point(599, 26);
            this.lblLoaiPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiPhieu.Name = "lblLoaiPhieu";
            this.lblLoaiPhieu.Size = new System.Drawing.Size(118, 27);
            this.lblLoaiPhieu.TabIndex = 59;
            this.lblLoaiPhieu.Text = "Loại Phiếu";
            this.lblLoaiPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaKho
            // 
            this.lblMaKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKho.Image = global::GUI.Properties.Resources.NhaKho;
            this.lblMaKho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaKho.Location = new System.Drawing.Point(349, 24);
            this.lblMaKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(109, 27);
            this.lblMaKho.TabIndex = 58;
            this.lblMaKho.Text = "Tên Kho";
            this.lblMaKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(629, 498);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grpSanPhamDaThem
            // 
            this.grpSanPhamDaThem.Controls.Add(this.dgvSanPhamDaThem);
            this.grpSanPhamDaThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpSanPhamDaThem.Location = new System.Drawing.Point(41, 342);
            this.grpSanPhamDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSanPhamDaThem.Name = "grpSanPhamDaThem";
            this.grpSanPhamDaThem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSanPhamDaThem.Size = new System.Drawing.Size(827, 141);
            this.grpSanPhamDaThem.TabIndex = 15;
            this.grpSanPhamDaThem.TabStop = false;
            this.grpSanPhamDaThem.Text = "SẢN PHẨM ĐÃ THÊM";
            // 
            // dgvSanPhamDaThem
            // 
            this.dgvSanPhamDaThem.AllowUserToAddRows = false;
            this.dgvSanPhamDaThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPhamDaThem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPhamDaThem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPhamDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamDaThem.Location = new System.Drawing.Point(16, 25);
            this.dgvSanPhamDaThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPhamDaThem.Name = "dgvSanPhamDaThem";
            this.dgvSanPhamDaThem.ReadOnly = true;
            this.dgvSanPhamDaThem.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSanPhamDaThem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPhamDaThem.RowTemplate.Height = 28;
            this.dgvSanPhamDaThem.Size = new System.Drawing.Size(793, 99);
            this.dgvSanPhamDaThem.TabIndex = 0;
            this.dgvSanPhamDaThem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSanPhamDaThem_MouseClick);
            // 
            // cboMaKho
            // 
            this.cboMaKho.BackColor = System.Drawing.Color.White;
            this.cboMaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaKho.FormattingEnabled = true;
            this.cboMaKho.Location = new System.Drawing.Point(468, 25);
            this.cboMaKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaKho.Name = "cboMaKho";
            this.cboMaKho.Size = new System.Drawing.Size(124, 28);
            this.cboMaKho.TabIndex = 8;
            this.cboMaKho.SelectedIndexChanged += new System.EventHandler(this.cboMaKho_SelectedIndexChanged);
            // 
            // grpLuaChonSanPham
            // 
            this.grpLuaChonSanPham.Controls.Add(this.lblMaSanPham);
            this.grpLuaChonSanPham.Controls.Add(this.txtMaSanPham);
            this.grpLuaChonSanPham.Controls.Add(this.lblValidSoLuong);
            this.grpLuaChonSanPham.Controls.Add(this.lblValidatedSoLuong);
            this.grpLuaChonSanPham.Controls.Add(this.txtDonViTinh);
            this.grpLuaChonSanPham.Controls.Add(this.btnThem);
            this.grpLuaChonSanPham.Controls.Add(this.btnChinhSua);
            this.grpLuaChonSanPham.Controls.Add(this.nUDSoLuong);
            this.grpLuaChonSanPham.Controls.Add(this.lblListSanPham);
            this.grpLuaChonSanPham.Controls.Add(this.lblDonViTinh);
            this.grpLuaChonSanPham.Controls.Add(this.lblSoLuong);
            this.grpLuaChonSanPham.Controls.Add(this.lblTenSanPham);
            this.grpLuaChonSanPham.Controls.Add(this.dgvListSanPham);
            this.grpLuaChonSanPham.Controls.Add(this.txtTenSanPham);
            this.grpLuaChonSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpLuaChonSanPham.Location = new System.Drawing.Point(41, 62);
            this.grpLuaChonSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLuaChonSanPham.Name = "grpLuaChonSanPham";
            this.grpLuaChonSanPham.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLuaChonSanPham.Size = new System.Drawing.Size(827, 276);
            this.grpLuaChonSanPham.TabIndex = 14;
            this.grpLuaChonSanPham.TabStop = false;
            this.grpLuaChonSanPham.Text = "LỰA CHỌN SẢN PHẨM";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanPham.Image = global::GUI.Properties.Resources.MaSoThue;
            this.lblMaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaSanPham.Location = new System.Drawing.Point(436, 24);
            this.lblMaSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(151, 27);
            this.lblMaSanPham.TabIndex = 88;
            this.lblMaSanPham.Text = "Mã Sản Phẩm";
            this.lblMaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSanPham.Location = new System.Drawing.Point(619, 25);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(190, 28);
            this.txtMaSanPham.TabIndex = 87;
            // 
            // lblValidSoLuong
            // 
            this.lblValidSoLuong.BackColor = System.Drawing.Color.White;
            this.lblValidSoLuong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblValidSoLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidSoLuong.Location = new System.Drawing.Point(446, 194);
            this.lblValidSoLuong.Name = "lblValidSoLuong";
            this.lblValidSoLuong.Size = new System.Drawing.Size(385, 19);
            this.lblValidSoLuong.TabIndex = 86;
            this.lblValidSoLuong.Text = "*Số lượng không được lớn hơn trong hợp đồng";
            this.lblValidSoLuong.Visible = false;
            // 
            // lblValidatedSoLuong
            // 
            this.lblValidatedSoLuong.BackColor = System.Drawing.Color.White;
            this.lblValidatedSoLuong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblValidatedSoLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidatedSoLuong.Location = new System.Drawing.Point(483, 194);
            this.lblValidatedSoLuong.Name = "lblValidatedSoLuong";
            this.lblValidatedSoLuong.Size = new System.Drawing.Size(351, 19);
            this.lblValidatedSoLuong.TabIndex = 85;
            this.lblValidatedSoLuong.Text = "*Không được vượt quá số hàng trong kho";
            this.lblValidatedSoLuong.Visible = false;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDonViTinh.Location = new System.Drawing.Point(619, 116);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(190, 28);
            this.txtDonViTinh.TabIndex = 76;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Enabled = false;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(690, 225);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 36);
            this.btnThem.TabIndex = 75;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.Edit;
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(690, 225);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(119, 36);
            this.btnChinhSua.TabIndex = 74;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Visible = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // nUDSoLuong
            // 
            this.nUDSoLuong.Enabled = false;
            this.nUDSoLuong.Location = new System.Drawing.Point(619, 164);
            this.nUDSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSoLuong.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nUDSoLuong.Name = "nUDSoLuong";
            this.nUDSoLuong.Size = new System.Drawing.Size(190, 28);
            this.nUDSoLuong.TabIndex = 63;
            this.nUDSoLuong.ValueChanged += new System.EventHandler(this.nUDSoLuong_ValueChanged);
            // 
            // lblListSanPham
            // 
            this.lblListSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSanPham.Image = global::GUI.Properties.Resources.NhapXuat;
            this.lblListSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListSanPham.Location = new System.Drawing.Point(14, 25);
            this.lblListSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListSanPham.Name = "lblListSanPham";
            this.lblListSanPham.Size = new System.Drawing.Size(231, 32);
            this.lblListSanPham.TabIndex = 61;
            this.lblListSanPham.Text = "Danh Sách SẢN PHẨM";
            this.lblListSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Image = global::GUI.Properties.Resources.DonViTinh;
            this.lblDonViTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDonViTinh.Location = new System.Drawing.Point(436, 116);
            this.lblDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(119, 27);
            this.lblDonViTinh.TabIndex = 60;
            this.lblDonViTinh.Text = "Đơn vị tính";
            this.lblDonViTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Image = global::GUI.Properties.Resources.Soluong;
            this.lblSoLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSoLuong.Location = new System.Drawing.Point(436, 162);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(106, 27);
            this.lblSoLuong.TabIndex = 59;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Image = global::GUI.Properties.Resources.MaSoThue;
            this.lblTenSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTenSanPham.Location = new System.Drawing.Point(436, 68);
            this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(151, 27);
            this.lblTenSanPham.TabIndex = 58;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            this.lblTenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListSanPham
            // 
            this.dgvListSanPham.AllowUserToAddRows = false;
            this.dgvListSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvListSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSanPham.Location = new System.Drawing.Point(17, 59);
            this.dgvListSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListSanPham.Name = "dgvListSanPham";
            this.dgvListSanPham.ReadOnly = true;
            this.dgvListSanPham.RowHeadersWidth = 62;
            this.dgvListSanPham.RowTemplate.Height = 28;
            this.dgvListSanPham.Size = new System.Drawing.Size(400, 202);
            this.dgvListSanPham.TabIndex = 8;
            this.dgvListSanPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListSanPham_MouseClick);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSanPham.Location = new System.Drawing.Point(619, 66);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(190, 28);
            this.txtTenSanPham.TabIndex = 5;
            // 
            // cboLoaiPhieu
            // 
            this.cboLoaiPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboLoaiPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiPhieu.FormattingEnabled = true;
            this.cboLoaiPhieu.Location = new System.Drawing.Point(731, 27);
            this.cboLoaiPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiPhieu.Name = "cboLoaiPhieu";
            this.cboLoaiPhieu.Size = new System.Drawing.Size(137, 28);
            this.cboLoaiPhieu.TabIndex = 9;
            this.cboLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhieu_SelectedIndexChanged);
            // 
            // FrmTaoPhieuNhapXuatKhoQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 700);
            this.Controls.Add(this.pnPhieuNhapXuatKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTaoPhieuNhapXuatKhoQLVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnPhieuNhapXuatKho.ResumeLayout(false);
            this.pnTitleNhapXuatKho.ResumeLayout(false);
            this.pnContentNXKho.ResumeLayout(false);
            this.pnContentNXKho.PerformLayout();
            this.grpSanPhamDaThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDaThem)).EndInit();
            this.grpLuaChonSanPham.ResumeLayout(false);
            this.grpLuaChonSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPhieuNhapXuatKho;
        private System.Windows.Forms.Panel pnContentNXKho;
        private System.Windows.Forms.Label lblLoaiPhieu;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.Label lblTitlePhieuNXKho;
        private System.Windows.Forms.GroupBox grpSanPhamDaThem;
        private System.Windows.Forms.DataGridView dgvSanPhamDaThem;
        private System.Windows.Forms.ComboBox cboMaKho;
        private System.Windows.Forms.GroupBox grpLuaChonSanPham;
        private System.Windows.Forms.Label lblListSanPham;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvListSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.ComboBox cboLoaiPhieu;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.Panel pnTitleNhapXuatKho;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.NumericUpDown nUDSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLoaiSanPham;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblChonKho;
        private System.Windows.Forms.Label lblChonLoaiPhieu;
        private System.Windows.Forms.Label lblValidatedSoLuong;
        private System.Windows.Forms.Label lblValidSoLuong;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
    }
}