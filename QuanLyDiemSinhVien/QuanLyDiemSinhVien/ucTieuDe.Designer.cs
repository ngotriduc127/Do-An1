namespace QuanLyDiemSinhVien
{
    partial class ucTieuDe
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.tmrMoveLabels = new System.Windows.Forms.Timer(this.components);
            this.tmrHideLabels = new System.Windows.Forms.Timer(this.components);
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDiemSinhVien.Properties.Resources.dangki;
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1624, 1053);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(1295, 341);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(96, 35);
            this.btnAnimate.TabIndex = 10;
            this.btnAnimate.Text = "button1";
            this.btnAnimate.UseVisualStyleBackColor = true;
            // 
            // tmrMoveLabels
            // 
            this.tmrMoveLabels.Interval = 10;
            // 
            // tmrHideLabels
            // 
            this.tmrHideLabels.Interval = 10000;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Red;
            this.lblTitle2.Location = new System.Drawing.Point(547, 470);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(505, 49);
            this.lblTitle2.TabIndex = 11;
            this.lblTitle2.Text = "Võ Thành Văn : 17110127";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle4.ForeColor = System.Drawing.Color.Red;
            this.lblTitle4.Location = new System.Drawing.Point(360, 672);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(1031, 67);
            this.lblTitle4.TabIndex = 12;
            this.lblTitle4.Text = "Chương Trình Quản Lý Điếm Sinh Viên";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.Color.Red;
            this.lblTitle3.Location = new System.Drawing.Point(573, 585);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(450, 49);
            this.lblTitle3.TabIndex = 13;
            this.lblTitle3.Text = "Ngô Trí Đức :17110127";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Red;
            this.lblTitle1.Location = new System.Drawing.Point(703, 353);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(173, 49);
            this.lblTitle1.TabIndex = 14;
            this.lblTitle1.Text = "Đồ Án 1";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucTieuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTieuDe";
            this.Size = new System.Drawing.Size(1624, 1053);
            this.Load += new System.EventHandler(this.ucTieuDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Timer tmrMoveLabels;
        private System.Windows.Forms.Timer tmrHideLabels;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblTitle1;
    }
}
