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
        public bool ThemUser(string UserName, string Password, string ChucVu, ref string err)
        {
            string sqlString = "Insert Into DangNhap(TenDangNhap,MatKhau,ChucVu) Values(" + "'" +
                UserName + "','" +
                Password + "','"+ChucVu+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //Lấy thông tin tài khoản đã có trong bảng SQL để đăng nhập
        public DataTable LayUser(string UserName, string Password, ref string err)
        {
            string sqlString = "Select * from DangNhap where TenDangNhap='" + UserName + "' and MatKhau = '" + Password
                + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
        public DataTable LayQuyen(string UserName, string Password, ref string err)
        {
            string sqlString = "Select ChucVu from DangNhap where TenDangNhap='" + UserName + "' and MatKhau = '" + Password
                + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
            
        }
        public DataTable LayUserDeDK(string UserName,ref string err)
        {
            string sqlString = "Select TenDangNhap from DangNhap where TenDangNhap='" + UserName + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);

        }
        public DataTable LayMaSinhVienDeDangKy (string username, ref string err)
        {
            string sqlString = "Select MaSinhVien from SinhVien where MaSinhVien='" + username + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
        public DataTable LayMaGiaoVienDeDangKy(string username, ref string err)
        {
            string sqlString = "Select MaGiaoVien from GiaoVien where MaGiaoVien='" + username + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
        public DataTable LayMaHieuTruongDeDangKy(string username, ref string err)
        {
            string sqlString = "Select MaHieuTruong from HieuTruong where MaHieuTruong='" + username + "'";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
        //public DataTable LayChucVuDeDangKy(string username, ref string err)
        //{
        //    //string sqlString = "Select MaGiaoVien from GiaoVien where MaGiaoVien='" + username + "'";

        //    return db.GetDataTable(sqlString, CommandType.Text, ref err);
        //}
    }
}
