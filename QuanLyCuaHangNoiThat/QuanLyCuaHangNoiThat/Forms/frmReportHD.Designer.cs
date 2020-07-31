namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmReportHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportHD));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangNoiThatDataSet1 = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSet1TableAdapters.DataTable1TableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnBC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangNoiThatDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.quanLyCuaHangNoiThatDataSet1;
            // 
            // quanLyCuaHangNoiThatDataSet1
            // 
            this.quanLyCuaHangNoiThatDataSet1.DataSetName = "QuanLyCuaHangNoiThatDataSet1";
            this.quanLyCuaHangNoiThatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report3.rdlc";
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Value = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            // 
            // btnBC
            // 
            this.btnBC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnBC, "btnBC");
            this.btnBC.Name = "btnBC";
            this.btnBC.UseVisualStyleBackColor = false;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // frmReportHD
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmReportHD";
            this.Load += new System.EventHandler(this.frmReportHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangNoiThatDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QuanLyCuaHangNoiThatDataSet1 quanLyCuaHangNoiThatDataSet1;
        private QuanLyCuaHangNoiThatDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}