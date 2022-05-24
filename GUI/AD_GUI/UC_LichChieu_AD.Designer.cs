namespace GUI.AD_GUI
{
    partial class UC_LichChieu_AD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnKhongDongY = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.rbDK = new System.Windows.Forms.RadioButton();
            this.rbCT = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLichChieuCT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLichChieuDK = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 461);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.btnKhongDongY);
            this.groupBox3.Controls.Add(this.btnDongY);
            this.groupBox3.Controls.Add(this.rbDK);
            this.groupBox3.Controls.Add(this.rbCT);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(10, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(296, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 29);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnKhongDongY
            // 
            this.btnKhongDongY.BackColor = System.Drawing.Color.LightCoral;
            this.btnKhongDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongDongY.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongDongY.Image = global::GUI.Properties.Resources.Close;
            this.btnKhongDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhongDongY.Location = new System.Drawing.Point(130, 24);
            this.btnKhongDongY.Name = "btnKhongDongY";
            this.btnKhongDongY.Size = new System.Drawing.Size(138, 29);
            this.btnKhongDongY.TabIndex = 22;
            this.btnKhongDongY.Text = "KHÔNG ĐỒNG Ý";
            this.btnKhongDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhongDongY.UseVisualStyleBackColor = false;
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.LightGreen;
            this.btnDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongY.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Image = global::GUI.Properties.Resources.Accept;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(12, 24);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(84, 29);
            this.btnDongY.TabIndex = 21;
            this.btnDongY.Text = "ĐỒNG Ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // rbDK
            // 
            this.rbDK.AutoSize = true;
            this.rbDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDK.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDK.Location = new System.Drawing.Point(601, 34);
            this.rbDK.Margin = new System.Windows.Forms.Padding(2);
            this.rbDK.Name = "rbDK";
            this.rbDK.Size = new System.Drawing.Size(78, 21);
            this.rbDK.TabIndex = 7;
            this.rbDK.TabStop = true;
            this.rbDK.Text = "Dự kiến";
            this.rbDK.UseVisualStyleBackColor = true;
            this.rbDK.CheckedChanged += new System.EventHandler(this.rbDK_CheckedChanged);
            // 
            // rbCT
            // 
            this.rbCT.AutoSize = true;
            this.rbCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCT.Location = new System.Drawing.Point(601, 9);
            this.rbCT.Margin = new System.Windows.Forms.Padding(2);
            this.rbCT.Name = "rbCT";
            this.rbCT.Size = new System.Drawing.Size(98, 21);
            this.rbCT.TabIndex = 6;
            this.rbCT.TabStop = true;
            this.rbCT.Text = "Chính thức";
            this.rbCT.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(410, 26);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(157, 24);
            this.txtTimKiem.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLichChieuCT);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(700, 180);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LỊCH CHIẾU CHÍNH THỨC";
            // 
            // dgvLichChieuCT
            // 
            this.dgvLichChieuCT.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvLichChieuCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieuCT.Location = new System.Drawing.Point(12, 21);
            this.dgvLichChieuCT.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLichChieuCT.Name = "dgvLichChieuCT";
            this.dgvLichChieuCT.RowHeadersWidth = 51;
            this.dgvLichChieuCT.RowTemplate.Height = 24;
            this.dgvLichChieuCT.Size = new System.Drawing.Size(670, 150);
            this.dgvLichChieuCT.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLichChieuDK);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(700, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỊCH CHIẾU DỰ KIẾN";
            // 
            // dgvLichChieuDK
            // 
            this.dgvLichChieuDK.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvLichChieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieuDK.Location = new System.Drawing.Point(12, 26);
            this.dgvLichChieuDK.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLichChieuDK.Name = "dgvLichChieuDK";
            this.dgvLichChieuDK.RowHeadersWidth = 51;
            this.dgvLichChieuDK.RowTemplate.Height = 24;
            this.dgvLichChieuDK.Size = new System.Drawing.Size(670, 150);
            this.dgvLichChieuDK.TabIndex = 1;
            // 
            // UC_LichChieu_AD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LichChieu_AD";
            this.Size = new System.Drawing.Size(745, 485);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnKhongDongY;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.RadioButton rbDK;
        private System.Windows.Forms.RadioButton rbCT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLichChieuDK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLichChieuCT;
    }
}
