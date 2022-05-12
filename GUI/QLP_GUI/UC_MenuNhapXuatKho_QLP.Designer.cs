namespace GUI.QLP_GUI
{
    partial class UC_MenuNhapXuatKho_QLP
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
            this.btnDanhSachPhieuNX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnTaoPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTaoPhieu.Location = new System.Drawing.Point(0, 0);
            this.btnTaoPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(341, 30);
            this.btnTaoPhieu.TabIndex = 0;
            this.btnTaoPhieu.Text = "TẠO PHIẾU";
            this.btnTaoPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // btnDanhSachPhieuNX
            // 
            this.btnDanhSachPhieuNX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.btnDanhSachPhieuNX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhSachPhieuNX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachPhieuNX.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDanhSachPhieuNX.Location = new System.Drawing.Point(341, 0);
            this.btnDanhSachPhieuNX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhSachPhieuNX.Name = "btnDanhSachPhieuNX";
            this.btnDanhSachPhieuNX.Size = new System.Drawing.Size(407, 30);
            this.btnDanhSachPhieuNX.TabIndex = 1;
            this.btnDanhSachPhieuNX.Text = "    DANH SÁCH PHIẾU NHẬP XUẤT";
            this.btnDanhSachPhieuNX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachPhieuNX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSachPhieuNX.UseVisualStyleBackColor = false;
            this.btnDanhSachPhieuNX.Click += new System.EventHandler(this.btnLSNX_Click);
            // 
            // UC_MenuNhapXuatKho_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnDanhSachPhieuNX);
            this.Controls.Add(this.btnTaoPhieu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_MenuNhapXuatKho_QLP";
            this.Size = new System.Drawing.Size(1333, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnDanhSachPhieuNX;
    }
}
