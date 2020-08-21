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
        private CONGNO cn = new CONGNO();
        private bool dangThayDoiDL = false;
        private string vitrithaotac = "Công nợ";
        private string manv;
        public frmCongNo(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {
            LoadDSCN();

            FormatDataGridView();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void LoadDSCN()
        {
            lstKhachhang = KhachHangBUS.LayDanhSachKhachHang();
            lstCongNo = CongNoBUS.LayDanhSachCongNo().Where(p=>p.TRANGTHAI ==true).ToList();
            var kq = from cn in lstCongNo
                        join kh in lstKhachhang
                        on cn.MAKH equals kh.MAKH
                        select new
                        {
                            cn.MACONGNO,
                            cn.MAKH,
                            cn.MAHD,
                            kh.TENKH,
                            cn.TONGTIEN,
                            cn.TIENCONNO,
                            cn.NGAYTRA,
                            cn.NV_LAPCN,
                            cn.NGAYLAP
                        };
            this.dgvCongNo.DataSource = kq.ToList();
            this.dgvCongNo.AutoGenerateColumns = false;
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            CapNhatCongNo();
        }


        private void dgvCongNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCongNo.CurrentRow.Selected)
            {
                this.dangThayDoiDL = true;

                this.btnXacNhanThanhToan.Enabled = true;
                this.txtSoTienTraHomNay.Enabled = true;
                this.dateTimePickerNgayTra.Enabled = true;
                this.btnCapNhatHanTraNo.Enabled = true;

                cn = lstCongNo.Where(p => p.MACONGNO == this.dgvCongNo.CurrentRow.Cells["MACONGNO"].Value.ToString() && p.TRANGTHAI == true).FirstOrDefault();

                KHACHHANG kh = KhachHangBUS.LayThongTin(this.dgvCongNo.CurrentRow.Cells["MAKHCongNo"].Value.ToString());
                this.lblTenkh.Text = kh.TENKH;
                this.lblDiaChi.Text = kh.DIACHI;
                this.lblSDT.Text = kh.SDT;

                //tongTien = this.dgvCongNo.CurrentRow.Cells["TONGTIENCN"].Value.ToString();
                //tienConNo = this.dgvCongNo.CurrentRow.Cells["TIENCONNOCN"].Value.ToString();
                this.lblTongTien.Text = Convert.ToDecimal(cn.TONGTIEN).ToString("#,##0") + " VND";
                this.lblTienConNo.Text = Convert.ToDecimal(cn.TIENCONNO).ToString("#,##0") + " VND";
                this.dateTimePickerNgayTra.Value = Convert.ToDateTime(this.dgvCongNo.CurrentRow.Cells["NGAYTRA"].Value);
            }
            else
            {
                Reset();
            }
        }

        void CapNhatHanTraNo()
        {
            CongNoBUS.CapNhatCongNo(new CONGNO
            {
                MACONGNO = cn.MACONGNO,
                MAHD = cn.MAHD,
                MAKH = cn.MAKH,
                TONGTIEN = cn.TONGTIEN,
                TIENCONNO = cn.TIENCONNO,
                NGAYTRA = this.dateTimePickerNgayTra.Value.Date,
                NV_LAPCN = cn.NV_LAPCN,
                NGAYLAP = cn.NGAYLAP.Value.Date,
                TRANGTHAI = cn.TRANGTHAI
            });
            MessageBox.Show("Cập nhật hạn trả nợ thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDSCN();
            Reset();
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật hạn trả nợ của mã công nợ " + cn.MACONGNO;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
            {
                NGAYTAO = DateTime.Now.Date,
                NV_THAOTAC = this.manv,
                VITRI_THAOTAC = this.vitrithaotac,
                GHICHU = lsth
            });
        }

        void CapNhatCongNo()
        {
            if(this.txtSoTienTraHomNay.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tiền trả nợ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if (Convert.ToDecimal(this.txtSoTienTraHomNay.Text) > cn.TIENCONNO)
            {
                MessageBox.Show("Số tiền trả đang lớn hơn số tiền còn nợ trong hóa đơn !!!", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtSoTienTraHomNay.Focus();
                return;
            }
            if (cn.TIENCONNO == Convert.ToDecimal(this.txtSoTienTraHomNay.Text))
            {
                CongNoBUS.CapNhatCongNo(new CONGNO
                {
                    MACONGNO = cn.MACONGNO,
                    MAKH = this.dgvCongNo.CurrentRow.Cells["MAKHCongNo"].Value.ToString(),
                    MAHD = cn.MAHD,
                    TONGTIEN = cn.TONGTIEN,
                    TIENCONNO = 0M,
                    NGAYTRA = cn.NGAYTRA.Value.Date,
                    NV_LAPCN = cn.NV_LAPCN,
                    NGAYLAP = cn.NGAYLAP.Value.Date,
                    TRANGTHAI = false
                });
                //CongNoBUS.XoaCongNo(cn.MACONGNO);
            }
            else
            {
                CongNoBUS.CapNhatCongNo(new CONGNO
                {
                    MACONGNO = cn.MACONGNO,
                    MAKH = this.dgvCongNo.CurrentRow.Cells["MAKHCongNo"].Value.ToString(),
                    MAHD = cn.MAHD,
                    TONGTIEN = cn.TONGTIEN,
                    TIENCONNO = Convert.ToDecimal(cn.TIENCONNO) - Convert.ToDecimal(this.txtSoTienTraHomNay.Text),
                    NGAYTRA = cn.NGAYTRA.Value.Date,
                    NV_LAPCN = cn.NV_LAPCN,
                    NGAYLAP = cn.NGAYLAP.Value.Date,
                    TRANGTHAI = true
                });
            }
            LichSuTraNoBUS.TaoLichSuTraNo(new LICHSUTRANO
            {
                MACONGNO = cn.MACONGNO,
                NGAYTRA_THEODOI = DateTime.Now.Date,
                TIENTRA_THEODOI = Convert.ToDecimal(this.txtSoTienTraHomNay.Text),
                TRANGTHAI = true,
            });
            MessageBox.Show("Thanh toán thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadDSCN();
            Reset();
            string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin của mã công nợ " + cn.MACONGNO;
            LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
            {
                NGAYTAO = DateTime.Now.Date,
                NV_THAOTAC = this.manv,
                VITRI_THAOTAC = this.vitrithaotac,
                GHICHU = lsth
            });
        }
        void Reset()
        {
            this.btnXacNhanThanhToan.Enabled = false;
            this.txtSoTienTraHomNay.Enabled = false;
            this.dateTimePickerNgayTra.Enabled = false;
            this.btnCapNhatHanTraNo.Enabled = false;
            this.lblTenkh.Text = string.Empty;
            this.lblDiaChi.Text = string.Empty;
            this.lblSDT.Text = string.Empty;
            this.lblTongTien.Text = string.Empty;
            this.lblTienConNo.Text = string.Empty;
            this.txtSoTienTraHomNay.Clear();
            this.dateTimePickerNgayTra.Value = DateTime.Now;
            this.dangThayDoiDL = false;

        }

        void FormatDataGridView()
        {
            this.dgvCongNo.Columns["TONGTIENCN"].DefaultCellStyle.Format = "#,##0";
            this.dgvCongNo.Columns["TIENCONNOCN"].DefaultCellStyle.Format = "#,##0";
            this.dgvCongNo.Columns["NGAYLAP"].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvCongNo.Columns["NGAYTRA"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnCapNhatHanTraNo_Click(object sender, EventArgs e)
        {
            if(this.dateTimePickerNgayTra.Value.Date < cn.NGAYLAP.Value.Date)
            {
                MessageBox.Show("Hạn trả nợ không thể nhỏ hơn ngày lập hóa đơn !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateTimePickerNgayTra.Focus();
                return;
            }
            CapNhatHanTraNo();
            LoadDSCN();
            Reset();
        }

        private void txtSoTienTraHomNay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text != string.Empty)
            {
                TimKiem(this.txtTimKiem.Text);
            }
            else
            {
                LoadDSCN();
            }
        }

        void TimKiem(string chuoi)
        {
            var kq = from cn in lstCongNo
                     join kh in lstKhachhang
                     on cn.MAKH equals kh.MAKH
                     where cn.MACONGNO.Contains(chuoi) 
                     || cn.MAKH.Contains(chuoi) 
                     || cn.MAHD.Contains(chuoi)
                     || kh.TENKH.Contains(chuoi)
                     select new
                     {
                         cn.MACONGNO,
                         cn.MAKH,
                         cn.MAHD,
                         kh.TENKH,
                         cn.TONGTIEN,
                         cn.TIENCONNO,
                         cn.NGAYTRA,
                         cn.NV_LAPCN,
                         cn.NGAYLAP
                     };
            this.dgvCongNo.AutoGenerateColumns = false;
            this.dgvCongNo.DataSource = kq.ToList();
        }

        private void frmCongNo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvCongNo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmLSCongNo lscn = new frmLSCongNo(this.dgvCongNo["MACONGNO", e.RowIndex].Value.ToString());
            lscn.ShowDialog();
        }
    }
}
