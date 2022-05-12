namespace GUI.QLP_GUI
{
    partial class frm_TaoDeXuat_QLP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBDanhSachPhim = new System.Windows.Forms.GroupBox();
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.gBDeXuatPhim = new System.Windows.Forms.GroupBox();
            this.dGVDeXuatPhim = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gBDanhSachPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.gBDeXuatPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDeXuatPhim)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gBDanhSachPhim);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.gBDeXuatPhim);
            this.panel1.Location = new System.Drawing.Point(25, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 644);
            this.panel1.TabIndex = 13;
            // 
            // gBDanhSachPhim
            // 
            this.gBDanhSachPhim.Controls.Add(this.dGVDanhSachPhim);
            this.gBDanhSachPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachPhim.Location = new System.Drawing.Point(56, 78);
            this.gBDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Name = "gBDanhSachPhim";
            this.gBDanhSachPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachPhim.Size = new System.Drawing.Size(981, 265);
            this.gBDanhSachPhim.TabIndex = 16;
            this.gBDanhSachPhim.TabStop = false;
            this.gBDanhSachPhim.Text = "DANH SÁCH PHIM";
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDanhSachPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(17, 30);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(948, 211);
            this.dGVDanhSachPhim.TabIndex = 0;
            this.dGVDanhSachPhim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhim_CellDoubleClick);
            // 
            // gBDeXuatPhim
            // 
            this.gBDeXuatPhim.Controls.Add(this.dGVDeXuatPhim);
            this.gBDeXuatPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDeXuatPhim.Location = new System.Drawing.Point(56, 362);
            this.gBDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Name = "gBDeXuatPhim";
            this.gBDeXuatPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Size = new System.Drawing.Size(981, 208);
            this.gBDeXuatPhim.TabIndex = 15;
            this.gBDeXuatPhim.TabStop = false;
            this.gBDeXuatPhim.Text = "ĐỀ XUẤT PHIM";
            // 
            // dGVDeXuatPhim
            // 
            this.dGVDeXuatPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDeXuatPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDeXuatPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDeXuatPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.TenPhim});
            this.dGVDeXuatPhim.Location = new System.Drawing.Point(17, 30);
            this.dGVDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDeXuatPhim.Name = "dGVDeXuatPhim";
            this.dGVDeXuatPhim.RowHeadersWidth = 62;
            this.dGVDeXuatPhim.RowTemplate.Height = 28;
            this.dGVDeXuatPhim.Size = new System.Drawing.Size(948, 161);
            this.dGVDeXuatPhim.TabIndex = 0;
            // 
            // MaPhim
            // 
            this.MaPhim.HeaderText = "Mã Phim";
            this.MaPhim.MinimumWidth = 8;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.Width = 137;
            // 
            // TenPhim
            // 
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 8;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Width = 139;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(25, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 40);
            this.panel2.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::GUI.Properties.Resources.NhapXuat;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(415, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 44);
            this.label6.TabIndex = 27;
            this.label6.Text = "TẠO ĐỀ XUẤT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(74, 576);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 45);
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::GUI.Properties.Resources.Renew;
            this.btnLamMoi.Location = new System.Drawing.Point(459, 577);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(169, 45);
            this.btnLamMoi.TabIndex = 57;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(886, 577);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 45);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // frm_TaoDeXuat_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TaoDeXuat_QLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TaoDeXuat_QLP";
            this.panel1.ResumeLayout(false);
            this.gBDanhSachPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.gBDeXuatPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDeXuatPhim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gBDeXuatPhim;
        private System.Windows.Forms.DataGridView dGVDeXuatPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gBDanhSachPhim;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
    }
}