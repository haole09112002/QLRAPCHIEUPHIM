namespace GUI.QLVT_GUI
{
    partial class UCNhaCungUngVatTuQLVT
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
            this.dGVDanhSachNhaCungUng = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachNhaCungUng)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.White;
            this.btnSapXep.ForeColor = System.Drawing.Color.Blue;
            this.btnSapXep.Location = new System.Drawing.Point(19, 64);
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
            this.txtTimKiem.Location = new System.Drawing.Point(611, 59);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 30);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Location = new System.Drawing.Point(839, 61);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 27);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dGVDanhSachNhaCungUng
            // 
            this.dGVDanhSachNhaCungUng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachNhaCungUng.Location = new System.Drawing.Point(18, 112);
            this.dGVDanhSachNhaCungUng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachNhaCungUng.Name = "dGVDanhSachNhaCungUng";
            this.dGVDanhSachNhaCungUng.RowHeadersWidth = 62;
            this.dGVDanhSachNhaCungUng.RowTemplate.Height = 28;
            this.dGVDanhSachNhaCungUng.Size = new System.Drawing.Size(916, 427);
            this.dGVDanhSachNhaCungUng.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::GUI.Properties.Resources.ToolDeXuat;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH NHÀ CUNG ỨNG VẬT TƯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBSapXep
            // 
            this.cBSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Location = new System.Drawing.Point(132, 64);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(198, 24);
            this.cBSapXep.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dGVDanhSachNhaCungUng);
            this.panel1.Controls.Add(this.cBSapXep);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnSapXep);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(18, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 562);
            this.panel1.TabIndex = 18;
            // 
            // UC_TTNCUVT_QLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TTNCUVT_QLVT";
            this.Size = new System.Drawing.Size(993, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachNhaCungUng)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dGVDanhSachNhaCungUng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.Panel panel1;
    }
}
