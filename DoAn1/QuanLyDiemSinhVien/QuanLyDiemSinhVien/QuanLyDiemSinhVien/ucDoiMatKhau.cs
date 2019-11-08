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
    public partial class ucDoiMatKhau : UserControl
    {
        string err;
        public ucDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTaiKhoan.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtMatKhauCu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtMatKhauMoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtXacNhanMatKhau.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if ((txtMatKhauMoi.Text == txtXacNhanMatKhau.Text) && txtMatKhauCu.Text == BLDangNhap.password)
                            {
                                //Conn.executeQuery(update);
                                BLDoiMatKhau blDMK = new BLDoiMatKhau();
                                blDMK.CapNhatMatKhau(txtMatKhauMoi.Text, txtTaiKhoan.Text, txtMatKhauCu.Text, ref err);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.SendToBack();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ucChinh ucChinh = new ucChinh();
                this.Controls.Clear();
                ucChinh.Dock = DockStyle.Fill;
                this.Controls.Add(ucChinh);

            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void ucDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = BLDangNhap.username;
        }
    }
}
