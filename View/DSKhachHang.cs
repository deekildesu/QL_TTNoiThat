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
    public partial class DSKhachHang : Form
    {
        KhachHangCtrl khctr = new KhachHangCtrl();
        KhachHangObj khObj = new KhachHangObj();
        public DSKhachHang()
        {
            InitializeComponent();
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DSKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = khctr.getData();
            dgvDSKH.DataSource = dtKhachHang;
        }
    }
}
