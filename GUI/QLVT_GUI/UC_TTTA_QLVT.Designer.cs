namespace GUI.QLVT_GUI
{
    partial class UC_TTTA_QLVT
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGVDanhSachPhim = new System.Windows.Forms.DataGridView();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.btnXoaPhim = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thức Ăn Nhanh";
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(38, 78);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(916, 384);
            this.dGVDanhSachPhim.TabIndex = 1;
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(124, 514);
            this.btnThemPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(95, 27);
            this.btnThemPhim.TabIndex = 2;
            this.btnThemPhim.Text = "Thêm Phim";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Location = new System.Drawing.Point(468, 514);
            this.btnXoaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(95, 27);
            this.btnXoaPhim.TabIndex = 3;
            this.btnXoaPhim.Text = "Xóa Phim";
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(772, 514);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(95, 27);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(643, 32);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 27);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiém";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(743, 32);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 30);
            this.txtTimKiem.TabIndex = 6;
            // 
            // UC_TTTA_QLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoaPhim);
            this.Controls.Add(this.btnThemPhim);
            this.Controls.Add(this.dGVDanhSachPhim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TTTA_QLVT";
            this.Size = new System.Drawing.Size(993, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
