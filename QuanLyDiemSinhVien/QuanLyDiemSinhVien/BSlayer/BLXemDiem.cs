using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.DBlayer;
using System.Data;
namespace QuanLyDiemSinhVien.BSlayer
{
    class BLXemDiem
    {
        DBMain db = null;

        public BLXemDiem()
        {
            db = new DBMain();
        }
        public DataSet LayTT()
        {
            return db.ExecuteQueryDataSet("select *from Diem", CommandType.Text);
        }

     

        public DataTable TimMSSV(string MaSinhVien, ref string err)
        {
            string sqlString = "Select * from Diem where MaSinhVien like N'%" + MaSinhVien + "%' ";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
        public DataTable TimML(string MaLop, ref string err)
        {
            string sqlString = "Select * from Diem where MaLop like N'%" + MaLop + "%' ";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
    }
}
