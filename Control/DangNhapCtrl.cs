using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TTNoiThat.Models;
using System.Data;
using System.Data.SqlClient;



namespace QL_TTNoiThat.Control
{
    class DangNhapCtrl
    {
        DangnhapMod dnMod = new DangnhapMod();
        public DataTable getID(string sql)
        {
            return dnMod.getID(sql);
        }
    }
}
