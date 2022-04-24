namespace GUI.QLVT_GUI
{
    partial class UC_TTNCUVT_QLVT
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
            this.btnSapXep = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.dGVDanhSachNhaCungUng = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachNhaCungUng)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.White;
            this.btnSapXep.ForeColor = System.Drawing.Color.Blue;
            this.btnSapXep.Location = new System.Drawing.Point(638, 534);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(95, 27);
            this.btnSapXep.TabIndex = 16;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(739, 52);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 30);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Location = new System.Drawing.Point(638, 52);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 27);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiém";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.Color.White;
            this.btnXemThongTin.ForeColor = System.Drawing.Color.Blue;
            this.btnXemThongTin.Location = new System.Drawing.Point(419, 534);
            this.btnXemThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(145, 27);
            this.btnXemThongTin.TabIndex = 11;
            this.btnXemThongTin.Text = "Xem Thông Tin";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // dGVDanhSachNhaCungUng
            // 
            this.dGVDanhSachNhaCungUng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachNhaCungUng.Location = new System.Drawing.Point(34, 98);
            this.dGVDanhSachNhaCungUng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachNhaCungUng.Name = "dGVDanhSachNhaCungUng";
            this.dGVDanhSachNhaCungUng.RowHeadersWidth = 62;
            this.dGVDanhSachNhaCungUng.RowTemplate.Height = 28;
            this.dGVDanhSachNhaCungUng.Size = new System.Drawing.Size(916, 384);
            this.dGVDanhSachNhaCungUng.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH NHÀ CUNG ỨNG VẬT TƯ";
            // 
            // cBSapXep
            // 
            this.cBSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Location = new System.Drawing.Point(753, 538);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(198, 24);
            this.cBSapXep.TabIndex = 17;
            // 
            // UC_TTNCUVT_QLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.dGVDanhSachNhaCungUng);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TTNCUVT_QLVT";
            this.Size = new System.Drawing.Size(993, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachNhaCungUng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.DataGridView dGVDanhSachNhaCungUng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBSapXep;
    }
}
