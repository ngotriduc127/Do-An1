using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frmChinh : Form
    {
        public static int trangthaidangnhap;
        public static int hanchequyen;
        public static string chucvu;
        public static string lopcuagiaovien;
        public static int thaydoinoidungbtndangnhapchinh = 0;
        
        public frmChinh()
        {
            trangthaidangnhap = 0;
            InitializeComponent();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            
            if (trangthaidangnhap > 0)
            {
                if (trangthaidangnhap >=3)
                {
                    btnDangNhapChinh.BackColor = Color.SkyBlue;
                    btnNhapDiem.BackColor = Color.Yellow;
                    btnXemDiem.BackColor = Color.SkyBlue;
                    btnThoat2.BackColor = Color.SkyBlue;
                    btnThongTin.BackColor = Color.SkyBlue;
                    thongtin.BackColor = Color.SkyBlue;
                    //
                    ucNhapDiem3.BringToFront();
                    ucNhapDiem3.Load_cbbLop();
                }
                else
                {
                    MessageBox.Show("Sinh viên không được phép vào mục này!");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
            }
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (trangthaidangnhap >0)
            {
                btnDangNhapChinh.BackColor = Color.SkyBlue;                
                btnNhapDiem.BackColor = Color.SkyBlue;
                btnXemDiem.BackColor = Color.Yellow;
                btnThoat2.BackColor = Color.SkyBlue;
                btnThongTin.BackColor = Color.SkyBlue;
                thongtin.BackColor = Color.SkyBlue;
                //
                ucXemDiem2.BringToFront();


            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
            }
        }


        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (trangthaidangnhap > 0)
            {
                if (trangthaidangnhap == 4)
                {
                    btnDangNhapChinh.BackColor = Color.SkyBlue;
                    btnNhapDiem.BackColor = Color.SkyBlue;
                    btnXemDiem.BackColor = Color.SkyBlue;
                    btnThoat2.BackColor = Color.SkyBlue;
                    btnThongTin.BackColor = Color.Yellow;
                    thongtin.BackColor = Color.Yellow;
                    //
                    ThongTin tt = new ThongTin();
                    tt.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Giáo viên và sinh viên không được phép vào mục này!");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            ucTieuDe2.BringToFront();
            var ucDangKy = new ucChinh_DangKy();
            this.Controls.Add(ucDangKy);
        }
    
 

        private void btnDangNhapChinh_Click(object sender, EventArgs e)
        {

            btnDangNhapChinh.BackColor = Color.Yellow;
            btnNhapDiem.BackColor = Color.SkyBlue;
            btnXemDiem.BackColor = Color.SkyBlue;
            btnThoat2.BackColor = Color.SkyBlue;
            btnThongTin.BackColor = Color.SkyBlue;
            thongtin.BackColor = Color.SkyBlue;
            if (btnDangNhapChinh.Text=="ĐĂNG NHẬP")
            {
                ucChinh2.BringToFront();
            }
            else //btnDangNhapChinh.Text=="ĐĂNG XUẤT"
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    trangthaidangnhap = 0;
                    MessageBox.Show("Bạn đã đăng xuất!");
                    ucTieuDe2.BringToFront();
                    btnDangNhapChinh.BackColor = Color.SkyBlue;
                    btnDangNhapChinh.Text = "ĐĂNG NHẬP";
                    thaydoinoidungbtndangnhapchinh = 0;
                    timerDangNhapDangXuat.Enabled = true;
                }
                else if (dialog == DialogResult.No)
                {
                    //
                }
                
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(thaydoinoidungbtndangnhapchinh==1)
            {
                btnDangNhapChinh.Text = "ĐĂNG XUẤT";
                timerDangNhapDangXuat.Enabled = false;
            }
        }

        private void timerChucVuDangNhap_Tick(object sender, EventArgs e)
        {
            if(trangthaidangnhap==2)    //Sinh Viên
            {
                btnXemDiem.Visible = true;
            }

            else if (trangthaidangnhap == 3)  //Giáo Viên
            {
                btnXemDiem.Visible = true;
                btnNhapDiem.Visible = true;
            }
            else if (trangthaidangnhap==4)  //Hiệu Trưởng
            {
                btnThongTin.Visible = true;
                btnXemDiem.Visible = true;
                thongtin.Visible = true;
            }
             else if (trangthaidangnhap==0)
            {
                btnXemDiem.Visible = false;
                btnNhapDiem.Visible = false;
                btnThongTin.Visible = false;
                thongtin.Visible = false;
            }


        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            btnDangNhapChinh.BackColor = Color.SkyBlue;
            btnNhapDiem.BackColor = Color.SkyBlue;
            btnXemDiem.BackColor = Color.SkyBlue;
            btnThoat2.BackColor = Color.Yellow;
            btnThongTin.BackColor = Color.SkyBlue;
            thongtin.BackColor = Color.SkyBlue;

            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
            {
                btnThoat2.BackColor = Color.SkyBlue;
            }
        }

        private void ucChinh2_Load(object sender, EventArgs e)
        {

        }
    }
}
