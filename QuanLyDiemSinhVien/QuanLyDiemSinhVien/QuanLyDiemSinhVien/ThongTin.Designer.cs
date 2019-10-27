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
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnNganh = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.ucSinhVien1 = new QuanLyDiemSinhVien.ucSinhVien();
            this.ucGiaoVien1 = new QuanLyDiemSinhVien.ucGiaoVien();
            this.ucNganh1 = new QuanLyDiemSinhVien.ucNganh();
            this.ucMonHoc1 = new QuanLyDiemSinhVien.ucMonHoc();
            this.ucLop1 = new QuanLyDiemSinhVien.ucLop();
            this.pnShowUC.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShowUC
            // 
            this.pnShowUC.BackColor = System.Drawing.Color.SpringGreen;
            this.pnShowUC.Controls.Add(this.ucSinhVien1);
            this.pnShowUC.Controls.Add(this.ucGiaoVien1);
            this.pnShowUC.Controls.Add(this.ucNganh1);
            this.pnShowUC.Controls.Add(this.ucMonHoc1);
            this.pnShowUC.Controls.Add(this.ucLop1);
            this.pnShowUC.Location = new System.Drawing.Point(217, 13);
            this.pnShowUC.Name = "pnShowUC";
            this.pnShowUC.Size = new System.Drawing.Size(1162, 740);
            this.pnShowUC.TabIndex = 3;
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnButton.Controls.Add(this.btnNganh);
            this.pnButton.Controls.Add(this.btnLop);
            this.pnButton.Controls.Add(this.btnSinhVien);
            this.pnButton.Controls.Add(this.btnMonhoc);
            this.pnButton.Controls.Add(this.btnGiaoVien);
            this.pnButton.Location = new System.Drawing.Point(1, 0);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(210, 700);
            this.pnButton.TabIndex = 2;
            // 
            // btnNganh
            // 
            this.btnNganh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNganh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganh.ForeColor = System.Drawing.Color.Red;
            this.btnNganh.Location = new System.Drawing.Point(0, 548);
            this.btnNganh.Name = "btnNganh";
            this.btnNganh.Size = new System.Drawing.Size(210, 140);
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
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Red;
            this.btnLop.Location = new System.Drawing.Point(0, 268);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(210, 140);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = false;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiaoVien.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Red;
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 131);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(210, 140);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSinhVien.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.Red;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 0);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(210, 140);
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
            this.btnMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonhoc.ForeColor = System.Drawing.Color.Red;
            this.btnMonhoc.Location = new System.Drawing.Point(0, 402);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.Size = new System.Drawing.Size(210, 140);
            this.btnMonhoc.TabIndex = 4;
            this.btnMonhoc.Text = "Môn Học";
            this.btnMonhoc.UseVisualStyleBackColor = false;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // ucSinhVien1
            // 
            this.ucSinhVien1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucSinhVien1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucSinhVien1.Location = new System.Drawing.Point(0, 0);
            this.ucSinhVien1.Name = "ucSinhVien1";
            this.ucSinhVien1.Size = new System.Drawing.Size(1154, 740);
            this.ucSinhVien1.TabIndex = 4;
            // 
            // ucGiaoVien1
            // 
            this.ucGiaoVien1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucGiaoVien1.Location = new System.Drawing.Point(0, 0);
            this.ucGiaoVien1.Name = "ucGiaoVien1";
            this.ucGiaoVien1.Size = new System.Drawing.Size(1154, 740);
            this.ucGiaoVien1.TabIndex = 3;
            // 
            // ucNganh1
            // 
            this.ucNganh1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucNganh1.Location = new System.Drawing.Point(0, 0);
            this.ucNganh1.Name = "ucNganh1";
            this.ucNganh1.Size = new System.Drawing.Size(1154, 740);
            this.ucNganh1.TabIndex = 2;
            // 
            // ucMonHoc1
            // 
            this.ucMonHoc1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucMonHoc1.Location = new System.Drawing.Point(0, 0);
            this.ucMonHoc1.Name = "ucMonHoc1";
            this.ucMonHoc1.Size = new System.Drawing.Size(1154, 740);
            this.ucMonHoc1.TabIndex = 1;
            // 
            // ucLop1
            // 
            this.ucLop1.BackColor = System.Drawing.Color.SpringGreen;
            this.ucLop1.Location = new System.Drawing.Point(20, 16);
            this.ucLop1.Name = "ucLop1";
            this.ucLop1.Size = new System.Drawing.Size(1154, 740);
            this.ucLop1.TabIndex = 0;
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.pnShowUC);
            this.Controls.Add(this.pnButton);
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
        private ucSinhVien ucSinhVien1;
        private ucGiaoVien ucGiaoVien1;
        private ucNganh ucNganh1;
        private ucMonHoc ucMonHoc1;
        private ucLop ucLop1;
    }
}