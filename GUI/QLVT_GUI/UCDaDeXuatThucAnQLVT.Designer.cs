namespace GUI.QLVT_GUI
{
    partial class UCDaDeXuatThucAnQLVT
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
            this.pnListDXDoAn = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTitleListDXDoAn = new System.Windows.Forms.Label();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvListDXDoAn = new System.Windows.Forms.DataGridView();
            this.pnListDXDoAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDXDoAn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListDXDoAn
            // 
            this.pnListDXDoAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListDXDoAn.Controls.Add(this.btnThem);
            this.pnListDXDoAn.Controls.Add(this.btnSapXep);
            this.pnListDXDoAn.Controls.Add(this.cboSapXep);
            this.pnListDXDoAn.Controls.Add(this.btnTimKiem);
            this.pnListDXDoAn.Controls.Add(this.txtTimKiem);
            this.pnListDXDoAn.Controls.Add(this.lblTitleListDXDoAn);
            this.pnListDXDoAn.Controls.Add(this.btnChinhSua);
            this.pnListDXDoAn.Controls.Add(this.btnXoa);
            this.pnListDXDoAn.Controls.Add(this.dgvListDXDoAn);
            this.pnListDXDoAn.Location = new System.Drawing.Point(16, 12);
            this.pnListDXDoAn.Name = "pnListDXDoAn";
            this.pnListDXDoAn.Size = new System.Drawing.Size(960, 588);
            this.pnListDXDoAn.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(687, 536);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 36);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(530, 45);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 47;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // cboSapXep
            // 
            this.cboSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Location = new System.Drawing.Point(671, 51);
            this.cboSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(265, 27);
            this.cboSapXep.TabIndex = 46;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 47);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(166, 50);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 28);
            this.txtTimKiem.TabIndex = 44;
            // 
            // lblTitleListDXDoAn
            // 
            this.lblTitleListDXDoAn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleListDXDoAn.Image = global::GUI.Properties.Resources.FoodTitleDeXuat;
            this.lblTitleListDXDoAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleListDXDoAn.Location = new System.Drawing.Point(270, 9);
            this.lblTitleListDXDoAn.Name = "lblTitleListDXDoAn";
            this.lblTitleListDXDoAn.Size = new System.Drawing.Size(396, 25);
            this.lblTitleListDXDoAn.TabIndex = 43;
            this.lblTitleListDXDoAn.Text = "DANH SÁCH ĐỒ ĂN NHANH ĐỀ XUẤT";
            this.lblTitleListDXDoAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.Edit;
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(397, 536);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(138, 36);
            this.btnChinhSua.TabIndex = 42;
            this.btnChinhSua.Text = "CHỈNH SỬA";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.trash_can_26px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(118, 536);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 36);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dgvListDXDoAn
            // 
            this.dgvListDXDoAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDXDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDXDoAn.Location = new System.Drawing.Point(24, 100);
            this.dgvListDXDoAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListDXDoAn.Name = "dgvListDXDoAn";
            this.dgvListDXDoAn.RowHeadersWidth = 62;
            this.dgvListDXDoAn.RowTemplate.Height = 28;
            this.dgvListDXDoAn.Size = new System.Drawing.Size(912, 428);
            this.dgvListDXDoAn.TabIndex = 40;
            // 
            // UCDaDeXuatThucAnQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListDXDoAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCDaDeXuatThucAnQLVT";
            this.Size = new System.Drawing.Size(993, 613);
            this.pnListDXDoAn.ResumeLayout(false);
            this.pnListDXDoAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDXDoAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListDXDoAn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTitleListDXDoAn;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvListDXDoAn;
    }
}
