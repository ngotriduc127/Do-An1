using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiemSinhVien.DBlayer;

namespace QuanLyDiemSinhVien.BSlayer
{
    class Nganh
    {

        DBMain db = null;
        public Nganh()
        {
            db = new DBMain();
        }
        public DataSet LayNganh()
        {
            return db.ExecuteQueryDataSet("select * from Nganh", CommandType.Text);
        }
        public bool Them(string MaNganh, string TenNganh, ref string err)
        {
            string sqlString = "Insert Into Nganh Values(" + "'" +
                MaNganh + "',N'" +
                TenNganh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Xoa(string MaNganh, ref string err)
        {
            string sqlString = "Delete From Nganh where MaNganh ='" + MaNganh + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }



        public bool CapNhat(string TenNganh, string MaNganhM, string MaCu, ref string err)
        {

            string sqlString = @"Update Nganh Set TenNganh = N'" +
                TenNganh + "'," + "MaNganh=N'" + MaNganhM + "' Where MaNganh=N'" + MaCu + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
