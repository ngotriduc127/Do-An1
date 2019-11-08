using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.DBlayer;
using System.Data;
namespace QuanLyDiemSinhVien.BSlayer
{
    class BLMonHoc
    {
        DBMain db = null;

        public BLMonHoc()
        {
            db = new DBMain();
        }
        public DataSet LayTT()
        {
            return db.ExecuteQueryDataSet("select *from MonHoc", CommandType.Text);
        }

        public bool Them(string MaMon, string TenMon, int STC, ref string err)
        {
            string sqlString = "Insert Into MonHoc Values(" + "'" +
                MaMon + "',N'" +
                TenMon + "',N'" +
                STC + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Xoa(string MaMon, ref string err)
        {
            string sqlString = "Delete From MonHoc where MaMon ='" + MaMon + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatMH(string TenMon, int SoTinhChi, string MaMonM, string MaCu, ref string err)
        {

            string sqlString = @"Update MonHoc Set TenMon = N'" +
                TenMon + "',SoTinhChi='" + SoTinhChi + "'," + "MaMon=N'" + MaMonM + "' Where MaMon=N'" + MaCu + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
