namespace GUI.AD_GUI
{
    partial class UC_ThongTinNV
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
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbTimKiem);
            this.panel1.Controls.Add(this.btnXemCT);
            this.panel1.Controls.Add(this.btnSapXep);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbbSapXep);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 729);
            this.panel1.TabIndex = 0;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Location = new System.Drawing.Point(1052, 48);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(225, 28);
            this.cbbTimKiem.TabIndex = 41;
            // 
            // btnXemCT
            // 
            this.btnXemCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXemCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCT.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnXemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemCT.Location = new System.Drawing.Point(494, 674);
            this.btnXemCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(148, 36);
            this.btnXemCT.TabIndex = 39;
            this.btnXemCT.Text = "XEM CHI TIẾT";
            this.btnXemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemCT.UseVisualStyleBackColor = false;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(42, 36);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 38;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(725, 674);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 36);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(653, 42);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1275, 583);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhanVien.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(21, 28);
            this.dgvDSNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.RowHeadersWidth = 51;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(1235, 537);
            this.dgvDSNhanVien.TabIndex = 4;
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.BackColor = System.Drawing.Color.White;
            this.cbbSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Location = new System.Drawing.Point(184, 43);
            this.cbbSapXep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(188, 27);
            this.cbbSapXep.TabIndex = 34;
            this.cbbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbbSapXep_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(800, 47);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(227, 28);
            this.txtTimKiem.TabIndex = 33;
            // 
            // UC_ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_ThongTinNV";
            this.Size = new System.Drawing.Size(1352, 766);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
    }
}