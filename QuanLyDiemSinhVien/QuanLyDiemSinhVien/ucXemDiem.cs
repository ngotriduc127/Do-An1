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
    public partial class ucXemDiem : UserControl
    {
        DBMain db = null;
        string err;
        BLXemDiem xd = new BLXemDiem();
        DataTable dtXD = null;
        public ucXemDiem()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            try
            {
                dtXD = new DataTable();
                DataSet ds = xd.LayTT();
                dtXD = ds.Tables[0];
                dgvXemDiemTheoMaSinhVien.DataSource = dtXD;
            }
            catch(Exception)
            {
                MessageBox.Show("Không lấy được thông tin :(");
            }
        }
        private void ucXemDiem_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

      

      

        private void btnTra_Click(object sender, EventArgs e)
        {
          
                dtXD = xd.TimMSSV(txtTimKiem.Text, ref err);
                dgvXemDiemTheoMaSinhVien.DataSource = dtXD;
   
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvXemDiemTheoMaSinhVien.DataSource = xd.TimMSSV(txtTimKiem.Text, ref err);
            dgvXemDiemTheoMaSinhVien.DataSource = xd.TimML(txtTimKiem.Text, ref err);   
        }

        private void btnTinhDiemTrungBinh_Click(object sender, EventArgs e)
        {
            float Diem;
            
        }

       
    }
}
