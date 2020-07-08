namespace QuanLyCuaHangNoiThat.Forms
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyCuaHangNoiThatDataSet = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSet();
            this.quanLyCuaHangNoiThatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBANHANGTableAdapter = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSetTableAdapters.HOADONBANHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangNoiThatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangNoiThatDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBANHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hOADONBANHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyCuaHangNoiThatDataSet
            // 
            this.quanLyCuaHangNoiThatDataSet.DataSetName = "QuanLyCuaHangNoiThatDataSet";
            this.quanLyCuaHangNoiThatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyCuaHangNoiThatDataSetBindingSource
            // 
            this.quanLyCuaHangNoiThatDataSetBindingSource.DataSource = this.quanLyCuaHangNoiThatDataSet;
            this.quanLyCuaHangNoiThatDataSetBindingSource.Position = 0;
            // 
            // hOADONBANHANGBindingSource
            // 
            this.hOADONBANHANGBindingSource.DataMember = "HOADONBANHANG";
            this.hOADONBANHANGBindingSource.DataSource = this.quanLyCuaHangNoiThatDataSetBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangNoiThatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangNoiThatDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBANHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyCuaHangNoiThatDataSet quanLyCuaHangNoiThatDataSet;
        private System.Windows.Forms.BindingSource quanLyCuaHangNoiThatDataSetBindingSource;
        private System.Windows.Forms.BindingSource hOADONBANHANGBindingSource;
        private QuanLyCuaHangNoiThatDataSetTableAdapters.HOADONBANHANGTableAdapter hOADONBANHANGTableAdapter;
    }
}