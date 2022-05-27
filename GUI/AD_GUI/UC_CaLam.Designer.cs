namespace GUI.AD_GUI
{
    partial class UC_CaLam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblValidatedCaLamViec = new System.Windows.Forms.Label();
            this.lblValidatedNgayLamViec = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboThemCaLamViec = new System.Windows.Forms.ComboBox();
            this.dtpThemNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorChonXoa = new System.Windows.Forms.Label();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.lblErrorXoa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.dtpTimKiemLich = new System.Windows.Forms.DateTimePicker();
            this.cboTimKiemCaLamViec = new System.Windows.Forms.ComboBox();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValidatedNhanVien = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 738);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaNhanVien);
            this.groupBox4.Controls.Add(this.lblMaNhanVien);
            this.groupBox4.Controls.Add(this.lblValidatedCaLamViec);
            this.groupBox4.Controls.Add(this.lblValidatedNgayLamViec);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.cboThemCaLamViec);
            this.groupBox4.Controls.Add(this.dtpThemNgayLamViec);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtTenNhanVien);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(528, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(763, 349);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "THÊM LỊCH LÀM VIỆC CHO NHÂN VIÊN";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(279, 258);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(469, 28);
            this.txtMaNhanVien.TabIndex = 88;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Image = global::GUI.Properties.Resources.UserProfileQLVT;
            this.lblMaNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaNhanVien.Location = new System.Drawing.Point(65, 258);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(162, 27);
            this.lblMaNhanVien.TabIndex = 87;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            this.lblMaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValidatedCaLamViec
            // 
            this.lblValidatedCaLamViec.BackColor = System.Drawing.Color.White;
            this.lblValidatedCaLamViec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedCaLamViec.ForeColor = System.Drawing.Color.Red;
            this.lblValidatedCaLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidatedCaLamViec.Location = new System.Drawing.Point(275, 154);
            this.lblValidatedCaLamViec.Name = "lblValidatedCaLamViec";
            this.lblValidatedCaLamViec.Size = new System.Drawing.Size(305, 19);
            this.lblValidatedCaLamViec.TabIndex = 86;
            this.lblValidatedCaLamViec.Text = "*Không được để trống ca làm việc";
            this.lblValidatedCaLamViec.Visible = false;
            // 
            // lblValidatedNgayLamViec
            // 
            this.lblValidatedNgayLamViec.BackColor = System.Drawing.Color.White;
            this.lblValidatedNgayLamViec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedNgayLamViec.ForeColor = System.Drawing.Color.Red;
            this.lblValidatedNgayLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidatedNgayLamViec.Location = new System.Drawing.Point(273, 83);
            this.lblValidatedNgayLamViec.Name = "lblValidatedNgayLamViec";
            this.lblValidatedNgayLamViec.Size = new System.Drawing.Size(473, 19);
            this.lblValidatedNgayLamViec.TabIndex = 85;
            this.lblValidatedNgayLamViec.Text = "*Lịch làm việc phải lớn hơn hôm nay";
            this.lblValidatedNgayLamViec.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Enabled = false;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(431, 303);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 36);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboThemCaLamViec
            // 
            this.cboThemCaLamViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboThemCaLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThemCaLamViec.Enabled = false;
            this.cboThemCaLamViec.FormattingEnabled = true;
            this.cboThemCaLamViec.Location = new System.Drawing.Point(277, 118);
            this.cboThemCaLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.cboThemCaLamViec.Name = "cboThemCaLamViec";
            this.cboThemCaLamViec.Size = new System.Drawing.Size(469, 27);
            this.cboThemCaLamViec.TabIndex = 6;
            this.cboThemCaLamViec.SelectedIndexChanged += new System.EventHandler(this.cboThemCaLamViec_SelectedIndexChanged);
            // 
            // dtpThemNgayLamViec
            // 
            this.dtpThemNgayLamViec.Location = new System.Drawing.Point(277, 49);
            this.dtpThemNgayLamViec.Name = "dtpThemNgayLamViec";
            this.dtpThemNgayLamViec.Size = new System.Drawing.Size(469, 28);
            this.dtpThemNgayLamViec.TabIndex = 37;
            this.dtpThemNgayLamViec.ValueChanged += new System.EventHandler(this.dtpThemNgayLamViec_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::GUI.Properties.Resources.Time;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(65, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ca Làm Việc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(279, 195);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(469, 28);
            this.txtTenNhanVien.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::GUI.Properties.Resources.Time;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ngày Làm Việc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.UserProfileQLVT;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(65, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên Nhân Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorChonXoa);
            this.groupBox1.Controls.Add(this.lblNhapTen);
            this.groupBox1.Controls.Add(this.lblErrorXoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtTimKiemNhanVien);
            this.groupBox1.Controls.Add(this.dtpTimKiemLich);
            this.groupBox1.Controls.Add(this.cboTimKiemCaLamViec);
            this.groupBox1.Controls.Add(this.dgvLichLamViec);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1264, 355);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH LỊCH LÀM VIỆC";
            // 
            // lblErrorChonXoa
            // 
            this.lblErrorChonXoa.BackColor = System.Drawing.Color.White;
            this.lblErrorChonXoa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorChonXoa.ForeColor = System.Drawing.Color.Red;
            this.lblErrorChonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorChonXoa.Location = new System.Drawing.Point(31, 306);
            this.lblErrorChonXoa.Name = "lblErrorChonXoa";
            this.lblErrorChonXoa.Size = new System.Drawing.Size(237, 19);
            this.lblErrorChonXoa.TabIndex = 84;
            this.lblErrorChonXoa.Text = "*Chỉ chọn 1 dòng duy nhất!";
            this.lblErrorChonXoa.Visible = false;
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.BackColor = System.Drawing.Color.White;
            this.lblNhapTen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNhapTen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNhapTen.Location = new System.Drawing.Point(872, 33);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(175, 19);
            this.lblNhapTen.TabIndex = 83;
            this.lblNhapTen.Text = "*Nhập tên nhân viên";
            // 
            // lblErrorXoa
            // 
            this.lblErrorXoa.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorXoa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblErrorXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorXoa.Location = new System.Drawing.Point(31, 309);
            this.lblErrorXoa.Name = "lblErrorXoa";
            this.lblErrorXoa.Size = new System.Drawing.Size(214, 19);
            this.lblErrorXoa.TabIndex = 82;
            this.lblErrorXoa.Text = "*Mời chọn dòng để xóa";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::GUI.Properties.Resources.Time;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(461, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 27);
            this.label5.TabIndex = 81;
            this.label5.Text = "Ca Làm Việc";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.Time;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 27);
            this.label4.TabIndex = 80;
            this.label4.Text = "Ngày Làm Việc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1204, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(43, 36);
            this.btnTimKiem.TabIndex = 79;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(1124, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 36);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(865, 30);
            this.txtTimKiemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(319, 28);
            this.txtTimKiemNhanVien.TabIndex = 78;
            this.txtTimKiemNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiemNhanVien_MouseClick);
            // 
            // dtpTimKiemLich
            // 
            this.dtpTimKiemLich.Location = new System.Drawing.Point(191, 30);
            this.dtpTimKiemLich.Name = "dtpTimKiemLich";
            this.dtpTimKiemLich.Size = new System.Drawing.Size(250, 28);
            this.dtpTimKiemLich.TabIndex = 75;
            this.dtpTimKiemLich.ValueChanged += new System.EventHandler(this.dtpTimKiemLich_ValueChanged);
            // 
            // cboTimKiemCaLamViec
            // 
            this.cboTimKiemCaLamViec.BackColor = System.Drawing.Color.White;
            this.cboTimKiemCaLamViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTimKiemCaLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemCaLamViec.FormattingEnabled = true;
            this.cboTimKiemCaLamViec.Location = new System.Drawing.Point(614, 30);
            this.cboTimKiemCaLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.cboTimKiemCaLamViec.Name = "cboTimKiemCaLamViec";
            this.cboTimKiemCaLamViec.Size = new System.Drawing.Size(228, 27);
            this.cboTimKiemCaLamViec.TabIndex = 76;
            this.cboTimKiemCaLamViec.SelectedIndexChanged += new System.EventHandler(this.cboTimKiemCaLamViec_SelectedIndexChanged);
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Location = new System.Drawing.Point(22, 69);
            this.dgvLichLamViec.Margin = new System.Windows.Forms.Padding(5);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLamViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLichLamViec.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichLamViec.Size = new System.Drawing.Size(1225, 232);
            this.dgvLichLamViec.TabIndex = 75;
            this.dgvLichLamViec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLichLamViec_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblValidatedNhanVien);
            this.groupBox3.Controls.Add(this.lblThongBao);
            this.groupBox3.Controls.Add(this.dgvNhanVien);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 367);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(484, 356);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // lblValidatedNhanVien
            // 
            this.lblValidatedNhanVien.BackColor = System.Drawing.Color.White;
            this.lblValidatedNhanVien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblValidatedNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidatedNhanVien.Location = new System.Drawing.Point(111, 330);
            this.lblValidatedNhanVien.Name = "lblValidatedNhanVien";
            this.lblValidatedNhanVien.Size = new System.Drawing.Size(237, 19);
            this.lblValidatedNhanVien.TabIndex = 85;
            this.lblValidatedNhanVien.Text = "*Chỉ chọn 1 dòng duy nhất!";
            this.lblValidatedNhanVien.Visible = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.BackColor = System.Drawing.Color.White;
            this.lblThongBao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThongBao.Location = new System.Drawing.Point(79, 329);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(308, 19);
            this.lblThongBao.TabIndex = 85;
            this.lblThongBao.Text = "*Click Chọn nhân viên để thêm lịch";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(16, 29);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(449, 294);
            this.dgvNhanVien.TabIndex = 32;
            this.dgvNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNhanVien_MouseClick);
            // 
            // UC_CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_CaLam";
            this.Size = new System.Drawing.Size(1352, 766);
            this.Leave += new System.EventHandler(this.UC_CaLam_Leave);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboThemCaLamViec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThemNgayLamViec;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.DateTimePicker dtpTimKiemLich;
        private System.Windows.Forms.ComboBox cboTimKiemCaLamViec;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorXoa;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.Label lblErrorChonXoa;
        private System.Windows.Forms.Label lblValidatedNgayLamViec;
        private System.Windows.Forms.Label lblValidatedCaLamViec;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblValidatedNhanVien;
    }
}
