namespace GUI.QLP_GUI
{
    partial class UC_MenuNXK_QLP
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
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnLSNX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTaoPhieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaoPhieu.Image = global::GUI.Properties.Resources.dexuat;
            this.btnTaoPhieu.Location = new System.Drawing.Point(0, 0);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(258, 36);
            this.btnTaoPhieu.TabIndex = 0;
            this.btnTaoPhieu.Text = "    Tạo Phiếu";
            this.btnTaoPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // btnLSNX
            // 
            this.btnLSNX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLSNX.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLSNX.Image = global::GUI.Properties.Resources.kho;
            this.btnLSNX.Location = new System.Drawing.Point(258, 0);
            this.btnLSNX.Name = "btnLSNX";
            this.btnLSNX.Size = new System.Drawing.Size(333, 36);
            this.btnLSNX.TabIndex = 1;
            this.btnLSNX.Text = "    Danh Sách Phiếu Nhập Xuất";
            this.btnLSNX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLSNX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLSNX.UseVisualStyleBackColor = false;
            this.btnLSNX.Click += new System.EventHandler(this.btnLSNX_Click);
            // 
            // UC_MenuNXK_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnLSNX);
            this.Controls.Add(this.btnTaoPhieu);
            this.Name = "UC_MenuNXK_QLP";
            this.Size = new System.Drawing.Size(1117, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnLSNX;
    }
}
