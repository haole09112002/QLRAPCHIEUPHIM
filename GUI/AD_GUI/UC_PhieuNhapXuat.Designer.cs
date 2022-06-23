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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSPhieu = new System.Windows.Forms.DataGridView();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBXuat = new System.Windows.Forms.RadioButton();
            this.rBNhap = new System.Windows.Forms.RadioButton();
            this.rBTatCa = new System.Windows.Forms.RadioButton();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cbbTimKiem);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cBSapXep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 736);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvChiTiet);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(654, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(631, 506);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(7, 40);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 62;
            this.dgvChiTiet.RowTemplate.Height = 28;
            this.dgvChiTiet.Size = new System.Drawing.Size(617, 458);
            this.dgvChiTiet.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSPhieu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(634, 506);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 710);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "*Kích đúp 1 dòng để xem chi tiết";
            // 
            // dgvDSPhieu
            // 
            this.dgvDSPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieu.Location = new System.Drawing.Point(7, 40);
            this.dgvDSPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSPhieu.Name = "dgvDSPhieu";
            this.dgvDSPhieu.RowHeadersWidth = 62;
            this.dgvDSPhieu.RowTemplate.Height = 28;
            this.dgvDSPhieu.Size = new System.Drawing.Size(612, 449);
            this.dgvDSPhieu.TabIndex = 27;
            this.dgvDSPhieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhieuNhapXuat_CellDoubleClick);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Lập Phiếu"});
            this.cbbTimKiem.Location = new System.Drawing.Point(750, 147);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(160, 25);
            this.cbbTimKiem.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::GUI.Properties.Resources.Sort;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(27, 140);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.button3.Location = new System.Drawing.Point(385, 142);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 36);
            this.button3.TabIndex = 31;
            this.button3.Text = "TÌM KIẾM";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(527, 146);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 28);
            this.txtTimKiem.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBXuat);
            this.groupBox1.Controls.Add(this.rBNhap);
            this.groupBox1.Controls.Add(this.rBTatCa);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1251, 60);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỌN XEM PHIẾU NHẬP XUẤT";
            // 
            // rBXuat
            // 
            this.rBXuat.AutoSize = true;
            this.rBXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBXuat.Location = new System.Drawing.Point(955, 26);
            this.rBXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBXuat.Name = "rBXuat";
            this.rBXuat.Size = new System.Drawing.Size(251, 23);
            this.rBXuat.TabIndex = 2;
            this.rBXuat.TabStop = true;
            this.rBXuat.Text = "Xem Danh Sách Phiếu Xuất";
            this.rBXuat.UseVisualStyleBackColor = true;
            this.rBXuat.CheckedChanged += new System.EventHandler(this.rBXuat_CheckedChanged);
            // 
            // rBNhap
            // 
            this.rBNhap.AutoSize = true;
            this.rBNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBNhap.Location = new System.Drawing.Point(500, 25);
            this.rBNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBNhap.Name = "rBNhap";
            this.rBNhap.Size = new System.Drawing.Size(259, 23);
            this.rBNhap.TabIndex = 1;
            this.rBNhap.TabStop = true;
            this.rBNhap.Text = "Xem Danh Sách Phiếu Nhập";
            this.rBNhap.UseVisualStyleBackColor = true;
            this.rBNhap.CheckedChanged += new System.EventHandler(this.rBNhap_CheckedChanged);
            // 
            // rBTatCa
            // 
            this.rBTatCa.AutoSize = true;
            this.rBTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBTatCa.Location = new System.Drawing.Point(79, 26);
            this.rBTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBTatCa.Name = "rBTatCa";
            this.rBTatCa.Size = new System.Drawing.Size(77, 23);
            this.rBTatCa.TabIndex = 0;
            this.rBTatCa.TabStop = true;
            this.rBTatCa.Text = "Tất Cả";
            this.rBTatCa.UseVisualStyleBackColor = true;
            this.rBTatCa.CheckedChanged += new System.EventHandler(this.rBTatCa_CheckedChanged);
            // 
            // cBSapXep
            // 
            this.cBSapXep.BackColor = System.Drawing.Color.White;
            this.cBSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Lập Phiếu"});
            this.cBSapXep.Location = new System.Drawing.Point(157, 147);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(195, 27);
            this.cBSapXep.TabIndex = 29;
            this.cBSapXep.SelectedIndexChanged += new System.EventHandler(this.btnSapXep_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(498, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_PhieuNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_PhieuNhapXuat";
            this.Size = new System.Drawing.Size(1333, 766);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBXuat;
        private System.Windows.Forms.RadioButton rBNhap;
        private System.Windows.Forms.RadioButton rBTatCa;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}
