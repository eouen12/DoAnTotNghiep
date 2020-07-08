using BUS;
using DTO;
using QuanLyCuaHangNoiThat.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmKhachHang : Form
    {
        private List<KHACHHANG> lstKhachHang = new List<KHACHHANG>();
        private string manv;
        private string makh;
        public frmKhachHang(string nhanvien)
        {
            InitializeComponent();
            manv = nhanvien;
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon(makh,manv);
            frm.ShowDialog();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void Loading()
        {
            lstKhachHang=KhachHangBUS.LayDanhSachKhachHang();
            dgvDSKH.AutoGenerateColumns = false;
            dgvDSKH.DataSource = lstKhachHang;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == string.Empty || txtTenKH.Text == string.Empty || txtCMND.Text == string.Empty || txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                KHACHHANG KH = new KHACHHANG();
                KH.CMND = txtCMND.Text;
                KH.DIACHI = txtDiaChi.Text;
                KH.SDT = txtSDT.Text;
                KH.TENKH = txtTenKH.Text;
                KhachHangBUS.Insert(KH);
                MessageBox.Show("Thêm mới thành công", "Thông báo");
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới khách hàng " + KH.TENKH;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                Loading();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KHACHHANG KH = new KHACHHANG();
            if (txtCMND.Text == string.Empty || txtTenKH.Text == string.Empty || txtSDT.Text == string.Empty || txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            KH.MAKH = dgvDSKH.CurrentRow.Cells["MAKH"].Value.ToString();
            KH.CMND = txtCMND.Text;
            KH.DIACHI = txtDiaChi.Text;
            KH.SDT = txtSDT.Text;
            KH.TENKH = txtTenKH.Text;
            KhachHangBUS.Update(KH);
            MessageBox.Show("Sửa thông tin thành công", "Thông báo");
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin khách hàng " + KH.TENKH;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
            Loading();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            string IDKH = dgvDSKH.CurrentRow.Cells["MAKH"].Value.ToString();
            KhachHangBUS.Delete(IDKH);
            MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo");
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa thông tin khách hàng " + this.txtTenKH.Text;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
            Loading();
        }

        void TimKiemKhachHang(string chuoi)
        {
            var kq = from sc in lstKhachHang
                     where sc.SDT.Contains(chuoi) || sc.TENKH.Contains(chuoi) || sc.CMND.Contains(chuoi)
                     select sc;
            this.dgvDSKH.AutoGenerateColumns = false;
            this.dgvDSKH.DataSource = kq.ToList();
        }
        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSua.Enabled = true;
            this.btnHuybo.Enabled = true;
            this.btnLapHD.Enabled = true;
            this.btnThem.Enabled = false;
            this.makh = dgvDSKH.CurrentRow.Cells["MaKHang"].Value.ToString();
            txtCMND.Text = dgvDSKH.CurrentRow.Cells["CMNDKHang"].Value.ToString();
            txtDiaChi.Text = dgvDSKH.CurrentRow.Cells["DIACHIKHang"].Value.ToString();
            txtSDT.Text = dgvDSKH.CurrentRow.Cells["SDTKHang"].Value.ToString();
            txtTenKH.Text = dgvDSKH.CurrentRow.Cells["TenKHang"].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            {
                if (this.txtTimKiem.Text != string.Empty)
                {
                    TimKiemKhachHang(this.txtTimKiem.Text);
                }
                else
                {
                    Loading();
                }
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
