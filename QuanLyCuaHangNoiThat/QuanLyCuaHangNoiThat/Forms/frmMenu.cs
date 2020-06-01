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

namespace QuanLyCuaHangNoiThat
{
    public partial class frmMenu : Form
    {
        private IconButton currentIconBtn;
        private Panel currentPanel;
        private Form currentfrmDesktop;
        public frmMenu()
        {
            InitializeComponent();
            this.currentIconBtn = new IconButton();
            this.currentPanel = new Panel();
            this.currentPanel.Size = new Size(5, 60);
            panelMenu.Controls.Add(this.currentPanel);

            this.currentfrmDesktop = new Form();
           
        }
        private void btnMenuHoaDon_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            MofrmDesktop(new frmHoaDon());
        }

        private void btnMenuSanPham_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            MofrmDesktop(new frmSanPham());
        }

        private void btnMenuKhachHang_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            MofrmDesktop(new frmKhachHang());
        }

        private void btnMenuCongNo_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            MofrmDesktop(new frmCongNo());
        }

        private void btnMenuNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            MofrmDesktop(new frmNhaPhanPhoi());
        }

        private void btnMenuNhanVien_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
            MofrmDesktop(new frmNhanVien());
        }

        private void btnMenuDoiDonVi_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
        }

        private void btnMenuDangXuat_Click(object sender, EventArgs e)
        {
            IconButtonMenuClick(sender, e);
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

        private void MofrmDesktop(Form frm)
        {
            if (frm != null)
            {
                this.currentfrmDesktop.Close();
            }
            this.currentfrmDesktop = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            panelDesktop.Tag = frm;
            frm.BringToFront();
            frm.Show();
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
        }

    }
}
