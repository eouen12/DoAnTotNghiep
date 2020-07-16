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
        public FrmDoiDonVi(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            Load1();
            Load2();
            AddBinding();
        }
        public class Gach
        {
            public string GachNen { get; set; }
            public double KTGachNen { get; set; }
            public string GachTuong { get; set; }
            public double KTGachTuong { get; set; }

        }
        List<Gach> listItem;
        void Load1()
        {
            listItem = new List<Gach>()
            {
                new Gach(){GachNen = "30x30 - 6 viên/thùng" ,KTGachNen = 0.9},
                new Gach(){GachNen = "40x40 - 4 viên/thùng" ,KTGachNen = 1.6},
                new Gach(){GachNen = "50x50 - 5 viên/thùng" ,KTGachNen = 1.25},
                new Gach(){GachNen = "60x60 - 4 viên/thùng" ,KTGachNen = 1.2},
                new Gach(){GachNen = "80x80 - 4 viên/thùng",KTGachNen = 1.6},
            };
            comboBox1.DataSource = listItem;
            comboBox1.DisplayMember = "GachNen";
        }
        void AddBinding()
        {
            txtMet.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "KTGachNen" ));
            txtMetToi.DataBindings.Add(new Binding("Text", comboBox2.DataSource, "KTGachTuong" ));
        }
        void Load2()
        {
            listItem = new List<Gach>()
            {
                new Gach(){GachTuong = "25x40 - 6 viên/thùng" ,KTGachTuong = 1.2},
                new Gach(){GachTuong = "30x45 - 6 viên/thùng" ,KTGachTuong = 1.3},
                new Gach(){GachTuong = "30x60 - 6 viên/thùng" ,KTGachTuong = 1.4},
                new Gach(){GachTuong = "40x80 - 6 viên/thùng" ,KTGachTuong = 1.5},
            };
            comboBox2.DataSource = listItem;
            comboBox2.DisplayMember = "GachTuong";
        }

        private void btndoi1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtMet.Text);
            double b = Convert.ToDouble(txtNhapMetVuong.Text);
            // txtKQ2.Text = ((b / a ) + " thùng").ToString();
            txtKQ2.Text = Convert.ToInt32((b / a)) + " thùng";
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
            btndoi1.Enabled = false;
            btndoi2.Enabled = false;
            txtNhapSoLop.Enabled = false;
        }
    }
}
