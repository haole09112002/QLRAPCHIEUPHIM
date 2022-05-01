namespace GUI.QLVT_GUI
{
    partial class UCMenuSanPhamQLVT
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
            this.btnMenuListTTVatTu = new System.Windows.Forms.Button();
            this.btnMenuListTTThucAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuListTTVatTu
            // 
            this.btnMenuListTTVatTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.btnMenuListTTVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuListTTVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuListTTVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuListTTVatTu.Location = new System.Drawing.Point(350, 0);
            this.btnMenuListTTVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuListTTVatTu.Name = "btnMenuListTTVatTu";
            this.btnMenuListTTVatTu.Size = new System.Drawing.Size(341, 29);
            this.btnMenuListTTVatTu.TabIndex = 7;
            this.btnMenuListTTVatTu.Text = "DANH SÁCH THÔNG TIN VẬT TƯ";
            this.btnMenuListTTVatTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuListTTVatTu.UseVisualStyleBackColor = false;
            this.btnMenuListTTVatTu.Click += new System.EventHandler(this.btnMenuListTTVatTu_Click);
            // 
            // btnMenuListTTThucAn
            // 
            this.btnMenuListTTThucAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnMenuListTTThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuListTTThucAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuListTTThucAn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuListTTThucAn.Location = new System.Drawing.Point(0, 0);
            this.btnMenuListTTThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuListTTThucAn.Name = "btnMenuListTTThucAn";
            this.btnMenuListTTThucAn.Size = new System.Drawing.Size(350, 29);
            this.btnMenuListTTThucAn.TabIndex = 6;
            this.btnMenuListTTThucAn.Text = "DANH SÁCH THÔNG TIN THỨC ĂN NHANH";
            this.btnMenuListTTThucAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuListTTThucAn.UseVisualStyleBackColor = false;
            this.btnMenuListTTThucAn.Click += new System.EventHandler(this.btnMenuListTTThucAn_Click);
            // 
            // UCMenuSanPhamQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuListTTVatTu);
            this.Controls.Add(this.btnMenuListTTThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCMenuSanPhamQLVT";
            this.Size = new System.Drawing.Size(993, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuListTTVatTu;
        public System.Windows.Forms.Button btnMenuListTTThucAn;
    }
}
