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

namespace QuanLyCuaHangNoiThat
{
    public partial class frmDangNhap : Form
    {
        private string chucvu;
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
                if(NhanVienBUS.KiemTraDangNhap(txtTenDangNhap.Text,txtMatKhau.Text))
                {
                    chucvu = NhanVienBUS.ChucVuNhanVien(txtTenDangNhap.Text);
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
        }

        void AutoCompleteMaNV()
        {
            List<String> lst = NhanVienBUS.LayDanhSachNhanVien();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach(string item in lst )
            {
                collection.Add(item);
            }
            txtTenDangNhap.AutoCompleteCustomSource = collection;
            txtTenDangNhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenDangNhap.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

    }
}
