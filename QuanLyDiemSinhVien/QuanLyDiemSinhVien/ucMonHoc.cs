﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSinhVien.BSlayer;
using QuanLyDiemSinhVien.DBlayer;
namespace QuanLyDiemSinhVien
{
    public partial class ucMonHoc : UserControl
    {
        DBMain db = null;
        string err;
        BLMonHoc mh = new BLMonHoc();
        DataTable dtmh = null;

        public ucMonHoc()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            try
            {
                dtmh = new DataTable();
                DataSet ds = mh.LayTT();
                dtmh = ds.Tables[0];
                dgvMonHoc.DataSource = dtmh;

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng");
            }
        }
        private void ucMonHoc_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            try
            {

            BLMonHoc mh = new BLMonHoc();
            int stc = Convert.ToInt32(dgvMonHoc.CurrentRow.Cells[2].Value.ToString());
            mh.Them(dgvMonHoc.CurrentRow.Cells[0].Value.ToString(),
                    dgvMonHoc.CurrentRow.Cells[1].Value.ToString(),
                stc,
                    ref err);
                Load_Data();
                MessageBox.Show("thêm Thành công :))");
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi cmnr :((");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                mh.Xoa(dgvMonHoc.CurrentRow.Cells[0].Value.ToString(), ref err);
                // Cập nhật lại DataGridView
                Load_Data();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa!");
            }
        }

    
        
    }
}
