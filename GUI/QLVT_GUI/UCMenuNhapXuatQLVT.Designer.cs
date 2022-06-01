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
            this.btnMenuListNXVatTu = new System.Windows.Forms.Button();
            this.btnMenuListNXThucAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuListNXVatTu
            // 
            this.btnMenuListNXVatTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.btnMenuListNXVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuListNXVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuListNXVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuListNXVatTu.Location = new System.Drawing.Point(373, 0);
            this.btnMenuListNXVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuListNXVatTu.Name = "btnMenuListNXVatTu";
            this.btnMenuListNXVatTu.Size = new System.Drawing.Size(361, 30);
            this.btnMenuListNXVatTu.TabIndex = 7;
            this.btnMenuListNXVatTu.Text = "DANH SÁCH PHIẾU NHẬP/XUẤT VẬT TƯ";
            this.btnMenuListNXVatTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuListNXVatTu.UseVisualStyleBackColor = false;
            this.btnMenuListNXVatTu.Click += new System.EventHandler(this.btnMenuListNXVatTu_Click);
            // 
            // btnMenuListNXThucAn
            // 
            this.btnMenuListNXThucAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnMenuListNXThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuListNXThucAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuListNXThucAn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuListNXThucAn.Location = new System.Drawing.Point(0, 0);
            this.btnMenuListNXThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuListNXThucAn.Name = "btnMenuListNXThucAn";
            this.btnMenuListNXThucAn.Size = new System.Drawing.Size(373, 34);
            this.btnMenuListNXThucAn.TabIndex = 6;
            this.btnMenuListNXThucAn.Text = "DANH SÁCH PHIẾU NHẬP/XUẤT THỨC ĂN";
            this.btnMenuListNXThucAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuListNXThucAn.UseVisualStyleBackColor = false;
            this.btnMenuListNXThucAn.Click += new System.EventHandler(this.btnMenuListNXThucAn_Click);
            // 
            // UCMenuNhapXuatQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnMenuListNXVatTu);
            this.Controls.Add(this.btnMenuListNXThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCMenuNhapXuatQLVT";
            this.Size = new System.Drawing.Size(993, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuListNXVatTu;
        public System.Windows.Forms.Button btnMenuListNXThucAn;
    }
}
