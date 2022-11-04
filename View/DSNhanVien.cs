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
    public partial class DSNhanVien : Form
    {
        NhanVienCtrl nvctr = new NhanVienCtrl();
        NhanVienObj nvObj = new NhanVienObj();
        public DSNhanVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DSNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvctr.getData();
            dgvDSNV.DataSource = dtNhanVien;
        }


    }
}
