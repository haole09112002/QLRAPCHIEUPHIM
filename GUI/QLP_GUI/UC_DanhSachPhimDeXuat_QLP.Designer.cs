namespace GUI.QLP_GUI
{
    partial class UC_DanhSachPhimDeXuat_QLP
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
            this.cBTimKiem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVDanhSachPhieuDeXuat = new System.Windows.Forms.DataGridView();
            this.gBDeXuatPhim = new System.Windows.Forms.GroupBox();
            this.dGVChiTietPhieuDeXuat = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhieuDeXuat)).BeginInit();
            this.gBDeXuatPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiTietPhieuDeXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cBTimKiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gBDeXuatPhim);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnSapXep);
            this.panel1.Controls.Add(this.cBSapXep);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 734);
            this.panel1.TabIndex = 1;
            // 
            // cBTimKiem
            // 
            this.cBTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTimKiem.FormattingEnabled = true;
            this.cBTimKiem.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Đề Xuất"});
            this.cBTimKiem.Location = new System.Drawing.Point(441, 64);
            this.cBTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBTimKiem.Name = "cBTimKiem";
            this.cBTimKiem.Size = new System.Drawing.Size(169, 31);
            this.cBTimKiem.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVDanhSachPhieuDeXuat);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(576, 535);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Đề Xuất";
            // 
            // dGVDanhSachPhieuDeXuat
            // 
            this.dGVDanhSachPhieuDeXuat.AllowUserToAddRows = false;
            this.dGVDanhSachPhieuDeXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDanhSachPhieuDeXuat.BackgroundColor = System.Drawing.Color.White;
            this.dGVDanhSachPhieuDeXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhieuDeXuat.Location = new System.Drawing.Point(22, 26);
            this.dGVDanhSachPhieuDeXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhieuDeXuat.Name = "dGVDanhSachPhieuDeXuat";
            this.dGVDanhSachPhieuDeXuat.RowHeadersWidth = 62;
            this.dGVDanhSachPhieuDeXuat.RowTemplate.Height = 28;
            this.dGVDanhSachPhieuDeXuat.Size = new System.Drawing.Size(528, 491);
            this.dGVDanhSachPhieuDeXuat.TabIndex = 0;
            this.dGVDanhSachPhieuDeXuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhieuDeXuat_CellDoubleClick);
            // 
            // gBDeXuatPhim
            // 
            this.gBDeXuatPhim.Controls.Add(this.dGVChiTietPhieuDeXuat);
            this.gBDeXuatPhim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBDeXuatPhim.Location = new System.Drawing.Point(620, 125);
            this.gBDeXuatPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Name = "gBDeXuatPhim";
            this.gBDeXuatPhim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDeXuatPhim.Size = new System.Drawing.Size(653, 535);
            this.gBDeXuatPhim.TabIndex = 49;
            this.gBDeXuatPhim.TabStop = false;
            this.gBDeXuatPhim.Text = "Chi Tiết Phiếu Đề Xuất Phim";
            // 
            // dGVChiTietPhieuDeXuat
            // 
            this.dGVChiTietPhieuDeXuat.AllowUserToAddRows = false;
            this.dGVChiTietPhieuDeXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVChiTietPhieuDeXuat.BackgroundColor = System.Drawing.Color.White;
            this.dGVChiTietPhieuDeXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChiTietPhieuDeXuat.Location = new System.Drawing.Point(15, 30);
            this.dGVChiTietPhieuDeXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVChiTietPhieuDeXuat.Name = "dGVChiTietPhieuDeXuat";
            this.dGVChiTietPhieuDeXuat.RowHeadersWidth = 62;
            this.dGVChiTietPhieuDeXuat.RowTemplate.Height = 28;
            this.dGVChiTietPhieuDeXuat.Size = new System.Drawing.Size(632, 491);
            this.dGVChiTietPhieuDeXuat.TabIndex = 40;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.button4.Location = new System.Drawing.Point(1109, 670);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 45);
            this.button4.TabIndex = 48;
            this.button4.Text = " Thêm";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(830, 62);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(138, 48);
            this.btnSapXep.TabIndex = 47;
            this.btnSapXep.Text = "    SẮP XẾP";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // cBSapXep
            // 
            this.cBSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Ngày Đề Xuất"});
            this.cBSapXep.Location = new System.Drawing.Point(975, 66);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(298, 31);
            this.cBSapXep.TabIndex = 46;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(42, 54);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 45);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(187, 62);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(248, 33);
            this.txtTimKiem.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.film_reel_26px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(488, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "DANH SÁCH PHIM ĐỀ XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_DanhSachPhimDeXuat_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_DanhSachPhimDeXuat_QLP";
            this.Size = new System.Drawing.Size(1333, 766);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhieuDeXuat)).EndInit();
            this.gBDeXuatPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiTietPhieuDeXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVChiTietPhieuDeXuat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gBDeXuatPhim;
        private System.Windows.Forms.DataGridView dGVDanhSachPhieuDeXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBTimKiem;
    }
}
