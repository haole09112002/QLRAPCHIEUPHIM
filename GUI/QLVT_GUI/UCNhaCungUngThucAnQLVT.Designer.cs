namespace GUI.QLVT_GUI
{
    partial class UCNhaCungUngThucAnQLVT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnListNCCThucAn = new System.Windows.Forms.Panel();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTitleListNCCThucAn = new System.Windows.Forms.Label();
            this.dgvListNCCThucAn = new System.Windows.Forms.DataGridView();
            this.pnListNCCThucAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNCCThucAn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListNCCThucAn
            // 
            this.pnListNCCThucAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListNCCThucAn.Controls.Add(this.btnXemChiTiet);
            this.pnListNCCThucAn.Controls.Add(this.btnSapXep);
            this.pnListNCCThucAn.Controls.Add(this.cboSapXep);
            this.pnListNCCThucAn.Controls.Add(this.btnTimKiem);
            this.pnListNCCThucAn.Controls.Add(this.txtTimKiem);
            this.pnListNCCThucAn.Controls.Add(this.lblTitleListNCCThucAn);
            this.pnListNCCThucAn.Controls.Add(this.dgvListNCCThucAn);
            this.pnListNCCThucAn.Location = new System.Drawing.Point(16, 12);
            this.pnListNCCThucAn.Name = "pnListNCCThucAn";
            this.pnListNCCThucAn.Size = new System.Drawing.Size(1318, 741);
            this.pnListNCCThucAn.TabIndex = 3;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(581, 691);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(148, 36);
            this.btnXemChiTiet.TabIndex = 48;
            this.btnXemChiTiet.Text = "XEM CHI TIẾT";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(853, 45);
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
            this.cboSapXep.Location = new System.Drawing.Point(1000, 51);
            this.cboSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(265, 27);
            this.cboSapXep.TabIndex = 46;
            this.cboSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(52, 47);
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
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiem.Location = new System.Drawing.Point(191, 51);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 28);
            this.txtTimKiem.TabIndex = 44;
            this.txtTimKiem.Text = "Nhập từ khóa bất kì";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            // 
            // lblTitleListNCCThucAn
            // 
            this.lblTitleListNCCThucAn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleListNCCThucAn.Image = global::GUI.Properties.Resources.Nhacungcap;
            this.lblTitleListNCCThucAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleListNCCThucAn.Location = new System.Drawing.Point(401, 12);
            this.lblTitleListNCCThucAn.Name = "lblTitleListNCCThucAn";
            this.lblTitleListNCCThucAn.Size = new System.Drawing.Size(502, 25);
            this.lblTitleListNCCThucAn.TabIndex = 43;
            this.lblTitleListNCCThucAn.Text = "DANH SÁCH NHÀ CUNG CẤP THỨC ĂN NHANH";
            this.lblTitleListNCCThucAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListNCCThucAn
            // 
            this.dgvListNCCThucAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListNCCThucAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListNCCThucAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListNCCThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNCCThucAn.Location = new System.Drawing.Point(24, 100);
            this.dgvListNCCThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListNCCThucAn.Name = "dgvListNCCThucAn";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListNCCThucAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListNCCThucAn.RowHeadersWidth = 62;
            this.dgvListNCCThucAn.RowTemplate.Height = 28;
            this.dgvListNCCThucAn.Size = new System.Drawing.Size(1270, 580);
            this.dgvListNCCThucAn.TabIndex = 40;
            // 
            // UCNhaCungUngThucAnQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListNCCThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCNhaCungUngThucAnQLVT";
            this.Size = new System.Drawing.Size(1352, 766);
            this.pnListNCCThucAn.ResumeLayout(false);
            this.pnListNCCThucAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNCCThucAn)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel pnListNCCThucAn;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTitleListNCCThucAn;
        private System.Windows.Forms.DataGridView dgvListNCCThucAn;
    }
}
