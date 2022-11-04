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
    class HangHoaCtrl
    {
        HangHoaMod hhMod = new HangHoaMod();
        public DataTable getData()
        {
            return hhMod.GetData();
        }
        public bool AddData(HangHoaObj hhObj)
        {
            return hhMod.AddData(hhObj);
        }
        public bool UpdateData(HangHoaObj hhObj)
        {
            return hhMod.UpdateData(hhObj);
        }
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}

