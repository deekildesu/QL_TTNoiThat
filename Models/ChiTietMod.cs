using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_TTNoiThat.Object;

namespace QL_TTNoiThat.Models
{
    class ChiTietMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select ct.MAHD,mh.TEN_MAT_HANG, ct.SO_LUONG,ct.DON_GIA from CTHDBAN ct, MATHANG mh where ct.MA_HANG= mh.MA_MAT_HANG and MAHD='"+ma+"'";
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
        public bool AddData(DataTable dt)
        {        
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++ )
                    cmd.CommandText = "insert into CTHDBAN values ('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Connection;
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
            cmd.CommandText = " delete CTHDBAN where MAHD='" + ma + "'";
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
