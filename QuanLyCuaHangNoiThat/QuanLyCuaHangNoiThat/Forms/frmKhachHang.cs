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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmKhachHang : Form
    {
        private List<KHACHHANG> lstKhachHang = new List<KHACHHANG>();
        private string manv;
        private string vitrithaotac = "Khách hàng";
        private bool dangThayDoiDL = false;
        public frmKhachHang(string nhanvien)
        {
            InitializeComponent();
            manv = nhanvien;
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon(this.txtMakh.Text,manv);
            frm.ShowDialog();
            Loading();
            Reset();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Loading();
            this.txtMakh.Text = AutoMaKh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ( txtTenKH.Text == string.Empty || txtSDT.Text == string.Empty || txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KHACHHANG KH = new KHACHHANG();
            KH.MAKH = this.txtMakh.Text;
            KH.DIACHI = this.txtDiaChi.Text;
            KH.SDT = this.txtSDT.Text.Trim();
            KH.TENKH = this.txtTenKH.Text;
            KH.TRANGTHAI = true;
            KhachHangBUS.Insert(KH);
            MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Loading();
            Reset();

            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới khách hàng " + KH.MAKH;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
            {
                NGAYTAO = DateTime.Now.Date,
                NV_THAOTAC = this.manv,
                VITRI_THAOTAC = this.vitrithaotac,
                GHICHU = lsth
            });
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == string.Empty || txtSDT.Text == string.Empty || txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             
            KHACHHANG KH = new KHACHHANG();
            KH.MAKH = this.txtMakh.Text;
            KH.DIACHI = txtDiaChi.Text;
            KH.SDT = txtSDT.Text;
            KH.TENKH = txtTenKH.Text;
            KhachHangBUS.Update(KH);
            MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Loading();
            Reset();
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin khách hàng " + KH.MAKH;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
            {
                NGAYTAO = DateTime.Now.Date,
                NV_THAOTAC = this.manv,
                VITRI_THAOTAC = this.vitrithaotac,
                GHICHU = lsth
            });
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string IDKH = this.txtMakh.Text;
                KhachHangBUS.Delete(IDKH);
                MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loading();
                Reset();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa thông tin khách hàng " + this.txtMakh.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
            }
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSua.Enabled = true;
            this.btnHuybo.Enabled = true;
            this.btnLapHD.Enabled = true;
            this.btnThem.Enabled = false;
            this.dangThayDoiDL = true;
            txtMakh.Text = dgvDSKH.CurrentRow.Cells["MaKHang"].Value.ToString();
            txtDiaChi.Text = dgvDSKH.CurrentRow.Cells["DIACHIKHang"].Value.ToString();
            txtSDT.Text = dgvDSKH.CurrentRow.Cells["SDTKHang"].Value.ToString();
            txtTenKH.Text = dgvDSKH.CurrentRow.Cells["TenKHang"].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
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

        private void txtSDT_Validated(object sender, EventArgs e)
        {
            if (this.txtSDT.Text == string.Empty)
            {
                return;
            }
            if (!KiemtraDinhDangSDT(this.txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSDT.Focus();
            }
        }

        void Loading()
        {
            lstKhachHang = KhachHangBUS.LayDanhSachKhachHang();
            dgvDSKH.AutoGenerateColumns = false;
            dgvDSKH.DataSource = lstKhachHang;

        }

        void TimKiemKhachHang(string chuoi)
        {
            var kq = from sc in lstKhachHang
                     where sc.SDT.Contains(chuoi) || sc.TENKH.Contains(chuoi) || sc.MAKH.Contains(chuoi)
                     select sc;
            this.dgvDSKH.AutoGenerateColumns = false;
            this.dgvDSKH.DataSource = kq.ToList();
        }

        string AutoMaKh()
        {
            List<KHACHHANG> lstMaKH = KhachHangBUS.LayDanhSachMaKhachHang();
            string ma = string.Empty;
            if (lstMaKH.Count == 0)
            {
                ma = "KH1";
                return ma;
            }
            else
            {
                ma = lstMaKH.Select(p => p.MAKH).LastOrDefault();
                int automa = Convert.ToInt32(ma.Remove(0, 2)) + 1;
                ma = "KH" + automa;
                for (int i = 0; i < lstMaKH.Count(); i++)
                {
                    if (ma == lstMaKH[i].MAKH)
                    {
                        automa = Convert.ToInt32(ma.Remove(0, 2)) + 1;
                        ma = "KH" + automa;
                    }
                }
                return ma;
            }
        }
        
        void Reset()
        {
            this.btnSua.Enabled = false;
            this.btnHuybo.Enabled = false;
            this.btnLapHD.Enabled = false;
            this.btnThem.Enabled = true;
            this.dangThayDoiDL = false;

            this.txtMakh.Text = AutoMaKh();
            this.txtDiaChi.Clear();
            this.txtSDT.Clear();
            this.txtTenKH.Clear();
            this.txtTimKiem.Clear();
        }

        bool KiemtraDinhDangSDT(string sdt)
        {
            Regex re = new Regex("^[0-9]{10,11}$");
            if (re.IsMatch(sdt))
                return (true);
            else
                return (false);
        }
        bool KiemtraDinhDangCMND(string cmnd)
        {
            Regex re = new Regex("^[0-9]{10,12}$");
            if (re.IsMatch(cmnd))
                return (true);
            else
                return (false);
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangThayDoiDL)
            {
                if (MessageBox.Show("Đang có sự thay đổi dữ liệu, bạn có chắc chứ ?", "Thông báo",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
