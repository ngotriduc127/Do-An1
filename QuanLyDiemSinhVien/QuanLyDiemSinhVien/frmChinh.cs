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
        
        public frmChinh()
        {
            trangthaidangnhap = 0;
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.Yellow;
            btnNhapDiem.BackColor = Color.SkyBlue;
            btnXemDiem.BackColor = Color.SkyBlue;
            btnThoat.BackColor = Color.SkyBlue;
            btnThongTin.BackColor = Color.SkyBlue;
            
            ucChinh1.BringToFront();
                


        }

        //internal void BringToFront(ucChinh_DangKy ucChinh_DangKy)
        //{
        //    throw new NotImplementedException();
        //}

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            
            if (trangthaidangnhap > 0)
            {
                if (trangthaidangnhap >=3)//giáo viên và hiệu trưởng
                {
                    btnDangNhap.BackColor = Color.SkyBlue;
                    btnNhapDiem.BackColor = Color.Yellow;
                    btnXemDiem.BackColor = Color.SkyBlue;
                    btnThoat.BackColor = Color.SkyBlue;
                    btnThongTin.BackColor = Color.SkyBlue;
                    //
                    ucNhapDiem1.BringToFront();
                    ucNhapDiem1.Load_cbbLop();


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
                btnDangNhap.BackColor = Color.SkyBlue;
                btnNhapDiem.BackColor = Color.SkyBlue;
                btnXemDiem.BackColor = Color.Yellow;
                btnThoat.BackColor = Color.SkyBlue;
                btnThongTin.BackColor = Color.SkyBlue;
                //
                ucXemDiem1.BringToFront();


            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.SkyBlue;
            btnNhapDiem.BackColor = Color.SkyBlue;
            btnXemDiem.BackColor = Color.SkyBlue;
            btnThoat.BackColor = Color.Yellow;
            btnThongTin.BackColor = Color.SkyBlue;

            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
            {
                btnThoat.BackColor = Color.SkyBlue;
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (trangthaidangnhap > 0)
            {
                if (trangthaidangnhap == 4)
                {

                    btnDangNhap.BackColor = Color.SkyBlue;
                    btnNhapDiem.BackColor = Color.SkyBlue;
                    btnXemDiem.BackColor = Color.SkyBlue;
                    btnThoat.BackColor = Color.SkyBlue;
                    btnThongTin.BackColor = Color.Yellow;
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
            ucTieuDe1.BringToFront();
           
        }

        private void ucChinh1_Load(object sender, EventArgs e)
        {

        }
        
        private void ucNhapDiem1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
