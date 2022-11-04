using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTNoiThat.Object
{
    class DangnhapObj
    {
        string username, matkhau, phanquyen;

        public string Phanquyen
        {
            get { return phanquyen; }
            set { phanquyen = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public DangnhapObj() { }
        public DangnhapObj (string username, string matkhau, string phanquyen)
        {
            this.username = username;
            this.matkhau = matkhau;
            this.phanquyen = phanquyen;
        }

    }
}
