namespace GUI.QLVT_GUI
{
    partial class UCNhapXuatThucAnQLVT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnListNhapXuatThucAn = new System.Windows.Forms.Panel();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.rbXuatThucAn = new System.Windows.Forms.RadioButton();
            this.rbNhapThucAn = new System.Windows.Forms.RadioButton();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.dgvListNhapXuatThucAn = new System.Windows.Forms.DataGridView();
            this.lblListNhapXuatThucAn = new System.Windows.Forms.Label();
            this.dgvListPhieuNhapXuatThucAn = new System.Windows.Forms.DataGridView();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.lblChonLoaiTimKiem = new System.Windows.Forms.Label();
            this.pnListNhapXuatThucAn.SuspendLayout();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhapXuatThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhieuNhapXuatThucAn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListNhapXuatThucAn
            // 
            this.pnListNhapXuatThucAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListNhapXuatThucAn.Controls.Add(this.lblChonLoaiTimKiem);
            this.pnListNhapXuatThucAn.Controls.Add(this.cboTimKiem);
            this.pnListNhapXuatThucAn.Controls.Add(this.dgvListPhieuNhapXuatThucAn);
            this.pnListNhapXuatThucAn.Controls.Add(this.btnTaoPhieu);
            this.pnListNhapXuatThucAn.Controls.Add(this.btnSapXep);
            this.pnListNhapXuatThucAn.Controls.Add(this.btnTimKiem);
            this.pnListNhapXuatThucAn.Controls.Add(this.txtTimKiem);
            this.pnListNhapXuatThucAn.Controls.Add(this.grpSelect);
            this.pnListNhapXuatThucAn.Controls.Add(this.cboSapXep);
            this.pnListNhapXuatThucAn.Controls.Add(this.dgvListNhapXuatThucAn);
            this.pnListNhapXuatThucAn.Controls.Add(this.lblListNhapXuatThucAn);
            this.pnListNhapXuatThucAn.Location = new System.Drawing.Point(16, 15);
            this.pnListNhapXuatThucAn.Name = "pnListNhapXuatThucAn";
            this.pnListNhapXuatThucAn.Size = new System.Drawing.Size(1319, 734);
            this.pnListNhapXuatThucAn.TabIndex = 2;
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.Silver;
            this.btnTaoPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieu.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnTaoPhieu.Location = new System.Drawing.Point(665, 132);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(154, 36);
            this.btnTaoPhieu.TabIndex = 49;
            this.btnTaoPhieu.Text = " Tạo Phiếu";
            this.btnTaoPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.Enabled = false;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(1173, 135);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 32;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(20, 135);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(150, 140);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(196, 28);
            this.txtTimKiem.TabIndex = 28;
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.rbXuatThucAn);
            this.grpSelect.Controls.Add(this.rbNhapThucAn);
            this.grpSelect.Controls.Add(this.rbTatCa);
            this.grpSelect.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpSelect.Location = new System.Drawing.Point(20, 45);
            this.grpSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelect.Size = new System.Drawing.Size(1276, 72);
            this.grpSelect.TabIndex = 30;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "CHỌN XEM PHIẾU NHẬP XUẤT";
            // 
            // rbXuatThucAn
            // 
            this.rbXuatThucAn.AutoSize = true;
            this.rbXuatThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXuatThucAn.Location = new System.Drawing.Point(930, 35);
            this.rbXuatThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbXuatThucAn.Name = "rbXuatThucAn";
            this.rbXuatThucAn.Size = new System.Drawing.Size(321, 23);
            this.rbXuatThucAn.TabIndex = 2;
            this.rbXuatThucAn.Text = "Xem Danh Sách Phiếu Xuất Thức Ăn";
            this.rbXuatThucAn.UseVisualStyleBackColor = true;
            this.rbXuatThucAn.CheckedChanged += new System.EventHandler(this.rbXuatThucAn_CheckedChanged);
            // 
            // rbNhapThucAn
            // 
            this.rbNhapThucAn.AutoSize = true;
            this.rbNhapThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNhapThucAn.Location = new System.Drawing.Point(438, 35);
            this.rbNhapThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNhapThucAn.Name = "rbNhapThucAn";
            this.rbNhapThucAn.Size = new System.Drawing.Size(329, 23);
            this.rbNhapThucAn.TabIndex = 1;
            this.rbNhapThucAn.Text = "Xem Danh Sách Phiếu Nhập Thức Ăn";
            this.rbNhapThucAn.UseVisualStyleBackColor = true;
            this.rbNhapThucAn.CheckedChanged += new System.EventHandler(this.rbNhapThucAn_CheckedChanged);
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Checked = true;
            this.rbTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTatCa.Location = new System.Drawing.Point(81, 37);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(77, 23);
            this.rbTatCa.TabIndex = 0;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất Cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            this.rbTatCa.CheckedChanged += new System.EventHandler(this.rbTatCa_CheckedChanged);
            // 
            // cboSapXep
            // 
            this.cboSapXep.BackColor = System.Drawing.Color.White;
            this.cboSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Lập Phiếu"});
            this.cboSapXep.Location = new System.Drawing.Point(871, 139);
            this.cboSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(285, 27);
            this.cboSapXep.TabIndex = 29;
            this.cboSapXep.SelectedIndexChanged += new System.EventHandler(this.cboSapXep_SelectedIndexChanged);
            // 
            // dgvListNhapXuatThucAn
            // 
            this.dgvListNhapXuatThucAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListNhapXuatThucAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListNhapXuatThucAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvListNhapXuatThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNhapXuatThucAn.Location = new System.Drawing.Point(17, 190);
            this.dgvListNhapXuatThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListNhapXuatThucAn.Name = "dgvListNhapXuatThucAn";
            this.dgvListNhapXuatThucAn.RowHeadersWidth = 62;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListNhapXuatThucAn.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvListNhapXuatThucAn.RowTemplate.Height = 28;
            this.dgvListNhapXuatThucAn.Size = new System.Drawing.Size(632, 518);
            this.dgvListNhapXuatThucAn.TabIndex = 27;
            this.dgvListNhapXuatThucAn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListNhapXuatThucAn_CellDoubleClick);
            // 
            // lblListNhapXuatThucAn
            // 
            this.lblListNhapXuatThucAn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblListNhapXuatThucAn.Image = global::GUI.Properties.Resources.NhapXuat;
            this.lblListNhapXuatThucAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListNhapXuatThucAn.Location = new System.Drawing.Point(445, 8);
            this.lblListNhapXuatThucAn.Name = "lblListNhapXuatThucAn";
            this.lblListNhapXuatThucAn.Size = new System.Drawing.Size(430, 35);
            this.lblListNhapXuatThucAn.TabIndex = 26;
            this.lblListNhapXuatThucAn.Text = "DANH SÁCH PHIẾU NHẬP XUẤT THỨC ĂN";
            this.lblListNhapXuatThucAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListPhieuNhapXuatThucAn
            // 
            this.dgvListPhieuNhapXuatThucAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListPhieuNhapXuatThucAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPhieuNhapXuatThucAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvListPhieuNhapXuatThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPhieuNhapXuatThucAn.Location = new System.Drawing.Point(665, 190);
            this.dgvListPhieuNhapXuatThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListPhieuNhapXuatThucAn.Name = "dgvListPhieuNhapXuatThucAn";
            this.dgvListPhieuNhapXuatThucAn.RowHeadersWidth = 62;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListPhieuNhapXuatThucAn.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvListPhieuNhapXuatThucAn.RowTemplate.Height = 28;
            this.dgvListPhieuNhapXuatThucAn.Size = new System.Drawing.Size(631, 518);
            this.dgvListPhieuNhapXuatThucAn.TabIndex = 50;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.BackColor = System.Drawing.Color.White;
            this.cboTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Lập Phiếu"});
            this.cboTimKiem.Location = new System.Drawing.Point(363, 140);
            this.cboTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(198, 27);
            this.cboTimKiem.TabIndex = 51;
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // lblChonLoaiTimKiem
            // 
            this.lblChonLoaiTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.lblChonLoaiTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLoaiTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChonLoaiTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChonLoaiTimKiem.Location = new System.Drawing.Point(377, 119);
            this.lblChonLoaiTimKiem.Name = "lblChonLoaiTimKiem";
            this.lblChonLoaiTimKiem.Size = new System.Drawing.Size(175, 19);
            this.lblChonLoaiTimKiem.TabIndex = 85;
            this.lblChonLoaiTimKiem.Text = "*Chọn loại tìm kiếm";
            // 
            // UCNhapXuatThucAnQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListNhapXuatThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCNhapXuatThucAnQLVT";
            this.Size = new System.Drawing.Size(1352, 766);
            this.pnListNhapXuatThucAn.ResumeLayout(false);
            this.pnListNhapXuatThucAn.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhapXuatThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhieuNhapXuatThucAn)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel pnListNhapXuatThucAn;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.RadioButton rbXuatThucAn;
        private System.Windows.Forms.RadioButton rbNhapThucAn;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.DataGridView dgvListNhapXuatThucAn;
        private System.Windows.Forms.Label lblListNhapXuatThucAn;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.DataGridView dgvListPhieuNhapXuatThucAn;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label lblChonLoaiTimKiem;
    }
}
