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

    public partial class ucChinh : UserControl
    {
        //public static string chucvu;
        string err;
        BLDangNhap blDN = new BLDangNhap();
        
        public ucChinh()
        {
            InitializeComponent();
        }
        private void lbDangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucChinh_DangKy ucChinh_DangKy = new ucChinh_DangKy();

            this.Controls.Clear();
            ucChinh_DangKy.Dock = DockStyle.Fill;
            this.Controls.Add(ucChinh_DangKy);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                    return;
                }

                //
                BLDangNhap blDN = new BLDangNhap();
                DataTable dt = blDN.LayUser(this.txtTenDangNhap.Text, this.txtMatKhau.Text, ref err);
                
                if (dt.Rows.Count > 0)  // Nếu tài khoản và mật khẩu đúng thì bảng sẽ có hàng mới
                {
                    //
                    DataTable CHUCVU= blDN.LayQuyen(this.txtTenDangNhap.Text, this.txtMatKhau.Text, ref err);
                    //frmChinh.chucvu = CHUCVU.Rows[0][0].ToString();//Lấy chức vụ
                    string a = CHUCVU.Rows[0][0].ToString().TrimEnd();//Lấy chức vụ
                    BLDangNhap.username = txtTenDangNhap.Text;
                    BLDangNhap.password = txtMatKhau.Text;
                   
                    
                    MessageBox.Show("Xin chào " + txtTenDangNhap.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                    this.SendToBack();
                    txtMatKhau.ResetText();
                    txtTenDangNhap.ResetText();
                    
                    //Khi dang nhap thanh cong thi moi duoc vao cac button khac
                    frmChinh.trangthaidangnhap = 1;
                    //  
                    if(a =="Sinh Viên")
                    {
                        frmChinh.trangthaidangnhap = 2;
                    }
                    if (a=="Giáo Viên")
                    {
                        frmChinh.trangthaidangnhap = 3;
                    }
                    if (a=="Hi?u Tru?ng")   // Lỗi phông chữ
                    {
                        frmChinh.trangthaidangnhap = 4;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi SQL!!!");
            }
        }

        private void linkLbDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucDoiMatKhau ucDoiMatKhau = new ucDoiMatKhau();

            this.Controls.Clear();
            ucDoiMatKhau.Dock = DockStyle.Fill;
            this.Controls.Add(ucDoiMatKhau);
        }
    }
}
