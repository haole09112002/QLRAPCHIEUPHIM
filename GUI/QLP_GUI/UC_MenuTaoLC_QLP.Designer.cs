namespace GUI.QLP_GUI
{
    partial class UC_MenuTaoLC_QLP
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
            this.btnTaoLC = new System.Windows.Forms.Button();
            this.btLCDuKien = new System.Windows.Forms.Button();
            this.btnLCChinhThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoLC
            // 
            this.btnTaoLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTaoLC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaoLC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTaoLC.Image = global::GUI.Properties.Resources.lichchieu;
            this.btnTaoLC.Location = new System.Drawing.Point(0, 0);
            this.btnTaoLC.Name = "btnTaoLC";
            this.btnTaoLC.Size = new System.Drawing.Size(364, 36);
            this.btnTaoLC.TabIndex = 0;
            this.btnTaoLC.Text = "    Tạo Lịch Chiếu";
            this.btnTaoLC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoLC.UseVisualStyleBackColor = false;
            this.btnTaoLC.Click += new System.EventHandler(this.btnTaoLC_Click);
            // 
            // btLCDuKien
            // 
            this.btLCDuKien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLCDuKien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btLCDuKien.Image = global::GUI.Properties.Resources.dexuat;
            this.btLCDuKien.Location = new System.Drawing.Point(364, 0);
            this.btLCDuKien.Name = "btLCDuKien";
            this.btLCDuKien.Size = new System.Drawing.Size(362, 36);
            this.btLCDuKien.TabIndex = 1;
            this.btLCDuKien.Text = "     Lịch Chiếu Dự Kiến";
            this.btLCDuKien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLCDuKien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLCDuKien.UseVisualStyleBackColor = false;
            this.btLCDuKien.Click += new System.EventHandler(this.btLCDuKien_Click);
            // 
            // btnLCChinhThuc
            // 
            this.btnLCChinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLCChinhThuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLCChinhThuc.Image = global::GUI.Properties.Resources.dexuat;
            this.btnLCChinhThuc.Location = new System.Drawing.Point(726, 0);
            this.btnLCChinhThuc.Name = "btnLCChinhThuc";
            this.btnLCChinhThuc.Size = new System.Drawing.Size(391, 36);
            this.btnLCChinhThuc.TabIndex = 3;
            this.btnLCChinhThuc.Text = "    Lịch Chiếu Chính Thức";
            this.btnLCChinhThuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLCChinhThuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLCChinhThuc.UseVisualStyleBackColor = false;
            this.btnLCChinhThuc.Click += new System.EventHandler(this.btnLCChinhThuc_Click);
            // 
            // UC_MenuTaoLC_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnLCChinhThuc);
            this.Controls.Add(this.btLCDuKien);
            this.Controls.Add(this.btnTaoLC);
            this.Name = "UC_MenuTaoLC_QLP";
            this.Size = new System.Drawing.Size(1117, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoLC;
        private System.Windows.Forms.Button btLCDuKien;
        private System.Windows.Forms.Button btnLCChinhThuc;
    }
}
