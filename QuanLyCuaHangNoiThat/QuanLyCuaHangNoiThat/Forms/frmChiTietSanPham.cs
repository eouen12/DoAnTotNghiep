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
    public partial class frmChiTietSanPham : Form
    {
        private string masp;
        public frmChiTietSanPham(string masp)
        {
            InitializeComponent();
            this.masp = masp;
        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        void LoadThongTin()
        {
            var sp = SanPhamBUS.LayDanhSachSanPham().Find(p => p.MASP == masp);
            this.lblMasp.Text = sp.MASP;
            this.lblTensp.Text = sp.TENSP;
            this.lblGiaban.Text = sp.GIABAN.ToString();
            this.lblSoluong.Text = sp.SL_TON.ToString();
            this.lblMaloai.Text = sp.MALOAI;
            this.lblTenloai.Text = sp.LOAISANPHAM.TENLOAI;
            this.lblMaNPP.Text = sp.MANPP;
            this.lblTenNPP.Text = sp.NHAPHANPHOI.TENNPP;
        }
    }
}
