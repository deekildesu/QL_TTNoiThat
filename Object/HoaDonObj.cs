using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTNoiThat.Object
{
    class HoaDonObj
    {
        string ma, nguoilap, ngaylap, khachhang;

        public string KhachHang
        {
            get { return khachhang; }
            set { khachhang = value; }
        }
        public string NguoiLap
        {
            get { return nguoilap; }
            set { nguoilap = value; }
        }
        public string NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string MaHoaDon
        {
            get { return ma; }
            set { ma = value; }
        }
        public HoaDonObj() { }
        public HoaDonObj(string ma, string nguoilap, string ngaylap, string khachhang)
        {
            this.ma = ma;
            this.ngaylap = ngaylap;
            this.nguoilap = nguoilap;
            this.khachhang = khachhang;

        }
    }
}
