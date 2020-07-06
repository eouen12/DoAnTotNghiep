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
using BUS;
using DTO;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmHoaDon : Form
    {
        private List<HOADONBANHANG> lstHD = new List<HOADONBANHANG>();
        private List<CTHOADONBANHANG> lstCTHD = new List<CTHOADONBANHANG>();
        private HOADONBANHANG hd = new HOADONBANHANG();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if(this.lblMaHD.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn !!!", "Thông báo");
                return;
            }
            frmChinhSuaCTHoaDon frm = new frmChinhSuaCTHoaDon(hd);
            frm.ShowDialog();
            frmHoaDon_Load(sender, e);
            
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSHoaDon();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text != string.Empty)
            {
                var kq = from hd in lstHD
                         where hd.MAHD.Contains(this.txtTimKiem.Text)
                         || hd.KHACHHANG.TENKH.Contains(this.txtTimKiem.Text)
                         || hd.MAKH == Convert.ToInt32(this.txtTimKiem.Text)
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
            this.lblMaHD.Text = this.dgvDanhSachHD["MAHD", e.RowIndex].Value.ToString();
            this.lblTenKH.Text = this.dgvDanhSachHD["TENKH", e.RowIndex].Value.ToString();
            this.lblTenNhanVien.Text = this.dgvDanhSachHD["NVLAPHD", e.RowIndex].Value.ToString();
            this.lblNgayLapHD.Text = this.dgvDanhSachHD["NGAYLAP", e.RowIndex].Value.ToString();
            this.lblTongTien.Text = Convert.ToInt32(this.dgvDanhSachHD["TONGTIEN", e.RowIndex].Value).ToString("#,##0");
            this.lblNgayGiaoHang.Text = Convert.ToDateTime(this.dgvDanhSachHD["NGAYGIAO", e.RowIndex].Value).ToShortDateString();
            LoadDSCTHD(this.lblMaHD.Text);
            hd = lstHD.Where(p => p.MAHD == this.lblMaHD.Text).FirstOrDefault();
        }

        void LoadDSHoaDon()
        {
            lstHD = HoaDonBanHangBUS.LayDanhSachHoaDon();
            var kq = from hd in lstHD
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

        void LoadDSCTHD(string mahd)
        {
            lstCTHD = CTHoaDonBanHangBUS.LayDSCTHD(mahd);
            var kq = from ct in lstCTHD
                     select new
                     {
                         ct.MASP,
                         ct.SANPHAM.TENSP,
                         ct.SOLUONG,
                         ct.DONGIA
                     };
            this.dgvDataChiTietHD.DataSource = kq.ToList();
            this.dgvDataChiTietHD.AutoGenerateColumns = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTimKiem.Clear();
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

        private void dgvDataChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {

        }
    }
}
