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
    public partial class frmLSHeThong : Form
    {
        private List<LICHSUHETHONG> lstLSHT = new List<LICHSUHETHONG>();
        private List<NHANVIEN> lstnv = new List<NHANVIEN>();
        public frmLSHeThong()
        {
            InitializeComponent();

        }

        private void frmLSHeThong_Load(object sender, EventArgs e)
        {
            
            LoadDataComboBox();
            LoadLichSuHeThong();
        }

        private void dtNgayTao_ValueChanged(object sender, EventArgs e)
        {
            TimKiem(this.dtNgayTao.Value);
        }

        private void cbNVThaoTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbNVThaoTac.SelectedIndex != -1)
            {
                TimKiem(this.cbNVThaoTac.SelectedValue.ToString());
            }
        }

        private void cbViTriThaoTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbViTriThaoTac.SelectedIndex != -1)
            {
                TimKiem(this.cbViTriThaoTac.SelectedItem.ToString());
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TimKiem(this.dtNgayTao.Value, this.cbNVThaoTac.SelectedValue.ToString(), this.cbViTriThaoTac.SelectedItem.ToString());
        }
        private void ckTimTheoAllDK_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ckTimTheoAllDK.Checked)
            {
                this.btnTimAll.Enabled = true;
            }
            else
            {
                this.btnTimAll.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void LoadDataComboBox()
        {
            this.lstnv = NhanVienBUS.LayDanhSachAllNV();
            this.cbNVThaoTac.DataSource = this.lstnv;
            this.cbNVThaoTac.DisplayMember = "MANV";
            this.cbNVThaoTac.ValueMember = "MANV";

            this.cbViTriThaoTac.SelectedIndex = 0;
            
            //this.cbViTriThaoTac.DataSource = this.lstvitri;
            ////this.cbViTriThaoTac.DisplayMember = "vitrithaotac";
            //this.cbViTriThaoTac.ValueMember = "vitrithaotac";
        }
        void TimKiem(string chuoi)
        {
            var kq = from ls in lstLSHT
                     where ls.NV_THAOTAC.Contains(chuoi)
                            || ls.VITRI_THAOTAC.Contains(chuoi)
                     select new { ls.GHICHU };
            this.dgvLSHeThong.AutoGenerateColumns = false;
            this.dgvLSHeThong.DataSource = kq.ToList();
        }
        void TimKiem(DateTime dt)
        {
            var kq = from ls in lstLSHT
                     where ls.NGAYTAO.Value == dt.Date
                     select new { ls.GHICHU };
            this.dgvLSHeThong.AutoGenerateColumns = false;
            this.dgvLSHeThong.DataSource = kq.ToList();
        }

        void TimKiem(DateTime dt,string nv, string vitri)
        {
            var kq = from ls in lstLSHT
                     where ls.NGAYTAO.Value == dt.Date
                            && ls.NV_THAOTAC.Contains(nv)
                            && ls.VITRI_THAOTAC.Contains(vitri)
                     select new { ls.GHICHU };
            this.dgvLSHeThong.AutoGenerateColumns = false;
            this.dgvLSHeThong.DataSource = kq.ToList();
        }

        void LoadLichSuHeThong()
        {
            this.lstLSHT = LichSuHeThongBUS.LayDanhSachLSHT();
            this.dgvLSHeThong.AutoGenerateColumns = false;
            this.dgvLSHeThong.DataSource = this.lstLSHT;
        }

        void Reset()
        {
            this.ckTimTheoAllDK.Checked = false;
            this.btnTimAll.Enabled = false;
            this.dtNgayTao.Value = DateTime.Now;
            this.cbViTriThaoTac.SelectedIndex = 0;
            LoadDataComboBox();
            LoadLichSuHeThong();
        }
    }
}
