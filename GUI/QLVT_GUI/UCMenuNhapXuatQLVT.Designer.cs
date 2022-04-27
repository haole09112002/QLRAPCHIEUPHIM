namespace GUI.QLVT_GUI
{
    partial class UCMenuNhapXuatQLVT
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
            this.btnTaoDeXuat = new System.Windows.Forms.Button();
            this.btnDSDXP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoDeXuat
            // 
            this.btnTaoDeXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTaoDeXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaoDeXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoDeXuat.ForeColor = System.Drawing.Color.Black;
            this.btnTaoDeXuat.Image = global::GUI.Properties.Resources.SubMenuFood;
            this.btnTaoDeXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoDeXuat.Location = new System.Drawing.Point(0, 0);
            this.btnTaoDeXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoDeXuat.Name = "btnTaoDeXuat";
            this.btnTaoDeXuat.Size = new System.Drawing.Size(329, 43);
            this.btnTaoDeXuat.TabIndex = 0;
            this.btnTaoDeXuat.Text = "Danh Sách Phiếu Nhập/Xuất Thức Ăn";
            this.btnTaoDeXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoDeXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDeXuat.UseVisualStyleBackColor = false;
            this.btnTaoDeXuat.Click += new System.EventHandler(this.btnTaoDeXuat_Click);
            // 
            // btnDSDXP
            // 
            this.btnDSDXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDSDXP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSDXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSDXP.ForeColor = System.Drawing.Color.Black;
            this.btnDSDXP.Image = global::GUI.Properties.Resources.TabarMaterial;
            this.btnDSDXP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSDXP.Location = new System.Drawing.Point(329, 0);
            this.btnDSDXP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSDXP.Name = "btnDSDXP";
            this.btnDSDXP.Size = new System.Drawing.Size(329, 43);
            this.btnDSDXP.TabIndex = 1;
            this.btnDSDXP.Text = "Danh Sách Phiếu Nhập/Xuất Vật Tư";
            this.btnDSDXP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSDXP.UseVisualStyleBackColor = false;
            this.btnDSDXP.Click += new System.EventHandler(this.btnDSDXP_Click);
            // 
            // UCMenuNhapXuatQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnDSDXP);
            this.Controls.Add(this.btnTaoDeXuat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCMenuNhapXuatQLVT";
            this.Size = new System.Drawing.Size(993, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoDeXuat;
        private System.Windows.Forms.Button btnDSDXP;
    }
}
