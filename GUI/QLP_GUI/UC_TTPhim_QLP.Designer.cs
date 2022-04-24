namespace GUI.QLP_GUI
{
    partial class UC_TTPhim_QLP
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
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Phim";
            // 
            // dGVDanhSachPhim
            // 
            this.dGVDanhSachPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhim.Location = new System.Drawing.Point(43, 97);
            this.dGVDanhSachPhim.Name = "dGVDanhSachPhim";
            this.dGVDanhSachPhim.RowHeadersWidth = 62;
            this.dGVDanhSachPhim.RowTemplate.Height = 28;
            this.dGVDanhSachPhim.Size = new System.Drawing.Size(1031, 480);
            this.dGVDanhSachPhim.TabIndex = 1;
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(140, 643);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(107, 34);
            this.btnThemPhim.TabIndex = 2;
            this.btnThemPhim.Text = "Thêm Phim";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Location = new System.Drawing.Point(526, 643);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(107, 34);
            this.btnXoaPhim.TabIndex = 3;
            this.btnXoaPhim.Text = "Xóa Phim";
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(868, 643);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(107, 34);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(723, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 34);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiém";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(836, 40);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(238, 35);
            this.txtTimKiem.TabIndex = 6;
            // 
            // UC_TTPhim_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoaPhim);
            this.Controls.Add(this.btnThemPhim);
            this.Controls.Add(this.dGVDanhSachPhim);
            this.Controls.Add(this.label1);
            this.Name = "UC_TTPhim_QLP";
            this.Size = new System.Drawing.Size(1117, 766);
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
