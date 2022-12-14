using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_TTNoiThat.Models;
using QL_TTNoiThat.Object;

namespace QL_TTNoiThat.Control
{
    class ChiTietCtrl
    {
        ChiTietMod ctMod = new ChiTietMod();
        public DataTable getData(string ma)
        {
            return ctMod.GetData(ma);
        }
        public bool AddData(DataTable dt)
        {
            return ctMod.AddData(dt);
        }
        public bool DelData(string ma)
        {
            return ctMod.DelData(ma);
        }
    }
}
