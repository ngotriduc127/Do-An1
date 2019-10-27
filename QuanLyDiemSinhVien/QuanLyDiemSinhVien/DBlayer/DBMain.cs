using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using QuanLyDiemSinhVien.DBlayer;

namespace QuanLyDiemSinhVien.DBlayer
{
    class DBMain
    {
        //
        //string ConnStr = @"Data Source=MSI;" + "Initial Catalog=QuanLyDiemSinhVien;" +
            //"Integrated Security = True"; //THAY LẠI ĐƯỜNG DẪN
        string ConnStr = @"Data Source=DESKTOP-EQTRTVT;" + "Initial Catalog=QuanLyDiemSinhVien;" +
            "Integrated Security = True";
       
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            //try
            //{
            comm.ExecuteNonQuery();
            f = true;
            //}
            //catch (SqlException ex)
            //{
            //    error = ex.Message;
            //}
            //finally
            //{
                conn.Close();
            //}
            return f;
        }
        //Hàm lấy thông tin từ bảng
        public DataTable GetDataTable(string strSQL, CommandType ct, ref string err)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }
        public object ExcuteScalar(string strSQL, CommandType ct, ref string err) //số lượng trả ra dòng ô đầu tiên trong dataset
        {
            object data = 0;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
          //  da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            data = comm.ExecuteScalar();        
          //  da.Fill(tb);
            conn.Close();
            return data;
        }
        
        

    }
}
