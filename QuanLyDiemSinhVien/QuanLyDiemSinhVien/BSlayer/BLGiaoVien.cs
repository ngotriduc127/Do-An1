using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiemSinhVien.DBlayer;
namespace QuanLyDiemSinhVien.BSlayer
{
    class BLGiaoVien
    {
        DBMain db = new DBMain();

        public BLGiaoVien()
        {
            db = new DBMain();
        }

        public DataSet LayTT()
        {
            return db.ExecuteQueryDataSet("select *from GiaoVien", CommandType.Text);
        }
        public bool Them(string MaGiaoVien, string TenGiaoVien, string SDT, string Email, ref string err)
        {
            string sqlString = "Insert Into GiaoVien Values(" + "'" +
                MaGiaoVien + "',N'" + TenGiaoVien + "',N'" + SDT + "',N'" + Email + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(string MaGiaoVien, ref string err)
        {
            string sqlString = "Delete from GiaoVien where MaGiaoVien='" + MaGiaoVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public bool CapNhat(string TenGiaoVien, string SDT, string Email, string MaGiaoVienM, string MaCu, ref string err)
        {

            string sqlString = @"Update GiaoVien Set TenGiaoVien = N'" +
                TenGiaoVien + "',SDT=N'" + SDT + "',Email=N'" + Email + "'," + "MaGiaoVien=N'" + MaGiaoVienM + "' Where MaGiaoVien=N'" + MaCu + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
