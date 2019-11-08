using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using QuanLyDiemSinhVien.DBlayer;

namespace QuanLyDiemSinhVien.BSlayer
{
    class BLDoiMatKhau
    {
        DBMain db = null;
        public BLDoiMatKhau()
        {
            db = new DBMain();
        }
        //
        public bool CapNhatMatKhau(string matkhaumoi, string taikhoan, string matkhaucu, ref string err)
        {
            string strSQL = "update DangNhap set MatKhau='" +
                matkhaumoi + "' where(TenDangNhap=N'" +
                taikhoan + "' and MatKhau='" +
                matkhaucu + "')";
            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref err);
        }
    }
}
