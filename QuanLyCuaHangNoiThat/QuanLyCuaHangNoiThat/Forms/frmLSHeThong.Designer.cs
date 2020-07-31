namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmLSHeThong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnTimAll = new FontAwesome.Sharp.IconButton();
            this.ckTimTheoAllDK = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbViTriThaoTac = new System.Windows.Forms.ComboBox();
            this.cbNVThaoTac = new System.Windows.Forms.ComboBox();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.dgvLSHeThong = new System.Windows.Forms.DataGridView();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnTimAll);
            this.groupBox1.Controls.Add(this.ckTimTheoAllDK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbViTriThaoTac);
            this.groupBox1.Controls.Add(this.cbNVThaoTac);
            this.groupBox1.Controls.Add(this.dtNgayTao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử hệ thống";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.FlatAppearance.BorderSize = 2;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnLamMoi.IconColor = System.Drawing.Color.Black;
            this.btnLamMoi.IconSize = 40;
            this.btnLamMoi.Location = new System.Drawing.Point(785, 34);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Rotation = 0D;
            this.btnLamMoi.Size = new System.Drawing.Size(124, 52);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimAll
            // 
            this.btnTimAll.BackColor = System.Drawing.Color.White;
            this.btnTimAll.Enabled = false;
            this.btnTimAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTimAll.FlatAppearance.BorderSize = 2;
            this.btnTimAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTimAll.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimAll.IconColor = System.Drawing.Color.Black;
            this.btnTimAll.IconSize = 32;
            this.btnTimAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimAll.Location = new System.Drawing.Point(318, 107);
            this.btnTimAll.Name = "btnTimAll";
            this.btnTimAll.Rotation = 0D;
            this.btnTimAll.Size = new System.Drawing.Size(93, 42);
            this.btnTimAll.TabIndex = 7;
            this.btnTimAll.Text = "Tìm";
            this.btnTimAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimAll.UseVisualStyleBackColor = false;
            this.btnTimAll.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ckTimTheoAllDK
            // 
            this.ckTimTheoAllDK.AutoSize = true;
            this.ckTimTheoAllDK.Location = new System.Drawing.Point(40, 120);
            this.ckTimTheoAllDK.Name = "ckTimTheoAllDK";
            this.ckTimTheoAllDK.Size = new System.Drawing.Size(272, 29);
            this.ckTimTheoAllDK.TabIndex = 6;
            this.ckTimTheoAllDK.Text = "Tìm theo tất cả điều kiện:";
            this.ckTimTheoAllDK.UseVisualStyleBackColor = true;
            this.ckTimTheoAllDK.CheckedChanged += new System.EventHandler(this.ckTimTheoAllDK_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nơi thao tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên thao tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày tạo";
            // 
            // cbViTriThaoTac
            // 
            this.cbViTriThaoTac.FormattingEnabled = true;
            this.cbViTriThaoTac.Items.AddRange(new object[] {
            "Sản phẩm",
            "Chỉnh sửa chi tiết hóa đơn",
            "Công nợ",
            "Khách hàng",
            "Lập hóa đơn",
            "Nhân viên",
            "Nhà phân phối"});
            this.cbViTriThaoTac.Location = new System.Drawing.Point(564, 53);
            this.cbViTriThaoTac.Name = "cbViTriThaoTac";
            this.cbViTriThaoTac.Size = new System.Drawing.Size(180, 33);
            this.cbViTriThaoTac.TabIndex = 2;
            this.cbViTriThaoTac.SelectedIndexChanged += new System.EventHandler(this.cbViTriThaoTac_SelectedIndexChanged);
            // 
            // cbNVThaoTac
            // 
            this.cbNVThaoTac.FormattingEnabled = true;
            this.cbNVThaoTac.Location = new System.Drawing.Point(292, 53);
            this.cbNVThaoTac.Name = "cbNVThaoTac";
            this.cbNVThaoTac.Size = new System.Drawing.Size(172, 33);
            this.cbNVThaoTac.TabIndex = 1;
            this.cbNVThaoTac.SelectedIndexChanged += new System.EventHandler(this.cbNVThaoTac_SelectedIndexChanged);
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.CustomFormat = "dd/MM/yyy";
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTao.Location = new System.Drawing.Point(40, 55);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(151, 31);
            this.dtNgayTao.TabIndex = 0;
            this.dtNgayTao.ValueChanged += new System.EventHandler(this.dtNgayTao_ValueChanged);
            // 
            // dgvLSHeThong
            // 
            this.dgvLSHeThong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLSHeThong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLSHeThong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLSHeThong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSHeThong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GHICHU});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLSHeThong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLSHeThong.Location = new System.Drawing.Point(12, 179);
            this.dgvLSHeThong.Name = "dgvLSHeThong";
            this.dgvLSHeThong.ReadOnly = true;
            this.dgvLSHeThong.RowHeadersVisible = false;
            this.dgvLSHeThong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLSHeThong.Size = new System.Drawing.Size(930, 373);
            this.dgvLSHeThong.TabIndex = 1;
            // 
            // GHICHU
            // 
            this.GHICHU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            // 
            // frmLSHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 564);
            this.Controls.Add(this.dgvLSHeThong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLSHeThong";
            this.Text = "frmLSHeThong";
            this.Load += new System.EventHandler(this.frmLSHeThong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHeThong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnTimAll;
        private System.Windows.Forms.CheckBox ckTimTheoAllDK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbViTriThaoTac;
        private System.Windows.Forms.ComboBox cbNVThaoTac;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLSHeThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}