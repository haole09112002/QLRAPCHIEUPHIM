namespace GUI.QLVT_GUI
{
    partial class UCPhongChieuQLVT
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
            this.pnListPhongChieu = new System.Windows.Forms.Panel();
            this.btnXoaPhongChieu = new System.Windows.Forms.Button();
            this.lblVatTu = new System.Windows.Forms.Label();
            this.btnTimKiemVatTu = new System.Windows.Forms.Button();
            this.btnTimKiemPhongChieu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoaVatTu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblPhongChieu = new System.Windows.Forms.Label();
            this.lblListPhongChieu = new System.Windows.Forms.Label();
            this.dgvListVatTu = new System.Windows.Forms.DataGridView();
            this.dgvListPhongChieu = new System.Windows.Forms.DataGridView();
            this.txtVatTu = new System.Windows.Forms.TextBox();
            this.pnListPhongChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhongChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListPhongChieu
            // 
            this.pnListPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListPhongChieu.Controls.Add(this.txtVatTu);
            this.pnListPhongChieu.Controls.Add(this.btnXoaPhongChieu);
            this.pnListPhongChieu.Controls.Add(this.lblVatTu);
            this.pnListPhongChieu.Controls.Add(this.btnTimKiemVatTu);
            this.pnListPhongChieu.Controls.Add(this.btnTimKiemPhongChieu);
            this.pnListPhongChieu.Controls.Add(this.btnThem);
            this.pnListPhongChieu.Controls.Add(this.btnXoaVatTu);
            this.pnListPhongChieu.Controls.Add(this.txtTimKiem);
            this.pnListPhongChieu.Controls.Add(this.lblPhongChieu);
            this.pnListPhongChieu.Controls.Add(this.lblListPhongChieu);
            this.pnListPhongChieu.Controls.Add(this.dgvListVatTu);
            this.pnListPhongChieu.Controls.Add(this.dgvListPhongChieu);
            this.pnListPhongChieu.Location = new System.Drawing.Point(9, 14);
            this.pnListPhongChieu.Name = "pnListPhongChieu";
            this.pnListPhongChieu.Size = new System.Drawing.Size(972, 579);
            this.pnListPhongChieu.TabIndex = 0;
            // 
            // btnXoaPhongChieu
            // 
            this.btnXoaPhongChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaPhongChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhongChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhongChieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhongChieu.Image = global::GUI.Properties.Resources.trash_can_26px;
            this.btnXoaPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhongChieu.Location = new System.Drawing.Point(335, 507);
            this.btnXoaPhongChieu.Name = "btnXoaPhongChieu";
            this.btnXoaPhongChieu.Size = new System.Drawing.Size(104, 36);
            this.btnXoaPhongChieu.TabIndex = 47;
            this.btnXoaPhongChieu.Text = "   Xóa";
            this.btnXoaPhongChieu.UseVisualStyleBackColor = false;
            // 
            // lblVatTu
            // 
            this.lblVatTu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblVatTu.Image = global::GUI.Properties.Resources.ToolDeXuat;
            this.lblVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVatTu.Location = new System.Drawing.Point(600, 75);
            this.lblVatTu.Name = "lblVatTu";
            this.lblVatTu.Size = new System.Drawing.Size(93, 33);
            this.lblVatTu.TabIndex = 46;
            this.lblVatTu.Text = "VẬT TƯ";
            this.lblVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiemVatTu
            // 
            this.btnTimKiemVatTu.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemVatTu.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemVatTu.Location = new System.Drawing.Point(839, 70);
            this.btnTimKiemVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemVatTu.Name = "btnTimKiemVatTu";
            this.btnTimKiemVatTu.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemVatTu.TabIndex = 45;
            this.btnTimKiemVatTu.Text = "TÌM KIẾM";
            this.btnTimKiemVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemVatTu.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemPhongChieu
            // 
            this.btnTimKiemPhongChieu.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemPhongChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemPhongChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhongChieu.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhongChieu.Location = new System.Drawing.Point(454, 70);
            this.btnTimKiemPhongChieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemPhongChieu.Name = "btnTimKiemPhongChieu";
            this.btnTimKiemPhongChieu.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemPhongChieu.TabIndex = 44;
            this.btnTimKiemPhongChieu.Text = "TÌM KIẾM";
            this.btnTimKiemPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhongChieu.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.new_copy_26px;
            this.btnThem.Location = new System.Drawing.Point(113, 507);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 36);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoaVatTu
            // 
            this.btnXoaVatTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaVatTu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVatTu.Image = global::GUI.Properties.Resources.trash_can_26px;
            this.btnXoaVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaVatTu.Location = new System.Drawing.Point(741, 507);
            this.btnXoaVatTu.Name = "btnXoaVatTu";
            this.btnXoaVatTu.Size = new System.Drawing.Size(104, 36);
            this.btnXoaVatTu.TabIndex = 29;
            this.btnXoaVatTu.Text = "   Xóa";
            this.btnXoaVatTu.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(174, 77);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 22);
            this.txtTimKiem.TabIndex = 20;
            // 
            // lblPhongChieu
            // 
            this.lblPhongChieu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhongChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.lblPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhongChieu.Location = new System.Drawing.Point(10, 72);
            this.lblPhongChieu.Name = "lblPhongChieu";
            this.lblPhongChieu.Size = new System.Drawing.Size(158, 33);
            this.lblPhongChieu.TabIndex = 15;
            this.lblPhongChieu.Text = "PHÒNG CHIẾU";
            this.lblPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblListPhongChieu
            // 
            this.lblListPhongChieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblListPhongChieu.Image = global::GUI.Properties.Resources.MovieRoom;
            this.lblListPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListPhongChieu.Location = new System.Drawing.Point(335, 17);
            this.lblListPhongChieu.Name = "lblListPhongChieu";
            this.lblListPhongChieu.Size = new System.Drawing.Size(305, 37);
            this.lblListPhongChieu.TabIndex = 14;
            this.lblListPhongChieu.Text = "DANH SÁCH PHÒNG CHIẾU";
            this.lblListPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListVatTu
            // 
            this.dgvListVatTu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVatTu.Location = new System.Drawing.Point(603, 117);
            this.dgvListVatTu.Name = "dgvListVatTu";
            this.dgvListVatTu.RowHeadersWidth = 51;
            this.dgvListVatTu.RowTemplate.Height = 24;
            this.dgvListVatTu.Size = new System.Drawing.Size(359, 367);
            this.dgvListVatTu.TabIndex = 13;
            // 
            // dgvListPhongChieu
            // 
            this.dgvListPhongChieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPhongChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPhongChieu.Location = new System.Drawing.Point(13, 117);
            this.dgvListPhongChieu.Name = "dgvListPhongChieu";
            this.dgvListPhongChieu.RowHeadersWidth = 51;
            this.dgvListPhongChieu.RowTemplate.Height = 24;
            this.dgvListPhongChieu.Size = new System.Drawing.Size(564, 367);
            this.dgvListPhongChieu.TabIndex = 12;
            // 
            // txtVatTu
            // 
            this.txtVatTu.Location = new System.Drawing.Point(702, 79);
            this.txtVatTu.Name = "txtVatTu";
            this.txtVatTu.Size = new System.Drawing.Size(130, 22);
            this.txtVatTu.TabIndex = 48;
            // 
            // UCPhongChieuQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListPhongChieu);
            this.Name = "UCPhongChieuQLVT";
            this.Size = new System.Drawing.Size(993, 613);
            this.pnListPhongChieu.ResumeLayout(false);
            this.pnListPhongChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPhongChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListPhongChieu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblPhongChieu;
        private System.Windows.Forms.Label lblListPhongChieu;
        private System.Windows.Forms.DataGridView dgvListVatTu;
        private System.Windows.Forms.DataGridView dgvListPhongChieu;
        private System.Windows.Forms.Button btnXoaVatTu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiemVatTu;
        private System.Windows.Forms.Button btnTimKiemPhongChieu;
        private System.Windows.Forms.Label lblVatTu;
        private System.Windows.Forms.Button btnXoaPhongChieu;
        private System.Windows.Forms.TextBox txtVatTu;
    }
}
