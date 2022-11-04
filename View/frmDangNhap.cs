using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTNoiThat.Models;
using QL_TTNoiThat.Object;
using QL_TTNoiThat.Control;
using System.Data.SqlClient;
namespace QL_TTNoiThat.View
{
    public partial class frmDangNhap : Form
    {
        ConnectToSQL conn = new ConnectToSQL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            DangnhapMod dnMod = new DangnhapMod();
            dt = dnMod.getID("select * from users where taikhoan=N'"+txtTaikhoan.Text+"' and matkhau=N'"+txtMatkhau.Text+"'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Enter(object sender, EventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
        }
    }
}

