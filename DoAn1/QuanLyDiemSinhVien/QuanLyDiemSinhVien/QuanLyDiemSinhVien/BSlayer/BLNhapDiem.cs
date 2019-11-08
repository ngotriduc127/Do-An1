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
    class BLNhapDiem
    {
        DBMain db = null;
        public BLNhapDiem()
        {
            db = new DBMain();
        }
        public DataTable LayMaGiaoVien(string MaGiaoVien)
        {
            return db.ExecuteQueryDataSet("Select * from Lop where MaGiaoVien='" + MaGiaoVien + "' ", CommandType.Text).Tables[0];
        }
        public DataSet LayLop(string lop)
        {
            return db.ExecuteQueryDataSet("select distinct Diem.MaSinhVien,TenSinhVien,[Diem L1],[Diem L2],[Diem L3],[Diem L4], DiemChuyenCan, DiemQuaTrinh,DiemThi,DiemTrungBinh,XepLoai from Diem, Lop, SinhVien where Diem.MaLop = '"+lop+"' and Diem.MaSinhVien = SinhVien.MaSinhVien", CommandType.Text);
        }
        public bool CapNhat(string MaSV, float DiemL1, float DiemL2, float DiemL3, float DiemL4, float DiemChuyenCan, float DiemQuaTrinh, float DiemThi, float DiemTrungBinh, ref string err)
        {
            string sqlString = "Update Diem set [Diem L1]='"+DiemL1+"',[Diem L2] ='"+DiemL2+"',[Diem L3] = '"+DiemL3 +"', [Diem L4]='"+DiemL4+"', DiemChuyenCan = '"+DiemChuyenCan+"', DiemQuaTrinh='"+DiemQuaTrinh+"',DiemThi='"+DiemThi+"', DiemTrungBinh = '"+DiemTrungBinh+ "' where MaSinhVien='" + MaSV + "'    ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
