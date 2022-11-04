using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_TTNoiThat.Object;
using QL_TTNoiThat.Models;

namespace QL_TTNoiThat.Control
{
    class KhachHangCtrl
    {
        KhachHangModel khMod = new KhachHangModel();
        public DataTable getData()
        {
            return khMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);
        }
        public bool UpdateData(KhachHangObj khObj)
        {
            return khMod.UpdateData(khObj);
        }
        public bool DelData(string ma)
        {
            return khMod.DelData(ma);
        }
    }
}
