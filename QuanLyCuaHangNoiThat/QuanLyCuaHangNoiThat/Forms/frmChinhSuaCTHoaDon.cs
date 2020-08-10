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
        private int sl_cthd;
        private string vitrithaotac = "Chỉnh sửa chi tiết hóa đơn";
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
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.txtMasp.Focus();
                return;
            }
            if (!SanPhamBUS.KiemTraMaSPTonTai(this.txtMasp.Text))
            {
                MessageBox.Show("Mã sản phẩm không tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMasp.Focus();
                return;
            }

            if(!KiemTraSLMasp(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text)))
            {
                this.txtSoLuong.Focus();
                return;
            }

            if (!KiemTraMaspTonTaiTrongCTHD(this.txtMasp.Text))
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
                CapNhatThongTienCongNo();
                this.dangThayDoiCTHD = false;
                loadThongTinHD(hd.MAHD);
                Reset();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm sản phẩm " + this.txtMasp.Text +" vào chi tiết hóa đơn " + hd.MAHD;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMasp.Focus();
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txtMasp.Text == string.Empty || this.txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn dòng sản phẩm muốn cập nhật !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraSLMasp(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text)))
            {
                this.txtSoLuong.Focus();
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
                CapNhatSoLuongSanPham(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text), 1);
                hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                HoaDonBanHangBUS.CapNhatHoaDon(hd);
                CapNhatThongTienCongNo();
                this.dangThayDoiCTHD = false;
                loadThongTinHD(hd.MAHD);
                Reset();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin chi tiết hóa đơn " + hd.MAHD;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
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
                MessageBox.Show("Bạn chưa chọn dòng sản phẩm muốn xóa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CTHoaDonBanHangBUS.XoaCTHoaDon(hd.MAHD, this.txtMasp.Text))
                {
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadDSCTHD(hd.MAHD);
                    CapNhatSoLuongSanPham(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text), 2);
                    hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                    HoaDonBanHangBUS.CapNhatHoaDon(hd);
                    CapNhatThongTienCongNo();
                    this.dangThayDoiCTHD = false;
                    loadThongTinHD(hd.MAHD);
                    Reset();
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa sản phẩm " + this.txtMasp.Text + " của chi tiết hóa đơn " + hd.MAHD;
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                    {
                        NGAYTAO = DateTime.Now.Date,
                        NV_THAOTAC = this.manv,
                        VITRI_THAOTAC = this.vitrithaotac,
                        GHICHU = lsth
                    });
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
                loadThongTinHD(hd.MAHD);
                this.dangThayDoiNgayGiao = false;
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật ngày giao " + this.lblMaHD.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Cập nhật ngày giao thất bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.txtMasp.Enabled = false;
            this.btnThem.Enabled = false;
            this.dangThayDoiCTHD = true;
            this.txtMasp.Text = this.dgvCTHD.CurrentRow.Cells["MASP"].Value.ToString();
            this.txtSoLuong.Text = this.dgvCTHD.CurrentRow.Cells["SOLUONG"].Value.ToString();
            this.sl_cthd = Convert.ToInt32(this.dgvCTHD.CurrentRow.Cells["SOLUONG"].Value.ToString());
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
            lstcthd = CTHoaDonBanHangBUS.LayDSCTHD().Where(p => p.MAHD == mahd).ToList();
            this.dgvCTHD.AutoGenerateColumns = false;
            this.dgvCTHD.DataSource = lstcthd;
        }

        void loadThongTinHD(string mahd)
        {
            lstThongTinHD = HoaDonBanHangBUS.LayThongTinCuaHD(mahd);
            var hd = lstThongTinHD.FirstOrDefault();
            this.lblMaHD.Text = hd.MAHD;
            this.lblMaKH.Text = hd.MAKH.ToString();
            this.lblTenKH.Text = KhachHangBUS.LayThongTin(hd.MAKH).TENKH;
            this.lblTongTien.Text = Convert.ToInt32(hd.TONGTIEN).ToString("#,##0") + " VND";
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

        bool KiemTraMaspTonTaiTrongCTHD(string masp)
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
            // sl ton =100
            // sl trong ct = 50
            // sl cap nhat =40
            if(mode == 1)
            {
                if(sl < sl_cthd)
                {
                    kq.SL_TON = sl_ton + (sl_cthd - sl); 
                } 
                else if(sl > sl_cthd)
                {
                    kq.SL_TON = sl_ton - (sl - sl_cthd);
                }
            }
            if(mode == 2)
            {
                kq.SL_TON = sl_ton + sl_cthd;
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
            this.txtMasp.Focus();
            this.txtSoLuong.Clear();
            this.txtMasp.Enabled = true;
            this.dangThayDoiCTHD = false;
            this.dangThayDoiNgayGiao = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
        }

        void CapNhatThongTienCongNo()
        {
            var cn = CongNoBUS.LayDanhSachCongNo().Where(p => p.MAKH == this.lblMaKH.Text && p.MAHD == hd.MAHD).FirstOrDefault();
            if (hd.TONGTIEN == 0)
            {
                CongNoBUS.CapNhatCongNo(new CONGNO
                {
                    MACONGNO = cn.MACONGNO,
                    MAKH = cn.MAKH,
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
                // cn tong tien 15 , con no 10
                // hd edit tong tien 10, cn tong tien 10
                CongNoBUS.CapNhatCongNo(new CONGNO
                {
                    MACONGNO = cn.MACONGNO,
                    MAKH = cn.MAKH,
                    MAHD = cn.MAHD,
                    TONGTIEN = Convert.ToDecimal(hd.TONGTIEN),
                    TIENCONNO = Convert.ToDecimal(hd.TONGTIEN) - cn.TONGTIEN + cn.TIENCONNO,
                    NGAYTRA = cn.NGAYTRA.Value.Date,
                    NV_LAPCN = cn.NV_LAPCN,
                    NGAYLAP = cn.NGAYLAP.Value.Date,
                    TRANGTHAI = true
                });
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
