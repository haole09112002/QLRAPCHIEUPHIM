namespace GUI.QLVT_GUI
{
    partial class UCMenuDeXuatQLVT
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
            this.btnMenuListDXVatTu = new System.Windows.Forms.Button();
            this.btnMenuListDXThucAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuListDXVatTu
            // 
            this.btnMenuListDXVatTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.btnMenuListDXVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuListDXVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuListDXVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuListDXVatTu.Location = new System.Drawing.Point(350, 0);
            this.btnMenuListDXVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuListDXVatTu.Name = "btnMenuListDXVatTu";
            this.btnMenuListDXVatTu.Size = new System.Drawing.Size(341, 29);
            this.btnMenuListDXVatTu.TabIndex = 3;
            this.btnMenuListDXVatTu.Text = "DANH SÁCH ĐỀ XUẤT VẬT TƯ";
            this.btnMenuListDXVatTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuListDXVatTu.UseVisualStyleBackColor = false;
            this.btnMenuListDXVatTu.Click += new System.EventHandler(this.btnMenuListDXVatTu_Click);
            // 
            // btnMenuListDXThucAn
            // 
            this.btnMenuListDXThucAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnMenuListDXThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuListDXThucAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuListDXThucAn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuListDXThucAn.Location = new System.Drawing.Point(0, 0);
            this.btnMenuListDXThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuListDXThucAn.Name = "btnMenuListDXThucAn";
            this.btnMenuListDXThucAn.Size = new System.Drawing.Size(350, 29);
            this.btnMenuListDXThucAn.TabIndex = 2;
            this.btnMenuListDXThucAn.Text = "DANH SÁCH ĐỀ XUẤT THỨC ĂN";
            this.btnMenuListDXThucAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuListDXThucAn.UseVisualStyleBackColor = false;
            this.btnMenuListDXThucAn.Click += new System.EventHandler(this.btnMenuListDXThucAn_Click);
            // 
            // UCMenuDeXuatQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuListDXVatTu);
            this.Controls.Add(this.btnMenuListDXThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCMenuDeXuatQLVT";
            this.Size = new System.Drawing.Size(993, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuListDXVatTu;
        public System.Windows.Forms.Button btnMenuListDXThucAn;
    }
}
