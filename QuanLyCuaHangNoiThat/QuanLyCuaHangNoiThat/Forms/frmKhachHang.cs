﻿using BUS;
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
        public frmKhachHang(string nhanvien)
        {
            InitializeComponent();
            manv = nhanvien;
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon(this.txtMakh.Text,manv);
            frm.ShowDialog();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Loading();
            this.txtMakh.Text = AutoMaKh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == string.Empty || txtTenKH.Text == string.Empty || txtCMND.Text == string.Empty || txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KHACHHANG KH = new KHACHHANG();
            KH.MAKH = this.txtMakh.Text;
            KH.CMND = this.txtCMND.Text.Trim();
            KH.DIACHI = this.txtDiaChi.Text;
            KH.SDT = this.txtSDT.Text.Trim();
            KH.TENKH = this.txtTenKH.Text;
            KH.TRANGTHAI = true;
            KhachHangBUS.Insert(KH);
            //if (!KhachHangBUS.Insert(KH))
            //{
            //    KhachHangBUS.Insert(new KHACHHANG
            //    {
            //        MAKH = this.txtMakh.Text,
            //        TENKH = this.txtTenKH.Text,
            //        SDT = this.txtSDT.Text,
            //        CMND = this.txtCMND.Text,
            //        DIACHI = this.txtDiaChi.Text,
            //        TRANGTHAI = true,
            //    });
            //}
            MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới khách hàng " + KH.TENKH;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
            Loading();
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == string.Empty || txtTenKH.Text == string.Empty || txtSDT.Text == string.Empty || txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             
            KHACHHANG KH = new KHACHHANG();
            KH.MAKH = this.txtMakh.Text;
            KH.CMND = txtCMND.Text;
            KH.DIACHI = txtDiaChi.Text;
            KH.SDT = txtSDT.Text;
            KH.TENKH = txtTenKH.Text;
            KhachHangBUS.Update(KH);
            MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin khách hàng " + KH.TENKH;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
            Loading();
            Reset();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            string IDKH = this.txtMakh.Text;
            KhachHangBUS.Delete(IDKH);
            MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa thông tin khách hàng " + this.txtTenKH.Text;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
            Loading();
            Reset();
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSua.Enabled = true;
            this.btnHuybo.Enabled = true;
            this.btnLapHD.Enabled = true;
            this.btnThem.Enabled = false;
            txtMakh.Text = dgvDSKH.CurrentRow.Cells["MaKHang"].Value.ToString();
            txtCMND.Text = dgvDSKH.CurrentRow.Cells["CMNDKHang"].Value.ToString();
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

        private void txtCMND_Validated(object sender, EventArgs e)
        {
            if (this.txtCMND.Text == string.Empty)
            {
                return;
            }
            if (!KiemtraDinhDangCMND(this.txtCMND.Text))
            {
                MessageBox.Show("Số CMND không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCMND.Focus();
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
                     where sc.SDT.Contains(chuoi) || sc.TENKH.Contains(chuoi) || sc.CMND.Contains(chuoi)
                     select sc;
            this.dgvDSKH.AutoGenerateColumns = false;
            this.dgvDSKH.DataSource = kq.ToList();
        }

        string AutoMaKh()
        {
            List<KHACHHANG> lstMaKH = KhachHangBUS.LayDanhSachMaKhachHang();
            string ma = lstMaKH.Select(p => p.MAKH).LastOrDefault();
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
        
        void Reset()
        {
            this.btnSua.Enabled = false;
            this.btnHuybo.Enabled = false;
            this.btnLapHD.Enabled = false;
            this.btnThem.Enabled = true;

            this.txtMakh.Text = AutoMaKh();
            this.txtCMND.Clear();
            this.txtDiaChi.Clear();
            this.txtSDT.Clear();
            this.txtTenKH.Clear();
            this.txtTimKiem.Clear();
        }

        bool KiemtraDinhDangSDT(string sdt)
        {
            Regex re = new Regex("^[0-9]{10,10}$");
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
    }
}
