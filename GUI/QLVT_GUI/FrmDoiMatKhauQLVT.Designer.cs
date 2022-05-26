namespace GUI.QLVT_GUI
{
    partial class FrmDoiMatKhauQLVT
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnDoiMatKhau = new System.Windows.Forms.Panel();
            this.pnContentDoiMatKhau = new System.Windows.Forms.Panel();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.pnTitleDoiMatKhau = new System.Windows.Forms.Panel();
            this.lblTitleDoiMatKhau = new System.Windows.Forms.Label();
            this.lblValidatedXacNhanMK = new System.Windows.Forms.Label();
            this.lblValidatedMatKhauCu = new System.Windows.Forms.Label();
            this.pnDoiMatKhau.SuspendLayout();
            this.pnContentDoiMatKhau.SuspendLayout();
            this.pnTitleDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDoiMatKhau
            // 
            this.pnDoiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDoiMatKhau.Controls.Add(this.pnContentDoiMatKhau);
            this.pnDoiMatKhau.Controls.Add(this.pnTitleDoiMatKhau);
            this.pnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.pnDoiMatKhau.Name = "pnDoiMatKhau";
            this.pnDoiMatKhau.Size = new System.Drawing.Size(711, 360);
            this.pnDoiMatKhau.TabIndex = 0;
            // 
            // pnContentDoiMatKhau
            // 
            this.pnContentDoiMatKhau.Controls.Add(this.lblValidatedMatKhauCu);
            this.pnContentDoiMatKhau.Controls.Add(this.lblValidatedXacNhanMK);
            this.pnContentDoiMatKhau.Controls.Add(this.lblXacNhanMatKhau);
            this.pnContentDoiMatKhau.Controls.Add(this.lblMatKhauMoi);
            this.pnContentDoiMatKhau.Controls.Add(this.lblMatKhauCu);
            this.pnContentDoiMatKhau.Controls.Add(this.btnThoat);
            this.pnContentDoiMatKhau.Controls.Add(this.btnLuu);
            this.pnContentDoiMatKhau.Controls.Add(this.txtXacNhanMatKhau);
            this.pnContentDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.pnContentDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.pnContentDoiMatKhau.Location = new System.Drawing.Point(11, 62);
            this.pnContentDoiMatKhau.Name = "pnContentDoiMatKhau";
            this.pnContentDoiMatKhau.Size = new System.Drawing.Size(687, 270);
            this.pnContentDoiMatKhau.TabIndex = 52;
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhanMatKhau.Image = global::GUI.Properties.Resources.Security;
            this.lblXacNhanMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(11, 129);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(250, 29);
            this.lblXacNhanMatKhau.TabIndex = 60;
            this.lblXacNhanMatKhau.Text = "XÁC NHẬN LẠI MẬT KHẨU";
            this.lblXacNhanMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.Image = global::GUI.Properties.Resources.Security;
            this.lblMatKhauMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(11, 74);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(170, 29);
            this.lblMatKhauMoi.TabIndex = 59;
            this.lblMatKhauMoi.Text = "MẬT KHẨU MỚI";
            this.lblMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauCu.Image = global::GUI.Properties.Resources.Security;
            this.lblMatKhauCu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMatKhauCu.Location = new System.Drawing.Point(11, 19);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(170, 29);
            this.lblMatKhauCu.TabIndex = 58;
            this.lblMatKhauCu.Text = "MẬT KHẨU CŨ";
            this.lblMatKhauCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.Logout_26px;
            this.btnThoat.Location = new System.Drawing.Point(77, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 36);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.save_26px;
            this.btnLuu.Location = new System.Drawing.Point(472, 215);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 36);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(290, 134);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(364, 22);
            this.txtXacNhanMatKhau.TabIndex = 55;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            this.txtXacNhanMatKhau.TextChanged += new System.EventHandler(this.txtMatKhauCu_TextChanged);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(290, 80);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(364, 22);
            this.txtMatKhauMoi.TabIndex = 54;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.txtMatKhauCu_TextChanged);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMatKhauCu.Location = new System.Drawing.Point(290, 26);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(364, 22);
            this.txtMatKhauCu.TabIndex = 53;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.TextChanged += new System.EventHandler(this.txtMatKhauCu_TextChanged);
            // 
            // pnTitleDoiMatKhau
            // 
            this.pnTitleDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnTitleDoiMatKhau.Controls.Add(this.lblTitleDoiMatKhau);
            this.pnTitleDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.pnTitleDoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitleDoiMatKhau.Name = "pnTitleDoiMatKhau";
            this.pnTitleDoiMatKhau.Size = new System.Drawing.Size(709, 35);
            this.pnTitleDoiMatKhau.TabIndex = 51;
            // 
            // lblTitleDoiMatKhau
            // 
            this.lblTitleDoiMatKhau.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleDoiMatKhau.Image = global::GUI.Properties.Resources.Password;
            this.lblTitleDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleDoiMatKhau.Location = new System.Drawing.Point(248, 6);
            this.lblTitleDoiMatKhau.Name = "lblTitleDoiMatKhau";
            this.lblTitleDoiMatKhau.Size = new System.Drawing.Size(185, 27);
            this.lblTitleDoiMatKhau.TabIndex = 0;
            this.lblTitleDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.lblTitleDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValidatedXacNhanMK
            // 
            this.lblValidatedXacNhanMK.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidatedXacNhanMK.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedXacNhanMK.ForeColor = System.Drawing.Color.Red;
            this.lblValidatedXacNhanMK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidatedXacNhanMK.Location = new System.Drawing.Point(306, 167);
            this.lblValidatedXacNhanMK.Name = "lblValidatedXacNhanMK";
            this.lblValidatedXacNhanMK.Size = new System.Drawing.Size(331, 20);
            this.lblValidatedXacNhanMK.TabIndex = 61;
            this.lblValidatedXacNhanMK.Text = "*Mật khẩu xác nhận không trùng khớp";
            this.lblValidatedXacNhanMK.Visible = false;
            // 
            // lblValidatedMatKhauCu
            // 
            this.lblValidatedMatKhauCu.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidatedMatKhauCu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedMatKhauCu.ForeColor = System.Drawing.Color.Red;
            this.lblValidatedMatKhauCu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidatedMatKhauCu.Location = new System.Drawing.Point(306, 50);
            this.lblValidatedMatKhauCu.Name = "lblValidatedMatKhauCu";
            this.lblValidatedMatKhauCu.Size = new System.Drawing.Size(270, 20);
            this.lblValidatedMatKhauCu.TabIndex = 62;
            this.lblValidatedMatKhauCu.Text = "*Mật khẩu cũ không chính xác!";
            this.lblValidatedMatKhauCu.Visible = false;
            // 
            // FrmDoiMatKhauQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.pnDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoiMatKhauQLVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoiMatKhauQLVT";
            this.pnDoiMatKhau.ResumeLayout(false);
            this.pnContentDoiMatKhau.ResumeLayout(false);
            this.pnContentDoiMatKhau.PerformLayout();
            this.pnTitleDoiMatKhau.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDoiMatKhau;
        private System.Windows.Forms.Panel pnContentDoiMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Panel pnTitleDoiMatKhau;
        private System.Windows.Forms.Label lblTitleDoiMatKhau;
        private System.Windows.Forms.Label lblValidatedXacNhanMK;
        private System.Windows.Forms.Label lblValidatedMatKhauCu;
    }
}