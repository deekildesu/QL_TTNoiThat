using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTNoiThat.Object
{
    class HangHoaObj
    {
         string mahang, tenhang, soluong, gianhap, giaban, ghichu;

        public string Ghichu
        {
          get { return ghichu; }
          set { ghichu = value; }
        }

        public string Giaban
        {
          get { return giaban; }
          set { giaban = value; }
        }

        public string Gianhap
        {
           get { return gianhap; }
           set { gianhap = value; }
        }

        public string Soluong
        {
          get { return soluong; }
          set { soluong = value; }
        }

        public string Tenhang
        {
          get { return tenhang; }
          set { tenhang = value; }
        }
        public string Mahang
        {
          get { return mahang; }
          set { mahang = value; }
        }

   
        public HangHoaObj(){}
        public HangHoaObj(string mahang, string tenhang, string soluong, string gianhap, string giaban, string ghichu)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.gianhap = gianhap;
            this.giaban = giaban;
            this.ghichu = ghichu;
        }
    }
}
