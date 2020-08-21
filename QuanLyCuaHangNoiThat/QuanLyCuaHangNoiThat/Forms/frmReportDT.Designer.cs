namespace QuanLyCuaHangNoiThat
{
    partial class frmReportDT
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
            this.HOADONBANHANG1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyCuaHangNoiThatDataSet1 = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.HOADONBANHANG1TableAdapter = new QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThatDataSet1TableAdapters.HOADONBANHANG1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBANHANG1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangNoiThatDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // HOADONBANHANG1BindingSource
            // 
            this.HOADONBANHANG1BindingSource.DataMember = "HOADONBANHANG1";
            this.HOADONBANHANG1BindingSource.DataSource = this.QuanLyCuaHangNoiThatDataSet1;
            // 
            // QuanLyCuaHangNoiThatDataSet1
            // 
            this.QuanLyCuaHangNoiThatDataSet1.DataSetName = "QuanLyCuaHangNoiThatDataSet1";
            this.QuanLyCuaHangNoiThatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(497, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTK.Location = new System.Drawing.Point(994, 9);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(184, 52);
            this.btnTK.TabIndex = 16;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(676, 20);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 34);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2020, 8, 21, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOADONBANHANG1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.ReportDT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 73);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1255, 588);
            this.reportViewer1.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 34);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 21, 0, 0, 0, 0);
            // 
            // HOADONBANHANG1TableAdapter
            // 
            this.HOADONBANHANG1TableAdapter.ClearBeforeFill = true;
            // 
            // frmReportDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmReportDT";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmReportDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBANHANG1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangNoiThatDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBANHANG1BindingSource;
        private QuanLyCuaHangNoiThatDataSet1 QuanLyCuaHangNoiThatDataSet1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private QuanLyCuaHangNoiThatDataSet1TableAdapters.HOADONBANHANG1TableAdapter HOADONBANHANG1TableAdapter;
    }
}