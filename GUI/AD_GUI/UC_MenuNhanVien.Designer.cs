namespace GUI.AD_GUI
{
    partial class UC_MenuNhanVien
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
            this.btnMenuThongTinNV = new System.Windows.Forms.Button();
            this.btnMenuCaLam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuThongTinNV
            // 
            this.btnMenuThongTinNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnMenuThongTinNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuThongTinNV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuThongTinNV.Location = new System.Drawing.Point(102, 0);
            this.btnMenuThongTinNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuThongTinNV.Name = "btnMenuThongTinNV";
            this.btnMenuThongTinNV.Size = new System.Drawing.Size(167, 24);
            this.btnMenuThongTinNV.TabIndex = 0;
            this.btnMenuThongTinNV.Text = "THÔNG TIN NHÂN VIÊN";
            this.btnMenuThongTinNV.UseVisualStyleBackColor = false;
            this.btnMenuThongTinNV.Click += new System.EventHandler(this.btnMenuThongTinNV_Click);
            // 
            // btnMenuCaLam
            // 
            this.btnMenuCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCaLam.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCaLam.Location = new System.Drawing.Point(411, 0);
            this.btnMenuCaLam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuCaLam.Name = "btnMenuCaLam";
            this.btnMenuCaLam.Size = new System.Drawing.Size(167, 24);
            this.btnMenuCaLam.TabIndex = 1;
            this.btnMenuCaLam.Text = "THÔNG TIN CA LÀM";
            this.btnMenuCaLam.UseVisualStyleBackColor = true;
            this.btnMenuCaLam.Click += new System.EventHandler(this.btnMenuCaLam_Click);
            // 
            // UC_MenuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuCaLam);
            this.Controls.Add(this.btnMenuThongTinNV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_MenuNhanVien";
            this.Size = new System.Drawing.Size(745, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuThongTinNV;
        private System.Windows.Forms.Button btnMenuCaLam;
    }
}
