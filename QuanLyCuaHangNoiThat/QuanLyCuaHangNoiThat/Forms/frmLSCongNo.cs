﻿using BUS;
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
            this.lblMacn.Text = macn;
            var cn = LichSuTraNoBUS.LayDSLSTraNoCuaKH(macn);
            this.dgvLSCongNo.AutoGenerateColumns = false;
            this.dgvLSCongNo.DataSource = cn.ToList();
            this.dgvLSCongNo.Columns["NgayTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvLSCongNo.Columns["TienTra"].DefaultCellStyle.Format = "#,##0";
        }

        
    }
 }


