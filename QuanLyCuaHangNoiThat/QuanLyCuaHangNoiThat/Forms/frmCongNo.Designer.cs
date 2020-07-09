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
            this.lblCMND = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MACONGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công nợ khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(113, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(195, 29);
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
            this.MaKHCongNo,
            this.TenKHCongNo,
            this.TONGTIENCN,
            this.TIENCONNOCN,
            this.NGAYTRA,
            this.NVLAPCN,
            this.NGAYLAP});
            this.dgvCongNo.Location = new System.Drawing.Point(6, 64);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.RowHeadersVisible = false;
            this.dgvCongNo.RowHeadersWidth = 51;
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.Size = new System.Drawing.Size(447, 464);
            this.dgvCongNo.TabIndex = 0;
            this.dgvCongNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongNo_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTienConNo);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.lblDiaChi);
            this.groupBox2.Controls.Add(this.lblCMND);
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(477, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 546);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết công nợ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTienConNo
            // 
            this.lblTienConNo.AutoSize = true;
            this.lblTienConNo.Location = new System.Drawing.Point(158, 281);
            this.lblTienConNo.Name = "lblTienConNo";
            this.lblTienConNo.Size = new System.Drawing.Size(0, 24);
            this.lblTienConNo.TabIndex = 33;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(134, 242);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 24);
            this.lblTongTien.TabIndex = 32;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AllowDrop = true;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(109, 174);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(0, 24);
            this.lblDiaChi.TabIndex = 31;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(105, 130);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(0, 24);
            this.lblCMND.TabIndex = 30;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(169, 86);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(0, 24);
            this.lblSDT.TabIndex = 29;
            // 
            // lblTenkh
            // 
            this.lblTenkh.AutoSize = true;
            this.lblTenkh.Location = new System.Drawing.Point(168, 42);
            this.lblTenkh.Name = "lblTenkh";
            this.lblTenkh.Size = new System.Drawing.Size(0, 24);
            this.lblTenkh.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapNhatHanTraNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePickerNgayTra);
            this.groupBox3.Location = new System.Drawing.Point(27, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 199);
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
            this.btnCapNhatHanTraNo.Location = new System.Drawing.Point(20, 125);
            this.btnCapNhatHanTraNo.Name = "btnCapNhatHanTraNo";
            this.btnCapNhatHanTraNo.Rotation = 0D;
            this.btnCapNhatHanTraNo.Size = new System.Drawing.Size(158, 54);
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
            this.label7.Location = new System.Drawing.Point(14, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hạn Trả nợ:";
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayTra.Enabled = false;
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(18, 84);
            this.dateTimePickerNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(161, 29);
            this.dateTimePickerNgayTra.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tổng tiền:";
            // 
            // txtSoTienTraHomNay
            // 
            this.txtSoTienTraHomNay.Enabled = false;
            this.txtSoTienTraHomNay.Location = new System.Drawing.Point(229, 356);
            this.txtSoTienTraHomNay.Name = "txtSoTienTraHomNay";
            this.txtSoTienTraHomNay.Size = new System.Drawing.Size(192, 29);
            this.txtSoTienTraHomNay.TabIndex = 17;
            this.txtSoTienTraHomNay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienTraHomNay_KeyPress);
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
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(229, 395);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Rotation = 0D;
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(230, 67);
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
            this.label8.Location = new System.Drawing.Point(225, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số tiền trả hôm nay:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 2);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiền còn nợ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên KH:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 564);
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
            this.MACONGNO.Width = 152;
            // 
            // MaKHCongNo
            // 
            this.MaKHCongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKHCongNo.DataPropertyName = "MAKH";
            this.MaKHCongNo.HeaderText = "Mã KH";
            this.MaKHCongNo.MinimumWidth = 6;
            this.MaKHCongNo.Name = "MaKHCongNo";
            this.MaKHCongNo.ReadOnly = true;
            this.MaKHCongNo.Width = 97;
            // 
            // TenKHCongNo
            // 
            this.TenKHCongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenKHCongNo.DataPropertyName = "TENKH";
            this.TenKHCongNo.HeaderText = "Tên KH";
            this.TenKHCongNo.MinimumWidth = 6;
            this.TenKHCongNo.Name = "TenKHCongNo";
            this.TenKHCongNo.ReadOnly = true;
            this.TenKHCongNo.Width = 106;
            // 
            // TONGTIENCN
            // 
            this.TONGTIENCN.DataPropertyName = "TONGTIEN";
            this.TONGTIENCN.HeaderText = "Tổng tiền (VND)";
            this.TONGTIENCN.Name = "TONGTIENCN";
            this.TONGTIENCN.ReadOnly = true;
            this.TONGTIENCN.Width = 170;
            // 
            // TIENCONNOCN
            // 
            this.TIENCONNOCN.DataPropertyName = "TIENCONNO";
            this.TIENCONNOCN.HeaderText = "Tiền còn nợ (VND)";
            this.TIENCONNOCN.Name = "TIENCONNOCN";
            this.TIENCONNOCN.ReadOnly = true;
            this.TIENCONNOCN.Width = 141;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.DataPropertyName = "NGAYTRA";
            this.NGAYTRA.HeaderText = "Ngày Trả";
            this.NGAYTRA.MinimumWidth = 6;
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            this.NGAYTRA.Width = 110;
            // 
            // NVLAPCN
            // 
            this.NVLAPCN.DataPropertyName = "NV_LAPCN";
            this.NVLAPCN.HeaderText = "Nhân viên lập công nợ";
            this.NVLAPCN.Name = "NVLAPCN";
            this.NVLAPCN.ReadOnly = true;
            this.NVLAPCN.Width = 155;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập công nợ";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            this.NGAYLAP.Width = 160;
            // 
            // frmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 564);
            this.Controls.Add(this.panel2);
            this.Name = "frmCongNo";
            this.Text = "frmCongNo";
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
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACONGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKHCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKHCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIENCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENCONNOCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVLAPCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
    }
}