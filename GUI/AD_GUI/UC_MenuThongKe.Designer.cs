namespace GUI.AD_GUI
{
    partial class UC_MenuThongKe
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
            this.btnMenuThongTinChung = new System.Windows.Forms.Button();
            this.btnMenuNhapXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuThongTinChung
            // 
            this.btnMenuThongTinChung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnMenuThongTinChung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuThongTinChung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuThongTinChung.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuThongTinChung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuThongTinChung.Location = new System.Drawing.Point(0, 0);
            this.btnMenuThongTinChung.Name = "btnMenuThongTinChung";
            this.btnMenuThongTinChung.Size = new System.Drawing.Size(223, 29);
            this.btnMenuThongTinChung.TabIndex = 0;
            this.btnMenuThongTinChung.Text = "THÔNG TIN CHUNG";
            this.btnMenuThongTinChung.UseVisualStyleBackColor = false;
            this.btnMenuThongTinChung.Click += new System.EventHandler(this.btnMenuThongTinChung_Click);
            // 
            // btnMenuNhapXuat
            // 
            this.btnMenuNhapXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuNhapXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNhapXuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuNhapXuat.Location = new System.Drawing.Point(223, 0);
            this.btnMenuNhapXuat.Name = "btnMenuNhapXuat";
            this.btnMenuNhapXuat.Size = new System.Drawing.Size(223, 29);
            this.btnMenuNhapXuat.TabIndex = 2;
            this.btnMenuNhapXuat.Text = "THỐNG KÊ NHẬP XUẤT";
            this.btnMenuNhapXuat.UseVisualStyleBackColor = true;
            this.btnMenuNhapXuat.Click += new System.EventHandler(this.btnMenuNhapXuat_Click);
            // 
            // UC_MenuThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuNhapXuat);
            this.Controls.Add(this.btnMenuThongTinChung);
            this.Name = "UC_MenuThongKe";
            this.Size = new System.Drawing.Size(993, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuThongTinChung;
        private System.Windows.Forms.Button btnMenuNhapXuat;
    }
}
