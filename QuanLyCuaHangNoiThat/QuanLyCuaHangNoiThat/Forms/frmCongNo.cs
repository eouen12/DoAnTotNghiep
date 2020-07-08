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
using QuanLyCuaHangNoiThat.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmCongNo : Form
    {
        private List<CONGNO> lstCongNo = new List<CONGNO>();
        private List<KHACHHANG> lstKhachhang = new List<KHACHHANG>();
        private List<LICHSUTRANO> lstTraNo = new List<LICHSUTRANO>();
        public frmCongNo()
        {
            InitializeComponent();
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {
            //try
            {
                dgvCongNo.DataSource = CongNoBUS.LayDanhSachCongNo().ToList();
                LoadDSCN();
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void LoadDSCN()
        {
            lstKhachhang = KhachHangBUS.LayDanhSachKhachHang();
            lstCongNo = CongNoBUS.LayDanhSachCongNo();
            try
            {
                var kq = from cn in lstCongNo
                         select new
                         {
                             cn.MACONGNO,
                             cn.MAKH,
                             cn.KHACHHANG.TENKH,
                             cn.TONGTIEN,
                             cn.TIENCONNO,
                             cn.NGAYTRA,
                         };
                this.dgvCongNo.DataSource = kq.ToList();
                this.dgvCongNo.AutoGenerateColumns = false;
            }
            catch
            {
                lstKhachhang = KhachHangBUS.LayDanhSachKhachHang();
                lstCongNo = CongNoBUS.LayDanhSachCongNo();
                var kq = from cn in lstCongNo
                         select new
                         {
                             cn.MACONGNO,
                             cn.MAKH,
                             cn.KHACHHANG.TENKH,
                             cn.TONGTIEN,
                             cn.TIENCONNO,
                             cn.NGAYTRA,
                         };
              this.dgvCongNo.DataSource = kq.ToList();
            this.dgvCongNo.AutoGenerateColumns = false;
            }


        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            CapNhatCongNo();
            LoadDSCN();
            Reset();
        }

        //void XoaCongNo()
        //{
        //   int tcn =int.Parse(txtTienConNo.Text);
        //    if(tcn == 0 )
        //    {
        //        CongNoBUS.XoaCongNo(macn);
        //    }    
        //}

        private void dgvCongNo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvCongNo.CurrentRow.Selected)
            {
                this.btnXacNhanThanhToan.Enabled = true;
                this.txtSoTienTraHomNay.Enabled = true;

                KHACHHANG kh = KhachHangBUS.LayThongTin(Convert.ToInt32(this.dgvCongNo["MAKHCongNo", e.RowIndex].Value.ToString()));
                this.txtCMNDKHCongNo.Text = kh.CMND;
                this.txtTenKHCongNo.Text = kh.TENKH;
                this.txtDiaChiKHCongNo.Text = kh.DIACHI;
                this.txtSDTKHCongNo.Text = kh.SDT;

                this.lblTongTien.Text = this.dgvCongNo.CurrentRow.Cells["TONGTIEN"].Value.ToString();
                this.txtTienConNo.Text = this.dgvCongNo.CurrentRow.Cells["TIENCONNO"].Value.ToString();
                this.dateTimePickerNgayTra.Value = Convert.ToDateTime(this.dgvCongNo.CurrentRow.Cells["NGAYTRA"].Value);
            }
            else
            {
                this.btnXacNhanThanhToan.Enabled = false;
                this.txtSoTienTraHomNay.Enabled = false;
            }
        }

        private void dgvCongNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCongNo.CurrentRow.Selected)
            {
                this.btnXacNhanThanhToan.Enabled = true;
                this.txtSoTienTraHomNay.Enabled = true;
                this.dateTimePickerNgayTra.Enabled = true;


                KHACHHANG kh = KhachHangBUS.LayThongTin(Convert.ToInt32(this.dgvCongNo["MAKHCongNo", e.RowIndex].Value.ToString()));
                this.txtCMNDKHCongNo.Text = kh.CMND;
                this.txtTenKHCongNo.Text = kh.TENKH;
                this.txtDiaChiKHCongNo.Text = kh.DIACHI;
                this.txtSDTKHCongNo.Text = kh.SDT;

                this.lblTongTien.Text = this.dgvCongNo.CurrentRow.Cells["TONGTIEN"].Value.ToString();
                this.txtTienConNo.Text = this.dgvCongNo.CurrentRow.Cells["TIENCONNO"].Value.ToString();
                this.dateTimePickerNgayTra.Value = Convert.ToDateTime(this.dgvCongNo.CurrentRow.Cells["NGAYTRA"].Value);
            }
            else
            {
                Reset();
            }
        }

        void CapNhatCongNo()
        {
            if (Convert.ToDecimal(this.txtSoTienTraHomNay.Text) > Convert.ToDecimal(this.txtTienConNo.Text))
            {
                MessageBox.Show("Số tiền trả đang lớn hơn tổng số tiền trong hóa đơn !!!", "Lỗi");
                return;
            }
            string macn = this.dgvCongNo.CurrentRow.Cells["MACONGNO"].Value.ToString();
            CongNoBUS.CapNhatCongNo(new CONGNO
            {
                MACONGNO = macn,
                MAKH = this.dgvCongNo.CurrentRow.Cells["MAKHCongNo"].Value.ToString(),
                TONGTIEN = Convert.ToDecimal(this.dgvCongNo.CurrentRow.Cells["TONGTIEN"].Value.ToString()),
                TIENCONNO = Convert.ToDecimal(this.txtTienConNo.Text) - Convert.ToDecimal(this.txtSoTienTraHomNay.Text),
                NGAYTRA = this.dateTimePickerNgayTra.Value,
                TRANGTHAI = true
            });

            LichSuTraNoBUS.TaoLichSuTraNo(new LICHSUTRANO
            {
                MACONGNO = macn,
                NGAYTRA_THEODOI = DateTime.Now,
                TIENTRA_THEODOI = Convert.ToDecimal(this.txtSoTienTraHomNay.Text),
                TRANGTHAI = true,
            });
            MessageBox.Show("Thanh toán thành công !!!", "Thông báo");
        }
        void Reset()
        {
            this.btnXacNhanThanhToan.Enabled = false;
            this.txtSoTienTraHomNay.Enabled = false;
            this.dateTimePickerNgayTra.Enabled = false;
            this.txtCMNDKHCongNo.Clear();
            this.txtTenKHCongNo.Clear();
            this.txtDiaChiKHCongNo.Clear();
            this.txtSDTKHCongNo.Clear();
            this.lblTongTien.Clear();
            this.txtTienConNo.Clear();
            this.dateTimePickerNgayTra.Value = DateTime.Now;
        }

        private void txtSoTienTraHomNay_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}
