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
    public partial class frmReportCN : Form
    {
        public frmReportCN()
        {
            InitializeComponent();
        }

        

        private void frmReportCN_Load(object sender, EventArgs e)
        {
            

        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangNoiThatDataSetCN.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.quanLyCuaHangNoiThatDataSetCongNo.DataTable1,dateTimePicker1.Value,dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
