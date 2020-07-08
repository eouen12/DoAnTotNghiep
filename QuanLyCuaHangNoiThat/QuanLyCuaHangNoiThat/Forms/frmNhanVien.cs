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
        private List<NHANVIEN> lstNV = new List<NHANVIEN>();
        //private string patch = @"C:\Users\trant\OneDrive\Desktop\DoAnTotNghiep\Anh_NhanVien\";
        private string patch = @"..\..\..\..\Anh_NhanVien\";
        private string tenAnhDaiDien = "";
        private string manv;
        private bool dangThayDoiDuLieu = false;
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
            if (/*this.txtMaNV.Text != string.Empty*/
                /*||*/ this.txtTenNV.Text != string.Empty
                || this.txtSDTNV.Text != string.Empty
                || this.txtCMNDNV.Text != string.Empty
                || this.txtEmail.Text != string.Empty
                || this.txtLuongNV.Text != string.Empty
                || this.txtDiaChiNV.Text != string.Empty)
            {
                string s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.txtTenNV.Text.ToLower());
                string chuoiTen = convertChuoiKhongDau(s).Replace(" ", "");
                string chuoiNgayTao = DateTime.Now.ToString("dd-MM-yyyy");
                string manv = "NV_" + chuoiTen + "_" + chuoiNgayTao;
                try
                {
                    string[] chuoiXuLiTenAnh = this.tenAnhDaiDien.Split('.');
                    tenAnhDaiDien = chuoiTen + "_" + DateTime.Now.ToString("dd-MM-yyyy") + "." + chuoiXuLiTenAnh[1];
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn ảnh đại diện !!!", "Thông báo");
                    return;
                }
                NHANVIEN nv = new NHANVIEN
                {
                    MANV = manv,
                    TENNV = this.txtTenNV.Text,
                    MATKHAU = manv,
                    SDT = this.txtSDTNV.Text,
                    CMND = Convert.ToInt32(this.txtCMNDNV.Text),
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
                    MessageBox.Show("Thêm nhân viên thành công !!!", "Thông báo");
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới nhân viên " + nv.MANV;
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                    LoadDsNhanVien();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại !!!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đây đủ thông tin !!!", "Thông báo");
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
                    CMND = Convert.ToInt32(this.txtCMNDNV.Text),
                    EMAIL = this.txtEmail.Text,
                    DIACHI = this.txtDiaChiNV.Text,
                    ANHDAIDIEN = tenAnhDaiDien.ToString(),
                    //LUONGCB = Convert.ToInt32(this.txtLuongNV.Text),
                };
                if (NhanVienBUS.CapNhatNhanVien(nv))
                {
                    if (this.imgNhanVien.ImageLocation != System.IO.Path.Combine(patch, this.dgvDSNhanVien.CurrentRow.Cells["ANHDAIDIEN"].Value.ToString()))
                    {
                        this.imgNhanVien.Image.Save(System.IO.Path.Combine(patch + this.tenAnhDaiDien));
                    }
                    MessageBox.Show("Cập nhật nhân viên thành công !!!", "Thông báo");
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin nhân viên " + nv.MANV;
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                    LoadDsNhanVien();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại !!!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đây đủ thông tin !!!", "Thông báo");
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhanVienBUS.XoaNhanVien(this.txtMaNV.Text);
                MessageBox.Show("Xóa nhân viên thành công thành công !!!", "Thông báo");
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới nhân viên " + this.txtMaNV.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                Reset();
                LoadDsNhanVien();
            }
        }

        private void btnLamMoiMK_Click(object sender, EventArgs e)
        {
            if (NhanVienBUS.LamMoiMatKhau(this.txtMaNV.Text))
            {
                MessageBox.Show("Làm mới mật khẩu nhân viên thành công !!!", "Thông báo");
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
            lstNV = NhanVienBUS.LayDanhSachNV();
            this.dgvDSNhanVien.AutoGenerateColumns = false;
            this.dgvDSNhanVien.DataSource = lstNV;
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
            this.txtMaNV.Clear();
            this.txtTenNV.Clear();
            this.txtSDTNV.Clear();
            this.txtCMNDNV.Clear();
            this.txtDiaChiNV.Clear();
            this.txtLuongNV.Clear();
            this.txtEmail.Clear();
            this.imgNhanVien.Image = null;
            this.tenAnhDaiDien = string.Empty;
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

        string convertChuoiKhongDau(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        bool isValidEmail(string inputEmail)
        {
            Regex re = new Regex("^[a-zA-Z0-9]{3,20}@[a-zA-Z0-9]{2,10}.[a-zA-Z]{2,3}$");
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
