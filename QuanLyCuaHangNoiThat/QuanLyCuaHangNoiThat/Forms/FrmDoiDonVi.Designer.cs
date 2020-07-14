namespace QuanLyCuaHangNoiThat.Forms
{
    partial class FrmDoiDonVi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndoi1 = new System.Windows.Forms.Button();
            this.txtMet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapMetVuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndoi2 = new System.Windows.Forms.Button();
            this.txtNhapSoLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhapMetToi = new System.Windows.Forms.TextBox();
            this.txtKQ2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMetToi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mét vuông";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại gạch nền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndoi1);
            this.groupBox1.Controls.Add(this.txtMet);
            this.groupBox1.Controls.Add(this.txtNhapMetVuong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1282, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gạch nền";
            // 
            // btndoi1
            // 
            this.btndoi1.Location = new System.Drawing.Point(950, 55);
            this.btndoi1.Name = "btndoi1";
            this.btndoi1.Size = new System.Drawing.Size(162, 56);
            this.btndoi1.TabIndex = 5;
            this.btndoi1.Text = "Đổi";
            this.btndoi1.UseVisualStyleBackColor = true;
            this.btndoi1.Click += new System.EventHandler(this.btndoi1_Click);
            // 
            // txtMet
            // 
            this.txtMet.Location = new System.Drawing.Point(574, 35);
            this.txtMet.Name = "txtMet";
            this.txtMet.Size = new System.Drawing.Size(307, 30);
            this.txtMet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết Quả";
            // 
            // txtNhapMetVuong
            // 
            this.txtNhapMetVuong.Location = new System.Drawing.Point(238, 86);
            this.txtNhapMetVuong.Name = "txtNhapMetVuong";
            this.txtNhapMetVuong.Size = new System.Drawing.Size(316, 30);
            this.txtNhapMetVuong.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtKQ2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 655);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMetToi);
            this.groupBox2.Controls.Add(this.btndoi2);
            this.groupBox2.Controls.Add(this.txtNhapSoLop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNhapMetToi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1266, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gach tường";
            // 
            // btndoi2
            // 
            this.btndoi2.Location = new System.Drawing.Point(915, 117);
            this.btndoi2.Name = "btndoi2";
            this.btndoi2.Size = new System.Drawing.Size(162, 56);
            this.btndoi2.TabIndex = 6;
            this.btndoi2.Text = "Đổi";
            this.btndoi2.UseVisualStyleBackColor = true;
            this.btndoi2.Click += new System.EventHandler(this.btndoi2_Click);
            // 
            // txtNhapSoLop
            // 
            this.txtNhapSoLop.Location = new System.Drawing.Point(222, 170);
            this.txtNhapSoLop.Name = "txtNhapSoLop";
            this.txtNhapSoLop.Size = new System.Drawing.Size(316, 34);
            this.txtNhapSoLop.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhập số lớp";
            // 
            // txtNhapMetToi
            // 
            this.txtNhapMetToi.Location = new System.Drawing.Point(222, 114);
            this.txtNhapMetToi.Name = "txtNhapMetToi";
            this.txtNhapMetToi.Size = new System.Drawing.Size(316, 34);
            this.txtNhapMetToi.TabIndex = 7;
            // 
            // txtKQ2
            // 
            this.txtKQ2.Enabled = false;
            this.txtKQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ2.Location = new System.Drawing.Point(440, 275);
            this.txtKQ2.Name = "txtKQ2";
            this.txtKQ2.Size = new System.Drawing.Size(307, 34);
            this.txtKQ2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhập mét tới";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60"});
            this.comboBox2.Location = new System.Drawing.Point(222, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 37);
            this.comboBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại gạch tường";
            // 
            // txtMetToi
            // 
            this.txtMetToi.Location = new System.Drawing.Point(558, 60);
            this.txtMetToi.Name = "txtMetToi";
            this.txtMetToi.Size = new System.Drawing.Size(307, 34);
            this.txtMetToi.TabIndex = 6;
            // 
            // FrmDoiDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 655);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDoiDonVi";
            this.Text = "FrmDoiDonVi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMetVuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNhapMetToi;
        private System.Windows.Forms.TextBox txtKQ2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhapSoLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndoi1;
        private System.Windows.Forms.Button btndoi2;
        private System.Windows.Forms.TextBox txtMetToi;
    }
}