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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.pnButton = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhapChinh = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timerDangNhapDangXuat = new System.Windows.Forms.Timer(this.components);
            this.timerChucVuDangNhap = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityCommand3 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityConnection2 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.entityCommand4 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucChinh = new QuanLyDiemSinhVien.ucChinh();
            this.ucChinh_DangKy = new QuanLyDiemSinhVien.ucChinh_DangKy();
            this.ucDoiMatKhau = new QuanLyDiemSinhVien.ucDoiMatKhau();
            this.ucGiaoVien = new QuanLyDiemSinhVien.ucGiaoVien();
            this.ucLop = new QuanLyDiemSinhVien.ucLop();
            this.ucMonHoc = new QuanLyDiemSinhVien.ucMonHoc();
            this.ucNganh = new QuanLyDiemSinhVien.ucNganh();
            this.ucNhapDiem = new QuanLyDiemSinhVien.ucNhapDiem();
            this.ucSinhVien = new QuanLyDiemSinhVien.ucSinhVien();
            this.ucXemDiem = new QuanLyDiemSinhVien.ucXemDiem();
            this.ucTieuDe = new QuanLyDiemSinhVien.ucTieuDe();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.SkyBlue;
            this.pnButton.Controls.Add(this.pictureBox1);
            this.pnButton.Controls.Add(this.btnDangNhapChinh);
            this.pnButton.Controls.Add(this.btnNhapDiem);
            this.pnButton.Controls.Add(this.btnXemDiem);
            this.pnButton.Location = new System.Drawing.Point(1, 1);
            this.pnButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(353, 1054);
            this.pnButton.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhapChinh
            // 
            this.btnDangNhapChinh.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDangNhapChinh.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDangNhapChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhapChinh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhapChinh.ForeColor = System.Drawing.Color.Red;
            this.btnDangNhapChinh.Location = new System.Drawing.Point(0, 280);
            this.btnDangNhapChinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhapChinh.Name = "btnDangNhapChinh";
            this.btnDangNhapChinh.Size = new System.Drawing.Size(353, 127);
            this.btnDangNhapChinh.TabIndex = 0;
            this.btnDangNhapChinh.Text = "ĐĂNG NHẬP";
            this.btnDangNhapChinh.UseVisualStyleBackColor = false;
            this.btnDangNhapChinh.Click += new System.EventHandler(this.btnDangNhapChinh_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNhapDiem.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDiem.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ForeColor = System.Drawing.Color.Red;
            this.btnNhapDiem.Location = new System.Drawing.Point(4, 449);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(349, 135);
            this.btnNhapDiem.TabIndex = 1;
            this.btnNhapDiem.Text = "NHẬP ĐIỂM";
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Visible = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXemDiem.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiem.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.ForeColor = System.Drawing.Color.Red;
            this.btnXemDiem.Location = new System.Drawing.Point(4, 619);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(349, 127);
            this.btnXemDiem.TabIndex = 2;
            this.btnXemDiem.Text = "XEM ĐIỂM";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Visible = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThongTin.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.Red;
            this.btnThongTin.Location = new System.Drawing.Point(576, 1074);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(273, 127);
            this.btnThongTin.TabIndex = 4;
            this.btnThongTin.Text = "THÔNG TIN";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Visible = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(576, 1160);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(273, 254);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timerDangNhapDangXuat
            // 
            this.timerDangNhapDangXuat.Enabled = true;
            this.timerDangNhapDangXuat.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerChucVuDangNhap
            // 
            this.timerChucVuDangNhap.Enabled = true;
            this.timerChucVuDangNhap.Tick += new System.EventHandler(this.timerChucVuDangNhap_Tick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // entityCommand3
            // 
            this.entityCommand3.CommandTimeout = 0;
            this.entityCommand3.CommandTree = null;
            this.entityCommand3.Connection = null;
            this.entityCommand3.EnablePlanCaching = true;
            this.entityCommand3.Transaction = null;
            // 
            // entityCommand4
            // 
            this.entityCommand4.CommandTimeout = 0;
            this.entityCommand4.CommandTree = null;
            this.entityCommand4.Connection = null;
            this.entityCommand4.EnablePlanCaching = true;
            this.entityCommand4.Transaction = null;
            // 
            // ucChinh
            // 
            this.ucChinh.BackColor = System.Drawing.Color.Transparent;
            this.ucChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucChinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucChinh.ForeColor = System.Drawing.Color.Red;
            this.ucChinh.Location = new System.Drawing.Point(352, 1);
            this.ucChinh.Margin = new System.Windows.Forms.Padding(4);
            this.ucChinh.Name = "ucChinh";
            this.ucChinh.Size = new System.Drawing.Size(1704, 1072);
            this.ucChinh.TabIndex = 5;
            // 
            // ucChinh_DangKy
            // 
            this.ucChinh_DangKy.BackColor = System.Drawing.Color.Transparent;
            this.ucChinh_DangKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucChinh_DangKy.Location = new System.Drawing.Point(352, 1);
            this.ucChinh_DangKy.Margin = new System.Windows.Forms.Padding(4);
            this.ucChinh_DangKy.Name = "ucChinh_DangKy";
            this.ucChinh_DangKy.Size = new System.Drawing.Size(1704, 1072);
            this.ucChinh_DangKy.TabIndex = 6;
            // 
            // ucDoiMatKhau
            // 
            this.ucDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.ucDoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucDoiMatKhau.Location = new System.Drawing.Point(352, 1);
            this.ucDoiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.ucDoiMatKhau.Name = "ucDoiMatKhau";
            this.ucDoiMatKhau.Size = new System.Drawing.Size(1704, 1072);
            this.ucDoiMatKhau.TabIndex = 7;
            // 
            // ucGiaoVien
            // 
            this.ucGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.ucGiaoVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucGiaoVien.BackgroundImage")));
            this.ucGiaoVien.Location = new System.Drawing.Point(352, 1);
            this.ucGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.ucGiaoVien.Name = "ucGiaoVien";
            this.ucGiaoVien.Size = new System.Drawing.Size(1704, 1072);
            this.ucGiaoVien.TabIndex = 8;
            // 
            // ucLop
            // 
            this.ucLop.BackColor = System.Drawing.Color.Transparent;
            this.ucLop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLop.BackgroundImage")));
            this.ucLop.Location = new System.Drawing.Point(352, 1);
            this.ucLop.Margin = new System.Windows.Forms.Padding(4);
            this.ucLop.Name = "ucLop";
            this.ucLop.Size = new System.Drawing.Size(1704, 1072);
            this.ucLop.TabIndex = 9;
            // 
            // ucMonHoc
            // 
            this.ucMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.ucMonHoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMonHoc.BackgroundImage")));
            this.ucMonHoc.Location = new System.Drawing.Point(352, 1);
            this.ucMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.ucMonHoc.Name = "ucMonHoc";
            this.ucMonHoc.Size = new System.Drawing.Size(1704, 1072);
            this.ucMonHoc.TabIndex = 10;
            // 
            // ucNganh
            // 
            this.ucNganh.BackColor = System.Drawing.Color.Transparent;
            this.ucNganh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucNganh.BackgroundImage")));
            this.ucNganh.Location = new System.Drawing.Point(352, 1);
            this.ucNganh.Margin = new System.Windows.Forms.Padding(4);
            this.ucNganh.Name = "ucNganh";
            this.ucNganh.Size = new System.Drawing.Size(1704, 1072);
            this.ucNganh.TabIndex = 11;
            // 
            // ucNhapDiem
            // 
            this.ucNhapDiem.BackColor = System.Drawing.Color.Aqua;
            this.ucNhapDiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucNhapDiem.BackgroundImage")));
            this.ucNhapDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucNhapDiem.Location = new System.Drawing.Point(352, 1);
            this.ucNhapDiem.Margin = new System.Windows.Forms.Padding(4);
            this.ucNhapDiem.Name = "ucNhapDiem";
            this.ucNhapDiem.Size = new System.Drawing.Size(1704, 1072);
            this.ucNhapDiem.TabIndex = 12;
            // 
            // ucSinhVien
            // 
            this.ucSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.ucSinhVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucSinhVien.BackgroundImage")));
            this.ucSinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucSinhVien.Location = new System.Drawing.Point(352, 1);
            this.ucSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.ucSinhVien.Name = "ucSinhVien";
            this.ucSinhVien.Size = new System.Drawing.Size(1704, 1072);
            this.ucSinhVien.TabIndex = 13;
            // 
            // ucXemDiem
            // 
            this.ucXemDiem.BackColor = System.Drawing.Color.Transparent;
            this.ucXemDiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucXemDiem.BackgroundImage")));
            this.ucXemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucXemDiem.Location = new System.Drawing.Point(352, 1);
            this.ucXemDiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucXemDiem.Name = "ucXemDiem";
            this.ucXemDiem.Size = new System.Drawing.Size(1704, 1072);
            this.ucXemDiem.TabIndex = 14;
            // 
            // ucTieuDe
            // 
            this.ucTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.ucTieuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTieuDe.Location = new System.Drawing.Point(352, 1);
            this.ucTieuDe.Margin = new System.Windows.Forms.Padding(4);
            this.ucTieuDe.Name = "ucTieuDe";
            this.ucTieuDe.Size = new System.Drawing.Size(1704, 1072);
            this.ucTieuDe.TabIndex = 15;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ucTieuDe);
            this.Controls.Add(this.ucXemDiem);
            this.Controls.Add(this.ucSinhVien);
            this.Controls.Add(this.ucNhapDiem);
            this.Controls.Add(this.ucNganh);
            this.Controls.Add(this.ucMonHoc);
            this.Controls.Add(this.ucLop);
            this.Controls.Add(this.ucGiaoVien);
            this.Controls.Add(this.ucDoiMatKhau);
            this.Controls.Add(this.ucChinh_DangKy);
            this.Controls.Add(this.ucChinh);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnThoat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.Button btnXemDiem;
        public System.Windows.Forms.Button btnNhapDiem;
        public System.Windows.Forms.Button btnThongTin;
        private ucChinh ucChinh1;
        private ucChinh_DangKy ucChinh_DangKy1;
        private ucXemDiem ucXemDiem1;
        private ucNhapDiem ucNhapDiem1;
        public System.Windows.Forms.Button btnDangNhapChinh;
        private System.Windows.Forms.Timer timerDangNhapDangXuat;
        private System.Windows.Forms.Timer timerChucVuDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ucTieuDe ucTieuDe1;
        private ucNhapDiem ucNhapDiem2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand3;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ucChinh ucChinh;
        private ucChinh_DangKy ucChinh_DangKy;
        private ucDoiMatKhau ucDoiMatKhau;
        private ucGiaoVien ucGiaoVien;
        private ucLop ucLop;
        private ucMonHoc ucMonHoc;
        private ucNganh ucNganh;
        private ucNhapDiem ucNhapDiem;
        private ucSinhVien ucSinhVien;
        private ucXemDiem ucXemDiem;
        private ucTieuDe ucTieuDe;
    }
}