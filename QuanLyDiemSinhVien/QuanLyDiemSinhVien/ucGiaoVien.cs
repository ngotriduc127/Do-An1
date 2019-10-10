using System;
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
    public partial class ucGiaoVien : UserControl
    {
        BLGiaoVien gv = new BLGiaoVien();
        string err;
        DataTable dtGV = null;
        public ucGiaoVien()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            try
            {
                dtGV = new DataTable();
                DataSet ds = gv.LayTT();
                dtGV = ds.Tables[0];
                dgvGiaoVien.DataSource = dtGV;
            }
            catch(Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng GiaoVien");
            }
        }
        private void ucGiaoVien_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gv.Them(dgvGiaoVien.CurrentRow.Cells[0].Value.ToString(),
                dgvGiaoVien.CurrentRow.Cells[1].Value.ToString(),
                dgvGiaoVien.CurrentRow.Cells[2].Value.ToString(),
                dgvGiaoVien.CurrentRow.Cells[3].Value.ToString(),
                ref err);
            Load_Data(); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                gv.Xoa(dgvGiaoVien.CurrentRow.Cells[0].Value.ToString(), ref err);
                Load_Data();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            gv.CapNhat(dgvGiaoVien.CurrentRow.Cells[0].Value.ToString(),
                dgvGiaoVien.CurrentRow.Cells[1].Value.ToString(),
                dgvGiaoVien.CurrentRow.Cells[2].Value.ToString(),
                dgvGiaoVien.CurrentRow.Cells[3].Value.ToString(),
                ref err);
            Load_Data();
        }
    }
}
