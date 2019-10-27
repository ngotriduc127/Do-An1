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
        public bool Them(string MaLop, string MaMon, string PhongHoc, string MaGiaoVien, ref string err)
        {
            string sqlString = "Insert Into Lop Values(" + "'" +
                MaLop + "',N'" +
                MaMon + "',N'" +
                PhongHoc + "',N'" +
                MaGiaoVien + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // chập nhật cho Bảng Giáo Viên
        public bool CapNhatLop(string MaLop, string MaMon, string PhongHoc, string MaGiaoVien, ref string err)
        {
            string sqlString = @"Update Lop Set MaMOn = N'" +
                MaMon + "',PhongHoc=N'" +
               PhongHoc + "', MaGiaoVien = '" +
               MaGiaoVien + "' Where MaLop'" + MaLop + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatLop2(string MaGiaoVien, ref string err)
        {
            string sqlString = @"Update Lop set MaGiaoVien = N'" + MaGiaoVien + "' where MaGiaoVien is NULL";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        //cập nhật mã môn ở  bảng Môn Học 
        public bool CapNhatMonHoc(string MaMon, ref string err)
        {
            string sqlString = @"Update Lop set MaMon = N'" + MaMon + "' where MaMon is NULL";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //cập nhật bảng lớp
        public bool CapNhatMaLop(string MaMon, string PhongHoc, string MaGiaoVien, string MaLopM, string MaCu, ref string err)
        {
            string sqlString = @"Update Lop Set MaMon = N'" +
                MaMon + "',PhongHoc='" + PhongHoc + "',MaGiaoVien=N'" + MaGiaoVien + "'," + "MaLop=N'" + MaLopM + "' Where MaLop=N'" + MaCu + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        //xóa maLop
        public bool XoaML(string MaLop, ref string err)
        {
            string sqlString = "Delete From Lop where MaLop ='" + MaLop + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //Xóa MaGV
        public bool XoaMaGV(string MaGiaoVien,ref string err)
        {
            string sqlString = "Delete from Lop where MaGiaoVien='" + MaGiaoVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xa mamon o bang monhoc
        public bool XoaMH(string MaMonHoc,ref string err)
        {
            string sqlString = "Delete from Lop where MaMon='" + MaMonHoc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err)
;        }
    }
}
