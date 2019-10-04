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

namespace QuanLyDiemSinhVien
{
    public partial class ucChinh_DangKy : UserControl
    {
        string err;
        BLDangNhap blDN = new BLDangNhap();
        public ucChinh_DangKy()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Controls.Clear();
                ucChinh ucChinh = new ucChinh();
                this.Controls.Add(ucChinh);
               
            }

            else if (dialog == DialogResult.No)
            {
                //
            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            if (txtTaiKhoanDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (txtMatKhauDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            if (cbbChucVu.Text=="")
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
            }
            else
                if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
                MessageBox.Show("Hai mật khẩu không khớp!");
            else
            {
                //Thêm dữ liệu vào bảng User trên SQL
                BLDangNhap blDN = new BLDangNhap();
                blDN.ThemUser(this.txtTaiKhoanDK.Text, this.txtMatKhauDK.Text,this.cbbChucVu.Text, ref err);
                MessageBox.Show("Bạn đã đăng kí thành công!");
            }
        }
    }
}
