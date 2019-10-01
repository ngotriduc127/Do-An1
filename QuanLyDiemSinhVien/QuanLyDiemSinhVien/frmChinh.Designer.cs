namespace QuanLyDiemSinhVien
{
    partial class frmChinh
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
            this.pnShowUC = new System.Windows.Forms.Panel();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.ucNhapDiem1 = new QuanLyDiemSinhVien.ucNhapDiem();
            this.ucChinh_DangKy1 = new QuanLyDiemSinhVien.ucChinh_DangKy();
            this.ucChinh1 = new QuanLyDiemSinhVien.ucChinh();
            this.ucXemDiem1 = new QuanLyDiemSinhVien.ucXemDiem();
            this.pnShowUC.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShowUC
            // 
            this.pnShowUC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnShowUC.Controls.Add(this.lbTieuDe);
            this.pnShowUC.Controls.Add(this.ucChinh_DangKy1);
            this.pnShowUC.Controls.Add(this.ucChinh1);
            this.pnShowUC.Controls.Add(this.ucXemDiem1);
            this.pnShowUC.Controls.Add(this.ucNhapDiem1);
            this.pnShowUC.Location = new System.Drawing.Point(211, 13);
            this.pnShowUC.Name = "pnShowUC";
            this.pnShowUC.Size = new System.Drawing.Size(537, 425);
            this.pnShowUC.TabIndex = 1;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Sitka Display", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(13, 109);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(517, 138);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Chương Trình \r\nQuản Lý Điểm Sinh Viên";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.Goldenrod;
            this.pnButton.Controls.Add(this.btnThongTin);
            this.pnButton.Controls.Add(this.btnThoat);
            this.pnButton.Controls.Add(this.btnXemDiem);
            this.pnButton.Controls.Add(this.btnNhapDiem);
            this.pnButton.Controls.Add(this.btnDangNhap);
            this.pnButton.Location = new System.Drawing.Point(13, 13);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(192, 425);
            this.pnButton.TabIndex = 0;
            // 
            // btnThongTin
            // 
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.Red;
            this.btnThongTin.Location = new System.Drawing.Point(4, 246);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(188, 65);
            this.btnThongTin.TabIndex = 4;
            this.btnThongTin.Text = "THÔNG TIN";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font(".VnCentury Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(7, 317);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(185, 65);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Font = new System.Drawing.Font(".VnCentury Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.ForeColor = System.Drawing.Color.Red;
            this.btnXemDiem.Location = new System.Drawing.Point(7, 174);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(185, 66);
            this.btnXemDiem.TabIndex = 2;
            this.btnXemDiem.Text = "XEM ĐIỂM";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Font = new System.Drawing.Font(".VnCentury Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ForeColor = System.Drawing.Color.Red;
            this.btnNhapDiem.Location = new System.Drawing.Point(7, 109);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(185, 59);
            this.btnNhapDiem.TabIndex = 1;
            this.btnNhapDiem.Text = "NHẬP ĐIỂM";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font(".VnCentury Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Red;
            this.btnDangNhap.Location = new System.Drawing.Point(4, 37);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(188, 66);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ucNhapDiem1
            // 
            this.ucNhapDiem1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ucNhapDiem1.Location = new System.Drawing.Point(-1, 8);
            this.ucNhapDiem1.Name = "ucNhapDiem1";
            this.ucNhapDiem1.Size = new System.Drawing.Size(538, 417);
            this.ucNhapDiem1.TabIndex = 4;
            // 
            // ucChinh_DangKy1
            // 
            this.ucChinh_DangKy1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucChinh_DangKy1.Location = new System.Drawing.Point(5, 3);
            this.ucChinh_DangKy1.Name = "ucChinh_DangKy1";
            this.ucChinh_DangKy1.Size = new System.Drawing.Size(532, 420);
            this.ucChinh_DangKy1.TabIndex = 3;
            // 
            // ucChinh1
            // 
            this.ucChinh1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucChinh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucChinh1.ForeColor = System.Drawing.Color.Red;
            this.ucChinh1.Location = new System.Drawing.Point(0, 2);
            this.ucChinh1.Name = "ucChinh1";
            this.ucChinh1.Size = new System.Drawing.Size(534, 420);
            this.ucChinh1.TabIndex = 2;
            // 
            // ucXemDiem1
            // 
            this.ucXemDiem1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucXemDiem1.Location = new System.Drawing.Point(0, 3);
            this.ucXemDiem1.Name = "ucXemDiem1";
            this.ucXemDiem1.Size = new System.Drawing.Size(537, 420);
            this.ucXemDiem1.TabIndex = 5;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.pnShowUC);
            this.Controls.Add(this.pnButton);
            this.Name = "frmChinh";
            this.Text = "Quản Lý Điểm Sinh Viên";
            this.pnShowUC.ResumeLayout(false);
            this.pnShowUC.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel pnShowUC;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btnThoat;
        private ucChinh ucChinh1;
        private ucChinh_DangKy ucChinh_DangKy1;
        private ucNhapDiem ucNhapDiem1;
        private System.Windows.Forms.Button btnThongTin;
        private ucXemDiem ucXemDiem1;
    }
}