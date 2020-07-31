using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmReportHD : Form
    {
        public frmReportHD()
        {
            InitializeComponent();
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.quanLyCuaHangNoiThatDataSet1.DataTable1, dateTimePicker1.Value, dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
