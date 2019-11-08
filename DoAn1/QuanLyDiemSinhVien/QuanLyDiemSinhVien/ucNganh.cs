using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyDiemSinhVien.BSlayer;
using QuanLyDiemSinhVien.DBlayer;

namespace QuanLyDiemSinhVien
{
    public partial class ucNganh : UserControl
    {
        DBMain db = null;
        string err;
        Nganh nganh = new Nganh();
        BLSinhVien SinhVien = new BLSinhVien();
        DataSet dataset = null;
        DataTable dtNganh = null;
        public ucNganh()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            try
            {
                dtNganh = new DataTable();
                DataSet ds = nganh.LayNganh();
                dtNganh = ds.Tables[0];
                dgvNganh.DataSource = dtNganh;

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng");
            }


        }
        private void ucNganh_Load(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Nganh nganhh = new Nganh();
                nganhh.Them(dgvNganh.CurrentRow.Cells[0].Value.ToString(), dgvNganh.CurrentRow.Cells[1].Value.ToString(), ref err);


                Load_Data();
                MessageBox.Show("Đã thêm xong!");
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo", "Hình Như Một Thông Tin Nào Đó Đã Nhập Sai", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Nganh nganhh = new Nganh();
                BLSinhVien SinhVien = new BLSinhVien();

                nganhh.CapNhat(dgvNganh.CurrentRow.Cells[1].Value.ToString(), dgvNganh.CurrentRow.Cells[0].Value.ToString(), textBox1.Text.ToString(), ref err);
                SinhVien.CapNhatSV2(dgvNganh.CurrentRow.Cells[0].Value.ToString(), ref err);
                Load_Data();
                SinhVien.LaySV();
                MessageBox.Show("Đã sửa xong!");
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo", "Bạn Đã Nhập Sai Thông Tin Nào Đó Mời Bạn Nhập Lại", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Nganh nganhh = new Nganh();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    nganhh.Xoa(dgvNganh.CurrentRow.Cells[0].Value.ToString(), ref err);
                    // Cập nhật lại DataGridView
                    Load_Data();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa!");
                }
            }catch(Exception)
            {
                MessageBox.Show("Thông Báo", "Hmmm.Đã lỗi chổ nào rồi sao?? ,Báo cáo lại với người tạo ra phần mềm giúp mình nhé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNganh.CurrentCell.RowIndex;
            textBox1.Text = dgvNganh.Rows[r].Cells[0].Value.ToString();
        }
    }
}
