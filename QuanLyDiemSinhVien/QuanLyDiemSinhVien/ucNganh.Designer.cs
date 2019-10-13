namespace QuanLyDiemSinhVien
{
    partial class ucNganh
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNganh = new System.Windows.Forms.DataGridView();
            this.maNganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemSinhVienDataSet = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet();
            this.nganhTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSetTableAdapters.NganhTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 0;
            this.btnXoa.Location = new System.Drawing.Point(444, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 29);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.ImageIndex = 0;
            this.btnCapNhat.Location = new System.Drawing.Point(216, 360);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btnCapNhat.TabIndex = 40;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 0;
            this.btnThem.Location = new System.Drawing.Point(3, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 29);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNganh
            // 
            this.dgvNganh.AutoGenerateColumns = false;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNganhDataGridViewTextBoxColumn,
            this.tenNganhDataGridViewTextBoxColumn});
            this.dgvNganh.DataSource = this.nganhBindingSource;
            this.dgvNganh.Location = new System.Drawing.Point(3, 32);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.RowHeadersWidth = 51;
            this.dgvNganh.Size = new System.Drawing.Size(526, 322);
            this.dgvNganh.TabIndex = 38;
            this.dgvNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_CellClick);
            // 
            // maNganhDataGridViewTextBoxColumn
            // 
            this.maNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNganhDataGridViewTextBoxColumn.Name = "maNganhDataGridViewTextBoxColumn";
            this.maNganhDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNganhDataGridViewTextBoxColumn
            // 
            this.tenNganhDataGridViewTextBoxColumn.DataPropertyName = "TenNganh";
            this.tenNganhDataGridViewTextBoxColumn.HeaderText = "TenNganh";
            this.tenNganhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNganhDataGridViewTextBoxColumn.Name = "tenNganhDataGridViewTextBoxColumn";
            this.tenNganhDataGridViewTextBoxColumn.Width = 125;
            // 
            // nganhBindingSource
            // 
            this.nganhBindingSource.DataMember = "Nganh";
            this.nganhBindingSource.DataSource = this.quanLyDiemSinhVienDataSet;
            // 
            // quanLyDiemSinhVienDataSet
            // 
            this.quanLyDiemSinhVienDataSet.DataSetName = "QuanLyDiemSinhVienDataSet";
            this.quanLyDiemSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nganhTableAdapter
            // 
            this.nganhTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 42;
            // 
            // ucNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNganh);
            this.Name = "ucNganh";
            this.Size = new System.Drawing.Size(1154, 740);
            this.Load += new System.EventHandler(this.ucNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nganhBindingSource;
        private QuanLyDiemSinhVienDataSet quanLyDiemSinhVienDataSet;
        private QuanLyDiemSinhVienDataSetTableAdapters.NganhTableAdapter nganhTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}
