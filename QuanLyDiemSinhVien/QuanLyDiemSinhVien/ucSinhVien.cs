using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSinhVien.DBlayer;
using QuanLyDiemSinhVien.BSlayer;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyDiemSinhVien
{
    public partial class ucSinhVien : UserControl
    {
        DBMain db = null;
        string err;
        BLSinhVien SinhVien = new BLSinhVien();
        DataSet dataset = null;
        DataTable dtSinhVien = null;
        public ucSinhVien()
        {
            InitializeComponent();
            Load_Data();
        }
        public void Load_Data()
        {
            try
            {
                dtSinhVien = new DataTable();
                DataSet ds = SinhVien.LaySV();
                dtSinhVien = ds.Tables[0];
                dgvSinhVien.DataSource = dtSinhVien;
            }
            catch (SqlException)
            {
                MessageBox.Show("Khong tim thay bang SinhVien...");
            }
        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            try
            {
                int GioiTinh = 0;
                if (dgvSinhVien.CurrentRow.Cells[3].Value == gioiTinhDataGridViewCheckBoxColumn)
                    GioiTinh = 0; //Nam
                else
                    GioiTinh = 1; //Nữ          

                //DateTime dt = Convert.ToDateTime(dgvSinhVien.CurrentRow.Cells[2].Value);
                //dt.ToShortDateString();

                // MessageBox.Show(dt.Date.ToString());
                BLSinhVien blNV = new BLSinhVien();
                blNV.ThemSV(dgvSinhVien.CurrentRow.Cells[0].Value.ToString(),
                    dgvSinhVien.CurrentRow.Cells[1].Value.ToString(),
                 Convert.ToDateTime(dgvSinhVien.CurrentRow.Cells[2].Value.ToString()), GioiTinh,
                    dgvSinhVien.CurrentRow.Cells[4].Value.ToString(),
                   dgvSinhVien.CurrentRow.Cells[5].Value.ToString(),
                    ref err); ;

                Load_Data();
                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLSinhVien sv = new BLSinhVien();
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {

                    sv.XoaSV(dgvSinhVien.CurrentRow.Cells[0].Value.ToString(),ref err);
                    Load_Data();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //try
            //{
                int GioiTinh = 0;
                if (dgvSinhVien.CurrentRow.Cells[3].Value == gioiTinhDataGridViewCheckBoxColumn)
                    GioiTinh = 0; //Nam
                else
                    GioiTinh = 1; //Nữ          

                //DateTime dt = Convert.ToDateTime(dgvSinhVien.CurrentRow.Cells[2].Value);
                //dt.ToShortDateString();

                // MessageBox.Show(dt.Date.ToString());
                BLSinhVien blNV = new BLSinhVien();
                blNV.CapNhatSV(dgvSinhVien.CurrentRow.Cells[0].Value.ToString(),
                    dgvSinhVien.CurrentRow.Cells[1].Value.ToString(),
                 Convert.ToDateTime(dgvSinhVien.CurrentRow.Cells[2].Value.ToString()), GioiTinh,
                    dgvSinhVien.CurrentRow.Cells[4].Value.ToString(),
                   dgvSinhVien.CurrentRow.Cells[5].Value.ToString(),
                    ref err); ;

                Load_Data();
                MessageBox.Show("Đã sửa xong!");
            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("Không sửa được. Lỗi rồi!");
            //}
        }
    } 
}

  

   

