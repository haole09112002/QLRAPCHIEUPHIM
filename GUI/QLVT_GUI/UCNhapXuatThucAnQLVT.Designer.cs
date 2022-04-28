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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBXuat = new System.Windows.Forms.RadioButton();
            this.rBNhap = new System.Windows.Forms.RadioButton();
            this.rBTatCa = new System.Windows.Forms.RadioButton();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.dGVLSNX = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLSNX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cBSapXep);
            this.panel1.Controls.Add(this.dGVLSNX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 580);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::GUI.Properties.Resources.Sort;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(27, 127);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 38);
            this.button6.TabIndex = 32;
            this.button6.Text = "    SẮP XẾP";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GUI.Properties.Resources.SearchIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(806, 129);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 36);
            this.button3.TabIndex = 31;
            this.button3.Text = "TÌM KIẾM";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBXuat);
            this.groupBox1.Controls.Add(this.rBNhap);
            this.groupBox1.Controls.Add(this.rBTatCa);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(912, 60);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỌN XEM PHIẾU NHẬP XUẤT";
            // 
            // rBXuat
            // 
            this.rBXuat.AutoSize = true;
            this.rBXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBXuat.Location = new System.Drawing.Point(581, 26);
            this.rBXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBXuat.Name = "rBXuat";
            this.rBXuat.Size = new System.Drawing.Size(321, 23);
            this.rBXuat.TabIndex = 2;
            this.rBXuat.TabStop = true;
            this.rBXuat.Text = "Xem Danh Sách Phiếu Xuất Thức Ăn";
            this.rBXuat.UseVisualStyleBackColor = true;
            // 
            // rBNhap
            // 
            this.rBNhap.AutoSize = true;
            this.rBNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBNhap.Location = new System.Drawing.Point(169, 25);
            this.rBNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBNhap.Name = "rBNhap";
            this.rBNhap.Size = new System.Drawing.Size(329, 23);
            this.rBNhap.TabIndex = 1;
            this.rBNhap.TabStop = true;
            this.rBNhap.Text = "Xem Danh Sách Phiếu Nhập Thức Ăn";
            this.rBNhap.UseVisualStyleBackColor = true;
            // 
            // rBTatCa
            // 
            this.rBTatCa.AutoSize = true;
            this.rBTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBTatCa.Location = new System.Drawing.Point(5, 26);
            this.rBTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBTatCa.Name = "rBTatCa";
            this.rBTatCa.Size = new System.Drawing.Size(77, 23);
            this.rBTatCa.TabIndex = 0;
            this.rBTatCa.TabStop = true;
            this.rBTatCa.Text = "Tất Cả";
            this.rBTatCa.UseVisualStyleBackColor = true;
            // 
            // cBSapXep
            // 
            this.cBSapXep.BackColor = System.Drawing.Color.White;
            this.cBSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Location = new System.Drawing.Point(166, 133);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(173, 27);
            this.cBSapXep.TabIndex = 29;
            // 
            // dGVLSNX
            // 
            this.dGVLSNX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLSNX.Location = new System.Drawing.Point(17, 190);
            this.dGVLSNX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVLSNX.Name = "dGVLSNX";
            this.dGVLSNX.RowHeadersWidth = 62;
            this.dGVLSNX.RowTemplate.Height = 28;
            this.dGVLSNX.Size = new System.Drawing.Size(912, 374);
            this.dGVLSNX.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(286, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP XUẤT THỨC ĂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.button4.Location = new System.Drawing.Point(391, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 36);
            this.button4.TabIndex = 49;
            this.button4.Text = " Tạo Phiếu";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // UCNhapXuatThucAnQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCNhapXuatThucAnQLVT";
            this.Size = new System.Drawing.Size(993, 613);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLSNX)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBXuat;
        private System.Windows.Forms.RadioButton rBNhap;
        private System.Windows.Forms.RadioButton rBTatCa;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.DataGridView dGVLSNX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}
