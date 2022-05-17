namespace GUI.AD_GUI
{
    partial class UC_HopDong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDSHopDong = new System.Windows.Forms.DataGridView();
            this.cbLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLoaiHopDongMuonTao = new System.Windows.Forms.ComboBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHopDong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 735);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSapXep);
            this.groupBox1.Controls.Add(this.btnSapXep);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dgvDSHopDong);
            this.groupBox1.Controls.Add(this.cbLoaiHopDong);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 602);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng";
            // 
            // cbSapXep
            // 
            this.cbSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Location = new System.Drawing.Point(636, 46);
            this.cbSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(215, 30);
            this.cbSapXep.TabIndex = 7;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(488, 40);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 5;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(883, 37);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvDSHopDong
            // 
            this.dgvDSHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHopDong.Location = new System.Drawing.Point(17, 89);
            this.dgvDSHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSHopDong.Name = "dgvDSHopDong";
            this.dgvDSHopDong.RowHeadersWidth = 51;
            this.dgvDSHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHopDong.Size = new System.Drawing.Size(1230, 493);
            this.dgvDSHopDong.TabIndex = 7;
            this.dgvDSHopDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHopDong_CellDoubleClick);
            // 
            // cbLoaiHopDong
            // 
            this.cbLoaiHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiHopDong.FormattingEnabled = true;
            this.cbLoaiHopDong.Location = new System.Drawing.Point(185, 38);
            this.cbLoaiHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiHopDong.Name = "cbLoaiHopDong";
            this.cbLoaiHopDong.Size = new System.Drawing.Size(288, 30);
            this.cbLoaiHopDong.TabIndex = 5;
            this.cbLoaiHopDong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHopDong_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1031, 46);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(216, 27);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.Hopdong1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loại Hợp đồng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLoaiHopDongMuonTao);
            this.panel3.Controls.Add(this.btnTao);
            this.panel3.Controls.Add(this.btnXemChiTiet);
            this.panel3.Controls.Add(this.btnExcel);
            this.panel3.Location = new System.Drawing.Point(25, 643);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1263, 62);
            this.panel3.TabIndex = 34;
            // 
            // cbLoaiHopDongMuonTao
            // 
            this.cbLoaiHopDongMuonTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiHopDongMuonTao.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHopDongMuonTao.FormattingEnabled = true;
            this.cbLoaiHopDongMuonTao.Location = new System.Drawing.Point(278, 18);
            this.cbLoaiHopDongMuonTao.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiHopDongMuonTao.Name = "cbLoaiHopDongMuonTao";
            this.cbLoaiHopDongMuonTao.Size = new System.Drawing.Size(258, 29);
            this.cbLoaiHopDongMuonTao.TabIndex = 34;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Silver;
            this.btnTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnTao.Location = new System.Drawing.Point(134, 12);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(123, 36);
            this.btnTao.TabIndex = 24;
            this.btnTao.Text = " Tạo";
            this.btnTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(636, 15);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(148, 36);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "XEM CHI TIẾT";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::GUI.Properties.Resources.Download;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(965, 18);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 40);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "XUẤT EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // UC_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_HopDong";
            this.Size = new System.Drawing.Size(1333, 766);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHopDong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSHopDong;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.ComboBox cbLoaiHopDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLoaiHopDongMuonTao;
    }
}
