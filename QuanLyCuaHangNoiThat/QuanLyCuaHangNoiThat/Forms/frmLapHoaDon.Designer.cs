namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmLapHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDSChiTietHD = new System.Windows.Forms.DataGridView();
            this.ITEMMASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMGIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHAPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonSP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.chkTraGop = new System.Windows.Forms.CheckBox();
            this.txtSoTienTraTrc = new System.Windows.Forms.TextBox();
            this.dateHanTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTietHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSChiTietHD
            // 
            this.dgvDSChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSChiTietHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSChiTietHD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEMMASP,
            this.ITEMSOLUONG,
            this.ITEMGIATIEN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSChiTietHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSChiTietHD.Location = new System.Drawing.Point(12, 12);
            this.dgvDSChiTietHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSChiTietHD.Name = "dgvDSChiTietHD";
            this.dgvDSChiTietHD.ReadOnly = true;
            this.dgvDSChiTietHD.RowHeadersVisible = false;
            this.dgvDSChiTietHD.RowHeadersWidth = 51;
            this.dgvDSChiTietHD.RowTemplate.Height = 24;
            this.dgvDSChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSChiTietHD.Size = new System.Drawing.Size(493, 298);
            this.dgvDSChiTietHD.TabIndex = 0;
            // 
            // ITEMMASP
            // 
            this.ITEMMASP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEMMASP.DataPropertyName = "MASP";
            this.ITEMMASP.HeaderText = "Mã sản phẩm";
            this.ITEMMASP.MinimumWidth = 6;
            this.ITEMMASP.Name = "ITEMMASP";
            this.ITEMMASP.ReadOnly = true;
            // 
            // ITEMSOLUONG
            // 
            this.ITEMSOLUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEMSOLUONG.DataPropertyName = "SOLUONG";
            this.ITEMSOLUONG.HeaderText = "Số lượng";
            this.ITEMSOLUONG.MinimumWidth = 6;
            this.ITEMSOLUONG.Name = "ITEMSOLUONG";
            this.ITEMSOLUONG.ReadOnly = true;
            // 
            // ITEMGIATIEN
            // 
            this.ITEMGIATIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEMGIATIEN.DataPropertyName = "DONGIA";
            this.ITEMGIATIEN.HeaderText = "Giá tiền";
            this.ITEMGIATIEN.MinimumWidth = 6;
            this.ITEMGIATIEN.Name = "ITEMGIATIEN";
            this.ITEMGIATIEN.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnChonSP);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(531, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(496, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDSSanPham);
            this.panel1.Location = new System.Drawing.Point(28, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 297);
            this.panel1.TabIndex = 6;
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.SOLUONGTON,
            this.GIABAN,
            this.TENLOAI,
            this.NHAPP});
            this.dgvDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvDSSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.ReadOnly = true;
            this.dgvDSSanPham.RowHeadersVisible = false;
            this.dgvDSSanPham.RowHeadersWidth = 51;
            this.dgvDSSanPham.RowTemplate.Height = 24;
            this.dgvDSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSanPham.Size = new System.Drawing.Size(440, 297);
            this.dgvDSSanPham.TabIndex = 2;
            this.dgvDSSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSanPham_CellClick);
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.MinimumWidth = 6;
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Width = 179;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.MinimumWidth = 6;
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 189;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.DataPropertyName = "SL_TON";
            this.SOLUONGTON.HeaderText = "Số lượng tồn";
            this.SOLUONGTON.MinimumWidth = 6;
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.ReadOnly = true;
            this.SOLUONGTON.Width = 172;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            this.GIABAN.Width = 121;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Loại sản phẩm";
            this.TENLOAI.MinimumWidth = 6;
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            this.TENLOAI.Width = 192;
            // 
            // NHAPP
            // 
            this.NHAPP.DataPropertyName = "TENNPP";
            this.NHAPP.HeaderText = "Nhà phân phối";
            this.NHAPP.MinimumWidth = 6;
            this.NHAPP.Name = "NHAPP";
            this.NHAPP.ReadOnly = true;
            this.NHAPP.Width = 192;
            // 
            // btnChonSP
            // 
            this.btnChonSP.BackColor = System.Drawing.Color.White;
            this.btnChonSP.Enabled = false;
            this.btnChonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSP.Location = new System.Drawing.Point(343, 394);
            this.btnChonSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(125, 34);
            this.btnChonSP.TabIndex = 5;
            this.btnChonSP.Text = "Chọn";
            this.btnChonSP.UseVisualStyleBackColor = false;
            this.btnChonSP.Click += new System.EventHandler(this.btnChonSP_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(157, 394);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(63, 34);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoLuong_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(157, 50);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(311, 34);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(244, 327);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(262, 36);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "0000";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnXacNhan.IconColor = System.Drawing.Color.White;
            this.btnXacNhan.IconSize = 64;
            this.btnXacNhan.Location = new System.Drawing.Point(18, 590);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Rotation = 0D;
            this.btnXacNhan.Size = new System.Drawing.Size(487, 73);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày giao:";
            // 
            // dtNgayGiao
            // 
            this.dtNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtNgayGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGiao.Location = new System.Drawing.Point(244, 378);
            this.dtNgayGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayGiao.Name = "dtNgayGiao";
            this.dtNgayGiao.Size = new System.Drawing.Size(260, 41);
            this.dtNgayGiao.TabIndex = 10;
            // 
            // chkTraGop
            // 
            this.chkTraGop.AutoSize = true;
            this.chkTraGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTraGop.Location = new System.Drawing.Point(18, 434);
            this.chkTraGop.Name = "chkTraGop";
            this.chkTraGop.Size = new System.Drawing.Size(156, 40);
            this.chkTraGop.TabIndex = 11;
            this.chkTraGop.Text = "Trả góp:";
            this.chkTraGop.UseVisualStyleBackColor = true;
            this.chkTraGop.CheckedChanged += new System.EventHandler(this.chkTraGop_CheckedChanged);
            // 
            // txtSoTienTraTrc
            // 
            this.txtSoTienTraTrc.Enabled = false;
            this.txtSoTienTraTrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienTraTrc.Location = new System.Drawing.Point(244, 472);
            this.txtSoTienTraTrc.Name = "txtSoTienTraTrc";
            this.txtSoTienTraTrc.Size = new System.Drawing.Size(260, 41);
            this.txtSoTienTraTrc.TabIndex = 12;
            // 
            // dateHanTra
            // 
            this.dateHanTra.CustomFormat = "dd/MM/yyyy";
            this.dateHanTra.Enabled = false;
            this.dateHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHanTra.Location = new System.Drawing.Point(244, 529);
            this.dateHanTra.Name = "dateHanTra";
            this.dateHanTra.Size = new System.Drawing.Size(260, 41);
            this.dateHanTra.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hạn trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đặt cọc:";
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 674);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateHanTra);
            this.Controls.Add(this.txtSoTienTraTrc);
            this.Controls.Add(this.chkTraGop);
            this.Controls.Add(this.dtNgayGiao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dgvDSChiTietHD);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLapHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLapHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTietHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSChiTietHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongTien;
        private FontAwesome.Sharp.IconButton btnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHAPP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMMASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMGIATIEN;
        private System.Windows.Forms.DateTimePicker dtNgayGiao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateHanTra;
        private System.Windows.Forms.TextBox txtSoTienTraTrc;
        private System.Windows.Forms.CheckBox chkTraGop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}