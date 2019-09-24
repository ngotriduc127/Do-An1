using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using QuanLyDiemSinhVien.DBlayer;

namespace QuanLyDiemSinhVien.BSlayer
{
    class BLDangNhap
    {
        public static string username;
        public static string password;
        DBMain db = null;
        public BLDangNhap()
        {
            db = new DBMain();
        }
        //Tạo tài khoản mới
        public bool ThemUser(string UserName, string Password, ref string err)
        {
            string sqlString = "Insert Into tblUser(ID,Password,PhanQuyen) Values(" + "'" +
                UserName + "','" +
                Password + "','3')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //Lấy thông tin tài khoản đã có trong bảng SQL để đăng nhập
        public DataTable LayUser(string UserName, string Password, ref string err)
        {
            string sqlString = "Select * from tblUser where ID='" + UserName + "' and Password = '" + Password
                + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
    }
}
