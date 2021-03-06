﻿using QuanLyCuaHangNoiThat.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.Reporting.WinForms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmHoaDon : Form
    {
        private List<HOADONBANHANG> lstHD = new List<HOADONBANHANG>();
        private List<CTHOADONBANHANG> lstCTHD = new List<CTHOADONBANHANG>();
        private List<SANPHAM> lstDSSP = new List<SANPHAM>();
        private List<KHACHHANG> lstDSKH = new List<KHACHHANG>();
        private HOADONBANHANG hd = new HOADONBANHANG();
        private string manv;

        public frmHoaDon(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            LoadDSHoaDon();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if(this.lblMaHD.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            frmChinhSuaCTHoaDon frm = new frmChinhSuaCTHoaDon(hd,this.manv);
            frm.ShowDialog();
            LoadDSHoaDon();
            Reset();
            
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSHoaDon();

            FormatDataGridView();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text != string.Empty)
            {
                var kq = from hd in lstHD
                         where hd.MAHD.Contains(this.txtTimKiem.Text)
                         || hd.KHACHHANG.TENKH.Contains(this.txtTimKiem.Text)
                         || hd.MAKH.Contains(this.txtTimKiem.Text)
                         select new
                         {
                             hd.MAHD,
                             hd.MAKH,
                             hd.KHACHHANG.TENKH,
                             hd.NGAYGIAO,
                             hd.TONGTIEN,
                             hd.NV_LAP_HD,
                             hd.NGAYLAP
                         };
                this.dgvDanhSachHD.DataSource = kq.ToList();
                this.dgvDanhSachHD.AutoGenerateColumns = false;
            }
            else
            {
                LoadDSHoaDon();
            }
        }

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblMaHD.Text = this.dgvDanhSachHD.CurrentRow.Cells["MAHD"].Value.ToString();
            hd = lstHD.Where(p => p.MAHD == this.lblMaHD.Text).FirstOrDefault();
            if (hd.TRANGTHAI == false)
            {
                this.btnSuaHD.Enabled = false;
                this.btnChotDon.Enabled = false;
            }
            else
            {
                this.btnSuaHD.Enabled = true;
                this.btnChotDon.Enabled = true;
            }    


            this.lblTenKH.Text = this.dgvDanhSachHD.CurrentRow.Cells["TENKH"].Value.ToString();
            this.lblTenNhanVien.Text = this.dgvDanhSachHD.CurrentRow.Cells["NVLAPHD"].Value.ToString();
            this.lblNgayLapHD.Text = Convert.ToDateTime(this.dgvDanhSachHD.CurrentRow.Cells["NGAYLAP"].Value).ToString("dd/MM/yyyy");
            this.lblTongTien.Text = Convert.ToInt32(this.dgvDanhSachHD.CurrentRow.Cells["TONGTIEN"].Value).ToString("#,##0") + " VND";
            this.lblNgayGiaoHang.Text = Convert.ToDateTime(this.dgvDanhSachHD.CurrentRow.Cells["NGAYGIAO"].Value).ToString("dd/MM/yyyy");
            LoadDSCTHD(this.lblMaHD.Text);
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            LoadDSHoaDon();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var kq = from hd in lstHD
                     where hd.NGAYLAP.Value.Date >= this.dtBatDau.Value.Date
                     && hd.NGAYLAP.Value.Date <= this.dtKetThuc.Value.Date
                     select new
                     {
                         hd.MAHD,
                         hd.MAKH,
                         hd.KHACHHANG.TENKH,
                         hd.NGAYGIAO,
                         hd.TONGTIEN,
                         hd.NV_LAP_HD,
                         hd.NGAYLAP
                     };
            this.dgvDanhSachHD.DataSource = kq.ToList();
            this.dgvDanhSachHD.AutoGenerateColumns = false;
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (this.lblMaHD.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmReport frm = new frmReport(this.lblMaHD.Text);
            frm.ShowDialog();
        }

        void LoadDSHoaDon()
        {
            // lstHD = HoaDonBanHangBUS.LayDanhSachHoaDon();
            lstHD = HoaDonBanHangBUS.LayDSHoaDon();
            lstDSKH = KhachHangBUS.LayDanhSachKhachHang();
            var kq = from hd in lstHD
                     join kh in lstDSKH
                     on hd.MAKH equals kh.MAKH
                     select new
                     {
                         hd.MAHD,
                         hd.MAKH,
                         kh.TENKH,
                         hd.NGAYGIAO,
                         hd.TONGTIEN,
                         hd.NV_LAP_HD,
                         hd.NGAYLAP
                     };
            this.dgvDanhSachHD.AutoGenerateColumns = false;
            this.dgvDanhSachHD.DataSource = kq.ToList();
        }

        void LoadDSCTHD(string mahd)
        {
            lstCTHD = CTHoaDonBanHangBUS.LayDSCTHD().Where(p => p.MAHD == mahd).ToList();
            lstDSSP = SanPhamBUS.LayDanhSachSP();
            //var kq = from ct in lstCTHD
            //         select ct;
            var kq = from ct in lstCTHD
                     join sp in lstDSSP
                     on ct.MASP equals sp.MASP
                     select new
                     {
                         ct.MASP,
                         sp.TENSP,
                         ct.DVT,
                         ct.SOLUONG,
                         ct.DONGIA,
                     };
            this.dgvDataChiTietHD.AutoGenerateColumns = false;
            this.dgvDataChiTietHD.DataSource = kq.ToList();
        }

        void Reset()
        {
            this.btnChotDon.Enabled = true;
            this.btnSuaHD.Enabled = true;
            this.txtTimKiem.Clear();
            this.lblMaHD.Text = string.Empty;
            this.lblTenKH.Text = string.Empty;
            this.lblTenNhanVien.Text = string.Empty;
            this.lblTongTien.Text = string.Empty;
            this.lblNgayLapHD.Text = string.Empty;
            this.lblNgayGiaoHang.Text = string.Empty;
            this.dgvDataChiTietHD.DataSource = null;
        }

        void FormatDataGridView()
        {
            DataGridViewCellStyle styleTien = new DataGridViewCellStyle();
            DataGridViewCellStyle styleNgay = new DataGridViewCellStyle();
            styleTien.Format = "#,##0";
            styleNgay.Format = "dd/MM/yyyy";
            this.dgvDanhSachHD.Columns["TONGTIEN"].DefaultCellStyle = styleTien;
            this.dgvDanhSachHD.Columns["NGAYGIAO"].DefaultCellStyle = styleNgay;
            this.dgvDanhSachHD.Columns["NGAYLAP"].DefaultCellStyle = styleNgay;
            this.dgvDataChiTietHD.Columns["DONGIA"].DefaultCellStyle = styleTien;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lstHD = HoaDonBanHangBUS.LayDSHoaDon();
            lstCTHD = CTHoaDonBanHangBUS.LayDSCTHD();
            lstDSSP = SanPhamBUS.LayDanhSachSP();
        }

        private void btnChotDon_Click(object sender, EventArgs e)
        {
            hd.TRANGTHAI = false;
            HoaDonBanHangBUS.CapNhatHoaDon(hd);
            Reset();
        }
    }
}
