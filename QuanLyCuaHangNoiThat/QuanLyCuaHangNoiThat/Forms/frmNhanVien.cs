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
using System.Text.RegularExpressions;
using System.Globalization;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmNhanVien : Form
    {
        private List<NHANVIEN> lstAllNV = new List<NHANVIEN>();
        private List<NHANVIEN> lstNV = new List<NHANVIEN>();
       // private string patch = @"..\..\..\..\Anh_NhanVien\";
        private string patch = @"Anh_NhanVien\";
        private string tenAnhDaiDien = "";
        private string manv;
        private string autoManv;
        private bool dangThayDoiDuLieu = false;
        private string vitrithaotac = "Nhân viên";
        public frmNhanVien(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDsNhanVien();


        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiemNV.Text != string.Empty)
            {
                TimKiemNhanVien(this.txtTimKiemNV.Text);
            }
            else
            {
                LoadDsNhanVien();
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEnable(false);
            this.txtMaNV.Text = this.dgvDSNhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            this.txtTenNV.Text = this.dgvDSNhanVien.CurrentRow.Cells["TENNV"].Value.ToString();
            this.txtSDTNV.Text = this.dgvDSNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            this.txtCMNDNV.Text = this.dgvDSNhanVien.CurrentRow.Cells["CMND"].Value.ToString();
            this.txtDiaChiNV.Text = this.dgvDSNhanVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            this.txtLuongNV.Text = Convert.ToInt32(this.dgvDSNhanVien.CurrentRow.Cells["LUONGCB"].Value).ToString("#,##0");
            this.txtEmail.Text = this.dgvDSNhanVien.CurrentRow.Cells["EMAIL"].Value.ToString();
            this.imgNhanVien.ImageLocation = patch + this.dgvDSNhanVien.CurrentRow.Cells["ANHDAIDIEN"].Value.ToString();
            this.tenAnhDaiDien = this.dgvDSNhanVien.CurrentRow.Cells["ANHDAIDIEN"].Value.ToString();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if ( this.txtTenNV.Text != string.Empty
                || this.txtSDTNV.Text != string.Empty
                || this.txtCMNDNV.Text != string.Empty
                || this.txtEmail.Text != string.Empty
                || this.txtLuongNV.Text != string.Empty
                || this.txtDiaChiNV.Text != string.Empty)
            {
                try
                {
                    string[] chuoiXuLiTenAnh = this.tenAnhDaiDien.Split('.');
                    tenAnhDaiDien = this.txtMaNV.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy") + "." + chuoiXuLiTenAnh[1];
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn ảnh đại diện !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                NHANVIEN nv = new NHANVIEN
                {
                    MANV = this.txtMaNV.Text,
                    TENNV = this.txtTenNV.Text,
                    MATKHAU = this.txtMaNV.Text,
                    SDT = this.txtSDTNV.Text,
                    CMND = this.txtCMNDNV.Text,
                    EMAIL = this.txtEmail.Text,
                    DIACHI = this.txtDiaChiNV.Text,
                    LUONGCB = Convert.ToInt32(this.txtLuongNV.Text),
                    ANHDAIDIEN = tenAnhDaiDien,
                    CHUCVU = "NV",
                    TRANGTHAI = true
                };
                if(NhanVienBUS.ThemNhanVien(nv))
                {
                    this.imgNhanVien.Image.Save(System.IO.Path.Combine(patch, this.tenAnhDaiDien));
                    MessageBox.Show("Thêm nhân viên thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadDsNhanVien();
                    Reset();
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới nhân viên " + nv.MANV;
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
                    MessageBox.Show("Thêm nhân viên thất bại !!!", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đây đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (this.txtTenNV.Text != string.Empty
                || this.txtSDTNV.Text != string.Empty
                || this.txtCMNDNV.Text != string.Empty
                || this.txtEmail.Text != string.Empty
                || this.txtLuongNV.Text != string.Empty
                || this.txtDiaChiNV.Text != string.Empty
                || this.imgNhanVien.Image != null)
            {
                if (this.tenAnhDaiDien != this.dgvDSNhanVien.CurrentRow.Cells["ANHDAIDIEN"].Value.ToString())
                {
                    string[] chuoiXuLiTenAnh = this.tenAnhDaiDien.Split('.');
                    tenAnhDaiDien = this.txtMaNV.Text + "_(" + DateTime.Now.ToString("dd-MM-yyyy") + ")." + chuoiXuLiTenAnh[1];
                }
                NHANVIEN nv = new NHANVIEN
                {
                    MANV = this.txtMaNV.Text,
                    TENNV = this.txtTenNV.Text,
                    SDT = this.txtSDTNV.Text,
                    CMND = this.txtCMNDNV.Text,
                    EMAIL = this.txtEmail.Text,
                    DIACHI = this.txtDiaChiNV.Text,
                    ANHDAIDIEN = tenAnhDaiDien.ToString(),
                    LUONGCB =KiemTraDinhDangLuongCB(this.txtLuongNV.Text),
                };
                if (NhanVienBUS.CapNhatNhanVien(nv))
                {
                    if (this.imgNhanVien.ImageLocation != System.IO.Path.Combine(patch, this.dgvDSNhanVien.CurrentRow.Cells["ANHDAIDIEN"].Value.ToString()))
                    {
                        this.imgNhanVien.Image.Save(System.IO.Path.Combine(patch + this.tenAnhDaiDien));
                    }
                    MessageBox.Show("Cập nhật nhân viên thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadDsNhanVien();
                    Reset();
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin nhân viên " + nv.MANV;
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
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
                    MessageBox.Show("Cập nhật nhân viên thất bại !!!", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đây đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhanVienBUS.XoaNhanVien(this.txtMaNV.Text);
                MessageBox.Show("Xóa nhân viên thành công thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Reset();
                LoadDsNhanVien();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới nhân viên " + this.txtMaNV.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
            }
        }

        private void btnLamMoiMK_Click(object sender, EventArgs e)
        {
            if (NhanVienBUS.LamMoiMatKhau(this.txtMaNV.Text))
            {
                MessageBox.Show("Làm mới mật khẩu nhân viên thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDsNhanVien();
                Reset();
            }
            else
            {
                MessageBox.Show("Làm mới mật khẩu viên thất bại !!!", "Lỗi");
            }
        }

        private void btnChonAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (this.imgNhanVien != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png;)| *.jpg; *.jpeg; *.png; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.imgNhanVien.Image = Image.FromFile(open.FileName);
                    this.tenAnhDaiDien = open.SafeFileName;
                }
            }
        }

        private void txtCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLuongNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnHuyBoNV_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void LoadDsNhanVien()
        {
            lstAllNV = NhanVienBUS.LayDanhSachAllNV();
            lstNV = NhanVienBUS.LayDanhSachNV();
            this.dgvDSNhanVien.AutoGenerateColumns = false;
            this.dgvDSNhanVien.DataSource = lstAllNV;
            this.txtMaNV.Text = AutoTaoMaNV();
        }

        void TimKiemNhanVien(string chuoi)
        {
            var kq = from nv in lstNV
                     where nv.MANV.Contains(chuoi)
                     || nv.TENNV.Contains(chuoi)
                     || nv.SDT.Contains(chuoi)
                     || nv.CMND.ToString().Contains(chuoi)
                     || nv.EMAIL.Contains(chuoi)
                     select nv;
            this.dgvDSNhanVien.AutoGenerateColumns = false;
            this.dgvDSNhanVien.DataSource = kq.ToList();
        }
        void setEnable(bool b)
        {
            this.btnThemNV.Enabled = b;
            this.btnSuaNV.Enabled = !b;
            this.btnXoaNV.Enabled = !b;
            this.btnLamMoiMK.Enabled = !b;
            this.dangThayDoiDuLieu = !b;
        }
        void Reset()
        {
            setEnable(true);
            this.txtMaNV.Text = AutoTaoMaNV();
            this.txtTenNV.Clear();
            this.txtSDTNV.Clear();
            this.txtCMNDNV.Clear();
            this.txtDiaChiNV.Clear();
            this.txtLuongNV.Clear();
            this.txtEmail.Clear();
            this.imgNhanVien.Image = null;
            this.tenAnhDaiDien = string.Empty;
        }
        int KiemTraDinhDangLuongCB(string luongcb)
        {
            string[] chuoi = luongcb.Split(',', '.');
            string luong = string.Empty;
            if(chuoi == null)
            {
                return Convert.ToInt32(luongcb);
            }
            else
            {
                for(int i = 0;i<chuoi.Length;i++)
                {
                    luong += chuoi[i];
                }
                return Convert.ToInt32(luong);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (!isValidEmail(this.txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng !!!", "Lỗi");
                this.txtEmail.Focus();
            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangThayDoiDuLieu)
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

        string AutoTaoMaNV()
        {
            if (lstNV.Count == 0)
            {
                autoManv = "NV1";
            }
            else
            {
                autoManv = lstNV.Select(p => p.MANV).LastOrDefault();
                int soma = Convert.ToInt32(autoManv.Remove(0, 2)) + 1;
                autoManv = "NV" + soma;
                for (int i = 0; i < lstNV.Count(); i++)
                {
                    if (autoManv == lstNV[i].MANV)
                    {
                        soma = Convert.ToInt32(autoManv.Remove(0, 2)) + 1;
                        autoManv = "HD" + soma;
                    }
                }
            }
            return autoManv;
        }
        bool isValidEmail(string inputEmail)
        {
            Regex re = new Regex("^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{2,10}.[a-zA-Z]{2,5}$");
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void txtSDTNV_Validated(object sender, EventArgs e)
        {
            if (this.txtSDTNV.Text == string.Empty)
            {
                return;
            }
            if (!KiemtraDinhDangSDT(this.txtSDTNV.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSDTNV.Focus();
            }
        }

        private void txtCMNDNV_Validated(object sender, EventArgs e)
        {
            if (this.txtCMNDNV.Text == string.Empty)
            {
                return;
            }
            if (!KiemtraDinhDangCMND(this.txtCMNDNV.Text))
            {
                MessageBox.Show("Số CMND không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCMNDNV.Focus();
            }
        }

        bool KiemtraDinhDangSDT(string sdt)
        {
            Regex re = new Regex("^[0-9]{10,10}$");
            if (re.IsMatch(sdt))
                return (true);
            else
                return (false);
        }
        bool KiemtraDinhDangCMND(string cmnd)
        {
            Regex re = new Regex("^[0-9]{10,12}$");
            if (re.IsMatch(cmnd))
                return (true);
            else
                return (false);
        }
    }
}
