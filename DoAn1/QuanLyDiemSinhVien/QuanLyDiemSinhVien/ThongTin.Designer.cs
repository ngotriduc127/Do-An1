namespace QuanLyDiemSinhVien
{
    partial class ThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTin));
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnNganh = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.ucNganh1 = new QuanLyDiemSinhVien.ucNganh();
            this.ucMonHoc1 = new QuanLyDiemSinhVien.ucMonHoc();
            this.ucLop1 = new QuanLyDiemSinhVien.ucLop();
            this.ucSinhVien1 = new QuanLyDiemSinhVien.ucSinhVien();
            this.ucGiaoVien1 = new QuanLyDiemSinhVien.ucGiaoVien();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnButton.Controls.Add(this.btnNganh);
            this.pnButton.Controls.Add(this.btnLop);
            this.pnButton.Controls.Add(this.btnSinhVien);
            this.pnButton.Controls.Add(this.btnMonhoc);
            this.pnButton.Controls.Add(this.btnGiaoVien);
            this.pnButton.Location = new System.Drawing.Point(-2, 0);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(255, 822);
            this.pnButton.TabIndex = 2;
            // 
            // btnNganh
            // 
            this.btnNganh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNganh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNganh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganh.ForeColor = System.Drawing.Color.Red;
            this.btnNganh.Location = new System.Drawing.Point(0, 620);
            this.btnNganh.Name = "btnNganh";
            this.btnNganh.Size = new System.Drawing.Size(252, 114);
            this.btnNganh.TabIndex = 3;
            this.btnNganh.Text = "Ngành";
            this.btnNganh.UseVisualStyleBackColor = false;
            this.btnNganh.Click += new System.EventHandler(this.btnNganh_Click);
            // 
            // btnLop
            // 
            this.btnLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLop.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Red;
            this.btnLop.Location = new System.Drawing.Point(-6, 324);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(261, 129);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = false;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSinhVien.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.Red;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 0);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(255, 140);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMonhoc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMonhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonhoc.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonhoc.ForeColor = System.Drawing.Color.Red;
            this.btnMonhoc.Location = new System.Drawing.Point(0, 474);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.Size = new System.Drawing.Size(255, 125);
            this.btnMonhoc.TabIndex = 4;
            this.btnMonhoc.Text = "Môn Học";
            this.btnMonhoc.UseVisualStyleBackColor = false;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiaoVien.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVien.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Red;
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 162);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(255, 140);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // ucNganh1
            // 
            this.ucNganh1.BackColor = System.Drawing.Color.Teal;
            this.ucNganh1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucNganh1.BackgroundImage")));
            this.ucNganh1.Location = new System.Drawing.Point(249, 0);
            this.ucNganh1.Name = "ucNganh1";
            this.ucNganh1.Size = new System.Drawing.Size(1297, 860);
            this.ucNganh1.TabIndex = 5;
            // 
            // ucMonHoc1
            // 
            this.ucMonHoc1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucMonHoc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMonHoc1.BackgroundImage")));
            this.ucMonHoc1.Location = new System.Drawing.Point(249, 0);
            this.ucMonHoc1.Name = "ucMonHoc1";
            this.ucMonHoc1.Size = new System.Drawing.Size(1297, 860);
            this.ucMonHoc1.TabIndex = 6;
            // 
            // ucLop1
            // 
            this.ucLop1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucLop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLop1.BackgroundImage")));
            this.ucLop1.Location = new System.Drawing.Point(249, 0);
            this.ucLop1.Name = "ucLop1";
            this.ucLop1.Size = new System.Drawing.Size(1297, 860);
            this.ucLop1.TabIndex = 5;
            // 
            // ucSinhVien1
            // 
            this.ucSinhVien1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucSinhVien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucSinhVien1.BackgroundImage")));
            this.ucSinhVien1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucSinhVien1.Location = new System.Drawing.Point(249, 0);
            this.ucSinhVien1.Name = "ucSinhVien1";
            this.ucSinhVien1.Size = new System.Drawing.Size(1297, 860);
            this.ucSinhVien1.TabIndex = 3;
            // 
            // ucGiaoVien1
            // 
            this.ucGiaoVien1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucGiaoVien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucGiaoVien1.BackgroundImage")));
            this.ucGiaoVien1.Location = new System.Drawing.Point(249, 0);
            this.ucGiaoVien1.Name = "ucGiaoVien1";
            this.ucGiaoVien1.Size = new System.Drawing.Size(1297, 860);
            this.ucGiaoVien1.TabIndex = 4;
            this.ucGiaoVien1.Load += new System.EventHandler(this.ucGiaoVien1_Load);
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1362, 733);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.ucNganh1);
            this.Controls.Add(this.ucMonHoc1);
            this.Controls.Add(this.ucLop1);
            this.Controls.Add(this.ucSinhVien1);
            this.Controls.Add(this.ucGiaoVien1);
            this.Name = "ThongTin";
            this.Text = "ThongTin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThongTin_Load);
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnMonhoc;
        private System.Windows.Forms.Button btnNganh;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnSinhVien;
        private ucSinhVien ucSinhVien1;
        private ucGiaoVien ucGiaoVien1;
        private ucLop ucLop1;
        private ucMonHoc ucMonHoc1;
        private ucNganh ucNganh1;
    }
}