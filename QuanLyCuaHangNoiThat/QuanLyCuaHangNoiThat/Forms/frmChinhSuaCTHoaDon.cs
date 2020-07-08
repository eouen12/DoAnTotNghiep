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
    public partial class frmChinhSuaCTHoaDon : Form
    {
        private List<CTHOADONBANHANG> lstcthd = new List<CTHOADONBANHANG>();
        private List<HOADONBANHANG> lstThongTinHD = new List<HOADONBANHANG>();
        private List<SANPHAM> sp = new List<SANPHAM>();
        private HOADONBANHANG hd = new HOADONBANHANG();
        private bool dangThayDoiNgayGiao = false;
        private bool dangThayDoiCTHD = false;
        private string manv;
        public frmChinhSuaCTHoaDon(HOADONBANHANG hoadon,string manv)
        {
            InitializeComponent();
            this.manv = manv;
            hd = hoadon;
            this.Text = "Chỉnh sửa chi tiết: " + hd.MAHD;
        }

        private void ChinhSuaCTHoaDon_Load(object sender, EventArgs e)
        {
            loadDSCTHD(hd.MAHD);

            loadThongTinHD(hd.MAHD);

            AutoCompleteMaSP();

            sp = SanPhamBUS.LayDanhSachSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMasp.Text == string.Empty || this.txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                return;
            }
            if (!SanPhamBUS.KiemTraMaSPTonTai(this.txtMasp.Text))
            {
                MessageBox.Show("Mã sản phẩm không tồn tại !!!", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if(!KiemTraSLMasp(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text)))
            {
                return;
            }

            if (!KiemTraMaspTonTai(this.txtMasp.Text,hd.MAHD))
            {
                CTHoaDonBanHangBUS.ThemCTHoaDon(new CTHOADONBANHANG
                {
                    MAHD = hd.MAHD,
                    MASP = this.txtMasp.Text,
                    SOLUONG = Convert.ToInt32(this.txtSoLuong.Text.Trim()),
                    DONGIA = TinhDonGia(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text)),
                    TRANGTHAI = true
                });
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadDSCTHD(hd.MAHD);
                CapNhatSoLuongSanPham(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text), 0);
                hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                HoaDonBanHangBUS.CapNhatHoaDon(hd);
                this.dangThayDoiCTHD = false;
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm sản phẩm " + this.txtMasp.Text +" vào chi tiết hóa đơn " + hd.MAHD;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                loadThongTinHD(hd.MAHD);
                Reset();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txtMasp.Text == string.Empty || this.txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn dòng sản phẩm muốn cập nhật !!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraSLMasp(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text)))
            {
                return;
            }
            CTHOADONBANHANG ct = new CTHOADONBANHANG
            {
                MAHD = hd.MAHD,
                MASP = this.txtMasp.Text,
                SOLUONG = Convert.ToInt32(this.txtSoLuong.Text.Trim()),
                DONGIA = TinhDonGia(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text))
            };


            if (CTHoaDonBanHangBUS.SuaCTHoaDon(ct))
            {
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadDSCTHD(hd.MAHD);
                CapNhatSoLuongSanPham(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text), 0);
                hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                HoaDonBanHangBUS.CapNhatHoaDon(hd);
                this.dangThayDoiCTHD = false;
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin chi tiết hóa đơn " + hd.MAHD;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                loadThongTinHD(hd.MAHD);
                Reset();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMasp.Text == string.Empty || this.txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn dòng sản phẩm muốn xóa !!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CTHoaDonBanHangBUS.XoaCTHoaDon(hd.MAHD, this.txtMasp.Text))
                {
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadDSCTHD(hd.MAHD);
                    CapNhatSoLuongSanPham(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text), 1);
                    hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                    HoaDonBanHangBUS.CapNhatHoaDon(hd);
                    this.dangThayDoiCTHD = false;
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa sản phẩm " + this.txtMasp.Text + " của chi tiết hóa đơn " + hd.MAHD;
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                    loadThongTinHD(hd.MAHD);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(this.dtNgayGiao.Value == hd.NGAYGIAO)
            {
                MessageBox.Show("Bạn chưa thay đổi dữ liệu 'Ngày giao'", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            hd.NGAYGIAO = dtNgayGiao.Value;
            if (HoaDonBanHangBUS.CapNhatHoaDon(hd))
            {
                MessageBox.Show("Cập nhật ngày giao thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật ngày giao " + this.lblMaHD.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                loadThongTinHD(hd.MAHD);
                this.dangThayDoiNgayGiao = false;
            }
            else
            {
                MessageBox.Show("Cập nhật ngày giao thất bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMasp.Enabled = false;
            this.btnThem.Enabled = false;
            this.dangThayDoiCTHD = true;
            this.txtMasp.Text = this.dgvCTHD.CurrentRow.Cells["MASP"].Value.ToString();
            this.txtSoLuong.Text = this.dgvCTHD.CurrentRow.Cells["SOLUONG"].Value.ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void dtNgayGiao_ValueChanged(object sender, EventArgs e)
        {
            this.dangThayDoiNgayGiao = true;
        }
        private void frmChinhSuaCTHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangThayDoiNgayGiao || dangThayDoiCTHD)
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
        void loadDSCTHD(string mahd)
        {
            lstcthd = CTHoaDonBanHangBUS.LayDSCTHD(mahd);
            this.dgvCTHD.AutoGenerateColumns = false;
            this.dgvCTHD.DataSource = lstcthd;
        }

        void loadThongTinHD(string mahd)
        {
            lstThongTinHD = HoaDonBanHangBUS.LayThongTinCuaHD(mahd);
            var hd = lstThongTinHD.FirstOrDefault();
            this.lblMaHD.Text = hd.MAHD;
            this.lblMaKH.Text = hd.MAKH.ToString();
            this.lblTenKH.Text = hd.KHACHHANG.TENKH;
            this.lblTongTien.Text = Convert.ToInt32(hd.TONGTIEN).ToString("#,##0");
            this.dtNgayGiao.Value = hd.NGAYGIAO.Value;
        }

        void AutoCompleteMaSP()
        {
            List<SANPHAM> lst = SanPhamBUS.LayDanhSachSanPham();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (SANPHAM item in lst)
            {
                collection.Add(item.MASP);
            }
            this.txtMasp.AutoCompleteCustomSource = collection;
            this.txtMasp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtMasp.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        bool KiemTraMaspTonTai(string masp, string mahd)
        {
            for(int i = 0; i < this.dgvCTHD.Rows.Count; i++)
            {
                if(masp == this.dgvCTHD["MASP",i].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        bool KiemTraSLMasp(string masp, int sl)
        {
            var kq = sp.Where(p => p.MASP == masp).FirstOrDefault();
            if (sl > kq.SL_TON)
            {
                MessageBox.Show("Số lượng nhập không thể vượt mức số lượng tồn của sản phẩm !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        void CapNhatSoLuongSanPham(string masp, int sl, int mode)
        {
            var kq = sp.Where(p => p.MASP == masp).FirstOrDefault();
            int sl_ton = Convert.ToInt32(kq.SL_TON);
            if (mode == 0)
            {
                kq.SL_TON = sl_ton - sl;
            }
            if(mode == 1)
            {
                kq.SL_TON = sl_ton + sl;
            }
            SanPhamBUS.SuaSanPham(kq);
        }

        int TinhDonGia(string masp, int sl)
        {
            var kq = sp.Where(p => p.MASP == masp).FirstOrDefault();
            return sl * Convert.ToInt32(kq.GIABAN);
        }
        void Reset()
        {
            this.txtMasp.Clear();
            this.txtSoLuong.Clear();
            this.txtMasp.Enabled = true;
            this.dangThayDoiCTHD = false;
            this.dangThayDoiNgayGiao = false;
            this.btnThem.Enabled = true;
        }

    }
}
