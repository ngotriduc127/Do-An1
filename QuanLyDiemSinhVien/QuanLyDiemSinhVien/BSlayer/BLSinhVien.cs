using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.DBlayer;
using QuanLyDiemSinhVien;
namespace QuanLyDiemSinhVien.BSlayer
{
    class BLSinhVien
    {
        DBMain db = null;
        public BLSinhVien()
        {
            db = new DBMain();
        }
       public DataSet LaySV()
       {
            return db.ExecuteQueryDataSet("select *from SinhVien", CommandType.Text);
       }
        public bool Them(string MaNganh, string TenNganh, ref string err)
        {
            string sqlString = "Insert Into Nganh Values(" + "'" +
                MaNganh + "',N'" +
                TenNganh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ThemSV(string MaSinhVien, string TenSinhVien, DateTime NgaySinh, int GioiTinh, string QueQuan, string MaNganh, ref string err)
        {
            string sqlString = "Insert Into SinhVien Values(" + "'" +
                MaSinhVien + "',N'" +
                TenSinhVien + "','" +
                NgaySinh + "','" +
                GioiTinh + "',N'" +
                QueQuan + "','" +
                MaNganh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool CapNhatSV(string MaSinhVien, string TenSinhVien, DateTime NgaySinh, int GioiTinh, string QueQuan, string MaNganh, ref string err)
        {
            string sqlString = @"Update SinhVien Set TenSinhVien = N'" +
               TenSinhVien + "',NgaySinh='" +
               NgaySinh + "', GioiTinh = '" +
               GioiTinh + "', QueQuan=N'" +
                QueQuan+ "',MaNganh='" +
               MaNganh + "' Where MaSinhVien '" + MaSinhVien + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSV2 (string MaNganh, ref string err)
        {
            string sqlString = @"Update SinhVien set MaNganh = N'"+MaNganh+"' where MaNganh is NULL";
            return  db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
                  
        }
        public bool XoaSV(string MaSinhVien, ref string err)
        {
            string sqlString = "Delete From SinhVien where MaSinhVien ='" + MaSinhVien + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
