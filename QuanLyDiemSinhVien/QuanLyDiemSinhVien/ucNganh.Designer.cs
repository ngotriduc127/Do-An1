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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNganh));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDiemSinhVien.Properties.Resources.pexels_photo_3090893;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1624, 1053);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(705, 582);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(232, 98);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(320, 582);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(229, 98);
            this.btnCapNhat.TabIndex = 45;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(9, 582);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(195, 98);
            this.btnThem.TabIndex = 44;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNganh
            // 
            this.dgvNganh.AutoGenerateColumns = false;
            this.dgvNganh.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNganhDataGridViewTextBoxColumn,
            this.tenNganhDataGridViewTextBoxColumn});
            this.dgvNganh.DataSource = this.nganhBindingSource;
            this.dgvNganh.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNganh.Location = new System.Drawing.Point(13, 55);
            this.dgvNganh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.RowHeadersWidth = 51;
            this.dgvNganh.Size = new System.Drawing.Size(924, 501);
            this.dgvNganh.TabIndex = 43;
            this.dgvNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_CellClick);
            // 
            // maNganhDataGridViewTextBoxColumn
            // 
            this.maNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNganhDataGridViewTextBoxColumn.Name = "maNganhDataGridViewTextBoxColumn";
            this.maNganhDataGridViewTextBoxColumn.Width = 315;
            // 
            // tenNganhDataGridViewTextBoxColumn
            // 
            this.tenNganhDataGridViewTextBoxColumn.DataPropertyName = "TenNganh";
            this.tenNganhDataGridViewTextBoxColumn.HeaderText = "TenNganh";
            this.tenNganhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNganhDataGridViewTextBoxColumn.Name = "tenNganhDataGridViewTextBoxColumn";
            this.tenNganhDataGridViewTextBoxColumn.Width = 320;
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
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(837, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 32);
            this.textBox1.TabIndex = 47;
            // 
            // ucNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNganh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucNganh";
            this.Size = new System.Drawing.Size(1624, 1053);
            this.Load += new System.EventHandler(this.ucNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
