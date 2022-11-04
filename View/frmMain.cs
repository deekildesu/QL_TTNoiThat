using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTNoiThat.View;
using QL_TTNoiThat.Models;

namespace QL_TTNoiThat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void introduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Introduce f = new Introduce();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon  f = new frmHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSKhachHang f = new DSKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSNhanVien f = new DSNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSHangHoa f = new DSHangHoa();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSCTHD f = new DSCTHD();
            f.MdiParent = this;
            f.Show();
        }
    }
}
