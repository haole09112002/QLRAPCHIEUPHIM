namespace GUI.AD_GUI
{
    partial class UC_Kho_AD
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.cbbLoaiKho = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 464);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnXuat);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.cbbSapXep);
            this.groupBox2.Controls.Add(this.cbbLoaiKho);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(17, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.NhaKho;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "LOẠI KHO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Image = global::GUI.Properties.Resources.Download;
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(364, 49);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(111, 32);
            this.btnXuat.TabIndex = 25;
            this.btnXuat.Text = "XUẤT EXCEL";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(365, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 29);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "   TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::GUI.Properties.Resources.Sort;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(14, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "    SẮP XẾP";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Location = new System.Drawing.Point(122, 50);
            this.cbbSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(200, 25);
            this.cbbSapXep.TabIndex = 3;
            this.cbbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbbSapXep_SelectedIndexChanged);
            // 
            // cbbLoaiKho
            // 
            this.cbbLoaiKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLoaiKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiKho.FormattingEnabled = true;
            this.cbbLoaiKho.Location = new System.Drawing.Point(122, 13);
            this.cbbLoaiKho.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiKho.Name = "cbbLoaiKho";
            this.cbbLoaiKho.Size = new System.Drawing.Size(200, 25);
            this.cbbLoaiKho.TabIndex = 4;
            this.cbbLoaiKho.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiKho_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(490, 15);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 24);
            this.txtTimKiem.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChiTiet);
            this.groupBox1.Controls.Add(this.dgvKho);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(692, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(340, 22);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(332, 312);
            this.dgvChiTiet.TabIndex = 1;
            // 
            // dgvKho
            // 
            this.dgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKho.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(4, 22);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(332, 312);
            this.dgvKho.TabIndex = 0;
            this.dgvKho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "*Kích đúp 1 dòng để xem chi tiết";
            // 
            // UC_Kho_AD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Kho_AD";
            this.Size = new System.Drawing.Size(745, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.ComboBox cbbLoaiKho;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label1;
    }
}
