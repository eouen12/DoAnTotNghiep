namespace QuanLyCuaHangNoiThat
{
    partial class frmSanPham
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
            this.tabControlSanPham = new System.Windows.Forms.TabControl();
            this.tabPageDsSanPham = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDSNPP = new System.Windows.Forms.ComboBox();
            this.cbDSLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTimKiemDSSP = new System.Windows.Forms.TextBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.tabPageQlSanPham = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbQLTimKiemNPP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbQLTimKiemLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTimKiemQLSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModeXoa = new FontAwesome.Sharp.IconButton();
            this.btnModeSua = new FontAwesome.Sharp.IconButton();
            this.btnModeThem = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvQLSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonAnhMHSP = new FontAwesome.Sharp.IconButton();
            this.lbltabQLSPMode = new System.Windows.Forms.Label();
            this.btnHuyBo = new FontAwesome.Sharp.IconButton();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSLTonSp = new System.Windows.Forms.TextBox();
            this.txtGiaBanSp = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.cbNPPSp = new System.Windows.Forms.ComboBox();
            this.cbLoaiSp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgSanPham = new FontAwesome.Sharp.IconPictureBox();
            this.tabControlSanPham.SuspendLayout();
            this.tabPageDsSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.tabPageQlSanPham.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSanPham
            // 
            this.tabControlSanPham.Controls.Add(this.tabPageDsSanPham);
            this.tabControlSanPham.Controls.Add(this.tabPageQlSanPham);
            this.tabControlSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSanPham.ItemSize = new System.Drawing.Size(200, 29);
            this.tabControlSanPham.Location = new System.Drawing.Point(0, 0);
            this.tabControlSanPham.Name = "tabControlSanPham";
            this.tabControlSanPham.SelectedIndex = 0;
            this.tabControlSanPham.Size = new System.Drawing.Size(954, 561);
            this.tabControlSanPham.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlSanPham.TabIndex = 0;
            // 
            // tabPageDsSanPham
            // 
            this.tabPageDsSanPham.Controls.Add(this.groupBox1);
            this.tabPageDsSanPham.Controls.Add(this.dgvDSSP);
            this.tabPageDsSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDsSanPham.Location = new System.Drawing.Point(4, 33);
            this.tabPageDsSanPham.Name = "tabPageDsSanPham";
            this.tabPageDsSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDsSanPham.Size = new System.Drawing.Size(946, 524);
            this.tabPageDsSanPham.TabIndex = 0;
            this.tabPageDsSanPham.Text = "Danh sách sản phẩm";
            this.tabPageDsSanPham.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDSNPP);
            this.groupBox1.Controls.Add(this.cbDSLoaiSP);
            this.groupBox1.Controls.Add(this.txtTimKiemDSSP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(22, 46);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 30);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhà phân phối";
            // 
            // cbDSNPP
            // 
            this.cbDSNPP.FormattingEnabled = true;
            this.cbDSNPP.Location = new System.Drawing.Point(641, 44);
            this.cbDSNPP.Name = "cbDSNPP";
            this.cbDSNPP.Size = new System.Drawing.Size(280, 33);
            this.cbDSNPP.TabIndex = 2;
            // 
            // cbDSLoaiSP
            // 
            this.cbDSLoaiSP.FormattingEnabled = true;
            this.cbDSLoaiSP.Location = new System.Drawing.Point(306, 44);
            this.cbDSLoaiSP.Name = "cbDSLoaiSP";
            this.cbDSLoaiSP.Size = new System.Drawing.Size(280, 33);
            this.cbDSLoaiSP.TabIndex = 1;
            // 
            // txtTimKiemDSSP
            // 
            this.txtTimKiemDSSP.Location = new System.Drawing.Point(55, 46);
            this.txtTimKiemDSSP.Name = "txtTimKiemDSSP";
            this.txtTimKiemDSSP.Size = new System.Drawing.Size(199, 31);
            this.txtTimKiemDSSP.TabIndex = 0;
            this.txtTimKiemDSSP.Tag = "";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSP.Location = new System.Drawing.Point(3, 3);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(940, 518);
            this.dgvDSSP.TabIndex = 0;
            // 
            // tabPageQlSanPham
            // 
            this.tabPageQlSanPham.Controls.Add(this.panel2);
            this.tabPageQlSanPham.Controls.Add(this.panel1);
            this.tabPageQlSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQlSanPham.Location = new System.Drawing.Point(4, 33);
            this.tabPageQlSanPham.Name = "tabPageQlSanPham";
            this.tabPageQlSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQlSanPham.Size = new System.Drawing.Size(946, 524);
            this.tabPageQlSanPham.TabIndex = 1;
            this.tabPageQlSanPham.Text = "Quản lí sản phẩm";
            this.tabPageQlSanPham.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbQLTimKiemNPP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbQLTimKiemLoaiSP);
            this.panel2.Controls.Add(this.txtTimKiemQLSP);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dgvQLSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(500, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 518);
            this.panel2.TabIndex = 1;
            // 
            // cbQLTimKiemNPP
            // 
            this.cbQLTimKiemNPP.FormattingEnabled = true;
            this.cbQLTimKiemNPP.Location = new System.Drawing.Point(167, 176);
            this.cbQLTimKiemNPP.Name = "cbQLTimKiemNPP";
            this.cbQLTimKiemNPP.Size = new System.Drawing.Size(250, 33);
            this.cbQLTimKiemNPP.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tìm kiếm:";
            // 
            // cbQLTimKiemLoaiSP
            // 
            this.cbQLTimKiemLoaiSP.FormattingEnabled = true;
            this.cbQLTimKiemLoaiSP.Location = new System.Drawing.Point(167, 132);
            this.cbQLTimKiemLoaiSP.Name = "cbQLTimKiemLoaiSP";
            this.cbQLTimKiemLoaiSP.Size = new System.Drawing.Size(250, 33);
            this.cbQLTimKiemLoaiSP.TabIndex = 14;
            // 
            // txtTimKiemQLSP
            // 
            this.txtTimKiemQLSP.Location = new System.Drawing.Point(167, 90);
            this.txtTimKiemQLSP.Name = "txtTimKiemQLSP";
            this.txtTimKiemQLSP.Size = new System.Drawing.Size(250, 31);
            this.txtTimKiemQLSP.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nhà phân phối:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModeXoa);
            this.groupBox3.Controls.Add(this.btnModeSua);
            this.groupBox3.Controls.Add(this.btnModeThem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 85);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnModeXoa
            // 
            this.btnModeXoa.BackColor = System.Drawing.Color.Red;
            this.btnModeXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModeXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnModeXoa.IconColor = System.Drawing.Color.Black;
            this.btnModeXoa.IconSize = 24;
            this.btnModeXoa.Location = new System.Drawing.Point(312, 30);
            this.btnModeXoa.Name = "btnModeXoa";
            this.btnModeXoa.Rotation = 0D;
            this.btnModeXoa.Size = new System.Drawing.Size(105, 40);
            this.btnModeXoa.TabIndex = 6;
            this.btnModeXoa.Text = "Xóa";
            this.btnModeXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModeXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModeXoa.UseVisualStyleBackColor = false;
            // 
            // btnModeSua
            // 
            this.btnModeSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModeSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModeSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModeSua.IconColor = System.Drawing.Color.Black;
            this.btnModeSua.IconSize = 24;
            this.btnModeSua.Location = new System.Drawing.Point(171, 30);
            this.btnModeSua.Name = "btnModeSua";
            this.btnModeSua.Rotation = 0D;
            this.btnModeSua.Size = new System.Drawing.Size(105, 40);
            this.btnModeSua.TabIndex = 5;
            this.btnModeSua.Text = "Sửa";
            this.btnModeSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModeSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModeSua.UseVisualStyleBackColor = false;
            // 
            // btnModeThem
            // 
            this.btnModeThem.BackColor = System.Drawing.Color.Lime;
            this.btnModeThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModeThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnModeThem.IconColor = System.Drawing.Color.Black;
            this.btnModeThem.IconSize = 24;
            this.btnModeThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModeThem.Location = new System.Drawing.Point(26, 30);
            this.btnModeThem.Name = "btnModeThem";
            this.btnModeThem.Rotation = 0D;
            this.btnModeThem.Size = new System.Drawing.Size(105, 40);
            this.btnModeThem.TabIndex = 4;
            this.btnModeThem.Text = "Thêm";
            this.btnModeThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModeThem.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Loại sản phẩm:";
            // 
            // dgvQLSanPham
            // 
            this.dgvQLSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSanPham.Location = new System.Drawing.Point(3, 224);
            this.dgvQLSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.dgvQLSanPham.Name = "dgvQLSanPham";
            this.dgvQLSanPham.Size = new System.Drawing.Size(437, 280);
            this.dgvQLSanPham.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonAnhMHSP);
            this.panel1.Controls.Add(this.lbltabQLSPMode);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.imgSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 518);
            this.panel1.TabIndex = 0;
            // 
            // btnChonAnhMHSP
            // 
            this.btnChonAnhMHSP.AutoSize = true;
            this.btnChonAnhMHSP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChonAnhMHSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnhMHSP.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnChonAnhMHSP.IconColor = System.Drawing.Color.Black;
            this.btnChonAnhMHSP.IconSize = 40;
            this.btnChonAnhMHSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnhMHSP.Location = new System.Drawing.Point(3, 190);
            this.btnChonAnhMHSP.Name = "btnChonAnhMHSP";
            this.btnChonAnhMHSP.Rotation = 0D;
            this.btnChonAnhMHSP.Size = new System.Drawing.Size(129, 46);
            this.btnChonAnhMHSP.TabIndex = 6;
            this.btnChonAnhMHSP.Text = "Chọn ảnh";
            this.btnChonAnhMHSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonAnhMHSP.UseVisualStyleBackColor = true;
            // 
            // lbltabQLSPMode
            // 
            this.lbltabQLSPMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabQLSPMode.ForeColor = System.Drawing.Color.Black;
            this.lbltabQLSPMode.Location = new System.Drawing.Point(5, 3);
            this.lbltabQLSPMode.Name = "lbltabQLSPMode";
            this.lbltabQLSPMode.Size = new System.Drawing.Size(153, 38);
            this.lbltabQLSPMode.TabIndex = 5;
            this.lbltabQLSPMode.Text = "Thêm mới";
            this.lbltabQLSPMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Red;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuyBo.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnHuyBo.IconColor = System.Drawing.Color.Black;
            this.btnHuyBo.IconSize = 40;
            this.btnHuyBo.Location = new System.Drawing.Point(331, 446);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Rotation = 0D;
            this.btnHuyBo.Size = new System.Drawing.Size(160, 58);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnXacNhan.IconColor = System.Drawing.Color.Black;
            this.btnXacNhan.IconSize = 40;
            this.btnXacNhan.Location = new System.Drawing.Point(138, 446);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Rotation = 0D;
            this.btnXacNhan.Size = new System.Drawing.Size(160, 58);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSLTonSp);
            this.groupBox2.Controls.Add(this.txtGiaBanSp);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtMaSp);
            this.groupBox2.Controls.Add(this.cbNPPSp);
            this.groupBox2.Controls.Add(this.cbLoaiSp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(138, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtSLTonSp
            // 
            this.txtSLTonSp.Location = new System.Drawing.Point(167, 190);
            this.txtSLTonSp.Name = "txtSLTonSp";
            this.txtSLTonSp.Size = new System.Drawing.Size(172, 31);
            this.txtSLTonSp.TabIndex = 11;
            // 
            // txtGiaBanSp
            // 
            this.txtGiaBanSp.Location = new System.Drawing.Point(167, 140);
            this.txtGiaBanSp.Name = "txtGiaBanSp";
            this.txtGiaBanSp.Size = new System.Drawing.Size(172, 31);
            this.txtGiaBanSp.TabIndex = 10;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(167, 90);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(172, 31);
            this.txtTenSP.TabIndex = 9;
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(167, 40);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(172, 31);
            this.txtMaSp.TabIndex = 8;
            // 
            // cbNPPSp
            // 
            this.cbNPPSp.FormattingEnabled = true;
            this.cbNPPSp.Location = new System.Drawing.Point(167, 290);
            this.cbNPPSp.Name = "cbNPPSp";
            this.cbNPPSp.Size = new System.Drawing.Size(172, 33);
            this.cbNPPSp.TabIndex = 7;
            // 
            // cbLoaiSp
            // 
            this.cbLoaiSp.FormattingEnabled = true;
            this.cbLoaiSp.Location = new System.Drawing.Point(167, 240);
            this.cbLoaiSp.Name = "cbLoaiSp";
            this.cbLoaiSp.Size = new System.Drawing.Size(172, 33);
            this.cbLoaiSp.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nhà phân phối:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Loại sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số lượng tồn: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // imgSanPham
            // 
            this.imgSanPham.BackColor = System.Drawing.Color.Transparent;
            this.imgSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgSanPham.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.imgSanPham.IconColor = System.Drawing.SystemColors.ControlText;
            this.imgSanPham.IconSize = 129;
            this.imgSanPham.Location = new System.Drawing.Point(3, 53);
            this.imgSanPham.Name = "imgSanPham";
            this.imgSanPham.Size = new System.Drawing.Size(129, 137);
            this.imgSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSanPham.TabIndex = 0;
            this.imgSanPham.TabStop = false;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.tabControlSanPham);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.tabControlSanPham.ResumeLayout(false);
            this.tabPageDsSanPham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.tabPageQlSanPham.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSanPham;
        private System.Windows.Forms.TabPage tabPageDsSanPham;
        private System.Windows.Forms.TabPage tabPageQlSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemDSSP;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDSNPP;
        private System.Windows.Forms.ComboBox cbDSLoaiSP;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQLSanPham;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox imgSanPham;
        private FontAwesome.Sharp.IconButton btnHuyBo;
        private FontAwesome.Sharp.IconButton btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSLTonSp;
        private System.Windows.Forms.TextBox txtGiaBanSp;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.ComboBox cbNPPSp;
        private System.Windows.Forms.ComboBox cbLoaiSp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltabQLSPMode;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnModeXoa;
        private FontAwesome.Sharp.IconButton btnModeSua;
        private FontAwesome.Sharp.IconButton btnModeThem;
        private FontAwesome.Sharp.IconButton btnChonAnhMHSP;
        private System.Windows.Forms.TextBox txtTimKiemQLSP;
        private System.Windows.Forms.ComboBox cbQLTimKiemNPP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbQLTimKiemLoaiSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}