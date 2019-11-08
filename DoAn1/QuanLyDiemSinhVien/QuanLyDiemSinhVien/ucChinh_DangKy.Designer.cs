namespace QuanLyDiemSinhVien
{
    partial class ucChinh_DangKy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtReMatKhauDK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhauDK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoanDK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDiemSinhVien.Properties.Resources.dangkiii;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1219, 856);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.BackColor = System.Drawing.Color.Chartreuse;
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.Enabled = false;
            this.cbbChucVu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucVu.Items.AddRange(new object[] {
            "Sinh Viên",
            "Giáo Viên",
            "Hiệu Trưởng",
            "Chức Vụ",
            "--------"});
            this.cbbChucVu.Location = new System.Drawing.Point(631, 475);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(180, 44);
            this.cbbChucVu.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(396, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 50;
            this.label1.Text = "Chức vụ";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Snow;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.ImageKey = "1460546211_DeleteRed.ico";
            this.btnHuy.Location = new System.Drawing.Point(639, 558);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(183, 44);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "THOÁT";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_2);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnDangKy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangKy.Location = new System.Drawing.Point(424, 558);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(193, 44);
            this.btnDangKy.TabIndex = 45;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click_2);
            // 
            // txtReMatKhauDK
            // 
            this.txtReMatKhauDK.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtReMatKhauDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReMatKhauDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReMatKhauDK.ForeColor = System.Drawing.Color.Black;
            this.txtReMatKhauDK.Location = new System.Drawing.Point(631, 408);
            this.txtReMatKhauDK.Name = "txtReMatKhauDK";
            this.txtReMatKhauDK.PasswordChar = '*';
            this.txtReMatKhauDK.Size = new System.Drawing.Size(180, 44);
            this.txtReMatKhauDK.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 42);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nhập lại";
            // 
            // txtMatKhauDK
            // 
            this.txtMatKhauDK.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtMatKhauDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauDK.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauDK.Location = new System.Drawing.Point(631, 326);
            this.txtMatKhauDK.Name = "txtMatKhauDK";
            this.txtMatKhauDK.PasswordChar = '*';
            this.txtMatKhauDK.Size = new System.Drawing.Size(180, 44);
            this.txtMatKhauDK.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(396, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 42);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtTaiKhoanDK
            // 
            this.txtTaiKhoanDK.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTaiKhoanDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoanDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoanDK.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoanDK.Location = new System.Drawing.Point(631, 254);
            this.txtTaiKhoanDK.Name = "txtTaiKhoanDK";
            this.txtTaiKhoanDK.Size = new System.Drawing.Size(180, 44);
            this.txtTaiKhoanDK.TabIndex = 42;
            this.txtTaiKhoanDK.TextChanged += new System.EventHandler(this.txtTaiKhoanDK_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(396, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 42);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tài Khoản";
            // 
            // ucChinh_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtReMatKhauDK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatKhauDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaiKhoanDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucChinh_DangKy";
            this.Size = new System.Drawing.Size(1219, 856);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtReMatKhauDK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatKhauDK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoanDK;
        private System.Windows.Forms.Label label4;
    }
}
