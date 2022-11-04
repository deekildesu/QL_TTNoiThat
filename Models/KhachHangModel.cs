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
    class KhachHangModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt =new DataTable();
            cmd.CommandText = "select * from KHACHHANG";
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
        public bool AddData(KhachHangObj khObj) 
        {
            cmd.CommandText = "insert into KHACHHANG values ('"+khObj.MaKhachHang+"',N'"+khObj.TenKhachHang+"','"+khObj.GioiTinh+"',N'"+khObj.DiaChi+"','"+khObj.DienThoai+"','"+khObj.Email+"')";
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
        public bool UpdateData(KhachHangObj khObj)
        {
            cmd.CommandText = "update KHACHHANG set TEN_KHACH_HANG= N'" + khObj.TenKhachHang + "',GIOI_TINH=N'" + khObj.GioiTinh + "',DIA_CHI='" + khObj.DiaChi + "',DIEN_THOAI='" + khObj.DienThoai + "', EMAIL= '" + khObj.Email + "' where MA_KHACH_HANG='"+khObj.MaKhachHang+"'";
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
            cmd.CommandText = " delete KHACHHANG where MA_KHACH_HANG='"+ma+"'";
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

