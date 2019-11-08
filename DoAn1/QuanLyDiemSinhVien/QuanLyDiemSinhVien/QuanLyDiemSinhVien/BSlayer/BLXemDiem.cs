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
        //Phương thức tìm kiếm
        public DataTable TimMSSV(string MaSinhVien, ref string err)
        {
            string sqlString = "Select * from Diem where MaSinhVien like '%" + MaSinhVien + "%' ";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }
        public DataTable TimML(string MaLop, ref string err)
        {
            string sqlString = "Select * from Diem where MaLop like N'%" + MaLop + "%' ";
            return db.GetDataTable(sqlString, CommandType.Text, ref err);
        }

        //Cập nhật MaLop cho bảng Lop
        public bool CapNhatMaLop(string MaLop, ref string err)
        {
            string sqlString = @"Update Diem set MaLop = N'" + MaLop + "' where MaLop is NULL";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        //cập nhật MaSinhVien cho bảng SinhVien
        public bool CapNhatMaSV(string MaSinhVien, ref string err)
        {
            string sqlString = @"Update Diem set MaSinhVien = N'" + MaSinhVien + "' where MaSinhVien is NULL";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //tìm kiếm   số tín chỉ
        public string STC(string MaSinhVien,string MaLop,ref string err)
        {
           string sqlString = "SELECT SoTinhChi FROM Diem, Lop, MonHoc WHERE Lop.MaMon = MonHoc.MaMon AND Lop.MaLop = Diem.MaLop AND Diem.MaSinhVien = N'" + MaSinhVien + "'AND Diem.MaLop=N'"+MaLop+"'";
           return Convert.ToString(db.ExcuteScalar(sqlString, CommandType.Text,ref err));
        }

        //xóa MaLLop ở bảng Diểm
        public bool XoaMaLOP(string MaLop,ref string err)
        {
            string sqlString = "Delete from Diem where MaLop='" + MaLop + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //thêm MaSinhVienCho Bang Diem
        public bool ThemSV1(string MaSinhVien, ref string err)
        {
            string sqlString = "Insert Into SinhVien Values(" + "'" +
                MaSinhVien + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
    }
}
