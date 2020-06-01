namespace QuanLyCuaHangNoiThat
{
    partial class frmHoaDon
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
            this.btnQuy1 = new FontAwesome.Sharp.IconButton();
            this.numUPNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numUPThang = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDNgay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQ2 = new FontAwesome.Sharp.IconButton();
            this.btbQuy3 = new FontAwesome.Sharp.IconButton();
            this.dgvDanhSachHD = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDataChiTietHD = new System.Windows.Forms.DataGridView();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayGiaoHang = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUPNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachHD);
            this.groupBox1.Controls.Add(this.btbQuy3);
            this.groupBox1.Controls.Add(this.btnQ2);
            this.groupBox1.Controls.Add(this.btnQuy1);
            this.groupBox1.Controls.Add(this.numUPNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numUPThang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUDNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc Hóa đơn";
            // 
            // btnQuy1
            // 
            this.btnQuy1.BackColor = System.Drawing.Color.White;
            this.btnQuy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuy1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQuy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuy1.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnQuy1.IconColor = System.Drawing.Color.Black;
            this.btnQuy1.IconSize = 32;
            this.btnQuy1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuy1.Location = new System.Drawing.Point(31, 93);
            this.btnQuy1.Name = "btnQuy1";
            this.btnQuy1.Rotation = 0D;
            this.btnQuy1.Size = new System.Drawing.Size(108, 50);
            this.btnQuy1.TabIndex = 6;
            this.btnQuy1.Text = "Quý 1";
            this.btnQuy1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuy1.UseVisualStyleBackColor = false;
            // 
            // numUPNam
            // 
            this.numUPNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUPNam.Location = new System.Drawing.Point(360, 47);
            this.numUPNam.Maximum = new decimal(new int[] {
            2060,
            0,
            0,
            0});
            this.numUPNam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numUPNam.Name = "numUPNam";
            this.numUPNam.Size = new System.Drawing.Size(59, 26);
            this.numUPNam.TabIndex = 5;
            this.numUPNam.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm:";
            // 
            // numUPThang
            // 
            this.numUPThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUPThang.Location = new System.Drawing.Point(229, 47);
            this.numUPThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUPThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUPThang.Name = "numUPThang";
            this.numUPThang.Size = new System.Drawing.Size(55, 26);
            this.numUPThang.TabIndex = 3;
            this.numUPThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng:";
            // 
            // numUDNgay
            // 
            this.numUDNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDNgay.Location = new System.Drawing.Point(84, 47);
            this.numUDNgay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numUDNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDNgay.Name = "numUDNgay";
            this.numUDNgay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numUDNgay.Size = new System.Drawing.Size(55, 26);
            this.numUDNgay.TabIndex = 1;
            this.numUDNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày:";
            // 
            // btnQ2
            // 
            this.btnQ2.BackColor = System.Drawing.Color.White;
            this.btnQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQ2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ2.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnQ2.IconColor = System.Drawing.Color.Black;
            this.btnQ2.IconSize = 32;
            this.btnQ2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ2.Location = new System.Drawing.Point(169, 93);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Rotation = 0D;
            this.btnQ2.Size = new System.Drawing.Size(108, 50);
            this.btnQ2.TabIndex = 7;
            this.btnQ2.Text = "Quý 2";
            this.btnQ2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQ2.UseVisualStyleBackColor = false;
            // 
            // btbQuy3
            // 
            this.btbQuy3.BackColor = System.Drawing.Color.White;
            this.btbQuy3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbQuy3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btbQuy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbQuy3.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btbQuy3.IconColor = System.Drawing.Color.Black;
            this.btbQuy3.IconSize = 32;
            this.btbQuy3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbQuy3.Location = new System.Drawing.Point(307, 93);
            this.btbQuy3.Name = "btbQuy3";
            this.btbQuy3.Rotation = 0D;
            this.btbQuy3.Size = new System.Drawing.Size(108, 50);
            this.btbQuy3.TabIndex = 8;
            this.btbQuy3.Text = "Quý 3";
            this.btbQuy3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btbQuy3.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachHD
            // 
            this.dgvDanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHD.Location = new System.Drawing.Point(6, 166);
            this.dgvDanhSachHD.Name = "dgvDanhSachHD";
            this.dgvDanhSachHD.Size = new System.Drawing.Size(441, 365);
            this.dgvDanhSachHD.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNgayGiaoHang);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.lblNgayLapHD);
            this.groupBox2.Controls.Add(this.lblTenNhanVien);
            this.groupBox2.Controls.Add(this.lblTenKH);
            this.groupBox2.Controls.Add(this.lblMaHD);
            this.groupBox2.Controls.Add(this.dgvDataChiTietHD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày lập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày giao hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tổng tiền:";
            // 
            // dgvDataChiTietHD
            // 
            this.dgvDataChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataChiTietHD.Location = new System.Drawing.Point(20, 220);
            this.dgvDataChiTietHD.Name = "dgvDataChiTietHD";
            this.dgvDataChiTietHD.Size = new System.Drawing.Size(419, 150);
            this.dgvDataChiTietHD.TabIndex = 6;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(165, 45);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(79, 25);
            this.lblMaHD.TabIndex = 7;
            this.lblMaHD.Text = "Test...";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(210, 90);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(79, 25);
            this.lblTenKH.TabIndex = 8;
            this.lblTenKH.Text = "Test...";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(147, 135);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(79, 25);
            this.lblTenNhanVien.TabIndex = 9;
            this.lblTenNhanVien.Text = "Test...";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Location = new System.Drawing.Point(134, 180);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(79, 25);
            this.lblNgayLapHD.TabIndex = 10;
            this.lblNgayLapHD.Text = "Test...";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(140, 390);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(79, 25);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "Test...";
            // 
            // lblNgayGiaoHang
            // 
            this.lblNgayGiaoHang.AutoSize = true;
            this.lblNgayGiaoHang.Location = new System.Drawing.Point(206, 435);
            this.lblNgayGiaoHang.Name = "lblNgayGiaoHang";
            this.lblNgayGiaoHang.Size = new System.Drawing.Size(79, 25);
            this.lblNgayGiaoHang.TabIndex = 12;
            this.lblNgayGiaoHang.Text = "Test...";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUPNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUPNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUPThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDNgay;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnQuy1;
        private FontAwesome.Sharp.IconButton btbQuy3;
        private FontAwesome.Sharp.IconButton btnQ2;
        private System.Windows.Forms.DataGridView dgvDanhSachHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDataChiTietHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNgayGiaoHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaHD;
    }
}