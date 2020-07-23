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
        private string mahd;
        public frmReport(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangNoiThatDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.quanLyCuaHangNoiThatDataSet.DataTable1,mahd);

            this.reportViewer1.RefreshReport();
        }
    }
}
