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
            this.pnShowUC = new System.Windows.Forms.Panel();
            this.ucGiaoVien1 = new QuanLyDiemSinhVien.ucGiaoVien();
            this.ucSinhVien1 = new QuanLyDiemSinhVien.ucSinhVien();
            this.ucNganh1 = new QuanLyDiemSinhVien.ucNganh();
            this.ucMonHoc1 = new QuanLyDiemSinhVien.ucMonHoc();
            this.ucLop1 = new QuanLyDiemSinhVien.ucLop();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.btnNganh = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.pnShowUC.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShowUC
            // 
            this.pnShowUC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnShowUC.Controls.Add(this.ucGiaoVien1);
            this.pnShowUC.Controls.Add(this.ucSinhVien1);
            this.pnShowUC.Controls.Add(this.ucNganh1);
            this.pnShowUC.Controls.Add(this.ucMonHoc1);
            this.pnShowUC.Controls.Add(this.ucLop1);
            this.pnShowUC.Location = new System.Drawing.Point(276, 16);
            this.pnShowUC.Margin = new System.Windows.Forms.Padding(4);
            this.pnShowUC.Name = "pnShowUC";
            this.pnShowUC.Size = new System.Drawing.Size(716, 523);
            this.pnShowUC.TabIndex = 3;
            // 
            // ucGiaoVien1
            // 
            this.ucGiaoVien1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucGiaoVien1.Location = new System.Drawing.Point(5, 6);
            this.ucGiaoVien1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGiaoVien1.Name = "ucGiaoVien1";
            this.ucGiaoVien1.Size = new System.Drawing.Size(709, 517);
            this.ucGiaoVien1.TabIndex = 1;
            // 
            // ucSinhVien1
            // 
            this.ucSinhVien1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucSinhVien1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucSinhVien1.Location = new System.Drawing.Point(5, 5);
            this.ucSinhVien1.Margin = new System.Windows.Forms.Padding(5);
            this.ucSinhVien1.Name = "ucSinhVien1";
            this.ucSinhVien1.Size = new System.Drawing.Size(709, 517);
            this.ucSinhVien1.TabIndex = 0;
            // 
            // ucNganh1
            // 
            this.ucNganh1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucNganh1.Location = new System.Drawing.Point(7, 6);
            this.ucNganh1.Margin = new System.Windows.Forms.Padding(5);
            this.ucNganh1.Name = "ucNganh1";
            this.ucNganh1.Size = new System.Drawing.Size(709, 517);
            this.ucNganh1.TabIndex = 4;
            // 
            // ucMonHoc1
            // 
            this.ucMonHoc1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucMonHoc1.Location = new System.Drawing.Point(7, 6);
            this.ucMonHoc1.Margin = new System.Windows.Forms.Padding(5);
            this.ucMonHoc1.Name = "ucMonHoc1";
            this.ucMonHoc1.Size = new System.Drawing.Size(709, 517);
            this.ucMonHoc1.TabIndex = 3;
            // 
            // ucLop1
            // 
            this.ucLop1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucLop1.Location = new System.Drawing.Point(7, 6);
            this.ucLop1.Margin = new System.Windows.Forms.Padding(5);
            this.ucLop1.Name = "ucLop1";
            this.ucLop1.Size = new System.Drawing.Size(709, 517);
            this.ucLop1.TabIndex = 2;
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.Goldenrod;
            this.pnButton.Controls.Add(this.btnNganh);
            this.pnButton.Controls.Add(this.btnLop);
            this.pnButton.Controls.Add(this.btnGiaoVien);
            this.pnButton.Controls.Add(this.btnSinhVien);
            this.pnButton.Controls.Add(this.btnMonhoc);
            this.pnButton.Location = new System.Drawing.Point(12, 16);
            this.pnButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(256, 523);
            this.pnButton.TabIndex = 2;
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonhoc.ForeColor = System.Drawing.Color.Red;
            this.btnMonhoc.Location = new System.Drawing.Point(5, 303);
            this.btnMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.Size = new System.Drawing.Size(251, 80);
            this.btnMonhoc.TabIndex = 4;
            this.btnMonhoc.Text = "Môn Học";
            this.btnMonhoc.UseVisualStyleBackColor = true;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // btnNganh
            // 
            this.btnNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganh.ForeColor = System.Drawing.Color.Red;
            this.btnNganh.Location = new System.Drawing.Point(9, 390);
            this.btnNganh.Margin = new System.Windows.Forms.Padding(4);
            this.btnNganh.Name = "btnNganh";
            this.btnNganh.Size = new System.Drawing.Size(247, 80);
            this.btnNganh.TabIndex = 3;
            this.btnNganh.Text = "Ngành";
            this.btnNganh.UseVisualStyleBackColor = true;
            this.btnNganh.Click += new System.EventHandler(this.btnNganh_Click);
            // 
            // btnLop
            // 
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Red;
            this.btnLop.Location = new System.Drawing.Point(9, 214);
            this.btnLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(247, 81);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Red;
            this.btnGiaoVien.Location = new System.Drawing.Point(9, 134);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(247, 73);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.Red;
            this.btnSinhVien.Location = new System.Drawing.Point(5, 46);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(251, 81);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 554);
            this.Controls.Add(this.pnShowUC);
            this.Controls.Add(this.pnButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTin";
            this.Text = "ThongTin";
            this.pnShowUC.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShowUC;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnMonhoc;
        private System.Windows.Forms.Button btnNganh;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnSinhVien;
        private ucNganh ucNganh1;
        private ucMonHoc ucMonHoc1;
        private ucLop ucLop1;
        private ucGiaoVien ucGiaoVien1;
        private ucSinhVien ucSinhVien1;
    }
}