using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmLapHoaDon : Form
    {
        private List<SANPHAM> lstSanPham = new List<SANPHAM>();
        private List<HOADONBANHANG> lstHoaDon = new List<HOADONBANHANG>();
        private List<CTHOADONBANHANG> lstCTHD = new List<CTHOADONBANHANG>();
        private string mahd;
        private string makh;
        private string manv;
        private bool dangThaoTac = false;
        public frmLapHoaDon(string makh, string manv)
        {
            InitializeComponent();
            this.makh = makh;
            this.manv = manv;
            this.Text = "Mã khách hàng: " + this.makh + ", Nhân viên: " + this.manv;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(this.lstCTHD.Count == 0)
            {
                return;
            }
            try
            {
                TaoHoaDon(this.makh, this.manv);

                TaoCTHoaDon();

                CapNhatSoLuongSanPham();

                if(this.chkTraGop.Checked)
                {
                    TaoCongNo();
                }    
                MessageBox.Show("Lập hóa đơn thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã lập một hóa đơn";
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                dangThaoTac = false;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            if (this.txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số lượng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSoLuong.Focus();
                return;
            }
            dangThaoTac = true;
            LoadDSCTHD();
            this.txtSoLuong.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(this.txtTimKiem.Text != string.Empty)
            {
                var kq = from sp in lstSanPham
                         where sp.TENSP.Contains(this.txtTimKiem.Text)
                         || sp.MASP.Contains(this.txtTimKiem.Text)
                         || sp.LOAISANPHAM.TENLOAI.Contains(this.txtTimKiem.Text)
                         || sp.NHAPHANPHOI.TENNPP.Contains(this.txtTimKiem.Text)
                         select new
                         {
                             sp.MASP,
                             sp.TENSP,
                             sp.SL_TON,
                             sp.GIABAN,
                             sp.LOAISANPHAM.TENLOAI,
                             sp.NHAPHANPHOI.TENNPP
                         };
                this.dgvDSSanPham.DataSource = kq.ToList();
                this.dgvDSSanPham.AutoSize = true;
                this.dgvDSSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSSP();

            FormatDataGridView();
        }


        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvDSSanPham.CurrentRow.Selected)
            {
                this.btnChonSP.Enabled = true;
                this.txtSoLuong.Enabled = true;
                this.btnXacNhan.Enabled = true;
                this.txtSoLuong.Focus();
            }
            else
            {
                this.btnChonSP.Enabled = false;
                this.txtSoLuong.Enabled = false;
                this.btnXacNhan.Enabled = false;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            if(this.txtSoLuong.Text == string.Empty)
            {
                return;
            }
            if (Convert.ToInt32(this.txtSoLuong.Text) > Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["SOLUONGTON"].Value) && this.txtSoLuong.Text != string.Empty)
            {
                MessageBox.Show("Số lượng nhập không được vượt quá số lượng tồn kho !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSoLuong.Focus();
                return;
            }
        }
        void LoadDSSP()
        {
            lstSanPham = SanPhamBUS.LayDanhSachSanPham();
            lstHoaDon = HoaDonBanHangBUS.LayDanhSachHoaDon();
            var kq = from sp in lstSanPham
                     select sp;
            this.dgvDSSanPham.AutoGenerateColumns = false;
            this.dgvDSSanPham.DataSource = kq.ToList();
        }

        void LoadDSCTHD()
        {
            if (lstCTHD.Count == 0)
            {
                lstCTHD.Add(new CTHOADONBANHANG
                {
                    MASP = this.dgvDSSanPham.CurrentRow.Cells["MASP"].Value.ToString(),
                    SOLUONG = Convert.ToInt32(this.txtSoLuong.Text),
                    DONGIA = Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["GIABAN"].Value) * Convert.ToInt32(this.txtSoLuong.Text),
                    TRANGTHAI = true,
                });
            }
            else
            {
                for (int i = 0; i < lstCTHD.Count; i++)
                {
                    if (lstCTHD[i].MASP == this.dgvDSSanPham.CurrentRow.Cells["MASP"].Value.ToString())
                    {
                        if(lstCTHD[i].SOLUONG >= Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["SOLUONGTON"].Value))
                        {
                            MessageBox.Show("Số lượng sản phẩm vượt mức số lượng tồn !!!", "Thông báo");
                            return;
                        }
                        lstCTHD[i].SOLUONG += Convert.ToInt32(this.txtSoLuong.Text);
                        lstCTHD[i].DONGIA = Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["GIABAN"].Value) * lstCTHD[i].SOLUONG;
                        this.dgvDSChiTietHD.AutoGenerateColumns = false;
                        this.dgvDSChiTietHD.DataSource = lstCTHD.ToList();
                        this.lblTongTien.Text = Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)).ToString("#,##0");
                        return;
                    }
                }
                lstCTHD.Add(new CTHOADONBANHANG
                {
                    MASP = this.dgvDSSanPham.CurrentRow.Cells["MASP"].Value.ToString(),
                    SOLUONG = Convert.ToInt32(this.txtSoLuong.Text),
                    DONGIA = Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["GIABAN"].Value) * Convert.ToInt32(this.txtSoLuong.Text),
                    TRANGTHAI = true,
                });
            }
            this.dgvDSChiTietHD.AutoGenerateColumns = false;
            this.dgvDSChiTietHD.DataSource = lstCTHD.ToList();
            this.lblTongTien.Text = Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)).ToString("#,##0");
        }

        void TaoHoaDon(string makh, string manv)
        {
            if (lstHoaDon.Count == 0)
            {
                mahd = "HD1";
            }
            else
            {
                mahd = lstHoaDon.Select(p => p.MAHD).LastOrDefault();
                int somahd = Convert.ToInt32(mahd.Remove(0, 2)) + 1;
                mahd = "HD" + somahd;
                for (int i = 0; i < lstHoaDon.Count(); i++)
                {
                    if (mahd == lstHoaDon[i].MAHD)
                    {
                        somahd = Convert.ToInt32(mahd.Remove(0, 2)) + 1;
                        mahd = "HD" + somahd;
                    }
                }
            }
            HoaDonBanHangBUS.ThemHoaDon(new HOADONBANHANG
            {
                MAHD = mahd,
                MAKH = makh,
                NV_LAP_HD = manv,
                NGAYLAP = DateTime.Now,
                TONGTIEN = Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)),
                NGAYGIAO = this.dtNgayGiao.Value,
                TRANGTHAI = true
            });
        }

        void TaoCTHoaDon()
        {
            foreach(CTHOADONBANHANG ct in lstCTHD)
            {
                ct.MAHD = mahd;
                CTHoaDonBanHangBUS.ThemCTHoaDon(ct);
            }
        }
        
        void TaoCongNo()
        {
            List<CONGNO> lstcongno = CongNoBUS.LayDanhSachCongNo();
            string macn;
            if (lstcongno.Count == 0)
            {
                macn = "CN1";
            }
            else
            {
                macn = lstcongno.Select(p => p.MACONGNO).LastOrDefault();
                int somacn = Convert.ToInt32(macn.Remove(0, 2)) + 1;
                macn = "CN" + somacn;
                for (int i = 0; i < lstcongno.Count(); i++)
                {
                    if (macn == lstcongno[i].MACONGNO)
                    {
                        somacn = Convert.ToInt32(macn.Remove(0, 2)) + 1;
                        macn = "CN" + somacn;
                    }
                }
            }
            CongNoBUS.ThemCongNo(new CONGNO
            {
                MACONGNO = macn,
                MAKH = makh,
                NV_LAPCN = this.manv,
                NGAYLAP = DateTime.Now.Date,
                TONGTIEN = Convert.ToDecimal(this.lblTongTien.Text),
                TIENCONNO = Convert.ToDecimal(this.lblTongTien.Text) - Convert.ToDecimal(this.txtSoTienTraTrc.Text),
                NGAYTRA = this.dateHanTra.Value.Date,
                TRANGTHAI = true
            });

        }
        private void frmLapHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dangThaoTac)
            {
                if(MessageBox.Show("Đang có sự thay đổi dữ liệu, bạn có chắc chứ ?", "Thông báo", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
            }
        }

        private void chkTraGop_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkTraGop.Checked)
            {
                this.txtSoTienTraTrc.Enabled = true;
                this.dateHanTra.Enabled = true;
            }    
            else
            {
                this.txtSoTienTraTrc.Enabled = false;
                this.dateHanTra.Enabled = false;
            }
        }

        private void dgvDSSanPham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmChiTietSanPham ctsp = new frmChiTietSanPham(this.dgvDSSanPham["MASP", e.RowIndex].Value.ToString());
            ctsp.ShowDialog();
        }

        void FormatDataGridView()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Format = "#,###";
            this.dgvDSSanPham.Columns["GIABAN"].DefaultCellStyle = style;
            this.dgvDSChiTietHD.Columns["ITEMGIATIEN"].DefaultCellStyle = style;
        }

        void CapNhatSoLuongSanPham()
        {
            var sp = SanPhamBUS.LayDanhSachSanPham();

            foreach(var item in lstCTHD)
            {
                var kq = sp.Where(p=>p.MASP == item.MASP).FirstOrDefault();
                int sl_ton = Convert.ToInt32(kq.SL_TON);
                kq.SL_TON = sl_ton - item.SOLUONG;
                SanPhamBUS.SuaSanPham(kq);
            }
        }

        private void dtNgayGiao_Validated(object sender, EventArgs e)
        {
            if(this.dtNgayGiao.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày giao không hợp lệ !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtNgayGiao.Focus();
            }
        }

        private void dateHanTra_Validated(object sender, EventArgs e)
        {
            if (this.dateHanTra.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Hạn trả góp không hợp lệ !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateHanTra.Focus();
            }
        }

        private void txtSoTienTraTrc_Validated(object sender, EventArgs e)
        {
            if(this.txtSoTienTraTrc.Text != string.Empty)
            {
                if(Convert.ToInt32(this.txtSoTienTraTrc.Text) > Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)))
                {
                    MessageBox.Show("Số tiền đặt cọc không được vượt quá tổng tiền !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtSoTienTraTrc.Focus();
                }
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnChonSP_Click(sender, e);
            }
        }

        private void txtSoTienTraTrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
