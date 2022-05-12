namespace GUI.QLP_GUI
{
    partial class frm_ThemDienVienDaoDien_QLP
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.gBDanhSachDienVienDaoDien = new System.Windows.Forms.GroupBox();
            this.dGVDanhSachDienVienDaoDien = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbChinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gBDeXuatPhim = new System.Windows.Forms.GroupBox();
            this.dGVDienVienDaoDienCuaPhim = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gBDanhSachDienVienDaoDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachDienVienDaoDien)).BeginInit();
            this.panel2.SuspendLayout();
            this.gBDeXuatPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienVienDaoDienCuaPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.gBDanhSachDienVienDaoDien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.gBDeXuatPhim);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 644);
            this.panel1.TabIndex = 64;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Silver;
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThemMoi.Location = new System.Drawing.Point(833, 325);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(188, 45);
            this.btnThemMoi.TabIndex = 66;
            this.btnThemMoi.Text = "   Thêm Mới";
            this.btnThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // gBDanhSachDienVienDaoDien
            // 
            this.gBDanhSachDienVienDaoDien.Controls.Add(this.dGVDanhSachDienVienDaoDien);
            this.gBDanhSachDienVienDaoDien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDanhSachDienVienDaoDien.Location = new System.Drawing.Point(56, 78);
            this.gBDanhSachDienVienDaoDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachDienVienDaoDien.Name = "gBDanhSachDienVienDaoDien";
            this.gBDanhSachDienVienDaoDien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDanhSachDienVienDaoDien.Size = new System.Drawing.Size(981, 243);
            this.gBDanhSachDienVienDaoDien.TabIndex = 16;
            this.gBDanhSachDienVienDaoDien.TabStop = false;
            this.gBDanhSachDienVienDaoDien.Text = "DANH SÁCH DIỄN VIÊN ĐẠO DIỄN";
            // 
            // dGVDanhSachDienVienDaoDien
            // 
            this.dGVDanhSachDienVienDaoDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDanhSachDienVienDaoDien.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachDienVienDaoDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachDienVienDaoDien.Location = new System.Drawing.Point(17, 30);
            this.dGVDanhSachDienVienDaoDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachDienVienDaoDien.Name = "dGVDanhSachDienVienDaoDien";
            this.dGVDanhSachDienVienDaoDien.RowHeadersWidth = 62;
            this.dGVDanhSachDienVienDaoDien.RowTemplate.Height = 28;
            this.dGVDanhSachDienVienDaoDien.Size = new System.Drawing.Size(948, 182);
            this.dGVDanhSachDienVienDaoDien.TabIndex = 0;
            this.dGVDanhSachDienVienDaoDien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachDienVienDaoDien_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbChinh);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 40);
            this.panel2.TabIndex = 65;
            // 
            // lbChinh
            // 
            this.lbChinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbChinh.Image = global::GUI.Properties.Resources.NhapXuat;
            this.lbChinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbChinh.Location = new System.Drawing.Point(382, -1);
            this.lbChinh.Name = "lbChinh";
            this.lbChinh.Size = new System.Drawing.Size(335, 44);
            this.lbChinh.TabIndex = 27;
            this.lbChinh.Text = "Diễn Viên Của Phim";
            this.lbChinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            // gBDeXuatPhim
            // 
            this.gBDeXuatPhim.Controls.Add(this.dGVDienVienDaoDienCuaPhim);
            this.gBDeXuatPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDeXuatPhim.Location = new System.Drawing.Point(56, 362);
            this.gBDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Name = "gBDeXuatPhim";
            this.gBDeXuatPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Size = new System.Drawing.Size(981, 208);
            this.gBDeXuatPhim.TabIndex = 15;
            this.gBDeXuatPhim.TabStop = false;
            // 
            // dGVDienVienDaoDienCuaPhim
            // 
            this.dGVDienVienDaoDienCuaPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDienVienDaoDienCuaPhim.BackgroundColor = System.Drawing.Color.White;
            this.dGVDienVienDaoDienCuaPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDienVienDaoDienCuaPhim.Location = new System.Drawing.Point(17, 30);
            this.dGVDienVienDaoDienCuaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDienVienDaoDienCuaPhim.Name = "dGVDienVienDaoDienCuaPhim";
            this.dGVDienVienDaoDienCuaPhim.RowHeadersWidth = 62;
            this.dGVDienVienDaoDienCuaPhim.RowTemplate.Height = 28;
            this.dGVDienVienDaoDienCuaPhim.Size = new System.Drawing.Size(948, 161);
            this.dGVDienVienDaoDienCuaPhim.TabIndex = 0;
            // 
            // frm_ThemDienVienDaoDien_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 685);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemDienVienDaoDien_QLP";
            this.Text = "frm_ThemDienVienDaoDien_QLP";
            this.panel1.ResumeLayout(false);
            this.gBDanhSachDienVienDaoDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachDienVienDaoDien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gBDeXuatPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDienVienDaoDienCuaPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBDanhSachDienVienDaoDien;
        private System.Windows.Forms.DataGridView dGVDanhSachDienVienDaoDien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gBDeXuatPhim;
        private System.Windows.Forms.DataGridView dGVDienVienDaoDienCuaPhim;
        private System.Windows.Forms.Button btnThemMoi;
    }
}