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
using System.Text.RegularExpressions;

namespace QuanLyDiemSinhVien
{
    public partial class ucNhapDiem : UserControl
    {

        BLNhapDiem blnd = new BLNhapDiem();
        System.Data.DataTable dtDiem = new System.Data.DataTable();
        string err;
        float giatribandau; //lấy giá trị ban đầu của cell
        public ucNhapDiem()
        {
            InitializeComponent();
        }
        private void ucNhapDiem_Load(object sender, EventArgs e)
        {
            Load_cbbLop();
        }
        public void Load_cbbLop()
        {
            if (frmChinh.trangthaidangnhap == 3)
            {
                cbbChonLop.DisplayMember = "MaLop";
                cbbChonLop.DataSource = blnd.LayMaGiaoVien(BLDangNhap.username.ToString());

            }
        }
        public void Load_Dgv()
        {
            try
            {
                dgvDiem.BackgroundColor = Color.MediumSpringGreen;
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
                //Không thể thay đổi giá trị trong các cột này
                dgvDiem.Columns[0].ReadOnly = true;
                //dgvDiem.Columns[0].DataGridView.BackgroundColor = Color.Red;
                dgvDiem.Columns[1].ReadOnly = true;
                dgvDiem.Columns[9].ReadOnly = true;
                dgvDiem.Columns[10].ReadOnly = true;
                //Tô màu
                dgvDiem.EnableHeadersVisualStyles = false;
                dgvDiem.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dgvDiem.Columns[0].DefaultCellStyle.BackColor = Color.OrangeRed;
                dgvDiem.Columns[1].DefaultCellStyle.BackColor = Color.Orange;
                for (int i = 2; i < 9; i++)
                {
                    dgvDiem.Columns[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                dgvDiem.Columns[9].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgvDiem.Columns[10].DefaultCellStyle.BackColor = Color.YellowGreen;







            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng !");
            }
        }
    
       
        //Hàm in
        private void InExcel(DataGridView dgv, string duongdan, string tentep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            //lấy headerText
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
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

  
        //--------------------------------------------------------------------------



        private void btnXem_Click_1(object sender, EventArgs e)
        {

            Load_Dgv();
            btnLuu.Visible = true;
            btnReset.Visible = true;
            btnXepLoai.Visible = true;
            btnIn.Visible = true;
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            InExcel(dgvDiem, @"D:\", "DiemSinhVien");
            MessageBox.Show("Đã in thành tệp excel trong thư mục D:\"");
        }

        private void btnXepLoai_Click_1(object sender, EventArgs e)
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
                if ((float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) < 6.5) && (float.Parse(dgvDiem.Rows[i].Cells[9].Value.ToString()) > 5))
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

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                for (int i = 2; i < 10; i++)
                    dgvDiem.CurrentRow.Cells[i].Value = 0;
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
            
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDiem.RowCount - 1; i++)
                {
                    float diemtb = (float.Parse(dgvDiem.Rows[i].Cells[2].Value.ToString()) +
                        float.Parse(dgvDiem.Rows[i].Cells[3].Value.ToString()) +
                        float.Parse(dgvDiem.Rows[i].Cells[4].Value.ToString()) +
                        float.Parse(dgvDiem.Rows[i].Cells[5].Value.ToString()) +
                        float.Parse(dgvDiem.Rows[i].Cells[6].Value.ToString()) +
                        float.Parse(dgvDiem.Rows[i].Cells[7].Value.ToString()) +
                        float.Parse(dgvDiem.Rows[i].Cells[8].Value.ToString())
                        ) / 7; //Tinh Diem Trung Binh


                    blnd.CapNhat(dgvDiem.Rows[i].Cells[0].Value.ToString(),
                        float.Parse(dgvDiem.Rows[i].Cells[2].Value.ToString()),
                        float.Parse(dgvDiem.Rows[i].Cells[3].Value.ToString()),
                        float.Parse(dgvDiem.Rows[i].Cells[4].Value.ToString()),
                        float.Parse(dgvDiem.Rows[i].Cells[5].Value.ToString()),
                        float.Parse(dgvDiem.Rows[i].Cells[6].Value.ToString()),
                        float.Parse(dgvDiem.Rows[i].Cells[7].Value.ToString()),
                        float.Parse(dgvDiem.Rows[i].Cells[8].Value.ToString()),
                        float.Parse((Math.Ceiling(diemtb * 100) / 100).ToString()), ref err);
                    //dgvDiem.CurrentRow.Cells

                }
                Load_Dgv();
                MessageBox.Show("Lưu thành công!");


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập điểm!");
            }
        }

        //Sự kiện khi tác động đến cell để lấy giá trị ban đầu của cell
        private void dgvDiem_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            int a = 0;
            float GiaTriCu = float.Parse(dgvDiem.CurrentCell.Value.ToString());
            DataGridViewCell cuCell = dgvDiem.CurrentCell;
            string mainStr = dgvDiem.CurrentCell.Value.ToString();
            for (int scan = 0; scan < mainStr.Length; scan++)
            {
                if (Char.IsDigit(mainStr[scan]))
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                    MessageBox.Show("Chỉ được nhập số từ 0 đến 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDiem.CurrentCell.Value = 0;
                    dgvDiem.ClearSelection();
                    dgvDiem.CurrentCell = cuCell;
                    dgvDiem.CurrentCell.Selected = true;
                    break;
                }
            }
            if (a == 1)
            {

                if (float.Parse(mainStr) < 0 || float.Parse(mainStr) > 10)
                {

                    MessageBox.Show("Giá trị phải nằm trong khoảng 0 đến 10");
                    dgvDiem.CurrentCell.Value = giatribandau.ToString();

                }
            }
        }

        private void dgvDiem_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            giatribandau = float.Parse(dgvDiem.CurrentCell.Value.ToString());
            DataGridViewCell cuCell = dgvDiem.CurrentCell;
            string mainStr = dgvDiem.CurrentCell.Value.ToString();
            for (int scan = 0; scan < mainStr.Length; scan++)
            {
                if (Char.IsDigit(mainStr[scan]))
                {
                    //a = 1;
                }
                else
                {
                    // a = 0;
                    MessageBox.Show("Chỉ được nhập số, và phải > 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDiem.CurrentCell.Value = giatribandau;
                    dgvDiem.ClearSelection();
                    dgvDiem.CurrentCell = cuCell;
                    dgvDiem.CurrentCell.Selected = true;
                    break;
                }
            }
        }

        private void dgvDiem_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Chỉ được nhập giá trị số!");
        }
    }
}
