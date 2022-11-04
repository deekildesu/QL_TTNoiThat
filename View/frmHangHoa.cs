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
    public partial class frmHangHoa : Form
    {
        HangHoaCtrl hhctr = new HangHoaCtrl();
        HangHoaObj hhObj = new HangHoaObj();
        int flag = 0;
        public frmHangHoa()
        {
            InitializeComponent();
        }


        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHangHoa = new DataTable();
            dtHangHoa = hhctr.getData();
            dgvDanhSachHH.DataSource = dtHangHoa;
            bingding();
        }
        void bingding()
        {
            txtMaHang.DataBindings.Clear();
            txtMaHang.DataBindings.Add("Text", dgvDanhSachHH.DataSource, "MA_MAT_HANG");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDanhSachHH.DataSource, "TEN_MAT_HANG");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDanhSachHH.DataSource, "SO_LUONG");
            txtDonGiaNhap.DataBindings.Clear();
            txtDonGiaNhap.DataBindings.Add("Text", dgvDanhSachHH.DataSource, "DON_GIA_NHAP");
            txtDonGIaBan.DataBindings.Clear();
            txtDonGIaBan.DataBindings.Add("Text", dgvDanhSachHH.DataSource, "DON_GIA_BAN");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhSachHH.DataSource, "GHI_CHU");
        }
        void dis_en(bool e)
        {
            txtMaHang.Enabled = e;
            txtTen.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGiaNhap.Enabled = e;
            txtDonGIaBan.Enabled = e;
            txtGhiChu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void ganDuLieu(HangHoaObj hhObj)
        {
            hhObj.Mahang = txtMaHang.Text.Trim();
            hhObj.Tenhang = txtTen.Text.Trim();
            hhObj.Soluong= txtSoLuong.Text.Trim();
            hhObj.Gianhap =  txtDonGiaNhap.Text.Trim();
            hhObj.Giaban =txtDonGIaBan.Text.Trim();
            hhObj.Ghichu= txtGhiChu.Text.Trim();
        }
        void cleardata()
        {
            txtMaHang.Text = "";
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGIaBan.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhctr.DelData(txtMaHang.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHangHoa_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(hhObj);
            if (flag == 0)
            {
                if (hhctr.AddData(hhObj))
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hhctr.UpdateData(hhObj))
                    MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHangHoa_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmHangHoa_Load(sender, e);
            dis_en(false);
        }



    }
}
