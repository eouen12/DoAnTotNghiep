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
            CongNoBUS.CapNhatCongNo(new CONGNO
            {
                TONGTIEN = Convert.ToDecimal(this.dgvCongNo.CurrentRow.Cells["TONGTIEN"].Value.ToString()),
                TIENCONNO = Convert.ToDecimal(this.dgvCongNo.CurrentRow.Cells["TONGTIEN"].Value.ToString()) - Convert.ToDecimal(this.txtSoTienTraHomNay.Text),
                NGAYTRA = this.dateTimePickerNgayTra.Value,
                TRANGTHAI = true
            });
            LoadDSCN();
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
                this.dateTimePickerNgayTra.Enabled = true;

                KHACHHANG kh = KhachHangBUS.LayThongTin(Convert.ToInt32(this.dgvCongNo["MAKHCongNo", e.RowIndex].Value.ToString()));
                this.txtCMNDKHCongNo.Text = kh.CMND;
                this.txtTenKHCongNo.Text = kh.TENKH;
                this.txtDiaChiKHCongNo.Text = kh.DIACHI;
                this.txtSDTKHCongNo.Text = kh.SDT;

                this.lblTongTien.Text = this.dgvCongNo.CurrentRow.Cells["TONGTIEN"].Value.ToString();
                this.txtTienConNo.Text = this.dgvCongNo.CurrentRow.Cells["TIENCONNO"].Value.ToString();
            }
            else
            {
                this.btnXacNhanThanhToan.Enabled = false;
                this.txtSoTienTraHomNay.Enabled = false;
                this.dateTimePickerNgayTra.Enabled = false;
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
            }
            else
            {
                this.btnXacNhanThanhToan.Enabled = false;
                this.txtSoTienTraHomNay.Enabled = false;
                this.dateTimePickerNgayTra.Enabled = false;
            }
        }
    }
}
