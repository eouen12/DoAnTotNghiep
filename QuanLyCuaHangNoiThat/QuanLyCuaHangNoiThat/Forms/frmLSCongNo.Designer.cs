namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmLSCongNo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMacn = new System.Windows.Forms.Label();
            this.dgvLSCongNo = new System.Windows.Forms.DataGridView();
            this.Macongno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLSCongNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMacn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Trả Nợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã công nợ :";
            // 
            // lblMacn
            // 
            this.lblMacn.AutoSize = true;
            this.lblMacn.Location = new System.Drawing.Point(173, 53);
            this.lblMacn.Name = "lblMacn";
            this.lblMacn.Size = new System.Drawing.Size(148, 29);
            this.lblMacn.TabIndex = 0;
            this.lblMacn.Text = "Mã công nợ";
            // 
            // dgvLSCongNo
            // 
            this.dgvLSCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLSCongNo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLSCongNo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLSCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macongno,
            this.TienTra,
            this.NgayTra});
            this.dgvLSCongNo.Location = new System.Drawing.Point(12, 113);
            this.dgvLSCongNo.Name = "dgvLSCongNo";
            this.dgvLSCongNo.ReadOnly = true;
            this.dgvLSCongNo.RowHeadersVisible = false;
            this.dgvLSCongNo.RowHeadersWidth = 51;
            this.dgvLSCongNo.RowTemplate.Height = 24;
            this.dgvLSCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLSCongNo.Size = new System.Drawing.Size(776, 289);
            this.dgvLSCongNo.TabIndex = 6;
            // 
            // Macongno
            // 
            this.Macongno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Macongno.DataPropertyName = "MACONGNO";
            this.Macongno.HeaderText = "Mã công nợ";
            this.Macongno.MinimumWidth = 6;
            this.Macongno.Name = "Macongno";
            this.Macongno.ReadOnly = true;
            // 
            // TienTra
            // 
            this.TienTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienTra.DataPropertyName = "TIENTRA_THEODOI";
            this.TienTra.HeaderText = "Tiền trả theo đợt";
            this.TienTra.MinimumWidth = 6;
            this.TienTra.Name = "TienTra";
            this.TienTra.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayTra.DataPropertyName = "NGAYTRA_THEODOI";
            this.NgayTra.HeaderText = "Ngày trả theo đợt";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // frmLSCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLSCongNo";
            this.Text = "frmLSCongNo";
            this.Load += new System.EventHandler(this.frmLSCongNo_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSCongNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMacn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLSCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Macongno;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}