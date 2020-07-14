namespace QuanLyCuaHangNoiThat
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyCuaHangNoiThatDataSet = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSet();
            this.KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHACHHANGTableAdapter = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSetTableAdapters.KHACHHANGTableAdapter();
            this.cTHOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHOADONBANHANGTableAdapter = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSetTableAdapters.CTHOADONBANHANGTableAdapter();
            this.hOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBANHANGTableAdapter = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSetTableAdapters.HOADONBANHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangNoiThatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBANHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBANHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KHACHHANGBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.cTHOADONBANHANGBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.hOADONBANHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyCuaHangNoiThatDataSet
            // 
            this.QuanLyCuaHangNoiThatDataSet.DataSetName = "QuanLyCuaHangNoiThatDataSet";
            this.QuanLyCuaHangNoiThatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHACHHANGBindingSource
            // 
            this.KHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.KHACHHANGBindingSource.DataSource = this.QuanLyCuaHangNoiThatDataSet;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // cTHOADONBANHANGBindingSource
            // 
            this.cTHOADONBANHANGBindingSource.DataMember = "CTHOADONBANHANG";
            this.cTHOADONBANHANGBindingSource.DataSource = this.QuanLyCuaHangNoiThatDataSet;
            // 
            // cTHOADONBANHANGTableAdapter
            // 
            this.cTHOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // hOADONBANHANGBindingSource
            // 
            this.hOADONBANHANGBindingSource.DataMember = "HOADONBANHANG";
            this.hOADONBANHANGBindingSource.DataSource = this.QuanLyCuaHangNoiThatDataSet;
            // 
            // hOADONBANHANGTableAdapter
            // 
            this.hOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangNoiThatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBANHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBANHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHACHHANGBindingSource;
        private QuanLyCuaHangNoiThatDataSet QuanLyCuaHangNoiThatDataSet;
        private QuanLyCuaHangNoiThatDataSetTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource cTHOADONBANHANGBindingSource;
        private QuanLyCuaHangNoiThatDataSetTableAdapters.CTHOADONBANHANGTableAdapter cTHOADONBANHANGTableAdapter;
        private System.Windows.Forms.BindingSource hOADONBANHANGBindingSource;
        private QuanLyCuaHangNoiThatDataSetTableAdapters.HOADONBANHANGTableAdapter hOADONBANHANGTableAdapter;
    }
}