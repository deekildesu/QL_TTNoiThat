using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TTNoiThat.Object;
using System.Data;
using System.Data.SqlClient;

namespace QL_TTNoiThat.Models
{
    class HangHoaMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt =new DataTable();
            cmd.CommandText = "select * from MATHANG";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }
        public bool AddData(HangHoaObj hhObj) 
        {
            cmd.CommandText = "insert into MATHANG values ('"+hhObj.Mahang+"',N'"+hhObj.Tenhang+"','"+hhObj.Soluong+"',N'"+hhObj.Gianhap+"','"+hhObj.Giaban+"',N''"+",N'"+hhObj.Ghichu+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
             return false;
        }
        public bool UpdateData(HangHoaObj hhObj)
        {
            cmd.CommandText = "update MATHANG set TEN_MAT_HANG= N'" + hhObj.Tenhang+ "',SO_LUONG='" + hhObj.Soluong+ "',DON_GIA_NHAP='" + hhObj.Gianhap + "',DON_GIA_BAN='" + hhObj.Giaban + "', GHI_CHU= '" + hhObj.Ghichu + "' where MA_MAT_HANG='"+hhObj.Mahang+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        } 
        public bool DelData(String ma)
        {
            cmd.CommandText = " delete MATHANG where MA_MAT_HANG='"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
