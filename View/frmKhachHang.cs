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
    public partial class frmKhachHang : Form
    {
        KhachHangCtrl khctr = new KhachHangCtrl();
        KhachHangObj khObj = new KhachHangObj();
        int flag = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang =khctr.getData();
            dgvDanhSachKH.DataSource = dtKhachHang;
            bingding();
        }
        void bingding()
        {
            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "MA_KHACH_HANG");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "TEN_KHACH_HANG");
            cmbgioitinh.DataBindings.Clear();
            cmbgioitinh.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "GIOI_TINH");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "DIA_CHI");
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "DIEN_THOAI");
            txtemail.DataBindings.Clear();
            txtemail.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "EMAIL");
        }
        void dis_en(bool e)
        {
            txtmakh.Enabled = e;
            txtten.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            txtemail.Enabled = e;
            cmbgioitinh.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void ganDuLieu(KhachHangObj khObj)
        {
            khObj.MaKhachHang = txtmakh.Text.Trim();
            khObj.TenKhachHang = txtten.Text.Trim();
            khObj.DiaChi = txtdiachi.Text.Trim();
            khObj.GioiTinh = cmbgioitinh.Text.Trim();
            khObj.DienThoai = txtsdt.Text.Trim();
            khObj.Email = txtemail.Text.Trim();
        }
        void loadcontrol()
        {
            cmbgioitinh.Items.Clear();
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nữ");
        }
        void cleardata()
        {
            txtmakh.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            loadcontrol();
            txtsdt.Text = "";
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            loadcontrol();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khctr.DelData(txtmakh.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(khObj);
            if (flag == 0)
            {
                if (khctr.AddData(khObj))
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khctr.UpdateData(khObj))
                    MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
            dis_en(false);
        }
    }
}
