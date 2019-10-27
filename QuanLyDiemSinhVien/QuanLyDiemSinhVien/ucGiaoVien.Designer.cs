namespace QuanLyDiemSinhVien
{
    partial class ucGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGiaoVien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.maGiaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGiaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemSinhVienDataSet6 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet6();
            this.giaoVienTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet6TableAdapters.GiaoVienTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet6)).BeginInit();
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
            this.btnXoa.Location = new System.Drawing.Point(817, 582);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(219, 95);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(8, 582);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(216, 95);
            this.btnThem.TabIndex = 50;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AutoGenerateColumns = false;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiaoVienDataGridViewTextBoxColumn,
            this.tenGiaoVienDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvGiaoVien.DataSource = this.giaoVienBindingSource;
            this.dgvGiaoVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGiaoVien.Location = new System.Drawing.Point(4, 41);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1044, 485);
            this.dgvGiaoVien.TabIndex = 49;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // maGiaoVienDataGridViewTextBoxColumn
            // 
            this.maGiaoVienDataGridViewTextBoxColumn.DataPropertyName = "MaGiaoVien";
            this.maGiaoVienDataGridViewTextBoxColumn.HeaderText = "MaGiaoVien";
            this.maGiaoVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maGiaoVienDataGridViewTextBoxColumn.Name = "maGiaoVienDataGridViewTextBoxColumn";
            this.maGiaoVienDataGridViewTextBoxColumn.Width = 160;
            // 
            // tenGiaoVienDataGridViewTextBoxColumn
            // 
            this.tenGiaoVienDataGridViewTextBoxColumn.DataPropertyName = "TenGiaoVien";
            this.tenGiaoVienDataGridViewTextBoxColumn.HeaderText = "TenGiaoVien";
            this.tenGiaoVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGiaoVienDataGridViewTextBoxColumn.Name = "tenGiaoVienDataGridViewTextBoxColumn";
            this.tenGiaoVienDataGridViewTextBoxColumn.Width = 160;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 160;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 250;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.quanLyDiemSinhVienDataSet6;
            // 
            // quanLyDiemSinhVienDataSet6
            // 
            this.quanLyDiemSinhVienDataSet6.DataSetName = "QuanLyDiemSinhVienDataSet6";
            this.quanLyDiemSinhVienDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(932, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 33);
            this.textBox1.TabIndex = 53;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(385, 582);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(239, 95);
            this.btnCapNhat.TabIndex = 52;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // ucGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucGiaoVien";
            this.Size = new System.Drawing.Size(1624, 1053);
            this.Load += new System.EventHandler(this.ucGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGiaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QuanLyDiemSinhVienDataSet6 quanLyDiemSinhVienDataSet6;
        private QuanLyDiemSinhVienDataSet6TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCapNhat;
    }
}
