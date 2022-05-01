namespace GUI.QLVT_GUI
{
    partial class UCNhapXuatVatTuQLVT
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
            this.pnListNhapXuatVatTu = new System.Windows.Forms.Panel();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.rbXuatVatTu = new System.Windows.Forms.RadioButton();
            this.rbNhapVatTu = new System.Windows.Forms.RadioButton();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.dgvListNhapXuatVatTu = new System.Windows.Forms.DataGridView();
            this.lblListNhapXuatVatTu = new System.Windows.Forms.Label();
            this.pnListNhapXuatVatTu.SuspendLayout();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhapXuatVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListNhapXuatVatTu
            // 
            this.pnListNhapXuatVatTu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListNhapXuatVatTu.Controls.Add(this.btnTaoPhieu);
            this.pnListNhapXuatVatTu.Controls.Add(this.btnSapXep);
            this.pnListNhapXuatVatTu.Controls.Add(this.btnTimKiem);
            this.pnListNhapXuatVatTu.Controls.Add(this.txtTimKiem);
            this.pnListNhapXuatVatTu.Controls.Add(this.grpSelect);
            this.pnListNhapXuatVatTu.Controls.Add(this.cboSapXep);
            this.pnListNhapXuatVatTu.Controls.Add(this.dgvListNhapXuatVatTu);
            this.pnListNhapXuatVatTu.Controls.Add(this.lblListNhapXuatVatTu);
            this.pnListNhapXuatVatTu.Location = new System.Drawing.Point(16, 16);
            this.pnListNhapXuatVatTu.Name = "pnListNhapXuatVatTu";
            this.pnListNhapXuatVatTu.Size = new System.Drawing.Size(961, 580);
            this.pnListNhapXuatVatTu.TabIndex = 3;
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.Silver;
            this.btnTaoPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieu.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnTaoPhieu.Location = new System.Drawing.Point(391, 129);
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
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(27, 127);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 32;
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
            this.btnTimKiem.Location = new System.Drawing.Point(806, 129);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(590, 133);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(194, 28);
            this.txtTimKiem.TabIndex = 28;
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.rbXuatVatTu);
            this.grpSelect.Controls.Add(this.rbNhapVatTu);
            this.grpSelect.Controls.Add(this.rbTatCa);
            this.grpSelect.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpSelect.Location = new System.Drawing.Point(27, 45);
            this.grpSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelect.Size = new System.Drawing.Size(912, 60);
            this.grpSelect.TabIndex = 30;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "CHỌN XEM PHIẾU NHẬP XUẤT";
            // 
            // rbXuatVatTu
            // 
            this.rbXuatVatTu.AutoSize = true;
            this.rbXuatVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXuatVatTu.Location = new System.Drawing.Point(581, 26);
            this.rbXuatVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbXuatVatTu.Name = "rbXuatVatTu";
            this.rbXuatVatTu.Size = new System.Drawing.Size(302, 23);
            this.rbXuatVatTu.TabIndex = 2;
            this.rbXuatVatTu.TabStop = true;
            this.rbXuatVatTu.Text = "Xem Danh Sách Phiếu Xuất Vật Tư";
            this.rbXuatVatTu.UseVisualStyleBackColor = true;
            // 
            // rbNhapVatTu
            // 
            this.rbNhapVatTu.AutoSize = true;
            this.rbNhapVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNhapVatTu.Location = new System.Drawing.Point(169, 25);
            this.rbNhapVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNhapVatTu.Name = "rbNhapVatTu";
            this.rbNhapVatTu.Size = new System.Drawing.Size(310, 23);
            this.rbNhapVatTu.TabIndex = 1;
            this.rbNhapVatTu.TabStop = true;
            this.rbNhapVatTu.Text = "Xem Danh Sách Phiếu Nhập Vật Tư";
            this.rbNhapVatTu.UseVisualStyleBackColor = true;
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTatCa.Location = new System.Drawing.Point(5, 26);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(77, 23);
            this.rbTatCa.TabIndex = 0;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất Cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            // 
            // cboSapXep
            // 
            this.cboSapXep.BackColor = System.Drawing.Color.White;
            this.cboSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Location = new System.Drawing.Point(166, 133);
            this.cboSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(173, 27);
            this.cboSapXep.TabIndex = 29;
            // 
            // dgvListNhapXuatVatTu
            // 
            this.dgvListNhapXuatVatTu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListNhapXuatVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNhapXuatVatTu.Location = new System.Drawing.Point(17, 190);
            this.dgvListNhapXuatVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListNhapXuatVatTu.Name = "dgvListNhapXuatVatTu";
            this.dgvListNhapXuatVatTu.RowHeadersWidth = 62;
            this.dgvListNhapXuatVatTu.RowTemplate.Height = 28;
            this.dgvListNhapXuatVatTu.Size = new System.Drawing.Size(912, 374);
            this.dgvListNhapXuatVatTu.TabIndex = 27;
            // 
            // lblListNhapXuatVatTu
            // 
            this.lblListNhapXuatVatTu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblListNhapXuatVatTu.Image = global::GUI.Properties.Resources.NhapXuat;
            this.lblListNhapXuatVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListNhapXuatVatTu.Location = new System.Drawing.Point(304, 8);
            this.lblListNhapXuatVatTu.Name = "lblListNhapXuatVatTu";
            this.lblListNhapXuatVatTu.Size = new System.Drawing.Size(408, 35);
            this.lblListNhapXuatVatTu.TabIndex = 26;
            this.lblListNhapXuatVatTu.Text = "DANH SÁCH PHIẾU NHẬP XUẤT VẬT TƯ";
            this.lblListNhapXuatVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCNhapXuatVatTuQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListNhapXuatVatTu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCNhapXuatVatTuQLVT";
            this.Size = new System.Drawing.Size(993, 613);
            this.pnListNhapXuatVatTu.ResumeLayout(false);
            this.pnListNhapXuatVatTu.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhapXuatVatTu)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel pnListNhapXuatVatTu;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.RadioButton rbXuatVatTu;
        private System.Windows.Forms.RadioButton rbNhapVatTu;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.DataGridView dgvListNhapXuatVatTu;
        private System.Windows.Forms.Label lblListNhapXuatVatTu;
    }
}
