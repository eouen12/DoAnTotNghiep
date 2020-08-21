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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTienConNo = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenkh = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatHanTraNo = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoTienTraHomNay = new System.Windows.Forms.TextBox();
            this.btnXacNhanThanhToan = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MACONGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKHCongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKHCongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIENCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENCONNOCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVLAPCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dgvCongNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(654, 650);
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
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(151, 39);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(259, 34);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCongNo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACONGNO,
            this.MAHD,
            this.MaKHCongNo,
            this.TenKHCongNo,
            this.TONGTIENCN,
            this.TIENCONNOCN,
            this.NGAYTRA,
            this.NVLAPCN,
            this.NGAYLAP});
            this.dgvCongNo.Location = new System.Drawing.Point(8, 79);
            this.dgvCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.RowHeadersVisible = false;
            this.dgvCongNo.RowHeadersWidth = 51;
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.Size = new System.Drawing.Size(638, 563);
            this.dgvCongNo.TabIndex = 0;
            this.dgvCongNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongNo_CellClick);
            this.dgvCongNo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCongNo_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTienConNo);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.lblDiaChi);
            this.groupBox2.Controls.Add(this.lblSDT);
            this.groupBox2.Controls.Add(this.lblTenkh);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoTienTraHomNay);
            this.groupBox2.Controls.Add(this.btnXacNhanThanhToan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(678, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(578, 650);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết công nợ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTienConNo
            // 
            this.lblTienConNo.AutoSize = true;
            this.lblTienConNo.Location = new System.Drawing.Point(211, 312);
            this.lblTienConNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienConNo.Name = "lblTienConNo";
            this.lblTienConNo.Size = new System.Drawing.Size(0, 29);
            this.lblTienConNo.TabIndex = 33;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(179, 264);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 29);
            this.lblTongTien.TabIndex = 32;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AllowDrop = true;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(145, 161);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(0, 29);
            this.lblDiaChi.TabIndex = 31;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(225, 106);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(0, 29);
            this.lblSDT.TabIndex = 29;
            // 
            // lblTenkh
            // 
            this.lblTenkh.AutoSize = true;
            this.lblTenkh.Location = new System.Drawing.Point(224, 52);
            this.lblTenkh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenkh.Name = "lblTenkh";
            this.lblTenkh.Size = new System.Drawing.Size(0, 29);
            this.lblTenkh.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapNhatHanTraNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePickerNgayTra);
            this.groupBox3.Location = new System.Drawing.Point(36, 371);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(256, 252);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gia hạn ngày trả nợ";
            // 
            // btnCapNhatHanTraNo
            // 
            this.btnCapNhatHanTraNo.Enabled = false;
            this.btnCapNhatHanTraNo.FlatAppearance.BorderSize = 2;
            this.btnCapNhatHanTraNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatHanTraNo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCapNhatHanTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatHanTraNo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnCapNhatHanTraNo.IconColor = System.Drawing.Color.Black;
            this.btnCapNhatHanTraNo.IconSize = 40;
            this.btnCapNhatHanTraNo.Location = new System.Drawing.Point(22, 168);
            this.btnCapNhatHanTraNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatHanTraNo.Name = "btnCapNhatHanTraNo";
            this.btnCapNhatHanTraNo.Rotation = 0D;
            this.btnCapNhatHanTraNo.Size = new System.Drawing.Size(211, 66);
            this.btnCapNhatHanTraNo.TabIndex = 25;
            this.btnCapNhatHanTraNo.Text = "Cập nhật";
            this.btnCapNhatHanTraNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatHanTraNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatHanTraNo.UseVisualStyleBackColor = true;
            this.btnCapNhatHanTraNo.Click += new System.EventHandler(this.btnCapNhatHanTraNo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hạn Trả nợ:";
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayTra.Enabled = false;
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(20, 106);
            this.dateTimePickerNgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(213, 34);
            this.dateTimePickerNgayTra.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 264);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tổng tiền:";
            // 
            // txtSoTienTraHomNay
            // 
            this.txtSoTienTraHomNay.Enabled = false;
            this.txtSoTienTraHomNay.Location = new System.Drawing.Point(305, 418);
            this.txtSoTienTraHomNay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienTraHomNay.Name = "txtSoTienTraHomNay";
            this.txtSoTienTraHomNay.Size = new System.Drawing.Size(255, 34);
            this.txtSoTienTraHomNay.TabIndex = 17;
            this.txtSoTienTraHomNay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienTraHomNay_KeyPress);
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhanThanhToan.Enabled = false;
            this.btnXacNhanThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXacNhanThanhToan.FlatAppearance.BorderSize = 2;
            this.btnXacNhanThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanThanhToan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXacNhanThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanThanhToan.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnXacNhanThanhToan.IconColor = System.Drawing.Color.White;
            this.btnXacNhanThanhToan.IconSize = 48;
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(305, 477);
            this.btnXacNhanThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Rotation = 0D;
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(235, 74);
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
            this.label8.Location = new System.Drawing.Point(300, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số tiền trả hôm nay:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 2);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiền còn nợ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
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
            this.panel2.Size = new System.Drawing.Size(1272, 672);
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
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.MinimumWidth = 6;
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Width = 178;
            // 
            // MaKHCongNo
            // 
            this.MaKHCongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKHCongNo.DataPropertyName = "MAKH";
            this.MaKHCongNo.HeaderText = "Mã khách hàng";
            this.MaKHCongNo.MinimumWidth = 6;
            this.MaKHCongNo.Name = "MaKHCongNo";
            this.MaKHCongNo.ReadOnly = true;
            this.MaKHCongNo.Width = 197;
            // 
            // TenKHCongNo
            // 
            this.TenKHCongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenKHCongNo.DataPropertyName = "TENKH";
            this.TenKHCongNo.HeaderText = "Tên khách hàng";
            this.TenKHCongNo.MinimumWidth = 6;
            this.TenKHCongNo.Name = "TenKHCongNo";
            this.TenKHCongNo.ReadOnly = true;
            this.TenKHCongNo.Width = 207;
            // 
            // TONGTIENCN
            // 
            this.TONGTIENCN.DataPropertyName = "TONGTIEN";
            this.TONGTIENCN.HeaderText = "Tổng tiền (VND)";
            this.TONGTIENCN.MinimumWidth = 6;
            this.TONGTIENCN.Name = "TONGTIENCN";
            this.TONGTIENCN.ReadOnly = true;
            this.TONGTIENCN.Width = 210;
            // 
            // TIENCONNOCN
            // 
            this.TIENCONNOCN.DataPropertyName = "TIENCONNO";
            this.TIENCONNOCN.HeaderText = "Tiền còn nợ (VND)";
            this.TIENCONNOCN.MinimumWidth = 6;
            this.TIENCONNOCN.Name = "TIENCONNOCN";
            this.TIENCONNOCN.ReadOnly = true;
            this.TIENCONNOCN.Width = 171;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.DataPropertyName = "NGAYTRA";
            this.NGAYTRA.HeaderText = "Ngày Trả";
            this.NGAYTRA.MinimumWidth = 6;
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            this.NGAYTRA.Width = 136;
            // 
            // NVLAPCN
            // 
            this.NVLAPCN.DataPropertyName = "NV_LAPCN";
            this.NVLAPCN.HeaderText = "Nhân viên lập công nợ";
            this.NVLAPCN.MinimumWidth = 6;
            this.NVLAPCN.Name = "NVLAPCN";
            this.NVLAPCN.ReadOnly = true;
            this.NVLAPCN.Width = 190;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập công nợ";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            this.NGAYLAP.Width = 197;
            // 
            // frmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 672);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCongNo";
            this.Text = "frmCongNo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCongNo_FormClosing);
            this.Load += new System.EventHandler(this.frmCongNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnXacNhanThanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoTienTraHomNay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnCapNhatHanTraNo;
        private System.Windows.Forms.Label lblTienConNo;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACONGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKHCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKHCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIENCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENCONNOCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVLAPCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
    }
}