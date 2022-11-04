using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using QL_TTNoiThat.Object;

namespace QL_TTNoiThat.Models
{
    class HoaDonMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MA_HOA_DON_BAN, hd.NGAY_BAN, nv.TEN_NHAN_VIEN, kh.TEN_KHACH_HANG from HDBAN hd,KHACHHANG kh, NHANVIEN nv where kh.MA_KHACH_HANG = hd.MA_KHACH_HANG and hd.MA_NHAN_VIEN = nv.MA_NHAN_VIEN";
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
        public bool AddData(HoaDonObj hdObj)
        {
            cmd.CommandText = "insert into HDBAN values ('" + hdObj.MaHoaDon + "','" + hdObj.NguoiLap + "',CONVERT(date,'"+hdObj.NgayLap+"',101),N'" + hdObj.KhachHang + "')";
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
            cmd.CommandText = " delete HDBAN where MA_HOA_DON_BAN='" + ma + "'";
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
