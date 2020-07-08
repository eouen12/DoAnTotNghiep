using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangNoiThatDataSet.HOADONBANHANG' table. You can move, or remove it, as needed.
            this.hOADONBANHANGTableAdapter.Fill(this.quanLyCuaHangNoiThatDataSet.HOADONBANHANG);
            // TODO: This line of code loads data into the 'quanLyCuaHangNoiThatDataSet1.CTHOADONBANHANG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyCuaHangNoiThatDataSet.HOADONBANHANG' table. You can move, or remove it, as needed.
            //this.hOADONBANHANGTableAdapter.Fill(this.quanLyCuaHangNoiThatDataSet.HOADONBANHANG , "HD0002");

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void hOADONBANHANGBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
