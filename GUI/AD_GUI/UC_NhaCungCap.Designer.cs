namespace GUI.AD_GUI
{
    partial class UC_NhaCungCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSanPham = new System.Windows.Forms.Button();
            this.txtTimKiemSanPham = new System.Windows.Forms.TextBox();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLoaiNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 744);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTimKiemSanPham);
            this.groupBox2.Controls.Add(this.txtTimKiemSanPham);
            this.groupBox2.Controls.Add(this.dgvDSSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 428);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1290, 312);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các sản phẩm cung cấp";
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSanPham.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(1157, 16);
            this.btnTimKiemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemSanPham.TabIndex = 26;
            this.btnTimKiemSanPham.Text = "TÌM KIẾM";
            this.btnTimKiemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            this.btnTimKiemSanPham.Click += new System.EventHandler(this.btnTimKiemSanPham_Click);
            // 
            // txtTimKiemSanPham
            // 
            this.txtTimKiemSanPham.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSanPham.Location = new System.Drawing.Point(946, 21);
            this.txtTimKiemSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            this.txtTimKiemSanPham.Size = new System.Drawing.Size(204, 28);
            this.txtTimKiemSanPham.TabIndex = 25;
            this.txtTimKiemSanPham.Text = "Nhập tên";
            this.txtTimKiemSanPham.Click += new System.EventHandler(this.txtTimKiemSanPham_Click);
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanPham.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Location = new System.Drawing.Point(6, 57);
            this.dgvDSSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.ReadOnly = true;
            this.dgvDSSanPham.RowHeadersWidth = 51;
            this.dgvDSSanPham.RowTemplate.Height = 24;
            this.dgvDSSanPham.Size = new System.Drawing.Size(1276, 251);
            this.dgvDSSanPham.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.dgvDSNhaCungCap);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1291, 384);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "*Kích đúp 1 dòng để xem chi tiết";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::GUI.Properties.Resources.Download;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1136, 342);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 40);
            this.btnExcel.TabIndex = 26;
            this.btnExcel.Text = "XUẤT EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbTieuChiTimKiem);
            this.panel2.Controls.Add(this.cbLoaiNhaCungCap);
            this.panel2.Controls.Add(this.btnSapXep);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbSapXep);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(11, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 40);
            this.panel2.TabIndex = 32;
            // 
            // cbLoaiNhaCungCap
            // 
            this.cbLoaiNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiNhaCungCap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNhaCungCap.FormattingEnabled = true;
            this.cbLoaiNhaCungCap.Location = new System.Drawing.Point(210, 6);
            this.cbLoaiNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiNhaCungCap.Name = "cbLoaiNhaCungCap";
            this.cbLoaiNhaCungCap.Size = new System.Drawing.Size(188, 27);
            this.cbLoaiNhaCungCap.TabIndex = 4;
            this.cbLoaiNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbLoaiNhaCungCap_SelectedIndexChanged);
            this.cbLoaiNhaCungCap.SelectedValueChanged += new System.EventHandler(this.cbLoaiNhaCungCap_SelectedValueChanged);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(405, 2);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 25;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::GUI.Properties.Resources.LoaiNhaCungCap;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Loại nhà cung cấp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSapXep
            // 
            this.cbSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Location = new System.Drawing.Point(535, 6);
            this.cbSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(185, 27);
            this.cbSapXep.TabIndex = 3;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1145, 2);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(786, 7);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(204, 28);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // dgvDSNhaCungCap
            // 
            this.dgvDSNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhaCungCap.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDSNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhaCungCap.Location = new System.Drawing.Point(11, 78);
            this.dgvDSNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSNhaCungCap.Name = "dgvDSNhaCungCap";
            this.dgvDSNhaCungCap.ReadOnly = true;
            this.dgvDSNhaCungCap.RowHeadersWidth = 51;
            this.dgvDSNhaCungCap.RowTemplate.Height = 24;
            this.dgvDSNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhaCungCap.Size = new System.Drawing.Size(1272, 258);
            this.dgvDSNhaCungCap.TabIndex = 0;
            this.dgvDSNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhaCungCap_CellClick);
            this.dgvDSNhaCungCap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhaCungCap_CellDoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(919, 343);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 36);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTieuChiTimKiem
            // 
            this.cbbTieuChiTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTieuChiTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTieuChiTimKiem.FormattingEnabled = true;
            this.cbbTieuChiTimKiem.Location = new System.Drawing.Point(996, 8);
            this.cbbTieuChiTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTieuChiTimKiem.Name = "cbbTieuChiTimKiem";
            this.cbbTieuChiTimKiem.Size = new System.Drawing.Size(144, 27);
            this.cbbTieuChiTimKiem.TabIndex = 27;
            // 
            // UC_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_NhaCungCap";
            this.Size = new System.Drawing.Size(1333, 766);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoaiNhaCungCap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemSanPham;
        private System.Windows.Forms.TextBox txtTimKiemSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTieuChiTimKiem;
    }
}
