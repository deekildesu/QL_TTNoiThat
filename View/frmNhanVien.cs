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
    public partial class frmNhanVien : Form
    {
        NhanVienCtrl nvctr = new NhanVienCtrl();
        NhanVienObj nvObj = new NhanVienObj();
        int flag = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvctr.getData();
            dgvDanhSachNV.DataSource = dtNhanVien;
            bingding();
        }
        void bingding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "MA_NHAN_VIEN");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "TEN_NHAN_VIEN");
            cmbgioitinh.DataBindings.Clear();
            cmbgioitinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GIOI_TINH");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DIA_CHI");
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DIEN_THOAI");
            dtngaysinh.DataBindings.Clear();
            dtngaysinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "NGAY_SINH");
        }
        void dis_en(bool e)
        {
            txtma.Enabled = e;
            txtten.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            dtngaysinh.Enabled = e;
            cmbgioitinh.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void ganDuLieu(NhanVienObj nvObj)
        {
            nvObj.MaNhanVien = txtma.Text.Trim();
            nvObj.TenNhanVien = txtten.Text.Trim();
            nvObj.NgaySinh = dtngaysinh.Text;
            nvObj.DiaChi = txtdiachi.Text.Trim();
            nvObj.GioiTinh = cmbgioitinh.Text.Trim();
            nvObj.DienThoai = txtsdt.Text.Trim();
            nvObj.Matkhau = "";
        }
        void loadcontrol()
        {
            cmbgioitinh.Items.Clear();
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nữ");
        }
        void cleardata( )
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            dtngaysinh.Text = DateTime.Now.Date.ToShortDateString();
            loadcontrol();
            txtsdt.Text="";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            loadcontrol();
            dtngaysinh.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                if (nvctr.DelData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nvObj);
            if (flag == 0)
            {
                if (nvctr.AddData(nvObj))
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvctr.UpdateData(nvObj))
                    MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }
    }
}
