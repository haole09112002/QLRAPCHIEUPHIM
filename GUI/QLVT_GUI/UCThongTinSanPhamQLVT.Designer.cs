namespace GUI.QLVT_GUI
{
    partial class UCThongTinSanPhamQLVT
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
            this.pnListThucAn = new System.Windows.Forms.Panel();
            this.dgvListVatTu = new System.Windows.Forms.DataGridView();
            this.cboSapXepVatTu = new System.Windows.Forms.ComboBox();
            this.btnSapXepVatTu = new System.Windows.Forms.Button();
            this.txtTimKiemVatTu = new System.Windows.Forms.TextBox();
            this.btnTimKiemVatTu = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTitleListThucAn = new System.Windows.Forms.Label();
            this.dgvListThucAn = new System.Windows.Forms.DataGridView();
            this.lblTitleListVatTu = new System.Windows.Forms.Label();
            this.pnListThucAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThucAn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListThucAn
            // 
            this.pnListThucAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListThucAn.Controls.Add(this.lblTitleListVatTu);
            this.pnListThucAn.Controls.Add(this.dgvListVatTu);
            this.pnListThucAn.Controls.Add(this.cboSapXepVatTu);
            this.pnListThucAn.Controls.Add(this.btnSapXepVatTu);
            this.pnListThucAn.Controls.Add(this.txtTimKiemVatTu);
            this.pnListThucAn.Controls.Add(this.btnTimKiemVatTu);
            this.pnListThucAn.Controls.Add(this.btnSapXep);
            this.pnListThucAn.Controls.Add(this.cboSapXep);
            this.pnListThucAn.Controls.Add(this.btnTimKiem);
            this.pnListThucAn.Controls.Add(this.txtTimKiem);
            this.pnListThucAn.Controls.Add(this.lblTitleListThucAn);
            this.pnListThucAn.Controls.Add(this.dgvListThucAn);
            this.pnListThucAn.Location = new System.Drawing.Point(16, 12);
            this.pnListThucAn.Name = "pnListThucAn";
            this.pnListThucAn.Size = new System.Drawing.Size(960, 588);
            this.pnListThucAn.TabIndex = 10;
            // 
            // dgvListVatTu
            // 
            this.dgvListVatTu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVatTu.Location = new System.Drawing.Point(24, 387);
            this.dgvListVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListVatTu.Name = "dgvListVatTu";
            this.dgvListVatTu.RowHeadersWidth = 62;
            this.dgvListVatTu.RowTemplate.Height = 28;
            this.dgvListVatTu.Size = new System.Drawing.Size(912, 158);
            this.dgvListVatTu.TabIndex = 53;
            // 
            // cboSapXepVatTu
            // 
            this.cboSapXepVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXepVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXepVatTu.FormattingEnabled = true;
            this.cboSapXepVatTu.Items.AddRange(new object[] {
            "MaVatTu",
            "TenVatTu",
            "DonViTinh",
            "SoLuong"});
            this.cboSapXepVatTu.Location = new System.Drawing.Point(671, 328);
            this.cboSapXepVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXepVatTu.Name = "cboSapXepVatTu";
            this.cboSapXepVatTu.Size = new System.Drawing.Size(265, 27);
            this.cboSapXepVatTu.TabIndex = 52;
            // 
            // btnSapXepVatTu
            // 
            this.btnSapXepVatTu.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXepVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXepVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXepVatTu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepVatTu.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXepVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXepVatTu.Location = new System.Drawing.Point(530, 322);
            this.btnSapXepVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXepVatTu.Name = "btnSapXepVatTu";
            this.btnSapXepVatTu.Size = new System.Drawing.Size(123, 38);
            this.btnSapXepVatTu.TabIndex = 51;
            this.btnSapXepVatTu.Text = "    SẮP XẾP";
            this.btnSapXepVatTu.UseVisualStyleBackColor = false;
            this.btnSapXepVatTu.Click += new System.EventHandler(this.btnSapXepVatTu_Click);
            // 
            // txtTimKiemVatTu
            // 
            this.txtTimKiemVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemVatTu.Location = new System.Drawing.Point(166, 328);
            this.txtTimKiemVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemVatTu.Name = "txtTimKiemVatTu";
            this.txtTimKiemVatTu.Size = new System.Drawing.Size(263, 28);
            this.txtTimKiemVatTu.TabIndex = 50;
            // 
            // btnTimKiemVatTu
            // 
            this.btnTimKiemVatTu.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemVatTu.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemVatTu.Location = new System.Drawing.Point(24, 322);
            this.btnTimKiemVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemVatTu.Name = "btnTimKiemVatTu";
            this.btnTimKiemVatTu.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemVatTu.TabIndex = 49;
            this.btnTimKiemVatTu.Text = "TÌM KIẾM";
            this.btnTimKiemVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemVatTu.UseVisualStyleBackColor = false;
            this.btnTimKiemVatTu.Click += new System.EventHandler(this.btnTimKiemVatTu_Click);
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
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // cboSapXep
            // 
            this.cboSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Items.AddRange(new object[] {
            "MaThucAn",
            "TenThucAn",
            "DonViTinh",
            "SoLuong"});
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            // lblTitleListThucAn
            // 
            this.lblTitleListThucAn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleListThucAn.Image = global::GUI.Properties.Resources.FoodTitleDeXuat;
            this.lblTitleListThucAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleListThucAn.Location = new System.Drawing.Point(323, 9);
            this.lblTitleListThucAn.Name = "lblTitleListThucAn";
            this.lblTitleListThucAn.Size = new System.Drawing.Size(338, 25);
            this.lblTitleListThucAn.TabIndex = 43;
            this.lblTitleListThucAn.Text = "DANH SÁCH THỨC ĂN NHANH";
            this.lblTitleListThucAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListThucAn
            // 
            this.dgvListThucAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvListThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListThucAn.Location = new System.Drawing.Point(24, 100);
            this.dgvListThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListThucAn.Name = "dgvListThucAn";
            this.dgvListThucAn.RowHeadersWidth = 62;
            this.dgvListThucAn.RowTemplate.Height = 28;
            this.dgvListThucAn.Size = new System.Drawing.Size(912, 158);
            this.dgvListThucAn.TabIndex = 40;
            // 
            // lblTitleListVatTu
            // 
            this.lblTitleListVatTu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleListVatTu.Image = global::GUI.Properties.Resources.ToolDeXuat;
            this.lblTitleListVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleListVatTu.Location = new System.Drawing.Point(359, 281);
            this.lblTitleListVatTu.Name = "lblTitleListVatTu";
            this.lblTitleListVatTu.Size = new System.Drawing.Size(240, 25);
            this.lblTitleListVatTu.TabIndex = 54;
            this.lblTitleListVatTu.Text = "DANH SÁCH VẬT TƯ";
            this.lblTitleListVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCThongTinThucAnQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCThongTinThucAnQLVT";
            this.Size = new System.Drawing.Size(993, 613);
            this.pnListThucAn.ResumeLayout(false);
            this.pnListThucAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThucAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListThucAn;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTitleListThucAn;
        private System.Windows.Forms.DataGridView dgvListThucAn;
        private System.Windows.Forms.Button btnTimKiemVatTu;
        private System.Windows.Forms.TextBox txtTimKiemVatTu;
        private System.Windows.Forms.Button btnSapXepVatTu;
        private System.Windows.Forms.ComboBox cboSapXepVatTu;
        private System.Windows.Forms.DataGridView dgvListVatTu;
        private System.Windows.Forms.Label lblTitleListVatTu;
    }
}
