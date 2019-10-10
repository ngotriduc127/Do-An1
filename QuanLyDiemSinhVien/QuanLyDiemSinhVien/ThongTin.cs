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
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            btnSinhVien.BackColor = Color.Yellow;
            btnGiaoVien.BackColor = Color.White;
            btnLop.BackColor = Color.White;
            btnMonhoc.BackColor = Color.White;
            btnNganh.BackColor = Color.White;
            ucSinhVien1.BringToFront();

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            btnSinhVien.BackColor = Color.White;
            btnGiaoVien.BackColor = Color.Yellow;
            btnLop.BackColor = Color.White;
            btnMonhoc.BackColor = Color.White;
            btnNganh.BackColor = Color.White;
            ucGiaoVien1.BringToFront();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            btnSinhVien.BackColor = Color.White;
            btnGiaoVien.BackColor = Color.White;
            btnLop.BackColor = Color.Yellow;
            btnMonhoc.BackColor = Color.White;
            btnNganh.BackColor = Color.White;
            ucLop1.BringToFront();
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            btnSinhVien.BackColor = Color.White;
            btnGiaoVien.BackColor = Color.White;
            btnLop.BackColor = Color.White;
            btnMonhoc.BackColor = Color.Yellow;
            btnNganh.BackColor = Color.White;
            ucMonHoc1.BringToFront();
        }

        private void btnNganh_Click(object sender, EventArgs e)
        {
            btnSinhVien.BackColor = Color.White;
            btnGiaoVien.BackColor = Color.White;
            btnLop.BackColor = Color.White;
            btnMonhoc.BackColor = Color.White;
            btnNganh.BackColor = Color.Yellow;
            ucNganh1.BringToFront();
        }
    }
}
