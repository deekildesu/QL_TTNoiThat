using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTNoiThat.Object;
using QL_TTNoiThat.Control;
using QL_TTNoiThat.Models;

namespace QL_TTNoiThat.View
{
    public partial class frmHoaDon : Form
    {
        HoaDonCtrl hdCtr = new HoaDonCtrl();
        ChiTietCtrl ctCtr= new ChiTietCtrl();
        HangHoaCtrl hhctr = new HangHoaCtrl();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.getData();
            dgvHD.DataSource = dt;
            bingding();
            txtNgayLap.Enabled = false;
            
        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHD.DataSource,"MA_HOA_DON_BAN");
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", dgvHD.DataSource, "TEN_NHAN_VIEN");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dgvHD.DataSource,"NGAY_BAN");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dgvHD.DataSource,"TEN_KHACH_HANG");

        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void bingding1()
        {
            cbHangHoa.DataBindings.Clear();
            cbHangHoa.DataBindings.Add("Text", dgvDSHH.DataSource, "TEN_MAT_HANG");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDSHH.DataSource, "DON_GIA");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dgvDSHH.DataSource, "SO_LUONG");

        }
        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            txtNhanVien.Enabled = e;
            txtNgayLap.Enabled = e;
            cmbKhachHang.Enabled = e;
            cbHangHoa.Enabled = e;
            btnTaoHD.Enabled = !e;
            btnThemHD.Enabled = e;
            btnXoa.Enabled = !e;
            btnIn.Enabled = !e;
            btncham.Enabled = e;
            btnBot.Enabled = e;
            btnCancel.Enabled = e;
            btnSaveHD.Enabled = e;
            txtSL.Enabled = e;
            txtDonGia.Enabled = e;
        }

         private void LoadcmbKhachHang()
        {
            KhachHangCtrl khctr= new KhachHangCtrl();
            cmbKhachHang.DataSource= khctr.getData();
            cmbKhachHang.DisplayMember="TEN_KHACH_HANG";
            cmbKhachHang.ValueMember="MA_KHACH_HANG";
        }
        private void LoadcmHangHoa()
         {
            DataTable dt = new DataTable();
            HangHoaCtrl hhctr = new HangHoaCtrl();
            cbHangHoa.DataSource = hhctr.getData();
            cbHangHoa.DisplayMember = "TEN_MAT_HANG";
            cbHangHoa.ValueMember = "MA_MAT_HANG";
            
         }

        private void clearData()
        {
            txtMa.Text = "";
            txtNhanVien.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadcmbKhachHang();
            LoadcmHangHoa();
        }
        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = txtNhanVien.Text.Trim();
            hdObj.KhachHang = cmbKhachHang.SelectedValue.ToString();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.getData(txtMa.Text.Trim());
                dgvDSHH.DataSource = dt;
                
            }
            catch
            {
                dgvDSHH.DataSource = null;
                
            }
            bingding1();
        }

        private void dgvDSHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSHH_DataSourceChanged(object sender, EventArgs e)
        {
            //bingding1();
            //DataTable dt = new DataTable();
            //dt = hhctr.getData("Where MA_MAT_HANG='" + cbHangHoa.SelectedValue.ToString() + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    double gia = double.Parse(dt.Rows[0][2].ToString());
            //    txtDonGia.Text = (gia * 1.1).ToString();
            //    txtThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();

            //}
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcmbKhachHang();
            LoadcmHangHoa();

            dgvDSHH.Rows.Clear();
            dgvDSHH.Rows.Add("MA_HD");
            dgvDSHH.Rows.Add("MA_HANG");
            dgvDSHH.Rows.Add("SO_LUONG");
            dgvDSHH.Rows.Add("DON_GIA");

        }

        private void btncham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnSaveHD_Click(object sender, EventArgs e)
        {
            HoaDonObj hdObj=new HoaDonObj();
            addData(hdObj);
            if (hdCtr.AddData(hdObj))
            {
                DataTable dt = new System.Data.DataTable();
                dt = (DataTable)dgvDSHH.DataSource;
                if (ctCtr.AddData(dt))
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }    
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }
    }


}

