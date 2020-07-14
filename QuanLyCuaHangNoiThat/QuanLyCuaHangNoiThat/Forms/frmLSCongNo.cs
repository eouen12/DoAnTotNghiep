using BUS;
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
    public partial class frmLSCongNo : Form
    {
        private string macn;
        public frmLSCongNo(string macn)
        {
            InitializeComponent();
            this.macn = macn;
            this.Text = "Chi tiết trả nợ " + this.macn;
        }
            private void frmLSCongNo_Load_1(object sender, EventArgs e)
                    {
                        LoadThongTin();
                    }
            void LoadThongTin()
            {
            var cn = LichSuTraNoBUS.LayDSLSTraNoCuaKH(macn).Find(p => p.MACONGNO == macn); ;
                
                this.lblNgaytra.Text = Convert.ToDateTime(cn.NGAYTRA_THEODOI).ToString();
                this.lblMacn.Text = cn.MACONGNO;
                this.lblTientra.Text = Convert.ToInt32(cn.TIENTRA_THEODOI).ToString("#,##0") + " VND";
            }

        
    }
 }


