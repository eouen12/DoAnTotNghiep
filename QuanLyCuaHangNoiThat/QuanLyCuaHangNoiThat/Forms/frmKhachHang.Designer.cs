namespace QuanLyCuaHangNoiThat
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLapHD = new FontAwesome.Sharp.IconButton();
            this.btnHuybo = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.MaKHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMNDKHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIKHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(153, 25);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(352, 34);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1237, 193);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(779, 123);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(289, 38);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(779, 64);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(289, 38);
            this.txtCMND.TabIndex = 6;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(284, 123);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(289, 38);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(284, 64);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(289, 38);
            this.txtTenKH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên KH:";
            // 
            // btnLapHD
            // 
            this.btnLapHD.BackColor = System.Drawing.Color.Lime;
            this.btnLapHD.Enabled = false;
            this.btnLapHD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLapHD.FlatAppearance.BorderSize = 2;
            this.btnLapHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHD.ForeColor = System.Drawing.Color.White;
            this.btnLapHD.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnLapHD.IconColor = System.Drawing.Color.White;
            this.btnLapHD.IconSize = 36;
            this.btnLapHD.Location = new System.Drawing.Point(676, 579);
            this.btnLapHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Rotation = 0D;
            this.btnLapHD.Size = new System.Drawing.Size(528, 98);
            this.btnLapHD.TabIndex = 22;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapHD.UseVisualStyleBackColor = false;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Enabled = false;
            this.btnHuybo.FlatAppearance.BorderSize = 2;
            this.btnHuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuybo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuybo.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnHuybo.IconColor = System.Drawing.Color.Red;
            this.btnHuybo.IconSize = 32;
            this.btnHuybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuybo.Location = new System.Drawing.Point(440, 595);
            this.btnHuybo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Rotation = 0D;
            this.btnHuybo.Size = new System.Drawing.Size(155, 66);
            this.btnHuybo.TabIndex = 21;
            this.btnHuybo.Text = "Hủy bỏ";
            this.btnHuybo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.Lime;
            this.btnSua.IconSize = 40;
            this.btnSua.Location = new System.Drawing.Point(256, 595);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(155, 66);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.Lime;
            this.btnThem.IconSize = 40;
            this.btnThem.Location = new System.Drawing.Point(67, 595);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(155, 66);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDSKH);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLapHD);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnHuybo);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1272, 690);
            this.panel3.TabIndex = 24;
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSKH.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKHang,
            this.TenKHang,
            this.SDTKHang,
            this.CMNDKHang,
            this.DIACHIKHang});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKH.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSKH.Location = new System.Drawing.Point(22, 75);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.ReadOnly = true;
            this.dgvDSKH.RowHeadersVisible = false;
            this.dgvDSKH.RowHeadersWidth = 51;
            this.dgvDSKH.RowTemplate.Height = 24;
            this.dgvDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKH.Size = new System.Drawing.Size(1238, 296);
            this.dgvDSKH.TabIndex = 23;
            this.dgvDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellClick);
            // 
            // MaKHang
            // 
            this.MaKHang.DataPropertyName = "MAKH";
            this.MaKHang.HeaderText = "Mã  Khách Hàng";
            this.MaKHang.MinimumWidth = 6;
            this.MaKHang.Name = "MaKHang";
            this.MaKHang.ReadOnly = true;
            this.MaKHang.Width = 243;
            // 
            // TenKHang
            // 
            this.TenKHang.DataPropertyName = "TENKH";
            this.TenKHang.HeaderText = "Tên Khách Hàng";
            this.TenKHang.MinimumWidth = 6;
            this.TenKHang.Name = "TenKHang";
            this.TenKHang.ReadOnly = true;
            this.TenKHang.Width = 245;
            // 
            // SDTKHang
            // 
            this.SDTKHang.DataPropertyName = "SDT";
            this.SDTKHang.HeaderText = "Số Điện Thoại";
            this.SDTKHang.MinimumWidth = 6;
            this.SDTKHang.Name = "SDTKHang";
            this.SDTKHang.ReadOnly = true;
            this.SDTKHang.Width = 216;
            // 
            // CMNDKHang
            // 
            this.CMNDKHang.DataPropertyName = "CMND";
            this.CMNDKHang.HeaderText = "CMND";
            this.CMNDKHang.MinimumWidth = 6;
            this.CMNDKHang.Name = "CMNDKHang";
            this.CMNDKHang.ReadOnly = true;
            this.CMNDKHang.Width = 131;
            // 
            // DIACHIKHang
            // 
            this.DIACHIKHang.DataPropertyName = "DIACHI";
            this.DIACHIKHang.HeaderText = "Địa Chỉ";
            this.DIACHIKHang.MinimumWidth = 6;
            this.DIACHIKHang.Name = "DIACHIKHang";
            this.DIACHIKHang.ReadOnly = true;
            this.DIACHIKHang.Width = 91;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1272, 690);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnHuybo;
        private FontAwesome.Sharp.IconButton btnLapHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMNDKHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIKHang;
    }
}