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

namespace QuanLyDiemSinhVien
{
    public partial class ucLop : UserControl
    {
        DBMain db = null;
        string err;
        BLLop lop = new BLLop();
        DataTable dtLop = null;
        public ucLop()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            try
            {
                dtLop = new DataTable();
                DataSet ds = lop.LayTT();
                dtLop = ds.Tables[0];
                dgvLop.DataSource = dtLop;
            }
            catch (Exception)
            {
                MessageBox.Show("Khong lay duoc thong tin tu bang Lop :(");
            }
        }
        private void ucLop_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLop.CurrentCell.RowIndex;
            textBox1.Text = dgvLop.Rows[r].Cells[0].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            try
            {
                BLLop lop = new BLLop();
                lop.CapNhatMaLop(dgvLop.CurrentRow.Cells[1].Value.ToString(),
                    dgvLop.CurrentRow.Cells[2].Value.ToString(),
                    dgvLop.CurrentRow.Cells[3].Value.ToString(),
                    dgvLop.CurrentRow.Cells[0].Value.ToString(),
                    textBox1.Text,
                    ref err);
                Load_Data();
                MessageBox.Show("Cập nhật thành công ");
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo","Bạn Đã Nhập 1 Số Thông Tin Sai",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BLXemDiem xd = new BLXemDiem();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    lop.XoaML(dgvLop.CurrentRow.Cells[0].Value.ToString(), ref err);
                    xd.XoaMaLOP(dgvLop.CurrentRow.Cells[1].Value.ToString(), ref err);
                    Load_Data();
                    MessageBox.Show("Đã xóa xong!");
                    xd.LayTT();

                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo", "Hmmm.Đã lỗi chổ nào rồi sao?? ,Báo cáo lại với người tạo ra phần mềm giúp mình nhé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BLXemDiem diem = new BLXemDiem();
                lop.Them(dgvLop.CurrentRow.Cells[0].Value.ToString(),
                dgvLop.CurrentRow.Cells[1].Value.ToString(),
                dgvLop.CurrentRow.Cells[2].Value.ToString(),
                dgvLop.CurrentRow.Cells[3].Value.ToString(),
                ref err);
                Load_Data();
                MessageBox.Show("thêm Thành công :))");
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo", "Hình Như Một Thông Tin Nào Đó Đã Nhập Sai", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
