using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using QuanLyDiemSinhVien.BSlayer;

using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyDiemSinhVien
{
    public partial class ucNhapDiem : UserControl
    {

        BLNhapDiem blnd = new BLNhapDiem();
        System.Data.DataTable dtDiem = new System.Data.DataTable();
        string err;
        int giatrinhapvao = 0;
        public ucNhapDiem()
        {
            InitializeComponent();
        }
        private void ucNhapDiem_Load(object sender, EventArgs e)
        {

        }
        public void Load_cbbLop()
        {
            cbbChonLop.DisplayMember = "MaLop";
            cbbChonLop.DataSource = blnd.LayMaGiaoVien(BLDangNhap.username.ToString());
        }
        public void Load_Dgv()
        {
            try
            {
                dtDiem = new System.Data.DataTable();
                dtDiem.Clear();
                DataSet ds = blnd.LayLop(this.cbbChonLop.Text.ToString());
                dtDiem = ds.Tables[0];

                dgvDiem.DataSource = dtDiem;
                dgvDiem.Columns[0].HeaderText = "Mã Sinh Viên";
                dgvDiem.Columns[1].HeaderText = "Tên Sinh Viên";
                dgvDiem.Columns[2].HeaderText = "Điểm Lần 1";
                dgvDiem.Columns[3].HeaderText = "Điểm Lần 2";
                dgvDiem.Columns[4].HeaderText = "Điểm Lần 3";
                dgvDiem.Columns[5].HeaderText = "Điểm Lần 4";
                dgvDiem.Columns[6].HeaderText = "Điểm Chuyên Cần";
                dgvDiem.Columns[7].HeaderText = "Điểm Quá Trình";
                dgvDiem.Columns[8].HeaderText = "Điểm Thi";
                dgvDiem.Columns[9].HeaderText = "Điểm Trung Bình";
                dgvDiem.Columns[10].HeaderText = "Xếp Loại";
                //Không thể thay đổi giá trị trong 2 cột này
                dgvDiem.Columns[0].ReadOnly = true;
                dgvDiem.Columns[1].ReadOnly = true;






            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng !");
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            Load_Dgv();
            btnLuu.Visible = true;
            btnReset.Visible = true;
            btnXepLoai.Visible = true;
            btnIn.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDiem.RowCount - 1; i++)
                    for (int j = 0; j < dgvDiem.ColumnCount - 1; j++)
                        if (float.Parse(dgvDiem.Rows[i].Cells[j].Value.ToString()) < 0 || float.Parse(dgvDiem.Rows[i].Cells[j].Value.ToString()) > 10)
                        {
                            MessageBox.Show("Giá trị không hợp lệ!");
                        }
                        else
                        {

                            blnd.CapNhat(dgvDiem.CurrentRow.Cells[0].Value.ToString(),
                                 float.Parse(dgvDiem.CurrentRow.Cells[2].Value.ToString()),
                                 float.Parse(dgvDiem.CurrentRow.Cells[3].Value.ToString()),
                                 float.Parse(dgvDiem.CurrentRow.Cells[4].Value.ToString()),
                                 float.Parse(dgvDiem.CurrentRow.Cells[5].Value.ToString()),
                                 float.Parse(dgvDiem.CurrentRow.Cells[6].Value.ToString()),
                                 float.Parse(dgvDiem.CurrentRow.Cells[7].Value.ToString()),
                                 float.Parse(dgvDiem.CurrentRow.Cells[8].Value.ToString()),
                                  (float.Parse(dgvDiem.CurrentRow.Cells[2].Value.ToString()) +
                                  float.Parse(dgvDiem.CurrentRow.Cells[3].Value.ToString()) +
                                  float.Parse(dgvDiem.CurrentRow.Cells[4].Value.ToString()) +
                                  float.Parse(dgvDiem.CurrentRow.Cells[5].Value.ToString()) +
                                 float.Parse(dgvDiem.CurrentRow.Cells[6].Value.ToString()) +
                                 float.Parse(dgvDiem.CurrentRow.Cells[7].Value.ToString()) +
                                 float.Parse(dgvDiem.CurrentRow.Cells[8].Value.ToString())
                                  ) / 7, //Tinh Diem Trung Binh
                                 ref err);
                            //dgvDiem.CurrentRow.Cells
                            Load_Dgv();

                            MessageBox.Show("Lưu thành công!");
                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < 10; i++)
                dgvDiem.CurrentRow.Cells[i].Value = 0;



        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDiem.RowCount - 1; i++)
            {
                if (float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) >= 8)
                {
                    dgvDiem.Rows[i].Cells[10].Value = "Giỏi";
                }
                if ((float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) < 8) && (float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) >= 6.5))
                {
                    dgvDiem.Rows[i].Cells[10].Value = "Khá";
                }
                if ((float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) < 6) && (float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) > 5))
                {
                    dgvDiem.Rows[i].Cells[10].Value = "Trung Bình";
                }
                if ((float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) < 5) && (float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) > 0))
                {
                    dgvDiem.Rows[i].Cells[10].Value = "Yếu";
                }
                if (float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) == 0)
                    dgvDiem.Rows[i].Cells[10].Value = "Chưa Xếp Loại";
            }
        }
        //Hàm in
        private void InExcel(DataGridView dgv, string duongdan, string tentep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            //lấy headerText
            for(int i = 1; i<dgv.Columns.Count +1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (int i= 0;i<dgv.Rows.Count;i++)
            {
                for (int j= 0;j<dgv.Columns.Count;j++)
                {
                    if(dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            InExcel(dgvDiem, @"D:\", "DiemSinhVien");
            MessageBox.Show("Đã in thành tệp excel trong thư mục D:\"");
        }

        private void dgvDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    float a = float.Parse(e.KeyChar.ToString());
                    if (a < 0 || a > 10)
                    {
                        giatrinhapvao = 1;
                    }
                    else
                        e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!");
            }
        }
    }
}
