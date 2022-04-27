namespace GUI.AD_GUI
{
    partial class UC_PhieuNhapXuat
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dGVLSNX = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBXuat = new System.Windows.Forms.RadioButton();
            this.rBNhap = new System.Windows.Forms.RadioButton();
            this.rBTatCa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLSNX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(675, 551);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 28);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(554, 549);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 37);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dGVLSNX
            // 
            this.dGVLSNX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLSNX.Location = new System.Drawing.Point(40, 147);
            this.dGVLSNX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVLSNX.Name = "dGVLSNX";
            this.dGVLSNX.RowHeadersWidth = 62;
            this.dGVLSNX.RowTemplate.Height = 28;
            this.dGVLSNX.Size = new System.Drawing.Size(912, 374);
            this.dGVLSNX.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(351, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP XUẤT";
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.White;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Black;
            this.btnSapXep.Location = new System.Drawing.Point(40, 545);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(104, 41);
            this.btnSapXep.TabIndex = 16;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // cBSapXep
            // 
            this.cBSapXep.BackColor = System.Drawing.Color.White;
            this.cBSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Location = new System.Drawing.Point(209, 551);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(280, 27);
            this.cBSapXep.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBXuat);
            this.groupBox1.Controls.Add(this.rBNhap);
            this.groupBox1.Controls.Add(this.rBTatCa);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(40, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(912, 60);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Xem Phiếu Nhập Xuất";
            // 
            // rBXuat
            // 
            this.rBXuat.AutoSize = true;
            this.rBXuat.Location = new System.Drawing.Point(576, 26);
            this.rBXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBXuat.Name = "rBXuat";
            this.rBXuat.Size = new System.Drawing.Size(296, 23);
            this.rBXuat.TabIndex = 2;
            this.rBXuat.TabStop = true;
            this.rBXuat.Text = "Xem Danh Sách Phiếu Xuất Phim";
            this.rBXuat.UseVisualStyleBackColor = true;
            // 
            // rBNhap
            // 
            this.rBNhap.AutoSize = true;
            this.rBNhap.Location = new System.Drawing.Point(213, 26);
            this.rBNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBNhap.Name = "rBNhap";
            this.rBNhap.Size = new System.Drawing.Size(304, 23);
            this.rBNhap.TabIndex = 1;
            this.rBNhap.TabStop = true;
            this.rBNhap.Text = "Xem Danh Sách Phiếu Nhập Phim";
            this.rBNhap.UseVisualStyleBackColor = true;
            // 
            // rBTatCa
            // 
            this.rBTatCa.AutoSize = true;
            this.rBTatCa.Location = new System.Drawing.Point(5, 26);
            this.rBTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBTatCa.Name = "rBTatCa";
            this.rBTatCa.Size = new System.Drawing.Size(77, 23);
            this.rBTatCa.TabIndex = 0;
            this.rBTatCa.TabStop = true;
            this.rBTatCa.Text = "Tất Cả";
            this.rBTatCa.UseVisualStyleBackColor = true;
            // 
            // UC_PhieuNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dGVLSNX);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_PhieuNhapXuat";
            this.Size = new System.Drawing.Size(993, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLSNX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dGVLSNX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBXuat;
        private System.Windows.Forms.RadioButton rBNhap;
        private System.Windows.Forms.RadioButton rBTatCa;
    }
}
