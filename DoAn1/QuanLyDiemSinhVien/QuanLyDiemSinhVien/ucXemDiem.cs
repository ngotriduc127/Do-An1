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

using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

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
                dgvXemDiemTheoMaSinhVien.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được thông tin :(");
            }
        }
        private void ucXemDiem_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void InExcel(DataGridView dgv, string duongdan, string tentep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            //lấy headerText
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }
 

        public void TongTC()
        {
            int r1 = dgvXemDiemTheoMaSinhVien.Rows.Count;
            float tongTC = 0;
            for (int i = 0; i < r1 - 1; i++)
            {
                tongTC += int.Parse(xd.STC(dgvXemDiemTheoMaSinhVien.Rows[i].Cells[0].Value.ToString(), dgvXemDiemTheoMaSinhVien.Rows[i].Cells[1].Value.ToString(),ref err));
            }
            float.Parse(textBox2.Text = tongTC.ToString());
        }

        private void txtTKMSSV_TextChanged(object sender, EventArgs e)
        {
            dgvXemDiemTheoMaSinhVien.DataSource = xd.TimMSSV(txtTKMSSV.Text, ref err);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InExcel(dgvXemDiemTheoMaSinhVien, @"D:\", "DiemSinhVien");
            MessageBox.Show("Đã in thành tệp excel trong thư mục D:\"");
        }

        private void btnTinhDiemTrungBinh_Click(object sender, EventArgs e)
        {

            int r = dgvXemDiemTheoMaSinhVien.Rows.Count;
            float TongDTB = 0;
            for (int i = 0; i < r - 1; i++)
            {
                TongDTB += float.Parse(dgvXemDiemTheoMaSinhVien.Rows[i].Cells[9].Value.ToString());
            }
            float.Parse(textBox1.Text = TongDTB.ToString());
            TongTC();
            float.Parse(textBox3.Text = (Convert.ToString(float.Parse(textBox1.Text) / float.Parse(textBox2.Text)).ToString()));
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvXemDiemTheoMaSinhVien.DataSource = xd.TimML(txtTimKiem.Text, ref err);
        }
    }
}
