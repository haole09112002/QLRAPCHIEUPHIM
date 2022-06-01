namespace GUI.QLP_GUI
{
    partial class UC_PhieuNhapXuat_QLP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBTimKiem = new System.Windows.Forms.ComboBox();
            this.dGVChiTietPhieuNhapXuat = new System.Windows.Forms.DataGridView();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBXuat = new System.Windows.Forms.RadioButton();
            this.rBNhap = new System.Windows.Forms.RadioButton();
            this.rBTatCa = new System.Windows.Forms.RadioButton();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.dGVDanhSachPhieuNhapXuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiTietPhieuNhapXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhieuNhapXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cBTimKiem);
            this.panel1.Controls.Add(this.dGVChiTietPhieuNhapXuat);
            this.panel1.Controls.Add(this.btnSapXep);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cBSapXep);
            this.panel1.Controls.Add(this.dGVDanhSachPhieuNhapXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 747);
            this.panel1.TabIndex = 1;
            // 
            // cBTimKiem
            // 
            this.cBTimKiem.BackColor = System.Drawing.Color.White;
            this.cBTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTimKiem.FormattingEnabled = true;
            this.cBTimKiem.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Lập Phiếu"});
            this.cBTimKiem.Location = new System.Drawing.Point(1154, 139);
            this.cBTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBTimKiem.Name = "cBTimKiem";
            this.cBTimKiem.Size = new System.Drawing.Size(147, 27);
            this.cBTimKiem.TabIndex = 34;
            // 
            // dGVChiTietPhieuNhapXuat
            // 
            this.dGVChiTietPhieuNhapXuat.AllowUserToAddRows = false;
            this.dGVChiTietPhieuNhapXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVChiTietPhieuNhapXuat.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVChiTietPhieuNhapXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVChiTietPhieuNhapXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVChiTietPhieuNhapXuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVChiTietPhieuNhapXuat.Location = new System.Drawing.Point(653, 186);
            this.dGVChiTietPhieuNhapXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVChiTietPhieuNhapXuat.Name = "dGVChiTietPhieuNhapXuat";
            this.dGVChiTietPhieuNhapXuat.ReadOnly = true;
            this.dGVChiTietPhieuNhapXuat.RowHeadersWidth = 62;
            this.dGVChiTietPhieuNhapXuat.RowTemplate.Height = 28;
            this.dGVChiTietPhieuNhapXuat.Size = new System.Drawing.Size(648, 545);
            this.dGVChiTietPhieuNhapXuat.TabIndex = 33;
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
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(780, 133);
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
            this.txtTimKiem.Location = new System.Drawing.Point(910, 139);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 28);
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
            this.groupBox1.Size = new System.Drawing.Size(1274, 60);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỌN XEM PHIẾU NHẬP XUẤT";
            // 
            // rBXuat
            // 
            this.rBXuat.AutoSize = true;
            this.rBXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBXuat.Location = new System.Drawing.Point(576, 26);
            this.rBXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBXuat.Name = "rBXuat";
            this.rBXuat.Size = new System.Drawing.Size(296, 23);
            this.rBXuat.TabIndex = 2;
            this.rBXuat.TabStop = true;
            this.rBXuat.Text = "Xem Danh Sách Phiếu Xuất Phim";
            this.rBXuat.UseVisualStyleBackColor = true;
            this.rBXuat.CheckedChanged += new System.EventHandler(this.rBXuat_CheckedChanged);
            // 
            // rBNhap
            // 
            this.rBNhap.AutoSize = true;
            this.rBNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBNhap.Location = new System.Drawing.Point(213, 26);
            this.rBNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBNhap.Name = "rBNhap";
            this.rBNhap.Size = new System.Drawing.Size(304, 23);
            this.rBNhap.TabIndex = 1;
            this.rBNhap.TabStop = true;
            this.rBNhap.Text = "Xem Danh Sách Phiếu Nhập Phim";
            this.rBNhap.UseVisualStyleBackColor = true;
            this.rBNhap.CheckedChanged += new System.EventHandler(this.rBNhap_CheckedChanged);
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
            this.rBTatCa.CheckedChanged += new System.EventHandler(this.rBTatCa_CheckedChanged);
            // 
            // cBSapXep
            // 
            this.cBSapXep.BackColor = System.Drawing.Color.White;
            this.cBSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Lập Phiếu"});
            this.cBSapXep.Location = new System.Drawing.Point(166, 133);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(280, 27);
            this.cBSapXep.TabIndex = 29;
            // 
            // dGVDanhSachPhieuNhapXuat
            // 
            this.dGVDanhSachPhieuNhapXuat.AllowUserToAddRows = false;
            this.dGVDanhSachPhieuNhapXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDanhSachPhieuNhapXuat.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDanhSachPhieuNhapXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVDanhSachPhieuNhapXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDanhSachPhieuNhapXuat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVDanhSachPhieuNhapXuat.Location = new System.Drawing.Point(32, 186);
            this.dGVDanhSachPhieuNhapXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhieuNhapXuat.Name = "dGVDanhSachPhieuNhapXuat";
            this.dGVDanhSachPhieuNhapXuat.ReadOnly = true;
            this.dGVDanhSachPhieuNhapXuat.RowHeadersWidth = 62;
            this.dGVDanhSachPhieuNhapXuat.RowTemplate.Height = 28;
            this.dGVDanhSachPhieuNhapXuat.Size = new System.Drawing.Size(602, 545);
            this.dGVDanhSachPhieuNhapXuat.TabIndex = 27;
            this.dGVDanhSachPhieuNhapXuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhieuNhapXuat_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(453, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP XUẤT PHIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_PhieuNhapXuat_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_PhieuNhapXuat_QLP";
            this.Size = new System.Drawing.Size(1352, 782);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiTietPhieuNhapXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhieuNhapXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBXuat;
        private System.Windows.Forms.RadioButton rBNhap;
        private System.Windows.Forms.RadioButton rBTatCa;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.DataGridView dGVDanhSachPhieuNhapXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVChiTietPhieuNhapXuat;
        private System.Windows.Forms.ComboBox cBTimKiem;
    }
}
