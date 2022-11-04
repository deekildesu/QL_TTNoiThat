using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTNoiThat.Object
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, dienthoai, email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string MaKhachHang
        {
            get { return ma; }
            set { ma = value; }
        }

        public string TenKhachHang
        {
            get { return ten; }
            set { ten = value; }
        }

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        public KhachHangObj(){}
        public KhachHangObj(string ma, string ten, string gioitinh, string diachi, string dienthoai, string email)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
        }
    }
    
}
