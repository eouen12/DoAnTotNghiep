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
        public frmNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void frmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            LoadDataDSLoaiSP();
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
    }
}
