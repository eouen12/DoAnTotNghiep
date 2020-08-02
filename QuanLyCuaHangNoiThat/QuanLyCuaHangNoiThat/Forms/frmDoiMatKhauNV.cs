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
using System.Security.Cryptography;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmDoiMatKhauNV : Form
    {
        private NHANVIEN nv = new NHANVIEN();
        private string patch = @"..\..\..\..\Anh_NhanVien\";
        public frmDoiMatKhauNV(NHANVIEN nhanvien)
        {
            InitializeComponent();
            nv = nhanvien;
        }

        private void frmDoiMatKhauNV_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin nhân viên " + nv.MANV;
            this.lblMaNV.Text = nv.MANV;
            this.lblTenNV.Text = nv.TENNV;
            this.lblCMNDNV.Text = nv.CMND.ToString();
            this.lblSDTNV.Text = nv.SDT;
            this.lblDiaChiNV.Text = nv.DIACHI;
            this.lblEmail.Text = nv.EMAIL;
            this.imgNhanVien.ImageLocation = patch + nv.ANHDAIDIEN;
        }

        private void btnLuuDoiMK_Click(object sender, EventArgs e)
        {
            if(this.txtMatKhauCu.Text == nv.MANV)
            {
                string mk = MD5(this.txtMatKhauMoi.Text);
                if(NhanVienBUS.DoiMatKhau(nv.MANV,mk))
                {
                    MessageBox.Show("Đổi mật khẩu thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.txtMatKhauCu.Clear();
                    this.txtMatKhauMoi.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại !!!", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            if(MD5(this.txtMatKhauCu.Text) != nv.MATKHAU)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(this.txtMatKhauCu.Text != this.txtMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string mkMoi = MD5(this.txtMatKhauMoi.Text);
            if (NhanVienBUS.DoiMatKhau(nv.MANV, mkMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtMatKhauCu.Clear();
                this.txtMatKhauMoi.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại !!!", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }

        string MD5 (string mk)
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

        private void btnThoatDoiMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
