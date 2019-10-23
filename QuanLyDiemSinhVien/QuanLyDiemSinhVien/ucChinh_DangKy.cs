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
            //if (cbbChucVu.Text=="")
            //{
            //    MessageBox.Show("Vui lòng chọn chức vụ!");
            //}
            //else
            //    if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
            //    MessageBox.Show("Hai mật khẩu không khớp!");
            if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
            MessageBox.Show("Hai mật khẩu không khớp!");
            else
            {

                DataTable dtHT = blDN.LayMaHieuTruongDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
                DataTable dtGV = blDN.LayMaGiaoVienDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
                DataTable dtSV = blDN.LayMaSinhVienDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
                if (dtSV.Rows.Count==0 && dtGV.Rows.Count == 0 && dtHT.Rows.Count == 0)
                {
                    MessageBox.Show("Hãy dùng mã số để đăng ký!");
                }
                else
                {
                    BLDangNhap blDangKy = new BLDangNhap();
                    DataTable a = blDangKy.LayUserDeDK(txtTaiKhoanDK.Text, ref err);

                    if (a.Rows.Count > 0) //tên tài khoản này đã tồn tại
                    {
                        MessageBox.Show("Tên tài khoản đã được dùng!");
                    }
                    else

                    {
                        //Thêm dữ liệu vào bảng User trên SQL
                        BLDangNhap blDN = new BLDangNhap();
                        blDN.ThemUser(this.txtTaiKhoanDK.Text, this.txtMatKhauDK.Text, this.cbbChucVu.Text, ref err);
                        MessageBox.Show("Bạn đã đăng kí thành công!");
                    }
                }
                


            }
        }

        private void txtTaiKhoanDK_TextChanged(object sender, EventArgs e)
        {
            DataTable dtHT = blDN.LayMaHieuTruongDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
            DataTable dtGV = blDN.LayMaGiaoVienDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
            DataTable dtSV = blDN.LayMaSinhVienDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
            if (dtSV.Rows.Count == 0 && dtGV.Rows.Count == 0 && dtHT.Rows.Count==0)
            {
                cbbChucVu.Text = "--------";
            }
            else if (dtGV.Rows.Count>0)
            {
                cbbChucVu.Text = "Giáo Viên";

            }
            else if (dtSV.Rows.Count>0)
            {
                cbbChucVu.Text = "Sinh Viên";
            }
            else if (dtHT.Rows.Count>0)
            {
                cbbChucVu.Text = "Hiệu Trưởng";
            }

        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
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
            //if (cbbChucVu.Text=="")
            //{
            //    MessageBox.Show("Vui lòng chọn chức vụ!");
            //}
            //else
            //    if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
            //    MessageBox.Show("Hai mật khẩu không khớp!");
            if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
                MessageBox.Show("Hai mật khẩu không khớp!");
            else
            {

                DataTable dtHT = blDN.LayMaHieuTruongDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
                DataTable dtGV = blDN.LayMaGiaoVienDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
                DataTable dtSV = blDN.LayMaSinhVienDeDangKy(txtTaiKhoanDK.Text.ToString().TrimEnd(), ref err);
                if (dtSV.Rows.Count == 0 && dtGV.Rows.Count == 0 && dtHT.Rows.Count == 0)
                {
                    MessageBox.Show("Hãy dùng mã số để đăng ký!");
                }
                else
                {
                    BLDangNhap blDangKy = new BLDangNhap();
                    DataTable a = blDangKy.LayUserDeDK(txtTaiKhoanDK.Text, ref err);

                    if (a.Rows.Count > 0) //tên tài khoản này đã tồn tại
                    {
                        MessageBox.Show("Tên tài khoản đã được dùng!");
                    }
                    else

                    {
                        //Thêm dữ liệu vào bảng User trên SQL
                        BLDangNhap blDN = new BLDangNhap();
                        blDN.ThemUser(this.txtTaiKhoanDK.Text, this.txtMatKhauDK.Text, this.cbbChucVu.Text, ref err);
                        MessageBox.Show("Bạn đã đăng kí thành công!");
                    }
                }



            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
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
    }
}
