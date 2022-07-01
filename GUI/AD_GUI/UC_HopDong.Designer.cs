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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.dgvDSHopDong = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.cbLoaiHopDongMuonTao = new System.Windows.Forms.ComboBox();
            this.cbbTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhimConHD = new System.Windows.Forms.DataGridView();
            this.txtTimKiemPhim = new System.Windows.Forms.TextBox();
            this.btnTimKiemPhim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHopDong)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhimConHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTieuChiTimKiem);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.cbSapXep);
            this.groupBox1.Controls.Add(this.btnSapXep);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dgvDSHopDong);
            this.groupBox1.Controls.Add(this.cbLoaiHopDong);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1294, 418);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::GUI.Properties.Resources.Hopdong1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loại Hợp đồng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1033, 30);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(216, 32);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // cbLoaiHopDong
            // 
            this.cbLoaiHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHopDong.FormattingEnabled = true;
            this.cbLoaiHopDong.Location = new System.Drawing.Point(185, 30);
            this.cbLoaiHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiHopDong.Name = "cbLoaiHopDong";
            this.cbLoaiHopDong.Size = new System.Drawing.Size(220, 32);
            this.cbLoaiHopDong.TabIndex = 5;
            this.cbLoaiHopDong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHopDong_SelectedIndexChanged);
            // 
            // dgvDSHopDong
            // 
            this.dgvDSHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHopDong.Location = new System.Drawing.Point(17, 76);
            this.dgvDSHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSHopDong.Name = "dgvDSHopDong";
            this.dgvDSHopDong.RowHeadersWidth = 51;
            this.dgvDSHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHopDong.Size = new System.Drawing.Size(1269, 295);
            this.dgvDSHopDong.TabIndex = 7;
            this.dgvDSHopDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHopDong_CellDoubleClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1250, 28);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(36, 36);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(413, 28);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(123, 38);
            this.btnSapXep.TabIndex = 5;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // cbSapXep
            // 
            this.cbSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Location = new System.Drawing.Point(544, 31);
            this.cbSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(215, 32);
            this.cbSapXep.TabIndex = 7;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLoaiHopDongMuonTao);
            this.panel3.Controls.Add(this.btnTao);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(17, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1267, 46);
            this.panel3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "*Kích đúp 1 dòng để xem chi tiết";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Silver;
            this.btnTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnTao.Location = new System.Drawing.Point(853, 3);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(123, 36);
            this.btnTao.TabIndex = 24;
            this.btnTao.Text = " Tạo";
            this.btnTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cbLoaiHopDongMuonTao
            // 
            this.cbLoaiHopDongMuonTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiHopDongMuonTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHopDongMuonTao.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHopDongMuonTao.FormattingEnabled = true;
            this.cbLoaiHopDongMuonTao.Location = new System.Drawing.Point(1001, 9);
            this.cbLoaiHopDongMuonTao.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiHopDongMuonTao.Name = "cbLoaiHopDongMuonTao";
            this.cbLoaiHopDongMuonTao.Size = new System.Drawing.Size(258, 29);
            this.cbLoaiHopDongMuonTao.TabIndex = 34;
            // 
            // cbbTieuChiTimKiem
            // 
            this.cbbTieuChiTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTieuChiTimKiem.FormattingEnabled = true;
            this.cbbTieuChiTimKiem.Location = new System.Drawing.Point(810, 30);
            this.cbbTieuChiTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTieuChiTimKiem.Name = "cbbTieuChiTimKiem";
            this.cbbTieuChiTimKiem.Size = new System.Drawing.Size(215, 32);
            this.cbbTieuChiTimKiem.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 735);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTimKiemPhim);
            this.groupBox2.Controls.Add(this.txtTimKiemPhim);
            this.groupBox2.Controls.Add(this.dgvDSPhimConHD);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 298);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phim còn hợp đồng";
            // 
            // dgvDSPhimConHD
            // 
            this.dgvDSPhimConHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhimConHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhimConHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhimConHD.Location = new System.Drawing.Point(17, 62);
            this.dgvDSPhimConHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSPhimConHD.Name = "dgvDSPhimConHD";
            this.dgvDSPhimConHD.RowHeadersWidth = 51;
            this.dgvDSPhimConHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhimConHD.Size = new System.Drawing.Size(1260, 229);
            this.dgvDSPhimConHD.TabIndex = 36;
            // 
            // txtTimKiemPhim
            // 
            this.txtTimKiemPhim.Location = new System.Drawing.Point(1018, 22);
            this.txtTimKiemPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemPhim.Name = "txtTimKiemPhim";
            this.txtTimKiemPhim.Size = new System.Drawing.Size(216, 32);
            this.txtTimKiemPhim.TabIndex = 36;
            // 
            // btnTimKiemPhim
            // 
            this.btnTimKiemPhim.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhim.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhim.Location = new System.Drawing.Point(1240, 18);
            this.btnTimKiemPhim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemPhim.Name = "btnTimKiemPhim";
            this.btnTimKiemPhim.Size = new System.Drawing.Size(36, 36);
            this.btnTimKiemPhim.TabIndex = 36;
            this.btnTimKiemPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhim.UseVisualStyleBackColor = false;
            this.btnTimKiemPhim.Click += new System.EventHandler(this.btnTimKiemPhim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nhập tên phim để tìm kiếm";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHopDong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhimConHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTieuChiTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLoaiHopDongMuonTao;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSHopDong;
        private System.Windows.Forms.ComboBox cbLoaiHopDong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSPhimConHD;
        private System.Windows.Forms.Button btnTimKiemPhim;
        private System.Windows.Forms.TextBox txtTimKiemPhim;
        private System.Windows.Forms.Label label3;
    }
}
