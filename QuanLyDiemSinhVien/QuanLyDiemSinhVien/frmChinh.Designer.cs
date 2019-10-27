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
            this.btnThoat2 = new System.Windows.Forms.Button();
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
            this.thongtin = new System.Windows.Forms.Button();
            this.ucXemDiem2 = new QuanLyDiemSinhVien.ucXemDiem();
            this.ucNhapDiem3 = new QuanLyDiemSinhVien.ucNhapDiem();
            this.ucTieuDe2 = new QuanLyDiemSinhVien.ucTieuDe();
            this.ucChinh_DangKy2 = new QuanLyDiemSinhVien.ucChinh_DangKy();
            this.ucChinh2 = new QuanLyDiemSinhVien.ucChinh();
            this.ucGiaoVien1 = new QuanLyDiemSinhVien.ucGiaoVien();
            this.ucLop1 = new QuanLyDiemSinhVien.ucLop();
            this.ucMonHoc1 = new QuanLyDiemSinhVien.ucMonHoc();
            this.ucNganh1 = new QuanLyDiemSinhVien.ucNganh();
            this.ucSinhVien1 = new QuanLyDiemSinhVien.ucSinhVien();
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
            this.pnButton.Controls.Add(this.thongtin);
            this.pnButton.Controls.Add(this.btnThoat2);
            this.pnButton.Controls.Add(this.btnXemDiem);
            this.pnButton.Location = new System.Drawing.Point(1, 0);
            this.pnButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(360, 961);
            this.pnButton.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDiemSinhVien.Properties.Resources.icontruonghoc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhapChinh
            // 
            this.btnDangNhapChinh.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDangNhapChinh.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDangNhapChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhapChinh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhapChinh.ForeColor = System.Drawing.Color.Red;
            this.btnDangNhapChinh.Location = new System.Drawing.Point(0, 229);
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
            this.btnNhapDiem.Location = new System.Drawing.Point(4, 345);
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
            this.btnXemDiem.Location = new System.Drawing.Point(0, 479);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(349, 127);
            this.btnXemDiem.TabIndex = 2;
            this.btnXemDiem.Text = "XEM ĐIỂM";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Visible = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnThoat2
            // 
            this.btnThoat2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnThoat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat2.ForeColor = System.Drawing.Color.Red;
            this.btnThoat2.Location = new System.Drawing.Point(4, 729);
            this.btnThoat2.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(349, 121);
            this.btnThoat2.TabIndex = 6;
            this.btnThoat2.Text = "THOÁT";
            this.btnThoat2.UseVisualStyleBackColor = false;
            this.btnThoat2.Click += new System.EventHandler(this.btnThoat2_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 5;
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
            // thongtin
            // 
            this.thongtin.BackColor = System.Drawing.Color.SkyBlue;
            this.thongtin.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thongtin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtin.ForeColor = System.Drawing.Color.Red;
            this.thongtin.Location = new System.Drawing.Point(4, 614);
            this.thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(349, 121);
            this.thongtin.TabIndex = 6;
            this.thongtin.Text = "THÔNG TIN";
            this.thongtin.UseVisualStyleBackColor = false;
            this.thongtin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // ucXemDiem2
            // 
            this.ucXemDiem2.BackColor = System.Drawing.Color.DarkGray;
            this.ucXemDiem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucXemDiem2.Location = new System.Drawing.Point(359, 0);
            this.ucXemDiem2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucXemDiem2.Name = "ucXemDiem2";
            this.ucXemDiem2.Size = new System.Drawing.Size(1624, 1053);
            this.ucXemDiem2.TabIndex = 12;
            // 
            // ucNhapDiem3
            // 
            this.ucNhapDiem3.BackColor = System.Drawing.Color.Aqua;
            this.ucNhapDiem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucNhapDiem3.BackgroundImage")));
            this.ucNhapDiem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucNhapDiem3.Location = new System.Drawing.Point(355, 4);
            this.ucNhapDiem3.Margin = new System.Windows.Forms.Padding(5);
            this.ucNhapDiem3.Name = "ucNhapDiem3";
            this.ucNhapDiem3.Size = new System.Drawing.Size(1780, 1058);
            this.ucNhapDiem3.TabIndex = 9;
            // 
            // ucTieuDe2
            // 
            this.ucTieuDe2.BackColor = System.Drawing.Color.Black;
            this.ucTieuDe2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTieuDe2.Location = new System.Drawing.Point(358, 0);
            this.ucTieuDe2.Margin = new System.Windows.Forms.Padding(4);
            this.ucTieuDe2.Name = "ucTieuDe2";
            this.ucTieuDe2.Size = new System.Drawing.Size(1624, 1053);
            this.ucTieuDe2.TabIndex = 11;
            // 
            // ucChinh_DangKy2
            // 
            this.ucChinh_DangKy2.BackColor = System.Drawing.Color.Transparent;
            this.ucChinh_DangKy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucChinh_DangKy2.BackgroundImage")));
            this.ucChinh_DangKy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucChinh_DangKy2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucChinh_DangKy2.ForeColor = System.Drawing.Color.Black;
            this.ucChinh_DangKy2.Location = new System.Drawing.Point(355, 0);
            this.ucChinh_DangKy2.Margin = new System.Windows.Forms.Padding(5);
            this.ucChinh_DangKy2.Name = "ucChinh_DangKy2";
            this.ucChinh_DangKy2.Size = new System.Drawing.Size(1624, 1053);
            this.ucChinh_DangKy2.TabIndex = 7;
            // 
            // ucChinh2
            // 
            this.ucChinh2.BackColor = System.Drawing.Color.Transparent;
            this.ucChinh2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucChinh2.BackgroundImage")));
            this.ucChinh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucChinh2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucChinh2.ForeColor = System.Drawing.Color.Red;
            this.ucChinh2.Location = new System.Drawing.Point(355, 7);
            this.ucChinh2.Margin = new System.Windows.Forms.Padding(5);
            this.ucChinh2.Name = "ucChinh2";
            this.ucChinh2.Size = new System.Drawing.Size(1493, 854);
            this.ucChinh2.TabIndex = 6;
            // 
            // ucGiaoVien1
            // 
            this.ucGiaoVien1.BackColor = System.Drawing.Color.Transparent;
            this.ucGiaoVien1.Location = new System.Drawing.Point(355, 0);
            this.ucGiaoVien1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGiaoVien1.Name = "ucGiaoVien1";
            this.ucGiaoVien1.Size = new System.Drawing.Size(1624, 1053);
            this.ucGiaoVien1.TabIndex = 13;
            // 
            // ucLop1
            // 
            this.ucLop1.BackColor = System.Drawing.Color.Transparent;
            this.ucLop1.Location = new System.Drawing.Point(355, 0);
            this.ucLop1.Margin = new System.Windows.Forms.Padding(4);
            this.ucLop1.Name = "ucLop1";
            this.ucLop1.Size = new System.Drawing.Size(1624, 1053);
            this.ucLop1.TabIndex = 14;
            // 
            // ucMonHoc1
            // 
            this.ucMonHoc1.BackColor = System.Drawing.Color.Transparent;
            this.ucMonHoc1.Location = new System.Drawing.Point(355, 0);
            this.ucMonHoc1.Margin = new System.Windows.Forms.Padding(4);
            this.ucMonHoc1.Name = "ucMonHoc1";
            this.ucMonHoc1.Size = new System.Drawing.Size(1624, 1053);
            this.ucMonHoc1.TabIndex = 15;
            // 
            // ucNganh1
            // 
            this.ucNganh1.BackColor = System.Drawing.Color.Transparent;
            this.ucNganh1.Location = new System.Drawing.Point(355, 0);
            this.ucNganh1.Margin = new System.Windows.Forms.Padding(4);
            this.ucNganh1.Name = "ucNganh1";
            this.ucNganh1.Size = new System.Drawing.Size(1624, 1053);
            this.ucNganh1.TabIndex = 16;
            // 
            // ucSinhVien1
            // 
            this.ucSinhVien1.BackColor = System.Drawing.Color.Transparent;
            this.ucSinhVien1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucSinhVien1.Location = new System.Drawing.Point(355, 0);
            this.ucSinhVien1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSinhVien1.Name = "ucSinhVien1";
            this.ucSinhVien1.Size = new System.Drawing.Size(1624, 1053);
            this.ucSinhVien1.TabIndex = 17;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1792, 863);
            this.Controls.Add(this.ucSinhVien1);
            this.Controls.Add(this.ucNganh1);
            this.Controls.Add(this.ucMonHoc1);
            this.Controls.Add(this.ucLop1);
            this.Controls.Add(this.ucGiaoVien1);
            this.Controls.Add(this.ucXemDiem2);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ucNhapDiem3);
            this.Controls.Add(this.ucTieuDe2);
            this.Controls.Add(this.ucChinh_DangKy2);
            this.Controls.Add(this.ucChinh2);
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
        private ucTieuDe ucTieuDe1;
        private ucNhapDiem ucNhapDiem2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand3;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnThoat2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button thongtin;
        private ucNhapDiem ucNhapDiem3;
        private ucXemDiem ucXemDiem2;
        private ucChinh ucChinh2;
        private ucChinh_DangKy ucChinh_DangKy2;
        private ucTieuDe ucTieuDe2;
        private ucGiaoVien ucGiaoVien1;
        private ucLop ucLop1;
        private ucMonHoc ucMonHoc1;
        private ucNganh ucNganh1;
        private ucSinhVien ucSinhVien1;
    }
}