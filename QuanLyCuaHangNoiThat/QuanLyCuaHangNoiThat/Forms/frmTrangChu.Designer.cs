namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmTrangChu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSCongNo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MACONGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENCONNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateNgayThang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDSCongNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 564);
            this.panel1.TabIndex = 0;
            // 
            // dgvDSCongNo
            // 
            this.dgvDSCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSCongNo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSCongNo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCongNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACONGNO,
            this.MAKH,
            this.TENKH,
            this.TONGTIEN,
            this.TIENCONNO,
            this.NGAYTRA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSCongNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSCongNo.Location = new System.Drawing.Point(12, 144);
            this.dgvDSCongNo.Name = "dgvDSCongNo";
            this.dgvDSCongNo.ReadOnly = true;
            this.dgvDSCongNo.RowHeadersVisible = false;
            this.dgvDSCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCongNo.Size = new System.Drawing.Size(930, 408);
            this.dgvDSCongNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách công nợ cần thu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNgayThang
            // 
            this.dateNgayThang.CustomFormat = "MM/yyyy";
            this.dateNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayThang.Location = new System.Drawing.Point(502, 74);
            this.dateNgayThang.Name = "dateNgayThang";
            this.dateNgayThang.Size = new System.Drawing.Size(184, 31);
            this.dateNgayThang.TabIndex = 2;
            this.dateNgayThang.ValueChanged += new System.EventHandler(this.dateNgayThang_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Công nợ trong tháng:";
            // 
            // MACONGNO
            // 
            this.MACONGNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MACONGNO.DataPropertyName = "MACONGNO";
            this.MACONGNO.HeaderText = "Mã công nợ";
            this.MACONGNO.Name = "MACONGNO";
            this.MACONGNO.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền (VND)";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // TIENCONNO
            // 
            this.TIENCONNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIENCONNO.DataPropertyName = "TIENCONNO";
            this.TIENCONNO.HeaderText = "Tiền còn nợ (VND)";
            this.TIENCONNO.Name = "TIENCONNO";
            this.TIENCONNO.ReadOnly = true;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTRA.DataPropertyName = "NGAYTRA";
            this.NGAYTRA.HeaderText = "Hạn trả nợ";
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 564);
            this.Controls.Add(this.panel1);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCongNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSCongNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACONGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENCONNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
    }
}