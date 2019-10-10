using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.DBlayer;
using System.Data;

namespace QuanLyDiemSinhVien.BSlayer
{
   
    class BLLop
    {
        DBMain db = null;
        public BLLop()
        {
            db = new DBMain();
        }
        public DataSet LayTT()
        {
            return db.ExecuteQueryDataSet("select *from Lop", CommandType.Text);
        }
        public bool Them(string MaLop,string MaMon,string PhongHoc, string MaGiaoVien,ref string err )
        {
            string sqlString = "Insert Into Lop Value(" + "'" +
                MaLop + "',N'" +
                MaMon + "',N'" +
                PhongHoc + "',N'" +
                MaGiaoVien + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSV(string MaLop, ref string err)
        {
            string sqlString = "Delete From Lop where MaLOp ='" + MaLop+ "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
