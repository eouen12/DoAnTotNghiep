using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using BUS;
using DTO;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmNhaPhanPhoi : Form
    {
        private List<NHAPHANPHOI> lstNPP = new List<NHAPHANPHOI>();
        private List<CHITIETNHAPHANG> lstCTNH = new List<CHITIETNHAPHANG>();
        private CHITIETNHAPHANG ct = new CHITIETNHAPHANG();
        private string manv;
        private bool dangThayDoiDL = false;
        private string vitrithaotac = "Nhà phân phối";
        private string vitrithaotacNhapHang = "Nhập hàng";
        public frmNhaPhanPhoi(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void frmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            LoadDataDSNPP();
            LoadDataDSCTNH();

            AutoCompleteMaNPP();
            AutoCompleteMaSP();
        }

        private void txtSDTNPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtEmailNPP_Validated(object sender, EventArgs e)
        {
            if(this.txtEmailNPP.Text == string.Empty)
            {
                return;
            }    
            if (!isValidEmail(this.txtEmailNPP.Text))
            {
                MessageBox.Show("Email không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmailNPP.Focus();
            }
        }

        private void txtSDTNPP_Validated(object sender, EventArgs e)
        {
            if (this.txtSDTNPP.Text == string.Empty)
            {
                return;
            }
            if (!KiemtraDinhDangSDT(this.txtSDTNPP.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSDTNPP.Focus();
            }
        }

            private void btnThemNPP_Click(object sender, EventArgs e)
        {
            if ( this.txtTenNPP.Text == string.Empty
                || this.txtDiaChiNPP.Text == string.Empty 
                || this.txtSDTNPP.Text == string.Empty 
                || this.txtEmailNPP.Text == string.Empty
                || this.txtWebsiteNPP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            NHAPHANPHOI npp = new NHAPHANPHOI 
            { 
                MANPP = AutoMaNPP(), 
                TENNPP = this.txtTenNPP.Text, 
                DIACHI = this.txtDiaChiNPP.Text , 
                EMAIL = this.txtEmailNPP.Text , 
                SDT = this.txtSDTNPP.Text,
                WEBSITE = this.txtWebsiteNPP.Text,
                TRANGTHAI = true 
            };
            if (NhaPhanPhoiBUS.ThemNPP(npp))
            {
                MessageBox.Show("Thêm nhà phân phối thành công thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSNPP();
                ResetTabQLNPP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới nhà phân phối " + npp.MANPP;
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
                MessageBox.Show("Thêm nhà phân phối thất bại!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvDSNhaPhanPhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnThemNPP.Enabled = false;
            this.btnSuaNPP.Enabled = true;
            this.btnXoaNPP.Enabled = true;
            this.dangThayDoiDL = true;
            this.txtMaNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["MANPP"].Value.ToString();
            this.txtTenNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["TENNPP"].Value.ToString();
            this.txtDiaChiNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["DIACHI"].Value.ToString();
            this.txtSDTNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["SDT"].Value.ToString();
            this.txtEmailNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["EMAIL"].Value.ToString();
            this.txtWebsiteNPP.Text = this.dgvDSNhaPhanPhoi.CurrentRow.Cells["WEBSITE"].Value.ToString();
        }
        string AutoMaNPP()
        {
            string manpp = string.Empty;
            var lstnpp = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            if (lstnpp.Count == 0)
            {
                manpp = "NPP1";
                return manpp;
            }
            else
            {
                manpp = lstnpp[lstnpp.Count - 1].MANPP.ToString();
                int somanpp = Convert.ToInt32(manpp.Remove(0, 3)) + 1;
                manpp = "NPP" + somanpp;
                for (int i = 0; i < lstnpp.Count(); i++)
                {
                    if (manpp == lstnpp[i].MANPP)
                    {
                        somanpp = Convert.ToInt32(manpp.Remove(0, 3)) + 1;
                        manpp = "NPP" + somanpp;
                    }
                }
                return manpp;
            }
        }
        void LoadDataDSNPP()
        {
            lstNPP = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi().Where(p=>p.TRANGTHAI == true).ToList();
            this.dgvDSNhaPhanPhoi.AutoGenerateColumns = false;
            this.dgvDSNhaPhanPhoi.DataSource = lstNPP;
            this.txtMaNPP.Text = AutoMaNPP();
        }
        void ResetTabQLNPP()
        {
            this.txtMaNPP.Text = AutoMaNPP();
            this.txtTenNPP.Clear();
            this.txtDiaChiNPP.Clear();
            this.txtSDTNPP.Clear();
            this.txtEmailNPP.Clear();
            this.txtWebsiteNPP.Clear();
            this.btnThemNPP.Enabled = true;
            this.btnSuaNPP.Enabled = false;
            this.btnXoaNPP.Enabled = false;
            this.dangThayDoiDL = false;
        }

        private void btnSuaNPP_Click(object sender, EventArgs e)
        {
            if (this.txtTenNPP.Text == string.Empty
                || this.txtDiaChiNPP.Text == string.Empty
                || this.txtSDTNPP.Text == string.Empty
                || this.txtEmailNPP.Text == string.Empty
                || this.txtWebsiteNPP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NHAPHANPHOI npp = new NHAPHANPHOI();
            npp.MANPP = this.txtMaNPP.Text;
            npp.TENNPP = this.txtTenNPP.Text;
            npp.DIACHI = this.txtDiaChiNPP.Text;
            npp.SDT = this.txtSDTNPP.Text;
            npp.EMAIL = this.txtEmailNPP.Text;
            npp.WEBSITE = this.txtWebsiteNPP.Text;
            if (NhaPhanPhoiBUS.SuaNPP(npp))
            {
                MessageBox.Show("Cập nhật thông tin nhà phân phối thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSNPP();
                ResetTabQLNPP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin nhà phân phối " + npp.MANPP;
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
                MessageBox.Show("Cập nhật thông tin nhà phân phối thất bại!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnXoaNPP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhaPhanPhoiBUS.XoaNPP(this.txtMaNPP.Text);
                MessageBox.Show("Xóa nhà phân phối thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSNPP();
                ResetTabQLNPP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa thông tin nhà phân phối " + this.txtMaNPP.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
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
        /// <summary>
        /// tab Quản lý nhập hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnThemDLNhapHang_Click(object sender, EventArgs e)
        {
            if (this.txtMaNPPNhapHang.Text == string.Empty 
                || this.txtMaSPNhapHang.Text == string.Empty 
                || this.txtDonGiaNhapHang.Text == string.Empty 
                || this.txtSLNhapHang.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(lstCTNH.Any(p=>p.MANPP == this.txtMaNPPNhapHang.Text && p.MASP == this.txtMaSPNhapHang.Text))
            {
                MessageBox.Show("Thêm chi tiết nhập hàng thất bại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            CHITIETNHAPHANG ctnh = new CHITIETNHAPHANG { 
                MANPP = this.txtMaNPPNhapHang.Text,
                MASP = this.txtMaSPNhapHang.Text,
                DONGIA = Convert.ToInt32(this.txtDonGiaNhapHang.Text), 
                SL_NHAPHANG = Convert.ToInt32(this.txtSLNhapHang.Text), 
                TONGGIATRI = Convert.ToInt32(this.txtDonGiaNhapHang.Text) * Convert.ToInt32(this.txtSLNhapHang.Text), 
                NGAYNHAPHANG = dateTimePickerNhapHang.Value.Date, 
                TRANGTHAI = true };
            if (CTNhapHangBUS.ThemCTNH(ctnh))
            {
                MessageBox.Show("Thêm chi tiết nhập hàng thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSCTNH();
                ResetTabQLCTNH();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới chi tiết nhập hàng (" + ctnh.MANPP + "," + ctnh.MASP + ")";
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotacNhapHang,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Thêm chi tiết nhập hàng thất bại!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSuaDLNhapHang_Click(object sender, EventArgs e)
        {
            if (this.txtMaNPPNhapHang.Text == string.Empty
                || this.txtMaSPNhapHang.Text == string.Empty
                || this.txtDonGiaNhapHang.Text == string.Empty
                || this.txtSLNhapHang.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CHITIETNHAPHANG ctnh = new CHITIETNHAPHANG();
            ctnh.MANPP = this.txtMaNPPNhapHang.Text;
            ctnh.MASP = this.txtMaSPNhapHang.Text;
            ctnh.DONGIA = Convert.ToInt32(this.txtDonGiaNhapHang.Text);
            ctnh.SL_NHAPHANG = Convert.ToInt32(this.txtSLNhapHang.Text);
            ctnh.TONGGIATRI = Convert.ToInt32(this.txtDonGiaNhapHang.Text) * Convert.ToInt32(this.txtSLNhapHang.Text);
            ctnh.NGAYNHAPHANG = this.dateTimePickerNhapHang.Value;

            if (CTNhapHangBUS.SuaCTNH(ctnh))
            {
                MessageBox.Show("Cập nhật chi tiết nhập hàng thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSCTNH();
                ResetTabQLCTNH();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin chi tiết nhập hàng (" + ctnh.MANPP + "," + ctnh.MASP + ")";
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotacNhapHang,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Cập nhật chi tiết nhập hàng thất bại!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnXoaDLNhapHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                CTNhapHangBUS.XoaCTNH(this.txtMaNPPNhapHang.Text , this.txtMaSPNhapHang.Text);
                MessageBox.Show("Xóa chi tiết nhập hàng thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSCTNH();
                ResetTabQLCTNH();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa thông tin chi tiết nhập hàng (" + this.txtMaNPPNhapHang.Text + "," + this.txtMaSPNhapHang.Text + ")";
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotacNhapHang,
                    GHICHU = lsth
                });
            }
        }

        private void dgvDsChiTietNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnThemDLNhapHang.Enabled = false;
            this.btnSuaDLNhapHang.Enabled = true;
            this.btnXoaDLNhapHang.Enabled = true;
            this.txtMaNPPNhapHang.Enabled = false;
            this.txtMaSPNhapHang.Enabled = false;
            this.dangThayDoiDL = true;
            this.txtMaNPPNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["MANPPNH"].Value.ToString();
            this.txtMaSPNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["MASPNH"].Value.ToString();
            this.txtSLNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["SL_NHAPHANG"].Value.ToString();
            this.txtDonGiaNhapHang.Text = Convert.ToInt32(this.dgvDsChiTietNhapHang.CurrentRow.Cells["DONGIA"].Value).ToString();
            this.txtTongGtriNhapHang.Text = Convert.ToInt32(this.dgvDsChiTietNhapHang.CurrentRow.Cells["TONGGIATRI"].Value).ToString("#,##0");
            this.dateTimePickerNhapHang.Text = this.dgvDsChiTietNhapHang.CurrentRow.Cells["NGAYNHAPHANG"].Value.ToString();
        }
        void LoadDataDSCTNH()
        {
            lstCTNH = CTNhapHangBUS.LayDanhSachChiTietNhapHang();
            this.dgvDsChiTietNhapHang.AutoGenerateColumns = false;
            this.dgvDsChiTietNhapHang.DataSource = lstCTNH;
            this.dgvDsChiTietNhapHang.Columns["TONGGIATRI"].DefaultCellStyle.Format = "#,##0";
            this.dgvDsChiTietNhapHang.Columns["DONGIA"].DefaultCellStyle.Format = "#,##0";
        }
        void ResetTabQLCTNH()
        {
            this.txtMaNPPNhapHang.Clear();
            this.txtMaSPNhapHang.Clear();
            this.txtDonGiaNhapHang.Clear();
            this.txtSLNhapHang.Clear();
            this.txtTongGtriNhapHang.Clear();
            this.dateTimePickerNhapHang.Value = DateTime.Now;
            this.btnThemDLNhapHang.Enabled = true;
            this.btnSuaDLNhapHang.Enabled = false;
            this.btnXoaDLNhapHang.Enabled = false;
            this.dangThayDoiDL = false;
            this.txtMaNPPNhapHang.Enabled = true;
            this.txtMaSPNhapHang.Enabled = true;
        }

        private void btnHuyNhapHang_Click(object sender, EventArgs e)
        {
            ResetTabQLCTNH();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        bool isValidEmail(string inputEmail)
        {
            Regex re = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void txtMaNPPNhapHang_Validated(object sender, EventArgs e)
        {
            if (this.txtMaNPPNhapHang.Text != string.Empty)
            {
                if (!NhaPhanPhoiBUS.KiemTraMaNPPTonTai(this.txtMaNPPNhapHang.Text))
                {
                    MessageBox.Show("Mã nhà phân phối không tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMaNPPNhapHang.Focus();
                }
            }
        }

        private void txtMaSPNhapHang_Validated(object sender, EventArgs e)
        {
            if (this.txtMaSPNhapHang.Text != string.Empty)
            {
                if (!SanPhamBUS.KiemTraMaSPTonTai(this.txtMaSPNhapHang.Text))
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMaSPNhapHang.Focus();
                }
            }
        }

        private void txtSLNhapHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGiaNhapHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSLNhapHang_Validated(object sender, EventArgs e)
        {
            //if(this.txtSLNhapHang.Text != string.Empty)
            //{
            //    var sp = SanPhamBUS.LayDanhSachSanPham().Where(p => p.MASP == this.txtMaSPNhapHang.Text).FirstOrDefault();
            //    int sl = Convert.ToInt32(sp.SL_TON);
            //    if(Convert.ToInt32(this.txtSLNhapHang.Text) > sl)
            //    {
            //        MessageBox.Show("Số lượng nhập hàng không thể vượt quá số lượng tồn kho của sản phẩm này !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        this.txtSLNhapHang.Focus();
            //    }
            //}
        }

        void AutoCompleteMaSP()
        {
            List<SANPHAM> lst = SanPhamBUS.LayDanhSachSanPham();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (SANPHAM item in lst)
            {
                collection.Add(item.MASP);
            }
            this.txtMaSPNhapHang.AutoCompleteCustomSource = collection;
            this.txtMaSPNhapHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtMaSPNhapHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void AutoCompleteMaNPP()
        {
            List<NHAPHANPHOI> lstNhaPP = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (NHAPHANPHOI item in lstNhaPP)
            {
                collection.Add(item.MANPP);
            }
            this.txtMaNPPNhapHang.AutoCompleteCustomSource = collection;
            this.txtMaNPPNhapHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtMaNPPNhapHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        bool KiemtraDinhDangSDT(string sdt)
        {
            Regex re = new Regex("^[0-9]{10,11}$");
            if (re.IsMatch(sdt))
                return (true);
            else
                return (false);
        }

        private void frmNhaPhanPhoi_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtTimKiemQLNPP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiemQLNPP.Text != string.Empty)
            {
                TimKiemCTNhapHang(this.txtTimKiemQLNPP.Text);
            }
            else
            {
                LoadDataDSCTNH();
            }
        }

        void TimKiemCTNhapHang(string chuoi)
        {
            var kq = from ctnh in lstCTNH
                     where ctnh.MANPP.Contains(chuoi) || ctnh.MASP.Contains(chuoi)
                     select ctnh;
            this.dgvDsChiTietNhapHang.AutoGenerateColumns = false;
            this.dgvDsChiTietNhapHang.DataSource = kq.ToList();
            this.dgvDsChiTietNhapHang.Columns["TONGGIATRI"].DefaultCellStyle.Format = "#,##0";
        }
    }
}
