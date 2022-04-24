namespace GUI.QLP_GUI
{
    partial class UC_MenuDeXuat_QLP
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
            this.btnTaoDeXuat.ForeColor = System.Drawing.Color.Black;
            this.btnTaoDeXuat.Image = global::GUI.Properties.Resources.phim;
            this.btnTaoDeXuat.Location = new System.Drawing.Point(0, 0);
            this.btnTaoDeXuat.Name = "btnTaoDeXuat";
            this.btnTaoDeXuat.Size = new System.Drawing.Size(323, 36);
            this.btnTaoDeXuat.TabIndex = 0;
            this.btnTaoDeXuat.Text = "    Tạo Đề Xuất";
            this.btnTaoDeXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoDeXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDeXuat.UseVisualStyleBackColor = false;
            this.btnTaoDeXuat.Click += new System.EventHandler(this.btnTaoDeXuat_Click);
            // 
            // btnDSDXP
            // 
            this.btnDSDXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDSDXP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSDXP.ForeColor = System.Drawing.Color.Black;
            this.btnDSDXP.Image = global::GUI.Properties.Resources.dexuat;
            this.btnDSDXP.Location = new System.Drawing.Point(323, 0);
            this.btnDSDXP.Name = "btnDSDXP";
            this.btnDSDXP.Size = new System.Drawing.Size(370, 36);
            this.btnDSDXP.TabIndex = 1;
            this.btnDSDXP.Text = "    Danh Sách Phim Đã Được Đề Xuất";
            this.btnDSDXP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSDXP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSDXP.UseVisualStyleBackColor = false;
            this.btnDSDXP.Click += new System.EventHandler(this.btnDSDXP_Click);
            // 
            // UC_MenuDeXuat_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnDSDXP);
            this.Controls.Add(this.btnTaoDeXuat);
            this.Name = "UC_MenuDeXuat_QLP";
            this.Size = new System.Drawing.Size(1117, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoDeXuat;
        private System.Windows.Forms.Button btnDSDXP;
    }
}
