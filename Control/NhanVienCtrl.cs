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
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdateData(NhanVienObj nvObj)
        {
            return nvMod.UpdateData(nvObj);
        }
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }

    }
}
