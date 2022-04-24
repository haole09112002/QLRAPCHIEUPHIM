namespace GUI.AD_GUI
{
    partial class UC_MenuKho
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
            this.btnMenuKho = new System.Windows.Forms.Button();
            this.btnMenuPhieuNhapXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuKho
            // 
            this.btnMenuKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuKho.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuKho.Location = new System.Drawing.Point(92, 0);
            this.btnMenuKho.Name = "btnMenuKho";
            this.btnMenuKho.Size = new System.Drawing.Size(223, 29);
            this.btnMenuKho.TabIndex = 0;
            this.btnMenuKho.Text = "KHO";
            this.btnMenuKho.UseVisualStyleBackColor = true;
            this.btnMenuKho.Click += new System.EventHandler(this.btnMenuKho_Click);
            // 
            // btnMenuPhieuNhapXuat
            // 
            this.btnMenuPhieuNhapXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPhieuNhapXuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPhieuNhapXuat.Location = new System.Drawing.Point(357, 0);
            this.btnMenuPhieuNhapXuat.Name = "btnMenuPhieuNhapXuat";
            this.btnMenuPhieuNhapXuat.Size = new System.Drawing.Size(223, 29);
            this.btnMenuPhieuNhapXuat.TabIndex = 1;
            this.btnMenuPhieuNhapXuat.Text = "PHIẾU NHẬP XUẤT";
            this.btnMenuPhieuNhapXuat.UseVisualStyleBackColor = true;
            this.btnMenuPhieuNhapXuat.Click += new System.EventHandler(this.btnMenuPhieuNhapXuat_Click);
            // 
            // UC_MenuKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuPhieuNhapXuat);
            this.Controls.Add(this.btnMenuKho);
            this.Name = "UC_MenuKho";
            this.Size = new System.Drawing.Size(993, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuKho;
        private System.Windows.Forms.Button btnMenuPhieuNhapXuat;
    }
}
