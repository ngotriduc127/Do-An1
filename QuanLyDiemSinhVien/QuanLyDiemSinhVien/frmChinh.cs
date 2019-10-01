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
        
        public frmChinh()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.Yellow;
            btnNhapDiem.BackColor = Color.White;
            btnXemDiem.BackColor = Color.White;
            btnThoat.BackColor = Color.White;
            btnThongTin.BackColor = Color.White;
            //
            ucChinh1.BringToFront();
            ucChinh_DangKy1.Visible = false;
            

            
            
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.White;
            btnNhapDiem.BackColor = Color.Yellow;
            btnXemDiem.BackColor = Color.White;
            btnThoat.BackColor = Color.White;
            btnThongTin.BackColor = Color.White;
            //



        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.White;
            btnNhapDiem.BackColor = Color.White;
            btnXemDiem.BackColor = Color.Yellow;
            btnThoat.BackColor = Color.White;
            btnThongTin.BackColor = Color.White;
            //




        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.White;
            btnNhapDiem.BackColor = Color.White;
            btnXemDiem.BackColor = Color.White;
            btnThoat.BackColor = Color.Yellow;
            btnThongTin.BackColor = Color.White;

            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
            {
                btnThoat.BackColor = Color.White;
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.White;
            btnNhapDiem.BackColor = Color.White;
            btnXemDiem.BackColor = Color.White;
            btnThoat.BackColor = Color.White;
            btnThongTin.BackColor = Color.Yellow;
            //
            ThongTin tt = new ThongTin();
            tt.ShowDialog();
        }
    }
}
