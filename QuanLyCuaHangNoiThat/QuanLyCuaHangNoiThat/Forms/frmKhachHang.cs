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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmKhachHang : Form
    {
        private string manv;
        private int makh;
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
            dgvDSKH.DataSource = KhachHangBUS.LayDanhSachKhachHang();
            //this.dgvDSKH.AutoSize = true;
            //this.dgvDSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //this.dgvDSKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            KH.MAKH = int.Parse(dgvDSKH.CurrentRow.Cells["MAKH"].Value.ToString());
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

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnLapHD.Enabled = true;
            this.makh = Convert.ToInt32(dgvDSKH.CurrentRow.Cells["MAKH"].Value);
            txtCMND.Text = dgvDSKH.CurrentRow.Cells["CMND"].Value.ToString();
            txtDiaChi.Text = dgvDSKH.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtSDT.Text = dgvDSKH.CurrentRow.Cells["SDT"].Value.ToString();
            txtTenKH.Text = dgvDSKH.CurrentRow.Cells["TENKH"].Value.ToString();
        }
    }
}
