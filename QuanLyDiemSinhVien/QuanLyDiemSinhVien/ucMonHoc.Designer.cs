﻿namespace QuanLyDiemSinhVien
{
    partial class ucMonHoc
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
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinhChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemSinhVienDataSet8 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet8();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemSinhVienDataSet7 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet7();
            this.monHocTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet7TableAdapters.MonHocTableAdapter();
            this.monHocTableAdapter1 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet8TableAdapters.MonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 0;
            this.btnXoa.Location = new System.Drawing.Point(120, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 45);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 0;
            this.btnThem.Location = new System.Drawing.Point(3, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 45);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AutoGenerateColumns = false;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.soTinhChiDataGridViewTextBoxColumn});
            this.dgvMonHoc.DataSource = this.monHocBindingSource1;
            this.dgvMonHoc.Location = new System.Drawing.Point(3, 32);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.Size = new System.Drawing.Size(526, 322);
            this.dgvMonHoc.TabIndex = 38;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // soTinhChiDataGridViewTextBoxColumn
            // 
            this.soTinhChiDataGridViewTextBoxColumn.DataPropertyName = "SoTinhChi";
            this.soTinhChiDataGridViewTextBoxColumn.HeaderText = "SoTinhChi";
            this.soTinhChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTinhChiDataGridViewTextBoxColumn.Name = "soTinhChiDataGridViewTextBoxColumn";
            this.soTinhChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // monHocBindingSource1
            // 
            this.monHocBindingSource1.DataMember = "MonHoc";
            this.monHocBindingSource1.DataSource = this.quanLyDiemSinhVienDataSet8;
            // 
            // quanLyDiemSinhVienDataSet8
            // 
            this.quanLyDiemSinhVienDataSet8.DataSetName = "QuanLyDiemSinhVienDataSet8";
            this.quanLyDiemSinhVienDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.quanLyDiemSinhVienDataSet7;
            // 
            // quanLyDiemSinhVienDataSet7
            // 
            this.quanLyDiemSinhVienDataSet7.DataSetName = "QuanLyDiemSinhVienDataSet7";
            this.quanLyDiemSinhVienDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // monHocTableAdapter1
            // 
            this.monHocTableAdapter1.ClearBeforeFill = true;
            // 
            // ucMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvMonHoc);
            this.Name = "ucMonHoc";
            this.Size = new System.Drawing.Size(1154, 740);
            this.Load += new System.EventHandler(this.ucMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinhChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QuanLyDiemSinhVienDataSet7 quanLyDiemSinhVienDataSet7;
        private QuanLyDiemSinhVienDataSet7TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource1;
        private QuanLyDiemSinhVienDataSet8 quanLyDiemSinhVienDataSet8;
        private QuanLyDiemSinhVienDataSet8TableAdapters.MonHocTableAdapter monHocTableAdapter1;
    }
}
