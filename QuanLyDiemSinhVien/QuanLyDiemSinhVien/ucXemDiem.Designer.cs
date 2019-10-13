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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTinhDiemTrungBinh = new System.Windows.Forms.Button();
            this.dgvXemDiemTheoMaSinhVien = new System.Windows.Forms.DataGridView();
            this.maSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemL4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemChuyenCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemQuaTrinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTrungBinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemSinhVienDataSet4 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet4();
            this.quanLyDiemSinhVienDataSet3 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet3();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet3TableAdapters.DiemTableAdapter();
            this.diemTableAdapter1 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet4TableAdapters.DiemTableAdapter();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiemTheoMaSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm Kiếm Thông Tin =>";
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
            this.btnTinhDiemTrungBinh.Location = new System.Drawing.Point(10, 375);
            this.btnTinhDiemTrungBinh.Name = "btnTinhDiemTrungBinh";
            this.btnTinhDiemTrungBinh.Size = new System.Drawing.Size(347, 28);
            this.btnTinhDiemTrungBinh.TabIndex = 27;
            this.btnTinhDiemTrungBinh.Text = "Tính điểm trung bình theo tín chỉ của 1 môn";
            this.btnTinhDiemTrungBinh.UseVisualStyleBackColor = true;
            this.btnTinhDiemTrungBinh.Click += new System.EventHandler(this.btnTinhDiemTrungBinh_Click);
            // 
            // dgvXemDiemTheoMaSinhVien
            // 
            this.dgvXemDiemTheoMaSinhVien.AutoGenerateColumns = false;
            this.dgvXemDiemTheoMaSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDiemTheoMaSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVienDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.diemL1DataGridViewTextBoxColumn,
            this.diemL2DataGridViewTextBoxColumn,
            this.diemL3DataGridViewTextBoxColumn,
            this.diemL4DataGridViewTextBoxColumn,
            this.diemChuyenCanDataGridViewTextBoxColumn,
            this.diemQuaTrinhDataGridViewTextBoxColumn,
            this.diemThiDataGridViewTextBoxColumn,
            this.diemTrungBinhDataGridViewTextBoxColumn});
            this.dgvXemDiemTheoMaSinhVien.DataSource = this.diemBindingSource1;
            this.dgvXemDiemTheoMaSinhVien.Location = new System.Drawing.Point(3, 57);
            this.dgvXemDiemTheoMaSinhVien.Name = "dgvXemDiemTheoMaSinhVien";
            this.dgvXemDiemTheoMaSinhVien.RowHeadersWidth = 51;
            this.dgvXemDiemTheoMaSinhVien.Size = new System.Drawing.Size(526, 312);
            this.dgvXemDiemTheoMaSinhVien.TabIndex = 28;
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            this.maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.HeaderText = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            this.maSinhVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemL1DataGridViewTextBoxColumn
            // 
            this.diemL1DataGridViewTextBoxColumn.DataPropertyName = "DiemL1";
            this.diemL1DataGridViewTextBoxColumn.HeaderText = "DiemL1";
            this.diemL1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemL1DataGridViewTextBoxColumn.Name = "diemL1DataGridViewTextBoxColumn";
            this.diemL1DataGridViewTextBoxColumn.Width = 125;
            // 
            // diemL2DataGridViewTextBoxColumn
            // 
            this.diemL2DataGridViewTextBoxColumn.DataPropertyName = "DiemL2";
            this.diemL2DataGridViewTextBoxColumn.HeaderText = "DiemL2";
            this.diemL2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemL2DataGridViewTextBoxColumn.Name = "diemL2DataGridViewTextBoxColumn";
            this.diemL2DataGridViewTextBoxColumn.Width = 125;
            // 
            // diemL3DataGridViewTextBoxColumn
            // 
            this.diemL3DataGridViewTextBoxColumn.DataPropertyName = "DiemL3";
            this.diemL3DataGridViewTextBoxColumn.HeaderText = "DiemL3";
            this.diemL3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemL3DataGridViewTextBoxColumn.Name = "diemL3DataGridViewTextBoxColumn";
            this.diemL3DataGridViewTextBoxColumn.Width = 125;
            // 
            // diemL4DataGridViewTextBoxColumn
            // 
            this.diemL4DataGridViewTextBoxColumn.DataPropertyName = "DiemL4";
            this.diemL4DataGridViewTextBoxColumn.HeaderText = "DiemL4";
            this.diemL4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemL4DataGridViewTextBoxColumn.Name = "diemL4DataGridViewTextBoxColumn";
            this.diemL4DataGridViewTextBoxColumn.Width = 125;
            // 
            // diemChuyenCanDataGridViewTextBoxColumn
            // 
            this.diemChuyenCanDataGridViewTextBoxColumn.DataPropertyName = "DiemChuyenCan";
            this.diemChuyenCanDataGridViewTextBoxColumn.HeaderText = "DiemChuyenCan";
            this.diemChuyenCanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemChuyenCanDataGridViewTextBoxColumn.Name = "diemChuyenCanDataGridViewTextBoxColumn";
            this.diemChuyenCanDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemQuaTrinhDataGridViewTextBoxColumn
            // 
            this.diemQuaTrinhDataGridViewTextBoxColumn.DataPropertyName = "DiemQuaTrinh";
            this.diemQuaTrinhDataGridViewTextBoxColumn.HeaderText = "DiemQuaTrinh";
            this.diemQuaTrinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemQuaTrinhDataGridViewTextBoxColumn.Name = "diemQuaTrinhDataGridViewTextBoxColumn";
            this.diemQuaTrinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemThiDataGridViewTextBoxColumn
            // 
            this.diemThiDataGridViewTextBoxColumn.DataPropertyName = "DiemThi";
            this.diemThiDataGridViewTextBoxColumn.HeaderText = "DiemThi";
            this.diemThiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemThiDataGridViewTextBoxColumn.Name = "diemThiDataGridViewTextBoxColumn";
            this.diemThiDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemTrungBinhDataGridViewTextBoxColumn
            // 
            this.diemTrungBinhDataGridViewTextBoxColumn.DataPropertyName = "DiemTrungBinh";
            this.diemTrungBinhDataGridViewTextBoxColumn.HeaderText = "DiemTrungBinh";
            this.diemTrungBinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemTrungBinhDataGridViewTextBoxColumn.Name = "diemTrungBinhDataGridViewTextBoxColumn";
            this.diemTrungBinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemBindingSource1
            // 
            this.diemBindingSource1.DataMember = "Diem";
            this.diemBindingSource1.DataSource = this.quanLyDiemSinhVienDataSet4;
            // 
            // quanLyDiemSinhVienDataSet4
            // 
            this.quanLyDiemSinhVienDataSet4.DataSetName = "QuanLyDiemSinhVienDataSet4";
            this.quanLyDiemSinhVienDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyDiemSinhVienDataSet3
            // 
            this.quanLyDiemSinhVienDataSet3.DataSetName = "QuanLyDiemSinhVienDataSet3";
            this.quanLyDiemSinhVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            this.diemBindingSource.DataSource = this.quanLyDiemSinhVienDataSet3;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // diemTableAdapter1
            // 
            this.diemTableAdapter1.ClearBeforeFill = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(201, 28);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(148, 24);
            this.txtTimKiem.TabIndex = 29;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 375);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 28);
            this.textBox1.TabIndex = 30;
            // 
            // ucXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvXemDiemTheoMaSinhVien);
            this.Controls.Add(this.btnTinhDiemTrungBinh);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Name = "ucXemDiem";
            this.Size = new System.Drawing.Size(1154, 740);
            this.Load += new System.EventHandler(this.ucXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiemTheoMaSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTinhDiemTrungBinh;
        private System.Windows.Forms.DataGridView dgvXemDiemTheoMaSinhVien;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private QuanLyDiemSinhVienDataSet3 quanLyDiemSinhVienDataSet3;
        private QuanLyDiemSinhVienDataSet3TableAdapters.DiemTableAdapter diemTableAdapter;
        private System.Windows.Forms.BindingSource diemBindingSource1;
        private QuanLyDiemSinhVienDataSet4 quanLyDiemSinhVienDataSet4;
        private QuanLyDiemSinhVienDataSet4TableAdapters.DiemTableAdapter diemTableAdapter1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemL4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemChuyenCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemQuaTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTrungBinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}
