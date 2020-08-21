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
using System.Security.Cryptography;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmDangNhap : Form
    {
        public static NHANVIEN nv = new NHANVIEN();
        private string patch = @"..\..\..\..\logodn.jpg";
        //private string patch = @"logodn.jpg";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenDangNhap.Text == string.Empty || txtMatKhau.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(NhanVienBUS.LayDanhSachAllNV().FirstOrDefault(p=>p.MANV == this.txtTenDangNhap.Text) == null)
                {
                    MessageBox.Show("Tài khoản không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
                if(NhanVienBUS.KiemTraDangNhap(txtTenDangNhap.Text,MD5(txtMatKhau.Text)))
                {
                    nv = NhanVienBUS.LayThongTinCuaNV(this.txtTenDangNhap.Text).FirstOrDefault();
                    DialogResult = DialogResult.OK;
                }
                else if (NhanVienBUS.KiemTraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    nv = NhanVienBUS.LayThongTinCuaNV(this.txtTenDangNhap.Text).FirstOrDefault();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btnDangNhap_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            AutoCompleteMaNV();
            this.pictureBox1.ImageLocation = patch;
        }

        void AutoCompleteMaNV()
        {
            List<String> lst = NhanVienBUS.LayDanhSachMaNV();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach(string item in lst )
            {
                collection.Add(item);
            }
            txtTenDangNhap.AutoCompleteCustomSource = collection;
            txtTenDangNhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenDangNhap.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        string MD5(string mk)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(mk));
            byte[] kq = md5.Hash;
            StringBuilder str = new StringBuilder();
            foreach (var item in kq)
            {
                str.Append(item.ToString("x2"));
            }
            return str.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
