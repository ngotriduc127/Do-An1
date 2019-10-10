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
                dgvDiem.DataSource = dtLop;
            }
            catch(Exception)
            {
                MessageBox.Show("Khong lay duoc thong tin tu bang Lop :(");
            }
        }
        private void ucLop_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lop.Them(dgvDiem.CurrentRow.Cells[0].Value.ToString(),
                dgvDiem.CurrentRow.Cells[1].Value.ToString(),
                dgvDiem.CurrentRow.Cells[2].Value.ToString(),
                dgvDiem.CurrentRow.Cells[3].Value.ToString(),
                ref err);
            Load_Data();
        }
    }
}
