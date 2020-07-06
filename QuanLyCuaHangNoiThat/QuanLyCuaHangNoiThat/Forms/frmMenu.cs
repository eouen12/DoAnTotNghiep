using FontAwesome.Sharp;
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

namespace QuanLyCuaHangNoiThat
{
    public partial class frmMenu : Form
    {
        private IconButton currentIconBtn;
        private Panel currentPanel;
        private Form currentfrmDesktop;
        private NHANVIEN nhanvien = new NHANVIEN();
        // private string patch = @"C:\Users\trant\OneDrive\Desktop\DoAnTotNghiep\Anh_NhanVien\";
        private string patch = @"..\..\..\..\Anh_NhanVien\";
        public frmMenu(NHANVIEN nv)
        {
            InitializeComponent();
            nhanvien = nv;
            this.currentIconBtn = new IconButton();
            this.currentPanel = new Panel();
            this.currentPanel.Size = new Size(5, btnMenuCongNo.Size.Height);
            panelMenu.Controls.Add(this.currentPanel);

            this.currentfrmDesktop = new Form();

            ChucVu();
            LoadAnhDaiDien();
            LoadLSHeThong();
        }
        private void btnMenuHoaDon_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmHoaDon(),sender,e);
        }

        private void btnMenuSanPham_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmSanPham(nhanvien.MANV), sender, e);
        }

        private void btnMenuKhachHang_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmKhachHang(nhanvien.MANV), sender, e);
        }

        private void btnMenuCongNo_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmCongNo(), sender, e);
        }

        private void btnMenuNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmNhaPhanPhoi(nhanvien.MANV), sender, e);
        }

        private void btnMenuNhanVien_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmNhanVien(nhanvien.MANV), sender, e);
        }

        private void btnMenuDoiDonVi_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
        }

        private void btnMenuDangXuat_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            this.Visible = false;
            frmDangNhap dangnhap = new frmDangNhap();
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                frmMenu menu = new frmMenu(frmDangNhap.nv);
                menu.Show();
            }
        }

        private void btnStatusMenu_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void IconButtonMenuClick(object sender, EventArgs e)
        {
            if(sender != null)
            {
                this.currentIconBtn.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                this.currentIconBtn = (IconButton)sender;
                this.currentIconBtn.BackColor = Color.Silver;
                btnStatusMenu.Text = this.currentIconBtn.Text;
                btnStatusMenu.IconChar = this.currentIconBtn.IconChar;

                this.currentPanel.BackColor = Color.Black;
                this.currentPanel.Location = new Point(0, this.currentIconBtn.Location.Y);
                this.currentPanel.Visible = true;
                this.currentPanel.BringToFront();
            }
        }

        private void MofrmDesktop(Form frm, object sender, EventArgs e)
        {
            if (frm != null /*&& frm.DialogResult != DialogResult.No*/)
            {
                this.currentfrmDesktop.Close();
            }
            if (this.currentfrmDesktop.DialogResult != DialogResult.No)
            {
                this.currentfrmDesktop = frm;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(frm);
                panelDesktop.Tag = frm;
                frm.BringToFront();
                frm.Show();
                IconButtonMenuClick(sender, e);
            }
        }

        private void Reset()
        {
            btnStatusMenu.Text = "Trang chủ";
            btnStatusMenu.IconChar = IconChar.Home;
            this.currentPanel.Visible = false;

            this.currentfrmDesktop.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = System.DateTime.Now.ToString("dd/MM/yyyy") + " " + System.DateTime.Now.ToLongTimeString();
            LoadLSHeThong();
        }

        private void lblTenNhanVien_Click(object sender, EventArgs e)
        {
            frmDoiMatKhauNV frm = new frmDoiMatKhauNV(nhanvien);
            frm.ShowDialog();
        }

        void ChucVu()
        {
            if(nhanvien.CHUCVU == "NV")
            {
                btnMenuNhanVien.Enabled = false;
            }
            else
            {
                btnMenuNhanVien.Enabled = true;
            }
        }

        void LoadAnhDaiDien()
        {
            this.imgAnhNhanVien.ImageLocation = patch + nhanvien.ANHDAIDIEN;
            this.lblTenNhanVien.Text = nhanvien.TENNV;
        }

        void LoadLSHeThong()
        {
            this.dgvLSHeThong.AutoGenerateColumns = false;
            this.dgvLSHeThong.DataSource = LichSuHeThongBUS.LayDanhSachLSHT();
        }
    }
}
