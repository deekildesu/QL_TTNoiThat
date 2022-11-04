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
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt =new DataTable();
            cmd.CommandText = "select * from NHANVIEN";
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
        public bool AddData(NhanVienObj nvObj) 
        {
            cmd.CommandText = "insert into NHANVIEN values ('"+nvObj.MaNhanVien+"',N'"+nvObj.TenNhanVien+"','"+nvObj.GioiTinh+"',N'"+nvObj.DiaChi+"','"+nvObj.DienThoai+"',CONVERT(DATE,'"+nvObj.NgaySinh+"',103))";
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
        public bool UpdateData(NhanVienObj nvObj)
        {
            cmd.CommandText = "update NHANVIEN set TEN_NHAN_VIEN= N'" + nvObj.TenNhanVien + "',GIOI_TINH=N'" + nvObj.GioiTinh + "',DIA_CHI='" + nvObj.DiaChi + "',DIEN_THOAI='" + nvObj.DienThoai + "',NGAY_SINH = CONVERT(DATE,'" + nvObj.NgaySinh+ "',103), MAT_KHAU= '" + nvObj.Matkhau + "' where MA_NHAN_VIEN='"+nvObj.MaNhanVien+"'";
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
            cmd.CommandText = " delete NHANVIEN where MA_NHAN_VIEN='"+ma+"'";
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
