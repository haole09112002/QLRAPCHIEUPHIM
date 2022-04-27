namespace GUI.QLVT_GUI
{
    partial class UCThongTinThucAnQLVT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::GUI.Properties.Resources.FoodTitleDeXuat;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(325, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thức Ăn Nhanh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(19, 98);
            this.dGVDanhSachPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(916, 384);
            this.dGVDanhSachPhim.TabIndex = 1;
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(68, 519);
            this.btnThemPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(122, 27);
            this.btnThemPhim.TabIndex = 2;
            this.btnThemPhim.Text = "Thêm Thức Ăn";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Location = new System.Drawing.Point(403, 519);
            this.btnXoaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(95, 27);
            this.btnXoaPhim.TabIndex = 3;
            this.btnXoaPhim.Text = "Xóa Thức Ăn";
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(744, 519);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(95, 27);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.Text = "Cập Nhật";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(840, 62);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 27);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(611, 60);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 30);
            this.txtTimKiem.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.dGVDanhSachPhim);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnThemPhim);
            this.panel1.Controls.Add(this.btnChinhSua);
            this.panel1.Controls.Add(this.btnXoaPhim);
            this.panel1.Location = new System.Drawing.Point(16, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 558);
            this.panel1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sắp Xếp";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCThongTinThucAnQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCThongTinThucAnQLVT";
            this.Size = new System.Drawing.Size(993, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVDanhSachPhim;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}
