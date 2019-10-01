namespace QuanLyDiemSinhVien
{
    partial class ucXemDiem
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
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbXemDiemTheo = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTinhDiemTrungBinh = new System.Windows.Forms.Button();
            this.dgvXemDiemTheoMaSinhVien = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiemTheoMaSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.ImageIndex = 0;
            this.btnXem.Location = new System.Drawing.Point(295, 29);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(62, 28);
            this.btnXem.TabIndex = 23;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Xem điểm theo";
            // 
            // cbbXemDiemTheo
            // 
            this.cbbXemDiemTheo.FormattingEnabled = true;
            this.cbbXemDiemTheo.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Lớp",
            "Môn học"});
            this.cbbXemDiemTheo.Location = new System.Drawing.Point(138, 35);
            this.cbbXemDiemTheo.Name = "cbbXemDiemTheo";
            this.cbbXemDiemTheo.Size = new System.Drawing.Size(151, 21);
            this.cbbXemDiemTheo.TabIndex = 24;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.ImageIndex = 0;
            this.btnIn.Location = new System.Drawing.Point(422, 28);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(107, 28);
            this.btnIn.TabIndex = 26;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnTinhDiemTrungBinh
            // 
            this.btnTinhDiemTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDiemTrungBinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhDiemTrungBinh.ImageIndex = 0;
            this.btnTinhDiemTrungBinh.Location = new System.Drawing.Point(90, 380);
            this.btnTinhDiemTrungBinh.Name = "btnTinhDiemTrungBinh";
            this.btnTinhDiemTrungBinh.Size = new System.Drawing.Size(329, 28);
            this.btnTinhDiemTrungBinh.TabIndex = 27;
            this.btnTinhDiemTrungBinh.Text = "Tính điểm trung bình theo tín chỉ";
            this.btnTinhDiemTrungBinh.UseVisualStyleBackColor = true;
            // 
            // dgvXemDiemTheoMaSinhVien
            // 
            this.dgvXemDiemTheoMaSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDiemTheoMaSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.Lop,
            this.MonHoc,
            this.DiemL1,
            this.DiemLan2,
            this.DiemLan3,
            this.DiemLan4,
            this.DiemChuyenCan,
            this.DiemQuaTrinh,
            this.DiemThi,
            this.DiemTrungBinh});
            this.dgvXemDiemTheoMaSinhVien.Location = new System.Drawing.Point(3, 62);
            this.dgvXemDiemTheoMaSinhVien.Name = "dgvXemDiemTheoMaSinhVien";
            this.dgvXemDiemTheoMaSinhVien.Size = new System.Drawing.Size(526, 312);
            this.dgvXemDiemTheoMaSinhVien.TabIndex = 28;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp Học";
            this.Lop.Name = "Lop";
            // 
            // MonHoc
            // 
            this.MonHoc.HeaderText = "Môn Học";
            this.MonHoc.Name = "MonHoc";
            // 
            // DiemL1
            // 
            this.DiemL1.HeaderText = "Điểm Lần 1";
            this.DiemL1.Name = "DiemL1";
            // 
            // DiemLan2
            // 
            this.DiemLan2.HeaderText = "Điểm Lần 2";
            this.DiemLan2.Name = "DiemLan2";
            // 
            // DiemLan3
            // 
            this.DiemLan3.HeaderText = "Điểm Lần 3";
            this.DiemLan3.Name = "DiemLan3";
            // 
            // DiemLan4
            // 
            this.DiemLan4.HeaderText = "Điểm Lần 4";
            this.DiemLan4.Name = "DiemLan4";
            // 
            // DiemChuyenCan
            // 
            this.DiemChuyenCan.HeaderText = "Điểm Chuyên Cần";
            this.DiemChuyenCan.Name = "DiemChuyenCan";
            // 
            // DiemQuaTrinh
            // 
            this.DiemQuaTrinh.HeaderText = "Điểm Quá Trình";
            this.DiemQuaTrinh.Name = "DiemQuaTrinh";
            // 
            // DiemThi
            // 
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.Name = "DiemThi";
            // 
            // DiemTrungBinh
            // 
            this.DiemTrungBinh.HeaderText = "Điểm Trung Bình";
            this.DiemTrungBinh.Name = "DiemTrungBinh";
            // 
            // ucXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.dgvXemDiemTheoMaSinhVien);
            this.Controls.Add(this.btnTinhDiemTrungBinh);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cbbXemDiemTheo);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Name = "ucXemDiem";
            this.Size = new System.Drawing.Size(532, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiemTheoMaSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbXemDiemTheo;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTinhDiemTrungBinh;
        private System.Windows.Forms.DataGridView dgvXemDiemTheoMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTrungBinh;
    }
}
