using QuanLyCuaHangNoiThat.Forms;
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

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class FrmDoiDonVi : Form
    {
        private string manv;
        private List<DOIDONVINEN> lstDDVNEN = new List<DOIDONVINEN>();
        private List<DOIDONVITUONG> lstDDVTUONG = new List<DOIDONVITUONG>();
        public FrmDoiDonVi(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            Load1();
            Load2();
            AddBinding();
        }
        void Load1()
        {
            lstDDVNEN = DoiDonViNenBUS.LayDSGachNen();
            comboBox1.DataSource = lstDDVNEN;
            comboBox1.DisplayMember = "TENGACH";
        }
        void AddBinding()
        {
            txtMet.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "SOMETNEN" ));
            txtMetToi.DataBindings.Add(new Binding("Text", comboBox2.DataSource, "SOMETTOI"));
        }
        void Load2()
        {
            lstDDVTUONG = DoiDonViTuongBUS.LayDSGachTuong();
            comboBox2.DataSource = lstDDVTUONG;
            comboBox2.DisplayMember = "TENGACHTUONG";
        }

        private void btndoi1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtMet.Text);
            double b = Convert.ToDouble(txtNhapMetVuong.Text);
            // txtKQ2.Text = ((b / a ) + " thùng").ToString();
            txtKQ1.Text = Convert.ToInt32(b / a)  +" thùng";
        }

        private void btndoi2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNhapMetToi.Text);
            double b = Convert.ToDouble(txtMetToi.Text);
            double c = Convert.ToDouble(txtNhapSoLop.Text);
            //txtKQ2.Text = ((a / b)*c + " thùng").ToString();
            txtKQ2.Text = Convert.ToInt32((a / b) * c) +" thùng";
        }

        private void txtNhapMetVuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNhapMetToi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNhapSoLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNhapMetVuong_TextChanged(object sender, EventArgs e)
        {
            btndoi1.Enabled = true;
        }

        private void txtNhapSoLop_TextChanged(object sender, EventArgs e)
        {
            btndoi2.Enabled = true;
        }

        private void txtNhapMetToi_TextChanged(object sender, EventArgs e)
        {
            txtNhapSoLop.Enabled = true;
        }

        private void btnLamMoiDV_Click(object sender, EventArgs e)
        {
            txtNhapMetVuong.Clear();
            txtNhapSoLop.Clear();
            txtNhapMetToi.Clear();
            txtKQ2.Clear();
            Load1();
            Load2();
            btndoi1.Enabled = false;
            btndoi2.Enabled = false;
            txtNhapSoLop.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.DataSource = 
        }
    }
}
