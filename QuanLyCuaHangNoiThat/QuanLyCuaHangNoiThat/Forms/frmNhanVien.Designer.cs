namespace QuanLyCuaHangNoiThat
{
    partial class frmNhanVien
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
            this.btnXoaNV = new FontAwesome.Sharp.IconButton();
            this.btnSuaNV = new FontAwesome.Sharp.IconButton();
            this.btnThemNV = new FontAwesome.Sharp.IconButton();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONGCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANHDAIDIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.imgNhanVien = new System.Windows.Forms.PictureBox();
            this.btnChonAnhNV = new FontAwesome.Sharp.IconButton();
            this.txtLuongNV = new System.Windows.Forms.TextBox();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtCMNDNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoiNV = new FontAwesome.Sharp.IconButton();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoiMK = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Red;
            this.btnXoaNV.Enabled = false;
            this.btnXoaNV.FlatAppearance.BorderSize = 2;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaNV.IconColor = System.Drawing.Color.Black;
            this.btnXoaNV.IconSize = 32;
            this.btnXoaNV.Location = new System.Drawing.Point(427, 421);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Rotation = 0D;
            this.btnXoaNV.Size = new System.Drawing.Size(179, 59);
            this.btnXoaNV.TabIndex = 17;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNV.Enabled = false;
            this.btnSuaNV.FlatAppearance.BorderSize = 2;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSuaNV.IconColor = System.Drawing.Color.Black;
            this.btnSuaNV.IconSize = 32;
            this.btnSuaNV.Location = new System.Drawing.Point(221, 421);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Rotation = 0D;
            this.btnSuaNV.Size = new System.Drawing.Size(179, 59);
            this.btnSuaNV.TabIndex = 16;
            this.btnSuaNV.Text = "Cập nhật";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.Lime;
            this.btnThemNV.FlatAppearance.BorderSize = 2;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemNV.IconColor = System.Drawing.Color.Black;
            this.btnThemNV.IconSize = 32;
            this.btnThemNV.Location = new System.Drawing.Point(19, 421);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Rotation = 0D;
            this.btnThemNV.Size = new System.Drawing.Size(179, 59);
            this.btnThemNV.TabIndex = 15;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSNhanVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.SDT,
            this.CMND,
            this.EMAIL,
            this.DIACHI,
            this.LUONGCB,
            this.ANHDAIDIEN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(19, 62);
            this.dgvDSNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.ReadOnly = true;
            this.dgvDSNhanVien.RowHeadersVisible = false;
            this.dgvDSNhanVien.RowHeadersWidth = 51;
            this.dgvDSNhanVien.RowTemplate.Height = 24;
            this.dgvDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(587, 322);
            this.dgvDSNhanVien.TabIndex = 14;
            this.dgvDSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhanVien_CellClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 197;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            this.TENNV.Width = 207;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 194;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 129;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 115;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 88;
            // 
            // LUONGCB
            // 
            this.LUONGCB.DataPropertyName = "LUONGCB";
            this.LUONGCB.HeaderText = "Lương căn bản";
            this.LUONGCB.MinimumWidth = 6;
            this.LUONGCB.Name = "LUONGCB";
            this.LUONGCB.ReadOnly = true;
            this.LUONGCB.Width = 170;
            // 
            // ANHDAIDIEN
            // 
            this.ANHDAIDIEN.DataPropertyName = "ANHDAIDIEN";
            this.ANHDAIDIEN.HeaderText = "Ảnh đại diện";
            this.ANHDAIDIEN.MinimumWidth = 6;
            this.ANHDAIDIEN.Name = "ANHDAIDIEN";
            this.ANHDAIDIEN.ReadOnly = true;
            this.ANHDAIDIEN.Visible = false;
            this.ANHDAIDIEN.Width = 141;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.imgNhanVien);
            this.groupBox1.Controls.Add(this.btnChonAnhNV);
            this.groupBox1.Controls.Add(this.txtLuongNV);
            this.groupBox1.Controls.Add(this.txtDiaChiNV);
            this.groupBox1.Controls.Add(this.txtSDTNV);
            this.groupBox1.Controls.Add(this.txtCMNDNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(624, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(629, 633);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(312, 368);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 34);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // imgNhanVien
            // 
            this.imgNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgNhanVien.Location = new System.Drawing.Point(33, 142);
            this.imgNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgNhanVien.Name = "imgNhanVien";
            this.imgNhanVien.Size = new System.Drawing.Size(170, 167);
            this.imgNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNhanVien.TabIndex = 16;
            this.imgNhanVien.TabStop = false;
            // 
            // btnChonAnhNV
            // 
            this.btnChonAnhNV.AutoSize = true;
            this.btnChonAnhNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChonAnhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnhNV.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnChonAnhNV.IconColor = System.Drawing.Color.Black;
            this.btnChonAnhNV.IconSize = 40;
            this.btnChonAnhNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnhNV.Location = new System.Drawing.Point(33, 309);
            this.btnChonAnhNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChonAnhNV.Name = "btnChonAnhNV";
            this.btnChonAnhNV.Rotation = 0D;
            this.btnChonAnhNV.Size = new System.Drawing.Size(197, 57);
            this.btnChonAnhNV.TabIndex = 20;
            this.btnChonAnhNV.Text = "Chọn ảnh";
            this.btnChonAnhNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonAnhNV.UseVisualStyleBackColor = true;
            this.btnChonAnhNV.Click += new System.EventHandler(this.btnChonAnhNV_Click);
            // 
            // txtLuongNV
            // 
            this.txtLuongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongNV.Location = new System.Drawing.Point(312, 468);
            this.txtLuongNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongNV.Name = "txtLuongNV";
            this.txtLuongNV.Size = new System.Drawing.Size(285, 34);
            this.txtLuongNV.TabIndex = 11;
            this.txtLuongNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongNV_KeyPress);
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(33, 438);
            this.txtDiaChiNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiNV.Multiline = true;
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(265, 178);
            this.txtDiaChiNV.TabIndex = 12;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.Location = new System.Drawing.Point(312, 270);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(285, 34);
            this.txtSDTNV.TabIndex = 9;
            this.txtSDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTNV_KeyPress);
            this.txtSDTNV.Validated += new System.EventHandler(this.txtSDTNV_Validated);
            // 
            // txtCMNDNV
            // 
            this.txtCMNDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDNV.Location = new System.Drawing.Point(312, 175);
            this.txtCMNDNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMNDNV.Name = "txtCMNDNV";
            this.txtCMNDNV.Size = new System.Drawing.Size(285, 34);
            this.txtCMNDNV.TabIndex = 8;
            this.txtCMNDNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMNDNV_KeyPress);
            this.txtCMNDNV.Validated += new System.EventHandler(this.txtCMNDNV_Validated);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(312, 82);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(285, 34);
            this.txtTenNV.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(33, 82);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(207, 34);
            this.txtMaNV.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lương căn bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLamMoiNV.FlatAppearance.BorderSize = 2;
            this.btnLamMoiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLamMoiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiNV.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnLamMoiNV.IconColor = System.Drawing.Color.Black;
            this.btnLamMoiNV.IconSize = 40;
            this.btnLamMoiNV.Location = new System.Drawing.Point(327, 516);
            this.btnLamMoiNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Rotation = 0D;
            this.btnLamMoiNV.Size = new System.Drawing.Size(279, 71);
            this.btnLamMoiNV.TabIndex = 19;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiNV.UseVisualStyleBackColor = false;
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnHuyBoNV_Click);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNV.Location = new System.Drawing.Point(164, 9);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(313, 34);
            this.txtTimKiemNV.TabIndex = 13;
            this.txtTimKiemNV.TextChanged += new System.EventHandler(this.txtTimKiemNV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm kiếm:";
            // 
            // btnLamMoiMK
            // 
            this.btnLamMoiMK.AutoSize = true;
            this.btnLamMoiMK.BackColor = System.Drawing.Color.Aqua;
            this.btnLamMoiMK.Enabled = false;
            this.btnLamMoiMK.FlatAppearance.BorderSize = 2;
            this.btnLamMoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiMK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLamMoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiMK.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnLamMoiMK.IconColor = System.Drawing.Color.Black;
            this.btnLamMoiMK.IconSize = 32;
            this.btnLamMoiMK.Location = new System.Drawing.Point(19, 516);
            this.btnLamMoiMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoiMK.Name = "btnLamMoiMK";
            this.btnLamMoiMK.Rotation = 0D;
            this.btnLamMoiMK.Size = new System.Drawing.Size(279, 71);
            this.btnLamMoiMK.TabIndex = 18;
            this.btnLamMoiMK.Text = "Làm mới mật khẩu";
            this.btnLamMoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiMK.UseVisualStyleBackColor = false;
            this.btnLamMoiMK.Click += new System.EventHandler(this.btnLamMoiMK_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 690);
            this.Controls.Add(this.btnLamMoiMK);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.btnLamMoiNV);
            this.Controls.Add(this.dgvDSNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnXoaNV;
        private FontAwesome.Sharp.IconButton btnSuaNV;
        private FontAwesome.Sharp.IconButton btnThemNV;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnLamMoiNV;
        private System.Windows.Forms.TextBox txtLuongNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtCMNDNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLamMoiMK;
        private FontAwesome.Sharp.IconButton btnChonAnhNV;
        private System.Windows.Forms.PictureBox imgNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONGCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANHDAIDIEN;
    }
}