 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTNoiThat.Control;
using QL_TTNoiThat.Object;

namespace QL_TTNoiThat.View
{
    public partial class DSHangHoa : Form
    {
        HangHoaCtrl hhctr = new HangHoaCtrl();
        HangHoaObj hhObj = new HangHoaObj();
        public DSHangHoa()
        {
            InitializeComponent();
        }

        private void DSHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHangHoa = new DataTable();
            dtHangHoa = hhctr.getData();
            dgvDSHH.DataSource = dtHangHoa;
        }
    }
}
