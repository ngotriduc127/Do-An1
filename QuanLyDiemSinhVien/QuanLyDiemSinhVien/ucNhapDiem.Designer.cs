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
            this.btnXem = new System.Windows.Forms.Button();
            this.cbbChonLop = new System.Windows.Forms.ComboBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbbChucNangThem = new System.Windows.Forms.ComboBox();
            this.btnOKChucNangKhac = new System.Windows.Forms.Button();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.ImageIndex = 0;
            this.btnXem.Location = new System.Drawing.Point(147, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(85, 29);
            this.btnXem.TabIndex = 23;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // cbbChonLop
            // 
            this.cbbChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonLop.FormattingEnabled = true;
            this.cbbChonLop.Location = new System.Drawing.Point(3, 3);
            this.cbbChonLop.Name = "cbbChonLop";
            this.cbbChonLop.Size = new System.Drawing.Size(138, 28);
            this.cbbChonLop.TabIndex = 25;
            this.cbbChonLop.Text = "Chọn Lớp";
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.HoTen,
            this.DiemL1,
            this.DiemLan2,
            this.DiemLan3,
            this.DiemLan4,
            this.DiemChuyenCan,
            this.DiemQuaTrinh,
            this.DiemThi,
            this.DiemTrungBinh,
            this.XepLoai});
            this.dgvDiem.Location = new System.Drawing.Point(3, 37);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(526, 322);
            this.dgvDiem.TabIndex = 26;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 0;
            this.btnThem.Location = new System.Drawing.Point(3, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 29);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.ImageIndex = 0;
            this.btnCapNhat.Location = new System.Drawing.Point(72, 365);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btnCapNhat.TabIndex = 28;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 0;
            this.btnXoa.Location = new System.Drawing.Point(172, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 29);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // cbbChucNangThem
            // 
            this.cbbChucNangThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucNangThem.FormattingEnabled = true;
            this.cbbChucNangThem.Items.AddRange(new object[] {
            "Tính điểm trung bình",
            "Xếp loại học lực",
            "In"});
            this.cbbChucNangThem.Location = new System.Drawing.Point(256, 365);
            this.cbbChucNangThem.Name = "cbbChucNangThem";
            this.cbbChucNangThem.Size = new System.Drawing.Size(152, 28);
            this.cbbChucNangThem.TabIndex = 30;
            this.cbbChucNangThem.Text = "Chức năng khác";
            // 
            // btnOKChucNangKhac
            // 
            this.btnOKChucNangKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKChucNangKhac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOKChucNangKhac.ImageIndex = 0;
            this.btnOKChucNangKhac.Location = new System.Drawing.Point(414, 364);
            this.btnOKChucNangKhac.Name = "btnOKChucNangKhac";
            this.btnOKChucNangKhac.Size = new System.Drawing.Size(85, 29);
            this.btnOKChucNangKhac.TabIndex = 31;
            this.btnOKChucNangKhac.Text = "OK";
            this.btnOKChucNangKhac.UseVisualStyleBackColor = true;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.HeaderText = "Mã Sinh Viên";
            this.MaSinhVien.Name = "MaSinhVien";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
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
            // XepLoai
            // 
            this.XepLoai.HeaderText = "Xếp Loại";
            this.XepLoai.Name = "XepLoai";
            // 
            // ucNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.btnOKChucNangKhac);
            this.Controls.Add(this.cbbChucNangThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.cbbChonLop);
            this.Controls.Add(this.btnXem);
            this.Name = "ucNhapDiem";
            this.Size = new System.Drawing.Size(535, 398);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbChonLop;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbChucNangThem;
        private System.Windows.Forms.Button btnOKChucNangKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTrungBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
    }
}
