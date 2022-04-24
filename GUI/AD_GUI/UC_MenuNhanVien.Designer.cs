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
            this.btnMenuNV = new System.Windows.Forms.Button();
            this.btnMenuCaLam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuNV
            // 
            this.btnMenuNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuNV.Location = new System.Drawing.Point(92, 0);
            this.btnMenuNV.Name = "btnMenuNV";
            this.btnMenuNV.Size = new System.Drawing.Size(223, 29);
            this.btnMenuNV.TabIndex = 0;
            this.btnMenuNV.Text = "THÔNG TIN NHÂN VIÊN";
            this.btnMenuNV.UseVisualStyleBackColor = true;
            // 
            // btnMenuCaLam
            // 
            this.btnMenuCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCaLam.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCaLam.Location = new System.Drawing.Point(357, 0);
            this.btnMenuCaLam.Name = "btnMenuCaLam";
            this.btnMenuCaLam.Size = new System.Drawing.Size(223, 29);
            this.btnMenuCaLam.TabIndex = 1;
            this.btnMenuCaLam.Text = "THÔNG TIN CA LÀM";
            this.btnMenuCaLam.UseVisualStyleBackColor = true;
            // 
            // UC_MenuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuCaLam);
            this.Controls.Add(this.btnMenuNV);
            this.Name = "UC_MenuNhanVien";
            this.Size = new System.Drawing.Size(993, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuNV;
        private System.Windows.Forms.Button btnMenuCaLam;
    }
}
