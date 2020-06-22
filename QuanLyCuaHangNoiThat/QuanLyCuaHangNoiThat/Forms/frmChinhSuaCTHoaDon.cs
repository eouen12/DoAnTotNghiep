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
        private HOADONBANHANG hd = new HOADONBANHANG();
        private bool dangThayDoiNgayGiao = false;
        private bool dangThayDoiCTHD = false;
        public frmChinhSuaCTHoaDon(HOADONBANHANG hoadon)
        {
            InitializeComponent();

            hd = hoadon;
        }

        private void ChinhSuaCTHoaDon_Load(object sender, EventArgs e)
        {
            loadDSCTHD(hd.MAHD);

            loadThongTinHD(hd.MAHD);

            AutoCompleteMaSP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.txtMasp.Text != string.Empty || this.txtSoLuong.Text != string.Empty)
            {
                if(!KiemTraMaspTonTai(this.txtMasp.Text,hd.MAHD))
                {
                    CTHoaDonBanHangBUS.ThemCTHoaDon(new CTHOADONBANHANG
                    {
                        MAHD = hd.MAHD,
                        MASP = this.txtMasp.Text,
                        SOLUONG = Convert.ToInt32(this.txtSoLuong.Text.Trim()),
                        DONGIA = TinhDonGia(this.txtMasp.Text, Convert.ToInt32(this.txtSoLuong.Text)),
                        TRANGTHAI = true
                    });
                    loadDSCTHD(hd.MAHD);
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã tồn tại !!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txtMasp.Text != string.Empty || this.txtSoLuong.Text != string.Empty)
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
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                loadDSCTHD(hd.MAHD);
                hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                HoaDonBanHangBUS.CapNhatHoaDon(hd);
                this.dangThayDoiCTHD = false;
                loadThongTinHD(hd.MAHD);
                Reset();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMasp.Text != string.Empty || this.txtSoLuong.Text != string.Empty)
            {
                return;
            }
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CTHoaDonBanHangBUS.XoaCTHoaDon(hd.MAHD, this.txtMasp.Text))
                {
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo");
                    loadDSCTHD(hd.MAHD);
                    hd.TONGTIEN = lstcthd.Sum(p => p.DONGIA);
                    HoaDonBanHangBUS.CapNhatHoaDon(hd);
                    this.dangThayDoiCTHD = false;
                    loadThongTinHD(hd.MAHD);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại", "Thông báo");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(this.dtNgayGiao.Value == hd.NGAYGIAO)
            {
                MessageBox.Show("Bạn chưa thay đổi dữ liệu 'Ngày giao'", "Thông báo");
                return;
            }
            hd.NGAYGIAO = dtNgayGiao.Value;
            if (HoaDonBanHangBUS.CapNhatHoaDon(hd))
            {
                MessageBox.Show("Cập nhật ngày giao thành công", "Thông báo");
                loadThongTinHD(hd.MAHD);
                this.dangThayDoiNgayGiao = false;
            }
            else
            {
                MessageBox.Show("Cập nhật ngày giao thất bại", "Thông báo");
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMasp.Enabled = false;
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
                    e.Cancel = true;
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

        int TinhDonGia(string masp, int sl)
        {
            List<SANPHAM> sp = SanPhamBUS.LayDanhSachSanPham();
            var kq = sp.Where(p => p.MASP == masp).FirstOrDefault();
            return sl * Convert.ToInt32(kq.GIABAN);
        }
        void Reset()
        {
            this.txtMasp.Clear();
            this.txtSoLuong.Clear();
            this.txtMasp.Enabled = true;
        }

    }
}
