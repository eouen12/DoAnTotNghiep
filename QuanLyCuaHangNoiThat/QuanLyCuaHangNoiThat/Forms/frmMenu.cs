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
using QuanLyCuaHangNoiThat.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmMenu : Form
    {
        private IconButton currentIconBtn;
        private Panel currentPanel;
        private Form currentfrmDesktop;
        private NHANVIEN nhanvien = new NHANVIEN();
        private List<LICHSUHETHONG> lsht = new List<LICHSUHETHONG>();
        private string patch = @"..\..\..\..\Anh_NhanVien\";
        private string patchLogo = @"..\..\..\..\logo3.jpg";
        //private string patch = @"Anh_NhanVien\";
        //private string patchLogo = @"logo3.jpg";
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = patchLogo;
            Form frm = new frmTrangChu();
            this.currentfrmDesktop = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            panelDesktop.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
        private void btnMenuHoaDon_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmHoaDon(nhanvien.MANV), sender, e);
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
            MofrmDesktop(new frmCongNo(nhanvien.MANV), sender, e);
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
            MofrmDesktop(new frmQuyDoi(nhanvien.MANV), sender, e);
        }

        private void btnfrmLSHT_Click(object sender, EventArgs e)
        {
            MofrmDesktop(new frmLSHeThong(), sender, e);
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
            frmMenu_Load(sender, e);
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
            if (frm != null)
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
                LoadLSHeThong();
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
            LoadAnhDaiDien();
            if(lsht.Count != LichSuHeThongBUS.LayDanhSachLSHT().Count)
            {
                LoadLSHeThong();
            }
        }

        private void lblTenNhanVien_Click(object sender, EventArgs e)
        {
            frmDoiMatKhauNV frm = new frmDoiMatKhauNV(nhanvien);
            frm.ShowDialog();
        }

        void ChucVu()
        {
            if(nhanvien.CHUCVU != "NV")
            {
                btnMenuNhanVien.Enabled = true;
                this.dgvLSHeThong.Visible= true;
                btnfrmLSHT.Enabled = true;
                btnTKCN.Enabled = true;
                btnTKDT.Enabled = true;
            }
            else
            {
                btnMenuNhanVien.Enabled = false;
                this.dgvLSHeThong.Visible = false;
                btnfrmLSHT.Enabled = false;
                btnTKCN.Enabled = false;
                btnTKDT.Enabled = false;

                Label lbl = new Label();
                lbl.Name = "lblBottom";
                lbl.AutoSize = false;
                lbl.Size = new System.Drawing.Size(692, 210);
                lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
                lbl.Location = new System.Drawing.Point(0, 0);
                lbl.Margin = new System.Windows.Forms.Padding(4);
                this.panel6.Controls.Add(lbl);
            }

        }

        void LoadAnhDaiDien()
        {
            this.imgAnhNhanVien.ImageLocation = patch + NhanVienBUS.LayNhanVien(nhanvien.MANV).ANHDAIDIEN;
        }

        void LoadLSHeThong()
        {
            lsht = LichSuHeThongBUS.LayDanhSachLSHT();
            this.dgvLSHeThong.AutoGenerateColumns = false;
            var kq = LichSuHeThongBUS.LayDanhSachLSHT().OrderByDescending(p=>p.ID).Take(50);
            this.dgvLSHeThong.DataSource = kq.ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvLSHeThong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTKCN_Click(object sender, EventArgs e)
        {
            frmReportCN frm = new frmReportCN();
            frm.ShowDialog();
        }

        private void btnTKDT_Click(object sender, EventArgs e)
        {
            frmReportDT frm = new frmReportDT();
            frm.ShowDialog();
        }
    }
}
