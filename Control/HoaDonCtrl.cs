using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_TTNoiThat.Object;
using QL_TTNoiThat.Models;

namespace QL_TTNoiThat.Control
{
    class HoaDonCtrl
    {
        HoaDonMod hdMod = new HoaDonMod();
        public DataTable getData()
        {
            return hdMod.GetData();
        }
        public bool AddData(HoaDonObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}
