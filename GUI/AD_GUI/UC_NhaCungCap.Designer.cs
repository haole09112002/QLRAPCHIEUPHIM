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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLoaiNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.dgvDSNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 744);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnExcel);
            this.groupBox4.Controls.Add(this.btnSapXep);
            this.groupBox4.Controls.Add(this.btnTimKiem);
            this.groupBox4.Controls.Add(this.cbSapXep);
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1290, 74);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::GUI.Properties.Resources.Download;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1134, 19);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 40);
            this.btnExcel.TabIndex = 26;
            this.btnExcel.Text = "XUẤT EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(13, 21);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 25;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(425, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbSapXep
            // 
            this.cbSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Location = new System.Drawing.Point(160, 28);
            this.cbSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(215, 27);
            this.cbSapXep.TabIndex = 3;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(572, 28);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(227, 28);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDSSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(658, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(636, 630);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các sản phẩm cung cấp";
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanPham.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Location = new System.Drawing.Point(6, 25);
            this.dgvDSSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.RowHeadersWidth = 51;
            this.dgvDSSanPham.RowTemplate.Height = 24;
            this.dgvDSSanPham.Size = new System.Drawing.Size(622, 601);
            this.dgvDSSanPham.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnXemChiTiet);
            this.groupBox1.Controls.Add(this.dgvDSNhaCungCap);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(632, 656);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLoaiNhaCungCap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(11, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 40);
            this.panel2.TabIndex = 32;
            // 
            // cbLoaiNhaCungCap
            // 
            this.cbLoaiNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiNhaCungCap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNhaCungCap.FormattingEnabled = true;
            this.cbLoaiNhaCungCap.Location = new System.Drawing.Point(230, 7);
            this.cbLoaiNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiNhaCungCap.Name = "cbLoaiNhaCungCap";
            this.cbLoaiNhaCungCap.Size = new System.Drawing.Size(293, 27);
            this.cbLoaiNhaCungCap.TabIndex = 4;
            this.cbLoaiNhaCungCap.SelectedValueChanged += new System.EventHandler(this.cbLoaiNhaCungCap_SelectedValueChanged);
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
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Image = global::GUI.Properties.Resources.Edit;
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(368, 593);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(139, 39);
            this.btnXemChiTiet.TabIndex = 31;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // dgvDSNhaCungCap
            // 
            this.dgvDSNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhaCungCap.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDSNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhaCungCap.Location = new System.Drawing.Point(11, 78);
            this.dgvDSNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSNhaCungCap.Name = "dgvDSNhaCungCap";
            this.dgvDSNhaCungCap.RowHeadersWidth = 51;
            this.dgvDSNhaCungCap.RowTemplate.Height = 24;
            this.dgvDSNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhaCungCap.Size = new System.Drawing.Size(615, 495);
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
            this.btnThem.Location = new System.Drawing.Point(83, 596);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 36);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
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
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Panel panel2;
    }
}
