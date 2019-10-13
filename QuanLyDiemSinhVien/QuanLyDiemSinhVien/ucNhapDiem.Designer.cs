namespace QuanLyDiemSinhVien
{
    partial class ucNhapDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbbChonLop = new System.Windows.Forms.ComboBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.ImageIndex = 0;
            this.btnXem.Location = new System.Drawing.Point(189, 41);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(124, 62);
            this.btnXem.TabIndex = 23;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbbChonLop
            // 
            this.cbbChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonLop.FormattingEnabled = true;
            this.cbbChonLop.Location = new System.Drawing.Point(19, 41);
            this.cbbChonLop.Name = "cbbChonLop";
            this.cbbChonLop.Size = new System.Drawing.Size(138, 28);
            this.cbbChonLop.TabIndex = 25;
            this.cbbChonLop.Text = "Chọn Lớp";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiem.GridColor = System.Drawing.Color.LightYellow;
            this.dgvDiem.Location = new System.Drawing.Point(0, 109);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(1151, 498);
            this.dgvDiem.TabIndex = 26;
            this.dgvDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDiem_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 0;
            this.btnLuu.Location = new System.Drawing.Point(3, 613);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(252, 74);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.ImageIndex = 0;
            this.btnReset.Location = new System.Drawing.Point(296, 613);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(246, 74);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLoai.ImageIndex = 0;
            this.btnXepLoai.Location = new System.Drawing.Point(572, 613);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(246, 74);
            this.btnXepLoai.TabIndex = 32;
            this.btnXepLoai.Text = "Xếp Loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Visible = false;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.ImageIndex = 0;
            this.btnIn.Location = new System.Drawing.Point(853, 613);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(246, 74);
            this.btnIn.TabIndex = 33;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Visible = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // ucNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.cbbChonLop);
            this.Controls.Add(this.btnXem);
            this.Name = "ucNhapDiem";
            this.Size = new System.Drawing.Size(1154, 740);
            this.Load += new System.EventHandler(this.ucNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbChonLop;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Button btnIn;
    }
}
