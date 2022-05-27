namespace GUI.AD_GUI
{
    partial class UC_DeXuat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTimKiemDeXuat = new System.Windows.Forms.ComboBox();
            this.txtTKdeXuat = new System.Windows.Forms.TextBox();
            this.btnTKdeXuat = new System.Windows.Forms.Button();
            this.cbbTimKiemDadeXuat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiemDaDeXuat = new System.Windows.Forms.TextBox();
            this.btnTimKiemDaDeXuat = new System.Windows.Forms.Button();
            this.btnKhongDongY = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.cbbDeXuat = new System.Windows.Forms.ComboBox();
            this.dgvDaDeXuat = new System.Windows.Forms.DataGridView();
            this.dgvChiTietdeXuat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDeXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietdeXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbTimKiemDeXuat);
            this.panel1.Controls.Add(this.txtTKdeXuat);
            this.panel1.Controls.Add(this.btnTKdeXuat);
            this.panel1.Controls.Add(this.cbbTimKiemDadeXuat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTimKiemDaDeXuat);
            this.panel1.Controls.Add(this.btnTimKiemDaDeXuat);
            this.panel1.Controls.Add(this.btnKhongDongY);
            this.panel1.Controls.Add(this.btnDongY);
            this.panel1.Controls.Add(this.cbbDeXuat);
            this.panel1.Controls.Add(this.dgvDaDeXuat);
            this.panel1.Controls.Add(this.dgvChiTietdeXuat);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(32, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 478);
            this.panel1.TabIndex = 0;
            // 
            // cbbTimKiemDeXuat
            // 
            this.cbbTimKiemDeXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemDeXuat.FormattingEnabled = true;
            this.cbbTimKiemDeXuat.Items.AddRange(new object[] {
            "Mã Đề Xuất",
            "Tên Sản Phẩm"});
            this.cbbTimKiemDeXuat.Location = new System.Drawing.Point(548, 9);
            this.cbbTimKiemDeXuat.Name = "cbbTimKiemDeXuat";
            this.cbbTimKiemDeXuat.Size = new System.Drawing.Size(121, 27);
            this.cbbTimKiemDeXuat.TabIndex = 36;
            // 
            // txtTKdeXuat
            // 
            this.txtTKdeXuat.Location = new System.Drawing.Point(404, 10);
            this.txtTKdeXuat.Name = "txtTKdeXuat";
            this.txtTKdeXuat.Size = new System.Drawing.Size(138, 27);
            this.txtTKdeXuat.TabIndex = 35;
            // 
            // btnTKdeXuat
            // 
            this.btnTKdeXuat.BackColor = System.Drawing.Color.Cyan;
            this.btnTKdeXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKdeXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKdeXuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKdeXuat.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTKdeXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKdeXuat.Location = new System.Drawing.Point(299, 6);
            this.btnTKdeXuat.Name = "btnTKdeXuat";
            this.btnTKdeXuat.Size = new System.Drawing.Size(92, 29);
            this.btnTKdeXuat.TabIndex = 34;
            this.btnTKdeXuat.Text = "TÌM KIẾM";
            this.btnTKdeXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKdeXuat.UseVisualStyleBackColor = false;
            this.btnTKdeXuat.Click += new System.EventHandler(this.btnTKdeXuat_Click);
            // 
            // cbbTimKiemDadeXuat
            // 
            this.cbbTimKiemDadeXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemDadeXuat.FormattingEnabled = true;
            this.cbbTimKiemDadeXuat.Items.AddRange(new object[] {
            "Mã Đề Xuất",
            "Tên Sản Phẩm"});
            this.cbbTimKiemDadeXuat.Location = new System.Drawing.Point(550, 281);
            this.cbbTimKiemDadeXuat.Name = "cbbTimKiemDadeXuat";
            this.cbbTimKiemDadeXuat.Size = new System.Drawing.Size(121, 27);
            this.cbbTimKiemDadeXuat.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.Search;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "ĐỀ XUẤT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::GUI.Properties.Resources.Calam;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(20, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "DANH SÁCH ĐÃ ĐỀ XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::GUI.Properties.Resources.Calam;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "DANH SÁCH ĐỀ XUẤT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiemDaDeXuat
            // 
            this.txtTimKiemDaDeXuat.Location = new System.Drawing.Point(406, 282);
            this.txtTimKiemDaDeXuat.Name = "txtTimKiemDaDeXuat";
            this.txtTimKiemDaDeXuat.Size = new System.Drawing.Size(138, 27);
            this.txtTimKiemDaDeXuat.TabIndex = 23;
            // 
            // btnTimKiemDaDeXuat
            // 
            this.btnTimKiemDaDeXuat.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemDaDeXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemDaDeXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemDaDeXuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDaDeXuat.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemDaDeXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemDaDeXuat.Location = new System.Drawing.Point(299, 275);
            this.btnTimKiemDaDeXuat.Name = "btnTimKiemDaDeXuat";
            this.btnTimKiemDaDeXuat.Size = new System.Drawing.Size(92, 29);
            this.btnTimKiemDaDeXuat.TabIndex = 22;
            this.btnTimKiemDaDeXuat.Text = "TÌM KIẾM";
            this.btnTimKiemDaDeXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemDaDeXuat.UseVisualStyleBackColor = false;
            this.btnTimKiemDaDeXuat.Click += new System.EventHandler(this.btnTimKiemDaDeXuat_Click);
            // 
            // btnKhongDongY
            // 
            this.btnKhongDongY.BackColor = System.Drawing.Color.LightCoral;
            this.btnKhongDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongDongY.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongDongY.Image = global::GUI.Properties.Resources.Close;
            this.btnKhongDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhongDongY.Location = new System.Drawing.Point(531, 245);
            this.btnKhongDongY.Name = "btnKhongDongY";
            this.btnKhongDongY.Size = new System.Drawing.Size(138, 29);
            this.btnKhongDongY.TabIndex = 21;
            this.btnKhongDongY.Text = "KHÔNG ĐỒNG Ý";
            this.btnKhongDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhongDongY.UseVisualStyleBackColor = false;
            this.btnKhongDongY.Click += new System.EventHandler(this.btnKhongDongY_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.LightGreen;
            this.btnDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongY.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Image = global::GUI.Properties.Resources.Accept;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(420, 245);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(84, 29);
            this.btnDongY.TabIndex = 20;
            this.btnDongY.Text = "ĐỒNG Ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // cbbDeXuat
            // 
            this.cbbDeXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDeXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeXuat.FormattingEnabled = true;
            this.cbbDeXuat.Location = new System.Drawing.Point(106, 8);
            this.cbbDeXuat.Name = "cbbDeXuat";
            this.cbbDeXuat.Size = new System.Drawing.Size(155, 27);
            this.cbbDeXuat.TabIndex = 18;
            this.cbbDeXuat.SelectedIndexChanged += new System.EventHandler(this.cbbDeXuat_SelectedIndexChanged);
            // 
            // dgvDaDeXuat
            // 
            this.dgvDaDeXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaDeXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvDaDeXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaDeXuat.Location = new System.Drawing.Point(23, 308);
            this.dgvDaDeXuat.Name = "dgvDaDeXuat";
            this.dgvDaDeXuat.ReadOnly = true;
            this.dgvDaDeXuat.RowHeadersWidth = 51;
            this.dgvDaDeXuat.Size = new System.Drawing.Size(648, 165);
            this.dgvDaDeXuat.TabIndex = 15;
            // 
            // dgvChiTietdeXuat
            // 
            this.dgvChiTietdeXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietdeXuat.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietdeXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietdeXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietdeXuat.Location = new System.Drawing.Point(21, 52);
            this.dgvChiTietdeXuat.Name = "dgvChiTietdeXuat";
            this.dgvChiTietdeXuat.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietdeXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietdeXuat.RowHeadersWidth = 51;
            this.dgvChiTietdeXuat.Size = new System.Drawing.Size(648, 187);
            this.dgvChiTietdeXuat.TabIndex = 14;
            // 
            // UC_DeXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_DeXuat";
            this.Size = new System.Drawing.Size(745, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDeXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietdeXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiemDaDeXuat;
        private System.Windows.Forms.Button btnTimKiemDaDeXuat;
        private System.Windows.Forms.Button btnKhongDongY;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.ComboBox cbbDeXuat;
        private System.Windows.Forms.DataGridView dgvDaDeXuat;
        private System.Windows.Forms.DataGridView dgvChiTietdeXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTimKiemDeXuat;
        private System.Windows.Forms.TextBox txtTKdeXuat;
        private System.Windows.Forms.Button btnTKdeXuat;
        private System.Windows.Forms.ComboBox cbbTimKiemDadeXuat;
    }
}
