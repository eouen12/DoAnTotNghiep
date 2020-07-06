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
    public partial class frmNhaPhanPhoi : Form
    {
        private List<LOAISANPHAM> lstLoaiSP = new List<LOAISANPHAM>();
        private List<NHAPHANPHOI> lstNPP = new List<NHAPHANPHOI>();
        private List<CHITIETNHAPHANG> lstCTNH = new List<CHITIETNHAPHANG>();
        public frmNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void frmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            LoadDataDSLoaiSP();
            LoadDataDSNPP();
            LoadDataDSCTNH();
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            if(this.txtMaLoai.Text == string.Empty || this.txtTenLoaiSP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            LOAISANPHAM loaisp = new LOAISANPHAM { MALOAI = this.txtMaLoai.Text, TENLOAI = this.txtTenLoaiSP.Text, TRANGTHAI = true };
            if(LoaiSanPhamBUS.ThemLoaiSanPham(loaisp))
            {
                MessageBox.Show("Thêm loại sản phẩm thành công !!!", "Thông báo");
                LoadDataDSLoaiSP();
                ResetTabQLLoaiSP();
            }
            else
            {
                MessageBox.Show("Thêm loại sản phẩm thất bại!!!", "Thông báo");
            }
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            LOAISANPHAM loaisp = new LOAISANPHAM();
            loaisp.MALOAI = this.txtMaLoai.Text;
            loaisp.TENLOAI = this.txtTenLoaiSP.Text;
            if (LoaiSanPhamBUS.SuaLoaiSanPham(loaisp))
            {
                MessageBox.Show("Sửa loại sản phẩm thành công !!!", "Thông báo");
                LoadDataDSLoaiSP();
                ResetTabQLLoaiSP();
            }
            else
            {
                MessageBox.Show("Sửa loại sản phẩm thất bại!!!", "Thông báo");
            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chứ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                LoaiSanPhamBUS.XoaLoaiSanPham(this.txtMaLoai.Text);
                MessageBox.Show("Xóa loại sản phẩm thành công !!!", "Thông báo");
                LoadDataDSLoaiSP();
                ResetTabQLLoaiSP();
            }
        }

        private void btnHuyboLoaiSP_Click(object sender, EventArgs e)
        {
            ResetTabQLLoaiSP();
        }

        private void txtTimKiemLoaiSP_TextChanged(object sender, EventArgs e)
        {
            if(this.txtTimKiemLoaiSP.Text != string.Empty)
            {
                TimKiemLoaiSanPham(this.txtTimKiemLoaiSP.Text);
            }
            else
            {
                LoadDataDSLoaiSP();
            }
        }

        private void dgvDsLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnThemLoaiSP.Enabled = false;
            this.btnSuaLoaiSP.Enabled = true;
            this.btnXoaLoaiSP.Enabled = true;
            this.txtMaLoai.Text = this.dgvDsLoaiSP.CurrentRow.Cells["MALOAI"].Value.ToString();
            this.txtTenLoaiSP.Text = this.dgvDsLoaiSP.CurrentRow.Cells["TENLOAI"].Value.ToString();
        }
        void LoadDataDSLoaiSP()
        {
            lstLoaiSP = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            this.dgvDsLoaiSP.AutoGenerateColumns = false;
            this.dgvDsLoaiSP.DataSource = lstLoaiSP;
        }

        void TimKiemLoaiSanPham(string chuoi)
        {
            var kq = from loai in lstLoaiSP
                     where loai.MALOAI.Contains(chuoi) || loai.TENLOAI.Contains(chuoi)
                     select loai;
            this.dgvDsLoaiSP.AutoGenerateColumns = false;
            this.dgvDsLoaiSP.DataSource = kq.ToList();
        }

        void ResetTabQLLoaiSP()
        {
            this.txtMaLoai.Clear();
            this.txtTenLoaiSP.Clear();
            this.btnThemLoaiSP.Enabled = true;
            this.btnSuaLoaiSP.Enabled = false;
            this.btnXoaLoaiSP.Enabled = false;
        }

        private void btnThemNPP_Click(object sender, EventArgs e)
        {
            if (this.txtMaNPP.Text == string.Empty || this.txtTenNPP.Text == string.Empty || this.txtDiaChiNPP.Text == string.Empty || this.txtSDTNPP.Text == string.Empty || this.txtEmailNPP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            NHAPHANPHOI npp = new NHAPHANPHOI { MANPP = this.txtMaNPP.Text, TENNPP = this.txtTenNPP.Text, DIACHI = this.txtDiaChiNPP.Text , EMAIL = this.txtEmailNPP.Text , SDT = this.txtSDTNPP.Text, TRANGTHAI = true };
            if (NhaPhanPhoiBUS.ThemNPP(npp))
            {
                MessageBox.Show("Thêm thành công !!!", "Thông báo");
                LoadDataDSNPP();
                ResetTabQLNPP();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!", "Thông báo");
            }
        }

        private void dgvDSNhaPhanPhoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnThemNPP.Enabled = false;
            this.btnSuaNPP.Enabled = true;
            this.btnXoaNPP.Enabled = true;
            this.txtMaNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["MANPP"].Value.ToString();
            this.txtTenNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["TENNPP"].Value.ToString();
            this.txtDiaChiNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["DIACHI"].Value.ToString();
            this.txtSDTNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["SDT"].Value.ToString();
            this.txtEmailNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["EMAIL"].Value.ToString();
            this.txtWebsiteNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["WEBSITE"].Value.ToString();
        }

        void LoadDataDSNPP()
        {
            lstNPP = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            this.dgvDSNhaPhanPhoi.AutoGenerateColumns = false;
            this.dgvDSNhaPhanPhoi.DataSource = lstNPP;
        }
        void ResetTabQLNPP()
        {
            this.txtMaNPP.Clear();
            this.txtTenNPP.Clear();
            this.txtDiaChiNPP.Clear();
            this.txtSDTNPP.Clear();
            this.txtEmailNPP.Clear();
            this.txtWebsiteNPP.Clear();
            this.btnThemNPP.Enabled = true;
            this.btnSuaNPP.Enabled = false;
            this.btnXoaNPP.Enabled = false;
        }

        private void btnSuaNPP_Click(object sender, EventArgs e)
        {
            NHAPHANPHOI npp = new NHAPHANPHOI();
            npp.MANPP = this.txtMaNPP.Text;
            npp.TENNPP = this.txtTenNPP.Text;
            npp.DIACHI = this.txtDiaChiNPP.Text;
            npp.SDT = this.txtSDTNPP.Text;
            npp.EMAIL = this.txtEmailNPP.Text;
            npp.WEBSITE = this.txtWebsiteNPP.Text;
            if (NhaPhanPhoiBUS.SuaNPP(npp))
            {
                MessageBox.Show("Sửa thành công !!!", "Thông báo");
                LoadDataDSNPP();
                ResetTabQLNPP();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
        }

        private void btnXoaNPP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhaPhanPhoiBUS.XoaNPP(this.txtMaNPP.Text);
                MessageBox.Show("Xóa thành công !!!", "Thông báo");
                LoadDataDSNPP();
                ResetTabQLNPP();
            }
        }

        private void btnHuyBoNPP_Click(object sender, EventArgs e)
        {
            ResetTabQLNPP();
        }
        void TimKiemNPP(string chuoi)
        {
            var kq = from npp in lstNPP
                     where npp.MANPP.Contains(chuoi) || npp.TENNPP.Contains(chuoi)
                     select npp;
            this.dgvDSNhaPhanPhoi.AutoGenerateColumns = false;
            this.dgvDSNhaPhanPhoi.DataSource = kq.ToList();
        }

        private void txtTimKiemNPP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiemNPP.Text != string.Empty)
            {
                TimKiemNPP(this.txtTimKiemNPP.Text);
            }
            else
            {
                LoadDataDSNPP();
            }
        }

        private void btnThemDLNhapHang_Click(object sender, EventArgs e)
        {
            if (this.txtMaNPPNhapHang.Text == string.Empty || this.txtMaSPNhapHang.Text == string.Empty || this.txtDonGiaNhapHang.Text == string.Empty || this.txtSLNhapHang.Text == string.Empty || this.txtTongGtriNhapHang.Text == string.Empty || this.dateTimePickerNhapHang.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo");
                return;
            }

            CHITIETNHAPHANG ctnh = new CHITIETNHAPHANG { MANPP = this.txtMaNPPNhapHang.Text, MASP = this.txtMaSPNhapHang.Text, DONGIA = this.txtDonGiaNhapHang.MaxLength, SL_NHAPHANG = this.txtSLNhapHang.MaxLength, TONGGIATRI = this.txtTongGtriNhapHang.MaxLength, NGAYNHAPHANG = dateTimePickerNhapHang.MaxDate, TRANGTHAI = true };
            if (CTNhapHangTuNPPBUS.ThemCTNH(ctnh))
            {
                MessageBox.Show("Thêm thành công !!!", "Thông báo");
                LoadDataDSCTNH();
                ResetTabQLCTNH();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!", "Thông báo");
            }
        }

        private void btnSuaDLNhapHang_Click(object sender, EventArgs e)
        {
            CHITIETNHAPHANG ctnh = new CHITIETNHAPHANG();
            ctnh.MANPP = this.txtMaNPPNhapHang.Text;
            ctnh.MASP = this.txtMaSPNhapHang.Text;
            ctnh.DONGIA = int.Parse(this.txtDonGiaNhapHang.Text);
            ctnh.SL_NHAPHANG = int.Parse(this.txtSLNhapHang.Text);
            ctnh.TONGGIATRI = int.Parse(this.txtTongGtriNhapHang.Text);
            ctnh.NGAYNHAPHANG = this.dateTimePickerNhapHang.MaxDate;
            if (CTNhapHangTuNPPBUS.SuaCTNH(ctnh))
            {
                MessageBox.Show("Sửa thành công !!!", "Thông báo");
                LoadDataDSCTNH();
                ResetTabQLCTNH();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!!!", "Thông báo");
            }
        }

        private void btnXoaDLNhapHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                CTNhapHangTuNPPBUS.XoaCTNH(this.txtMaNPPNhapHang.Text , this.txtMaSPNhapHang.Text);
                MessageBox.Show("Xóa thành công !!!", "Thông báo");
                LoadDataDSCTNH();
                ResetTabQLCTNH();
            }
        }

        private void dgvDsChiTietNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnThemDLNhapHang.Enabled = false;
            this.btnSuaDLNhapHang.Enabled = true;
            this.btnXoaDLNhapHang.Enabled = true;
            this.txtMaNPPNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["MANPPNH"].Value.ToString();
            this.txtMaSPNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["MASPNH"].Value.ToString();
            this.txtSLNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["SL_NHAPHANG"].Value.ToString();
            this.txtDonGiaNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["DONGIA"].Value.ToString();
            this.txtTongGtriNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["TONGGIATRI"].Value.ToString();
            this.dateTimePickerNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["NGAYNHAPHANG"].Value.ToString();
        }
        void LoadDataDSCTNH()
        {
            lstCTNH = CTNhapHangTuNPPBUS.LayDanhSachChiTietNhapHang();
            this.dgvDsChiTietNhapHang.AutoGenerateColumns = false;
            this.dgvDsChiTietNhapHang.DataSource = lstCTNH;
        }
        void ResetTabQLCTNH()
        {
            this.txtMaNPPNhapHang.Clear();
            this.txtMaSPNhapHang.Clear();
            this.txtDonGiaNhapHang.Clear();
            this.txtSLNhapHang.Clear();
            this.txtTongGtriNhapHang.Clear();
            this.btnThemDLNhapHang.Enabled = true;
            this.btnSuaDLNhapHang.Enabled = false;
            this.btnXoaDLNhapHang.Enabled = false;
        }

        private void btnHuyNhapHang_Click(object sender, EventArgs e)
        {
            ResetTabQLCTNH();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
