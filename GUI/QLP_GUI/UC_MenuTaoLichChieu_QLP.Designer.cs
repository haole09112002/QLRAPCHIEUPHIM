namespace GUI.QLP_GUI
{
    partial class UC_MenuTaoLichChieu_QLP
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
            this.btnTaoLichChieu = new System.Windows.Forms.Button();
            this.btnLichChieuDuKien = new System.Windows.Forms.Button();
            this.btnLichChieuChinhThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoLichChieu
            // 
            this.btnTaoLichChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.btnTaoLichChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoLichChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoLichChieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTaoLichChieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTaoLichChieu.Location = new System.Drawing.Point(0, 0);
            this.btnTaoLichChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoLichChieu.Name = "btnTaoLichChieu";
            this.btnTaoLichChieu.Size = new System.Drawing.Size(250, 30);
            this.btnTaoLichChieu.TabIndex = 0;
            this.btnTaoLichChieu.Text = "TẠO LỊCH CHIẾU";
            this.btnTaoLichChieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoLichChieu.UseVisualStyleBackColor = false;
            this.btnTaoLichChieu.Click += new System.EventHandler(this.btnTaoLC_Click);
            // 
            // btnLichChieuDuKien
            // 
            this.btnLichChieuDuKien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.btnLichChieuDuKien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichChieuDuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichChieuDuKien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLichChieuDuKien.Location = new System.Drawing.Point(250, 0);
            this.btnLichChieuDuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichChieuDuKien.Name = "btnLichChieuDuKien";
            this.btnLichChieuDuKien.Size = new System.Drawing.Size(322, 30);
            this.btnLichChieuDuKien.TabIndex = 1;
            this.btnLichChieuDuKien.Text = "LỊCH CHIẾU DỰ KIẾN";
            this.btnLichChieuDuKien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichChieuDuKien.UseVisualStyleBackColor = false;
            this.btnLichChieuDuKien.Click += new System.EventHandler(this.btLCDuKien_Click);
            // 
            // btnLichChieuChinhThuc
            // 
            this.btnLichChieuChinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.btnLichChieuChinhThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichChieuChinhThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichChieuChinhThuc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLichChieuChinhThuc.Location = new System.Drawing.Point(572, 0);
            this.btnLichChieuChinhThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichChieuChinhThuc.Name = "btnLichChieuChinhThuc";
            this.btnLichChieuChinhThuc.Size = new System.Drawing.Size(276, 30);
            this.btnLichChieuChinhThuc.TabIndex = 3;
            this.btnLichChieuChinhThuc.Text = "LỊCH CHIẾU CHÍNH THỨC";
            this.btnLichChieuChinhThuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichChieuChinhThuc.UseVisualStyleBackColor = false;
            this.btnLichChieuChinhThuc.Click += new System.EventHandler(this.btnLCChinhThuc_Click);
            // 
            // UC_MenuTaoLichChieu_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnLichChieuChinhThuc);
            this.Controls.Add(this.btnLichChieuDuKien);
            this.Controls.Add(this.btnTaoLichChieu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_MenuTaoLichChieu_QLP";
            this.Size = new System.Drawing.Size(1185, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnTaoLichChieu;
        private System.Windows.Forms.Button btnLichChieuDuKien;
        private System.Windows.Forms.Button btnLichChieuChinhThuc;
    }
}
