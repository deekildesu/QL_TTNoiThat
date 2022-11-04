using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTNoiThat.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, dienthoai, matkhau;
        string ngaysinh;

        public string MaNhanVien
        {
            get { return ma; }
            set { ma = value; }
        }

        public string TenNhanVien
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

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        public string NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, string ngaysinh, string diachi, string dienthoai, string matkhau)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.matkhau = matkhau;
        }
    }
}
