namespace QuanLyCuaHangNoiThat
{
    partial class frmCongNo
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtTienConNo = new System.Windows.Forms.TextBox();
            this.txtTenKHCongNo = new System.Windows.Forms.TextBox();
            this.txtSDTKHCongNo = new System.Windows.Forms.TextBox();
            this.txtCMNDKHCongNo = new System.Windows.Forms.TextBox();
            this.txtDiaChiKHCongNo = new System.Windows.Forms.TextBox();
            this.txtSoTienTraHomNay = new System.Windows.Forms.TextBox();
            this.btnXacNhanThanhToan = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MACONGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKHCongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKHCongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienConNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dgvCongNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(612, 672);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công nợ khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 34);
            this.textBox1.TabIndex = 1;
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCongNo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACONGNO,
            this.MaKHCongNo,
            this.TenKHCongNo,
            this.TONGTIEN,
            this.TienConNo,
            this.NGAYTRA});
            this.dgvCongNo.Location = new System.Drawing.Point(8, 79);
            this.dgvCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.RowHeadersVisible = false;
            this.dgvCongNo.RowHeadersWidth = 51;
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.Size = new System.Drawing.Size(596, 571);
            this.dgvCongNo.TabIndex = 0;
            this.dgvCongNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongNo_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePickerNgayTra);
            this.groupBox2.Controls.Add(this.txtTienConNo);
            this.groupBox2.Controls.Add(this.txtTenKHCongNo);
            this.groupBox2.Controls.Add(this.txtSDTKHCongNo);
            this.groupBox2.Controls.Add(this.txtCMNDKHCongNo);
            this.groupBox2.Controls.Add(this.txtDiaChiKHCongNo);
            this.groupBox2.Controls.Add(this.txtSoTienTraHomNay);
            this.groupBox2.Controls.Add(this.btnXacNhanThanhToan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(636, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(620, 672);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết công nợ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Enabled = false;
            this.lblTongTien.Location = new System.Drawing.Point(300, 298);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(311, 34);
            this.lblTongTien.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tổng tiền";
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayTra.Enabled = false;
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(300, 447);
            this.dateTimePickerNgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(313, 34);
            this.dateTimePickerNgayTra.TabIndex = 24;
            // 
            // txtTienConNo
            // 
            this.txtTienConNo.Enabled = false;
            this.txtTienConNo.Location = new System.Drawing.Point(300, 398);
            this.txtTienConNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienConNo.Name = "txtTienConNo";
            this.txtTienConNo.Size = new System.Drawing.Size(311, 34);
            this.txtTienConNo.TabIndex = 23;
            // 
            // txtTenKHCongNo
            // 
            this.txtTenKHCongNo.Enabled = false;
            this.txtTenKHCongNo.Location = new System.Drawing.Point(216, 41);
            this.txtTenKHCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKHCongNo.Name = "txtTenKHCongNo";
            this.txtTenKHCongNo.Size = new System.Drawing.Size(311, 34);
            this.txtTenKHCongNo.TabIndex = 21;
            // 
            // txtSDTKHCongNo
            // 
            this.txtSDTKHCongNo.Enabled = false;
            this.txtSDTKHCongNo.Location = new System.Drawing.Point(216, 101);
            this.txtSDTKHCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTKHCongNo.Name = "txtSDTKHCongNo";
            this.txtSDTKHCongNo.Size = new System.Drawing.Size(311, 34);
            this.txtSDTKHCongNo.TabIndex = 20;
            // 
            // txtCMNDKHCongNo
            // 
            this.txtCMNDKHCongNo.Enabled = false;
            this.txtCMNDKHCongNo.Location = new System.Drawing.Point(216, 155);
            this.txtCMNDKHCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMNDKHCongNo.Name = "txtCMNDKHCongNo";
            this.txtCMNDKHCongNo.Size = new System.Drawing.Size(311, 34);
            this.txtCMNDKHCongNo.TabIndex = 19;
            // 
            // txtDiaChiKHCongNo
            // 
            this.txtDiaChiKHCongNo.Enabled = false;
            this.txtDiaChiKHCongNo.Location = new System.Drawing.Point(216, 209);
            this.txtDiaChiKHCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiKHCongNo.Name = "txtDiaChiKHCongNo";
            this.txtDiaChiKHCongNo.Size = new System.Drawing.Size(311, 34);
            this.txtDiaChiKHCongNo.TabIndex = 18;
            // 
            // txtSoTienTraHomNay
            // 
            this.txtSoTienTraHomNay.Enabled = false;
            this.txtSoTienTraHomNay.Location = new System.Drawing.Point(300, 495);
            this.txtSoTienTraHomNay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienTraHomNay.Name = "txtSoTienTraHomNay";
            this.txtSoTienTraHomNay.Size = new System.Drawing.Size(311, 34);
            this.txtSoTienTraHomNay.TabIndex = 17;
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhanThanhToan.Enabled = false;
            this.btnXacNhanThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXacNhanThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanThanhToan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXacNhanThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanThanhToan.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnXacNhanThanhToan.IconColor = System.Drawing.Color.White;
            this.btnXacNhanThanhToan.IconSize = 48;
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(0, 551);
            this.btnXacNhanThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Rotation = 0D;
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(620, 102);
            this.btnXacNhanThanhToan.TabIndex = 2;
            this.btnXacNhanThanhToan.Text = "Xác nhận thanh toán";
            this.btnXacNhanThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhanThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnXacNhanThanhToan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 501);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số tiền trả hôm nay:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 2);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 452);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiền còn nợ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên KH:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 694);
            this.panel2.TabIndex = 3;
            // 
            // MACONGNO
            // 
            this.MACONGNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MACONGNO.DataPropertyName = "MACONGNO";
            this.MACONGNO.HeaderText = "Mã Công Nợ";
            this.MACONGNO.MinimumWidth = 6;
            this.MACONGNO.Name = "MACONGNO";
            this.MACONGNO.ReadOnly = true;
            this.MACONGNO.Width = 187;
            // 
            // MaKHCongNo
            // 
            this.MaKHCongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKHCongNo.DataPropertyName = "MAKH";
            this.MaKHCongNo.HeaderText = "Mã KH";
            this.MaKHCongNo.MinimumWidth = 6;
            this.MaKHCongNo.Name = "MaKHCongNo";
            this.MaKHCongNo.ReadOnly = true;
            this.MaKHCongNo.Width = 119;
            // 
            // TenKHCongNo
            // 
            this.TenKHCongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenKHCongNo.DataPropertyName = "TENKH";
            this.TenKHCongNo.HeaderText = "Tên KH";
            this.TenKHCongNo.MinimumWidth = 6;
            this.TenKHCongNo.Name = "TenKHCongNo";
            this.TenKHCongNo.ReadOnly = true;
            this.TenKHCongNo.Width = 130;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            this.TONGTIEN.Width = 163;
            // 
            // TienConNo
            // 
            this.TienConNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TienConNo.DataPropertyName = "TIENCONNO";
            this.TienConNo.HeaderText = "Tiền Còn Nợ";
            this.TienConNo.MinimumWidth = 6;
            this.TienConNo.Name = "TienConNo";
            this.TienConNo.ReadOnly = true;
            this.TienConNo.Width = 190;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.DataPropertyName = "NGAYTRA";
            this.NGAYTRA.HeaderText = "Ngày Trả";
            this.NGAYTRA.MinimumWidth = 6;
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            this.NGAYTRA.Width = 149;
            // 
            // frmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 694);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCongNo";
            this.Text = "frmCongNo";
            this.Load += new System.EventHandler(this.frmCongNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCongNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnXacNhanThanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoTienTraHomNay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTienConNo;
        private System.Windows.Forms.TextBox txtTenKHCongNo;
        private System.Windows.Forms.TextBox txtSDTKHCongNo;
        private System.Windows.Forms.TextBox txtCMNDKHCongNo;
        private System.Windows.Forms.TextBox txtDiaChiKHCongNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.TextBox lblTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACONGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKHCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKHCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienConNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
    }
}